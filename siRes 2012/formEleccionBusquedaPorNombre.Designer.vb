<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEleccionBusquedaPorNombre
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvResultadoBusquedaPorNombre = New System.Windows.Forms.DataGridView()
        Me.btSeleccionarRegistro = New System.Windows.Forms.Button()
        CType(Me.dgvResultadoBusquedaPorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResultadoBusquedaPorNombre
        '
        Me.dgvResultadoBusquedaPorNombre.AllowUserToAddRows = False
        Me.dgvResultadoBusquedaPorNombre.AllowUserToDeleteRows = False
        Me.dgvResultadoBusquedaPorNombre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultadoBusquedaPorNombre.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvResultadoBusquedaPorNombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultadoBusquedaPorNombre.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultadoBusquedaPorNombre.Location = New System.Drawing.Point(12, 12)
        Me.dgvResultadoBusquedaPorNombre.Name = "dgvResultadoBusquedaPorNombre"
        Me.dgvResultadoBusquedaPorNombre.ReadOnly = True
        Me.dgvResultadoBusquedaPorNombre.RowHeadersVisible = False
        Me.dgvResultadoBusquedaPorNombre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultadoBusquedaPorNombre.Size = New System.Drawing.Size(676, 248)
        Me.dgvResultadoBusquedaPorNombre.TabIndex = 0
        '
        'btSeleccionarRegistro
        '
        Me.btSeleccionarRegistro.BackColor = System.Drawing.Color.Peru
        Me.btSeleccionarRegistro.FlatAppearance.BorderSize = 0
        Me.btSeleccionarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeleccionarRegistro.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSeleccionarRegistro.Location = New System.Drawing.Point(607, 276)
        Me.btSeleccionarRegistro.Name = "btSeleccionarRegistro"
        Me.btSeleccionarRegistro.Size = New System.Drawing.Size(81, 23)
        Me.btSeleccionarRegistro.TabIndex = 1
        Me.btSeleccionarRegistro.Text = "Seleccionar"
        Me.btSeleccionarRegistro.UseVisualStyleBackColor = False
        '
        'formEleccionBusquedaPorNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(703, 320)
        Me.Controls.Add(Me.btSeleccionarRegistro)
        Me.Controls.Add(Me.dgvResultadoBusquedaPorNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formEleccionBusquedaPorNombre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coincidencias encontradas"
        CType(Me.dgvResultadoBusquedaPorNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvResultadoBusquedaPorNombre As System.Windows.Forms.DataGridView
    Friend WithEvents btSeleccionarRegistro As System.Windows.Forms.Button
End Class
