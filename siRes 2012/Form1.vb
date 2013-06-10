Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

#Region "Load"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mirarPendientes()
    End Sub
#End Region

#Region "Alta de Usuario"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formAltaUsuario.Show()
    End Sub
#End Region

#Region "Consultar Disponibilidad"
    Private Sub btDisponibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDisponibilidad.Click

        Dim miComandoContar As SqlCommand
        Dim plazasOcupadas, plazasOcupadasEX, plazasOcupadasTC As Integer
        Dim plazasLibres, plazasLibresEX, plazasLibresTC As Integer
        Dim value As Object

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

            Dim micomandoObtenerResidencia As SqlCommand
            Dim dr As SqlDataReader = Nothing
            Dim dt As New DataTable

            'consulta para obtener los datos de la tabla RESIDENCIA
            micomandoObtenerResidencia = New SqlCommand("SELECT * FROM RESIDENCIA", SqlConnection1)
            
            'cargamos el resultado de la consulta en un DataTable
            dt.Load(micomandoObtenerResidencia.ExecuteReader)

            For Each Fila As DataRow In dt.Rows

                'Obtenemos las plazas ocupadas en MAYORES
                miComandoContar = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE CodResidencia =" & Convert.ToInt32(Fila.Item("CodResidencia")) & " AND TIPO_PLAZA='MAYORES'", SqlConnection1)
                plazasOcupadas = miComandoContar.ExecuteScalar

                'restamos las totales de las ocupadas
                plazasLibres = Convert.ToInt32(Fila.Item("PlazasMayores")) - plazasOcupadas

                'si hay libres, la añadimos al listview
                If plazasLibres <> 0 Then
                    formDisponibilidad.ListViewDisponibilidad.Items.Add(Fila.Item("RESIDENCIA") & " (" & plazasLibres & " plazas libres)")
                End If

                'REPETIMOS LA OPERACIÓN CON EXCLUSIÓN
                'Obtenemos las plazas ocupadas en EXCLUSION
                Dim miComandoContarEX As SqlCommand
                miComandoContarEX = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE CodResidencia =" & Convert.ToInt32(Fila.Item("CodResidencia")) & " AND TIPO_PLAZA='EXCLUSION'", SqlConnection1)
                plazasOcupadasEX = miComandoContarEX.ExecuteScalar

                plazasLibresEX = Convert.ToInt32(Fila.Item("PlazasExclusion")) - plazasOcupadasEX

                If plazasLibresEX <> 0 Then
                    formDisponibilidad.ListViewDisponibilidad.Items.Add(Fila.Item("RESIDENCIA") & "  (EXCLUSION) (" & plazasLibresEX & " plazas libres)")
                End If

                'REPETIMOS LA OPERACIÓN CON TRASTORNOS DE CONDUCTA
                'Obtenemos las plazas ocupadas en TRASTORNOS DE CONDUCTA
                Dim miComandoContarTC As SqlCommand
                miComandoContarTC = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE CodResidencia =" & Convert.ToInt32(Fila.Item("CodResidencia")) & " AND TIPO_PLAZA='TRASTORNOS DE CONDUCTA'", SqlConnection1)
                plazasOcupadasTC = miComandoContarTC.ExecuteScalar

                plazasLibresTC = Convert.ToInt32(Fila.Item("PlazasTrastConducta")) - plazasOcupadasTC

                If plazasLibresTC <> 0 Then
                    formDisponibilidad.ListViewDisponibilidad.Items.Add(Fila.Item("RESIDENCIA") & " (TRASTORNOS DE CONDUCTA) (" & plazasLibresTC & " plazas libres)")
                End If

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        formDisponibilidad.Show()

    End Sub
#End Region

#Region "Acceso a Residencia"
    Private Sub btAccesoResidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAccesoResidencia.Click
        formAccesoResidencia.Show()
    End Sub
#End Region

#Region "Búsqueda"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        formBusqueda.Show()
        formBusqueda.tbDNIBuscar.ReadOnly = True
        formBusqueda.tbNombreBuscar.ReadOnly = True
        formBusqueda.tbISEBuscar.ReadOnly = True
        formBusqueda.tbObservacionesBuscar.ReadOnly = True
        formBusqueda.tbReservaBuscar.ReadOnly = True
        formBusqueda.tbViaAccesoBuscar.ReadOnly = True
        formBusqueda.dtpFechaIngreso.ReadOnly = True
        formBusqueda.dtpFechaBaja.ReadOnly = True
        formBusqueda.tbExpdteBuscar.ReadOnly = True
        formBusqueda.cbxCentroResidencial.Enabled = False
        formBusqueda.cbxPendienteCitar.Enabled = False
        formBusqueda.cbxPendienteIngresar.Enabled = False
        formBusqueda.cbxTipoPlaza.Enabled = False
        formBusqueda.btActualizarRegistro.Visible = False
        formBusqueda.btTraslado.Visible = False
        formBusqueda.btHistoricoTraslados.Visible = True
        formBusqueda.btHistoricoTraslados.Location = New Point(507, 394)
    End Sub
#End Region

#Region "Trasladar/Actualizar Registro"
    Private Sub btBorrarModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBorrarModificar.Click
        formBusqueda.Show()
        formBusqueda.Text = "Trasladar/Actualizar Registros"
        formBusqueda.tbExpdteBuscar.ReadOnly = True
        formBusqueda.cbxCentroResidencial.Enabled = False
        formBusqueda.dtpFechaIngreso.Enabled = True
        formBusqueda.cbxTipoPlaza.Enabled = False
        formBusqueda.dtpFechaIngreso.ReadOnly = True
    End Sub
#End Region

#Region "Explotación de Datos"
    Private Sub btExplotacionDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExplotacionDatos.Click
        formExplotacionDatos.Show()
    End Sub
#End Region

#Region "link Plazas Reservadas sin Formalizar"
    Private Sub lklbAvisadorReserva_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbAvisadorReserva.LinkClicked

        formPlazasSinFormalizar.lbPlazasSinFormalizar.Text = "PLAZAS RESERVADAS:"

        Dim da As New SqlDataAdapter("SELECT PLAZA.EXPDTE, RESIDENCIA.RESIDENCIA, PLAZA.TIPO_PLAZA FROM PLAZA, RESIDENCIA WHERE PLAZA.RESERVA='RESERVADA' AND PLAZA.CodResidencia=RESIDENCIA.CodResidencia", _
                                     SqlConnection1)
        Dim ds As New DataSet

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

            da.Fill(ds)
            formPlazasSinFormalizar.dgvPlazasReservadas.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        formPlazasSinFormalizar.btPaFormalizar.Text = "Formalizar Reserva"

        formPlazasSinFormalizar.Show()
        formPlazasSinFormalizar.btPaFormalizar.Visible = False
        formPlazasSinFormalizar.btFormalizarIngreso.Visible = True
        formPlazasSinFormalizar.btFormalizarIngreso.Location = New Point(365, 320)
        formPlazasSinFormalizar.btCancelarReserva.Visible = True
        formPlazasSinFormalizar.btCancelarReserva.Location = New Point(489, 320)

    End Sub
#End Region

#Region "link Pendiente Citar"
    Private Sub lklbPendienteCitar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbPendienteCitar.LinkClicked

        formPlazasSinFormalizar.lbPlazasSinFormalizar.Text = "USUARIOS PENDIENTES DE CITAR:"

        Dim da As New SqlDataAdapter("SELECT EXPDTE, NOMBRE, DNI FROM USUARIOS WHERE USUARIOS.PENDIENTE_CITAR = 'SI'", SqlConnection1)
        Dim ds As New DataSet

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
            da.Fill(ds)
            formPlazasSinFormalizar.dgvPlazasReservadas.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        formPlazasSinFormalizar.btPaFormalizar.Text = "Anular Cita"

        formPlazasSinFormalizar.Show()
        formPlazasSinFormalizar.btPaFormalizar.Visible = True
        formPlazasSinFormalizar.btPaFormalizar.Location = New Point(520, 320)
        formPlazasSinFormalizar.btFormalizarIngreso.Visible = False
        formPlazasSinFormalizar.btCancelarReserva.Visible = False
    End Sub
#End Region

#Region "link Pendiente Ingresar"
    Private Sub lklbPendientesIngresar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbPendientesIngresar.LinkClicked

        formPlazasSinFormalizar.lbPlazasSinFormalizar.Text = "USUARIOS PENDIENTES DE INGRESO:"

        Dim da As New SqlDataAdapter("SELECT EXPDTE, NOMBRE, DNI FROM USUARIOS WHERE USUARIOS.PENDIENTE_INGRESAR = 'SI'", SqlConnection1)
        Dim ds As New DataSet

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
            da.Fill(ds)
            formPlazasSinFormalizar.dgvPlazasReservadas.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        formPlazasSinFormalizar.btPaFormalizar.Text = "Formalizar Ingreso"

        formPlazasSinFormalizar.Show()
        formPlazasSinFormalizar.btPaFormalizar.Visible = True
        formPlazasSinFormalizar.btPaFormalizar.Location = New Point(480, 320)
        formPlazasSinFormalizar.btFormalizarIngreso.Visible = False
        formPlazasSinFormalizar.btCancelarReserva.Visible = False
    End Sub
#End Region

#Region "mirarPendientes"
    Public Sub mirarPendientes()

        'vamos a mostrar los avisos para plazas reservadas, pendientes de cita y pendientes de ingreso
        Dim miComandoContarReservadas, miComandoPendientesCitar, miComandoPendientesIngresar As SqlCommand
        Dim plazas, pendientesCitar, pendientesIngresar As Integer

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

            miComandoContarReservadas = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE PLAZA.RESERVA = 'RESERVADA'", SqlConnection1)
            plazas = miComandoContarReservadas.ExecuteScalar

            miComandoPendientesCitar = New SqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE USUARIOS.PENDIENTE_CITAR = 'SI'", SqlConnection1)
            pendientesCitar = miComandoPendientesCitar.ExecuteScalar

            miComandoPendientesIngresar = New SqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE USUARIOS.PENDIENTE_INGRESAR = 'SI'", SqlConnection1)
            pendientesIngresar = miComandoPendientesIngresar.ExecuteScalar


            If plazas <> 0 Then
                lklbAvisadorReserva.Visible = True
                lklbAvisadorReserva.Text = "- Tiene " & plazas & " plaza/s RESERVADA en espera de ingreso. -"
            Else
                lklbAvisadorReserva.Visible = False
                lklbAvisadorReserva.Text = ""
            End If

            If pendientesCitar <> 0 Then
                lklbPendienteCitar.Visible = True
                lklbPendienteCitar.Text = "- Tiene " & pendientesCitar & " usuario/s PENDIENTE/S DE CITAR. -"
            Else
                lklbPendienteCitar.Visible = False
                lklbPendienteCitar.Text = ""
            End If

            If pendientesIngresar <> 0 Then
                lklbPendientesIngresar.Visible = True
                lklbPendientesIngresar.Text = "- Tiene " & pendientesIngresar & " usuarios PENDIENTE/S DE INGRESO. -"
            Else
                lklbPendientesIngresar.Visible = False
                lklbPendientesIngresar.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

    End Sub
#End Region

#Region "Acerca de..."
    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    '    formAcercaDe.Show()
    'End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        formAcercaDe.Show()
    End Sub
#End Region
End Class
