<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAltaUsuario
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
        Me.lbCompletaDatos = New System.Windows.Forms.Label()
        Me.tbExpediente = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.btAceptarAltaUsuario = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbVIaAcceso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbISE = New System.Windows.Forms.TextBox()
        Me.cbxCentroResidencial = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxTipoPlaza = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.BdResidentesDataSet1 = New siRes.bdResidentesDataSet()
        Me.cbxPendienteIngresar = New System.Windows.Forms.CheckBox()
        Me.cbxPendienteCitar = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.BdResidentesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCompletaDatos
        '
        Me.lbCompletaDatos.AutoSize = True
        Me.lbCompletaDatos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompletaDatos.Location = New System.Drawing.Point(68, 13)
        Me.lbCompletaDatos.Name = "lbCompletaDatos"
        Me.lbCompletaDatos.Size = New System.Drawing.Size(53, 15)
        Me.lbCompletaDatos.TabIndex = 0
        Me.lbCompletaDatos.Text = "EXPDTE:"
        '
        'tbExpediente
        '
        Me.tbExpediente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbExpediente.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExpediente.Location = New System.Drawing.Point(127, 10)
        Me.tbExpediente.Name = "tbExpediente"
        Me.tbExpediente.Size = New System.Drawing.Size(88, 23)
        Me.tbExpediente.TabIndex = 1
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombre.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(127, 37)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(235, 23)
        Me.tbNombre.TabIndex = 2
        '
        'btAceptarAltaUsuario
        '
        Me.btAceptarAltaUsuario.BackColor = System.Drawing.Color.Peru
        Me.btAceptarAltaUsuario.FlatAppearance.BorderSize = 0
        Me.btAceptarAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptarAltaUsuario.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAceptarAltaUsuario.Location = New System.Drawing.Point(267, 449)
        Me.btAceptarAltaUsuario.Name = "btAceptarAltaUsuario"
        Me.btAceptarAltaUsuario.Size = New System.Drawing.Size(139, 23)
        Me.btAceptarAltaUsuario.TabIndex = 12
        Me.btAceptarAltaUsuario.Text = "Formalizar el Alta"
        Me.btAceptarAltaUsuario.UseVisualStyleBackColor = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Documents and Settings\WinXP\Escrit" & _
            "orio\siRes\siRes\siRes\bdResidentes.mdf"";Integrated Security=True;Connect Timeou" & _
            "t=30;User Instance=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     ResidentesEnAlta.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         ResidentesEnAlta"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [ResidentesEnAlta] ([EXPDTE], [NOMBRE], [RESIDENCIA]) VALUES (@EXPDTE" & _
            ", @NOMBRE, @RESIDENCIA)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EXPDTE", System.Data.SqlDbType.NVarChar, 0, "EXPDTE"), New System.Data.SqlClient.SqlParameter("@NOMBRE", System.Data.SqlDbType.NVarChar, 0, "NOMBRE"), New System.Data.SqlClient.SqlParameter("@RESIDENCIA", System.Data.SqlDbType.NVarChar, 0, "RESIDENCIA")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ResidentesEnAlta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EXPDTE", "EXPDTE"), New System.Data.Common.DataColumnMapping("NOMBRE", "NOMBRE"), New System.Data.Common.DataColumnMapping("RESIDENCIA", "RESIDENCIA")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlCommand1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DNI:"
        '
        'tbDNI
        '
        Me.tbDNI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDNI.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDNI.Location = New System.Drawing.Point(127, 63)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(88, 23)
        Me.tbDNI.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CENTRO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "FECHA DE INGRESO:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "VIA DE ACCESO:"
        '
        'tbVIaAcceso
        '
        Me.tbVIaAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbVIaAcceso.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVIaAcceso.Location = New System.Drawing.Point(130, 11)
        Me.tbVIaAcceso.Name = "tbVIaAcceso"
        Me.tbVIaAcceso.Size = New System.Drawing.Size(235, 23)
        Me.tbVIaAcceso.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ISE:"
        '
        'tbISE
        '
        Me.tbISE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbISE.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbISE.Location = New System.Drawing.Point(130, 37)
        Me.tbISE.Name = "tbISE"
        Me.tbISE.Size = New System.Drawing.Size(88, 23)
        Me.tbISE.TabIndex = 8
        '
        'cbxCentroResidencial
        '
        Me.cbxCentroResidencial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxCentroResidencial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCentroResidencial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCentroResidencial.FormattingEnabled = True
        Me.cbxCentroResidencial.Location = New System.Drawing.Point(127, 3)
        Me.cbxCentroResidencial.Name = "cbxCentroResidencial"
        Me.cbxCentroResidencial.Size = New System.Drawing.Size(235, 23)
        Me.cbxCentroResidencial.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "TIPO DE PLAZA:"
        '
        'cbxTipoPlaza
        '
        Me.cbxTipoPlaza.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTipoPlaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoPlaza.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoPlaza.FormattingEnabled = True
        Me.cbxTipoPlaza.Location = New System.Drawing.Point(127, 30)
        Me.cbxTipoPlaza.Name = "cbxTipoPlaza"
        Me.cbxTipoPlaza.Size = New System.Drawing.Size(184, 23)
        Me.cbxTipoPlaza.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "OBSERVACIONES:"
        '
        'tbObservaciones
        '
        Me.tbObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbObservaciones.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObservaciones.Location = New System.Drawing.Point(130, 69)
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbObservaciones.Size = New System.Drawing.Size(235, 107)
        Me.tbObservaciones.TabIndex = 9
        '
        'BdResidentesDataSet1
        '
        Me.BdResidentesDataSet1.DataSetName = "bdResidentesDataSet"
        Me.BdResidentesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxPendienteIngresar
        '
        Me.cbxPendienteIngresar.AutoSize = True
        Me.cbxPendienteIngresar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPendienteIngresar.Location = New System.Drawing.Point(141, 411)
        Me.cbxPendienteIngresar.Name = "cbxPendienteIngresar"
        Me.cbxPendienteIngresar.Size = New System.Drawing.Size(124, 19)
        Me.cbxPendienteIngresar.TabIndex = 10
        Me.cbxPendienteIngresar.Text = "Pendiente Ingresar"
        Me.cbxPendienteIngresar.UseVisualStyleBackColor = True
        '
        'cbxPendienteCitar
        '
        Me.cbxPendienteCitar.AutoSize = True
        Me.cbxPendienteCitar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPendienteCitar.Location = New System.Drawing.Point(278, 411)
        Me.cbxPendienteCitar.Name = "cbxPendienteCitar"
        Me.cbxPendienteCitar.Size = New System.Drawing.Size(105, 19)
        Me.cbxPendienteCitar.TabIndex = 11
        Me.cbxPendienteCitar.Text = "Pendiente Citar"
        Me.cbxPendienteCitar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbCompletaDatos)
        Me.Panel1.Controls.Add(Me.tbExpediente)
        Me.Panel1.Controls.Add(Me.tbNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tbDNI)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 92)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cbxCentroResidencial)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cbxTipoPlaza)
        Me.Panel2.Location = New System.Drawing.Point(12, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 92)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.tbVIaAcceso)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.tbISE)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.tbObservaciones)
        Me.Panel3.Location = New System.Drawing.Point(12, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(394, 191)
        Me.Panel3.TabIndex = 24
        '
        'formAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(425, 490)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbxPendienteCitar)
        Me.Controls.Add(Me.cbxPendienteIngresar)
        Me.Controls.Add(Me.btAceptarAltaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formAltaUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de usuario"
        CType(Me.BdResidentesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCompletaDatos As System.Windows.Forms.Label
    Friend WithEvents tbExpediente As System.Windows.Forms.TextBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents btAceptarAltaUsuario As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BdResidentesDataSet1 As siRes.bdResidentesDataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbVIaAcceso As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbISE As System.Windows.Forms.TextBox
    Friend WithEvents cbxCentroResidencial As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents cbxPendienteIngresar As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPendienteCitar As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
