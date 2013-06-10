Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class formTraslado

    Private Sub formTraslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            SqlConnection1.Open()

            dr = micomandoObtenerResidencia.ExecuteReader(CommandBehavior.Default)

            While dr.Read
                'primero damos a la variable value el nombre de la columna que tiene el nombre de la Residencia
                Dim value As Object = dr.Item("RESIDENCIA")
                'Si está, recuperamos el valor y lo mostramos en el textbox correspondiente
                If value IsNot DBNull.Value Then
                    cbxResidenciaDestino.Items.Add(value).ToString()
                End If
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        cbxTipoPlazaDestino.Items.AddRange(tipo_plazas)
        tbExpedienteTraslado.ReadOnly = True
    End Sub

#Region "TRASLADAR DE CENTRO"
    Private Sub btTraslado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTraslado.Click

        If dtpFechaAltaDestino.Text = dtpFechaBajaOrigen.Text Then
            MessageBox.Show("Las fechas de alta y baja no pueden coincidir")
        Else

            Dim buscandoCodResidenciaDestino As SqlCommand
            Dim encontradoCodResidenciaDestino As Integer
            Dim miComandoContar As SqlCommand
            Dim plazas As Integer

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
                SqlConnection1.Open()

                'vamos a obtener el CodResidencia a partir de lo introducido en el combobox de Residencia Destino
                buscandoCodResidenciaDestino = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA='" & _
                                                        cbxResidenciaDestino.Text & "'", SqlConnection1)
                encontradoCodResidenciaDestino = buscandoCodResidenciaDestino.ExecuteScalar


                ' 1º    Contamos las plazas que tiene ocupada la residencia 
                miComandoContar = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE CodResidencia = '" & _
                                                 encontradoCodResidenciaDestino & "' AND TIPO_PLAZA = '" _
                                                 & cbxTipoPlazaDestino.Text & "'", SqlConnection1)
                plazas = miComandoContar.ExecuteScalar

                ' 2º    Antes de añadir el registro, comprobamos que hay plazas libres

                'Obtenemos las plazas totales de la residencia
                Dim consultandoPlazasTotales As SqlCommand
                Dim dsPlazas As New DataSet
                Dim plazasTotales As Integer
                consultandoPlazasTotales = New SqlCommand("SELECT * FROM RESIDENCIA WHERE CodResidencia=" & encontradoCodResidenciaDestino, SqlConnection1)
                Dim daPlazasTotales As New SqlDataAdapter(consultandoPlazasTotales)

                daPlazasTotales.Fill(dsPlazas)

                If cbxTipoPlazaDestino.Text = "MAYORES" Then
                    plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasMayores")
                ElseIf cbxTipoPlazaDestino.Text = "EXCLUSION" Then
                    plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasExclusion")
                ElseIf cbxTipoPlazaDestino.Text = "TRASTORNOS DE CONDUCTA" Then
                    plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasTrastConducta")
                End If

                If plazas = plazasTotales Then
                    MessageBox.Show("No hay plazas disponibles en el centro elegido")
                Else


                    'ORIGEN
                    Dim micomandoInsertarBaja As SqlCommand
                    Dim buscandoCodResidenciaOrigen As SqlCommand
                    Dim registrandoBaja As Integer
                    Dim encontradoCodResidenciaOrigen As Integer


                    Try
                        'vamos a obtener el CodResidencia a partir de lo introducido en el combobox de Residencia Origen
                        buscandoCodResidenciaOrigen = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA='" & _
                                                                cbxResidenciaOrigen.Text & "'", SqlConnection1)
                        encontradoCodResidenciaOrigen = buscandoCodResidenciaOrigen.ExecuteScalar

                        'damos la instruccion al comando
                        micomandoInsertarBaja = New SqlCommand("INSERT INTO BAJA (EXPDTE, CodResidencia, FECHA_BAJA) VALUES ('" & tbExpedienteTraslado.Text & _
                                                          "', '" & encontradoCodResidenciaOrigen & "', '" & dtpFechaBajaOrigen.Text & "');", _
                                                           SqlConnection1)

                        'ejecutamos la baja
                        registrandoBaja = micomandoInsertarBaja.ExecuteNonQuery
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try


                    'DESTINO
                    '1º Actualizar la tabla PLAZA, con el CodResidencia y el Tipo_Plaza de destino
                    '2º Insertar la fecha de ingreso en la tabla INGRESO

                    '1º
                    Dim micomandoActualizarPlaza As SqlCommand
                    Dim actualizarPlaza As Integer

                    Try
                        micomandoActualizarPlaza = New SqlCommand("UPDATE PLAZA SET CodResidencia='" & encontradoCodResidenciaDestino & "', TIPO_PLAZA='" & cbxTipoPlazaDestino.Text & "' WHERE PLAZA.EXPDTE='" & tbExpedienteTraslado.Text & "';", SqlConnection1)

                        actualizarPlaza = micomandoActualizarPlaza.ExecuteNonQuery

                        '2º
                        Dim micomandoInsertarIngresoDestino As SqlCommand
                        Dim insertarIngresoDestino As Integer

                        micomandoInsertarIngresoDestino = New SqlCommand("INSERT INTO INGRESO (EXPDTE, CodResidencia, FECHA_INGRESO) VALUES ('" & tbExpedienteTraslado.Text & _
                                                                          "', '" & encontradoCodResidenciaDestino & "', '" & dtpFechaAltaDestino.Text & "');", _
                                                                           SqlConnection1)

                        insertarIngresoDestino = micomandoInsertarIngresoDestino.ExecuteNonQuery

                        MessageBox.Show("Traslado realizado con éxito")

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        SqlConnection1.Close()
                    End Try

                    Me.Close()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                SqlConnection1.Close()
            End Try
        End If
    End Sub
#End Region

End Class