<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDisponibilidad
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
        Me.ListViewDisponibilidad = New System.Windows.Forms.ListView()
        Me.btReservarPlaza = New System.Windows.Forms.Button()
        Me.btFormalizarAlta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewDisponibilidad
        '
        Me.ListViewDisponibilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListViewDisponibilidad.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewDisponibilidad.Location = New System.Drawing.Point(12, 12)
        Me.ListViewDisponibilidad.Name = "ListViewDisponibilidad"
        Me.ListViewDisponibilidad.Size = New System.Drawing.Size(456, 440)
        Me.ListViewDisponibilidad.TabIndex = 0
        Me.ListViewDisponibilidad.UseCompatibleStateImageBehavior = False
        Me.ListViewDisponibilidad.View = System.Windows.Forms.View.List
        '
        'btReservarPlaza
        '
        Me.btReservarPlaza.BackColor = System.Drawing.Color.Peru
        Me.btReservarPlaza.FlatAppearance.BorderSize = 0
        Me.btReservarPlaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReservarPlaza.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReservarPlaza.Location = New System.Drawing.Point(249, 468)
        Me.btReservarPlaza.Name = "btReservarPlaza"
        Me.btReservarPlaza.Size = New System.Drawing.Size(106, 23)
        Me.btReservarPlaza.TabIndex = 1
        Me.btReservarPlaza.Text = "Reservar plaza"
        Me.btReservarPlaza.UseVisualStyleBackColor = False
        '
        'btFormalizarAlta
        '
        Me.btFormalizarAlta.BackColor = System.Drawing.Color.BurlyWood
        Me.btFormalizarAlta.FlatAppearance.BorderSize = 0
        Me.btFormalizarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFormalizarAlta.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFormalizarAlta.Location = New System.Drawing.Point(373, 468)
        Me.btFormalizarAlta.Name = "btFormalizarAlta"
        Me.btFormalizarAlta.Size = New System.Drawing.Size(95, 23)
        Me.btFormalizarAlta.TabIndex = 2
        Me.btFormalizarAlta.Text = "Formalizar Alta"
        Me.btFormalizarAlta.UseVisualStyleBackColor = False
        '
        'formDisponibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(480, 512)
        Me.Controls.Add(Me.btFormalizarAlta)
        Me.Controls.Add(Me.btReservarPlaza)
        Me.Controls.Add(Me.ListViewDisponibilidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formDisponibilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plazas Disponibles"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewDisponibilidad As System.Windows.Forms.ListView
    Friend WithEvents btReservarPlaza As System.Windows.Forms.Button
    Friend WithEvents btFormalizarAlta As System.Windows.Forms.Button
End Class
