<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReapertura
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
        Me.btReapertura = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbExpedienteReapertura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNombreReapertura = New System.Windows.Forms.TextBox()
        Me.cbxResidenciaReapertura = New System.Windows.Forms.ComboBox()
        Me.cbxTipoPlazaReapertura = New System.Windows.Forms.ComboBox()
        Me.dtpReapertura = New System.Windows.Forms.DateTimePicker()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SuspendLayout()
        '
        'btReapertura
        '
        Me.btReapertura.BackColor = System.Drawing.Color.Peru
        Me.btReapertura.FlatAppearance.BorderSize = 0
        Me.btReapertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReapertura.Location = New System.Drawing.Point(360, 128)
        Me.btReapertura.Name = "btReapertura"
        Me.btReapertura.Size = New System.Drawing.Size(123, 29)
        Me.btReapertura.TabIndex = 11
        Me.btReapertura.Text = "Reabrir Expediente"
        Me.btReapertura.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EXPDTE:"
        '
        'tbExpedienteReapertura
        '
        Me.tbExpedienteReapertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbExpedienteReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExpedienteReapertura.Location = New System.Drawing.Point(71, 27)
        Me.tbExpedienteReapertura.Name = "tbExpedienteReapertura"
        Me.tbExpedienteReapertura.ReadOnly = True
        Me.tbExpedienteReapertura.Size = New System.Drawing.Size(140, 23)
        Me.tbExpedienteReapertura.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(217, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RESIDENCIA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "TIPO DE PLAZA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "FECHA DE INGRESO:"
        '
        'tbNombreReapertura
        '
        Me.tbNombreReapertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreReapertura.Location = New System.Drawing.Point(280, 27)
        Me.tbNombreReapertura.Name = "tbNombreReapertura"
        Me.tbNombreReapertura.ReadOnly = True
        Me.tbNombreReapertura.Size = New System.Drawing.Size(203, 23)
        Me.tbNombreReapertura.TabIndex = 7
        '
        'cbxResidenciaReapertura
        '
        Me.cbxResidenciaReapertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxResidenciaReapertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxResidenciaReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxResidenciaReapertura.FormattingEnabled = True
        Me.cbxResidenciaReapertura.Location = New System.Drawing.Point(132, 53)
        Me.cbxResidenciaReapertura.Name = "cbxResidenciaReapertura"
        Me.cbxResidenciaReapertura.Size = New System.Drawing.Size(229, 23)
        Me.cbxResidenciaReapertura.TabIndex = 8
        '
        'cbxTipoPlazaReapertura
        '
        Me.cbxTipoPlazaReapertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTipoPlazaReapertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoPlazaReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoPlazaReapertura.FormattingEnabled = True
        Me.cbxTipoPlazaReapertura.Location = New System.Drawing.Point(132, 80)
        Me.cbxTipoPlazaReapertura.Name = "cbxTipoPlazaReapertura"
        Me.cbxTipoPlazaReapertura.Size = New System.Drawing.Size(166, 23)
        Me.cbxTipoPlazaReapertura.TabIndex = 9
        '
        'dtpReapertura
        '
        Me.dtpReapertura.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpReapertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReapertura.Location = New System.Drawing.Point(132, 107)
        Me.dtpReapertura.Name = "dtpReapertura"
        Me.dtpReapertura.Size = New System.Drawing.Size(93, 20)
        Me.dtpReapertura.TabIndex = 10
        '
        'SqlConnection1
        '
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'formReapertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(500, 176)
        Me.Controls.Add(Me.dtpReapertura)
        Me.Controls.Add(Me.cbxTipoPlazaReapertura)
        Me.Controls.Add(Me.cbxResidenciaReapertura)
        Me.Controls.Add(Me.tbNombreReapertura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbExpedienteReapertura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btReapertura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formReapertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reapertura de Expediente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btReapertura As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbExpedienteReapertura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNombreReapertura As System.Windows.Forms.TextBox
    Friend WithEvents cbxResidenciaReapertura As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTipoPlazaReapertura As System.Windows.Forms.ComboBox
    Friend WithEvents dtpReapertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
