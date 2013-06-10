﻿Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class formReserva

    Private Sub formReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                    cbxResidenciaReserva.Items.Add(value).ToString()
                End If
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection1.Close()
        End Try

        cbxTipoPlazaReserva.Items.AddRange(tipo_plazas)
    End Sub


    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReservar.Click

        Dim reservaUsuario As Integer
        Dim miComandoContar As SqlCommand
        Dim plazas As Integer
        Dim buscandoCodResidencia As SqlCommand
        Dim encontradoCodResidencia As Integer
        Dim miComandoInsertarUsuarios As New SqlCommand
        Dim altaUsuario As Integer
        Dim miComandoInsertarPlaza As New SqlCommand
        Dim altaPlaza As Integer

        Dim constructor As New SqlConnectionStringBuilder()
        constructor.DataSource = ".\SQLEXPRESS"
        constructor.AttachDBFilename = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) & "\bdResidentes.mdf"
        constructor.IntegratedSecurity = True
        constructor.ConnectTimeout = 30
        constructor.UserInstance = True
        Me.SqlConnection1.ConnectionString = constructor.ConnectionString
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False

        'vamos a controlar que los textbox Expdte, Residencia y Tipo de Plaza no se queden vacios
        If String.IsNullOrWhiteSpace(tbExpdteReserva.Text) Or String.IsNullOrWhiteSpace(cbxResidenciaReserva.Text) Or String.IsNullOrWhiteSpace(cbxTipoPlazaReserva.Text) Then
            MessageBox.Show("Expediente, Residencia y Tipo de Plaza, son campos requeridos")
        Else

            Try
                SqlConnection1.Open()

                'If Verificar_NIF(tbDNIReserva.Text) = False Then
                '    MsgBox("El formato correcto de DNI es 12345678A")
                '    SqlConnection1.Close()
                '    Exit Sub
                'End If

                'vamos a obtener el CodResidencia a partir de lo introducido en el textbox
                buscandoCodResidencia = New SqlCommand("SELECT CodResidencia FROM RESIDENCIA WHERE RESIDENCIA='" & _
                                                        cbxResidenciaReserva.Text & "'", SqlConnection1)
                encontradoCodResidencia = buscandoCodResidencia.ExecuteScalar



                ' 1º    Contamos las plazas que tiene ocupada la residencia 
                miComandoContar = New SqlCommand("SELECT COUNT(*) FROM PLAZA WHERE CodResidencia = '" & _
                                                 encontradoCodResidencia & "' AND TIPO_PLAZA = '" _
                                                 & cbxTipoPlazaReserva.Text & "'", SqlConnection1)
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

                If cbxTipoPlazaReserva.Text = "MAYORES" Then
                    plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasMayores")
                ElseIf cbxTipoPlazaReserva.Text = "EXCLUSION" Then
                    plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasExclusion")
                ElseIf cbxTipoPlazaReserva.Text = "TRASTORNOS DE CONDUCTA" Then
                    plazasTotales = dsPlazas.Tables(0).Rows(0)("PlazasTrastConducta")
                End If

                If plazas = plazasTotales Then
                    MessageBox.Show("No hay plazas disponibles en el centro elegido")
                Else
                    ' 3º    Si hay plazas libres grabamos el alta

                    'Comando Insert para insertar en la tabla lo escrito en los campos del formulario formAltaUsuario
                    miComandoInsertarUsuarios = New SqlCommand("INSERT INTO USUARIOS(EXPDTE, NOMBRE, DNI) VALUES('" & _
                                                       tbExpdteReserva.Text & "', '" & tbNombreReserva.Text & "','" & tbDNIReserva.Text & "');", _
                                                       SqlConnection1)

                    miComandoInsertarPlaza = New SqlCommand("INSERT INTO PLAZA (CodResidencia, TIPO_PLAZA, EXPDTE, RESERVA) VALUES('" & _
                                                            encontradoCodResidencia & "', '" & cbxTipoPlazaReserva.Text & "', '" & _
                                                            tbExpdteReserva.Text & "', 'RESERVADA');",
                                                      SqlConnection1)


                    'Esta sentencia ejecuta el comando Insert
                    altaUsuario = miComandoInsertarUsuarios.ExecuteNonQuery()
                    altaPlaza = miComandoInsertarPlaza.ExecuteNonQuery()

                    MessageBox.Show("Reserva realizada con éxito")

                End If

            Catch ex As Exception
                MessageBox.Show("El usuario ya existe")
            Finally
                SqlConnection1.Close()
            End Try

            Me.Close()
            Call Form1.mirarPendientes()

        End If

    End Sub

    'Private Function CalculaNIF(ByVal strA As String) As String
    '    '----------------------------------------------------------------------
    '    ' Calcular la letra del NIF
    '    ' Código original adaptado a Visual Basic                   (13/Sep/95)
    '    ' Adaptado a Visual Basic .NET (VB 9.0/2008)                (09/May/08)
    '    ' y convertido en función que devuelve el NIF correcto
    '    '----------------------------------------------------------------------
    '    Const cCADENA As String = "TRWAGMYFPDXBNJZSQVHLCKE"
    '    Const cNUMEROS As String = "0123456789"
    '    Dim a, b, c, NIF As Integer
    '    Dim sb As New StringBuilder

    '    strA = Trim(strA)
    '    If Len(strA) = 0 Then Return ""

    '    ' Dejar sólo los números
    '    For i As Integer = 0 To strA.Length - 1
    '        If cNUMEROS.IndexOf(strA(i)) > -1 Then
    '            sb.Append(strA(i))
    '        End If
    '    Next

    '    strA = sb.ToString
    '    a = 0
    '    NIF = CInt(Val(strA))
    '    Do
    '        b = CInt(Int(NIF / 24))
    '        c = NIF - (24 * b)
    '        a = a + c
    '        NIF = b
    '    Loop While b <> 0
    '    b = CInt(Int(a / 23))
    '    c = a - (23 * b)

    '    Return strA & Mid(cCADENA, CInt(c + 1), 1)
    'End Function

    'Public Function Verificar_NIF(ByVal valor As String) As Boolean
    '    Dim aux As String

    '    valor = tbDNIReserva.Text

    '    valor = valor.ToUpper ' ponemos la letra en mayúscula
    '    aux = valor.Substring(0, valor.Length - 1) ' quitamos la letra del NIF

    '    If aux.Length >= 7 AndAlso IsNumeric(aux) Then
    '        aux = CalculaNIF(aux) ' calculamos la letra del NIF para comparar con la que tenemos
    '    Else
    '        Return False
    '    End If

    '    If valor <> aux Then ' comparamos las letras
    '        Return False
    '    End If

    '    Return True
    'End Function
End Class