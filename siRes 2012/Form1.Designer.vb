<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btDisponibilidad = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btAccesoResidencia = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.btBorrarModificar = New System.Windows.Forms.Button()
        Me.btExplotacionDatos = New System.Windows.Forms.Button()
        Me.lklbAvisadorReserva = New System.Windows.Forms.LinkLabel()
        Me.lklbPendienteCitar = New System.Windows.Forms.LinkLabel()
        Me.lklbPendientesIngresar = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Peru
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(237, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Alta de Usuario"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btDisponibilidad
        '
        Me.btDisponibilidad.BackColor = System.Drawing.Color.BurlyWood
        Me.btDisponibilidad.FlatAppearance.BorderSize = 0
        Me.btDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDisponibilidad.Location = New System.Drawing.Point(237, 223)
        Me.btDisponibilidad.Name = "btDisponibilidad"
        Me.btDisponibilidad.Size = New System.Drawing.Size(163, 27)
        Me.btDisponibilidad.TabIndex = 1
        Me.btDisponibilidad.Text = "Consulta disponibilidad"
        Me.btDisponibilidad.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Peru
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(237, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 27)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Búsqueda"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btAccesoResidencia
        '
        Me.btAccesoResidencia.BackColor = System.Drawing.Color.Peru
        Me.btAccesoResidencia.FlatAppearance.BorderSize = 0
        Me.btAccesoResidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAccesoResidencia.Location = New System.Drawing.Point(400, 223)
        Me.btAccesoResidencia.Name = "btAccesoResidencia"
        Me.btAccesoResidencia.Size = New System.Drawing.Size(163, 27)
        Me.btAccesoResidencia.TabIndex = 4
        Me.btAccesoResidencia.Text = "Acceso a Residencia"
        Me.btAccesoResidencia.UseVisualStyleBackColor = False
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
        'btBorrarModificar
        '
        Me.btBorrarModificar.BackColor = System.Drawing.Color.BurlyWood
        Me.btBorrarModificar.FlatAppearance.BorderSize = 0
        Me.btBorrarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBorrarModificar.Location = New System.Drawing.Point(400, 196)
        Me.btBorrarModificar.Name = "btBorrarModificar"
        Me.btBorrarModificar.Size = New System.Drawing.Size(163, 27)
        Me.btBorrarModificar.TabIndex = 3
        Me.btBorrarModificar.Text = "Trasladar/Actualizar Reg."
        Me.btBorrarModificar.UseVisualStyleBackColor = False
        '
        'btExplotacionDatos
        '
        Me.btExplotacionDatos.BackColor = System.Drawing.Color.BurlyWood
        Me.btExplotacionDatos.Enabled = False
        Me.btExplotacionDatos.FlatAppearance.BorderSize = 0
        Me.btExplotacionDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExplotacionDatos.Location = New System.Drawing.Point(400, 249)
        Me.btExplotacionDatos.Name = "btExplotacionDatos"
        Me.btExplotacionDatos.Size = New System.Drawing.Size(163, 27)
        Me.btExplotacionDatos.TabIndex = 5
        Me.btExplotacionDatos.Text = "Explotacion de Datos"
        Me.btExplotacionDatos.UseVisualStyleBackColor = False
        '
        'lklbAvisadorReserva
        '
        Me.lklbAvisadorReserva.AutoSize = True
        Me.lklbAvisadorReserva.LinkColor = System.Drawing.Color.DarkOliveGreen
        Me.lklbAvisadorReserva.Location = New System.Drawing.Point(247, 313)
        Me.lklbAvisadorReserva.Name = "lklbAvisadorReserva"
        Me.lklbAvisadorReserva.Size = New System.Drawing.Size(198, 15)
        Me.lklbAvisadorReserva.TabIndex = 6
        Me.lklbAvisadorReserva.TabStop = True
        Me.lklbAvisadorReserva.Text = "Aqui avisaré de las plazas reservadas"
        Me.lklbAvisadorReserva.Visible = False
        '
        'lklbPendienteCitar
        '
        Me.lklbPendienteCitar.AutoSize = True
        Me.lklbPendienteCitar.LinkColor = System.Drawing.Color.DarkOliveGreen
        Me.lklbPendienteCitar.Location = New System.Drawing.Point(247, 328)
        Me.lklbPendienteCitar.Name = "lklbPendienteCitar"
        Me.lklbPendienteCitar.Size = New System.Drawing.Size(190, 15)
        Me.lklbPendienteCitar.TabIndex = 7
        Me.lklbPendienteCitar.TabStop = True
        Me.lklbPendienteCitar.Text = "Aqui avisaré de los pendientes citar"
        Me.lklbPendienteCitar.Visible = False
        '
        'lklbPendientesIngresar
        '
        Me.lklbPendientesIngresar.AutoSize = True
        Me.lklbPendientesIngresar.LinkColor = System.Drawing.Color.DarkOliveGreen
        Me.lklbPendientesIngresar.Location = New System.Drawing.Point(247, 343)
        Me.lklbPendientesIngresar.Name = "lklbPendientesIngresar"
        Me.lklbPendientesIngresar.Size = New System.Drawing.Size(208, 15)
        Me.lklbPendientesIngresar.TabIndex = 8
        Me.lklbPendientesIngresar.TabStop = True
        Me.lklbPendientesIngresar.Text = "Aquí avisare de los pendientes ingresar"
        Me.lklbPendientesIngresar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(118, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 129)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "        "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.BurlyWood
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(237, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 27)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Acerca de..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(602, 384)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lklbAvisadorReserva)
        Me.Controls.Add(Me.lklbPendientesIngresar)
        Me.Controls.Add(Me.lklbPendienteCitar)
        Me.Controls.Add(Me.btExplotacionDatos)
        Me.Controls.Add(Me.btBorrarModificar)
        Me.Controls.Add(Me.btAccesoResidencia)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btDisponibilidad)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "siRes 0.1 (Beta)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btDisponibilidad As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btAccesoResidencia As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents btBorrarModificar As System.Windows.Forms.Button
    Friend WithEvents btExplotacionDatos As System.Windows.Forms.Button
    Friend WithEvents lklbAvisadorReserva As System.Windows.Forms.LinkLabel
    Friend WithEvents lklbPendienteCitar As System.Windows.Forms.LinkLabel
    Friend WithEvents lklbPendientesIngresar As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
