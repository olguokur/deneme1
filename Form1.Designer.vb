<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLIGHT2onOFF = New System.Windows.Forms.Button()
        Me.btnLIGHT1onOFF = New System.Windows.Forms.Button()
        Me.btnMOTOR2onOFF = New System.Windows.Forms.Button()
        Me.lblDelay = New System.Windows.Forms.Label()
        Me.btnDelayPlus = New System.Windows.Forms.Button()
        Me.btnDelayMinus = New System.Windows.Forms.Button()
        Me.btnAlarm_Buzzer_Light = New System.Windows.Forms.Button()
        Me.btnNumberOfCells = New System.Windows.Forms.Button()
        Me.btnLIGHT2_3Press = New System.Windows.Forms.Button()
        Me.btnLIGHT2_2Press = New System.Windows.Forms.Button()
        Me.btnLIGHT2_1Press = New System.Windows.Forms.Button()
        Me.btnLIGHT2powerON = New System.Windows.Forms.Button()
        Me.btnLIGHT1_3Press = New System.Windows.Forms.Button()
        Me.btnLIGHT1_2Press = New System.Windows.Forms.Button()
        Me.btnLIGHT1_1Press = New System.Windows.Forms.Button()
        Me.btnLIGHT1powerON = New System.Windows.Forms.Button()
        Me.btnMOTOR2_3Press = New System.Windows.Forms.Button()
        Me.btnMOTOR2_2Press = New System.Windows.Forms.Button()
        Me.btnMOTOR2_1Press = New System.Windows.Forms.Button()
        Me.btnMOTOR2pwrON = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConnectionSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ILURAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PC2YToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ILURACRFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.P4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PC6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIDLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MERCADONAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAlarm = New System.Windows.Forms.Button()
        Me.btnLIGHT2 = New System.Windows.Forms.Button()
        Me.btnLIGHT1 = New System.Windows.Forms.Button()
        Me.btnMOTOR2 = New System.Windows.Forms.Button()
        Me.btnMOTOR1 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Inputs_ALM = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Inputs_P2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Inputs_P1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Cell2_TX = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Cell2_RX = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Cell1_TX = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Cell1_RX = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RadioButton_R_PEDAL = New System.Windows.Forms.RadioButton()
        Me.RadioButton_F_SWITCH = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_F_SWITCH)
        Me.GroupBox1.Controls.Add(Me.RadioButton_R_PEDAL)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT2onOFF)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT1onOFF)
        Me.GroupBox1.Controls.Add(Me.btnMOTOR2onOFF)
        Me.GroupBox1.Controls.Add(Me.lblDelay)
        Me.GroupBox1.Controls.Add(Me.btnDelayPlus)
        Me.GroupBox1.Controls.Add(Me.btnDelayMinus)
        Me.GroupBox1.Controls.Add(Me.btnAlarm_Buzzer_Light)
        Me.GroupBox1.Controls.Add(Me.btnNumberOfCells)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT2_3Press)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT2_2Press)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT2_1Press)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT2powerON)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT1_3Press)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT1_2Press)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT1_1Press)
        Me.GroupBox1.Controls.Add(Me.btnLIGHT1powerON)
        Me.GroupBox1.Controls.Add(Me.btnMOTOR2_3Press)
        Me.GroupBox1.Controls.Add(Me.btnMOTOR2_2Press)
        Me.GroupBox1.Controls.Add(Me.btnMOTOR2_1Press)
        Me.GroupBox1.Controls.Add(Me.btnMOTOR2pwrON)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Program Settings"
        '
        'btnLIGHT2onOFF
        '
        Me.btnLIGHT2onOFF.BackColor = System.Drawing.Color.LightBlue
        Me.btnLIGHT2onOFF.Location = New System.Drawing.Point(69, 106)
        Me.btnLIGHT2onOFF.Name = "btnLIGHT2onOFF"
        Me.btnLIGHT2onOFF.Size = New System.Drawing.Size(52, 23)
        Me.btnLIGHT2onOFF.TabIndex = 33
        Me.btnLIGHT2onOFF.Text = "ON"
        Me.btnLIGHT2onOFF.UseVisualStyleBackColor = False
        '
        'btnLIGHT1onOFF
        '
        Me.btnLIGHT1onOFF.BackColor = System.Drawing.Color.LightBlue
        Me.btnLIGHT1onOFF.Location = New System.Drawing.Point(69, 83)
        Me.btnLIGHT1onOFF.Name = "btnLIGHT1onOFF"
        Me.btnLIGHT1onOFF.Size = New System.Drawing.Size(52, 23)
        Me.btnLIGHT1onOFF.TabIndex = 32
        Me.btnLIGHT1onOFF.Text = "ON"
        Me.btnLIGHT1onOFF.UseVisualStyleBackColor = False
        '
        'btnMOTOR2onOFF
        '
        Me.btnMOTOR2onOFF.BackColor = System.Drawing.Color.LightBlue
        Me.btnMOTOR2onOFF.Location = New System.Drawing.Point(69, 60)
        Me.btnMOTOR2onOFF.Name = "btnMOTOR2onOFF"
        Me.btnMOTOR2onOFF.Size = New System.Drawing.Size(52, 23)
        Me.btnMOTOR2onOFF.TabIndex = 31
        Me.btnMOTOR2onOFF.Text = "ON"
        Me.btnMOTOR2onOFF.UseVisualStyleBackColor = False
        '
        'lblDelay
        '
        Me.lblDelay.AutoSize = True
        Me.lblDelay.Location = New System.Drawing.Point(77, 184)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(27, 13)
        Me.lblDelay.TabIndex = 30
        Me.lblDelay.Text = "0,5s"
        '
        'btnDelayPlus
        '
        Me.btnDelayPlus.BackColor = System.Drawing.Color.LightBlue
        Me.btnDelayPlus.Location = New System.Drawing.Point(106, 179)
        Me.btnDelayPlus.Name = "btnDelayPlus"
        Me.btnDelayPlus.Size = New System.Drawing.Size(21, 23)
        Me.btnDelayPlus.TabIndex = 29
        Me.btnDelayPlus.Text = "+"
        Me.btnDelayPlus.UseVisualStyleBackColor = False
        '
        'btnDelayMinus
        '
        Me.btnDelayMinus.BackColor = System.Drawing.Color.LightBlue
        Me.btnDelayMinus.Location = New System.Drawing.Point(55, 179)
        Me.btnDelayMinus.Name = "btnDelayMinus"
        Me.btnDelayMinus.Size = New System.Drawing.Size(21, 23)
        Me.btnDelayMinus.TabIndex = 28
        Me.btnDelayMinus.Text = "-"
        Me.btnDelayMinus.UseVisualStyleBackColor = False
        '
        'btnAlarm_Buzzer_Light
        '
        Me.btnAlarm_Buzzer_Light.BackColor = System.Drawing.Color.LightBlue
        Me.btnAlarm_Buzzer_Light.Location = New System.Drawing.Point(245, 150)
        Me.btnAlarm_Buzzer_Light.Name = "btnAlarm_Buzzer_Light"
        Me.btnAlarm_Buzzer_Light.Size = New System.Drawing.Size(109, 23)
        Me.btnAlarm_Buzzer_Light.TabIndex = 27
        Me.btnAlarm_Buzzer_Light.Text = "BUZZER"
        Me.btnAlarm_Buzzer_Light.UseVisualStyleBackColor = False
        '
        'btnNumberOfCells
        '
        Me.btnNumberOfCells.BackColor = System.Drawing.Color.LightBlue
        Me.btnNumberOfCells.Location = New System.Drawing.Point(127, 150)
        Me.btnNumberOfCells.Name = "btnNumberOfCells"
        Me.btnNumberOfCells.Size = New System.Drawing.Size(31, 23)
        Me.btnNumberOfCells.TabIndex = 26
        Me.btnNumberOfCells.Text = "1"
        Me.btnNumberOfCells.UseVisualStyleBackColor = False
        '
        'btnLIGHT2_3Press
        '
        Me.btnLIGHT2_3Press.Location = New System.Drawing.Point(298, 107)
        Me.btnLIGHT2_3Press.Name = "btnLIGHT2_3Press"
        Me.btnLIGHT2_3Press.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT2_3Press.TabIndex = 25
        Me.btnLIGHT2_3Press.Text = "OFF"
        Me.btnLIGHT2_3Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT2_2Press
        '
        Me.btnLIGHT2_2Press.Location = New System.Drawing.Point(241, 107)
        Me.btnLIGHT2_2Press.Name = "btnLIGHT2_2Press"
        Me.btnLIGHT2_2Press.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT2_2Press.TabIndex = 24
        Me.btnLIGHT2_2Press.Text = "ON"
        Me.btnLIGHT2_2Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT2_1Press
        '
        Me.btnLIGHT2_1Press.Location = New System.Drawing.Point(184, 106)
        Me.btnLIGHT2_1Press.Name = "btnLIGHT2_1Press"
        Me.btnLIGHT2_1Press.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT2_1Press.TabIndex = 23
        Me.btnLIGHT2_1Press.Text = "FLASH"
        Me.btnLIGHT2_1Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT2powerON
        '
        Me.btnLIGHT2powerON.Location = New System.Drawing.Point(127, 106)
        Me.btnLIGHT2powerON.Name = "btnLIGHT2powerON"
        Me.btnLIGHT2powerON.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT2powerON.TabIndex = 22
        Me.btnLIGHT2powerON.Text = "OFF"
        Me.btnLIGHT2powerON.UseVisualStyleBackColor = True
        '
        'btnLIGHT1_3Press
        '
        Me.btnLIGHT1_3Press.Location = New System.Drawing.Point(298, 83)
        Me.btnLIGHT1_3Press.Name = "btnLIGHT1_3Press"
        Me.btnLIGHT1_3Press.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT1_3Press.TabIndex = 21
        Me.btnLIGHT1_3Press.Text = "OFF"
        Me.btnLIGHT1_3Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT1_2Press
        '
        Me.btnLIGHT1_2Press.Location = New System.Drawing.Point(241, 83)
        Me.btnLIGHT1_2Press.Name = "btnLIGHT1_2Press"
        Me.btnLIGHT1_2Press.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT1_2Press.TabIndex = 20
        Me.btnLIGHT1_2Press.Text = "OFF"
        Me.btnLIGHT1_2Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT1_1Press
        '
        Me.btnLIGHT1_1Press.Location = New System.Drawing.Point(184, 83)
        Me.btnLIGHT1_1Press.Name = "btnLIGHT1_1Press"
        Me.btnLIGHT1_1Press.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT1_1Press.TabIndex = 19
        Me.btnLIGHT1_1Press.Text = "ON"
        Me.btnLIGHT1_1Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT1powerON
        '
        Me.btnLIGHT1powerON.Location = New System.Drawing.Point(127, 83)
        Me.btnLIGHT1powerON.Name = "btnLIGHT1powerON"
        Me.btnLIGHT1powerON.Size = New System.Drawing.Size(55, 23)
        Me.btnLIGHT1powerON.TabIndex = 18
        Me.btnLIGHT1powerON.Text = "ON"
        Me.btnLIGHT1powerON.UseVisualStyleBackColor = True
        '
        'btnMOTOR2_3Press
        '
        Me.btnMOTOR2_3Press.Location = New System.Drawing.Point(298, 60)
        Me.btnMOTOR2_3Press.Name = "btnMOTOR2_3Press"
        Me.btnMOTOR2_3Press.Size = New System.Drawing.Size(55, 23)
        Me.btnMOTOR2_3Press.TabIndex = 17
        Me.btnMOTOR2_3Press.UseVisualStyleBackColor = True
        '
        'btnMOTOR2_2Press
        '
        Me.btnMOTOR2_2Press.Location = New System.Drawing.Point(241, 60)
        Me.btnMOTOR2_2Press.Name = "btnMOTOR2_2Press"
        Me.btnMOTOR2_2Press.Size = New System.Drawing.Size(55, 23)
        Me.btnMOTOR2_2Press.TabIndex = 16
        Me.btnMOTOR2_2Press.Text = "PEDAL"
        Me.btnMOTOR2_2Press.UseVisualStyleBackColor = True
        '
        'btnMOTOR2_1Press
        '
        Me.btnMOTOR2_1Press.Location = New System.Drawing.Point(184, 60)
        Me.btnMOTOR2_1Press.Name = "btnMOTOR2_1Press"
        Me.btnMOTOR2_1Press.Size = New System.Drawing.Size(55, 23)
        Me.btnMOTOR2_1Press.TabIndex = 15
        Me.btnMOTOR2_1Press.Text = "RUN"
        Me.btnMOTOR2_1Press.UseVisualStyleBackColor = True
        '
        'btnMOTOR2pwrON
        '
        Me.btnMOTOR2pwrON.BackColor = System.Drawing.Color.Orange
        Me.btnMOTOR2pwrON.Location = New System.Drawing.Point(127, 60)
        Me.btnMOTOR2pwrON.Name = "btnMOTOR2pwrON"
        Me.btnMOTOR2pwrON.Size = New System.Drawing.Size(55, 23)
        Me.btnMOTOR2pwrON.TabIndex = 14
        Me.btnMOTOR2pwrON.Text = "AUTO"
        Me.btnMOTOR2pwrON.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(304, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "3.Press"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(246, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "2. Press"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(187, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "1. Press"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Power On"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ALARM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DELAY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NUMBER OF CELLS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "LIGHT 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LIGHT 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MOTOR 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(201, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ILURA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Name: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionSToolStripMenuItem, Me.ProgramsToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConnectionSToolStripMenuItem
        '
        Me.ConnectionSToolStripMenuItem.Name = "ConnectionSToolStripMenuItem"
        Me.ConnectionSToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.ConnectionSToolStripMenuItem.Text = "Connection Settings"
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ILURAToolStripMenuItem, Me.PC2YToolStripMenuItem, Me.ILURACRFToolStripMenuItem, Me.P4ToolStripMenuItem, Me.PC6ToolStripMenuItem, Me.LIDLToolStripMenuItem, Me.MERCADONAToolStripMenuItem, Me.CUSTOMToolStripMenuItem})
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ProgramsToolStripMenuItem.Text = "Program Select"
        '
        'ILURAToolStripMenuItem
        '
        Me.ILURAToolStripMenuItem.Name = "ILURAToolStripMenuItem"
        Me.ILURAToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ILURAToolStripMenuItem.Text = "ILURA"
        '
        'PC2YToolStripMenuItem
        '
        Me.PC2YToolStripMenuItem.Name = "PC2YToolStripMenuItem"
        Me.PC2YToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PC2YToolStripMenuItem.Text = "PC2Y"
        '
        'ILURACRFToolStripMenuItem
        '
        Me.ILURACRFToolStripMenuItem.Name = "ILURACRFToolStripMenuItem"
        Me.ILURACRFToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ILURACRFToolStripMenuItem.Text = "ILURA CRF"
        '
        'P4ToolStripMenuItem
        '
        Me.P4ToolStripMenuItem.Name = "P4ToolStripMenuItem"
        Me.P4ToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.P4ToolStripMenuItem.Text = "P4"
        '
        'PC6ToolStripMenuItem
        '
        Me.PC6ToolStripMenuItem.Name = "PC6ToolStripMenuItem"
        Me.PC6ToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PC6ToolStripMenuItem.Text = "PC6"
        '
        'LIDLToolStripMenuItem
        '
        Me.LIDLToolStripMenuItem.Name = "LIDLToolStripMenuItem"
        Me.LIDLToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LIDLToolStripMenuItem.Text = "LIDL"
        '
        'MERCADONAToolStripMenuItem
        '
        Me.MERCADONAToolStripMenuItem.Name = "MERCADONAToolStripMenuItem"
        Me.MERCADONAToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MERCADONAToolStripMenuItem.Text = "MERCADONA"
        '
        'CUSTOMToolStripMenuItem
        '
        Me.CUSTOMToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.CUSTOMToolStripMenuItem.Name = "CUSTOMToolStripMenuItem"
        Me.CUSTOMToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CUSTOMToolStripMenuItem.Text = "CUSTOM DESIGN"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 493)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(386, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAlarm)
        Me.GroupBox2.Controls.Add(Me.btnLIGHT2)
        Me.GroupBox2.Controls.Add(Me.btnLIGHT1)
        Me.GroupBox2.Controls.Add(Me.btnMOTOR2)
        Me.GroupBox2.Controls.Add(Me.btnMOTOR1)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 247)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Maintenance"
        '
        'btnAlarm
        '
        Me.btnAlarm.Location = New System.Drawing.Point(281, 189)
        Me.btnAlarm.Name = "btnAlarm"
        Me.btnAlarm.Size = New System.Drawing.Size(75, 23)
        Me.btnAlarm.TabIndex = 8
        Me.btnAlarm.Text = "ALARM"
        Me.btnAlarm.UseVisualStyleBackColor = True
        '
        'btnLIGHT2
        '
        Me.btnLIGHT2.Location = New System.Drawing.Point(188, 217)
        Me.btnLIGHT2.Name = "btnLIGHT2"
        Me.btnLIGHT2.Size = New System.Drawing.Size(75, 23)
        Me.btnLIGHT2.TabIndex = 7
        Me.btnLIGHT2.Text = "LIGHT 2"
        Me.btnLIGHT2.UseVisualStyleBackColor = True
        '
        'btnLIGHT1
        '
        Me.btnLIGHT1.Location = New System.Drawing.Point(188, 188)
        Me.btnLIGHT1.Name = "btnLIGHT1"
        Me.btnLIGHT1.Size = New System.Drawing.Size(75, 23)
        Me.btnLIGHT1.TabIndex = 6
        Me.btnLIGHT1.Text = "LIGHT 1"
        Me.btnLIGHT1.UseVisualStyleBackColor = True
        '
        'btnMOTOR2
        '
        Me.btnMOTOR2.Location = New System.Drawing.Point(107, 188)
        Me.btnMOTOR2.Name = "btnMOTOR2"
        Me.btnMOTOR2.Size = New System.Drawing.Size(75, 23)
        Me.btnMOTOR2.TabIndex = 5
        Me.btnMOTOR2.Text = "MOTOR 2"
        Me.btnMOTOR2.UseVisualStyleBackColor = True
        '
        'btnMOTOR1
        '
        Me.btnMOTOR1.Location = New System.Drawing.Point(13, 188)
        Me.btnMOTOR1.Name = "btnMOTOR1"
        Me.btnMOTOR1.Size = New System.Drawing.Size(75, 23)
        Me.btnMOTOR1.TabIndex = 4
        Me.btnMOTOR1.Text = "MOTOR 1"
        Me.btnMOTOR1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton_Inputs_ALM)
        Me.GroupBox6.Controls.Add(Me.RadioButton_Inputs_P2)
        Me.GroupBox6.Controls.Add(Me.RadioButton_Inputs_P1)
        Me.GroupBox6.Location = New System.Drawing.Point(188, 136)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(168, 46)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "INPUTS"
        '
        'RadioButton_Inputs_ALM
        '
        Me.RadioButton_Inputs_ALM.AutoSize = True
        Me.RadioButton_Inputs_ALM.Location = New System.Drawing.Point(109, 23)
        Me.RadioButton_Inputs_ALM.Name = "RadioButton_Inputs_ALM"
        Me.RadioButton_Inputs_ALM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Inputs_ALM.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton_Inputs_ALM.TabIndex = 6
        Me.RadioButton_Inputs_ALM.TabStop = True
        Me.RadioButton_Inputs_ALM.Text = ":ALM"
        Me.RadioButton_Inputs_ALM.UseVisualStyleBackColor = True
        '
        'RadioButton_Inputs_P2
        '
        Me.RadioButton_Inputs_P2.AutoSize = True
        Me.RadioButton_Inputs_P2.Location = New System.Drawing.Point(61, 23)
        Me.RadioButton_Inputs_P2.Name = "RadioButton_Inputs_P2"
        Me.RadioButton_Inputs_P2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Inputs_P2.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton_Inputs_P2.TabIndex = 5
        Me.RadioButton_Inputs_P2.TabStop = True
        Me.RadioButton_Inputs_P2.Text = ":P2"
        Me.RadioButton_Inputs_P2.UseVisualStyleBackColor = True
        '
        'RadioButton_Inputs_P1
        '
        Me.RadioButton_Inputs_P1.AutoSize = True
        Me.RadioButton_Inputs_P1.Location = New System.Drawing.Point(12, 22)
        Me.RadioButton_Inputs_P1.Name = "RadioButton_Inputs_P1"
        Me.RadioButton_Inputs_P1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Inputs_P1.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton_Inputs_P1.TabIndex = 4
        Me.RadioButton_Inputs_P1.TabStop = True
        Me.RadioButton_Inputs_P1.Text = ":P1"
        Me.RadioButton_Inputs_P1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton_Cell2_TX)
        Me.GroupBox5.Controls.Add(Me.RadioButton_Cell2_RX)
        Me.GroupBox5.Location = New System.Drawing.Point(188, 76)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(168, 46)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CELL 2"
        '
        'RadioButton_Cell2_TX
        '
        Me.RadioButton_Cell2_TX.AutoSize = True
        Me.RadioButton_Cell2_TX.Location = New System.Drawing.Point(58, 19)
        Me.RadioButton_Cell2_TX.Name = "RadioButton_Cell2_TX"
        Me.RadioButton_Cell2_TX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell2_TX.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton_Cell2_TX.TabIndex = 3
        Me.RadioButton_Cell2_TX.TabStop = True
        Me.RadioButton_Cell2_TX.Text = ":TX"
        Me.RadioButton_Cell2_TX.UseVisualStyleBackColor = True
        '
        'RadioButton_Cell2_RX
        '
        Me.RadioButton_Cell2_RX.AutoSize = True
        Me.RadioButton_Cell2_RX.Location = New System.Drawing.Point(9, 18)
        Me.RadioButton_Cell2_RX.Name = "RadioButton_Cell2_RX"
        Me.RadioButton_Cell2_RX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell2_RX.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton_Cell2_RX.TabIndex = 2
        Me.RadioButton_Cell2_RX.TabStop = True
        Me.RadioButton_Cell2_RX.Text = ":RX"
        Me.RadioButton_Cell2_RX.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton_Cell1_TX)
        Me.GroupBox4.Controls.Add(Me.RadioButton_Cell1_RX)
        Me.GroupBox4.Location = New System.Drawing.Point(188, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(168, 46)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CELL 1"
        '
        'RadioButton_Cell1_TX
        '
        Me.RadioButton_Cell1_TX.AutoSize = True
        Me.RadioButton_Cell1_TX.Location = New System.Drawing.Point(58, 20)
        Me.RadioButton_Cell1_TX.Name = "RadioButton_Cell1_TX"
        Me.RadioButton_Cell1_TX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell1_TX.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton_Cell1_TX.TabIndex = 1
        Me.RadioButton_Cell1_TX.TabStop = True
        Me.RadioButton_Cell1_TX.Text = ":TX"
        Me.RadioButton_Cell1_TX.UseVisualStyleBackColor = True
        '
        'RadioButton_Cell1_RX
        '
        Me.RadioButton_Cell1_RX.AutoSize = True
        Me.RadioButton_Cell1_RX.Location = New System.Drawing.Point(9, 19)
        Me.RadioButton_Cell1_RX.Name = "RadioButton_Cell1_RX"
        Me.RadioButton_Cell1_RX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell1_RX.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton_Cell1_RX.TabIndex = 0
        Me.RadioButton_Cell1_RX.TabStop = True
        Me.RadioButton_Cell1_RX.Text = ":RX"
        Me.RadioButton_Cell1_RX.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(169, 163)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIMING"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "LIGHT 2 TIME(h) : "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 125)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "LIGHT 2 CYCLE : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "LIGHT 1 TIME(h) : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "LIGHT 1 CYCLE : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "MOTOR 2 TIME(h) : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "MOTOR 2 CYCLE : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "MOTOR 1 TIME(h) : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "MOTOR 1 CYCLE : "
        '
        'RadioButton_R_PEDAL
        '
        Me.RadioButton_R_PEDAL.AutoSize = True
        Me.RadioButton_R_PEDAL.Location = New System.Drawing.Point(190, 182)
        Me.RadioButton_R_PEDAL.Name = "RadioButton_R_PEDAL"
        Me.RadioButton_R_PEDAL.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton_R_PEDAL.TabIndex = 34
        Me.RadioButton_R_PEDAL.TabStop = True
        Me.RadioButton_R_PEDAL.Text = "R.PEDAL"
        Me.RadioButton_R_PEDAL.UseVisualStyleBackColor = True
        '
        'RadioButton_F_SWITCH
        '
        Me.RadioButton_F_SWITCH.AutoSize = True
        Me.RadioButton_F_SWITCH.Location = New System.Drawing.Point(274, 182)
        Me.RadioButton_F_SWITCH.Name = "RadioButton_F_SWITCH"
        Me.RadioButton_F_SWITCH.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton_F_SWITCH.TabIndex = 35
        Me.RadioButton_F_SWITCH.TabStop = True
        Me.RadioButton_F_SWITCH.Text = "F.SWITCH"
        Me.RadioButton_F_SWITCH.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 515)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Mart Elektronik"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ConnectionSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ILURAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PC2YToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ILURACRFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents P4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PC6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIDLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MERCADONAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAlarm_Buzzer_Light As Button
    Friend WithEvents btnNumberOfCells As Button
    Friend WithEvents btnLIGHT2_3Press As Button
    Friend WithEvents btnLIGHT2_2Press As Button
    Friend WithEvents btnLIGHT2_1Press As Button
    Friend WithEvents btnLIGHT2powerON As Button
    Friend WithEvents btnLIGHT1_3Press As Button
    Friend WithEvents btnLIGHT1_2Press As Button
    Friend WithEvents btnLIGHT1_1Press As Button
    Friend WithEvents btnLIGHT1powerON As Button
    Friend WithEvents btnMOTOR2_3Press As Button
    Friend WithEvents btnMOTOR2_2Press As Button
    Friend WithEvents btnMOTOR2_1Press As Button
    Friend WithEvents btnMOTOR2pwrON As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblDelay As Label
    Friend WithEvents btnDelayPlus As Button
    Friend WithEvents btnDelayMinus As Button
    Friend WithEvents btnLIGHT2onOFF As Button
    Friend WithEvents btnLIGHT1onOFF As Button
    Friend WithEvents btnMOTOR2onOFF As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAlarm As Button
    Friend WithEvents btnLIGHT2 As Button
    Friend WithEvents btnLIGHT1 As Button
    Friend WithEvents btnMOTOR2 As Button
    Friend WithEvents btnMOTOR1 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButton_Inputs_ALM As RadioButton
    Friend WithEvents RadioButton_Inputs_P2 As RadioButton
    Friend WithEvents RadioButton_Inputs_P1 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButton_Cell2_TX As RadioButton
    Friend WithEvents RadioButton_Cell2_RX As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton_Cell1_TX As RadioButton
    Friend WithEvents RadioButton_Cell1_RX As RadioButton
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents RadioButton_F_SWITCH As RadioButton
    Friend WithEvents RadioButton_R_PEDAL As RadioButton
End Class
