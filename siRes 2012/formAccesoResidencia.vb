Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class formAccesoResidencia

    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet

    Private Sub formAccesoResidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'relleno el combobox con el nombre de las residencias
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
                    cbxAccesoResidencia.Items.Add(value).ToString()
                End If
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

    End Sub

    'EN ESTE FORMULARIO VAMOS A MOSTRAR TODOS LOS RESIDENTES ACTUALES DE LA RESIDENCIA SELECCIONADA

    Private Sub btConsultarResidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConsultarResidencia.Click

        Dim micomandoContar As SqlCommand
        Dim registrosMostrados As Integer
        Dim buscandoCodResidencia As SqlCommand
        Dim encontradoCodResidencia As Integer

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

            'vamos a obtener el CodResidencia a partir de lo introducido en el combobox de Residencia Origen
            buscandoCodResidencia = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA='" & _
                                                    cbxAccesoResidencia.Text & "'", SqlConnection1)
            encontradoCodResidencia = buscandoCodResidencia.ExecuteScalar


            'Aqui seleccionamos todos los campos de la base de datos, según la residencia elegida y la mostramos por pantalla
            Dim da As New SqlDataAdapter("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, " &
                                         "PLAZA.TIPO_PLAZA, I.FECHA_INGRESO, USUARIOS.VIA_ACCESO, " &
                                         "USUARIOS.OBSERVACIONES, USUARIOS.ISE, PLAZA.RESERVA FROM USUARIOS," &
                                         " PLAZA, INGRESO I WHERE USUARIOS.EXPDTE = PLAZA.EXPDTE AND PLAZA.CodResidencia ='" &
                                         encontradoCodResidencia & "' AND USUARIOS.EXPDTE = I.EXPDTE " &
                                         " AND I.FECHA_INGRESO = (SELECT MAX(FECHA_INGRESO) " &
                                         "FROM INGRESO I2 WHERE I2.EXPDTE = I.EXPDTE)", SqlConnection1)
            Dim ds As New DataSet

            'Tambien tenemos que contar los registros mostrados
            micomandoContar = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE CodResidencia = '" & _
                                             encontradoCodResidencia & "'", SqlConnection1)



            'llenamos el datagridview
            da.Fill(ds)
            dgvResidenciaConsultada.DataSource = ds.Tables(0)

            'contamos los registros recuperados
            registrosMostrados = micomandoContar.ExecuteScalar
            tbRegistrosRecuperados.Text = registrosMostrados

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        btGenerarExcel.Visible = True

    End Sub

    Private Sub btAccesoGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAccesoGestion.Click
        formGestionResidencias.Show()
        Me.Close()
    End Sub

    Private Sub btGenerarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGenerarExcel.Click
        'crear hoja de calculo
        ApExcel = New Excel.Application
        ApExcel.Visible = True
        LibroExcel = ApExcel.Workbooks.Add
        HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)

        Dim constructor As New SqlConnectionStringBuilder()
        constructor.DataSource = ".\SQLEXPRESS"
        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
        constructor.IntegratedSecurity = True
        constructor.ConnectTimeout = 30
        constructor.UserInstance = True
        Me.SqlConnection1.ConnectionString = constructor.ConnectionString
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False



        Dim f As Integer = 3
        Dim residencialeida As String
        Dim micomandoLeer As SqlCommand
        Dim dr As SqlDataReader
        Dim buscandoCodResidencia As SqlCommand
        Dim encontradoCodResidencia As Integer
        Dim rango As Excel.Range

        Try
            SqlConnection1.Open()

            'vamos a obtener el CodResidencia a partir de lo introducido en el combobox de Residencia Origen
            buscandoCodResidencia = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA='" & _
                                                    cbxAccesoResidencia.Text & "'", SqlConnection1)
            encontradoCodResidencia = buscandoCodResidencia.ExecuteScalar

            micomandoLeer = New SqlCommand("SELECT USUARIOS.EXPDTE, USUARIOS.NOMBRE, USUARIOS.DNI, " &
                                         "PLAZA.TIPO_PLAZA, I.FECHA_INGRESO, USUARIOS.VIA_ACCESO, " &
                                         "USUARIOS.OBSERVACIONES, USUARIOS.ISE, PLAZA.RESERVA FROM USUARIOS," &
                                         " PLAZA, INGRESO I WHERE USUARIOS.EXPDTE = PLAZA.EXPDTE AND PLAZA.CodResidencia ='" &
                                         encontradoCodResidencia & "' AND USUARIOS.EXPDTE = I.EXPDTE " &
                                         " AND I.FECHA_INGRESO = (SELECT MAX(FECHA_INGRESO) " &
                                         "FROM INGRESO I2 WHERE I2.EXPDTE = I.EXPDTE)", SqlConnection1)

            dr = micomandoLeer.ExecuteReader(CommandBehavior.Default)

            'Nombre de la residencia (en la primera fila)
            HojaExcel.Cells(1, 1) = "Centro Residencial: " & cbxAccesoResidencia.Text

            'Titulos de columna
            HojaExcel.Cells(2, 1) = "Expediente"
            HojaExcel.Cells(2, 2) = "Nombre y Apellidos"
            HojaExcel.Cells(2, 3) = "DNI"
            HojaExcel.Cells(2, 4) = "Tipo de Plaza"
            HojaExcel.Cells(2, 5) = "Fecha de Ingreso"
            HojaExcel.Cells(2, 6) = "Via de acceso"
            HojaExcel.Cells(2, 7) = "ISE"
            HojaExcel.Cells(2, 8) = "Observaciones"
            HojaExcel.Cells(2, 9) = "Reserva"

            'Formato linea de titulos
            Dim rango2 As Excel.Range
            rango2 = CType(HojaExcel.Rows(1), Excel.Range)
            rango2.EntireRow.Font.Bold = True

            rango2 = CType(HojaExcel.Rows(2), Excel.Range)
            rango2.EntireRow.Font.Bold = True
            rango2.EntireRow.HorizontalAlignment = HorizontalAlignment.Center


            While dr.Read()
                'leemos el valor de la columna
                Dim value As Object = dr.Item("EXPDTE")
                'lo pasamos a la hoja excel
                HojaExcel.Cells(f, 1) = value.ToString
                rango = CType(HojaExcel.Cells(f, 1), Excel.Range)
                rango.HorizontalAlignment = HorizontalAlignment.Center

                'comprobamos otra columna y repetimos proceso
                value = dr.Item("NOMBRE")
                HojaExcel.Cells(f, 2) = value.ToString
                rango = CType(HojaExcel.Columns("B"), Excel.Range)
                rango.ColumnWidth = 40

                value = dr.Item("DNI")
                HojaExcel.Cells(f, 3) = value.ToString
                rango = CType(HojaExcel.Columns("C"), Excel.Range)
                rango.ColumnWidth = 12

                value = dr.Item("TIPO_PLAZA")
                HojaExcel.Cells(f, 4) = value.ToString
                rango = CType(HojaExcel.Columns("D"), Excel.Range)
                rango.ColumnWidth = 12

                value = dr.Item("FECHA_INGRESO")
                HojaExcel.Cells(f, 5) = Convert.ToDateTime(value)
                rango = CType(HojaExcel.Columns("E"), Excel.Range)
                rango.ColumnWidth = 16

                value = dr.Item("VIA_ACCESO")
                HojaExcel.Cells(f, 6) = value.ToString
                rango = CType(HojaExcel.Columns("F"), Excel.Range)
                rango.ColumnWidth = 15

                value = dr.Item("ISE")
                HojaExcel.Cells(f, 8) = value.ToString
                rango = CType(HojaExcel.Columns("G"), Excel.Range)
                rango.ColumnWidth = 15

                value = dr.Item("OBSERVACIONES")
                HojaExcel.Cells(f, 7) = value.ToString
                rango = CType(HojaExcel.Columns("H"), Excel.Range)
                rango.ColumnWidth = 50

                value = dr.Item("RESERVA")
                HojaExcel.Cells(f, 9) = value.ToString

                f += 1

            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try


        ApExcel.Quit()
        ApExcel = Nothing
    End Sub

    Private Sub formAccesoResidencia_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
    End Sub
End Class