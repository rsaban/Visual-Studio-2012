Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class formFechaIngreso

    Private Sub btFormalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFormalizar.Click
        Dim micomandoActualizarPlaza As SqlCommand
        Dim actualizarPlaza As Integer
        Dim micomandoInsertarIngreso As SqlCommand
        Dim insertarIngreso As Integer
        Dim buscandoCodResidencia As SqlCommand
        Dim encontradoCodResidencia As Integer

        micomandoActualizarPlaza = New SqlCommand("UPDATE PLAZA SET RESERVA ='' WHERE EXPDTE = '" & tbExpdte.Text & "'", SqlConnection1)

        Dim constructor As New SqlConnectionStringBuilder()
        constructor.DataSource = ".\SQLEXPRESS"
        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
        constructor.IntegratedSecurity = True
        constructor.ConnectTimeout = 30
        constructor.UserInstance = True
        SqlConnection1.ConnectionString = constructor.ConnectionString
        SqlConnection1.FireInfoMessageEventOnUserErrors = False

        Try
            SqlConnection1.Open()

            'vamos a obtener el CodResidencia a partir de lo introducido en el textbox
            buscandoCodResidencia = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA.RESIDENCIA='" & _
                                                    tbResidencia.Text & "'", SqlConnection1)
            encontradoCodResidencia = buscandoCodResidencia.ExecuteScalar

            micomandoInsertarIngreso = New SqlCommand("INSERT INTO INGRESO (EXPDTE, CodResidencia, FECHA_INGRESO) VALUES ('" & tbExpdte.Text & _
                                                  "', '" & encontradoCodResidencia & "', '" & DateTimePicker1.Text & "');", _
                                                   SqlConnection1)


            actualizarPlaza = micomandoActualizarPlaza.ExecuteNonQuery
            insertarIngreso = micomandoInsertarIngreso.ExecuteNonQuery

            MessageBox.Show("Usuario añadido con éxito")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        Me.Close()
        formPlazasSinFormalizar.Close()

        Call Form1.mirarPendientes()

    End Sub

End Class