Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class formPlazasSinFormalizar

    Private Sub btPaFormalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPaFormalizar.Click

        'averiguamos la fila seleccionada
        Dim numeroFila As Integer = dgvPlazasReservadas.CurrentCell.RowIndex
        Dim dt As DataTable = DirectCast(dgvPlazasReservadas.DataSource, DataTable)
        Dim fila As DataRow = dt.Rows(numeroFila)

        formBusqueda.Show()
        ' formBusqueda.dtpFechaIngreso.Enabled = True

        Try
            formBusqueda.tbBuscar.Text = fila.Item("EXPDTE").ToString
            formBusqueda.rbExpdteBuscar.Enabled = True 'este es el radiobutton de Expdte
            formBusqueda.tbExpdteBuscar.Enabled = False
            formBusqueda.cbxCentroResidencial.Enabled = False
            formBusqueda.cbxTipoPlaza.Enabled = False
            formBusqueda.dtpFechaIngreso.Enabled = False
            formBusqueda.btBuscar.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()

    End Sub

    Private Sub btFormalizarIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFormalizarIngreso.Click
        'averiguamos la fila seleccionada
        Dim numeroFila As Integer = dgvPlazasReservadas.CurrentCell.RowIndex
        Dim dt As DataTable = DirectCast(dgvPlazasReservadas.DataSource, DataTable)
        Dim fila As DataRow = dt.Rows(numeroFila)

        formFechaIngreso.Show()
        formFechaIngreso.tbExpdte.Text = fila.Item("EXPDTE").ToString
        formFechaIngreso.tbResidencia.Text = fila.Item("RESIDENCIA").ToString
    End Sub

    Private Sub btCancelarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarReserva.Click
        Dim micomandoBorrarReservaUsuario As SqlCommand
        Dim borrarReservaUsuario As Integer
        Dim micomandoBorrarReservaPlaza As SqlCommand
        Dim borrarReservaPlaza As Integer

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

            'averiguamos la fila seleccionada
            Dim numeroFila As Integer = dgvPlazasReservadas.CurrentCell.RowIndex
            Dim dt As DataTable = DirectCast(dgvPlazasReservadas.DataSource, DataTable)
            Dim fila As DataRow = dt.Rows(numeroFila)

            micomandoBorrarReservaUsuario = New SqlCommand("DELETE FROM USUARIOS WHERE EXPDTE='" _
                                                            & fila.Item("EXPDTE").ToString & "'", SqlConnection1)
            micomandoBorrarReservaPlaza = New SqlCommand("DELETE FROM PLAZA WHERE EXPDTE='" _
                                                            & fila.Item("EXPDTE").ToString & "'", SqlConnection1)


            Dim caption As String = "Atención"
            If (MessageBox.Show("¿Seguro que desea cancelar la reserva?", caption, MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                borrarReservaUsuario = micomandoBorrarReservaUsuario.ExecuteNonQuery
                borrarReservaPlaza = micomandoBorrarReservaPlaza.ExecuteNonQuery
                MessageBox.Show("Reserva eliminada")
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        Me.Close()

        Call Form1.mirarPendientes()

    End Sub
End Class