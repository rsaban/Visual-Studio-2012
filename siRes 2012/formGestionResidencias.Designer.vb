<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGestionResidencias
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
        Me.components = New System.ComponentModel.Container()
        Me.cbxCentroResidencial = New System.Windows.Forms.ComboBox()
        Me.tbNombreResidencia = New System.Windows.Forms.TextBox()
        Me.tbPlazasMayores = New System.Windows.Forms.TextBox()
        Me.tbPlazasExclusion = New System.Windows.Forms.TextBox()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.tbPlazasTrastornos = New System.Windows.Forms.TextBox()
        Me.btAñadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxCentroResidencial
        '
        Me.cbxCentroResidencial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxCentroResidencial.FormattingEnabled = True
        Me.cbxCentroResidencial.Location = New System.Drawing.Point(134, 18)
        Me.cbxCentroResidencial.Name = "cbxCentroResidencial"
        Me.cbxCentroResidencial.Size = New System.Drawing.Size(334, 23)
        Me.cbxCentroResidencial.TabIndex = 0
        '
        'tbNombreResidencia
        '
        Me.tbNombreResidencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreResidencia.Location = New System.Drawing.Point(65, 25)
        Me.tbNombreResidencia.Name = "tbNombreResidencia"
        Me.tbNombreResidencia.Size = New System.Drawing.Size(369, 23)
        Me.tbNombreResidencia.TabIndex = 1
        '
        'tbPlazasMayores
        '
        Me.tbPlazasMayores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPlazasMayores.Location = New System.Drawing.Point(367, 55)
        Me.tbPlazasMayores.Name = "tbPlazasMayores"
        Me.tbPlazasMayores.Size = New System.Drawing.Size(67, 23)
        Me.tbPlazasMayores.TabIndex = 2
        '
        'tbPlazasExclusion
        '
        Me.tbPlazasExclusion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPlazasExclusion.Location = New System.Drawing.Point(367, 85)
        Me.tbPlazasExclusion.Name = "tbPlazasExclusion"
        Me.tbPlazasExclusion.Size = New System.Drawing.Size(67, 23)
        Me.tbPlazasExclusion.TabIndex = 3
        '
        'btActualizar
        '
        Me.btActualizar.BackColor = System.Drawing.Color.Peru
        Me.btActualizar.FlatAppearance.BorderSize = 0
        Me.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btActualizar.Location = New System.Drawing.Point(381, 237)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(87, 27)
        Me.btActualizar.TabIndex = 5
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = False
        '
        'tbPlazasTrastornos
        '
        Me.tbPlazasTrastornos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPlazasTrastornos.Location = New System.Drawing.Point(367, 115)
        Me.tbPlazasTrastornos.Name = "tbPlazasTrastornos"
        Me.tbPlazasTrastornos.Size = New System.Drawing.Size(67, 23)
        Me.tbPlazasTrastornos.TabIndex = 4
        '
        'btAñadir
        '
        Me.btAñadir.BackColor = System.Drawing.Color.Peru
        Me.btAñadir.FlatAppearance.BorderSize = 0
        Me.btAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAñadir.Location = New System.Drawing.Point(207, 237)
        Me.btAñadir.Name = "btAñadir"
        Me.btAñadir.Size = New System.Drawing.Size(87, 27)
        Me.btAñadir.TabIndex = 6
        Me.btAñadir.Text = "Añadir"
        Me.btAñadir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Plazas de Mayores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Plazas de Exclusion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Plazas de Trastornos de Conducta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Seleccionar Centro"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbPlazasMayores)
        Me.GroupBox1.Controls.Add(Me.tbNombreResidencia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbPlazasExclusion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbPlazasTrastornos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 172)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btEliminar
        '
        Me.btEliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btEliminar.FlatAppearance.BorderSize = 0
        Me.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEliminar.Location = New System.Drawing.Point(294, 237)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(87, 27)
        Me.btEliminar.TabIndex = 7
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = False
        '
        'formGestionResidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(492, 277)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btAñadir)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.cbxCentroResidencial)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formGestionResidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Residencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxCentroResidencial As System.Windows.Forms.ComboBox
    Friend WithEvents tbNombreResidencia As System.Windows.Forms.TextBox
    Friend WithEvents tbPlazasMayores As System.Windows.Forms.TextBox
    Friend WithEvents tbPlazasExclusion As System.Windows.Forms.TextBox
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Friend WithEvents tbPlazasTrastornos As System.Windows.Forms.TextBox
    Friend WithEvents btAñadir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btEliminar As System.Windows.Forms.Button
End Class
