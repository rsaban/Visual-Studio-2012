Public Class formEleccionBusquedaPorNombre

    Private Sub btSeleccionarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSeleccionarRegistro.Click
        'averiguamos la fila seleccionada
        Dim numeroFila As Integer = dgvResultadoBusquedaPorNombre.CurrentCell.RowIndex
        Dim dt As DataTable = DirectCast(dgvResultadoBusquedaPorNombre.DataSource, DataTable)
        Dim fila As DataRow = dt.Rows(numeroFila)

        Try
            registroSeleccionado = fila.Item("EXPDTE").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub
End Class