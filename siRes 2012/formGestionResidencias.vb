Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class formGestionResidencias

    Private Sub formGestionResidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                    cbxCentroResidencial.Items.Add(value).ToString()
                End If
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        Label5.Focus()
    End Sub

#Region "Realizar Consulta"
    Private Sub cbxCentroResidencial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCentroResidencial.Leave

        If cbxCentroResidencial.Text = "" Then
            Exit Sub
        Else

            Dim miConsulta As SqlCommand
            Dim ds As New DataSet


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

                miConsulta = New SqlCommand("SELECT RESIDENCIA.RESIDENCIA, RESIDENCIA.PlazasMayores, RESIDENCIA.PlazasExclusion, RESIDENCIA.PlazasTrastConducta FROM RESIDENCIA WHERE RESIDENCIA.RESIDENCIA='" & _
                                                               cbxCentroResidencial.Text & "'", SqlConnection1)

                Dim consulta As New SqlDataAdapter(miConsulta)
                consulta.Fill(ds)

                If IsDBNull(ds.Tables(0).Rows(0)("RESIDENCIA")) Then tbNombreResidencia.Text = "" Else tbNombreResidencia.Text = ds.Tables(0).Rows(0)("RESIDENCIA")
                If IsDBNull(ds.Tables(0).Rows(0)("PlazasMayores")) Then tbPlazasMayores.Text = "" Else tbPlazasMayores.Text = ds.Tables(0).Rows(0)("PlazasMayores")
                If IsDBNull(ds.Tables(0).Rows(0)("PlazasExclusion")) Then tbPlazasExclusion.Text = "" Else tbPlazasExclusion.Text = ds.Tables(0).Rows(0)("PlazasExclusion")
                If IsDBNull(ds.Tables(0).Rows(0)("PlazasTrastConducta")) Then tbPlazasTrastornos.Text = "" Else tbPlazasTrastornos.Text = ds.Tables(0).Rows(0)("PlazasTrastConducta")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                SqlConnection1.Close()
            End Try
        End If
    End Sub
#End Region

#Region "Actualizar Residencia"
    Private Sub btActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btActualizar.Click

        Dim miComandoActualizarResidencia As SqlCommand
        Dim actualizarResidencia As Integer


        Dim constructor As New SqlConnectionStringBuilder()
        constructor.DataSource = ".\SQLEXPRESS"
        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
        constructor.IntegratedSecurity = True
        constructor.ConnectTimeout = 30
        constructor.UserInstance = True
        SqlConnection1.ConnectionString = constructor.ConnectionString
        SqlConnection1.FireInfoMessageEventOnUserErrors = False


        miComandoActualizarResidencia = New SqlCommand("UPDATE RESIDENCIA SET RESIDENCIA.RESIDENCIA='" & tbNombreResidencia.Text & "', RESIDENCIA.PlazasMayores='" _
                                                        & Convert.ToInt32(tbPlazasMayores.Text) & "', RESIDENCIA.PlazasExclusion='" _
                                                        & Convert.ToInt32(tbPlazasExclusion.Text) & "', RESIDENCIA.PlazasTrastConducta='" _
                                                        & Convert.ToInt32(tbPlazasTrastornos.Text) & "' WHERE RESIDENCIA.RESIDENCIA='" _
                                                        & cbxCentroResidencial.Text & "';", SqlConnection1)

        Try
            SqlConnection1.Open()

            'actualizo la tabla residencia
            actualizarResidencia = miComandoActualizarResidencia.ExecuteNonQuery

            MessageBox.Show("Residencia actualizada con éxito")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        Me.Close()
    End Sub
#End Region

#Region "Añadir Residencia"
    Private Sub btAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAñadir.Click

        Dim micomandoConsultarResidencia As SqlCommand
        Dim consultarResidencias As Integer
        Dim micomandoInsertarResidencia As SqlCommand
        Dim insertarResidencia As Integer

        micomandoConsultarResidencia = New SqlCommand("SELECT COUNT(*) FROM RESIDENCIA WHERE RESIDENCIA.RESIDENCIA='" & tbNombreResidencia.Text & "'", SqlConnection1)


        micomandoInsertarResidencia = New SqlCommand("INSERT INTO RESIDENCIA(RESIDENCIA, PlazasMayores, PlazasExclusion, PlazasTrastConducta) VALUES ('" _
                                                      & tbNombreResidencia.Text & "', '" & Convert.ToInt32(tbPlazasMayores.Text) & "', '" _
                                                      & Convert.ToInt32(tbPlazasExclusion.Text) & "', '" _
                                                      & Convert.ToInt32(tbPlazasTrastornos.Text) & "')", SqlConnection1)

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

            'antes de insertar comprobamos que no exista
            consultarResidencias = micomandoConsultarResidencia.ExecuteScalar
            If consultarResidencias = 0 Then
                insertarResidencia = micomandoInsertarResidencia.ExecuteNonQuery
                MessageBox.Show("Residencia añadida con éxito")
            Else
                MessageBox.Show("La residencia ya existe")
                SqlConnection1.Close()
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        Me.Close()
    End Sub
#End Region

#Region "Eliminar Residencia"
    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click

        Dim micomandoEliminarResidencia As SqlCommand
        Dim eliminarResidencia As Integer

        micomandoEliminarResidencia = New SqlCommand("DELETE FROM RESIDENCIA WHERE RESIDENCIA.RESIDENCIA='" _
                                                      & cbxCentroResidencial.Text & "'", SqlConnection1)



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

            Dim caption As String = "Atención"
            'preguntamos si quiere continuar, ya que se va a cerrar el expediente
            If (MessageBox.Show("¿Si elimina esta residencia todos sus datos se perderán?", caption, MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                eliminarResidencia = micomandoEliminarResidencia.ExecuteNonQuery
                MessageBox.Show("Residencia eliminada con éxito")
            Else
                SqlConnection1.Close()
                Exit Sub
            End If
        Catch ex As Exception
            'si hay datos de la residencia en otras tablas, la sentencia Delete falla.
            MessageBox.Show("No es posible eliminar la residencia")
        Finally
            SqlConnection1.Close()
        End Try

        Me.Close()
    End Sub
#End Region

    Private Sub tbPlazasExclusion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbPlazasExclusion.Validating
        Dim tb As TextBox = CType(sender, TextBox)
        Dim datoPlaza As Int32
        Try
            datoPlaza = Convert.ToInt32(tb.Text)
        Catch ex As Exception
            e.Cancel = True
            tb.SelectAll()
            ErrorProvider1.SetError(tb, "Tiene que ser númerico")
        End Try
    End Sub

    Private Sub tbPlazasMayores_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbPlazasMayores.Validating
        Dim tb As TextBox = CType(sender, TextBox)
        Dim datoPlaza As Int32
        Try
            datoPlaza = Convert.ToInt32(tb.Text)
        Catch ex As Exception
            e.Cancel = True
            tb.SelectAll()
            ErrorProvider1.SetError(tb, "Tiene que ser númerico")
        End Try
    End Sub

    Private Sub tbPlazasTrastornos_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbPlazasTrastornos.Validating
        Dim tb As TextBox = CType(sender, TextBox)
        Dim datoPlaza As Int32
        Try
            datoPlaza = Convert.ToInt32(tb.Text)
        Catch ex As Exception
            e.Cancel = True
            tb.SelectAll()
            ErrorProvider1.SetError(tb, "Tiene que ser númerico")
        End Try
    End Sub


    Private Sub formGestionResidencias_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
    End Sub
End Class