<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTraslado
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
        Me.cbxResidenciaOrigen = New System.Windows.Forms.ComboBox()
        Me.cbxResidenciaDestino = New System.Windows.Forms.ComboBox()
        Me.cbxTipoPlazaOrigen = New System.Windows.Forms.ComboBox()
        Me.cbxTipoPlazaDestino = New System.Windows.Forms.ComboBox()
        Me.dtpFechaBajaOrigen = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaAltaDestino = New System.Windows.Forms.DateTimePicker()
        Me.gbOrigen = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btTraslado = New System.Windows.Forms.Button()
        Me.tbExpedienteTraslado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.gbOrigen.SuspendLayout()
        Me.gbDestino.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxResidenciaOrigen
        '
        Me.cbxResidenciaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxResidenciaOrigen.Enabled = False
        Me.cbxResidenciaOrigen.FormattingEnabled = True
        Me.cbxResidenciaOrigen.Location = New System.Drawing.Point(101, 19)
        Me.cbxResidenciaOrigen.Name = "cbxResidenciaOrigen"
        Me.cbxResidenciaOrigen.Size = New System.Drawing.Size(251, 23)
        Me.cbxResidenciaOrigen.TabIndex = 2
        '
        'cbxResidenciaDestino
        '
        Me.cbxResidenciaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxResidenciaDestino.FormattingEnabled = True
        Me.cbxResidenciaDestino.Location = New System.Drawing.Point(101, 19)
        Me.cbxResidenciaDestino.Name = "cbxResidenciaDestino"
        Me.cbxResidenciaDestino.Size = New System.Drawing.Size(251, 23)
        Me.cbxResidenciaDestino.TabIndex = 7
        '
        'cbxTipoPlazaOrigen
        '
        Me.cbxTipoPlazaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTipoPlazaOrigen.Enabled = False
        Me.cbxTipoPlazaOrigen.FormattingEnabled = True
        Me.cbxTipoPlazaOrigen.Location = New System.Drawing.Point(101, 46)
        Me.cbxTipoPlazaOrigen.Name = "cbxTipoPlazaOrigen"
        Me.cbxTipoPlazaOrigen.Size = New System.Drawing.Size(188, 23)
        Me.cbxTipoPlazaOrigen.TabIndex = 4
        '
        'cbxTipoPlazaDestino
        '
        Me.cbxTipoPlazaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTipoPlazaDestino.FormattingEnabled = True
        Me.cbxTipoPlazaDestino.Location = New System.Drawing.Point(101, 46)
        Me.cbxTipoPlazaDestino.Name = "cbxTipoPlazaDestino"
        Me.cbxTipoPlazaDestino.Size = New System.Drawing.Size(188, 23)
        Me.cbxTipoPlazaDestino.TabIndex = 8
        '
        'dtpFechaBajaOrigen
        '
        Me.dtpFechaBajaOrigen.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpFechaBajaOrigen.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaBajaOrigen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBajaOrigen.Location = New System.Drawing.Point(101, 73)
        Me.dtpFechaBajaOrigen.Name = "dtpFechaBajaOrigen"
        Me.dtpFechaBajaOrigen.Size = New System.Drawing.Size(121, 23)
        Me.dtpFechaBajaOrigen.TabIndex = 6
        '
        'dtpFechaAltaDestino
        '
        Me.dtpFechaAltaDestino.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpFechaAltaDestino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAltaDestino.Location = New System.Drawing.Point(101, 76)
        Me.dtpFechaAltaDestino.Name = "dtpFechaAltaDestino"
        Me.dtpFechaAltaDestino.Size = New System.Drawing.Size(121, 23)
        Me.dtpFechaAltaDestino.TabIndex = 9
        '
        'gbOrigen
        '
        Me.gbOrigen.Controls.Add(Me.Label3)
        Me.gbOrigen.Controls.Add(Me.Label2)
        Me.gbOrigen.Controls.Add(Me.Label1)
        Me.gbOrigen.Controls.Add(Me.cbxResidenciaOrigen)
        Me.gbOrigen.Controls.Add(Me.dtpFechaBajaOrigen)
        Me.gbOrigen.Controls.Add(Me.cbxTipoPlazaOrigen)
        Me.gbOrigen.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOrigen.Location = New System.Drawing.Point(12, 45)
        Me.gbOrigen.Name = "gbOrigen"
        Me.gbOrigen.Size = New System.Drawing.Size(368, 120)
        Me.gbOrigen.TabIndex = 8
        Me.gbOrigen.TabStop = False
        Me.gbOrigen.Text = "ORIGEN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha de Baja:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo de Plaza:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Residencia:"
        '
        'gbDestino
        '
        Me.gbDestino.Controls.Add(Me.Label4)
        Me.gbDestino.Controls.Add(Me.Label6)
        Me.gbDestino.Controls.Add(Me.Label5)
        Me.gbDestino.Controls.Add(Me.cbxResidenciaDestino)
        Me.gbDestino.Controls.Add(Me.dtpFechaAltaDestino)
        Me.gbDestino.Controls.Add(Me.cbxTipoPlazaDestino)
        Me.gbDestino.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDestino.Location = New System.Drawing.Point(12, 171)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(368, 120)
        Me.gbDestino.TabIndex = 9
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "DESTINO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Residencia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha de Alta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipo de Plaza:"
        '
        'btTraslado
        '
        Me.btTraslado.BackColor = System.Drawing.Color.Peru
        Me.btTraslado.FlatAppearance.BorderSize = 0
        Me.btTraslado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTraslado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTraslado.Location = New System.Drawing.Point(305, 307)
        Me.btTraslado.Name = "btTraslado"
        Me.btTraslado.Size = New System.Drawing.Size(75, 23)
        Me.btTraslado.TabIndex = 10
        Me.btTraslado.Text = "Trasladar"
        Me.btTraslado.UseVisualStyleBackColor = False
        '
        'tbExpedienteTraslado
        '
        Me.tbExpedienteTraslado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbExpedienteTraslado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExpedienteTraslado.Location = New System.Drawing.Point(113, 16)
        Me.tbExpedienteTraslado.Name = "tbExpedienteTraslado"
        Me.tbExpedienteTraslado.Size = New System.Drawing.Size(121, 23)
        Me.tbExpedienteTraslado.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Expediente Nº:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'formTraslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(390, 348)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbExpedienteTraslado)
        Me.Controls.Add(Me.btTraslado)
        Me.Controls.Add(Me.gbDestino)
        Me.Controls.Add(Me.gbOrigen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formTraslado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRASLADO DE CENTRO"
        Me.gbOrigen.ResumeLayout(False)
        Me.gbOrigen.PerformLayout()
        Me.gbDestino.ResumeLayout(False)
        Me.gbDestino.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxResidenciaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cbxResidenciaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTipoPlazaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTipoPlazaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaBajaOrigen As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaAltaDestino As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbOrigen As System.Windows.Forms.GroupBox
    Friend WithEvents gbDestino As System.Windows.Forms.GroupBox
    Friend WithEvents btTraslado As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbExpedienteTraslado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
