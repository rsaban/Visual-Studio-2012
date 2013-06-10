<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFechaIngreso
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
        Me.btFormalizar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.tbExpdte = New System.Windows.Forms.TextBox()
        Me.tbResidencia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btFormalizar
        '
        Me.btFormalizar.BackColor = System.Drawing.Color.Peru
        Me.btFormalizar.FlatAppearance.BorderSize = 0
        Me.btFormalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFormalizar.Location = New System.Drawing.Point(86, 103)
        Me.btFormalizar.Name = "btFormalizar"
        Me.btFormalizar.Size = New System.Drawing.Size(160, 27)
        Me.btFormalizar.TabIndex = 0
        Me.btFormalizar.Text = "Formalizar Ingreso"
        Me.btFormalizar.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 23)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Introducir Fecha de Ingreso:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'tbExpdte
        '
        Me.tbExpdte.Location = New System.Drawing.Point(1, 2)
        Me.tbExpdte.Name = "tbExpdte"
        Me.tbExpdte.Size = New System.Drawing.Size(74, 23)
        Me.tbExpdte.TabIndex = 3
        Me.tbExpdte.Visible = False
        '
        'tbResidencia
        '
        Me.tbResidencia.Location = New System.Drawing.Point(83, 2)
        Me.tbResidencia.Name = "tbResidencia"
        Me.tbResidencia.Size = New System.Drawing.Size(231, 23)
        Me.tbResidencia.TabIndex = 4
        Me.tbResidencia.Visible = False
        '
        'formFechaIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(329, 162)
        Me.Controls.Add(Me.tbResidencia)
        Me.Controls.Add(Me.tbExpdte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btFormalizar)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formFechaIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Completando el Alta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btFormalizar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents tbExpdte As System.Windows.Forms.TextBox
    Friend WithEvents tbResidencia As System.Windows.Forms.TextBox
End Class
