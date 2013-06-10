<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPlazasSinFormalizar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbPlazasSinFormalizar = New System.Windows.Forms.Label()
        Me.dgvPlazasReservadas = New System.Windows.Forms.DataGridView()
        Me.btPaFormalizar = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.btFormalizarIngreso = New System.Windows.Forms.Button()
        Me.btCancelarReserva = New System.Windows.Forms.Button()
        CType(Me.dgvPlazasReservadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbPlazasSinFormalizar
        '
        Me.lbPlazasSinFormalizar.AutoSize = True
        Me.lbPlazasSinFormalizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPlazasSinFormalizar.Location = New System.Drawing.Point(25, 20)
        Me.lbPlazasSinFormalizar.Name = "lbPlazasSinFormalizar"
        Me.lbPlazasSinFormalizar.Size = New System.Drawing.Size(39, 15)
        Me.lbPlazasSinFormalizar.TabIndex = 0
        Me.lbPlazasSinFormalizar.Text = "Label1"
        '
        'dgvPlazasReservadas
        '
        Me.dgvPlazasReservadas.AllowUserToAddRows = False
        Me.dgvPlazasReservadas.AllowUserToDeleteRows = False
        Me.dgvPlazasReservadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlazasReservadas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlazasReservadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPlazasReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPlazasReservadas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPlazasReservadas.Location = New System.Drawing.Point(28, 46)
        Me.dgvPlazasReservadas.Name = "dgvPlazasReservadas"
        Me.dgvPlazasReservadas.ReadOnly = True
        Me.dgvPlazasReservadas.RowHeadersVisible = False
        Me.dgvPlazasReservadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlazasReservadas.Size = New System.Drawing.Size(568, 260)
        Me.dgvPlazasReservadas.TabIndex = 1
        '
        'btPaFormalizar
        '
        Me.btPaFormalizar.AutoSize = True
        Me.btPaFormalizar.BackColor = System.Drawing.Color.Peru
        Me.btPaFormalizar.FlatAppearance.BorderSize = 0
        Me.btPaFormalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPaFormalizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPaFormalizar.Location = New System.Drawing.Point(488, 321)
        Me.btPaFormalizar.Name = "btPaFormalizar"
        Me.btPaFormalizar.Size = New System.Drawing.Size(32, 27)
        Me.btPaFormalizar.TabIndex = 4
        Me.btPaFormalizar.Text = "Ir"
        Me.btPaFormalizar.UseVisualStyleBackColor = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Documents and Settings\WinXP\Escrit" & _
            "orio\siRes\siRes\siRes\bdResidentes.mdf"";Integrated Security=True;Connect Timeou" & _
            "t=30;User Instance=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'btFormalizarIngreso
        '
        Me.btFormalizarIngreso.BackColor = System.Drawing.Color.Peru
        Me.btFormalizarIngreso.FlatAppearance.BorderSize = 0
        Me.btFormalizarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFormalizarIngreso.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFormalizarIngreso.Location = New System.Drawing.Point(356, 323)
        Me.btFormalizarIngreso.Name = "btFormalizarIngreso"
        Me.btFormalizarIngreso.Size = New System.Drawing.Size(115, 23)
        Me.btFormalizarIngreso.TabIndex = 5
        Me.btFormalizarIngreso.Text = "Formalizar Ingreso"
        Me.btFormalizarIngreso.UseVisualStyleBackColor = False
        '
        'btCancelarReserva
        '
        Me.btCancelarReserva.BackColor = System.Drawing.Color.Peru
        Me.btCancelarReserva.FlatAppearance.BorderSize = 0
        Me.btCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelarReserva.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelarReserva.Location = New System.Drawing.Point(230, 323)
        Me.btCancelarReserva.Name = "btCancelarReserva"
        Me.btCancelarReserva.Size = New System.Drawing.Size(107, 23)
        Me.btCancelarReserva.TabIndex = 6
        Me.btCancelarReserva.Text = "Cancelar Reserva"
        Me.btCancelarReserva.UseVisualStyleBackColor = False
        '
        'formPlazasSinFormalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(627, 364)
        Me.Controls.Add(Me.btCancelarReserva)
        Me.Controls.Add(Me.btFormalizarIngreso)
        Me.Controls.Add(Me.btPaFormalizar)
        Me.Controls.Add(Me.dgvPlazasReservadas)
        Me.Controls.Add(Me.lbPlazasSinFormalizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formPlazasSinFormalizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plazas sin formalizar"
        CType(Me.dgvPlazasReservadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPlazasSinFormalizar As System.Windows.Forms.Label
    Friend WithEvents dgvPlazasReservadas As System.Windows.Forms.DataGridView
    Friend WithEvents btPaFormalizar As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents btFormalizarIngreso As System.Windows.Forms.Button
    Friend WithEvents btCancelarReserva As System.Windows.Forms.Button
End Class
