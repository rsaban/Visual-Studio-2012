<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReserva
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btReservar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.tbExpdteReserva = New System.Windows.Forms.TextBox()
        Me.tbNombreReserva = New System.Windows.Forms.TextBox()
        Me.tbDNIReserva = New System.Windows.Forms.TextBox()
        Me.cbxResidenciaReserva = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTipoPlazaReserva = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btReservar
        '
        Me.btReservar.BackColor = System.Drawing.Color.Peru
        Me.btReservar.FlatAppearance.BorderSize = 0
        Me.btReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReservar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReservar.Location = New System.Drawing.Point(216, 169)
        Me.btReservar.Name = "btReservar"
        Me.btReservar.Size = New System.Drawing.Size(75, 23)
        Me.btReservar.TabIndex = 12
        Me.btReservar.Text = "Reservar"
        Me.btReservar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.BurlyWood
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(297, 169)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 13
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'tbExpdteReserva
        '
        Me.tbExpdteReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbExpdteReserva.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExpdteReserva.Location = New System.Drawing.Point(103, 21)
        Me.tbExpdteReserva.Name = "tbExpdteReserva"
        Me.tbExpdteReserva.Size = New System.Drawing.Size(100, 23)
        Me.tbExpdteReserva.TabIndex = 2
        '
        'tbNombreReserva
        '
        Me.tbNombreReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreReserva.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreReserva.Location = New System.Drawing.Point(103, 47)
        Me.tbNombreReserva.Name = "tbNombreReserva"
        Me.tbNombreReserva.Size = New System.Drawing.Size(238, 23)
        Me.tbNombreReserva.TabIndex = 3
        '
        'tbDNIReserva
        '
        Me.tbDNIReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDNIReserva.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDNIReserva.Location = New System.Drawing.Point(103, 73)
        Me.tbDNIReserva.Name = "tbDNIReserva"
        Me.tbDNIReserva.Size = New System.Drawing.Size(100, 23)
        Me.tbDNIReserva.TabIndex = 4
        '
        'cbxResidenciaReserva
        '
        Me.cbxResidenciaReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxResidenciaReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxResidenciaReserva.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxResidenciaReserva.FormattingEnabled = True
        Me.cbxResidenciaReserva.Location = New System.Drawing.Point(103, 99)
        Me.cbxResidenciaReserva.Name = "cbxResidenciaReserva"
        Me.cbxResidenciaReserva.Size = New System.Drawing.Size(238, 23)
        Me.cbxResidenciaReserva.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "EXPDTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DNI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "RESIDENCIA:"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     ResidentesEnAlta.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         ResidentesEnAlta"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Documents and Settings\WinXP\Escrit" & _
            "orio\siRes\siRes\siRes\bdResidentes.mdf"";Integrated Security=True;Connect Timeou" & _
            "t=30;User Instance=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [ResidentesEnAlta] ([EXPDTE], [NOMBRE], [RESIDENCIA]) VALUES (@EXPDTE" & _
            ", @NOMBRE, @RESIDENCIA)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EXPDTE", System.Data.SqlDbType.NVarChar, 0, "EXPDTE"), New System.Data.SqlClient.SqlParameter("@NOMBRE", System.Data.SqlDbType.NVarChar, 0, "NOMBRE"), New System.Data.SqlClient.SqlParameter("@RESIDENCIA", System.Data.SqlDbType.NChar, 0, "RESIDENCIA")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ResidentesEnAlta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EXPDTE", "EXPDTE"), New System.Data.Common.DataColumnMapping("NOMBRE", "NOMBRE"), New System.Data.Common.DataColumnMapping("RESIDENCIA", "RESIDENCIA")})})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TIPO PLAZA:"
        '
        'cbxTipoPlazaReserva
        '
        Me.cbxTipoPlazaReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTipoPlazaReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoPlazaReserva.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoPlazaReserva.FormattingEnabled = True
        Me.cbxTipoPlazaReserva.Location = New System.Drawing.Point(103, 126)
        Me.cbxTipoPlazaReserva.Name = "cbxTipoPlazaReserva"
        Me.cbxTipoPlazaReserva.Size = New System.Drawing.Size(185, 23)
        Me.cbxTipoPlazaReserva.TabIndex = 11
        '
        'formReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(388, 215)
        Me.Controls.Add(Me.cbxTipoPlazaReserva)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxResidenciaReserva)
        Me.Controls.Add(Me.tbDNIReserva)
        Me.Controls.Add(Me.tbNombreReserva)
        Me.Controls.Add(Me.tbExpdteReserva)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btReservar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva de plaza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btReservar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents tbExpdteReserva As System.Windows.Forms.TextBox
    Friend WithEvents tbNombreReserva As System.Windows.Forms.TextBox
    Friend WithEvents tbDNIReserva As System.Windows.Forms.TextBox
    Friend WithEvents cbxResidenciaReserva As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoPlazaReserva As System.Windows.Forms.ComboBox
End Class
