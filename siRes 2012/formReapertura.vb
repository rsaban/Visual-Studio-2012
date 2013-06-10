Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class formReapertura

    Private Sub formReapertura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                    cbxResidenciaReapertura.Items.Add(value).ToString()
                End If
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        cbxTipoPlazaReapertura.Items.AddRange(tipo_plazas)
    End Sub

#Region "REAPERTURA"
    Private Sub btReapertura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReapertura.Click

        Dim buscandoCodResidencia As SqlCommand
        Dim encontradoCodResidencia As Integer
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


        'Aqui tengo que controlar que la fecha de reapertura sea mayor o igual a la fecha de cierre.
        Dim consultaBaja As SqlCommand
        Dim ds3 As New DataSet
        Dim fechaBaja As String

        Try
            SqlConnection1.Open()

            consultaBaja = New SqlCommand("SELECT BAJA.FECHA_BAJA FROM USUARIOS, BAJA WHERE USUARIOS.EXPDTE=BAJA.EXPDTE AND USUARIOS.EXPDTE='" & tbExpedienteReapertura.Text & "' ORDER BY BAJA.FECHA_BAJA DESC", SqlConnection1)
            Dim ejecutandoConsultaBaja As New SqlDataAdapter(consultaBaja)
            ejecutandoConsultaBaja.Fill(ds3)
            fechaBaja = ds3.Tables(0).Rows(0)("FECHA_BAJA")

            If Convert.ToDateTime(fechaBaja) < Convert.ToDateTime(dtpReapertura.Text) Then

                If String.IsNullOrWhiteSpace(cbxResidenciaReapertura.Text) Or String.IsNullOrWhiteSpace(cbxTipoPlazaReapertura.Text) Then
                    MessageBox.Show("Residencia y Tipo de Plaza, son campos requeridos")
                    SqlConnection1.Close()
                Else
                    Try
                        'vamos a obtener el CodResidencia a partir de lo introducido en el combobox de Residencia Destino
                        buscandoCodResidencia = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA='" & _
                                                                cbxResidenciaReapertura.Text & "'", SqlConnection1)
                        encontradoCodResidencia = buscandoCodResidencia.ExecuteScalar


                        ' 1º    Contamos las plazas que tiene ocupada la residencia 
                        miComandoContar = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE CodResidencia = '" & _
                                                         encontradoCodResidencia & "' AND TIPO_PLAZA = '" _
                                                 & cbxTipoPlazaReapertura.Text & "'", SqlConnection1)
                        plazas = miComandoContar.ExecuteScalar

                        ' 2º    Antes de añadir el registro, comprobamos que hay plazas libres
                        'Obtenemos las plazas totales de la residencia
                        Dim consultandoPlazasTotales As SqlCommand
                        Dim dsPlazas As New DataSet
                        Dim plazasTotales As Integer
                        consultandoPlazasTotales = New SqlCommand("SELECT * FROM RESIDENCIA WHERE CodResidencia=" & encontradoCodResidencia, SqlConnection1)
                        Dim daPlazasTotales As New SqlDataAdapter(consultandoPlazasTotales)
                        Try
                            daPlazasTotales.Fill(dsPlazas)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try

                        If cbxTipoPlazaReapertura.Text = "MAYORES" Then
                            plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasMayores")
                        ElseIf cbxTipoPlazaReapertura.Text = "EXCLUSION" Then
                            plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasExclusion")
                        ElseIf cbxTipoPlazaReapertura.Text = "TRASTORNOS DE CONDUCTA" Then
                            plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasTrastConducta")
                        End If

                        If plazas = plazasTotales Then

                            MessageBox.Show("No hay plazas disponibles en el centro elegido")
                        Else

                            '1º Actualizar la tabla PLAZA, con el CodResidencia y el Tipo_Plaza de destino
                            '2º Insertar la fecha de ingreso en la tabla INGRESO

                            '1º
                            Dim micomandoActualizarPlaza As SqlCommand
                            Dim actualizarPlaza As Integer

                            Try
                                'micomandoActualizarPlaza = New SqlCommand("UPDATE PLAZA SET CodResidencia='" & encontradoCodResidencia & "', TIPO_PLAZA='" & cbxTipoPlazaReapertura.Text & "' WHERE PLAZA.EXPDTE='" & tbExpedienteReapertura.Text & "';", SqlConnection1)
                                micomandoActualizarPlaza = New SqlCommand("INSERT INTO PLAZA (EXPDTE, CodResidencia, TIPO_PLAZA) VALUES ('" & tbExpedienteReapertura.Text & _
                                                                                  "', '" & encontradoCodResidencia & "', '" & cbxTipoPlazaReapertura.Text & "');", SqlConnection1)
                                actualizarPlaza = micomandoActualizarPlaza.ExecuteNonQuery

                                '2º
                                Dim micomandoInsertarIngresoDestino As SqlCommand
                                Dim insertarIngresoDestino As Integer

                                micomandoInsertarIngresoDestino = New SqlCommand("INSERT INTO INGRESO (EXPDTE, CodResidencia, FECHA_INGRESO) VALUES ('" & tbExpedienteReapertura.Text & _
                                                                                  "', '" & encontradoCodResidencia & "', '" & dtpReapertura.Text & "');", _
                                                                                   SqlConnection1)

                                insertarIngresoDestino = micomandoInsertarIngresoDestino.ExecuteNonQuery

                                MessageBox.Show("Reapertura realizada con éxito")

                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                    SqlConnection1.Close()

                    Me.Close()
                    Call Form1.mirarPendientes()

                End If
            Else
                MessageBox.Show("La fecha de reapertura no puede ser inferior a la fecha de cierre del expediente")
                SqlConnection1.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try
    End Sub
#End Region


End Class