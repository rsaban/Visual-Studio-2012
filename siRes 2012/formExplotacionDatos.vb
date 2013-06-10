'Imports System
'Imports System.Data
'Imports System.Data.SqlClient

'Public Class formExplotacionDatos

'    Private Sub formExplotacionDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Dim constructor As New SqlConnectionStringBuilder()
'        constructor.DataSource = ".\SQLEXPRESS"
'        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
'        constructor.IntegratedSecurity = True
'        constructor.ConnectTimeout = 30
'        constructor.UserInstance = True
'        SqlConnection1.ConnectionString = constructor.ConnectionString
'        SqlConnection1.FireInfoMessageEventOnUserErrors = False

'        SqlConnection1.Open()

'        Dim x As Integer
'        Dim miComandoContarResidencias As SqlCommand
'        Dim numeroResidencias As Integer
'        Dim micomandoObtenerResidencia As SqlCommand
'        Dim obtenerResidencia As String


'        'Obtenemos el número total de residencias
'        miComandoContarResidencias = New SqlCommand("SELECT COUNT(*) FROM RESIDENCIA", SqlConnection1)
'        numeroResidencias = miComandoContarResidencias.ExecuteScalar

'        'Bucle que recorrera toda la tabla RESIDENCIA   
'        For x = 1 To numeroResidencias
'            micomandoObtenerResidencia = New SqlCommand("SELECT RESIDENCIA.RESIDENCIA FROM RESIDENCIA WHERE CodResidencia=" & x, SqlConnection1)
'            obtenerResidencia = micomandoObtenerResidencia.ExecuteScalar
'            cbxResidenciaExplotacion.Items.Add(obtenerResidencia)
'        Next

'        SqlConnection1.Close()
'    End Sub

'    Private Sub btConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConsulta.Click

'        Dim da As SqlDataAdapter
'        Dim ds As New DataSet
'        Dim micomandoContarExplotacion As SqlCommand
'        Dim registrosRecuperadosExplotacion As Integer

'        If cbxAñoIngresoExplotacion.Text = "" Then
'            dgvExplotacionDatos.DataSource = ""
'            MessageBox.Show("Por favor, indique un año para la consulta")
'        Else

'            If cbxAltaBajaExplotacion.Text = "ALTA" Then
'                da = New SqlDataAdapter("SELECT * FROM ResidentesEnAlta WHERE (RESIDENCIA='" & cbxResidenciaExplotacion.Text & "') AND (TIPO_PLAZA='" & cbxTipoPlazaExplotacion.Text & "') AND (FECHA_INGRESO LIKE '%" & cbxAñoIngresoExplotacion.Text & "%');", SqlConnection1)
'                micomandoContarExplotacion = New SqlCommand("SELECT COUNT(*) FROM ResidentesEnAlta WHERE (RESIDENCIA='" & cbxResidenciaExplotacion.Text & "') AND (TIPO_PLAZA='" & cbxTipoPlazaExplotacion.Text & "') AND (FECHA_INGRESO LIKE '%" & cbxAñoIngresoExplotacion.Text & "%');", SqlConnection1)
'            Else
'                da = New SqlDataAdapter("SELECT * FROM ResidentesEnBaja WHERE (RESIDENCIA='" & cbxResidenciaExplotacion.Text & "') AND (TIPO_PLAZA='" & cbxTipoPlazaExplotacion.Text & "') AND (FECHA_INGRESO LIKE '%" & cbxAñoIngresoExplotacion.Text & "%');", SqlConnection1)
'                micomandoContarExplotacion = New SqlCommand("SELECT COUNT(*) FROM ResidentesEnBaja WHERE (RESIDENCIA='" & cbxResidenciaExplotacion.Text & "') AND (TIPO_PLAZA='" & cbxTipoPlazaExplotacion.Text & "') AND (FECHA_INGRESO LIKE '%" & cbxAñoIngresoExplotacion.Text & "%');", SqlConnection1)
'            End If


'            Dim constructor As New SqlConnectionStringBuilder()
'            constructor.DataSource = ".\SQLEXPRESS"
'            constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
'            constructor.IntegratedSecurity = True
'            constructor.ConnectTimeout = 30
'            constructor.UserInstance = True
'            Me.SqlConnection1.ConnectionString = constructor.ConnectionString
'            Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False

'            SqlConnection1.Open()

'            Try

'                'llenamos el datagriedview con la consulta
'                da.Fill(ds)
'                dgvExplotacionDatos.DataSource = ds.Tables(0)

'                'contamos los registros que se han recuperado y lo mostramos en el textbox correspondiente
'                registrosRecuperadosExplotacion = micomandoContarExplotacion.ExecuteScalar
'                tbRegistrosRecuperados.Text = registrosRecuperadosExplotacion

'            Catch ex As Exception
'                MessageBox.Show(ex.Message)
'            End Try

'            SqlConnection1.Close()
'        End If
'    End Sub

'End Class