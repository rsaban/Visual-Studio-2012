<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAccesoResidencia
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
        Me.dgvResidenciaConsultada = New System.Windows.Forms.DataGridView()
        Me.btConsultarResidencia = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.cbxAccesoResidencia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbRegistrosRecuperados = New System.Windows.Forms.TextBox()
        Me.btAccesoGestion = New System.Windows.Forms.Button()
        Me.btGenerarExcel = New System.Windows.Forms.Button()
        CType(Me.dgvResidenciaConsultada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResidenciaConsultada
        '
        Me.dgvResidenciaConsultada.AllowUserToAddRows = False
        Me.dgvResidenciaConsultada.AllowUserToDeleteRows = False
        Me.dgvResidenciaConsultada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResidenciaConsultada.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResidenciaConsultada.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResidenciaConsultada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidenciaConsultada.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResidenciaConsultada.Location = New System.Drawing.Point(41, 68)
        Me.dgvResidenciaConsultada.Name = "dgvResidenciaConsultada"
        Me.dgvResidenciaConsultada.RowHeadersVisible = False
        Me.dgvResidenciaConsultada.Size = New System.Drawing.Size(837, 341)
        Me.dgvResidenciaConsultada.TabIndex = 0
        '
        'btConsultarResidencia
        '
        Me.btConsultarResidencia.BackColor = System.Drawing.Color.Peru
        Me.btConsultarResidencia.FlatAppearance.BorderSize = 0
        Me.btConsultarResidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConsultarResidencia.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsultarResidencia.Location = New System.Drawing.Point(309, 24)
        Me.btConsultarResidencia.Name = "btConsultarResidencia"
        Me.btConsultarResidencia.Size = New System.Drawing.Size(75, 23)
        Me.btConsultarResidencia.TabIndex = 1
        Me.btConsultarResidencia.Text = "Consultar"
        Me.btConsultarResidencia.UseVisualStyleBackColor = False
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
        'cbxAccesoResidencia
        '
        Me.cbxAccesoResidencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxAccesoResidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAccesoResidencia.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAccesoResidencia.FormattingEnabled = True
        Me.cbxAccesoResidencia.Location = New System.Drawing.Point(41, 24)
        Me.cbxAccesoResidencia.Name = "cbxAccesoResidencia"
        Me.cbxAccesoResidencia.Size = New System.Drawing.Size(262, 23)
        Me.cbxAccesoResidencia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Registros Recuperados:"
        '
        'tbRegistrosRecuperados
        '
        Me.tbRegistrosRecuperados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbRegistrosRecuperados.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRegistrosRecuperados.Location = New System.Drawing.Point(165, 426)
        Me.tbRegistrosRecuperados.Name = "tbRegistrosRecuperados"
        Me.tbRegistrosRecuperados.ReadOnly = True
        Me.tbRegistrosRecuperados.Size = New System.Drawing.Size(43, 23)
        Me.tbRegistrosRecuperados.TabIndex = 6
        '
        'btAccesoGestion
        '
        Me.btAccesoGestion.BackColor = System.Drawing.Color.Peru
        Me.btAccesoGestion.FlatAppearance.BorderSize = 0
        Me.btAccesoGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAccesoGestion.Location = New System.Drawing.Point(769, 426)
        Me.btAccesoGestion.Name = "btAccesoGestion"
        Me.btAccesoGestion.Size = New System.Drawing.Size(109, 21)
        Me.btAccesoGestion.TabIndex = 2
        Me.btAccesoGestion.Text = "Acceso a Gestión"
        Me.btAccesoGestion.UseVisualStyleBackColor = False
        '
        'btGenerarExcel
        '
        Me.btGenerarExcel.BackColor = System.Drawing.Color.BurlyWood
        Me.btGenerarExcel.FlatAppearance.BorderSize = 0
        Me.btGenerarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGenerarExcel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGenerarExcel.Location = New System.Drawing.Point(390, 24)
        Me.btGenerarExcel.Name = "btGenerarExcel"
        Me.btGenerarExcel.Size = New System.Drawing.Size(91, 23)
        Me.btGenerarExcel.TabIndex = 7
        Me.btGenerarExcel.Text = "Generar Excel"
        Me.btGenerarExcel.UseVisualStyleBackColor = False
        Me.btGenerarExcel.Visible = False
        '
        'formAccesoResidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(912, 459)
        Me.Controls.Add(Me.btGenerarExcel)
        Me.Controls.Add(Me.btAccesoGestion)
        Me.Controls.Add(Me.tbRegistrosRecuperados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxAccesoResidencia)
        Me.Controls.Add(Me.btConsultarResidencia)
        Me.Controls.Add(Me.dgvResidenciaConsultada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formAccesoResidencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso a Residencias"
        CType(Me.dgvResidenciaConsultada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvResidenciaConsultada As System.Windows.Forms.DataGridView
    Friend WithEvents btConsultarResidencia As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents cbxAccesoResidencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbRegistrosRecuperados As System.Windows.Forms.TextBox
    Friend WithEvents btAccesoGestion As System.Windows.Forms.Button
    Friend WithEvents btGenerarExcel As System.Windows.Forms.Button
End Class
