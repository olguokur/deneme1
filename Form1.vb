
Imports System.IO

Module Module1

    Public M2CON(13) As Byte
    Public L1CON(13) As Byte
    Public L2CON(13) As Byte
    Public DCR(13) As Byte

    'Public received_M2CON(13) As Byte

    Public ILURA_M2CON(13) As Byte
    Public ILURA_L1CON(13) As Byte
    Public ILURA_L2CON(13) As Byte
    Public ILURA_DCR(13) As Byte

    Public strArr() As Char
    Public dosya As String
    Public ports As String() = IO.Ports.SerialPort.GetPortNames()
    Public port As String
    Public PortName As String


End Module

Public Class Form1

    Private Sub btnMOTOR2onOFF_Click(sender As Object, e As EventArgs) Handles btnMOTOR2onOFF.Click
        If btnMOTOR2onOFF.Text = "ON" Then
            btnMOTOR2onOFF.Text = "OFF"
            btnMOTOR2onOFF.BackColor = Color.LightGray
            btnMOTOR2pwrON.Text = ""
            btnMOTOR2pwrON.BackColor = Color.LightGray
            btnMOTOR2_1Press.Text = ""
            btnMOTOR2_1Press.BackColor = Color.LightGray
            btnMOTOR2_2Press.Text = ""
            btnMOTOR2_2Press.BackColor = Color.LightGray
            btnMOTOR2_3Press.Text = ""
            btnMOTOR2_3Press.BackColor = Color.LightGray

            M2CON(0) = 0
        Else
            btnMOTOR2onOFF.Text = "ON"
            btnMOTOR2onOFF.BackColor = Color.LightBlue
            M2CON(0) = 1
        End If
    End Sub

    Private Sub btnLIGHT1onOFF_Click(sender As Object, e As EventArgs) Handles btnLIGHT1onOFF.Click
        If btnLIGHT1onOFF.Text = "ON" Then

            btnLIGHT1onOFF.Text = "OFF"
            btnLIGHT1onOFF.BackColor = Color.LightGray
            btnLIGHT1powerON.Text = ""
            btnLIGHT1powerON.BackColor = Color.LightGray
            btnLIGHT1_1Press.Text = ""
            btnLIGHT1_1Press.BackColor = Color.LightGray
            btnLIGHT1_2Press.Text = ""
            btnLIGHT1_2Press.BackColor = Color.LightGray
            btnLIGHT1_3Press.Text = ""
            btnLIGHT1_3Press.BackColor = Color.LightGray

            L1CON(0) = 0
        Else
            btnLIGHT1onOFF.Text = "ON"
            btnLIGHT1onOFF.BackColor = Color.LightBlue
            L1CON(0) = 1
        End If
    End Sub

    Private Sub btnLIGHT2onOFF_Click(sender As Object, e As EventArgs) Handles btnLIGHT2onOFF.Click
        If btnLIGHT2onOFF.Text = "ON" Then

            btnLIGHT2onOFF.Text = "OFF"
            btnLIGHT2onOFF.BackColor = Color.LightGray
            btnLIGHT2powerON.Text = ""
            btnLIGHT2powerON.BackColor = Color.LightGray
            btnLIGHT2_1Press.Text = ""
            btnLIGHT2_1Press.BackColor = Color.LightGray
            btnLIGHT2_2Press.Text = ""
            btnLIGHT2_2Press.BackColor = Color.LightGray
            btnLIGHT2_3Press.Text = ""
            btnLIGHT2_3Press.BackColor = Color.LightGray

            L2CON(0) = 0
        Else
            btnLIGHT2onOFF.Text = "ON"
            btnLIGHT2onOFF.BackColor = Color.LightBlue
            L2CON(0) = 1
        End If
    End Sub

    Private Sub btnMOTOR2pwrON_Click(sender As Object, e As EventArgs) Handles btnMOTOR2pwrON.Click
        If btnMOTOR2onOFF.Text <> "OFF" Then
            If btnMOTOR2pwrON.Text = "AUTO" Then
                btnMOTOR2pwrON.Text = "SYNC"
                btnMOTOR2pwrON.BackColor = Color.Orange
                M2CON(2) = 0
                M2CON(3) = 0
                M2CON(4) = 1
            ElseIf btnMOTOR2pwrON.Text = "SYNC" Then
                btnMOTOR2pwrON.Text = "PEDAL"
                btnMOTOR2pwrON.BackColor = Color.Orange
                M2CON(2) = 0
                M2CON(3) = 1
                M2CON(4) = 0
            ElseIf btnMOTOR2pwrON.Text = "PEDAL" Then
                btnMOTOR2pwrON.Text = "RUN"
                btnMOTOR2pwrON.BackColor = Color.LightGreen
                M2CON(2) = 0
                M2CON(3) = 1
                M2CON(4) = 1
            ElseIf btnMOTOR2pwrON.Text = "RUN" Then
                btnMOTOR2pwrON.Text = "OFF"
                btnMOTOR2pwrON.BackColor = Color.Red
                M2CON(2) = 1
                M2CON(3) = 0
                M2CON(4) = 0
            ElseIf btnMOTOR2pwrON.Text = "OFF" Then
                btnMOTOR2pwrON.Text = ""
                btnMOTOR2pwrON.BackColor = Color.LightGray
                M2CON(2) = 1
                M2CON(3) = 0
                M2CON(4) = 1
            ElseIf btnMOTOR2pwrON.Text = "" Then
                btnMOTOR2pwrON.Text = "AUTO"
                btnMOTOR2pwrON.BackColor = Color.Orange
                M2CON(2) = 0
                M2CON(3) = 0
                M2CON(4) = 0
            End If
        End If
    End Sub

    Private Sub btnMOTOR2_1Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_1Press.Click
        If btnMOTOR2pwrON.Text <> "OFF" Then


            If btnMOTOR2_1Press.Text = "AUTO" Then
                btnMOTOR2_1Press.Text = "SYNC"
                btnMOTOR2_1Press.BackColor = Color.Orange
                M2CON(5) = 0
                M2CON(6) = 0
                M2CON(7) = 1
            ElseIf btnMOTOR2_1Press.Text = "SYNC" Then
                btnMOTOR2_1Press.Text = "PEDAL"
                btnMOTOR2_1Press.BackColor = Color.Orange
                M2CON(5) = 0
                M2CON(6) = 1
                M2CON(7) = 0
            ElseIf btnMOTOR2_1Press.Text = "PEDAL" Then
                btnMOTOR2_1Press.Text = "RUN"
                btnMOTOR2_1Press.BackColor = Color.LightGreen
                M2CON(5) = 0
                M2CON(6) = 1
                M2CON(7) = 1
            ElseIf btnMOTOR2_1Press.Text = "RUN" Then
                btnMOTOR2_1Press.Text = "OFF"
                btnMOTOR2_1Press.BackColor = Color.Red
                M2CON(5) = 1
                M2CON(6) = 0
                M2CON(7) = 0
            ElseIf btnMOTOR2_1Press.Text = "OFF" Then
                btnMOTOR2_1Press.Text = ""
                btnMOTOR2_1Press.BackColor = Color.LightGray
                M2CON(5) = 1
                M2CON(6) = 0
                M2CON(7) = 1
            ElseIf btnMOTOR2_1Press.Text = "" Then
                btnMOTOR2_1Press.Text = "AUTO"
                btnMOTOR2_1Press.BackColor = Color.Orange
                M2CON(5) = 0
                M2CON(6) = 0
                M2CON(7) = 0
            End If
        End If
    End Sub

    Private Sub btnMOTOR2_2Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_2Press.Click
        If btnMOTOR2_2Press.Text = "AUTO" Then
            btnMOTOR2_2Press.Text = "SYNC"
            btnMOTOR2_2Press.BackColor = Color.Orange
            M2CON(8) = 0
            M2CON(9) = 0
            M2CON(10) = 1
        ElseIf btnMOTOR2_2Press.Text = "SYNC" Then
            btnMOTOR2_2Press.Text = "PEDAL"
            btnMOTOR2_2Press.BackColor = Color.Orange
            M2CON(8) = 0
            M2CON(9) = 1
            M2CON(10) = 0
        ElseIf btnMOTOR2_2Press.Text = "PEDAL" Then
            btnMOTOR2_2Press.Text = "RUN"
            btnMOTOR2_2Press.BackColor = Color.LightGreen
            M2CON(8) = 0
            M2CON(9) = 1
            M2CON(10) = 1
        ElseIf btnMOTOR2_2Press.Text = "RUN" Then
            btnMOTOR2_2Press.Text = "OFF"
            btnMOTOR2_2Press.BackColor = Color.Red
            M2CON(8) = 1
            M2CON(9) = 0
            M2CON(10) = 0
        ElseIf btnMOTOR2_2Press.Text = "OFF" Then
            btnMOTOR2_2Press.Text = ""
            btnMOTOR2_2Press.BackColor = Color.LightGray
            M2CON(8) = 1
            M2CON(9) = 0
            M2CON(10) = 1
        ElseIf btnMOTOR2_2Press.Text = "" Then
            btnMOTOR2_2Press.Text = "AUTO"
            btnMOTOR2_2Press.BackColor = Color.Orange
            M2CON(8) = 0
            M2CON(9) = 0
            M2CON(10) = 0
        End If
    End Sub

    Private Sub btnMOTOR2_3Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_3Press.Click

        If btnMOTOR2_3Press.Text = "AUTO" Then
            btnMOTOR2_3Press.Text = "SYNC"
            btnMOTOR2_3Press.BackColor = Color.Orange
            M2CON(11) = 0
            M2CON(12) = 0
            M2CON(13) = 1
        ElseIf btnMOTOR2_3Press.Text = "SYNC" Then
            btnMOTOR2_3Press.Text = "PEDAL"
            btnMOTOR2_3Press.BackColor = Color.Orange
            M2CON(11) = 0
            M2CON(12) = 1
            M2CON(13) = 0
        ElseIf btnMOTOR2_3Press.Text = "PEDAL" Then
            btnMOTOR2_3Press.Text = "RUN"
            btnMOTOR2_3Press.BackColor = Color.LightGreen
            M2CON(11) = 0
            M2CON(12) = 1
            M2CON(13) = 1
        ElseIf btnMOTOR2_3Press.Text = "RUN" Then
            btnMOTOR2_3Press.Text = "OFF"
            btnMOTOR2_3Press.BackColor = Color.Red
            M2CON(11) = 1
            M2CON(12) = 0
            M2CON(13) = 0
        ElseIf btnMOTOR2_3Press.Text = "OFF" Then
            btnMOTOR2_3Press.Text = ""
            btnMOTOR2_3Press.BackColor = Color.LightGray
            M2CON(11) = 1
            M2CON(12) = 0
            M2CON(13) = 1
        ElseIf btnMOTOR2_3Press.Text = "" Then
            btnMOTOR2_3Press.Text = "AUTO"
            btnMOTOR2_3Press.BackColor = Color.Orange
            M2CON(11) = 0
            M2CON(12) = 0
            M2CON(13) = 0
        End If
    End Sub

    Private Sub btnLIGHT1powerON_Click(sender As Object, e As EventArgs) Handles btnLIGHT1powerON.Click
        If btnLIGHT1onOFF.Text <> "OFF" Then
            If btnLIGHT1powerON.Text = "" Then
                btnLIGHT1powerON.Text = "OFF"
                btnLIGHT1powerON.BackColor = Color.Red
                L1CON(2) = 0
                L1CON(3) = 0
                L1CON(4) = 0
            ElseIf btnLIGHT1powerON.Text = "OFF" Then
                btnLIGHT1powerON.Text = "ON"
                btnLIGHT1powerON.BackColor = Color.LightGreen
                L1CON(2) = 0
                L1CON(3) = 0
                L1CON(4) = 1
            ElseIf btnLIGHT1powerON.Text = "ON" Then
                btnLIGHT1powerON.Text = "FLASH"
                btnLIGHT1powerON.BackColor = Color.Orange
                L1CON(2) = 0
                L1CON(3) = 1
                L1CON(4) = 0
            ElseIf btnLIGHT1powerON.Text = "FLASH" Then
                btnLIGHT1powerON.Text = ""
                btnLIGHT1powerON.BackColor = Color.LightGray
                L1CON(2) = 1
                L1CON(3) = 0
                L1CON(4) = 1
            End If
        End If
    End Sub

    Private Sub btnLIGHT1_1Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_1Press.Click
        If btnLIGHT1powerON.Text <> "" Then
            If btnLIGHT1_1Press.Text = "" Then
                btnLIGHT1_1Press.Text = "OFF"
                btnLIGHT1_1Press.BackColor = Color.Red
                L1CON(5) = 0
                L1CON(6) = 0
                L1CON(7) = 0
            ElseIf btnLIGHT1_1Press.Text = "OFF" Then
                btnLIGHT1_1Press.Text = "ON"
                btnLIGHT1_1Press.BackColor = Color.LightGreen
                L1CON(5) = 0
                L1CON(6) = 0
                L1CON(7) = 1
            ElseIf btnLIGHT1_1Press.Text = "ON" Then
                btnLIGHT1_1Press.Text = "FLASH"
                btnLIGHT1_1Press.BackColor = Color.Orange
                L1CON(5) = 0
                L1CON(6) = 1
                L1CON(7) = 0
            ElseIf btnLIGHT1_1Press.Text = "FLASH" Then 'NA
                btnLIGHT1_1Press.Text = ""
                btnLIGHT1_1Press.BackColor = Color.LightGray
                L1CON(5) = 0
                L1CON(6) = 1
                L1CON(7) = 1
            End If
        End If
    End Sub

    Private Sub btnLIGHT2powerON_Click(sender As Object, e As EventArgs) Handles btnLIGHT2powerON.Click
        If btnLIGHT2onOFF.Text <> "OFF" Then

            If btnLIGHT2powerON.Text = "OFF" Then
                btnLIGHT2powerON.Text = "ON"
                btnLIGHT2powerON.BackColor = Color.LightGreen
                L2CON(2) = 0
                L2CON(3) = 0
                L2CON(4) = 1

            ElseIf btnLIGHT2powerON.Text = "ON" Then
                btnLIGHT2powerON.Text = "FLASH"
                btnLIGHT2powerON.BackColor = Color.Orange
                L2CON(2) = 0
                L2CON(3) = 1
                L2CON(4) = 0

            ElseIf btnLIGHT2powerON.Text = "FLASH" Then
                btnLIGHT2powerON.Text = ""
                btnLIGHT2powerON.BackColor = Color.LightGray
                L2CON(2) = 0
                L2CON(3) = 1
                L2CON(4) = 1
            ElseIf btnLIGHT2powerON.Text = "" Then
                btnLIGHT2powerON.Text = "OFF"
                btnLIGHT2powerON.BackColor = Color.Red
                L2CON(2) = 0
                L2CON(3) = 0
                L2CON(4) = 0

            End If
        End If
    End Sub

    Private Sub btnLIGHT2_1Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_1Press.Click
        If btnLIGHT2powerON.Text <> "" Then
            If btnLIGHT2_1Press.Text = "OFF" Then
                btnLIGHT2_1Press.Text = "ON"
                btnLIGHT2_1Press.BackColor = Color.LightGreen
                L2CON(5) = 0
                L2CON(6) = 0
                L2CON(7) = 1
            ElseIf btnLIGHT2_1Press.Text = "ON" Then
                btnLIGHT2_1Press.Text = "FLASH"
                btnLIGHT2_1Press.BackColor = Color.Orange
                L2CON(5) = 0
                L2CON(6) = 1
                L2CON(7) = 0
            ElseIf btnLIGHT2_1Press.Text = "FLASH" Then
                btnLIGHT2_1Press.Text = ""
                btnLIGHT2_1Press.BackColor = Color.LightGray
                L2CON(5) = 0
                L2CON(6) = 1
                L2CON(7) = 1
            ElseIf btnLIGHT2_1Press.Text = "" Then
                btnLIGHT2_1Press.Text = "OFF"
                btnLIGHT2_1Press.BackColor = Color.Red
                L2CON(5) = 0
                L2CON(6) = 0
                L2CON(7) = 0
            End If
        End If
    End Sub

    Private Sub btnNumberOfCells_Click(sender As Object, e As EventArgs) Handles btnNumberOfCells.Click
        If btnNumberOfCells.Text = "1" Then
            btnNumberOfCells.Text = "2"
            btnNumberOfCells.BackColor = Color.LightGray
            DCR(0) = 1
        ElseIf btnNumberOfCells.Text = "2" Then
            btnNumberOfCells.Text = "1"
            btnNumberOfCells.BackColor = Color.LightBlue
            DCR(0) = 0
        End If
    End Sub

    Private Sub btnAlarm_Buzzer_Light_Click(sender As Object, e As EventArgs) Handles btnAlarm_Buzzer_Light.Click
        If btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
            DCR(4) = 1
            DCR(5) = 1
            DCR(6) = 0
            'DCR.Set(4, 1)
            'DCR.Set(5, 1)
            'DCR.Set(6, 0)

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
            DCR(4) = 1
            DCR(5) = 0
            DCR(6) = 1
            'DCR.Set(4, 1)
            'DCR.Set(5, 0)
            'DCR.Set(6, 1)

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2" Then
            btnAlarm_Buzzer_Light.Text = "OFF"
            btnAlarm_Buzzer_Light.BackColor = Color.Red
            DCR(4) = 0
            DCR(5) = 0
            DCR(6) = 0
            'DCR.Set(4, 0)
            'DCR.Set(5, 0)
            'DCR.Set(6, 0)

        ElseIf btnAlarm_Buzzer_Light.Text = "OFF" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
            DCR(4) = 1
            DCR(5) = 0
            DCR(6) = 0
            'DCR.Set(4, 1)
            'DCR.Set(5, 0)
            'DCR.Set(6, 0)

        End If
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'ilk açılışta ILURA programı ile açılıyor
        'cmbPrograms.ForeColor = System.Drawing.Color.Red
        Dim obj As Object = "CUSTOM DESIGN"
        cmbPrograms.Items.Add(obj)

        'cmbPrograms.Items.Item(0).ForeColor = System.Drawing.Color.Red

        Dim ItemText As String = cmbPrograms.Items(0)

        GetListOfSettings()

        ClearForm()

        GroupBox2.Visible = False

        For Each port In ports
            cmbPorts.Items.Add(port)
            'MsgBox(port, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Serial port detecetd")
        Next port

    End Sub

    Private Sub SetForm()
        btnMOTOR2onOFF.Text = "ON"
        btnMOTOR2onOFF.BackColor = Color.LightBlue
        btnMOTOR2pwrON.Text = "AUTO"
        btnMOTOR2pwrON.BackColor = Color.Orange
        btnMOTOR2_1Press.Text = "RUN"
        btnMOTOR2_1Press.BackColor = Color.LightGreen
        btnMOTOR2_2Press.Text = "PEDAL"
        btnMOTOR2_2Press.BackColor = Color.Orange
        btnMOTOR2_3Press.Text = ""
        btnMOTOR2_3Press.BackColor = Color.LightGray
    End Sub

    Private Sub ClearForm()

        btnMOTOR2onOFF.Text = "OFF"
        btnMOTOR2onOFF.BackColor = Color.LightGray
        btnMOTOR2pwrON.Text = ""
        btnMOTOR2_1Press.Text = ""
        btnMOTOR2_2Press.Text = ""
        btnMOTOR2_3Press.Text = ""

        btnLIGHT1onOFF.Text = "OFF"
        btnLIGHT1onOFF.BackColor = Color.LightGray
        btnLIGHT1powerON.Text = ""
        btnLIGHT1_1Press.Text = ""
        btnLIGHT1_2Press.Text = ""
        btnLIGHT1_3Press.Text = ""

        btnLIGHT2onOFF.Text = "OFF"
        btnLIGHT2onOFF.BackColor = Color.LightGray
        btnLIGHT2powerON.Text = ""
        btnLIGHT2_1Press.Text = ""
        btnLIGHT2_2Press.Text = ""
        btnLIGHT2_3Press.Text = ""

        btnNumberOfCells.Text = "1"
        btnNumberOfCells.BackColor = Color.LightBlue

        btnAlarm_Buzzer_Light.Text = "BUZZER"
        btnAlarm_Buzzer_Light.BackColor = Color.LightBlue

        lblDelay.Text = "0,5s"

        RadioButton_F_SWITCH.Checked = False

        RadioButton_R_PEDAL.Checked = True


        '------

        btnMOTOR2onOFF.BackColor = Color.LightGray
        btnMOTOR2pwrON.BackColor = Color.LightGray
        btnMOTOR2_1Press.BackColor = Color.LightGray
        btnMOTOR2_2Press.BackColor = Color.LightGray
        btnMOTOR2_3Press.BackColor = Color.LightGray

        btnLIGHT1.BackColor = Color.LightGray
        btnLIGHT1powerON.BackColor = Color.LightGray
        btnLIGHT1_1Press.BackColor = Color.LightGray
        btnLIGHT1_2Press.BackColor = Color.LightGray
        btnLIGHT1_3Press.BackColor = Color.LightGray

        btnLIGHT2onOFF.BackColor = Color.LightGray
        btnLIGHT2powerON.BackColor = Color.LightGray
        btnLIGHT2_1Press.BackColor = Color.LightGray
        btnLIGHT2_2Press.BackColor = Color.LightGray
        btnLIGHT2_3Press.BackColor = Color.LightGray

        'M2CON = ILURA_M2CON
        'L1CON = ILURA_L1CON
        'L2CON = ILURA_L1CON
        'DCR = ILURA_M2CON

    End Sub


    Private Sub btnLIGHT1_2Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_2Press.Click
        If btnLIGHT1_1Press.Text <> "" Then
            If btnLIGHT1_2Press.Text = "OFF" Then
                btnLIGHT1_2Press.Text = "ON"
                btnLIGHT1_2Press.BackColor = Color.LightGreen
                L1CON(8) = 0
                L1CON(9) = 0
                L1CON(10) = 1
            ElseIf btnLIGHT1_2Press.Text = "ON" Then
                btnLIGHT1_2Press.Text = "FLASH"
                btnLIGHT1_2Press.BackColor = Color.Orange
                L1CON(8) = 0
                L1CON(9) = 1
                L1CON(10) = 0
            ElseIf btnLIGHT1_2Press.Text = "FLASH" Then
                btnLIGHT1_2Press.Text = ""
                btnLIGHT1_2Press.BackColor = Color.LightGray
                L1CON(8) = 0
                L1CON(9) = 1
                L1CON(10) = 1
            ElseIf btnLIGHT1_2Press.Text = "" Then
                btnLIGHT1_2Press.Text = "OFF"
                btnLIGHT1_2Press.BackColor = Color.Red
                L1CON(8) = 0
                L1CON(9) = 0
                L1CON(10) = 0
            End If
        End If
    End Sub

    Private Sub btnLIGHT1_3Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_3Press.Click
        If btnLIGHT1_2Press.Text <> "" Then
            If btnLIGHT1_3Press.Text = "OFF" Then
                btnLIGHT1_3Press.Text = "ON"
                btnLIGHT1_3Press.BackColor = Color.LightGreen
                L1CON(11) = 0
                L1CON(12) = 0
                L1CON(13) = 1
            ElseIf btnLIGHT1_3Press.Text = "ON" Then
                btnLIGHT1_3Press.Text = "FLASH"
                btnLIGHT1_3Press.BackColor = Color.Orange
                L1CON(11) = 0
                L1CON(12) = 1
                L1CON(13) = 0
            ElseIf btnLIGHT1_3Press.Text = "FLASH" Then
                btnLIGHT1_3Press.Text = ""
                btnLIGHT1_3Press.BackColor = Color.LightGray
                L1CON(11) = 0
                L1CON(12) = 1
                L1CON(13) = 1
            ElseIf btnLIGHT1_3Press.Text = "" Then
                btnLIGHT1_3Press.Text = "OFF"
                btnLIGHT1_3Press.BackColor = Color.Red
                L1CON(11) = 0
                L1CON(12) = 0
                L1CON(13) = 0
            End If
        End If
    End Sub

    Private Sub btnLIGHT2_2Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_2Press.Click
        If btnLIGHT2_1Press.Text <> "" Then
            If btnLIGHT2_2Press.Text = "OFF" Then
                btnLIGHT2_2Press.Text = "ON"
                btnLIGHT2_2Press.BackColor = Color.LightGreen
                L2CON(8) = 0
                L2CON(9) = 0
                L2CON(10) = 1
            ElseIf btnLIGHT2_2Press.Text = "ON" Then
                btnLIGHT2_2Press.Text = "FLASH"
                btnLIGHT2_2Press.BackColor = Color.Orange
                L2CON(8) = 0
                L2CON(9) = 1
                L2CON(10) = 0
            ElseIf btnLIGHT2_2Press.Text = "FLASH" Then
                btnLIGHT2_2Press.Text = ""
                btnLIGHT2_2Press.BackColor = Color.LightGray
                L2CON(8) = 0
                L2CON(9) = 1
                L2CON(10) = 1
            ElseIf btnLIGHT2_2Press.Text = "" Then
                btnLIGHT2_2Press.Text = "OFF"
                btnLIGHT2_2Press.BackColor = Color.Red
                L2CON(8) = 0
                L2CON(9) = 0
                L2CON(10) = 0
            End If
        End If
    End Sub

    Private Sub btnLIGHT2_3Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_3Press.Click
        If btnLIGHT2_2Press.Text <> "" Then
            If btnLIGHT2_3Press.Text = "OFF" Then
                btnLIGHT2_3Press.Text = "ON"
                btnLIGHT2_3Press.BackColor = Color.LightGreen
                L2CON(11) = 0
                L2CON(12) = 0
                L2CON(13) = 1
            ElseIf btnLIGHT2_3Press.Text = "ON" Then
                btnLIGHT2_3Press.Text = "FLASH"
                btnLIGHT2_3Press.BackColor = Color.Orange
                L2CON(11) = 0
                L2CON(12) = 1
                L2CON(13) = 0
            ElseIf btnLIGHT2_3Press.Text = "FLASH" Then
                btnLIGHT2_3Press.Text = ""
                btnLIGHT2_3Press.BackColor = Color.LightGray
                L2CON(11) = 0
                L2CON(12) = 1
                L2CON(13) = 1
            ElseIf btnLIGHT2_3Press.Text = "" Then
                btnLIGHT2_3Press.Text = "OFF"
                btnLIGHT2_3Press.BackColor = Color.Red
                L2CON(11) = 0
                L2CON(12) = 0
                L2CON(13) = 0
            End If
        End If
    End Sub

    Private Sub btnM2CON_Click(sender As Object, e As EventArgs) Handles btnM2CON.Click
        GetLastStateBeforeSave()
        MsgBox("Bit Status; " + M2CON(0).ToString + "-" +
                    " " + M2CON(1).ToString + "-" +
                    " " + M2CON(2).ToString +
                    " " + M2CON(3).ToString +
                    " " + M2CON(4).ToString + "-" +
                    " " + M2CON(5).ToString +
                    " " + M2CON(6).ToString +
                    " " + M2CON(7).ToString + "-" +
                    " " + M2CON(8).ToString +
                    " " + M2CON(9).ToString +
                    " " + M2CON(10).ToString + "-" +
                    " " + M2CON(11).ToString +
                    " " + M2CON(12).ToString +
                    " " + M2CON(13).ToString)
    End Sub

    Private Sub btnL1CON_Click(sender As Object, e As EventArgs) Handles btnL1CON.Click

        GetLastStateBeforeSave()
        MsgBox("L1CON Bit Status; " + L1CON(0).ToString + "-" +
                    " " + L1CON(1).ToString + "-" +
                    " " + L1CON(2).ToString +
                    " " + L1CON(3).ToString +
                    " " + L1CON(4).ToString + "-" +
                    " " + L1CON(5).ToString +
                    " " + L1CON(6).ToString +
                    " " + L1CON(7).ToString + "-" +
                    " " + L1CON(8).ToString +
                    " " + L1CON(9).ToString +
                    " " + L1CON(10).ToString + "-" +
                    " " + L1CON(11).ToString +
                    " " + L1CON(12).ToString +
                    " " + L1CON(13).ToString)
    End Sub

    Private Sub btnL2CON_Click(sender As Object, e As EventArgs) Handles btnL2CON.Click
        GetLastStateBeforeSave()
        MsgBox("L2CON Bit Status; " + L2CON(0).ToString + "-" +
                    " " + L2CON(1).ToString + "-" +
                    " " + L2CON(2).ToString +
                    " " + L2CON(3).ToString +
                    " " + L2CON(4).ToString + "-" +
                    " " + L2CON(5).ToString +
                    " " + L2CON(6).ToString +
                    " " + L2CON(7).ToString + "-" +
                    " " + L2CON(8).ToString +
                    " " + L2CON(9).ToString +
                    " " + L2CON(10).ToString + "-" +
                    " " + L2CON(11).ToString +
                    " " + L2CON(12).ToString +
                    " " + L2CON(13).ToString)
    End Sub

    Private Sub btnDCR_Click(sender As Object, e As EventArgs) Handles btnDCR.Click
        GetLastStateBeforeSave()
        MsgBox("DCR Bit Status; " + DCR(0).ToString +
                    " " + DCR(1).ToString +
                    " " + DCR(2).ToString +
                    " " + DCR(3).ToString +
                    " " + DCR(4).ToString +
                    " " + DCR(5).ToString +
                    " " + DCR(6).ToString +
                    " " + DCR(7).ToString +
                    " " + DCR(8).ToString +
                    " " + DCR(9).ToString +
                    " " + DCR(10).ToString +
                    " " + DCR(11).ToString +
                    " " + DCR(12).ToString +
                    " " + DCR(13).ToString)
    End Sub

    Private Sub RadioButton_R_PEDAL_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_R_PEDAL.CheckedChanged
        If RadioButton_R_PEDAL.Checked Then
            RadioButton_F_SWITCH.Checked = False
            DCR(2) = 1
            DCR(3) = 0
            'DCR.Set(2, 1)
            'DCR.Set(3, 0)
        Else
            RadioButton_F_SWITCH.Checked = True
            DCR(2) = 0
            DCR(3) = 1
            'DCR.Set(2, 0)
            'DCR.Set(3, 1)
        End If
    End Sub

    Private Sub btnDelayPlus_Click(sender As Object, e As EventArgs) Handles btnDelayPlus.Click
        If lblDelay.Text = "0,5s" Then
            lblDelay.Text = "1,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "1,0s" Then
            lblDelay.Text = "1,5s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 1

        ElseIf lblDelay.Text = "1,5s" Then
            lblDelay.Text = "2,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "2,0s" Then
            lblDelay.Text = "2,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "2,5s" Then
            lblDelay.Text = "3,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "3,0s" Then
            lblDelay.Text = "3,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "3,5s" Then
            lblDelay.Text = "4,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "4,0s" Then
            lblDelay.Text = "4,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "4,5s" Then
            lblDelay.Text = "5,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "5,0s" Then
            lblDelay.Text = "5,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "5,5s" Then
            lblDelay.Text = "6,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "6,0s" Then
            lblDelay.Text = "6,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "6,5s" Then
            lblDelay.Text = "7,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "7,0s" Then
            lblDelay.Text = "7,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "7,5s" Then
            lblDelay.Text = "8,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "8,0s" Then
            lblDelay.Text = "8,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "8,5s" Then
            lblDelay.Text = "9,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "9,0s" Then
            lblDelay.Text = "9,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        End If

    End Sub

    Private Sub btnDelayMinus_Click(sender As Object, e As EventArgs) Handles btnDelayMinus.Click
        If lblDelay.Text = "9,5s" Then
            lblDelay.Text = "9,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "9,0s" Then
            lblDelay.Text = "8,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "8,5s" Then
            lblDelay.Text = "8,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "8,0s" Then
            lblDelay.Text = "7,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "7,5s" Then
            lblDelay.Text = "7,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "7,0s" Then
            lblDelay.Text = "6,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "6,5s" Then
            lblDelay.Text = "6,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "6,0s" Then
            lblDelay.Text = "5,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "5,5s" Then
            lblDelay.Text = "5,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "5,0s" Then
            lblDelay.Text = "4,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "4,5s" Then
            lblDelay.Text = "4,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "4,0s" Then
            lblDelay.Text = "3,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "3,5s" Then
            lblDelay.Text = "3,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "3,0s" Then
            lblDelay.Text = "2,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "2,5s" Then
            lblDelay.Text = "2,0s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "2,0s" Then
            lblDelay.Text = "1,5s"
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "1,5s" Then
            lblDelay.Text = "1,0s"
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "1,0s" Then
            lblDelay.Text = "0,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        End If
    End Sub

    Public Function LoadSpecFile(finame As String) As String

        Dim text As String
        Dim FILE_NAME As String = Application.StartupPath & "\SETTINGS\" + finame + ".txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            text = objReader.ReadToEnd()
            MessageBox.Show(text)
            objReader.Close()
            'MessageBox.Show("Text written to file")
        Else
            MessageBox.Show("File Does Not Exist")
        End If
        Return text

    End Function

    Private Function ParseText(filename As String)
        If (filename = "CUSTOM DESIGN") Then
            Exit Function
        End If

        Dim testString As String = LoadSpecFile(filename)
        If (testString = Nothing) Then
            Exit Function
        End If

        Dim testArray() As String = Split(testString)


        Dim M2CON() As Byte = ConvertStringToByteArray(testArray(1))
        If M2CON(0) = "0" Then
            btnMOTOR2onOFF.Text = "OFF"
            btnMOTOR2onOFF.BackColor = Color.LightGray
        ElseIf M2CON(0) = "1" Then
            btnMOTOR2onOFF.Text = "ON"
            btnMOTOR2onOFF.BackColor = Color.LightBlue
        End If
        'MOTOR2 Power On
        If M2CON(2) = "0" And M2CON(3) = "0" AndAlso M2CON(4) = "0" Then
            btnMOTOR2pwrON.Text = "AUTO"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf M2CON(2) = "0" And M2CON(3) = "0" AndAlso M2CON(4) = "1" Then
            btnMOTOR2pwrON.Text = "SYNC"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf M2CON(2) = "0" And M2CON(3) = "1" AndAlso M2CON(4) = "0" Then
            btnMOTOR2pwrON.Text = "PEDAL"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf M2CON(2) = "0" And M2CON(3) = "1" AndAlso M2CON(4) = "1" Then
            btnMOTOR2pwrON.Text = "RUN"
            btnMOTOR2pwrON.BackColor = Color.LightGreen
        ElseIf M2CON(2) = "1" And M2CON(3) = "0" AndAlso M2CON(4) = "0" Then
            btnMOTOR2pwrON.Text = "OFF"
            btnMOTOR2pwrON.BackColor = Color.Red
        ElseIf M2CON(2) = "1" And M2CON(3) = "0" AndAlso M2CON(4) = "1" Then
            btnMOTOR2pwrON.Text = ""
            btnMOTOR2pwrON.BackColor = Color.LightGray

        End If
        'Motor2 1.Press
        If M2CON(5) = "0" And M2CON(6) = "0" AndAlso M2CON(7) = "0" Then
            btnMOTOR2_1Press.Text = "AUTO"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf M2CON(5) = "0" And M2CON(6) = "0" AndAlso M2CON(7) = "1" Then
            btnMOTOR2_1Press.Text = "SYNC"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf M2CON(5) = "0" And M2CON(6) = "1" AndAlso M2CON(7) = "0" Then
            btnMOTOR2_1Press.Text = "PEDAL"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf M2CON(5) = "0" And M2CON(6) = "1" AndAlso M2CON(7) = "1" Then
            btnMOTOR2_1Press.Text = "RUN"
            btnMOTOR2_1Press.BackColor = Color.LightGreen
        ElseIf M2CON(5) = "1" And M2CON(6) = "0" AndAlso M2CON(7) = "0" Then
            btnMOTOR2_1Press.Text = "OFF"
            btnMOTOR2_1Press.BackColor = Color.Red
        ElseIf M2CON(5) = "1" And M2CON(6) = "0" AndAlso M2CON(7) = "1" Then
            btnMOTOR2_1Press.Text = ""
            btnMOTOR2_1Press.BackColor = Color.LightGray
        End If

        'Motor2 2.Press
        If M2CON(8) = "0" And M2CON(9) = "0" AndAlso M2CON(10) = "0" Then
            btnMOTOR2_2Press.Text = "AUTO"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf M2CON(8) = "0" And M2CON(9) = "0" AndAlso M2CON(10) = "1" Then
            btnMOTOR2_2Press.Text = "SYNC"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf M2CON(8) = "0" And M2CON(9) = "1" AndAlso M2CON(10) = "0" Then
            btnMOTOR2_2Press.Text = "PEDAL"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf M2CON(8) = "0" And M2CON(9) = "1" AndAlso M2CON(10) = "1" Then
            btnMOTOR2_2Press.Text = "RUN"
            btnMOTOR2_2Press.BackColor = Color.LightGreen
        ElseIf M2CON(8) = "1" And M2CON(9) = "0" AndAlso M2CON(10) = "0" Then
            btnMOTOR2_2Press.Text = "OFF"
            btnMOTOR2_2Press.BackColor = Color.Red
        ElseIf M2CON(8) = "1" And M2CON(9) = "0" AndAlso M2CON(10) = "1" Then
            btnMOTOR2_2Press.Text = ""
            btnMOTOR2_2Press.BackColor = Color.LightGray
        End If

        'Motor2 3.Press
        If M2CON(11) = "0" And M2CON(12) = "0" AndAlso M2CON(13) = "0" Then
            btnMOTOR2_3Press.Text = "AUTO"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf M2CON(11) = "0" And M2CON(12) = "0" AndAlso M2CON(13) = "1" Then
            btnMOTOR2_3Press.Text = "SYNC"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf M2CON(11) = "0" And M2CON(12) = "1" AndAlso M2CON(13) = "0" Then
            btnMOTOR2_3Press.Text = "PEDAL"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf M2CON(11) = "0" And M2CON(12) = "1" AndAlso M2CON(13) = "1" Then
            btnMOTOR2_3Press.Text = "RUN"
            btnMOTOR2_3Press.BackColor = Color.LightGreen
        ElseIf M2CON(11) = "1" And M2CON(12) = "0" AndAlso M2CON(13) = "0" Then
            btnMOTOR2_3Press.Text = "OFF"
            btnMOTOR2_3Press.BackColor = Color.Red
        ElseIf M2CON(11) = "1" And M2CON(12) = "0" AndAlso M2CON(13) = "1" Then
            btnMOTOR2_3Press.Text = ""
            btnMOTOR2_3Press.BackColor = Color.LightGray
        End If

        Dim L1CON() As Byte = ConvertStringToByteArray(testArray(2)) 'testArray(2).ToCharArray

        If L1CON(0) = "0" Then
            btnLIGHT1onOFF.Text = "OFF"
            btnLIGHT1onOFF.BackColor = Color.LightGray
        ElseIf L1CON(0) = "1" Then
            btnLIGHT1onOFF.Text = "ON"
            btnLIGHT1onOFF.BackColor = Color.LightBlue
        End If
        'LIGHT1 Power On
        If L1CON(2) = "0" And L1CON(3) = "0" AndAlso L1CON(4) = "0" Then
            btnLIGHT1powerON.Text = "OFF"
            btnLIGHT1powerON.BackColor = Color.Red
        ElseIf L1CON(2) = "0" And L1CON(3) = "0" AndAlso L1CON(4) = "1" Then
            btnLIGHT1powerON.Text = "ON"
            btnLIGHT1powerON.BackColor = Color.LightGreen
        ElseIf L1CON(2) = "0" And L1CON(3) = "1" AndAlso L1CON(4) = "0" Then
            btnLIGHT1powerON.Text = "FLASH"
            btnLIGHT1powerON.BackColor = Color.Orange
        ElseIf L1CON(2) = "0" And L1CON(3) = "1" AndAlso L1CON(4) = "1" Then
            btnLIGHT1powerON.Text = ""
            btnLIGHT1powerON.BackColor = Color.LightGray
        End If
        'LIGHT1 1.Press
        If L1CON(5) = "0" And L1CON(6) = "0" AndAlso L1CON(7) = "0" Then
            btnLIGHT1_1Press.Text = "OFF"
            btnLIGHT1_1Press.BackColor = Color.Red
        ElseIf L1CON(5) = "0" And L1CON(6) = "0" AndAlso L1CON(7) = "1" Then
            btnLIGHT1_1Press.Text = "ON"
            btnLIGHT1_1Press.BackColor = Color.LightGreen
        ElseIf L1CON(5) = "0" And L1CON(6) = "1" AndAlso L1CON(7) = "0" Then
            btnLIGHT1_1Press.Text = "FLASH"
            btnLIGHT1_1Press.BackColor = Color.Orange
        ElseIf L1CON(5) = "0" And L1CON(6) = "1" AndAlso L1CON(7) = "1" Then
            btnLIGHT1_1Press.Text = ""
            btnLIGHT1_1Press.BackColor = Color.LightGray
        End If

        'LIGHT1 2.Press
        If L1CON(8) = "0" And L1CON(9) = "0" AndAlso L1CON(10) = "0" Then
            btnLIGHT1_2Press.Text = "OFF"
            btnLIGHT1_2Press.BackColor = Color.Red
        ElseIf L1CON(8) = "0" And L1CON(9) = "0" AndAlso L1CON(10) = "1" Then
            btnLIGHT1_2Press.Text = "ON"
            btnLIGHT1_2Press.BackColor = Color.LightGreen
        ElseIf L1CON(8) = "0" And L1CON(9) = "1" AndAlso L1CON(10) = "0" Then
            btnLIGHT1_2Press.Text = "FLASH"
            btnLIGHT1_2Press.BackColor = Color.Orange
        ElseIf L1CON(8) = "0" And L1CON(9) = "1" AndAlso L1CON(10) = "1" Then
            btnLIGHT1_2Press.Text = ""
            btnLIGHT1_2Press.BackColor = Color.LightGray
        End If

        'LIGHT1 3.Press
        If L1CON(11) = "0" And L1CON(12) = "0" AndAlso L1CON(13) = "0" Then
            btnLIGHT1_3Press.Text = "OFF"
            btnLIGHT1_3Press.BackColor = Color.Red
        ElseIf L1CON(11) = "0" And L1CON(12) = "0" AndAlso L1CON(13) = "1" Then
            btnLIGHT1_3Press.Text = "ON"
            btnLIGHT1_3Press.BackColor = Color.LightGreen
        ElseIf L1CON(11) = "0" And L1CON(12) = "1" AndAlso L1CON(13) = "0" Then
            btnLIGHT1_3Press.Text = "FLASH"
            btnLIGHT1_3Press.BackColor = Color.Orange
        ElseIf L1CON(11) = "0" And L1CON(12) = "1" AndAlso L1CON(13) = "1" Then
            btnLIGHT1_3Press.Text = ""
            btnLIGHT1_3Press.BackColor = Color.LightGray
        End If

        Dim L2CON() As Byte = ConvertStringToByteArray(testArray(3)) 'testArray(3).ToCharArray

        If L2CON(0) = "0" Then
            btnLIGHT2onOFF.Text = "OFF"
            btnLIGHT2onOFF.BackColor = Color.LightGray
        ElseIf L2CON(0) = "1" Then
            btnLIGHT2onOFF.Text = "ON"
            btnLIGHT2onOFF.BackColor = Color.LightBlue
        End If
        'LIGHT2 Power On
        If L2CON(2) = "0" And L2CON(3) = "0" AndAlso L2CON(4) = "0" Then
            btnLIGHT2powerON.Text = "OFF"
            btnLIGHT2powerON.BackColor = Color.Red
        ElseIf L2CON(2) = "0" And L2CON(3) = "0" AndAlso L2CON(4) = "1" Then
            btnLIGHT2powerON.Text = "ON"
            btnLIGHT2powerON.BackColor = Color.LightGreen
        ElseIf L2CON(2) = "0" And L2CON(3) = "1" AndAlso L2CON(4) = "0" Then
            btnLIGHT2powerON.Text = "FLASH"
            btnLIGHT2powerON.BackColor = Color.Orange
        ElseIf L2CON(2) = "0" And L2CON(3) = "1" AndAlso L2CON(4) = "1" Then
            btnLIGHT2powerON.Text = ""
            btnLIGHT2powerON.BackColor = Color.LightGray
        End If
        'LIGHT2 1.Press
        If L2CON(5) = "0" And L2CON(6) = "0" AndAlso L2CON(7) = "0" Then
            btnLIGHT2_1Press.Text = "OFF"
            btnLIGHT2_1Press.BackColor = Color.Red
        ElseIf L2CON(5) = "0" And L2CON(6) = "0" AndAlso L2CON(7) = "1" Then
            btnLIGHT2_1Press.Text = "ON"
            btnLIGHT2_1Press.BackColor = Color.LightGreen
        ElseIf L2CON(5) = "0" And L2CON(6) = "1" AndAlso L2CON(7) = "0" Then
            btnLIGHT2_1Press.Text = "FLASH"
            btnLIGHT2_1Press.BackColor = Color.Orange
        ElseIf L2CON(5) = "0" And L2CON(6) = "1" AndAlso L2CON(7) = "1" Then
            btnLIGHT2_1Press.Text = ""
            btnLIGHT2_1Press.BackColor = Color.LightGray
        End If

        'LIGHT2 2.Press
        If L2CON(8) = "0" And L2CON(9) = "0" AndAlso L2CON(10) = "0" Then
            btnLIGHT2_2Press.Text = "OFF"
            btnLIGHT2_2Press.BackColor = Color.Red
        ElseIf L2CON(8) = "0" And L2CON(9) = "0" AndAlso L2CON(10) = "1" Then
            btnLIGHT2_2Press.Text = "ON"
            btnLIGHT2_2Press.BackColor = Color.LightGreen
        ElseIf L2CON(8) = "0" And L2CON(9) = "1" AndAlso L2CON(10) = "0" Then
            btnLIGHT2_2Press.Text = "FLASH"
            btnLIGHT2_2Press.BackColor = Color.Orange
        ElseIf L2CON(8) = "0" And L2CON(9) = "1" AndAlso L2CON(10) = "1" Then
            btnLIGHT2_2Press.Text = ""
            btnLIGHT2_2Press.BackColor = Color.LightGray
        End If

        'LIGHT2 3.Press
        If L2CON(11) = "0" And L2CON(12) = "0" AndAlso L2CON(13) = "0" Then
            btnLIGHT2_3Press.Text = "OFF"
            btnLIGHT2_3Press.BackColor = Color.Red
        ElseIf L2CON(11) = "0" And L2CON(12) = "0" AndAlso L2CON(13) = "1" Then
            btnLIGHT2_3Press.Text = "ON"
            btnLIGHT2_3Press.BackColor = Color.LightGreen
        ElseIf L2CON(11) = "0" And L2CON(12) = "1" AndAlso L2CON(13) = "0" Then
            btnLIGHT2_3Press.Text = "FLASH"
            btnLIGHT2_3Press.BackColor = Color.Orange
        ElseIf L2CON(11) = "0" And L2CON(12) = "1" AndAlso L2CON(13) = "1" Then
            btnLIGHT2_3Press.Text = ""
            btnLIGHT2_3Press.BackColor = Color.LightGray
        End If

        Dim DCR() As Byte = ConvertStringToByteArray(testArray(4)) 'testArray(4).ToCharArray

        If DCR(0) = 0 Then
            btnNumberOfCells.Text = "1"
            btnNumberOfCells.BackColor = Color.LightBlue
        ElseIf DCR(0) = 1 Then
            btnNumberOfCells.Text = "2"
            btnNumberOfCells.BackColor = Color.LightGray
        End If

        If DCR(2) = 0 And DCR(3) = 1 Then
            RadioButton_F_SWITCH.Checked = True
            RadioButton_R_PEDAL.Checked = False
        ElseIf DCR(2) = 1 And DCR(3) = 0 Then
            RadioButton_F_SWITCH.Checked = False
            RadioButton_R_PEDAL.Checked = True
        End If

        If DCR(4) = 1 And DCR(5) = 1 AndAlso DCR(6) = 0 Then 'btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue

        ElseIf DCR(4) = 1 And DCR(5) = 0 AndAlso DCR(6) = 1 Then 'btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue

        ElseIf DCR(4) = 0 And DCR(5) = 0 AndAlso DCR(6) = 0 Then 'btnAlarm_Buzzer_Light.Text = "OFF" Then
            btnAlarm_Buzzer_Light.Text = "OFF"
            btnAlarm_Buzzer_Light.BackColor = Color.Red

        ElseIf DCR(4) = 1 And DCR(5) = 0 AndAlso DCR(6) = 0 Then 'btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue

        End If

        Dim DCRCONstring As String = ""
        Dim sayi As New System.Text.StringBuilder()
        For indexA = 7 To 13
            sayi.Append(DCR(indexA))
        Next indexA
        DCRCONstring = sayi.ToString
        If DCRCONstring = "1111101" Then
            lblDelay.Text = "9,5s"
        ElseIf DCRCONstring = "0101101" Then
            lblDelay.Text = "9,0s"
        ElseIf DCRCONstring = "1010101" Then
            lblDelay.Text = "8,5s"
        ElseIf DCRCONstring = "0000101" Then
            lblDelay.Text = "8,0s"
        ElseIf DCRCONstring = "1101001" Then
            lblDelay.Text = "7,5s"
        ElseIf DCRCONstring = "0110001" Then
            lblDelay.Text = "7,0s"
        ElseIf DCRCONstring = "1000001" Then
            lblDelay.Text = "6,5s"
        ElseIf DCRCONstring = "0011110" Then
            lblDelay.Text = "6,0s"
        ElseIf DCRCONstring = "1110110" Then
            lblDelay.Text = "5,5s"
        ElseIf DCRCONstring = "0100110" Then
            lblDelay.Text = "5,0s"
        ElseIf DCRCONstring = "1011010" Then
            lblDelay.Text = "4,5s"
        ElseIf DCRCONstring = "0001010" Then
            lblDelay.Text = "4,0s"
        ElseIf DCRCONstring = "1100010" Then
            lblDelay.Text = "3,5s"
        ElseIf DCRCONstring = "0111100" Then
            lblDelay.Text = "3,0s"
        ElseIf DCRCONstring = "1001100" Then
            lblDelay.Text = "2,5s"
        ElseIf DCRCONstring = "0010100" Then
            lblDelay.Text = "2,0s"
        ElseIf DCRCONstring = "0001111" Then ''HATA Then11111
            lblDelay.Text = "1,5s"
        ElseIf DCRCONstring = "0101000" Then
            lblDelay.Text = "1,0s"
        ElseIf DCRCONstring = "1010000" Then
            lblDelay.Text = "0,5s"
        End If


    End Function
    Private Sub GetListOfSettings()
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\SETTINGS")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.txt")
        Dim fi As IO.FileInfo

        cmbPrograms.ForeColor = System.Drawing.Color.Black
        For Each fi In aryFi
            Dim filename As String = fi.Name.Substring(0, fi.Name.Length - 4)

            AddMenuItem(filename)

        Next
    End Sub

    Private Sub AddMenuItem(item As String)
        cmbPrograms.Items.Add(item)



        'Dim SubMenu As New ToolStripMenuItem
        'SubMenu.Text = item
        'AddHandler SubMenu.Click, AddressOf ClickMenuItem

        'ProgramsToolStripMenuItem.DropDownItems.Add(SubMenu)
    End Sub
    Private Sub btnLOAD_Click(sender As Object, e As EventArgs) Handles btnLOAD.Click
        Dim testString As String = LoadSpecFile("")

        Dim testArray() As String = Split(testString)

        Dim received_M2CONByte() As Byte = ConvertStringToByteArray(testArray(1))

        'M2CON = received_M2CONByte

    End Sub

    Private Function ConvertStringToByteArray(paramString As String) As Byte()
        Dim paramByte(13) As Byte
        If paramString <> "" Then
            Dim parameterChar() As Char = paramString.ToCharArray
            For i As Integer = 0 To 13
                paramByte(i) = Char.GetNumericValue(parameterChar(i))
            Next
        End If
        Return paramByte
    End Function


    Private Sub received_M2CON_Click(sender As Object, e As EventArgs) Handles btnReceived_M2CON.Click

        M2CON(0) = 1
        MsgBox("M2CON Bit Status: " + M2CON(13).ToString +
                    " " + M2CON(12).ToString +
                    " " + M2CON(11).ToString +
                    " " + M2CON(10).ToString +
                    " " + M2CON(9).ToString +
                    " " + M2CON(8).ToString +
                    " " + M2CON(7).ToString +
                    " " + M2CON(6).ToString +
                    " " + M2CON(5).ToString +
                    " " + M2CON(4).ToString +
                    " " + M2CON(3).ToString +
                    " " + M2CON(2).ToString +
                    " " + M2CON(1).ToString +
                    " " + M2CON(0).ToString)


    End Sub

    Public Function Save() As String
        GetLastStateBeforeSave()
        Dim M2CONstring As String = ""
        Dim sb1 As New System.Text.StringBuilder()
        For indexA = 0 To 13
            sb1.Append(M2CON(indexA))
        Next indexA
        M2CONstring = sb1.ToString

        Dim L1CONstring As String = ""
        Dim sb2 As New System.Text.StringBuilder()
        For indexA = 0 To 13
            sb2.Append(L1CON(indexA))
        Next indexA
        L1CONstring = sb2.ToString

        Dim L2CONstring As String = ""
        Dim sb3 As New System.Text.StringBuilder()
        For indexA = 0 To 13
            sb3.Append(L2CON(indexA))
        Next indexA
        L2CONstring = sb3.ToString

        Dim DCRCONstring As String = ""
        Dim sb4 As New System.Text.StringBuilder()
        For indexA = 0 To 13
            sb4.Append(DCR(indexA))
        Next indexA
        DCRCONstring = sb4.ToString

        Dim st As String
        st = M2CONstring + " " + L1CONstring + " " + L2CONstring + " " + DCRCONstring

        Return st
    End Function



    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click

        If (cmbPrograms.SelectedItem = "") Then
            MessageBox.Show("No program selected!")
            Exit Sub
        End If


        M2CON(1) = 1
        Dim st As String
        st = Save()

        'Dim M2CONstring As String = System.Text.Encoding.UTF8.GetString(M2CON)

        Dim FILE_NAME As String = Application.StartupPath & "\SETTINGS\" + cmbPrograms.SelectedItem + ".txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(cmbPrograms.SelectedItem + " " + st)
            objWriter.Close()
            MessageBox.Show("Text written to file")
        Else

            Dim myValue As String = InputBox("Program Name:", "Program Name", "Please enter a valid program name here")
            If (myValue = "" Or myValue = "Please enter a valid program name here") Then
                MessageBox.Show("Enter a valid program name")
                Exit Sub
            End If
            myValue = myValue.ToUpper
            FILE_NAME = Application.StartupPath & "\SETTINGS\" + myValue + ".txt"
            'MessageBox.Show("File Does Not Exist")
            System.IO.File.Create(FILE_NAME).Dispose()
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(myValue + " " + st)
            objWriter.Close()

                ' MENUYE EKLEME
                AddMenuItem(myValue)
            MessageBox.Show("Text written to new file named: " + myValue)

        End If

        'Dim path As String = Application.StartupPath & "\M2CON.txt"
        'IO.File.WriteAllLines(FileName, M2CON)
        'Dim fs As New FileStream(Path, FileMode.Create)
        'fs.Write(M2CON, 0, M2CON.Length)
        'fs.Close()
        'MessageBox.Show("M2CON saved")

    End Sub

    Private Sub btnBitToByte_Click(sender As Object, e As EventArgs) Handles btnBitToByte.Click


    End Sub

    Private Function UnicodeBytesToString(
    ByVal bytes() As Byte) As String

        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Private Sub btnMOTOR1_Click(sender As Object, e As EventArgs) Handles btnMOTOR1.Click

    End Sub

    Private Sub ProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramsToolStripMenuItem.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox7.Visible = False


    End Sub

    Private Sub MERCADONAToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CUSTOMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ClearForm()

    End Sub

    Private Sub ClickMenuItem(ByVal sender As Object, ByVal e As EventArgs)
        ClearForm()
        ParseText(sender.ToString)
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
        GroupBox7.Visible = False

    End Sub

    Private Sub GetLastStateBeforeSave()
        If btnMOTOR2onOFF.Text = "ON" Then
            M2CON(0) = 1
        Else
            M2CON(0) = 0
        End If

        If btnMOTOR2pwrON.Text = "SYNC" Then
            M2CON(2) = 0
            M2CON(3) = 0
            M2CON(4) = 1
        ElseIf btnMOTOR2pwrON.Text = "PEDAL" Then
            M2CON(2) = 0
            M2CON(3) = 1
            M2CON(4) = 0
        ElseIf btnMOTOR2pwrON.Text = "RUN" Then
            M2CON(2) = 0
            M2CON(3) = 1
            M2CON(4) = 1
        ElseIf btnMOTOR2pwrON.Text = "OFF" Then
            M2CON(2) = 1
            M2CON(3) = 0
            M2CON(4) = 0
        ElseIf btnMOTOR2pwrON.Text = "" Then
            M2CON(2) = 1
            M2CON(3) = 0
            M2CON(4) = 1
        ElseIf btnMOTOR2pwrON.Text = "AUTO" Then
            M2CON(2) = 0
            M2CON(3) = 0
            M2CON(4) = 0
        End If
        If btnMOTOR2_1Press.Text = "SYNC" Then
            M2CON(5) = 0
            M2CON(6) = 0
            M2CON(7) = 1
        ElseIf btnMOTOR2_1Press.Text = "PEDAL" Then
            M2CON(5) = 0
            M2CON(6) = 1
            M2CON(7) = 0
        ElseIf btnMOTOR2_1Press.Text = "RUN" Then
            M2CON(5) = 0
            M2CON(6) = 1
            M2CON(7) = 1
        ElseIf btnMOTOR2_1Press.Text = "OFF" Then
            M2CON(5) = 1
            M2CON(6) = 0
            M2CON(7) = 0
        ElseIf btnMOTOR2_1Press.Text = "" Then
            M2CON(5) = 1
            M2CON(6) = 0
            M2CON(7) = 1
        ElseIf btnMOTOR2_1Press.Text = "AUTO" Then
            M2CON(5) = 0
            M2CON(6) = 0
            M2CON(7) = 0
        End If

        If btnMOTOR2_2Press.Text = "SYNC" Then
            M2CON(8) = 0
            M2CON(9) = 0
            M2CON(10) = 1
        ElseIf btnMOTOR2_2Press.Text = "PEDAL" Then
            M2CON(8) = 0
            M2CON(9) = 1
            M2CON(10) = 0
        ElseIf btnMOTOR2_2Press.Text = "RUN" Then
            M2CON(8) = 0
            M2CON(9) = 1
            M2CON(10) = 1
        ElseIf btnMOTOR2_2Press.Text = "OFF" Then
            M2CON(8) = 1
            M2CON(9) = 0
            M2CON(10) = 0
        ElseIf btnMOTOR2_2Press.Text = "" Then
            M2CON(8) = 1
            M2CON(9) = 0
            M2CON(10) = 1
        ElseIf btnMOTOR2_2Press.Text = "AUTO" Then
            M2CON(8) = 0
            M2CON(9) = 0
            M2CON(10) = 0
        End If

        If btnMOTOR2_3Press.Text = "SYNC" Then
            M2CON(11) = 0
            M2CON(12) = 0
            M2CON(13) = 1
        ElseIf btnMOTOR2_3Press.Text = "PEDAL" Then
            M2CON(11) = 0
            M2CON(12) = 1
            M2CON(13) = 0
        ElseIf btnMOTOR2_3Press.Text = "RUN" Then
            M2CON(11) = 0
            M2CON(12) = 1
            M2CON(13) = 1
        ElseIf btnMOTOR2_3Press.Text = "OFF" Then
            M2CON(11) = 1
            M2CON(12) = 0
            M2CON(13) = 0
        ElseIf btnMOTOR2_3Press.Text = "" Then
            M2CON(11) = 1
            M2CON(12) = 0
            M2CON(13) = 1
        ElseIf btnMOTOR2_3Press.Text = "AUTO" Then
            M2CON(11) = 0
            M2CON(12) = 0
            M2CON(13) = 0
        End If

        If btnLIGHT1onOFF.Text = "ON" Then
            L1CON(0) = 1
        Else
            L1CON(0) = 0
        End If
        If btnLIGHT1powerON.Text = "OFF" Then
            L1CON(2) = 0
            L1CON(3) = 0
            L1CON(4) = 0
        ElseIf btnLIGHT1powerON.Text = "ON" Then
            L1CON(2) = 0
            L1CON(3) = 0
            L1CON(4) = 1
        ElseIf btnLIGHT1powerON.Text = "FLASH" Then
            L1CON(2) = 0
            L1CON(3) = 1
            L1CON(4) = 0
        ElseIf btnLIGHT1powerON.Text = "" Then
            L1CON(2) = 1
            L1CON(3) = 0
            L1CON(4) = 1
        End If

        If btnLIGHT1_1Press.Text = "OFF" Then
            L1CON(5) = 0
            L1CON(6) = 0
            L1CON(7) = 0
        ElseIf btnLIGHT1_1Press.Text = "ON" Then
            L1CON(5) = 0
            L1CON(6) = 0
            L1CON(7) = 1
        ElseIf btnLIGHT1_1Press.Text = "FLASH" Then
            L1CON(5) = 0
            L1CON(6) = 1
            L1CON(7) = 0
        ElseIf btnLIGHT1_1Press.Text = "" Then 'NA
            L1CON(5) = 0
            L1CON(6) = 1
            L1CON(7) = 1
        End If

        If btnLIGHT1_2Press.Text = "OFF" Then
            L1CON(8) = 0
            L1CON(9) = 0
            L1CON(10) = 0
        ElseIf btnLIGHT1_2Press.Text = "ON" Then
            L1CON(8) = 0
            L1CON(9) = 0
            L1CON(10) = 1
        ElseIf btnLIGHT1_2Press.Text = "FLASH" Then
            L1CON(8) = 0
            L1CON(9) = 1
            L1CON(10) = 0
        ElseIf btnLIGHT1_2Press.Text = "" Then 'NA
            L1CON(8) = 0
            L1CON(9) = 1
            L1CON(10) = 1
        End If
        If btnLIGHT1_3Press.Text = "OFF" Then
            L1CON(11) = 0
            L1CON(12) = 0
            L1CON(13) = 0
        ElseIf btnLIGHT1_3Press.Text = "ON" Then
            L1CON(11) = 0
            L1CON(12) = 0
            L1CON(13) = 1
        ElseIf btnLIGHT1_3Press.Text = "FLASH" Then
            L1CON(11) = 0
            L1CON(12) = 1
            L1CON(13) = 0
        ElseIf btnLIGHT1_3Press.Text = "" Then 'NA
            L1CON(11) = 0
            L1CON(12) = 1
            L1CON(13) = 1
        End If

        If btnLIGHT2onOFF.Text = "ON" Then
            L2CON(0) = 1
        Else
            L2CON(0) = 0
        End If
        If btnLIGHT2powerON.Text = "OFF" Then
            L2CON(2) = 0
            L2CON(3) = 0
            L2CON(4) = 0
        ElseIf btnLIGHT2powerON.Text = "ON" Then
            L2CON(2) = 0
            L2CON(3) = 0
            L2CON(4) = 1
        ElseIf btnLIGHT2powerON.Text = "FLASH" Then
            L2CON(2) = 0
            L2CON(3) = 1
            L2CON(4) = 0
        ElseIf btnLIGHT2powerON.Text = "" Then
            L2CON(2) = 1
            L2CON(3) = 0
            L2CON(4) = 1
        End If

        If btnLIGHT2_1Press.Text = "OFF" Then
            L2CON(5) = 0
            L2CON(6) = 0
            L2CON(7) = 0
        ElseIf btnLIGHT2_1Press.Text = "ON" Then
            L2CON(5) = 0
            L2CON(6) = 0
            L2CON(7) = 1
        ElseIf btnLIGHT2_1Press.Text = "FLASH" Then
            L2CON(5) = 0
            L2CON(6) = 1
            L2CON(7) = 0
        ElseIf btnLIGHT2_1Press.Text = "" Then 'NA
            L2CON(5) = 0
            L2CON(6) = 1
            L2CON(7) = 1
        End If

        If btnLIGHT2_2Press.Text = "OFF" Then
            L2CON(8) = 0
            L2CON(9) = 0
            L2CON(10) = 0
        ElseIf btnLIGHT2_2Press.Text = "ON" Then
            L2CON(8) = 0
            L2CON(9) = 0
            L2CON(10) = 1
        ElseIf btnLIGHT2_2Press.Text = "FLASH" Then
            L2CON(8) = 0
            L2CON(9) = 1
            L2CON(10) = 0
        ElseIf btnLIGHT2_2Press.Text = "" Then 'NA
            L2CON(8) = 0
            L2CON(9) = 1
            L2CON(10) = 1
        End If

        If btnLIGHT2_3Press.Text = "OFF" Then
            L2CON(11) = 0
            L2CON(12) = 0
            L2CON(13) = 0
        ElseIf btnLIGHT2_3Press.Text = "ON" Then
            L2CON(11) = 0
            L2CON(12) = 0
            L2CON(13) = 1
        ElseIf btnLIGHT2_3Press.Text = "FLASH" Then
            L2CON(11) = 0
            L2CON(12) = 1
            L2CON(13) = 0
        ElseIf btnLIGHT2_3Press.Text = "" Then 'NA
            L2CON(11) = 0
            L2CON(12) = 1
            L2CON(13) = 1
        End If  'EKLE

        If btnNumberOfCells.Text = "1" Then
            DCR(0) = 0
        ElseIf btnNumberOfCells.Text = "2" Then
            DCR(0) = 1
        End If

        If btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1" Then
            DCR(4) = 1
            DCR(5) = 1
            DCR(6) = 0

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2" Then
            DCR(4) = 1
            DCR(5) = 0
            DCR(6) = 1

        ElseIf btnAlarm_Buzzer_Light.Text = "OFF" Then
            DCR(4) = 0
            DCR(5) = 0
            DCR(6) = 0

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            DCR(4) = 1
            DCR(5) = 0
            DCR(6) = 0

        End If

        If lblDelay.Text = "0,5s" Then
            lblDelay.Text = "0,5s"
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "1,0s" Then
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "1,5s" Then
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 1

        ElseIf lblDelay.Text = "2,0s" Then
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "2,5s" Then
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "3,0s" Then
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "3,5s" Then
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "4,0s" Then
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "4,5s" Then
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "5,0s" Then
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "5,5s" Then
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "6,0s" Then
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "6,5s" Then
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "7,0s" Then
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "7,5s" Then
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "8,0s" Then
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "8,5s" Then
            DCR(7) = 1
            DCR(8) = 0
            DCR(9) = 1
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "9,0s" Then
            DCR(7) = 0
            DCR(8) = 1
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1

        ElseIf lblDelay.Text = "9,5s" Then
            DCR(7) = 1
            DCR(8) = 1
            DCR(9) = 1
            DCR(10) = 1
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 1
        End If

    End Sub

    Private Sub RadioButton_F_SWITCH_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_F_SWITCH.CheckedChanged

    End Sub

    Private Sub ConnectionSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSToolStripMenuItem.Click
        GroupBox7.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False

        cmbPorts.Items.Clear()

        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()
        Dim port As String
        'Dim PortName As String

        For Each port In ports
            cmbPorts.Items.Add(port)
            'MsgBox(port, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Serial port detecetd")
        Next port

        'MessageBox.Show("PORTLAR" + port)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PortName = cmbPorts.SelectedItem
        If PortName <> "" Then

            If SerialPort1.IsOpen = True Then
                MsgBox("Serial Port that you want to connect is using by another program")
                lblStatus.Text = "Com Port: " & PortName & " connected."
                Exit Sub
            End If

            SerialPort1.PortName = PortName
            SerialPort1.BaudRate = 9600 'The speed data used
            SerialPort1.DataBits = 8 'Width of the data used
            SerialPort1.StopBits = 1 'number of stop bits used
            'SerialPort1.Encoding = System.Text.Encoding.GetEncoding(28591)
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.WriteTimeout = 1000
            SerialPort1.ReadTimeout = 1000

            If SerialPort1.IsOpen = False Then

                Try
                    SerialPort1.Open()
                Catch ex As Exception
                    MsgBox("Serial Port that you want to connect is using by another program")
                End Try

            End If
            lblStatus.Text = "Com Port: " & PortName & " connected."

        End If
    End Sub

    Private Sub cmbPrograms_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPrograms.SelectedValueChanged
        ClearForm()
        ParseText(cmbPrograms.Text)
    End Sub

    Private Sub cmbPrograms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrograms.SelectedIndexChanged

    End Sub

    Private Sub cmbPrograms_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmbPrograms.DrawItem
        Dim myFont As System.Drawing.Font = cmbPrograms.Font
        Dim TextColor As New System.Drawing.Color
        If e.Index = 0 Then
            TextColor = System.Drawing.Color.Red
        Else
            TextColor = System.Drawing.Color.Black
        End If

        cmbPrograms.ForeColor = System.Drawing.Color.Red

        Dim myBrush As SolidBrush = New SolidBrush(TextColor)
        ' Draw the background of the item.
        e.DrawBackground()

        e.Graphics.DrawString(cmbPrograms.Items(0), myFont, myBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))

        ' Draw the focus rectangle if the mouse hovers over an item.
        'e.DrawFocusRectangle()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        Dim txtBuff As String
        Dim txtBuffChrArr As Char()

        txtBuff = "00110010111111111111111110011001"

        txtBuff = txtBuff.PadLeft(32, "0")

        txtBuffChrArr = txtBuff.ToCharArray()

        Dim vsNum As String = txtBuff.Substring(0, 4)

        Dim rvsNum As String = txtBuff.Substring(4, 4)

        Dim cell1Int As String = txtBuff.Substring(16, 8)

        Dim cell2Int As String = txtBuff.Substring(24, 8)

        lblVs.Text = "V" + ((10 + ConvertBinToStr(vsNum, 0, 0)).ToString) + "-R" + ConvertBinToStr(rvsNum, 0, 0).ToString

        If txtBuffChrArr(9) = "0" Then
            RadioButton_Cell1_RX.Checked = False
        ElseIf txtBuffChrArr(9) = "1" Then
            RadioButton_Cell1_RX.Checked = True
        End If
        If txtBuffChrArr(10) = "0" Then
            RadioButton_Cell1_TX.Checked = False
        ElseIf txtBuffChrArr(10) = "1" Then
            RadioButton_Cell1_TX.Checked = True
        End If

        If txtBuffChrArr(11) = "0" Then
            RadioButton_Cell2_RX.Checked = False
        ElseIf txtBuffChrArr(11) = "1" Then
            RadioButton_Cell2_RX.Checked = True
        End If
        If txtBuffChrArr(12) = "0" Then
            RadioButton_Cell2_TX.Checked = False
        ElseIf txtBuffChrArr(12) = "1" Then
            RadioButton_Cell2_TX.Checked = True
        End If

        If txtBuffChrArr(13) = "0" Then
            RadioButton_Inputs_P1.Checked = False
        ElseIf txtBuffChrArr(13) = "1" Then
            RadioButton_Inputs_P1.Checked = True
        End If
        If txtBuffChrArr(14) = "0" Then
            RadioButton_Inputs_P2.Checked = False
        ElseIf txtBuffChrArr(14) = "1" Then
            RadioButton_Inputs_P2.Checked = True
        End If

        If txtBuffChrArr(15) = "0" Then
            RadioButton_Inputs_ALM.Checked = False
        ElseIf txtBuffChrArr(15) = "1" Then
            RadioButton_Inputs_ALM.Checked = True
        End If

        lblCell1Intensity.Text = ConvertBinToStr(cell1Int, 1, 1)
        lblCell2Intensity.Text = ConvertBinToStr(cell2Int, 1, 1)

        'ConvertStrToBin(76, 32)

        'ConvertBinToStr("0000000000000000000000001001100", 32, 0)

    End Sub

    Private Sub WriteSth()

        Try

            If SerialPort1.IsOpen Then

                Dim d As String
                d = "Bit Status; " + M2CON(0).ToString + "-" +
                        " " + M2CON(1).ToString + "-" +
                        " " + M2CON(2).ToString +
                        " " + M2CON(3).ToString +
                        " " + M2CON(4).ToString + "-" +
                        " " + M2CON(5).ToString +
                        " " + M2CON(6).ToString +
                        " " + M2CON(7).ToString + "-" +
                        " " + M2CON(8).ToString +
                        " " + M2CON(9).ToString +
                        " " + M2CON(10).ToString + "-" +
                        " " + M2CON(11).ToString +
                        " " + M2CON(12).ToString +
                        " " + M2CON(13).ToString

                SerialPort1.WriteLine(d)

                Dim result As String
                result = SerialPort1.ReadExisting
                lblResult.Text = result

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Function ConvertStrToBin(num As Integer, len As Integer) As Char()
        Dim chrArr As Char()
        Dim strOfInt As String
        If num > 0 Then
            strOfInt = Convert.ToString(num, 2)
            If (strOfInt.Length > 0) Then

                If (strOfInt.Length < len) Then
                    'Dim fark As Integer
                    'fark = len - strOfInt.Length
                    strOfInt = strOfInt.PadLeft(len, "0")
                End If
                Console.WriteLine(strOfInt)
                chrArr = strOfInt.ToCharArray
                Console.WriteLine(chrArr)
            End If

        End If
        Return chrArr
    End Function

    Private Function ConvertBinToStr(strBin As String, min As Integer, max As Integer) As Integer
        Dim strOfInt As Integer
        If strBin.Length > 0 Then
            strOfInt = Convert.ToInt32(strBin, 2)
            If (strOfInt > 0) Then
                Console.WriteLine(strOfInt)
            End If
        End If
        Return strOfInt
    End Function

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
