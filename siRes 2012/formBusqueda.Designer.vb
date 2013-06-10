<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBusqueda
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
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.rbNombreBuscar = New System.Windows.Forms.RadioButton()
        Me.rbDNIBuscar = New System.Windows.Forms.RadioButton()
        Me.rbExpdteBuscar = New System.Windows.Forms.RadioButton()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.tbExpdteBuscar = New System.Windows.Forms.TextBox()
        Me.tbNombreBuscar = New System.Windows.Forms.TextBox()
        Me.tbDNIBuscar = New System.Windows.Forms.TextBox()
        Me.tbReservaBuscar = New System.Windows.Forms.TextBox()
        Me.tbViaAccesoBuscar = New System.Windows.Forms.TextBox()
        Me.tbISEBuscar = New System.Windows.Forms.TextBox()
        Me.tbObservacionesBuscar = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxTipoPlaza = New System.Windows.Forms.ComboBox()
        Me.cbxCentroResidencial = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxPendienteIngresar = New System.Windows.Forms.ComboBox()
        Me.cbxPendienteCitar = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaBaja = New System.Windows.Forms.TextBox()
        Me.dtpFechaIngreso = New System.Windows.Forms.TextBox()
        Me.lbBaja = New System.Windows.Forms.Label()
        Me.btActualizarRegistro = New System.Windows.Forms.Button()
        Me.btTraslado = New System.Windows.Forms.Button()
        Me.lbCerrado = New System.Windows.Forms.Label()
        Me.lklbReapertura = New System.Windows.Forms.LinkLabel()
        Me.btHistoricoTraslados = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbBuscar
        '
        Me.tbBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscar.Location = New System.Drawing.Point(208, 14)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(289, 23)
        Me.tbBuscar.TabIndex = 4
        '
        'rbNombreBuscar
        '
        Me.rbNombreBuscar.AutoSize = True
        Me.rbNombreBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreBuscar.Location = New System.Drawing.Point(140, 15)
        Me.rbNombreBuscar.Name = "rbNombreBuscar"
        Me.rbNombreBuscar.Size = New System.Drawing.Size(65, 19)
        Me.rbNombreBuscar.TabIndex = 3
        Me.rbNombreBuscar.Text = "Nombre"
        Me.rbNombreBuscar.UseVisualStyleBackColor = True
        '
        'rbDNIBuscar
        '
        Me.rbDNIBuscar.AutoSize = True
        Me.rbDNIBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDNIBuscar.Location = New System.Drawing.Point(90, 15)
        Me.rbDNIBuscar.Name = "rbDNIBuscar"
        Me.rbDNIBuscar.Size = New System.Drawing.Size(48, 19)
        Me.rbDNIBuscar.TabIndex = 2
        Me.rbDNIBuscar.Text = "DNI"
        Me.rbDNIBuscar.UseVisualStyleBackColor = True
        '
        'rbExpdteBuscar
        '
        Me.rbExpdteBuscar.AutoSize = True
        Me.rbExpdteBuscar.Checked = True
        Me.rbExpdteBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExpdteBuscar.Location = New System.Drawing.Point(16, 15)
        Me.rbExpdteBuscar.Name = "rbExpdteBuscar"
        Me.rbExpdteBuscar.Size = New System.Drawing.Size(68, 19)
        Me.rbExpdteBuscar.TabIndex = 1
        Me.rbExpdteBuscar.TabStop = True
        Me.rbExpdteBuscar.Text = "EXPDTE"
        Me.rbExpdteBuscar.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.Color.Peru
        Me.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Peru
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Location = New System.Drawing.Point(507, 15)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 5
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'tbExpdteBuscar
        '
        Me.tbExpdteBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbExpdteBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExpdteBuscar.Location = New System.Drawing.Point(83, 29)
        Me.tbExpdteBuscar.Name = "tbExpdteBuscar"
        Me.tbExpdteBuscar.Size = New System.Drawing.Size(100, 23)
        Me.tbExpdteBuscar.TabIndex = 6
        '
        'tbNombreBuscar
        '
        Me.tbNombreBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreBuscar.Location = New System.Drawing.Point(256, 29)
        Me.tbNombreBuscar.Name = "tbNombreBuscar"
        Me.tbNombreBuscar.Size = New System.Drawing.Size(194, 23)
        Me.tbNombreBuscar.TabIndex = 7
        '
        'tbDNIBuscar
        '
        Me.tbDNIBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDNIBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDNIBuscar.Location = New System.Drawing.Point(83, 55)
        Me.tbDNIBuscar.Name = "tbDNIBuscar"
        Me.tbDNIBuscar.Size = New System.Drawing.Size(100, 23)
        Me.tbDNIBuscar.TabIndex = 8
        '
        'tbReservaBuscar
        '
        Me.tbReservaBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbReservaBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReservaBuscar.Location = New System.Drawing.Point(83, 108)
        Me.tbReservaBuscar.Name = "tbReservaBuscar"
        Me.tbReservaBuscar.ReadOnly = True
        Me.tbReservaBuscar.Size = New System.Drawing.Size(100, 23)
        Me.tbReservaBuscar.TabIndex = 11
        '
        'tbViaAccesoBuscar
        '
        Me.tbViaAccesoBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbViaAccesoBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbViaAccesoBuscar.Location = New System.Drawing.Point(347, 31)
        Me.tbViaAccesoBuscar.Name = "tbViaAccesoBuscar"
        Me.tbViaAccesoBuscar.Size = New System.Drawing.Size(100, 23)
        Me.tbViaAccesoBuscar.TabIndex = 15
        '
        'tbISEBuscar
        '
        Me.tbISEBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbISEBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbISEBuscar.Location = New System.Drawing.Point(347, 57)
        Me.tbISEBuscar.Name = "tbISEBuscar"
        Me.tbISEBuscar.Size = New System.Drawing.Size(100, 23)
        Me.tbISEBuscar.TabIndex = 17
        '
        'tbObservacionesBuscar
        '
        Me.tbObservacionesBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbObservacionesBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObservacionesBuscar.Location = New System.Drawing.Point(125, 83)
        Me.tbObservacionesBuscar.Multiline = True
        Me.tbObservacionesBuscar.Name = "tbObservacionesBuscar"
        Me.tbObservacionesBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbObservacionesBuscar.Size = New System.Drawing.Size(325, 83)
        Me.tbObservacionesBuscar.TabIndex = 18
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Documents and Settings\WinXP\Escrit" & _
            "orio\siRes\siRes\siRes\bdResidentes.mdf"";Integrated Security=True;Connect Timeou" & _
            "t=30;User Instance=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "EXPDTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "RESERVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "CENTRO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(317, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "ISE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "FECHA DE INGRESO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(253, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "VIA DE ACCESO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(272, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "TIPO DE PLAZA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "OBSERVACIONES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxTipoPlaza)
        Me.GroupBox1.Controls.Add(Me.cbxCentroResidencial)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbxPendienteIngresar)
        Me.GroupBox1.Controls.Add(Me.cbxPendienteCitar)
        Me.GroupBox1.Controls.Add(Me.tbExpdteBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbNombreBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbDNIBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbReservaBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 183)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'cbxTipoPlaza
        '
        Me.cbxTipoPlaza.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTipoPlaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoPlaza.DropDownWidth = 180
        Me.cbxTipoPlaza.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoPlaza.FormattingEnabled = True
        Me.cbxTipoPlaza.Items.AddRange(New Object() {"", "MAYORES", "EXCLUSION", "TRASTORNOS DE CONDUCTA"})
        Me.cbxTipoPlaza.Location = New System.Drawing.Point(365, 81)
        Me.cbxTipoPlaza.Name = "cbxTipoPlaza"
        Me.cbxTipoPlaza.Size = New System.Drawing.Size(100, 23)
        Me.cbxTipoPlaza.TabIndex = 10
        '
        'cbxCentroResidencial
        '
        Me.cbxCentroResidencial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxCentroResidencial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCentroResidencial.DropDownWidth = 235
        Me.cbxCentroResidencial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCentroResidencial.FormattingEnabled = True
        Me.cbxCentroResidencial.Location = New System.Drawing.Point(83, 81)
        Me.cbxCentroResidencial.Name = "cbxCentroResidencial"
        Me.cbxCentroResidencial.Size = New System.Drawing.Size(183, 23)
        Me.cbxCentroResidencial.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(228, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "PENDIENTE INGRESAR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(255, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "PENDIENTE CITAR"
        '
        'cbxPendienteIngresar
        '
        Me.cbxPendienteIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxPendienteIngresar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPendienteIngresar.FormattingEnabled = True
        Me.cbxPendienteIngresar.Items.AddRange(New Object() {"", "SI", "NO"})
        Me.cbxPendienteIngresar.Location = New System.Drawing.Point(365, 145)
        Me.cbxPendienteIngresar.Name = "cbxPendienteIngresar"
        Me.cbxPendienteIngresar.Size = New System.Drawing.Size(68, 23)
        Me.cbxPendienteIngresar.TabIndex = 13
        '
        'cbxPendienteCitar
        '
        Me.cbxPendienteCitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxPendienteCitar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPendienteCitar.FormattingEnabled = True
        Me.cbxPendienteCitar.Items.AddRange(New Object() {"", "SI", "NO"})
        Me.cbxPendienteCitar.Location = New System.Drawing.Point(365, 113)
        Me.cbxPendienteCitar.Name = "cbxPendienteCitar"
        Me.cbxPendienteCitar.Size = New System.Drawing.Size(68, 23)
        Me.cbxPendienteCitar.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaBaja)
        Me.GroupBox2.Controls.Add(Me.dtpFechaIngreso)
        Me.GroupBox2.Controls.Add(Me.lbBaja)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbObservacionesBuscar)
        Me.GroupBox2.Controls.Add(Me.tbViaAccesoBuscar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbISEBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 177)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'dtpFechaBaja
        '
        Me.dtpFechaBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpFechaBaja.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaBaja.Location = New System.Drawing.Point(126, 57)
        Me.dtpFechaBaja.Name = "dtpFechaBaja"
        Me.dtpFechaBaja.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaBaja.TabIndex = 16
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(126, 31)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaIngreso.TabIndex = 14
        '
        'lbBaja
        '
        Me.lbBaja.AutoSize = True
        Me.lbBaja.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBaja.Location = New System.Drawing.Point(28, 60)
        Me.lbBaja.Name = "lbBaja"
        Me.lbBaja.Size = New System.Drawing.Size(94, 15)
        Me.lbBaja.TabIndex = 25
        Me.lbBaja.Text = "FECHA DE BAJA"
        '
        'btActualizarRegistro
        '
        Me.btActualizarRegistro.BackColor = System.Drawing.Color.Peru
        Me.btActualizarRegistro.FlatAppearance.BorderSize = 0
        Me.btActualizarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btActualizarRegistro.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizarRegistro.Location = New System.Drawing.Point(507, 365)
        Me.btActualizarRegistro.Name = "btActualizarRegistro"
        Me.btActualizarRegistro.Size = New System.Drawing.Size(75, 23)
        Me.btActualizarRegistro.TabIndex = 20
        Me.btActualizarRegistro.Text = "Actualizar"
        Me.btActualizarRegistro.UseVisualStyleBackColor = False
        '
        'btTraslado
        '
        Me.btTraslado.BackColor = System.Drawing.Color.Peru
        Me.btTraslado.FlatAppearance.BorderSize = 0
        Me.btTraslado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTraslado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTraslado.Location = New System.Drawing.Point(507, 394)
        Me.btTraslado.Name = "btTraslado"
        Me.btTraslado.Size = New System.Drawing.Size(75, 39)
        Me.btTraslado.TabIndex = 21
        Me.btTraslado.Text = "Traslado de Centro"
        Me.btTraslado.UseVisualStyleBackColor = False
        '
        'lbCerrado
        '
        Me.lbCerrado.AutoSize = True
        Me.lbCerrado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCerrado.ForeColor = System.Drawing.Color.Maroon
        Me.lbCerrado.Location = New System.Drawing.Point(23, 51)
        Me.lbCerrado.Name = "lbCerrado"
        Me.lbCerrado.Size = New System.Drawing.Size(340, 15)
        Me.lbCerrado.TabIndex = 33
        Me.lbCerrado.Text = "Expediente cerrado. El usuario no se encuentra en ningún Centro."
        Me.lbCerrado.Visible = False
        '
        'lklbReapertura
        '
        Me.lklbReapertura.AutoSize = True
        Me.lklbReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklbReapertura.Location = New System.Drawing.Point(373, 51)
        Me.lklbReapertura.Name = "lklbReapertura"
        Me.lklbReapertura.Size = New System.Drawing.Size(118, 15)
        Me.lklbReapertura.TabIndex = 34
        Me.lklbReapertura.TabStop = True
        Me.lklbReapertura.Text = "¿Reabrir expediente?"
        Me.lklbReapertura.Visible = False
        '
        'btHistoricoTraslados
        '
        Me.btHistoricoTraslados.BackColor = System.Drawing.Color.Peru
        Me.btHistoricoTraslados.FlatAppearance.BorderSize = 0
        Me.btHistoricoTraslados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btHistoricoTraslados.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHistoricoTraslados.Location = New System.Drawing.Point(507, 313)
        Me.btHistoricoTraslados.Name = "btHistoricoTraslados"
        Me.btHistoricoTraslados.Size = New System.Drawing.Size(75, 36)
        Me.btHistoricoTraslados.TabIndex = 19
        Me.btHistoricoTraslados.Text = "Histórico de Traslados"
        Me.btHistoricoTraslados.UseVisualStyleBackColor = False
        Me.btHistoricoTraslados.Visible = False
        '
        'formBusqueda
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(591, 449)
        Me.Controls.Add(Me.btHistoricoTraslados)
        Me.Controls.Add(Me.lklbReapertura)
        Me.Controls.Add(Me.lbCerrado)
        Me.Controls.Add(Me.btTraslado)
        Me.Controls.Add(Me.btActualizarRegistro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.rbExpdteBuscar)
        Me.Controls.Add(Me.rbDNIBuscar)
        Me.Controls.Add(Me.rbNombreBuscar)
        Me.Controls.Add(Me.tbBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de expedientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbBuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbNombreBuscar As System.Windows.Forms.RadioButton
    Friend WithEvents rbDNIBuscar As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpdteBuscar As System.Windows.Forms.RadioButton
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents tbExpdteBuscar As System.Windows.Forms.TextBox
    Friend WithEvents tbNombreBuscar As System.Windows.Forms.TextBox
    Friend WithEvents tbDNIBuscar As System.Windows.Forms.TextBox
    Friend WithEvents tbReservaBuscar As System.Windows.Forms.TextBox
    Friend WithEvents tbViaAccesoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents tbISEBuscar As System.Windows.Forms.TextBox
    Friend WithEvents tbObservacionesBuscar As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btActualizarRegistro As System.Windows.Forms.Button
    Friend WithEvents lbBaja As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxPendienteIngresar As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPendienteCitar As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCentroResidencial As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTipoPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents btTraslado As System.Windows.Forms.Button
    Friend WithEvents lbCerrado As System.Windows.Forms.Label
    Friend WithEvents lklbReapertura As System.Windows.Forms.LinkLabel
    Friend WithEvents btHistoricoTraslados As System.Windows.Forms.Button
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaBaja As System.Windows.Forms.TextBox
End Class
