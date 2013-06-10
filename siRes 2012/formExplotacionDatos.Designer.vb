<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formExplotacionDatos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxAñoIngresoExplotacion = New System.Windows.Forms.ComboBox()
        Me.btConsulta = New System.Windows.Forms.Button()
        Me.cbxAltaBajaExplotacion = New System.Windows.Forms.ComboBox()
        Me.cbxTipoPlazaExplotacion = New System.Windows.Forms.ComboBox()
        Me.cbxResidenciaExplotacion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvExplotacionDatos = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbRegistrosRecuperados = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvExplotacionDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxAñoIngresoExplotacion)
        Me.GroupBox1.Controls.Add(Me.btConsulta)
        Me.GroupBox1.Controls.Add(Me.cbxAltaBajaExplotacion)
        Me.GroupBox1.Controls.Add(Me.cbxTipoPlazaExplotacion)
        Me.GroupBox1.Controls.Add(Me.cbxResidenciaExplotacion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterios de Consulta"
        '
        'cbxAñoIngresoExplotacion
        '
        Me.cbxAñoIngresoExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAñoIngresoExplotacion.FormattingEnabled = True
        Me.cbxAñoIngresoExplotacion.Items.AddRange(New Object() {"", "2011", "2010", "2009", "2008", "2007"})
        Me.cbxAñoIngresoExplotacion.Location = New System.Drawing.Point(100, 25)
        Me.cbxAñoIngresoExplotacion.Name = "cbxAñoIngresoExplotacion"
        Me.cbxAñoIngresoExplotacion.Size = New System.Drawing.Size(121, 21)
        Me.cbxAñoIngresoExplotacion.TabIndex = 9
        '
        'btConsulta
        '
        Me.btConsulta.Location = New System.Drawing.Point(614, 100)
        Me.btConsulta.Name = "btConsulta"
        Me.btConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btConsulta.TabIndex = 8
        Me.btConsulta.Text = "Consulta"
        Me.btConsulta.UseVisualStyleBackColor = True
        '
        'cbxAltaBajaExplotacion
        '
        Me.cbxAltaBajaExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAltaBajaExplotacion.FormattingEnabled = True
        Me.cbxAltaBajaExplotacion.Items.AddRange(New Object() {"", "ALTA", "BAJA"})
        Me.cbxAltaBajaExplotacion.Location = New System.Drawing.Point(100, 79)
        Me.cbxAltaBajaExplotacion.Name = "cbxAltaBajaExplotacion"
        Me.cbxAltaBajaExplotacion.Size = New System.Drawing.Size(100, 21)
        Me.cbxAltaBajaExplotacion.TabIndex = 7
        '
        'cbxTipoPlazaExplotacion
        '
        Me.cbxTipoPlazaExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoPlazaExplotacion.FormattingEnabled = True
        Me.cbxTipoPlazaExplotacion.Items.AddRange(New Object() {"", "MAYORES", "EXCLUSION", "TRASTORNOS DE CONDUCTA"})
        Me.cbxTipoPlazaExplotacion.Location = New System.Drawing.Point(438, 52)
        Me.cbxTipoPlazaExplotacion.Name = "cbxTipoPlazaExplotacion"
        Me.cbxTipoPlazaExplotacion.Size = New System.Drawing.Size(189, 21)
        Me.cbxTipoPlazaExplotacion.TabIndex = 6
        '
        'cbxResidenciaExplotacion
        '
        Me.cbxResidenciaExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxResidenciaExplotacion.FormattingEnabled = True
        Me.cbxResidenciaExplotacion.Location = New System.Drawing.Point(100, 52)
        Me.cbxResidenciaExplotacion.Name = "cbxResidenciaExplotacion"
        Me.cbxResidenciaExplotacion.Size = New System.Drawing.Size(231, 21)
        Me.cbxResidenciaExplotacion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo de Plaza:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alta/Baja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Residencia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Año de Ingreso:"
        '
        'dgvExplotacionDatos
        '
        Me.dgvExplotacionDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExplotacionDatos.Location = New System.Drawing.Point(24, 159)
        Me.dgvExplotacionDatos.Name = "dgvExplotacionDatos"
        Me.dgvExplotacionDatos.Size = New System.Drawing.Size(695, 219)
        Me.dgvExplotacionDatos.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(21, 393)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(121, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Registros Recuperados:"
        '
        'tbRegistrosRecuperados
        '
        Me.tbRegistrosRecuperados.Location = New System.Drawing.Point(148, 390)
        Me.tbRegistrosRecuperados.Name = "tbRegistrosRecuperados"
        Me.tbRegistrosRecuperados.Size = New System.Drawing.Size(39, 20)
        Me.tbRegistrosRecuperados.TabIndex = 3
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Documents and Settings\WinXP\Escrit" & _
            "orio\siRes\siRes\siRes\bdResidentes.mdf"";Integrated Security=True;Connect Timeou" & _
            "t=30;User Instance=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'formExplotacionDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 431)
        Me.Controls.Add(Me.tbRegistrosRecuperados)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgvExplotacionDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formExplotacionDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Explotacion Datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvExplotacionDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxAltaBajaExplotacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTipoPlazaExplotacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbxResidenciaExplotacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvExplotacionDatos As System.Windows.Forms.DataGridView
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents tbRegistrosRecuperados As System.Windows.Forms.TextBox
    Friend WithEvents btConsulta As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents cbxAñoIngresoExplotacion As System.Windows.Forms.ComboBox
End Class
