﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbProgram = New System.Windows.Forms.GroupBox()
        Me.chbLock = New System.Windows.Forms.CheckBox()
        Me.lblActionStatus = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.gbLock = New System.Windows.Forms.GroupBox()
        Me.cmbBuzzer = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_SelfButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton_FrontPedal = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRFP = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_F_SWITCH = New System.Windows.Forms.RadioButton()
        Me.RadioButton_R_PEDAL = New System.Windows.Forms.RadioButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbAutoOff = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CmbTurnOff = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbMotor2 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbToff = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CmbTon = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmbTFirst = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPrograms = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLIGHT2onOFF = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLIGHT1onOFF = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnMOTOR2onOFF = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDelay = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnDelayPlus = New System.Windows.Forms.Button()
        Me.btnMOTOR2pwrON = New System.Windows.Forms.Button()
        Me.btnDelayMinus = New System.Windows.Forms.Button()
        Me.btnMOTOR2_1Press = New System.Windows.Forms.Button()
        Me.btnAlarm_Buzzer_Light = New System.Windows.Forms.Button()
        Me.btnMOTOR2_2Press = New System.Windows.Forms.Button()
        Me.btnNumberOfCells = New System.Windows.Forms.Button()
        Me.btnMOTOR2_3Press = New System.Windows.Forms.Button()
        Me.btnLIGHT2_3Press = New System.Windows.Forms.Button()
        Me.btnLIGHT1powerON = New System.Windows.Forms.Button()
        Me.btnLIGHT1_1Press = New System.Windows.Forms.Button()
        Me.btnLIGHT2_2Press = New System.Windows.Forms.Button()
        Me.btnLIGHT1_2Press = New System.Windows.Forms.Button()
        Me.btnLIGHT2_1Press = New System.Windows.Forms.Button()
        Me.btnLIGHT1_3Press = New System.Windows.Forms.Button()
        Me.btnLIGHT2powerON = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConnectionSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.gbMaintenance = New System.Windows.Forms.GroupBox()
        Me.gbTest = New System.Windows.Forms.GroupBox()
        Me.btnMOTOR1 = New System.Windows.Forms.Button()
        Me.btnMOTOR2 = New System.Windows.Forms.Button()
        Me.btnAlarm = New System.Windows.Forms.Button()
        Me.btnLIGHT1 = New System.Windows.Forms.Button()
        Me.btnLIGHT2 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Inputs_ALM = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Inputs_P2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Inputs_P1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblCell2Intensity = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton_Cell2_TX = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Cell2_RX = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblCell1Intensity = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton_Cell1_TX = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Cell1_RX = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblM2TCon = New System.Windows.Forms.Label()
        Me.lblL2TCon = New System.Windows.Forms.Label()
        Me.lblL2C = New System.Windows.Forms.Label()
        Me.lblL1TCon = New System.Windows.Forms.Label()
        Me.lblL1C = New System.Windows.Forms.Label()
        Me.lblM2C = New System.Windows.Forms.Label()
        Me.lblM1TCon = New System.Windows.Forms.Label()
        Me.lblM1C = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblVs = New System.Windows.Forms.Label()
        Me.cmbPorts = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.gbConSettings = New System.Windows.Forms.GroupBox()
        Me.lblProgramInfo1 = New System.Windows.Forms.Label()
        Me.lblProgramInfo = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TmrVersion = New System.Windows.Forms.Timer(Me.components)
        Me.gbProgram.SuspendLayout()
        Me.gbLock.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.gbAutoOff.SuspendLayout()
        Me.gbMotor2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.gbMaintenance.SuspendLayout()
        Me.gbTest.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbConSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProgram
        '
        Me.gbProgram.Controls.Add(Me.chbLock)
        Me.gbProgram.Controls.Add(Me.lblActionStatus)
        Me.gbProgram.Controls.Add(Me.btnSend)
        Me.gbProgram.Controls.Add(Me.gbLock)
        Me.gbProgram.Location = New System.Drawing.Point(18, 34)
        Me.gbProgram.Margin = New System.Windows.Forms.Padding(4)
        Me.gbProgram.Name = "gbProgram"
        Me.gbProgram.Padding = New System.Windows.Forms.Padding(4)
        Me.gbProgram.Size = New System.Drawing.Size(640, 432)
        Me.gbProgram.TabIndex = 0
        Me.gbProgram.TabStop = False
        Me.gbProgram.Text = "Program Settings"
        '
        'chbLock
        '
        Me.chbLock.AutoSize = True
        Me.chbLock.Location = New System.Drawing.Point(28, 390)
        Me.chbLock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chbLock.Name = "chbLock"
        Me.chbLock.Size = New System.Drawing.Size(122, 20)
        Me.chbLock.TabIndex = 59
        Me.chbLock.Text = "LOCK SCREEN"
        Me.chbLock.UseVisualStyleBackColor = True
        '
        'lblActionStatus
        '
        Me.lblActionStatus.AutoSize = True
        Me.lblActionStatus.Location = New System.Drawing.Point(208, 392)
        Me.lblActionStatus.Name = "lblActionStatus"
        Me.lblActionStatus.Size = New System.Drawing.Size(10, 16)
        Me.lblActionStatus.TabIndex = 51
        Me.lblActionStatus.Text = " "
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(502, 394)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(96, 28)
        Me.btnSend.TabIndex = 42
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'gbLock
        '
        Me.gbLock.Controls.Add(Me.cmbBuzzer)
        Me.gbLock.Controls.Add(Me.GroupBox1)
        Me.gbLock.Controls.Add(Me.Label1)
        Me.gbLock.Controls.Add(Me.btnRFP)
        Me.gbLock.Controls.Add(Me.GroupBox9)
        Me.gbLock.Controls.Add(Me.Label29)
        Me.gbLock.Controls.Add(Me.Label3)
        Me.gbLock.Controls.Add(Me.gbAutoOff)
        Me.gbLock.Controls.Add(Me.Label4)
        Me.gbLock.Controls.Add(Me.gbMotor2)
        Me.gbLock.Controls.Add(Me.Label5)
        Me.gbLock.Controls.Add(Me.cmbPrograms)
        Me.gbLock.Controls.Add(Me.Label6)
        Me.gbLock.Controls.Add(Me.Label7)
        Me.gbLock.Controls.Add(Me.btnLIGHT2onOFF)
        Me.gbLock.Controls.Add(Me.Label8)
        Me.gbLock.Controls.Add(Me.btnLIGHT1onOFF)
        Me.gbLock.Controls.Add(Me.Label11)
        Me.gbLock.Controls.Add(Me.btnSAVE)
        Me.gbLock.Controls.Add(Me.Label12)
        Me.gbLock.Controls.Add(Me.btnMOTOR2onOFF)
        Me.gbLock.Controls.Add(Me.Label13)
        Me.gbLock.Controls.Add(Me.lblDelay)
        Me.gbLock.Controls.Add(Me.Label14)
        Me.gbLock.Controls.Add(Me.btnDelayPlus)
        Me.gbLock.Controls.Add(Me.btnMOTOR2pwrON)
        Me.gbLock.Controls.Add(Me.btnDelayMinus)
        Me.gbLock.Controls.Add(Me.btnMOTOR2_1Press)
        Me.gbLock.Controls.Add(Me.btnAlarm_Buzzer_Light)
        Me.gbLock.Controls.Add(Me.btnMOTOR2_2Press)
        Me.gbLock.Controls.Add(Me.btnNumberOfCells)
        Me.gbLock.Controls.Add(Me.btnMOTOR2_3Press)
        Me.gbLock.Controls.Add(Me.btnLIGHT2_3Press)
        Me.gbLock.Controls.Add(Me.btnLIGHT1powerON)
        Me.gbLock.Controls.Add(Me.btnLIGHT1_1Press)
        Me.gbLock.Controls.Add(Me.btnLIGHT2_2Press)
        Me.gbLock.Controls.Add(Me.btnLIGHT1_2Press)
        Me.gbLock.Controls.Add(Me.btnLIGHT2_1Press)
        Me.gbLock.Controls.Add(Me.btnLIGHT1_3Press)
        Me.gbLock.Controls.Add(Me.btnLIGHT2powerON)
        Me.gbLock.Location = New System.Drawing.Point(11, 18)
        Me.gbLock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbLock.Name = "gbLock"
        Me.gbLock.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbLock.Size = New System.Drawing.Size(610, 358)
        Me.gbLock.TabIndex = 58
        Me.gbLock.TabStop = False
        '
        'cmbBuzzer
        '
        Me.cmbBuzzer.FormattingEnabled = True
        Me.cmbBuzzer.Location = New System.Drawing.Point(425, 264)
        Me.cmbBuzzer.Name = "cmbBuzzer"
        Me.cmbBuzzer.Size = New System.Drawing.Size(166, 24)
        Me.cmbBuzzer.TabIndex = 59
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_SelfButton)
        Me.GroupBox1.Controls.Add(Me.RadioButton_FrontPedal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(130, 71)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P1 INPUT"
        '
        'RadioButton_SelfButton
        '
        Me.RadioButton_SelfButton.AutoSize = True
        Me.RadioButton_SelfButton.Location = New System.Drawing.Point(7, 22)
        Me.RadioButton_SelfButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_SelfButton.Name = "RadioButton_SelfButton"
        Me.RadioButton_SelfButton.Size = New System.Drawing.Size(92, 20)
        Me.RadioButton_SelfButton.TabIndex = 35
        Me.RadioButton_SelfButton.Text = "Self-Button"
        Me.RadioButton_SelfButton.UseVisualStyleBackColor = True
        '
        'RadioButton_FrontPedal
        '
        Me.RadioButton_FrontPedal.AutoSize = True
        Me.RadioButton_FrontPedal.Checked = True
        Me.RadioButton_FrontPedal.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton_FrontPedal.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_FrontPedal.Name = "RadioButton_FrontPedal"
        Me.RadioButton_FrontPedal.Size = New System.Drawing.Size(97, 20)
        Me.RadioButton_FrontPedal.TabIndex = 34
        Me.RadioButton_FrontPedal.TabStop = True
        Me.RadioButton_FrontPedal.Text = "Front Pedal"
        Me.RadioButton_FrontPedal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Name: "
        '
        'btnRFP
        '
        Me.btnRFP.BackColor = System.Drawing.Color.LightGreen
        Me.btnRFP.Location = New System.Drawing.Point(112, 262)
        Me.btnRFP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRFP.Name = "btnRFP"
        Me.btnRFP.Size = New System.Drawing.Size(68, 28)
        Me.btnRFP.TabIndex = 57
        Me.btnRFP.Text = "ON"
        Me.btnRFP.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.RadioButton_F_SWITCH)
        Me.GroupBox9.Controls.Add(Me.RadioButton_R_PEDAL)
        Me.GroupBox9.Location = New System.Drawing.Point(183, 186)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(130, 71)
        Me.GroupBox9.TabIndex = 56
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "P2 INPUT"
        '
        'RadioButton_F_SWITCH
        '
        Me.RadioButton_F_SWITCH.AutoSize = True
        Me.RadioButton_F_SWITCH.Location = New System.Drawing.Point(7, 22)
        Me.RadioButton_F_SWITCH.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_F_SWITCH.Name = "RadioButton_F_SWITCH"
        Me.RadioButton_F_SWITCH.Size = New System.Drawing.Size(96, 20)
        Me.RadioButton_F_SWITCH.TabIndex = 35
        Me.RadioButton_F_SWITCH.Text = "Flap Switch"
        Me.RadioButton_F_SWITCH.UseVisualStyleBackColor = True
        '
        'RadioButton_R_PEDAL
        '
        Me.RadioButton_R_PEDAL.AutoSize = True
        Me.RadioButton_R_PEDAL.Checked = True
        Me.RadioButton_R_PEDAL.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton_R_PEDAL.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_R_PEDAL.Name = "RadioButton_R_PEDAL"
        Me.RadioButton_R_PEDAL.Size = New System.Drawing.Size(97, 20)
        Me.RadioButton_R_PEDAL.TabIndex = 34
        Me.RadioButton_R_PEDAL.TabStop = True
        Me.RadioButton_R_PEDAL.Text = "Rear Pedal"
        Me.RadioButton_R_PEDAL.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(14, 268)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(91, 16)
        Me.Label29.TabIndex = 56
        Me.Label29.Text = "P1 RESTART"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MOTOR 2"
        '
        'gbAutoOff
        '
        Me.gbAutoOff.Controls.Add(Me.Label31)
        Me.gbAutoOff.Controls.Add(Me.CmbTurnOff)
        Me.gbAutoOff.Controls.Add(Me.Label2)
        Me.gbAutoOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAutoOff.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gbAutoOff.Location = New System.Drawing.Point(12, 292)
        Me.gbAutoOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbAutoOff.Name = "gbAutoOff"
        Me.gbAutoOff.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbAutoOff.Size = New System.Drawing.Size(176, 62)
        Me.gbAutoOff.TabIndex = 48
        Me.gbAutoOff.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(135, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 17)
        Me.Label31.TabIndex = 46
        Me.Label31.Text = "min."
        '
        'CmbTurnOff
        '
        Me.CmbTurnOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTurnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTurnOff.FormattingEnabled = True
        Me.CmbTurnOff.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CmbTurnOff.Location = New System.Drawing.Point(87, 23)
        Me.CmbTurnOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbTurnOff.Name = "CmbTurnOff"
        Me.CmbTurnOff.Size = New System.Drawing.Size(42, 24)
        Me.CmbTurnOff.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Auto OFF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LIGHT 1"
        '
        'gbMotor2
        '
        Me.gbMotor2.Controls.Add(Me.Label24)
        Me.gbMotor2.Controls.Add(Me.cmbToff)
        Me.gbMotor2.Controls.Add(Me.Label25)
        Me.gbMotor2.Controls.Add(Me.CmbTon)
        Me.gbMotor2.Controls.Add(Me.Label27)
        Me.gbMotor2.Controls.Add(Me.cmbTFirst)
        Me.gbMotor2.Controls.Add(Me.Label15)
        Me.gbMotor2.Controls.Add(Me.Label26)
        Me.gbMotor2.Controls.Add(Me.Label28)
        Me.gbMotor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMotor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbMotor2.Location = New System.Drawing.Point(191, 292)
        Me.gbMotor2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbMotor2.Name = "gbMotor2"
        Me.gbMotor2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbMotor2.Size = New System.Drawing.Size(411, 62)
        Me.gbMotor2.TabIndex = 55
        Me.gbMotor2.TabStop = False
        Me.gbMotor2.Text = "MOTOR 2 (sec)"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(23, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 17)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "first"
        '
        'cmbToff
        '
        Me.cmbToff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToff.FormattingEnabled = True
        Me.cmbToff.Items.AddRange(New Object() {"1", "1,5", "2", "2,5", "3", "3,5", "4", "4,5", "5"})
        Me.cmbToff.Location = New System.Drawing.Point(192, 23)
        Me.cmbToff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbToff.Name = "cmbToff"
        Me.cmbToff.Size = New System.Drawing.Size(70, 24)
        Me.cmbToff.TabIndex = 54
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(298, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(26, 17)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "on"
        '
        'CmbTon
        '
        Me.CmbTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTon.FormattingEnabled = True
        Me.CmbTon.Items.AddRange(New Object() {"1", "1,5", "2", "2,5", "3", "3,5", "4", "4,5", "5"})
        Me.CmbTon.Location = New System.Drawing.Point(328, 23)
        Me.CmbTon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbTon.Name = "CmbTon"
        Me.CmbTon.Size = New System.Drawing.Size(70, 24)
        Me.CmbTon.TabIndex = 53
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(160, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 17)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "off"
        '
        'cmbTFirst
        '
        Me.cmbTFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTFirst.FormattingEnabled = True
        Me.cmbTFirst.Items.AddRange(New Object() {"1", "1,5", "2", "2,5", "3", "3,5", "4", "4,5", "5"})
        Me.cmbTFirst.Location = New System.Drawing.Point(63, 23)
        Me.cmbTFirst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTFirst.Name = "cmbTFirst"
        Me.cmbTFirst.Size = New System.Drawing.Size(70, 24)
        Me.cmbTFirst.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 24)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "T"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(143, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(23, 24)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "T"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(280, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(23, 24)
        Me.Label28.TabIndex = 57
        Me.Label28.Text = "T"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "LIGHT 2"
        '
        'cmbPrograms
        '
        Me.cmbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrograms.FormattingEnabled = True
        Me.cmbPrograms.Location = New System.Drawing.Point(140, 15)
        Me.cmbPrograms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPrograms.Name = "cmbPrograms"
        Me.cmbPrograms.Size = New System.Drawing.Size(336, 24)
        Me.cmbPrograms.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NUMBER OF CELL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 230)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DELAY"
        '
        'btnLIGHT2onOFF
        '
        Me.btnLIGHT2onOFF.BackColor = System.Drawing.Color.LightGreen
        Me.btnLIGHT2onOFF.Location = New System.Drawing.Point(96, 137)
        Me.btnLIGHT2onOFF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT2onOFF.Name = "btnLIGHT2onOFF"
        Me.btnLIGHT2onOFF.Size = New System.Drawing.Size(68, 28)
        Me.btnLIGHT2onOFF.TabIndex = 33
        Me.btnLIGHT2onOFF.Text = "ON"
        Me.btnLIGHT2onOFF.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(314, 272)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ALARM INPUT"
        '
        'btnLIGHT1onOFF
        '
        Me.btnLIGHT1onOFF.BackColor = System.Drawing.Color.LightGreen
        Me.btnLIGHT1onOFF.Location = New System.Drawing.Point(96, 101)
        Me.btnLIGHT1onOFF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT1onOFF.Name = "btnLIGHT1onOFF"
        Me.btnLIGHT1onOFF.Size = New System.Drawing.Size(68, 28)
        Me.btnLIGHT1onOFF.TabIndex = 32
        Me.btnLIGHT1onOFF.Text = "ON"
        Me.btnLIGHT1onOFF.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(192, 44)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Power On"
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.ForeColor = System.Drawing.Color.White
        Me.btnSAVE.Location = New System.Drawing.Point(495, 12)
        Me.btnSAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(107, 28)
        Me.btnSAVE.TabIndex = 41
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(302, 45)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "1. Press"
        '
        'btnMOTOR2onOFF
        '
        Me.btnMOTOR2onOFF.BackColor = System.Drawing.Color.LightGreen
        Me.btnMOTOR2onOFF.Location = New System.Drawing.Point(96, 64)
        Me.btnMOTOR2onOFF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMOTOR2onOFF.Name = "btnMOTOR2onOFF"
        Me.btnMOTOR2onOFF.Size = New System.Drawing.Size(68, 28)
        Me.btnMOTOR2onOFF.TabIndex = 31
        Me.btnMOTOR2onOFF.Text = "ON"
        Me.btnMOTOR2onOFF.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(408, 45)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "2. Press"
        '
        'lblDelay
        '
        Me.lblDelay.AutoSize = True
        Me.lblDelay.Location = New System.Drawing.Point(460, 230)
        Me.lblDelay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(31, 16)
        Me.lblDelay.TabIndex = 30
        Me.lblDelay.Text = "0,2s"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(518, 45)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "3.Press"
        '
        'btnDelayPlus
        '
        Me.btnDelayPlus.BackColor = System.Drawing.Color.LightBlue
        Me.btnDelayPlus.Location = New System.Drawing.Point(495, 223)
        Me.btnDelayPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelayPlus.Name = "btnDelayPlus"
        Me.btnDelayPlus.Size = New System.Drawing.Size(36, 28)
        Me.btnDelayPlus.TabIndex = 29
        Me.btnDelayPlus.Text = "+"
        Me.btnDelayPlus.UseVisualStyleBackColor = False
        '
        'btnMOTOR2pwrON
        '
        Me.btnMOTOR2pwrON.BackColor = System.Drawing.Color.Orange
        Me.btnMOTOR2pwrON.Location = New System.Drawing.Point(183, 64)
        Me.btnMOTOR2pwrON.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMOTOR2pwrON.Name = "btnMOTOR2pwrON"
        Me.btnMOTOR2pwrON.Size = New System.Drawing.Size(102, 28)
        Me.btnMOTOR2pwrON.TabIndex = 14
        Me.btnMOTOR2pwrON.Text = "AUTO"
        Me.btnMOTOR2pwrON.UseVisualStyleBackColor = False
        '
        'btnDelayMinus
        '
        Me.btnDelayMinus.BackColor = System.Drawing.Color.LightBlue
        Me.btnDelayMinus.Location = New System.Drawing.Point(425, 223)
        Me.btnDelayMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelayMinus.Name = "btnDelayMinus"
        Me.btnDelayMinus.Size = New System.Drawing.Size(36, 28)
        Me.btnDelayMinus.TabIndex = 28
        Me.btnDelayMinus.Text = "-"
        Me.btnDelayMinus.UseVisualStyleBackColor = False
        '
        'btnMOTOR2_1Press
        '
        Me.btnMOTOR2_1Press.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMOTOR2_1Press.Location = New System.Drawing.Point(287, 64)
        Me.btnMOTOR2_1Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMOTOR2_1Press.Name = "btnMOTOR2_1Press"
        Me.btnMOTOR2_1Press.Size = New System.Drawing.Size(103, 28)
        Me.btnMOTOR2_1Press.TabIndex = 15
        Me.btnMOTOR2_1Press.Text = "RUN"
        Me.btnMOTOR2_1Press.UseVisualStyleBackColor = False
        '
        'btnAlarm_Buzzer_Light
        '
        Me.btnAlarm_Buzzer_Light.BackColor = System.Drawing.Color.LightBlue
        Me.btnAlarm_Buzzer_Light.Location = New System.Drawing.Point(589, 218)
        Me.btnAlarm_Buzzer_Light.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlarm_Buzzer_Light.Name = "btnAlarm_Buzzer_Light"
        Me.btnAlarm_Buzzer_Light.Size = New System.Drawing.Size(13, 28)
        Me.btnAlarm_Buzzer_Light.TabIndex = 27
        Me.btnAlarm_Buzzer_Light.Text = "BUZZER"
        Me.btnAlarm_Buzzer_Light.UseVisualStyleBackColor = False
        Me.btnAlarm_Buzzer_Light.Visible = False
        '
        'btnMOTOR2_2Press
        '
        Me.btnMOTOR2_2Press.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMOTOR2_2Press.Location = New System.Drawing.Point(393, 64)
        Me.btnMOTOR2_2Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMOTOR2_2Press.Name = "btnMOTOR2_2Press"
        Me.btnMOTOR2_2Press.Size = New System.Drawing.Size(103, 28)
        Me.btnMOTOR2_2Press.TabIndex = 16
        Me.btnMOTOR2_2Press.Text = "PEDAL"
        Me.btnMOTOR2_2Press.UseVisualStyleBackColor = False
        '
        'btnNumberOfCells
        '
        Me.btnNumberOfCells.BackColor = System.Drawing.Color.LightBlue
        Me.btnNumberOfCells.Location = New System.Drawing.Point(520, 187)
        Me.btnNumberOfCells.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumberOfCells.Name = "btnNumberOfCells"
        Me.btnNumberOfCells.Size = New System.Drawing.Size(48, 28)
        Me.btnNumberOfCells.TabIndex = 26
        Me.btnNumberOfCells.Text = "1"
        Me.btnNumberOfCells.UseVisualStyleBackColor = False
        '
        'btnMOTOR2_3Press
        '
        Me.btnMOTOR2_3Press.Location = New System.Drawing.Point(499, 64)
        Me.btnMOTOR2_3Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMOTOR2_3Press.Name = "btnMOTOR2_3Press"
        Me.btnMOTOR2_3Press.Size = New System.Drawing.Size(103, 28)
        Me.btnMOTOR2_3Press.TabIndex = 17
        Me.btnMOTOR2_3Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT2_3Press
        '
        Me.btnLIGHT2_3Press.Location = New System.Drawing.Point(499, 137)
        Me.btnLIGHT2_3Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT2_3Press.Name = "btnLIGHT2_3Press"
        Me.btnLIGHT2_3Press.Size = New System.Drawing.Size(103, 28)
        Me.btnLIGHT2_3Press.TabIndex = 25
        Me.btnLIGHT2_3Press.Text = "OFF"
        Me.btnLIGHT2_3Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT1powerON
        '
        Me.btnLIGHT1powerON.Location = New System.Drawing.Point(183, 101)
        Me.btnLIGHT1powerON.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT1powerON.Name = "btnLIGHT1powerON"
        Me.btnLIGHT1powerON.Size = New System.Drawing.Size(102, 28)
        Me.btnLIGHT1powerON.TabIndex = 18
        Me.btnLIGHT1powerON.Text = "ON"
        Me.btnLIGHT1powerON.UseVisualStyleBackColor = True
        '
        'btnLIGHT1_1Press
        '
        Me.btnLIGHT1_1Press.Location = New System.Drawing.Point(287, 101)
        Me.btnLIGHT1_1Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT1_1Press.Name = "btnLIGHT1_1Press"
        Me.btnLIGHT1_1Press.Size = New System.Drawing.Size(103, 28)
        Me.btnLIGHT1_1Press.TabIndex = 19
        Me.btnLIGHT1_1Press.Text = "ON"
        Me.btnLIGHT1_1Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT2_2Press
        '
        Me.btnLIGHT2_2Press.Location = New System.Drawing.Point(393, 137)
        Me.btnLIGHT2_2Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT2_2Press.Name = "btnLIGHT2_2Press"
        Me.btnLIGHT2_2Press.Size = New System.Drawing.Size(103, 28)
        Me.btnLIGHT2_2Press.TabIndex = 24
        Me.btnLIGHT2_2Press.Text = "ON"
        Me.btnLIGHT2_2Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT1_2Press
        '
        Me.btnLIGHT1_2Press.Location = New System.Drawing.Point(393, 101)
        Me.btnLIGHT1_2Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT1_2Press.Name = "btnLIGHT1_2Press"
        Me.btnLIGHT1_2Press.Size = New System.Drawing.Size(103, 28)
        Me.btnLIGHT1_2Press.TabIndex = 20
        Me.btnLIGHT1_2Press.Text = "OFF"
        Me.btnLIGHT1_2Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT2_1Press
        '
        Me.btnLIGHT2_1Press.Location = New System.Drawing.Point(287, 137)
        Me.btnLIGHT2_1Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT2_1Press.Name = "btnLIGHT2_1Press"
        Me.btnLIGHT2_1Press.Size = New System.Drawing.Size(103, 28)
        Me.btnLIGHT2_1Press.TabIndex = 23
        Me.btnLIGHT2_1Press.Text = "FLASH"
        Me.btnLIGHT2_1Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT1_3Press
        '
        Me.btnLIGHT1_3Press.Location = New System.Drawing.Point(499, 101)
        Me.btnLIGHT1_3Press.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT1_3Press.Name = "btnLIGHT1_3Press"
        Me.btnLIGHT1_3Press.Size = New System.Drawing.Size(103, 28)
        Me.btnLIGHT1_3Press.TabIndex = 21
        Me.btnLIGHT1_3Press.Text = "OFF"
        Me.btnLIGHT1_3Press.UseVisualStyleBackColor = True
        '
        'btnLIGHT2powerON
        '
        Me.btnLIGHT2powerON.Location = New System.Drawing.Point(183, 137)
        Me.btnLIGHT2powerON.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT2powerON.Name = "btnLIGHT2powerON"
        Me.btnLIGHT2powerON.Size = New System.Drawing.Size(102, 28)
        Me.btnLIGHT2powerON.TabIndex = 22
        Me.btnLIGHT2powerON.Text = "OFF"
        Me.btnLIGHT2powerON.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionSToolStripMenuItem, Me.ProgramsToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.StatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConnectionSToolStripMenuItem
        '
        Me.ConnectionSToolStripMenuItem.Name = "ConnectionSToolStripMenuItem"
        Me.ConnectionSToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.ConnectionSToolStripMenuItem.Text = "Connection Settings"
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ProgramsToolStripMenuItem.Text = "Program"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 502)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(676, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'gbMaintenance
        '
        Me.gbMaintenance.Controls.Add(Me.gbTest)
        Me.gbMaintenance.Controls.Add(Me.GroupBox6)
        Me.gbMaintenance.Controls.Add(Me.GroupBox5)
        Me.gbMaintenance.Controls.Add(Me.GroupBox4)
        Me.gbMaintenance.Controls.Add(Me.GroupBox3)
        Me.gbMaintenance.Location = New System.Drawing.Point(18, 34)
        Me.gbMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.gbMaintenance.Name = "gbMaintenance"
        Me.gbMaintenance.Padding = New System.Windows.Forms.Padding(4)
        Me.gbMaintenance.Size = New System.Drawing.Size(640, 432)
        Me.gbMaintenance.TabIndex = 3
        Me.gbMaintenance.TabStop = False
        Me.gbMaintenance.Text = "Maintenance"
        Me.gbMaintenance.Visible = False
        '
        'gbTest
        '
        Me.gbTest.Controls.Add(Me.btnMOTOR1)
        Me.gbTest.Controls.Add(Me.btnMOTOR2)
        Me.gbTest.Controls.Add(Me.btnAlarm)
        Me.gbTest.Controls.Add(Me.btnLIGHT1)
        Me.gbTest.Controls.Add(Me.btnLIGHT2)
        Me.gbTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTest.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gbTest.Location = New System.Drawing.Point(18, 282)
        Me.gbTest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbTest.Name = "gbTest"
        Me.gbTest.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbTest.Size = New System.Drawing.Size(559, 67)
        Me.gbTest.TabIndex = 11
        Me.gbTest.TabStop = False
        Me.gbTest.Text = "TEST"
        '
        'btnMOTOR1
        '
        Me.btnMOTOR1.BackColor = System.Drawing.Color.LightGray
        Me.btnMOTOR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOTOR1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMOTOR1.Location = New System.Drawing.Point(22, 25)
        Me.btnMOTOR1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMOTOR1.Name = "btnMOTOR1"
        Me.btnMOTOR1.Size = New System.Drawing.Size(90, 28)
        Me.btnMOTOR1.TabIndex = 4
        Me.btnMOTOR1.Text = "MOTOR 1"
        Me.btnMOTOR1.UseVisualStyleBackColor = False
        '
        'btnMOTOR2
        '
        Me.btnMOTOR2.BackColor = System.Drawing.Color.LightGray
        Me.btnMOTOR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOTOR2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMOTOR2.Location = New System.Drawing.Point(129, 25)
        Me.btnMOTOR2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMOTOR2.Name = "btnMOTOR2"
        Me.btnMOTOR2.Size = New System.Drawing.Size(90, 28)
        Me.btnMOTOR2.TabIndex = 5
        Me.btnMOTOR2.Text = "MOTOR 2"
        Me.btnMOTOR2.UseVisualStyleBackColor = False
        '
        'btnAlarm
        '
        Me.btnAlarm.BackColor = System.Drawing.Color.LightGray
        Me.btnAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlarm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAlarm.Location = New System.Drawing.Point(446, 25)
        Me.btnAlarm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlarm.Name = "btnAlarm"
        Me.btnAlarm.Size = New System.Drawing.Size(90, 28)
        Me.btnAlarm.TabIndex = 8
        Me.btnAlarm.Text = "ALARM"
        Me.btnAlarm.UseVisualStyleBackColor = False
        '
        'btnLIGHT1
        '
        Me.btnLIGHT1.BackColor = System.Drawing.Color.LightGray
        Me.btnLIGHT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIGHT1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLIGHT1.Location = New System.Drawing.Point(234, 25)
        Me.btnLIGHT1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT1.Name = "btnLIGHT1"
        Me.btnLIGHT1.Size = New System.Drawing.Size(90, 28)
        Me.btnLIGHT1.TabIndex = 6
        Me.btnLIGHT1.Text = "LIGHT 1"
        Me.btnLIGHT1.UseVisualStyleBackColor = False
        '
        'btnLIGHT2
        '
        Me.btnLIGHT2.BackColor = System.Drawing.Color.LightGray
        Me.btnLIGHT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIGHT2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLIGHT2.Location = New System.Drawing.Point(340, 25)
        Me.btnLIGHT2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLIGHT2.Name = "btnLIGHT2"
        Me.btnLIGHT2.Size = New System.Drawing.Size(90, 28)
        Me.btnLIGHT2.TabIndex = 7
        Me.btnLIGHT2.Text = "LIGHT 2"
        Me.btnLIGHT2.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton_Inputs_ALM)
        Me.GroupBox6.Controls.Add(Me.RadioButton_Inputs_P2)
        Me.GroupBox6.Controls.Add(Me.RadioButton_Inputs_P1)
        Me.GroupBox6.Location = New System.Drawing.Point(300, 203)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(276, 57)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "INPUTS"
        '
        'RadioButton_Inputs_ALM
        '
        Me.RadioButton_Inputs_ALM.AutoSize = True
        Me.RadioButton_Inputs_ALM.Enabled = False
        Me.RadioButton_Inputs_ALM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Inputs_ALM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton_Inputs_ALM.Location = New System.Drawing.Point(146, 28)
        Me.RadioButton_Inputs_ALM.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Inputs_ALM.Name = "RadioButton_Inputs_ALM"
        Me.RadioButton_Inputs_ALM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Inputs_ALM.Size = New System.Drawing.Size(65, 21)
        Me.RadioButton_Inputs_ALM.TabIndex = 6
        Me.RadioButton_Inputs_ALM.TabStop = True
        Me.RadioButton_Inputs_ALM.Text = ":ALM"
        Me.RadioButton_Inputs_ALM.UseVisualStyleBackColor = True
        '
        'RadioButton_Inputs_P2
        '
        Me.RadioButton_Inputs_P2.AutoSize = True
        Me.RadioButton_Inputs_P2.Enabled = False
        Me.RadioButton_Inputs_P2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Inputs_P2.Location = New System.Drawing.Point(82, 28)
        Me.RadioButton_Inputs_P2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Inputs_P2.Name = "RadioButton_Inputs_P2"
        Me.RadioButton_Inputs_P2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Inputs_P2.Size = New System.Drawing.Size(53, 21)
        Me.RadioButton_Inputs_P2.TabIndex = 5
        Me.RadioButton_Inputs_P2.TabStop = True
        Me.RadioButton_Inputs_P2.Text = ":P2"
        Me.RadioButton_Inputs_P2.UseVisualStyleBackColor = True
        '
        'RadioButton_Inputs_P1
        '
        Me.RadioButton_Inputs_P1.AutoSize = True
        Me.RadioButton_Inputs_P1.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton_Inputs_P1.Enabled = False
        Me.RadioButton_Inputs_P1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Inputs_P1.Location = New System.Drawing.Point(16, 27)
        Me.RadioButton_Inputs_P1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Inputs_P1.Name = "RadioButton_Inputs_P1"
        Me.RadioButton_Inputs_P1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Inputs_P1.Size = New System.Drawing.Size(53, 21)
        Me.RadioButton_Inputs_P1.TabIndex = 4
        Me.RadioButton_Inputs_P1.TabStop = True
        Me.RadioButton_Inputs_P1.Text = ":P1"
        Me.RadioButton_Inputs_P1.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblCell2Intensity)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.RadioButton_Cell2_TX)
        Me.GroupBox5.Controls.Add(Me.RadioButton_Cell2_RX)
        Me.GroupBox5.Location = New System.Drawing.Point(300, 91)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(276, 57)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CELL 2"
        '
        'lblCell2Intensity
        '
        Me.lblCell2Intensity.AutoSize = True
        Me.lblCell2Intensity.Location = New System.Drawing.Point(192, 26)
        Me.lblCell2Intensity.Name = "lblCell2Intensity"
        Me.lblCell2Intensity.Size = New System.Drawing.Size(11, 16)
        Me.lblCell2Intensity.TabIndex = 5
        Me.lblCell2Intensity.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "(%):"
        '
        'RadioButton_Cell2_TX
        '
        Me.RadioButton_Cell2_TX.AutoSize = True
        Me.RadioButton_Cell2_TX.Enabled = False
        Me.RadioButton_Cell2_TX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Cell2_TX.Location = New System.Drawing.Point(86, 22)
        Me.RadioButton_Cell2_TX.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Cell2_TX.Name = "RadioButton_Cell2_TX"
        Me.RadioButton_Cell2_TX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell2_TX.Size = New System.Drawing.Size(54, 21)
        Me.RadioButton_Cell2_TX.TabIndex = 3
        Me.RadioButton_Cell2_TX.TabStop = True
        Me.RadioButton_Cell2_TX.Text = ":TX"
        Me.RadioButton_Cell2_TX.UseVisualStyleBackColor = True
        '
        'RadioButton_Cell2_RX
        '
        Me.RadioButton_Cell2_RX.AutoSize = True
        Me.RadioButton_Cell2_RX.Enabled = False
        Me.RadioButton_Cell2_RX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Cell2_RX.Location = New System.Drawing.Point(12, 22)
        Me.RadioButton_Cell2_RX.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Cell2_RX.Name = "RadioButton_Cell2_RX"
        Me.RadioButton_Cell2_RX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell2_RX.Size = New System.Drawing.Size(55, 21)
        Me.RadioButton_Cell2_RX.TabIndex = 2
        Me.RadioButton_Cell2_RX.TabStop = True
        Me.RadioButton_Cell2_RX.Text = ":RX"
        Me.RadioButton_Cell2_RX.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblCell1Intensity)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.RadioButton_Cell1_TX)
        Me.GroupBox4.Controls.Add(Me.RadioButton_Cell1_RX)
        Me.GroupBox4.Location = New System.Drawing.Point(300, 21)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(276, 57)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CELL 1"
        '
        'lblCell1Intensity
        '
        Me.lblCell1Intensity.AutoSize = True
        Me.lblCell1Intensity.Location = New System.Drawing.Point(192, 26)
        Me.lblCell1Intensity.Name = "lblCell1Intensity"
        Me.lblCell1Intensity.Size = New System.Drawing.Size(11, 16)
        Me.lblCell1Intensity.TabIndex = 3
        Me.lblCell1Intensity.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(159, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "(%):"
        '
        'RadioButton_Cell1_TX
        '
        Me.RadioButton_Cell1_TX.AutoSize = True
        Me.RadioButton_Cell1_TX.Enabled = False
        Me.RadioButton_Cell1_TX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Cell1_TX.Location = New System.Drawing.Point(86, 25)
        Me.RadioButton_Cell1_TX.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Cell1_TX.Name = "RadioButton_Cell1_TX"
        Me.RadioButton_Cell1_TX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell1_TX.Size = New System.Drawing.Size(54, 21)
        Me.RadioButton_Cell1_TX.TabIndex = 1
        Me.RadioButton_Cell1_TX.TabStop = True
        Me.RadioButton_Cell1_TX.Text = ":TX"
        Me.RadioButton_Cell1_TX.UseVisualStyleBackColor = True
        '
        'RadioButton_Cell1_RX
        '
        Me.RadioButton_Cell1_RX.AutoSize = True
        Me.RadioButton_Cell1_RX.Enabled = False
        Me.RadioButton_Cell1_RX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Cell1_RX.Location = New System.Drawing.Point(12, 23)
        Me.RadioButton_Cell1_RX.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Cell1_RX.Name = "RadioButton_Cell1_RX"
        Me.RadioButton_Cell1_RX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton_Cell1_RX.Size = New System.Drawing.Size(55, 21)
        Me.RadioButton_Cell1_RX.TabIndex = 0
        Me.RadioButton_Cell1_RX.TabStop = True
        Me.RadioButton_Cell1_RX.Text = ":RX"
        Me.RadioButton_Cell1_RX.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRefresh)
        Me.GroupBox3.Controls.Add(Me.lblM2TCon)
        Me.GroupBox3.Controls.Add(Me.lblL2TCon)
        Me.GroupBox3.Controls.Add(Me.lblL2C)
        Me.GroupBox3.Controls.Add(Me.lblL1TCon)
        Me.GroupBox3.Controls.Add(Me.lblL1C)
        Me.GroupBox3.Controls.Add(Me.lblM2C)
        Me.GroupBox3.Controls.Add(Me.lblM1TCon)
        Me.GroupBox3.Controls.Add(Me.lblM1C)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(268, 241)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIMING"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.SkyBlue
        Me.btnRefresh.Location = New System.Drawing.Point(169, 211)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 25)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblM2TCon
        '
        Me.lblM2TCon.AutoSize = True
        Me.lblM2TCon.Location = New System.Drawing.Point(151, 90)
        Me.lblM2TCon.Name = "lblM2TCon"
        Me.lblM2TCon.Size = New System.Drawing.Size(11, 16)
        Me.lblM2TCon.TabIndex = 13
        Me.lblM2TCon.Text = "-"
        '
        'lblL2TCon
        '
        Me.lblL2TCon.AutoSize = True
        Me.lblL2TCon.Location = New System.Drawing.Point(151, 189)
        Me.lblL2TCon.Name = "lblL2TCon"
        Me.lblL2TCon.Size = New System.Drawing.Size(11, 16)
        Me.lblL2TCon.TabIndex = 16
        Me.lblL2TCon.Text = "-"
        '
        'lblL2C
        '
        Me.lblL2C.AutoSize = True
        Me.lblL2C.Location = New System.Drawing.Point(151, 169)
        Me.lblL2C.Name = "lblL2C"
        Me.lblL2C.Size = New System.Drawing.Size(11, 16)
        Me.lblL2C.TabIndex = 15
        Me.lblL2C.Text = "-"
        '
        'lblL1TCon
        '
        Me.lblL1TCon.AutoSize = True
        Me.lblL1TCon.Location = New System.Drawing.Point(151, 138)
        Me.lblL1TCon.Name = "lblL1TCon"
        Me.lblL1TCon.Size = New System.Drawing.Size(11, 16)
        Me.lblL1TCon.TabIndex = 14
        Me.lblL1TCon.Text = "-"
        '
        'lblL1C
        '
        Me.lblL1C.AutoSize = True
        Me.lblL1C.Location = New System.Drawing.Point(151, 118)
        Me.lblL1C.Name = "lblL1C"
        Me.lblL1C.Size = New System.Drawing.Size(11, 16)
        Me.lblL1C.TabIndex = 13
        Me.lblL1C.Text = "-"
        '
        'lblM2C
        '
        Me.lblM2C.AutoSize = True
        Me.lblM2C.Location = New System.Drawing.Point(151, 71)
        Me.lblM2C.Name = "lblM2C"
        Me.lblM2C.Size = New System.Drawing.Size(11, 16)
        Me.lblM2C.TabIndex = 12
        Me.lblM2C.Text = "-"
        '
        'lblM1TCon
        '
        Me.lblM1TCon.AutoSize = True
        Me.lblM1TCon.Location = New System.Drawing.Point(151, 42)
        Me.lblM1TCon.Name = "lblM1TCon"
        Me.lblM1TCon.Size = New System.Drawing.Size(11, 16)
        Me.lblM1TCon.TabIndex = 12
        Me.lblM1TCon.Text = "-"
        '
        'lblM1C
        '
        Me.lblM1C.AutoSize = True
        Me.lblM1C.Location = New System.Drawing.Point(151, 22)
        Me.lblM1C.Name = "lblM1C"
        Me.lblM1C.Size = New System.Drawing.Size(11, 16)
        Me.lblM1C.TabIndex = 11
        Me.lblM1C.Text = "-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 189)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 16)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "LIGHT 2 TCON(h) : "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 169)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 16)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "LIGHT 2 CYCLE : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 138)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "LIGHT 1 TCON(h) : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 118)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 16)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "LIGHT 1 CYCLE : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 90)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 16)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "MOTOR 2 TCON(h) : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 71)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 16)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "MOTOR 2 CYCLE : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 42)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "MOTOR 1 TCON(h) : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 22)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "MOTOR 1 CYCLE : "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(388, 482)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(121, 16)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "Device Information:"
        '
        'lblVs
        '
        Me.lblVs.AutoSize = True
        Me.lblVs.Location = New System.Drawing.Point(539, 482)
        Me.lblVs.Name = "lblVs"
        Me.lblVs.Size = New System.Drawing.Size(107, 16)
        Me.lblVs.TabIndex = 10
        Me.lblVs.Text = "Device not found"
        '
        'cmbPorts
        '
        Me.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPorts.FormattingEnabled = True
        Me.cmbPorts.Location = New System.Drawing.Point(29, 34)
        Me.cmbPorts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPorts.Name = "cmbPorts"
        Me.cmbPorts.Size = New System.Drawing.Size(176, 24)
        Me.cmbPorts.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(269, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "CONNECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(165, 482)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(95, 16)
        Me.lblStatus.TabIndex = 46
        Me.lblStatus.Text = "No Connection"
        '
        'gbConSettings
        '
        Me.gbConSettings.Controls.Add(Me.lblProgramInfo1)
        Me.gbConSettings.Controls.Add(Me.lblProgramInfo)
        Me.gbConSettings.Controls.Add(Me.cmbPorts)
        Me.gbConSettings.Controls.Add(Me.Button1)
        Me.gbConSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbConSettings.Location = New System.Drawing.Point(18, 34)
        Me.gbConSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbConSettings.Name = "gbConSettings"
        Me.gbConSettings.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbConSettings.Size = New System.Drawing.Size(640, 432)
        Me.gbConSettings.TabIndex = 47
        Me.gbConSettings.TabStop = False
        Me.gbConSettings.Text = "Connection Settings"
        Me.gbConSettings.Visible = False
        '
        'lblProgramInfo1
        '
        Me.lblProgramInfo1.AutoSize = True
        Me.lblProgramInfo1.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramInfo1.Location = New System.Drawing.Point(3, 358)
        Me.lblProgramInfo1.Name = "lblProgramInfo1"
        Me.lblProgramInfo1.Size = New System.Drawing.Size(223, 17)
        Me.lblProgramInfo1.TabIndex = 47
        Me.lblProgramInfo1.Text = "Copyright ©️ 2021 by Mart Elektronik."
        '
        'lblProgramInfo
        '
        Me.lblProgramInfo.AutoSize = True
        Me.lblProgramInfo.Font = New System.Drawing.Font("Calibri", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramInfo.Location = New System.Drawing.Point(3, 367)
        Me.lblProgramInfo.Name = "lblProgramInfo"
        Me.lblProgramInfo.Size = New System.Drawing.Size(599, 34)
        Me.lblProgramInfo.TabIndex = 46
        Me.lblProgramInfo.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved. Unauthorized use of the software may violate copyright, tra" &
    "demark, and other laws."
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(14, 482)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(117, 16)
        Me.lblResult.TabIndex = 47
        Me.lblResult.Text = "Connection Status:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'TmrVersion
        '
        Me.TmrVersion.Enabled = True
        Me.TmrVersion.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 524)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblVs)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbProgram)
        Me.Controls.Add(Me.gbConSettings)
        Me.Controls.Add(Me.gbMaintenance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Checkout Programmer V1.4.2"
        Me.gbProgram.ResumeLayout(False)
        Me.gbProgram.PerformLayout()
        Me.gbLock.ResumeLayout(False)
        Me.gbLock.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.gbAutoOff.ResumeLayout(False)
        Me.gbAutoOff.PerformLayout()
        Me.gbMotor2.ResumeLayout(False)
        Me.gbMotor2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbMaintenance.ResumeLayout(False)
        Me.gbTest.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbConSettings.ResumeLayout(False)
        Me.gbConSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbProgram As GroupBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents ConnectionSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents gbMaintenance As GroupBox
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
    Friend WithEvents btnSAVE As Button
    Friend WithEvents cmbPorts As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents cmbPrograms As ComboBox
    Friend WithEvents gbConSettings As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblCell2Intensity As Label
    Friend WithEvents lblCell1Intensity As Label
    Friend WithEvents lblVs As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbTurnOff As ComboBox
    Friend WithEvents cmbToff As ComboBox
    Friend WithEvents CmbTon As ComboBox
    Friend WithEvents cmbTFirst As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents gbMotor2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents gbAutoOff As GroupBox
    Friend WithEvents btnRFP As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents lblM2TCon As Label
    Friend WithEvents lblL2TCon As Label
    Friend WithEvents lblL2C As Label
    Friend WithEvents lblL1TCon As Label
    Friend WithEvents lblL1C As Label
    Friend WithEvents lblM2C As Label
    Friend WithEvents lblM1TCon As Label
    Friend WithEvents lblM1C As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gbTest As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lblActionStatus As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents gbLock As GroupBox
    Friend WithEvents chbLock As CheckBox
    Friend WithEvents lblProgramInfo As Label
    Friend WithEvents lblProgramInfo1 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TmrVersion As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_SelfButton As RadioButton
    Friend WithEvents RadioButton_FrontPedal As RadioButton
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbBuzzer As ComboBox
End Class
