Imports System
Imports System.Data
Imports System.Data.SqlClient
'Imports System.Text 'por si se incluye la función comprobar DNI

Public Class formBusqueda


    Private Sub formBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim constructor As New SqlConnectionStringBuilder()
        constructor.DataSource = ".\SQLEXPRESS"
        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
        constructor.IntegratedSecurity = True
        constructor.ConnectTimeout = 30
        constructor.UserInstance = True
        SqlConnection1.ConnectionString = constructor.ConnectionString
        SqlConnection1.FireInfoMessageEventOnUserErrors = False


        Dim micomandoObtenerResidencia As SqlCommand
        Dim dr As SqlDataReader = Nothing

        micomandoObtenerResidencia = New SqlCommand("SELECT * FROM RESIDENCIA", SqlConnection1)

        Try
            cbxCentroResidencial.Items.Add("")

            SqlConnection1.Open()

            dr = micomandoObtenerResidencia.ExecuteReader(CommandBehavior.Default)

            While dr.Read
                'primero damos a la variable value el nombre de la columna que tiene el nombre de la Residencia
                Dim value As Object = dr.Item("RESIDENCIA")
                'Si está, recuperamos el valor y lo mostramos en el textbox correspondiente
                If value IsNot DBNull.Value Then
                    cbxCentroResidencial.Items.Add(value).ToString()
                End If
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        btActualizarRegistro.Enabled = False
        btTraslado.Enabled = False
        btHistoricoTraslados.Enabled = False

    End Sub


#Region "BUSCAR"
    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click

        Dim ds As New DataSet
        Dim miConsulta As SqlCommand
        Dim buscandoNombreResidencia As SqlCommand
        Dim encontradoNombreResidencia As String
        Dim buscandoNumeroExpdte As SqlCommand
        Dim encontradoNumeroExpdte As String
        Dim buscandoEnPlaza As SqlCommand
        Dim encontradoEnPlaza As Integer
        Dim contadorEnPlaza As Integer
        Dim metodo1 As Boolean 'lo usaremos para saber si está en la tabla PLAZA
        Dim plazaEnReserva As Boolean = False 'nos servirá en la búsqueda para indicar que la plaza está reservada, no ocupada
        Dim sinResultados As Boolean = False

        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        btActualizarRegistro.Enabled = True
        btTraslado.Enabled = True
        btHistoricoTraslados.Enabled = True

        'construimos la conexión a la base de datos
        Dim constructor As New SqlConnectionStringBuilder()
        constructor.DataSource = ".\SQLEXPRESS"
        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
        constructor.IntegratedSecurity = True
        constructor.ConnectTimeout = 30
        constructor.UserInstance = True
        Me.SqlConnection1.ConnectionString = constructor.ConnectionString
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False

        Try

            'abrimos aquí la conexión porque es necesaria para comprobar el criterio de búsqueda
            SqlConnection1.Open()

            'comprobamos el criterio de búsqueda
            If rbExpdteBuscar.Checked Then
                'comprobamos si esta de alta o no. Esto variara nuestro select
                buscandoEnPlaza = New SqlCommand("SELECT COUNT('EXPDTE') FROM PLAZA WHERE EXPDTE='" & tbBuscar.Text & "'", SqlConnection1)
                contadorEnPlaza = buscandoEnPlaza.ExecuteScalar
                If contadorEnPlaza > 0 Then
                    metodo1 = True
                    miConsulta = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, USUARIOS.VIA_ACCESO, USUARIOS.ISE, USUARIOS.OBSERVACIONES, USUARIOS.PENDIENTE_CITAR, USUARIOS.PENDIENTE_INGRESAR, PLAZA.CodResidencia, PLAZA.TIPO_PLAZA, PLAZA.RESERVA FROM USUARIOS, PLAZA WHERE USUARIOS.EXPDTE='" & tbBuscar.Text & "' AND USUARIOS.EXPDTE=PLAZA.EXPDTE", SqlConnection1)
                Else
                    metodo1 = False
                    miConsulta = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, USUARIOS.VIA_ACCESO, USUARIOS.ISE, USUARIOS.OBSERVACIONES, USUARIOS.PENDIENTE_CITAR, USUARIOS.PENDIENTE_INGRESAR FROM USUARIOS WHERE USUARIOS.EXPDTE='" & tbBuscar.Text & "'", SqlConnection1)
                End If
            ElseIf rbDNIBuscar.Checked Then
                'buscamos el número de expediente al que corresponde el DNI introducido
                buscandoNumeroExpdte = New SqlCommand("SELECT EXPDTE FROM USUARIOS WHERE DNI='" & _
                                                 tbBuscar.Text & "'", SqlConnection1)
                encontradoNumeroExpdte = buscandoNumeroExpdte.ExecuteScalar
                'comprobamos si esta de alta o no. Esto variara nuestro select
                buscandoEnPlaza = New SqlCommand("SELECT COUNT('EXPDTE') FROM PLAZA WHERE EXPDTE='" & encontradoNumeroExpdte & "'", SqlConnection1)
                contadorEnPlaza = buscandoEnPlaza.ExecuteScalar
                If contadorEnPlaza > 0 Then
                    metodo1 = True
                    miConsulta = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, USUARIOS.VIA_ACCESO, USUARIOS.ISE, USUARIOS.OBSERVACIONES, USUARIOS.PENDIENTE_CITAR, USUARIOS.PENDIENTE_INGRESAR, PLAZA.CodResidencia, PLAZA.TIPO_PLAZA, PLAZA.RESERVA FROM USUARIOS, PLAZA WHERE USUARIOS.EXPDTE='" & encontradoNumeroExpdte & "' AND USUARIOS.EXPDTE=PLAZA.EXPDTE", SqlConnection1)
                Else
                    metodo1 = False
                    miConsulta = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, USUARIOS.VIA_ACCESO, USUARIOS.ISE, USUARIOS.OBSERVACIONES, USUARIOS.PENDIENTE_CITAR, USUARIOS.PENDIENTE_INGRESAR FROM USUARIOS WHERE USUARIOS.EXPDTE='" & encontradoNumeroExpdte & "'", SqlConnection1)
                End If
            ElseIf rbNombreBuscar.Checked Then
                'vamos a mostrar un cuadro de dialogo con todos los resultados que coinciden con la búsqueda
                Dim miConsultaNombre As SqlCommand
                miConsultaNombre = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI FROM USUARIOS WHERE USUARIOS.NOMBRE LIKE '%" & tbBuscar.Text & "%'", SqlConnection1)
                Dim consulta5 As New SqlDataAdapter(miConsultaNombre)
                Dim ds5 As New DataSet
                consulta5.Fill(ds5)
                formEleccionBusquedaPorNombre.dgvResultadoBusquedaPorNombre.DataSource = ds5.Tables(0)
                formEleccionBusquedaPorNombre.ShowDialog()
                'ahora que hemos seleccionado el regitro en el cuadro de dialogo hacemos la consulta
                'comprobamos si esta de alta o no. Esto variara nuestro select
                buscandoEnPlaza = New SqlCommand("SELECT COUNT('EXPDTE') FROM PLAZA WHERE EXPDTE='" & registroSeleccionado & "'", SqlConnection1)
                contadorEnPlaza = buscandoEnPlaza.ExecuteScalar
                If contadorEnPlaza > 0 Then
                    metodo1 = True
                    miConsulta = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, USUARIOS.VIA_ACCESO, USUARIOS.ISE, USUARIOS.OBSERVACIONES, USUARIOS.PENDIENTE_CITAR, USUARIOS.PENDIENTE_INGRESAR, PLAZA.CodResidencia, PLAZA.TIPO_PLAZA, PLAZA.RESERVA FROM USUARIOS, PLAZA WHERE USUARIOS.EXPDTE='" & registroSeleccionado & "' AND USUARIOS.EXPDTE=PLAZA.EXPDTE", SqlConnection1)
                Else
                    metodo1 = False
                    miConsulta = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, USUARIOS.VIA_ACCESO, USUARIOS.ISE, USUARIOS.OBSERVACIONES, USUARIOS.PENDIENTE_CITAR, USUARIOS.PENDIENTE_INGRESAR FROM USUARIOS WHERE USUARIOS.EXPDTE='" & registroSeleccionado & "'", SqlConnection1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'almacenamos la consulta
        Dim consulta As New SqlDataAdapter(miConsulta)

        'liberamos recursos y limpiamos el dataset para evitar problemas
        ds.Dispose()
        ds.Clear()
        Try
            'llenamos el dataset con el resultado de la consulta
            consulta.Fill(ds)


            'llenamos los textbox con sus datos correspondientes (A EXCEPCION DE FECHA_INGRESO Y FECHA_BAJA)
            If IsDBNull(ds.Tables(0).Rows(0)("EXPDTE")) Then tbExpdteBuscar.Text = "" Else tbExpdteBuscar.Text = ds.Tables(0).Rows(0)("EXPDTE")
            If IsDBNull(ds.Tables(0).Rows(0)("NOMBRE")) Then tbNombreBuscar.Text = "" Else tbNombreBuscar.Text = ds.Tables(0).Rows(0)("NOMBRE")
            If IsDBNull(ds.Tables(0).Rows(0)("DNI")) Then tbDNIBuscar.Text = "" Else tbDNIBuscar.Text = ds.Tables(0).Rows(0)("DNI")
            If IsDBNull(ds.Tables(0).Rows(0)("VIA_ACCESO")) Then tbViaAccesoBuscar.Text = "" Else tbViaAccesoBuscar.Text = ds.Tables(0).Rows(0)("VIA_ACCESO")
            If IsDBNull(ds.Tables(0).Rows(0)("ISE")) Then tbISEBuscar.Text = "" Else tbISEBuscar.Text = ds.Tables(0).Rows(0)("ISE")
            If IsDBNull(ds.Tables(0).Rows(0)("OBSERVACIONES")) Then tbObservacionesBuscar.Text = "" Else tbObservacionesBuscar.Text = ds.Tables(0).Rows(0)("OBSERVACIONES")
            If IsDBNull(ds.Tables(0).Rows(0)("PENDIENTE_CITAR")) Then cbxPendienteCitar.Text = "" Else cbxPendienteCitar.Text = ds.Tables(0).Rows(0)("PENDIENTE_CITAR")
            If IsDBNull(ds.Tables(0).Rows(0)("PENDIENTE_INGRESAR")) Then cbxPendienteIngresar.Text = "" Else cbxPendienteIngresar.Text = ds.Tables(0).Rows(0)("PENDIENTE_INGRESAR")
            cbxCentroResidencial.Text = ""
            cbxTipoPlaza.Text = ""

            If metodo1 = True Then
                'vamos a obtener el nombre de la residencia a partir de la consulta
                buscandoNombreResidencia = New SqlCommand("SELECT RESIDENCIA FROM RESIDENCIA WHERE CodResidencia='" & _
                                                        ds.Tables(0).Rows(0)("CodResidencia") & "'", SqlConnection1)
                encontradoNombreResidencia = buscandoNombreResidencia.ExecuteScalar

                If IsDBNull(ds.Tables(0).Rows(0)("CodResidencia")) Then cbxCentroResidencial.Text = "" Else cbxCentroResidencial.Text = encontradoNombreResidencia
                If IsDBNull(ds.Tables(0).Rows(0)("TIPO_PLAZA")) Then cbxTipoPlaza.Text = "" Else cbxTipoPlaza.Text = ds.Tables(0).Rows(0)("TIPO_PLAZA")
                If IsDBNull(ds.Tables(0).Rows(0)("RESERVA")) Then tbReservaBuscar.Text = "" Else tbReservaBuscar.Text = ds.Tables(0).Rows(0)("RESERVA")

            End If
        Catch ex As Exception
            MessageBox.Show("No se encontraron coincidencias")
            tbExpdteBuscar.Text = ""
            tbDNIBuscar.Text = ""
            tbISEBuscar.Text = ""
            tbNombreBuscar.Text = ""
            tbObservacionesBuscar.Text = ""
            tbReservaBuscar.Text = ""
            tbViaAccesoBuscar.Text = ""
            cbxPendienteCitar.Text = ""
            cbxPendienteIngresar.Text = ""
            cbxTipoPlaza.Text = ""
            cbxCentroResidencial.Text = ""
            sinResultados = True
        End Try

        '-------------------------------------------------------------------------------------------------------

        'consultamos la tabla INGRESO y recuperamos el dato FECHA_INGRESO actual (en vigor)
        Dim buscandoDatoAlta As SqlCommand
        Dim contador As Integer
        Dim consultaIngreso As SqlCommand
        Dim ds2 As New DataSet
        Dim fechaIngreso As String

        Try
            If rbExpdteBuscar.Checked Then
                buscandoDatoAlta = New SqlCommand("SELECT COUNT('EXPDTE') FROM INGRESO WHERE INGRESO.EXPDTE='" & tbBuscar.Text & "'", SqlConnection1)
                contador = buscandoDatoAlta.ExecuteScalar
                If contador > 0 Then
                    consultaIngreso = New SqlCommand("SELECT INGRESO.FECHA_INGRESO FROM USUARIOS, INGRESO WHERE USUARIOS.EXPDTE=INGRESO.EXPDTE AND USUARIOS.EXPDTE='" & tbBuscar.Text & "' ORDER BY INGRESO.FECHA_INGRESO DESC", SqlConnection1)
                    Dim ejecutandoConsultaIngreso As New SqlDataAdapter(consultaIngreso)
                    ejecutandoConsultaIngreso.Fill(ds2)
                    fechaIngreso = ds2.Tables(0).Rows(0)("FECHA_INGRESO")
                Else
                    dtpFechaIngreso.Text = ""
                    plazaEnReserva = True
                End If
            ElseIf rbDNIBuscar.Checked Then
                'ejecutamos la instrucción
                buscandoDatoAlta = New SqlCommand("SELECT COUNT('EXPDTE') FROM INGRESO WHERE INGRESO.EXPDTE='" & encontradoNumeroExpdte & "'", SqlConnection1)
                contador = buscandoDatoAlta.ExecuteScalar
                If contador > 0 Then
                    consultaIngreso = New SqlCommand("SELECT INGRESO.FECHA_INGRESO FROM USUARIOS, INGRESO WHERE USUARIOS.EXPDTE=INGRESO.EXPDTE AND USUARIOS.EXPDTE='" & encontradoNumeroExpdte & "' ORDER BY INGRESO.FECHA_INGRESO DESC", SqlConnection1)
                    Dim ejecutandoConsultaIngreso As New SqlDataAdapter(consultaIngreso)
                    ejecutandoConsultaIngreso.Fill(ds2)
                    fechaIngreso = ds2.Tables(0).Rows(0)("FECHA_INGRESO")
                Else
                    dtpFechaIngreso.Text = ""
                    plazaEnReserva = True
                End If
            ElseIf rbNombreBuscar.Checked Then
                buscandoDatoAlta = New SqlCommand("SELECT COUNT('EXPDTE') FROM INGRESO WHERE INGRESO.EXPDTE='" & registroSeleccionado & "'", SqlConnection1)
                contador = buscandoDatoAlta.ExecuteScalar
                If contador > 0 Then
                    consultaIngreso = New SqlCommand("SELECT INGRESO.FECHA_INGRESO FROM USUARIOS, INGRESO WHERE USUARIOS.EXPDTE=INGRESO.EXPDTE AND USUARIOS.EXPDTE='" & registroSeleccionado & "' ORDER BY INGRESO.FECHA_INGRESO DESC", SqlConnection1)
                    Dim ejecutandoConsultaIngreso As New SqlDataAdapter(consultaIngreso)
                    ejecutandoConsultaIngreso.Fill(ds2)
                    fechaIngreso = ds2.Tables(0).Rows(0)("FECHA_INGRESO")
                Else
                    dtpFechaIngreso.Text = ""
                    plazaEnReserva = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        '-------------------------------------------------------------------------------------------------------------

        'consultamos la tabla BAJA y recuperamos el dato FECHA_BAJA actual (en vigor)
        Dim buscandoDatoBaja As SqlCommand
        Dim contador2 As Integer
        Dim consultaBaja As SqlCommand
        Dim ds3 As New DataSet
        Dim fechaBaja As String

        Try
            If rbExpdteBuscar.Checked Then
                buscandoDatoBaja = New SqlCommand("SELECT COUNT('EXPDTE') FROM BAJA WHERE BAJA.EXPDTE='" & tbBuscar.Text & "'", SqlConnection1)
                contador2 = buscandoDatoBaja.ExecuteScalar
                If contador2 > 0 Then
                    consultaBaja = New SqlCommand("SELECT BAJA.FECHA_BAJA FROM USUARIOS, BAJA WHERE USUARIOS.EXPDTE=BAJA.EXPDTE AND USUARIOS.EXPDTE='" & tbBuscar.Text & "' ORDER BY BAJA.FECHA_BAJA DESC", SqlConnection1)
                    Dim ejecutandoConsultaBaja As New SqlDataAdapter(consultaBaja)
                    ejecutandoConsultaBaja.Fill(ds3)
                    fechaBaja = ds3.Tables(0).Rows(0)("FECHA_BAJA")
                Else
                    dtpFechaBaja.Text = ""
                End If
            ElseIf rbDNIBuscar.Checked Then
                buscandoDatoBaja = New SqlCommand("SELECT COUNT('EXPDTE') FROM BAJA WHERE BAJA.EXPDTE='" & encontradoNumeroExpdte & "'", SqlConnection1)
                contador2 = buscandoDatoBaja.ExecuteScalar
                If contador2 > 0 Then
                    consultaBaja = New SqlCommand("SELECT BAJA.FECHA_BAJA FROM USUARIOS, BAJA WHERE USUARIOS.EXPDTE=BAJA.EXPDTE AND USUARIOS.EXPDTE='" & encontradoNumeroExpdte & "' ORDER BY BAJA.FECHA_BAJA DESC", SqlConnection1)
                    Dim ejecutandoConsultaBaja As New SqlDataAdapter(consultaBaja)
                    ejecutandoConsultaBaja.Fill(ds3)
                    fechaBaja = ds3.Tables(0).Rows(0)("FECHA_BAJA")
                Else
                    dtpFechaBaja.Text = ""
                End If
            ElseIf rbNombreBuscar.Checked Then
                buscandoDatoBaja = New SqlCommand("SELECT COUNT('EXPDTE') FROM BAJA WHERE BAJA.EXPDTE='" & registroSeleccionado & "'", SqlConnection1)
                contador2 = buscandoDatoBaja.ExecuteScalar
                If contador2 > 0 Then
                    consultaBaja = New SqlCommand("SELECT BAJA.FECHA_BAJA FROM USUARIOS, BAJA WHERE USUARIOS.EXPDTE=BAJA.EXPDTE AND USUARIOS.EXPDTE='" & registroSeleccionado & "' ORDER BY BAJA.FECHA_BAJA DESC", SqlConnection1)
                    Dim ejecutandoConsultaBaja As New SqlDataAdapter(consultaBaja)
                    ejecutandoConsultaBaja.Fill(ds3)
                    fechaBaja = ds3.Tables(0).Rows(0)("FECHA_BAJA")
                Else
                    dtpFechaBaja.Text = ""
                End If

            End If

            '--------------------------

            'comprobamos las fechas para saber si esta de baja definitiva o sigue de alta
            If Convert.ToDateTime(fechaIngreso) > Convert.ToDateTime(fechaBaja) Then
                dtpFechaIngreso.Text = fechaIngreso
                dtpFechaBaja.Text = ""
                lbCerrado.Visible = False
                lklbReapertura.Visible = False
                btActualizarRegistro.Enabled = True
                btTraslado.Enabled = True
            ElseIf Convert.ToDateTime(fechaIngreso) <= Convert.ToDateTime(fechaBaja) Then
                dtpFechaIngreso.Text = fechaIngreso
                dtpFechaBaja.Text = fechaBaja
                'indicamos que el expediente está cerrado.
                lbCerrado.Visible = True
                'mostramos la posibilidad de reabrirlo sólo mediante el botón Trasladar/Actualizar del form1
                If Me.Text = "Trasladar/Actualizar Registros" Then
                    lklbReapertura.Visible = True
                    btActualizarRegistro.Enabled = False
                    btTraslado.Enabled = False
                End If
            End If

            'aqui voy a mostrar un aviso para aquellas plazas que sólo están reservadas
            If plazaEnReserva = True Then
                lklbReapertura.Visible = False
                'esto lo pongo, para no mostrar las etiquetas ni activar los controles, si la búsqueda no devuelve resultados
                If sinResultados = True Then
                    lbCerrado.Visible = False
                    GroupBox1.Enabled = False
                    GroupBox2.Enabled = False
                    btActualizarRegistro.Enabled = False
                    btHistoricoTraslados.Enabled = False
                    btTraslado.Enabled = False
                Else
                    lbCerrado.Text = "Plaza RESERVADA pendiente de formalizar"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

    End Sub
#End Region

#Region "ACTUALIZAR REGISTRO"
    Private Sub btActualizarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btActualizarRegistro.Click

        Dim miComandoActualizarUsuarios As SqlCommand
        Dim actualizarUsuarios As Integer
        Dim buscandoCodResidenciaOrigen As SqlCommand
        Dim encontradoCodResidenciaOrigen As Integer


        miComandoActualizarUsuarios = New SqlCommand("UPDATE USUARIOS SET USUARIOS.NOMBRE='" & tbNombreBuscar.Text & "', USUARIOS.DNI='" & tbDNIBuscar.Text & "', USUARIOS.VIA_ACCESO='" & tbViaAccesoBuscar.Text & "', USUARIOS.ISE='" & tbISEBuscar.Text & "', USUARIOS.OBSERVACIONES='" & tbObservacionesBuscar.Text & "', USUARIOS.PENDIENTE_CITAR='" & cbxPendienteCitar.Text & "', USUARIOS.PENDIENTE_INGRESAR='" & cbxPendienteIngresar.Text & "' WHERE USUARIOS.EXPDTE='" & tbExpdteBuscar.Text & "';", SqlConnection1)

        Dim constructor As New SqlConnectionStringBuilder()
        constructor.DataSource = ".\SQLEXPRESS"
        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
        constructor.IntegratedSecurity = True
        constructor.ConnectTimeout = 30
        constructor.UserInstance = True
        Me.SqlConnection1.ConnectionString = constructor.ConnectionString
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False

        Try

            SqlConnection1.Open()

            'AHORA MISMO NO QUIERO UTILIZARLO
            'If Verificar_NIF(tbDNIBuscar.Text) = False Then
            '    MsgBox("El formato correcto de DNI es 12345678A")
            '    SqlConnection1.Close()
            '    Exit Sub
            'End If



            'vamos a obtener el CodResidencia a partir de lo introducido en el combobox de Residencia Origen
            buscandoCodResidenciaOrigen = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA='" & _
                                                    cbxCentroResidencial.Text & "'", SqlConnection1)
            encontradoCodResidenciaOrigen = buscandoCodResidenciaOrigen.ExecuteScalar

            'actualizo la tabla USUARIOS
            actualizarUsuarios = miComandoActualizarUsuarios.ExecuteNonQuery


            'actualizo la tabla BAJA si se ha introducido fecha de baja
            If Not (String.IsNullOrWhiteSpace(dtpFechaBaja.Text)) Then
                'compruebo si la fecha es válida
                If IsDate(dtpFechaBaja.Text) Then
                    'compruebo que la fecha de baja es superior o igual a la de ingreso
                    If Convert.ToDateTime(dtpFechaBaja.Text) >= Convert.ToDateTime(dtpFechaIngreso.Text) Then


                        'Como en la tabla BAJA, los tres campos son Clave Primaria, y queremos guardar registros, no hay que hacer UPDATE, directamente INSERT
                        Dim micomandoInsertarBaja As SqlCommand
                        Dim registrandoBaja As Integer

                        Try
                            'damos la instruccion al comando
                            micomandoInsertarBaja = New SqlCommand("INSERT INTO BAJA (EXPDTE, CodResidencia, FECHA_BAJA) VALUES ('" & tbExpdteBuscar.Text & _
                                                              "', '" & encontradoCodResidenciaOrigen & "', '" & dtpFechaBaja.Text & "');", _
                                                               SqlConnection1)

                            Dim caption As String = "Atención"
                            'preguntamos si quiere continuar, ya que se va a cerrar el expediente
                            If (MessageBox.Show("Esto dará por cerrado el expediente. ¿Desea continuar?", caption, MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                                'ejecutamos la baja
                                registrandoBaja = micomandoInsertarBaja.ExecuteNonQuery()
                            Else
                                SqlConnection1.Close()
                                Exit Sub
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try

                        'ahora vamos a eliminar el registro de la tabla PLAZA
                        Dim micomandoEliminarRegistro As SqlCommand
                        Dim eliminarRegistro As Integer

                        micomandoEliminarRegistro = New SqlCommand("DELETE FROM PLAZA WHERE EXPDTE='" & tbExpdteBuscar.Text & "'", SqlConnection1)
                        eliminarRegistro = micomandoEliminarRegistro.ExecuteNonQuery

                    Else
                        MessageBox.Show("La fecha de baja no puede ser inferior a la de ingreso")
                        SqlConnection1.Close()
                        Exit Sub
                    End If

                Else
                    MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                    SqlConnection1.Close()
                    Exit Sub
                End If
            End If
          
            MessageBox.Show("Usuario actualizado con éxito")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        Me.Close()
        Call Form1.mirarPendientes()
    End Sub
#End Region

#Region "TRASLADO DE CENTRO"
    Private Sub btTraslado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTraslado.Click
        If tbExpdteBuscar.Text = "" Then
            MessageBox.Show("No se ha seleccionado ningún expediente para trasladar")
        Else
            formTraslado.Show()
            formTraslado.tbExpedienteTraslado.Text = tbExpdteBuscar.Text
            formTraslado.cbxResidenciaOrigen.Text = cbxCentroResidencial.SelectedItem
            formTraslado.cbxTipoPlazaOrigen.Text = cbxTipoPlaza.SelectedItem
        End If
        Me.Close()
    End Sub
#End Region

#Region "REAPERTURA EXPEDIENTE"
    Private Sub lklbReapertura_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbReapertura.LinkClicked
        formReapertura.Show()
        formReapertura.tbExpedienteReapertura.Text = tbExpdteBuscar.Text
        formReapertura.tbNombreReapertura.Text = tbNombreBuscar.Text
        Me.Close()
    End Sub
#End Region

#Region "HISTORICO DE TRASLADOS"
    Private Sub btHistoricoTraslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHistoricoTraslados.Click

        Dim buscandoIngresos As New SqlDataAdapter("SELECT RESIDENCIA.RESIDENCIA, INGRESO.FECHA_INGRESO FROM RESIDENCIA, INGRESO WHERE RESIDENCIA.CodResidencia=INGRESO.CodResidencia AND INGRESO.EXPDTE ='" & tbExpdteBuscar.Text & "' ORDER BY INGRESO.FECHA_INGRESO ASC", SqlConnection1)
        Dim dsIngreso As New DataSet
        Dim buscandoBajas As New SqlDataAdapter("SELECT RESIDENCIA.RESIDENCIA, BAJA.FECHA_BAJA FROM RESIDENCIA, BAJA WHERE RESIDENCIA.CodResidencia=BAJA.CodResidencia AND BAJA.EXPDTE ='" & tbExpdteBuscar.Text & "' ORDER BY BAJA.FECHA_BAJA ASC", SqlConnection1)
        Dim dsBaja As New DataSet

        Try

            SqlConnection1.Open()

            buscandoIngresos.Fill(dsIngreso)
            buscandoBajas.Fill(dsBaja)

            formHistoricoTraslados.Show()
            formHistoricoTraslados.tbExpdteHistoricoT.Text = tbExpdteBuscar.Text
            formHistoricoTraslados.tbNombreHistoricoT.Text = tbNombreBuscar.Text
            formHistoricoTraslados.dgvIngresosHistoricoT.DataSource = dsIngreso.Tables(0)
            formHistoricoTraslados.dgvBajasHistoricoT.DataSource = dsBaja.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try
    End Sub
#End Region


    'funciones para verificar NIF

    'Private Function CalculaNIF(ByVal strA As String) As String
    '    '----------------------------------------------------------------------
    '    ' Calcular la letra del NIF
    '    ' Código original adaptado a Visual Basic                   (13/Sep/95)
    '    ' Adaptado a Visual Basic .NET (VB 9.0/2008)                (09/May/08)
    '    ' y convertido en función que devuelve el NIF correcto
    '    '----------------------------------------------------------------------
    '    Const cCADENA As String = "TRWAGMYFPDXBNJZSQVHLCKE"
    '    Const cNUMEROS As String = "0123456789"
    '    Dim a, b, c, NIF As Integer
    '    Dim sb As New StringBuilder

    '    strA = Trim(strA)
    '    If Len(strA) = 0 Then Return ""

    '    ' Dejar sólo los números
    '    For i As Integer = 0 To strA.Length - 1
    '        If cNUMEROS.IndexOf(strA(i)) > -1 Then
    '            sb.Append(strA(i))
    '        End If
    '    Next

    '    strA = sb.ToString
    '    a = 0
    '    NIF = CInt(Val(strA))
    '    Do
    '        b = CInt(Int(NIF / 24))
    '        c = NIF - (24 * b)
    '        a = a + c
    '        NIF = b
    '    Loop While b <> 0
    '    b = CInt(Int(a / 23))
    '    c = a - (23 * b)

    '    Return strA & Mid(cCADENA, CInt(c + 1), 1)
    'End Function

    'Public Function Verificar_NIF(ByVal valor As String) As Boolean
    '    Dim aux As String

    '    valor = tbDNIBuscar.Text

    '    valor = valor.ToUpper ' ponemos la letra en mayúscula
    '    aux = valor.Substring(0, valor.Length - 1) ' quitamos la letra del NIF

    '    If aux.Length >= 7 AndAlso IsNumeric(aux) Then
    '        aux = CalculaNIF(aux) ' calculamos la letra del NIF para comparar con la que tenemos
    '    Else
    '        Return False
    '    End If

    '    If valor <> aux Then ' comparamos las letras
    '        Return False
    '    End If

    '    Return True
    'End Function


    Private Sub tbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBuscar.Click
        tbBuscar.Text = ""
    End Sub
End Class