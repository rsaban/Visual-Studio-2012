Public Class formDisponibilidad

    Private Sub btFormalizarAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFormalizarAlta.Click
        formAltaUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btReservarPlaza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReservarPlaza.Click
        formReserva.Show()
        Me.Close()
    End Sub
End Class