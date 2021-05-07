
Imports System.IO
Imports System.Management
Imports System.Threading

Module Module1

    Public M2CON(15) As Byte
    Public L1CON(15) As Byte
    Public L2CON(15) As Byte
    Public DCR(15) As Byte
    Public TEST(7) As Byte
    'Public TCON(15) As Byte
    Public TCON As String
    Public ATO(7) As Byte
    Public DENE(15) As Byte

    Public i As Integer = 12

    Public strArr() As Char
    Public dosya As String
    Public ports As String() = IO.Ports.SerialPort.GetPortNames()
    Public port As String
    Public PortName As String

    Public msjFlag As Integer = 0

    Public cycleFlag As Boolean = False

    Public Structure Input

        Dim name As String
        Dim bitText As String
        Dim address As String
        Dim amount As String
        Dim data1 As String
        Dim data2 As String
        Dim data3 As String
        Dim data4 As String
        Dim status As String

    End Structure

    'Public tryNumber As Integer = 0

End Module

Public Class Form1

    'Dim thReadAll As New Thread(New ThreadStart(AddressOf Me.ReadAll))
    'Dim thReadDev As New Thread(New ThreadStart(AddressOf Me.ReadDev))


    Private Sub btnMOTOR2onOFF_Click(sender As Object, e As EventArgs) Handles btnMOTOR2onOFF.Click
        If btnMOTOR2onOFF.Text = "ON" Then
            btnMOTOR2onOFF.Text = "OFF"
            btnMOTOR2onOFF.BackColor = Color.Salmon
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
            btnMOTOR2onOFF.BackColor = Color.LightGreen
            M2CON(0) = 1

            GetHistoric(1, 1)

        End If
    End Sub

    Private Sub btnLIGHT1onOFF_Click(sender As Object, e As EventArgs) Handles btnLIGHT1onOFF.Click
        If btnLIGHT1onOFF.Text = "ON" Then

            btnLIGHT1onOFF.Text = "OFF"
            btnLIGHT1onOFF.BackColor = Color.Salmon
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
            btnLIGHT1onOFF.BackColor = Color.LightGreen
            L1CON(0) = 1
            GetHistoric(2, 1)
        End If
    End Sub

    Private Sub btnLIGHT2onOFF_Click(sender As Object, e As EventArgs) Handles btnLIGHT2onOFF.Click
        If btnLIGHT2onOFF.Text = "ON" Then

            btnLIGHT2onOFF.Text = "OFF"
            btnLIGHT2onOFF.BackColor = Color.Salmon
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
            btnLIGHT2onOFF.BackColor = Color.LightGreen
            L2CON(0) = 1
            GetHistoric(3, 1)
        End If
    End Sub

    Private Sub btnMOTOR2pwrON_Click(sender As Object, e As EventArgs) Handles btnMOTOR2pwrON.Click
        If btnMOTOR2onOFF.Text <> "OFF" Then
            If btnMOTOR2pwrON.Text = "AUTO" Then
                btnMOTOR2pwrON.Text = "SYNC"
                btnMOTOR2pwrON.BackColor = Color.Orange
                M2CON(4) = 0
                M2CON(3) = 0
                M2CON(2) = 1
            ElseIf btnMOTOR2pwrON.Text = "SYNC" Then
                btnMOTOR2pwrON.Text = "PEDAL"
                btnMOTOR2pwrON.BackColor = Color.Orange
                M2CON(4) = 0
                M2CON(3) = 1
                M2CON(2) = 0
            ElseIf btnMOTOR2pwrON.Text = "PEDAL" Then
                btnMOTOR2pwrON.Text = "OFF"
                btnMOTOR2pwrON.BackColor = Color.Salmon
                M2CON(4) = 1
                M2CON(3) = 0
                M2CON(2) = 0
            ElseIf btnMOTOR2pwrON.Text = "RUN" Then
                btnMOTOR2pwrON.Text = "OFF"
                btnMOTOR2pwrON.BackColor = Color.Salmon
                M2CON(4) = 1
                M2CON(3) = 0
                M2CON(2) = 0
            ElseIf btnMOTOR2pwrON.Text = "OFF" Then
                btnMOTOR2pwrON.Text = ""
                btnMOTOR2pwrON.BackColor = Color.LightGray
                M2CON(4) = 1
                M2CON(3) = 0
                M2CON(2) = 1

                '-----

                btnMOTOR2_1Press.Text = ""
                btnMOTOR2_1Press.BackColor = Color.LightGray
                M2CON(7) = 1
                M2CON(6) = 0
                M2CON(5) = 1

                '----

                btnMOTOR2_2Press.Text = ""
                btnMOTOR2_2Press.BackColor = Color.LightGray
                M2CON(10) = 1
                M2CON(9) = 0
                M2CON(8) = 1

                '-----

                btnMOTOR2_3Press.Text = ""
                btnMOTOR2_3Press.BackColor = Color.LightGray

                M2CON(13) = 1
                M2CON(12) = 0
                M2CON(11) = 1

            ElseIf btnMOTOR2pwrON.Text = "" Then
                btnMOTOR2pwrON.Text = "AUTO"
                btnMOTOR2pwrON.BackColor = Color.Orange
                M2CON(4) = 0
                M2CON(3) = 0
                M2CON(2) = 0

                GetHistoric(1, 2)
            End If
        End If
    End Sub

    Private Sub btnMOTOR2_1Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_1Press.Click
        If btnMOTOR2pwrON.Text <> "" Then
            If btnMOTOR2_1Press.Text = "AUTO" Then
                btnMOTOR2_1Press.Text = "SYNC"
                btnMOTOR2_1Press.BackColor = Color.Orange
                M2CON(7) = 0
                M2CON(6) = 0
                M2CON(5) = 1
            ElseIf btnMOTOR2_1Press.Text = "SYNC" Then
                btnMOTOR2_1Press.Text = "PEDAL"
                btnMOTOR2_1Press.BackColor = Color.Orange
                M2CON(7) = 0
                M2CON(6) = 1
                M2CON(5) = 0
                'ElseIf btnMOTOR2_1Press.Text = "PEDAL" Then
                '   btnMOTOR2_1Press.Text = "RUN"
                '  btnMOTOR2_1Press.BackColor = Color.LightGreen
                ' M2CON(5) = 0
                'M2CON(6) = 1
                'M2CON(7) = 1
            ElseIf btnMOTOR2_1Press.Text = "PEDAL" Then
                btnMOTOR2_1Press.Text = "OFF"
                btnMOTOR2_1Press.BackColor = Color.Salmon
                M2CON(7) = 1
                M2CON(6) = 0
                M2CON(5) = 0
            ElseIf btnMOTOR2_1Press.Text = "RUN" Then
                btnMOTOR2_1Press.Text = "OFF"
                btnMOTOR2_1Press.BackColor = Color.Salmon
                M2CON(7) = 1
                M2CON(6) = 0
                M2CON(5) = 0
            ElseIf btnMOTOR2_1Press.Text = "OFF" Then
                btnMOTOR2_1Press.Text = ""
                btnMOTOR2_1Press.BackColor = Color.LightGray
                M2CON(7) = 1
                M2CON(6) = 0
                M2CON(5) = 1

                '----

                btnMOTOR2_2Press.Text = ""
                btnMOTOR2_2Press.BackColor = Color.LightGray
                M2CON(10) = 1
                M2CON(9) = 0
                M2CON(8) = 1

                '-----

                btnMOTOR2_3Press.Text = ""
                btnMOTOR2_3Press.BackColor = Color.LightGray

                M2CON(13) = 1
                M2CON(12) = 0
                M2CON(11) = 1
            ElseIf btnMOTOR2_1Press.Text = "" Then
                btnMOTOR2_1Press.Text = "AUTO"
                btnMOTOR2_1Press.BackColor = Color.Orange
                M2CON(7) = 0
                M2CON(6) = 0
                M2CON(5) = 0
                GetHistoric(1, 3)
            End If
        End If
    End Sub

    Private Sub btnMOTOR2_2Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_2Press.Click
        If btnMOTOR2_1Press.Text <> "" Then
            If btnMOTOR2_2Press.Text = "AUTO" Then
                btnMOTOR2_2Press.Text = "SYNC"
                btnMOTOR2_2Press.BackColor = Color.Orange
                M2CON(10) = 0
                M2CON(9) = 0
                M2CON(8) = 1
            ElseIf btnMOTOR2_2Press.Text = "SYNC" Then
                btnMOTOR2_2Press.Text = "PEDAL"
                btnMOTOR2_2Press.BackColor = Color.Orange
                M2CON(10) = 0
                M2CON(9) = 1
                M2CON(8) = 0
            ElseIf btnMOTOR2_2Press.Text = "PEDAL" Then
                btnMOTOR2_2Press.Text = "OFF"
                btnMOTOR2_2Press.BackColor = Color.Salmon
                M2CON(10) = 1
                M2CON(9) = 0
                M2CON(8) = 0
            ElseIf btnMOTOR2_2Press.Text = "RUN" Then
                btnMOTOR2_2Press.Text = "OFF"
                btnMOTOR2_2Press.BackColor = Color.Salmon
                M2CON(10) = 1
                M2CON(9) = 0
                M2CON(8) = 0
            ElseIf btnMOTOR2_2Press.Text = "OFF" Then
                btnMOTOR2_2Press.Text = ""
                btnMOTOR2_2Press.BackColor = Color.LightGray
                M2CON(10) = 1
                M2CON(9) = 0
                M2CON(8) = 1

                '-----

                btnMOTOR2_3Press.Text = ""
                btnMOTOR2_3Press.BackColor = Color.LightGray

                M2CON(13) = 1
                M2CON(12) = 0
                M2CON(11) = 1

            ElseIf btnMOTOR2_2Press.Text = "" Then
                btnMOTOR2_2Press.Text = "AUTO"
                btnMOTOR2_2Press.BackColor = Color.Orange
                M2CON(10) = 0
                M2CON(9) = 0
                M2CON(8) = 0
                GetHistoric(1, 4)
            End If
        End If
    End Sub

    Private Sub btnMOTOR2_3Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_3Press.Click
        If btnMOTOR2_2Press.Text <> "" Then
            If btnMOTOR2_3Press.Text = "AUTO" Then
                btnMOTOR2_3Press.Text = "SYNC"
                btnMOTOR2_3Press.BackColor = Color.Orange
                M2CON(13) = 0
                M2CON(12) = 0
                M2CON(11) = 1
            ElseIf btnMOTOR2_3Press.Text = "SYNC" Then
                btnMOTOR2_3Press.Text = "PEDAL"
                btnMOTOR2_3Press.BackColor = Color.Orange
                M2CON(13) = 0
                M2CON(12) = 1
                M2CON(11) = 0
            ElseIf btnMOTOR2_3Press.Text = "PEDAL" Then
                btnMOTOR2_3Press.Text = "OFF"
                btnMOTOR2_3Press.BackColor = Color.Salmon
                M2CON(13) = 1
                M2CON(12) = 0
                M2CON(11) = 0
            ElseIf btnMOTOR2_3Press.Text = "RUN" Then
                btnMOTOR2_3Press.Text = "OFF"
                btnMOTOR2_3Press.BackColor = Color.Salmon
                M2CON(13) = 1
                M2CON(12) = 0
                M2CON(11) = 0
            ElseIf btnMOTOR2_3Press.Text = "OFF" Then
                btnMOTOR2_3Press.Text = ""
                btnMOTOR2_3Press.BackColor = Color.LightGray
                M2CON(13) = 1
                M2CON(12) = 0
                M2CON(11) = 1
            ElseIf btnMOTOR2_3Press.Text = "" Then
                btnMOTOR2_3Press.Text = "AUTO"
                btnMOTOR2_3Press.BackColor = Color.Orange
                M2CON(13) = 0
                M2CON(12) = 0
                M2CON(11) = 0
            End If
        End If
    End Sub

    Private Sub btnLIGHT1powerON_Click(sender As Object, e As EventArgs) Handles btnLIGHT1powerON.Click
        If btnLIGHT1onOFF.Text <> "OFF" Then
            If btnLIGHT1powerON.Text = "" Then
                btnLIGHT1powerON.Text = "OFF"
                btnLIGHT1powerON.BackColor = Color.Salmon
                L1CON(4) = 0
                L1CON(3) = 0
                L1CON(2) = 0
                GetHistoric(2, 2)
            ElseIf btnLIGHT1powerON.Text = "OFF" Then
                btnLIGHT1powerON.Text = "ON"
                btnLIGHT1powerON.BackColor = Color.LightGreen
                L1CON(4) = 0
                L1CON(3) = 0
                L1CON(2) = 1
            ElseIf btnLIGHT1powerON.Text = "ON" Then
                btnLIGHT1powerON.Text = "FLASH"
                btnLIGHT1powerON.BackColor = Color.Orange
                L1CON(4) = 0
                L1CON(3) = 1
                L1CON(2) = 0
            ElseIf btnLIGHT1powerON.Text = "FLASH" Then
                btnLIGHT1powerON.Text = ""
                btnLIGHT1powerON.BackColor = Color.LightGray
                L1CON(4) = 1
                L1CON(3) = 0
                L1CON(2) = 1

                '------

                btnLIGHT1_1Press.Text = ""
                btnLIGHT1_1Press.BackColor = Color.LightGray
                L1CON(7) = 0
                L1CON(6) = 1
                L1CON(5) = 1

                '----

                btnLIGHT1_2Press.Text = ""
                btnLIGHT1_2Press.BackColor = Color.LightGray
                L1CON(10) = 0
                L1CON(9) = 1
                L1CON(8) = 1

                '--

                btnLIGHT1_3Press.Text = ""
                btnLIGHT1_3Press.BackColor = Color.LightGray
                L1CON(13) = 0
                L1CON(12) = 1
                L1CON(11) = 1
            End If
        End If
    End Sub

    Private Sub btnLIGHT1_1Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_1Press.Click
        If btnLIGHT1powerON.Text <> "" Then
            If btnLIGHT1_1Press.Text = "" Then
                btnLIGHT1_1Press.Text = "OFF"
                btnLIGHT1_1Press.BackColor = Color.Salmon
                L1CON(7) = 0
                L1CON(6) = 0
                L1CON(5) = 0
                GetHistoric(2, 3)
            ElseIf btnLIGHT1_1Press.Text = "OFF" Then
                btnLIGHT1_1Press.Text = "ON"
                btnLIGHT1_1Press.BackColor = Color.LightGreen
                L1CON(7) = 0
                L1CON(6) = 0
                L1CON(5) = 1
            ElseIf btnLIGHT1_1Press.Text = "ON" Then
                btnLIGHT1_1Press.Text = "FLASH"
                btnLIGHT1_1Press.BackColor = Color.Orange
                L1CON(7) = 0
                L1CON(6) = 1
                L1CON(5) = 0
            ElseIf btnLIGHT1_1Press.Text = "FLASH" Then 'NA
                btnLIGHT1_1Press.Text = ""
                btnLIGHT1_1Press.BackColor = Color.LightGray
                L1CON(7) = 0
                L1CON(6) = 1
                L1CON(5) = 1

                '----

                btnLIGHT1_2Press.Text = ""
                btnLIGHT1_2Press.BackColor = Color.LightGray
                L1CON(10) = 0
                L1CON(9) = 1
                L1CON(8) = 1

                '--

                btnLIGHT1_3Press.Text = ""
                btnLIGHT1_3Press.BackColor = Color.LightGray
                L1CON(13) = 0
                L1CON(12) = 1
                L1CON(11) = 1
            End If
        End If
    End Sub

    Private Sub btnLIGHT2powerON_Click(sender As Object, e As EventArgs) Handles btnLIGHT2powerON.Click
        If btnLIGHT2onOFF.Text <> "OFF" Then

            If btnLIGHT2powerON.Text = "OFF" Then
                btnLIGHT2powerON.Text = "ON"
                btnLIGHT2powerON.BackColor = Color.LightGreen
                L2CON(4) = 0
                L2CON(3) = 0
                L2CON(2) = 1

            ElseIf btnLIGHT2powerON.Text = "ON" Then
                btnLIGHT2powerON.Text = "FLASH"
                btnLIGHT2powerON.BackColor = Color.Orange
                L2CON(4) = 0
                L2CON(3) = 1
                L2CON(2) = 0

            ElseIf btnLIGHT2powerON.Text = "FLASH" Then
                btnLIGHT2powerON.Text = ""
                btnLIGHT2powerON.BackColor = Color.LightGray
                L2CON(4) = 0
                L2CON(3) = 1
                L2CON(2) = 1

                '----
                btnLIGHT2_1Press.Text = ""
                btnLIGHT2_1Press.BackColor = Color.LightGray
                L2CON(7) = 0
                L2CON(6) = 1
                L2CON(5) = 1

                '----
                btnLIGHT2_2Press.Text = ""
                btnLIGHT2_2Press.BackColor = Color.LightGray
                L2CON(10) = 0
                L2CON(9) = 1
                L2CON(8) = 1

                '-----

                btnLIGHT2_3Press.Text = ""
                btnLIGHT2_3Press.BackColor = Color.LightGray
                L2CON(13) = 0
                L2CON(12) = 1
                L2CON(11) = 1
            ElseIf btnLIGHT2powerON.Text = "" Then
                btnLIGHT2powerON.Text = "OFF"
                btnLIGHT2powerON.BackColor = Color.Salmon
                L2CON(4) = 0
                L2CON(3) = 0
                L2CON(2) = 0
                GetHistoric(3, 2)
            End If
        End If
    End Sub

    Private Sub btnLIGHT2_1Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_1Press.Click
        If btnLIGHT2powerON.Text <> "" Then
            If btnLIGHT2_1Press.Text = "OFF" Then
                btnLIGHT2_1Press.Text = "ON"
                btnLIGHT2_1Press.BackColor = Color.LightGreen
                L2CON(7) = 0
                L2CON(6) = 0
                L2CON(5) = 1
            ElseIf btnLIGHT2_1Press.Text = "ON" Then
                btnLIGHT2_1Press.Text = "FLASH"
                btnLIGHT2_1Press.BackColor = Color.Orange
                L2CON(7) = 0
                L2CON(6) = 1
                L2CON(5) = 0
            ElseIf btnLIGHT2_1Press.Text = "FLASH" Then
                btnLIGHT2_1Press.Text = ""
                btnLIGHT2_1Press.BackColor = Color.LightGray
                L2CON(7) = 0
                L2CON(6) = 1
                L2CON(5) = 1

                '----
                btnLIGHT2_2Press.Text = ""
                btnLIGHT2_2Press.BackColor = Color.LightGray
                L2CON(10) = 0
                L2CON(9) = 1
                L2CON(8) = 1

                '-----

                btnLIGHT2_3Press.Text = ""
                btnLIGHT2_3Press.BackColor = Color.LightGray
                L2CON(13) = 0
                L2CON(12) = 1
                L2CON(11) = 1
            ElseIf btnLIGHT2_1Press.Text = "" Then
                btnLIGHT2_1Press.Text = "OFF"
                btnLIGHT2_1Press.BackColor = Color.Salmon
                L2CON(7) = 0
                L2CON(6) = 0
                L2CON(5) = 0
                GetHistoric(3, 3)
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

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
            DCR(4) = 1
            DCR(5) = 0
            DCR(6) = 1

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2" Then
            btnAlarm_Buzzer_Light.Text = "OFF"
            btnAlarm_Buzzer_Light.BackColor = Color.Salmon
            DCR(4) = 0
            DCR(5) = 0
            DCR(6) = 0

        ElseIf btnAlarm_Buzzer_Light.Text = "OFF" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
            DCR(4) = 1
            DCR(5) = 0
            DCR(6) = 0

        End If
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        CheckForIllegalCrossThreadCalls = False

        Dim toolTip1 As New ToolTip()
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        toolTip1.ShowAlways = True

        toolTip1.SetToolTip(Me.btnMOTOR2onOFF, "Turn On or Off")
        toolTip1.SetToolTip(Me.btnLIGHT1onOFF, "Turn On or Off")
        toolTip1.SetToolTip(Me.btnLIGHT2onOFF, "Turn On or Off")

        toolTip1.SetToolTip(Me.Label1, "Select predefined program")
        toolTip1.SetToolTip(Me.Label3, "Set Motor 2 parameters")
        toolTip1.SetToolTip(Me.Label4, "Set Light 1 parameters")
        toolTip1.SetToolTip(Me.Label5, "Set Light 2 parameters")
        toolTip1.SetToolTip(Me.GroupBox9, "Select the 'Pedal 2' connector function (Pedal or Flap Switch)")
        toolTip1.SetToolTip(Me.GroupBox6, "Check if related inputs are working")
        toolTip1.SetToolTip(Me.Label8, "Set the action of alarm")
        toolTip1.SetToolTip(Me.Label6, "Select the photocell quantity on the board")
        toolTip1.SetToolTip(Me.Label7, "Set the time delay for the front belt restart")
        toolTip1.SetToolTip(Me.Label29, "If device restart is required after the front pedal is depressed, turn it on")
        toolTip1.SetToolTip(Me.Label2, "Set the maximum idle running time of the front belt")
        toolTip1.SetToolTip(Me.Label24, "Set the first running time of rear belt in 'Auto' mode")
        toolTip1.SetToolTip(Me.Label15, "Set the first running time of rear belt in 'Auto' mode")
        toolTip1.SetToolTip(Me.Label27, "Set the off cycle time of rear belt in 'Auto' mode")
        toolTip1.SetToolTip(Me.Label26, "Set the off cycle time of rear belt in 'Auto' mode")
        toolTip1.SetToolTip(Me.Label25, "Set the on cycle time of rear belt in 'Auto' mode")
        toolTip1.SetToolTip(Me.Label28, "Set the on cycle time of rear belt in 'Auto' mode")
        toolTip1.SetToolTip(Me.btnMOTOR1, "Test the front belt")
        toolTip1.SetToolTip(Me.btnMOTOR2, "Test the rear belt")
        toolTip1.SetToolTip(Me.btnLIGHT1, "Test the Light 1")
        toolTip1.SetToolTip(Me.btnLIGHT2, "Test the Light 2")
        toolTip1.SetToolTip(Me.btnAlarm, "Test the Alarm")
        toolTip1.SetToolTip(Me.Label11, "Set the 'Power On' parameter of corresponding key")
        toolTip1.SetToolTip(Me.Label12, "Set the first press parameter of corresponding key")
        toolTip1.SetToolTip(Me.Label13, "Set the second press parameter of corresponding key")
        toolTip1.SetToolTip(Me.Label14, "Set the third press parameter of corresponding key")


        'ilk açılışta ILURA programı ile açılıyor
        'cmbPrograms.ForeColor = System.Drawing.Color.Salmon
        Dim obj As Object = "NEW"
        cmbPrograms.Items.Add(obj)

        cmbPrograms.SelectedItem = "NEW"

        GetListOfSettings()

        ClearForm()

        gbMaintenance.Visible = False

        For Each port In ports
            cmbPorts.Items.Add(port)
            'MsgBox(port, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Serial port detecetd")
        Next port

        GetLastStateBeforeSave()
    End Sub

    Private Sub SetForm()
        btnMOTOR2onOFF.Text = "ON"
        btnMOTOR2onOFF.BackColor = Color.LightGreen
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
        btnMOTOR2onOFF.BackColor = Color.Salmon
        btnMOTOR2pwrON.Text = ""
        btnMOTOR2_1Press.Text = ""
        btnMOTOR2_2Press.Text = ""
        btnMOTOR2_3Press.Text = ""

        btnLIGHT1onOFF.Text = "OFF"
        btnLIGHT1onOFF.BackColor = Color.Salmon
        btnLIGHT1powerON.Text = ""
        btnLIGHT1_1Press.Text = ""
        btnLIGHT1_2Press.Text = ""
        btnLIGHT1_3Press.Text = ""

        btnLIGHT2onOFF.Text = "OFF"
        btnLIGHT2onOFF.BackColor = Color.Salmon
        btnLIGHT2powerON.Text = ""
        btnLIGHT2_1Press.Text = ""
        btnLIGHT2_2Press.Text = ""
        btnLIGHT2_3Press.Text = ""

        btnNumberOfCells.Text = "1"
        btnNumberOfCells.BackColor = Color.LightBlue

        btnAlarm_Buzzer_Light.Text = "BUZZER"
        btnAlarm_Buzzer_Light.BackColor = Color.LightBlue

        lblDelay.Text = "0,2s"

        CmbTurnOff.SelectedIndex = CmbTurnOff.FindStringExact("5")
        cmbTFirst.SelectedIndex = cmbTFirst.FindStringExact("5")
        CmbTon.SelectedIndex = CmbTon.FindStringExact("5")
        cmbToff.SelectedIndex = cmbToff.FindStringExact("5")


        RadioButton_F_SWITCH.Checked = False

        RadioButton_R_PEDAL.Checked = True

        btnRFP.Text = "OFF"
        btnRFP.BackColor = Color.Salmon
        'TODO

        '------

        btnMOTOR2pwrON.BackColor = Color.LightGray
        btnMOTOR2_1Press.BackColor = Color.LightGray
        btnMOTOR2_2Press.BackColor = Color.LightGray
        btnMOTOR2_3Press.BackColor = Color.LightGray

        btnLIGHT1onOFF.BackColor = Color.Salmon
        btnLIGHT1powerON.BackColor = Color.LightGray
        btnLIGHT1_1Press.BackColor = Color.LightGray
        btnLIGHT1_2Press.BackColor = Color.LightGray
        btnLIGHT1_3Press.BackColor = Color.LightGray

        btnLIGHT2onOFF.BackColor = Color.Salmon
        btnLIGHT2powerON.BackColor = Color.LightGray
        btnLIGHT2_1Press.BackColor = Color.LightGray
        btnLIGHT2_2Press.BackColor = Color.LightGray
        btnLIGHT2_3Press.BackColor = Color.LightGray

        'M2CON = ILURA_M2CON
        'L1CON = ILURA_L1CON
        'L2CON = ILURA_L1CON
        'DCR = ILURA_M2CON

        'CmbTurnOff.SelectedItem = "0"

    End Sub


    Private Sub btnLIGHT1_2Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_2Press.Click
        If btnLIGHT1_1Press.Text <> "" Then
            If btnLIGHT1_2Press.Text = "OFF" Then
                btnLIGHT1_2Press.Text = "ON"
                btnLIGHT1_2Press.BackColor = Color.LightGreen
                L1CON(10) = 0
                L1CON(9) = 0
                L1CON(8) = 1
            ElseIf btnLIGHT1_2Press.Text = "ON" Then
                btnLIGHT1_2Press.Text = "FLASH"
                btnLIGHT1_2Press.BackColor = Color.Orange
                L1CON(10) = 0
                L1CON(9) = 1
                L1CON(8) = 0
            ElseIf btnLIGHT1_2Press.Text = "FLASH" Then
                btnLIGHT1_2Press.Text = ""
                btnLIGHT1_2Press.BackColor = Color.LightGray
                L1CON(10) = 0
                L1CON(9) = 1
                L1CON(8) = 1

                '--

                btnLIGHT1_3Press.Text = ""
                btnLIGHT1_3Press.BackColor = Color.LightGray
                L1CON(13) = 0
                L1CON(12) = 1
                L1CON(11) = 1


            ElseIf btnLIGHT1_2Press.Text = "" Then
                btnLIGHT1_2Press.Text = "OFF"
                btnLIGHT1_2Press.BackColor = Color.Salmon
                L1CON(10) = 0
                L1CON(9) = 0
                L1CON(8) = 0
                GetHistoric(2, 4)
            End If
        End If
    End Sub

    Private Sub btnLIGHT1_3Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_3Press.Click
        If btnLIGHT1_2Press.Text <> "" Then
            If btnLIGHT1_3Press.Text = "OFF" Then
                btnLIGHT1_3Press.Text = "ON"
                btnLIGHT1_3Press.BackColor = Color.LightGreen
                L1CON(13) = 0
                L1CON(12) = 0
                L1CON(11) = 1
            ElseIf btnLIGHT1_3Press.Text = "ON" Then
                btnLIGHT1_3Press.Text = "FLASH"
                btnLIGHT1_3Press.BackColor = Color.Orange
                L1CON(13) = 0
                L1CON(12) = 1
                L1CON(11) = 0
            ElseIf btnLIGHT1_3Press.Text = "FLASH" Then
                btnLIGHT1_3Press.Text = ""
                btnLIGHT1_3Press.BackColor = Color.LightGray
                L1CON(13) = 0
                L1CON(12) = 1
                L1CON(11) = 1
            ElseIf btnLIGHT1_3Press.Text = "" Then
                btnLIGHT1_3Press.Text = "OFF"
                btnLIGHT1_3Press.BackColor = Color.Salmon
                L1CON(13) = 0
                L1CON(12) = 0
                L1CON(11) = 0
            End If
        End If
    End Sub

    Private Sub btnLIGHT2_2Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_2Press.Click
        If btnLIGHT2_1Press.Text <> "" Then
            If btnLIGHT2_2Press.Text = "OFF" Then
                btnLIGHT2_2Press.Text = "ON"
                btnLIGHT2_2Press.BackColor = Color.LightGreen
                L2CON(10) = 0
                L2CON(9) = 0
                L2CON(8) = 1
            ElseIf btnLIGHT2_2Press.Text = "ON" Then
                btnLIGHT2_2Press.Text = "FLASH"
                btnLIGHT2_2Press.BackColor = Color.Orange
                L2CON(10) = 0
                L2CON(9) = 1
                L2CON(8) = 0
            ElseIf btnLIGHT2_2Press.Text = "FLASH" Then
                btnLIGHT2_2Press.Text = ""
                btnLIGHT2_2Press.BackColor = Color.LightGray
                L2CON(10) = 0
                L2CON(9) = 1
                L2CON(8) = 1

                '-----

                btnLIGHT2_3Press.Text = ""
                btnLIGHT2_3Press.BackColor = Color.LightGray
                L2CON(13) = 0
                L2CON(12) = 1
                L2CON(11) = 1


            ElseIf btnLIGHT2_2Press.Text = "" Then
                btnLIGHT2_2Press.Text = "OFF"
                btnLIGHT2_2Press.BackColor = Color.Salmon
                L2CON(10) = 0
                L2CON(9) = 0
                L2CON(8) = 0
                GetHistoric(3, 4)
            End If
        End If
    End Sub

    Private Sub btnLIGHT2_3Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_3Press.Click
        If btnLIGHT2_2Press.Text <> "" Then
            If btnLIGHT2_3Press.Text = "OFF" Then
                btnLIGHT2_3Press.Text = "ON"
                btnLIGHT2_3Press.BackColor = Color.LightGreen
                L2CON(13) = 0
                L2CON(12) = 0
                L2CON(11) = 1
            ElseIf btnLIGHT2_3Press.Text = "ON" Then
                btnLIGHT2_3Press.Text = "FLASH"
                btnLIGHT2_3Press.BackColor = Color.Orange
                L2CON(13) = 0
                L2CON(12) = 1
                L2CON(11) = 0
            ElseIf btnLIGHT2_3Press.Text = "FLASH" Then
                btnLIGHT2_3Press.Text = ""
                btnLIGHT2_3Press.BackColor = Color.LightGray
                L2CON(13) = 0
                L2CON(12) = 1
                L2CON(11) = 1
            ElseIf btnLIGHT2_3Press.Text = "" Then
                btnLIGHT2_3Press.Text = "OFF"
                btnLIGHT2_3Press.BackColor = Color.Salmon
                L2CON(13) = 0
                L2CON(12) = 0
                L2CON(11) = 0
            End If
        End If
    End Sub

    Private Sub btnM2CON_Click(sender As Object, e As EventArgs)
        GetLastStateBeforeSave()
        MsgBox("Bit Status; " +
                          M2CON(15).ToString +
                    " " + M2CON(14).ToString +
                    " " + M2CON(13).ToString +
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

    Private Sub btnL1CON_Click(sender As Object, e As EventArgs)

        GetLastStateBeforeSave()
        MsgBox("L1CON Bit Status; " +
                          L1CON(15).ToString +
                    " " + L1CON(14).ToString +
                    " " + L1CON(13).ToString +
                    " " + L1CON(12).ToString +
                    " " + L1CON(11).ToString +
                    " " + L1CON(10).ToString +
                    " " + L1CON(9).ToString +
                    " " + L1CON(8).ToString +
                    " " + L1CON(7).ToString +
                    " " + L1CON(6).ToString +
                    " " + L1CON(5).ToString +
                    " " + L1CON(4).ToString +
                    " " + L1CON(3).ToString +
                    " " + L1CON(2).ToString +
                    " " + L1CON(1).ToString +
                    " " + L1CON(0).ToString)
    End Sub

    Private Sub btnL2CON_Click(sender As Object, e As EventArgs)
        GetLastStateBeforeSave()
        MsgBox("L2CON Bit Status; " +
                          L2CON(15).ToString() +
                    " " + L2CON(14).ToString +
                    " " + L2CON(13).ToString +
                    " " + L2CON(12).ToString +
                    " " + L2CON(11).ToString +
                    " " + L2CON(10).ToString +
                    " " + L2CON(9).ToString +
                    " " + L2CON(8).ToString +
                    " " + L2CON(7).ToString +
                    " " + L2CON(6).ToString +
                    " " + L2CON(5).ToString +
                    " " + L2CON(4).ToString +
                    " " + L2CON(3).ToString +
                    " " + L2CON(2).ToString +
                    " " + L2CON(1).ToString +
                    " " + L2CON(0).ToString)
    End Sub

    Private Sub btnDCR_Click(sender As Object, e As EventArgs)
        GetLastStateBeforeSave()
        MsgBox("DCR Bit Status; " +
                          DCR(15).ToString() +
                    " " + DCR(14).ToString +
                    " " + DCR(13).ToString +
                    " " + DCR(12).ToString +
                    " " + DCR(11).ToString +
                    " " + DCR(10).ToString +
                    " " + DCR(9).ToString +
                    " " + DCR(8).ToString +
                    " " + DCR(7).ToString +
                    " " + DCR(6).ToString +
                    " " + DCR(5).ToString +
                    " " + DCR(4).ToString +
                    " " + DCR(3).ToString +
                    " " + DCR(2).ToString +
                    " " + DCR(1).ToString +
                    " " + DCR(0).ToString)
    End Sub

    Private Sub RadioButton_R_PEDAL_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_R_PEDAL.CheckedChanged
        If RadioButton_R_PEDAL.Checked Then
            RadioButton_F_SWITCH.Checked = False
            DCR(2) = 1
            DCR(3) = 0
        Else
            RadioButton_F_SWITCH.Checked = True
            DCR(2) = 0
            DCR(3) = 1
        End If
    End Sub

    Private Sub btnDelayPlus_Click(sender As Object, e As EventArgs) Handles btnDelayPlus.Click
        If lblDelay.Text = "0,2s" Then
            lblDelay.Text = "0,4s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "0,4s" Then
            lblDelay.Text = "0,6s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "0,6s" Then
            lblDelay.Text = "0,8s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "0,8s" Then
            lblDelay.Text = "1s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0
        End If

    End Sub

    Private Sub btnDelayMinus_Click(sender As Object, e As EventArgs) Handles btnDelayMinus.Click
        If lblDelay.Text = "1s" Then
            lblDelay.Text = "0,8s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 1
            DCR(11) = 0
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "0,8s" Then
            lblDelay.Text = "0,6s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 1
            DCR(13) = 0

        ElseIf lblDelay.Text = "0,6s" Then
            lblDelay.Text = "0,4s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 1
            DCR(12) = 0
            DCR(13) = 0

        ElseIf lblDelay.Text = "0,4s" Then
            lblDelay.Text = "0,2s"
            DCR(7) = 0
            DCR(8) = 0
            DCR(9) = 0
            DCR(10) = 0
            DCR(11) = 0
            DCR(12) = 1
            DCR(13) = 0

        End If
    End Sub

    Public Function LoadSpecFile(finame As String) As String

        Dim text As String
        text = ""
        Dim FILE_NAME As String = Application.StartupPath & "\SETTINGS\" + finame + ".txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            text = objReader.ReadToEnd()
            'MessageBox.Show(text)
            objReader.Close()
            'MessageBox.Show("Text written to file")
        Else
            MessageBox.Show("File Does Not Exist")
        End If
        Return text

    End Function

    Private Function ParseText(filename As String)
        If (filename = "NEW") Then
            Exit Function
        End If

        Dim testString As String = LoadSpecFile(filename)
        If (testString = Nothing) Then
            Exit Function
        End If

        Dim testArray() As String = Split(testString)

        Dim M2CON() As Byte = ConvertBitStringToByteArray(testArray(1))

        If M2CON(0) = "0" Then
            btnMOTOR2onOFF.Text = "OFF"
            btnMOTOR2onOFF.BackColor = Color.Salmon
        ElseIf M2CON(0) = "1" Then
            btnMOTOR2onOFF.Text = "ON"
            btnMOTOR2onOFF.BackColor = Color.LightGreen
        End If

        'MOTOR2 Power On
        If M2CON(4) = "0" And M2CON(3) = "0" AndAlso M2CON(2) = "0" Then
            btnMOTOR2pwrON.Text = "AUTO"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf M2CON(4) = "0" And M2CON(3) = "0" AndAlso M2CON(2) = "1" Then
            btnMOTOR2pwrON.Text = "SYNC"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf M2CON(4) = "0" And M2CON(3) = "1" AndAlso M2CON(2) = "0" Then
            btnMOTOR2pwrON.Text = "PEDAL"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf M2CON(4) = "0" And M2CON(3) = "1" AndAlso M2CON(2) = "1" Then
            btnMOTOR2pwrON.Text = "RUN"
            btnMOTOR2pwrON.BackColor = Color.LightGreen
        ElseIf M2CON(4) = "1" And M2CON(3) = "0" AndAlso M2CON(2) = "0" Then
            btnMOTOR2pwrON.Text = "OFF"
            btnMOTOR2pwrON.BackColor = Color.Salmon
        ElseIf M2CON(4) = "1" And M2CON(3) = "0" AndAlso M2CON(2) = "1" Then
            btnMOTOR2pwrON.Text = ""
            btnMOTOR2pwrON.BackColor = Color.LightGray

        End If
        'Motor2 1.Press
        If M2CON(7) = "0" And M2CON(6) = "0" AndAlso M2CON(5) = "0" Then
            btnMOTOR2_1Press.Text = "AUTO"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf M2CON(7) = "0" And M2CON(6) = "0" AndAlso M2CON(5) = "1" Then
            btnMOTOR2_1Press.Text = "SYNC"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf M2CON(7) = "0" And M2CON(6) = "1" AndAlso M2CON(5) = "0" Then
            btnMOTOR2_1Press.Text = "PEDAL"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf M2CON(7) = "0" And M2CON(6) = "1" AndAlso M2CON(5) = "1" Then
            btnMOTOR2_1Press.Text = "RUN"
            btnMOTOR2_1Press.BackColor = Color.LightGreen
        ElseIf M2CON(7) = "1" And M2CON(6) = "0" AndAlso M2CON(5) = "0" Then
            btnMOTOR2_1Press.Text = "OFF"
            btnMOTOR2_1Press.BackColor = Color.Salmon
        ElseIf M2CON(7) = "1" And M2CON(6) = "0" AndAlso M2CON(5) = "1" Then
            btnMOTOR2_1Press.Text = ""
            btnMOTOR2_1Press.BackColor = Color.LightGray
        End If

        'Motor2 2.Press
        If M2CON(10) = "0" And M2CON(9) = "0" AndAlso M2CON(8) = "0" Then
            btnMOTOR2_2Press.Text = "AUTO"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf M2CON(10) = "0" And M2CON(9) = "0" AndAlso M2CON(8) = "1" Then
            btnMOTOR2_2Press.Text = "SYNC"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf M2CON(10) = "0" And M2CON(9) = "1" AndAlso M2CON(8) = "0" Then
            btnMOTOR2_2Press.Text = "PEDAL"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf M2CON(10) = "0" And M2CON(9) = "1" AndAlso M2CON(8) = "1" Then
            btnMOTOR2_2Press.Text = "RUN"
            btnMOTOR2_2Press.BackColor = Color.LightGreen
        ElseIf M2CON(10) = "1" And M2CON(9) = "0" AndAlso M2CON(8) = "0" Then
            btnMOTOR2_2Press.Text = "OFF"
            btnMOTOR2_2Press.BackColor = Color.Salmon
        ElseIf M2CON(10) = "1" And M2CON(9) = "0" AndAlso M2CON(8) = "1" Then
            btnMOTOR2_2Press.Text = ""
            btnMOTOR2_2Press.BackColor = Color.LightGray
        End If

        'Motor2 3.Press
        If M2CON(13) = "0" And M2CON(12) = "0" AndAlso M2CON(11) = "0" Then
            btnMOTOR2_3Press.Text = "AUTO"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf M2CON(13) = "0" And M2CON(12) = "0" AndAlso M2CON(11) = "1" Then
            btnMOTOR2_3Press.Text = "SYNC"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf M2CON(13) = "0" And M2CON(12) = "1" AndAlso M2CON(11) = "0" Then
            btnMOTOR2_3Press.Text = "PEDAL"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf M2CON(13) = "0" And M2CON(12) = "1" AndAlso M2CON(11) = "1" Then
            btnMOTOR2_3Press.Text = "RUN"
            btnMOTOR2_3Press.BackColor = Color.LightGreen
        ElseIf M2CON(13) = "1" And M2CON(12) = "0" AndAlso M2CON(11) = "0" Then
            btnMOTOR2_3Press.Text = "OFF"
            btnMOTOR2_3Press.BackColor = Color.Salmon
        ElseIf M2CON(13) = "1" And M2CON(12) = "0" AndAlso M2CON(11) = "1" Then
            btnMOTOR2_3Press.Text = ""
            btnMOTOR2_3Press.BackColor = Color.LightGray
        End If

        Dim L1CON() As Byte = ConvertBitStringToByteArray(testArray(2)) 'testArray(2).ToCharArray

        If L1CON(0) = "0" Then
            btnLIGHT1onOFF.Text = "OFF"
            btnLIGHT1onOFF.BackColor = Color.Salmon
        ElseIf L1CON(0) = "1" Then
            btnLIGHT1onOFF.Text = "ON"
            btnLIGHT1onOFF.BackColor = Color.LightGreen
        End If
        'LIGHT1 Power On
        If L1CON(4) = "0" And L1CON(3) = "0" AndAlso L1CON(2) = "0" Then
            btnLIGHT1powerON.Text = "OFF"
            btnLIGHT1powerON.BackColor = Color.Salmon
        ElseIf L1CON(4) = "0" And L1CON(3) = "0" AndAlso L1CON(2) = "1" Then
            btnLIGHT1powerON.Text = "ON"
            btnLIGHT1powerON.BackColor = Color.LightGreen
        ElseIf L1CON(4) = "0" And L1CON(3) = "1" AndAlso L1CON(2) = "0" Then
            btnLIGHT1powerON.Text = "FLASH"
            btnLIGHT1powerON.BackColor = Color.Orange
        ElseIf L1CON(4) = "0" And L1CON(3) = "1" AndAlso L1CON(2) = "1" Then
            btnLIGHT1powerON.Text = ""
            btnLIGHT1powerON.BackColor = Color.LightGray
        End If
        'LIGHT1 1.Press
        If L1CON(7) = "0" And L1CON(6) = "0" AndAlso L1CON(5) = "0" Then
            btnLIGHT1_1Press.Text = "OFF"
            btnLIGHT1_1Press.BackColor = Color.Salmon
        ElseIf L1CON(7) = "0" And L1CON(6) = "0" AndAlso L1CON(5) = "1" Then
            btnLIGHT1_1Press.Text = "ON"
            btnLIGHT1_1Press.BackColor = Color.LightGreen
        ElseIf L1CON(7) = "0" And L1CON(6) = "1" AndAlso L1CON(5) = "0" Then
            btnLIGHT1_1Press.Text = "FLASH"
            btnLIGHT1_1Press.BackColor = Color.Orange
        ElseIf L1CON(7) = "0" And L1CON(6) = "1" AndAlso L1CON(5) = "1" Then
            btnLIGHT1_1Press.Text = ""
            btnLIGHT1_1Press.BackColor = Color.LightGray
        End If

        'LIGHT1 2.Press
        If L1CON(10) = "0" And L1CON(9) = "0" AndAlso L1CON(8) = "0" Then
            btnLIGHT1_2Press.Text = "OFF"
            btnLIGHT1_2Press.BackColor = Color.Salmon
        ElseIf L1CON(10) = "0" And L1CON(9) = "0" AndAlso L1CON(8) = "1" Then
            btnLIGHT1_2Press.Text = "ON"
            btnLIGHT1_2Press.BackColor = Color.LightGreen
        ElseIf L1CON(10) = "0" And L1CON(9) = "1" AndAlso L1CON(8) = "0" Then
            btnLIGHT1_2Press.Text = "FLASH"
            btnLIGHT1_2Press.BackColor = Color.Orange
        ElseIf L1CON(10) = "0" And L1CON(9) = "1" AndAlso L1CON(8) = "1" Then
            btnLIGHT1_2Press.Text = ""
            btnLIGHT1_2Press.BackColor = Color.LightGray
        End If

        'LIGHT1 3.Press
        If L1CON(13) = "0" And L1CON(12) = "0" AndAlso L1CON(11) = "0" Then
            btnLIGHT1_3Press.Text = "OFF"
            btnLIGHT1_3Press.BackColor = Color.Salmon
        ElseIf L1CON(13) = "0" And L1CON(12) = "0" AndAlso L1CON(11) = "1" Then
            btnLIGHT1_3Press.Text = "ON"
            btnLIGHT1_3Press.BackColor = Color.LightGreen
        ElseIf L1CON(13) = "0" And L1CON(12) = "1" AndAlso L1CON(11) = "0" Then
            btnLIGHT1_3Press.Text = "FLASH"
            btnLIGHT1_3Press.BackColor = Color.Orange
        ElseIf L1CON(13) = "0" And L1CON(12) = "1" AndAlso L1CON(11) = "1" Then
            btnLIGHT1_3Press.Text = ""
            btnLIGHT1_3Press.BackColor = Color.LightGray
        End If

        Dim L2CON() As Byte = ConvertBitStringToByteArray(testArray(3)) 'testArray(3).ToCharArray

        If L2CON(0) = "0" Then
            btnLIGHT2onOFF.Text = "OFF"
            btnLIGHT2onOFF.BackColor = Color.Salmon
        ElseIf L2CON(0) = "1" Then
            btnLIGHT2onOFF.Text = "ON"
            btnLIGHT2onOFF.BackColor = Color.LightGreen
        End If
        'LIGHT2 Power On
        If L2CON(4) = "0" And L2CON(3) = "0" AndAlso L2CON(2) = "0" Then
            btnLIGHT2powerON.Text = "OFF"
            btnLIGHT2powerON.BackColor = Color.Salmon
        ElseIf L2CON(4) = "0" And L2CON(3) = "0" AndAlso L2CON(2) = "1" Then
            btnLIGHT2powerON.Text = "ON"
            btnLIGHT2powerON.BackColor = Color.LightGreen
        ElseIf L2CON(4) = "0" And L2CON(3) = "1" AndAlso L2CON(2) = "0" Then
            btnLIGHT2powerON.Text = "FLASH"
            btnLIGHT2powerON.BackColor = Color.Orange
        ElseIf L2CON(4) = "0" And L2CON(3) = "1" AndAlso L2CON(2) = "1" Then
            btnLIGHT2powerON.Text = ""
            btnLIGHT2powerON.BackColor = Color.LightGray
        End If
        'LIGHT2 1.Press
        If L2CON(7) = "0" And L2CON(6) = "0" AndAlso L2CON(5) = "0" Then
            btnLIGHT2_1Press.Text = "OFF"
            btnLIGHT2_1Press.BackColor = Color.Salmon
        ElseIf L2CON(7) = "0" And L2CON(6) = "0" AndAlso L2CON(5) = "1" Then
            btnLIGHT2_1Press.Text = "ON"
            btnLIGHT2_1Press.BackColor = Color.LightGreen
        ElseIf L2CON(7) = "0" And L2CON(6) = "1" AndAlso L2CON(5) = "0" Then
            btnLIGHT2_1Press.Text = "FLASH"
            btnLIGHT2_1Press.BackColor = Color.Orange
        ElseIf L2CON(7) = "0" And L2CON(6) = "1" AndAlso L2CON(5) = "1" Then
            btnLIGHT2_1Press.Text = ""
            btnLIGHT2_1Press.BackColor = Color.LightGray
        End If

        'LIGHT2 2.Press
        If L2CON(10) = "0" And L2CON(9) = "0" AndAlso L2CON(8) = "0" Then
            btnLIGHT2_2Press.Text = "OFF"
            btnLIGHT2_2Press.BackColor = Color.Salmon
        ElseIf L2CON(10) = "0" And L2CON(9) = "0" AndAlso L2CON(8) = "1" Then
            btnLIGHT2_2Press.Text = "ON"
            btnLIGHT2_2Press.BackColor = Color.LightGreen
        ElseIf L2CON(10) = "0" And L2CON(9) = "1" AndAlso L2CON(8) = "0" Then
            btnLIGHT2_2Press.Text = "FLASH"
            btnLIGHT2_2Press.BackColor = Color.Orange
        ElseIf L2CON(10) = "0" And L2CON(9) = "1" AndAlso L2CON(8) = "1" Then
            btnLIGHT2_2Press.Text = ""
            btnLIGHT2_2Press.BackColor = Color.LightGray
        End If

        'LIGHT2 3.Press
        If L2CON(13) = "0" And L2CON(12) = "0" AndAlso L2CON(11) = "0" Then
            btnLIGHT2_3Press.Text = "OFF"
            btnLIGHT2_3Press.BackColor = Color.Salmon
        ElseIf L2CON(13) = "0" And L2CON(12) = "0" AndAlso L2CON(11) = "1" Then
            btnLIGHT2_3Press.Text = "ON"
            btnLIGHT2_3Press.BackColor = Color.LightGreen
        ElseIf L2CON(13) = "0" And L2CON(12) = "1" AndAlso L2CON(11) = "0" Then
            btnLIGHT2_3Press.Text = "FLASH"
            btnLIGHT2_3Press.BackColor = Color.Orange
        ElseIf L2CON(13) = "0" And L2CON(12) = "1" AndAlso L2CON(11) = "1" Then
            btnLIGHT2_3Press.Text = ""
            btnLIGHT2_3Press.BackColor = Color.LightGray
        End If

        Dim DCR() As Byte = ConvertBitStringToByteArray(testArray(4)) 'testArray(4).ToCharArray

        If DCR(0) = 0 Then
            btnNumberOfCells.Text = "1"
            btnNumberOfCells.BackColor = Color.LightBlue
        ElseIf DCR(0) = 1 Then
            btnNumberOfCells.Text = "2"
            btnNumberOfCells.BackColor = Color.LightGray
        End If

        If DCR(1) = 0 Then
            btnRFP.Text = "OFF"
            btnRFP.BackColor = Color.Salmon
        ElseIf DCR(1) = 1 Then
            btnRFP.Text = "ON"
            btnRFP.BackColor = Color.LightGreen
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
            btnAlarm_Buzzer_Light.BackColor = Color.Salmon

        ElseIf DCR(4) = 1 And DCR(5) = 0 AndAlso DCR(6) = 0 Then 'btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue

        End If

        Dim DCRCONstring As String = ""
        Dim sayi As New System.Text.StringBuilder()
        For indexA = 13 To 7 Step -1
            sayi.Append(DCR(indexA))
        Next indexA
        If String.IsNullOrEmpty(sayi.ToString) = False Then
            DCRCONstring = sayi.ToString
            If DCRCONstring = "0000010" Then
                lblDelay.Text = "0,2s"
            ElseIf DCRCONstring = "0000100" Then
                lblDelay.Text = "0,4s"
            ElseIf DCRCONstring = "0000110" Then
                lblDelay.Text = "0,6s"
            ElseIf DCRCONstring = "0001000" Then
                lblDelay.Text = "0,8s"
            ElseIf DCRCONstring = "0001010" Then
                lblDelay.Text = "1s"

            End If
        End If

        TCON = testArray(5) 'testArray(4).ToCharArray

        Dim timeAuto As String
        Dim timeFirst As String
        Dim timeOn As String
        Dim timeOff As String

        If (TCON.Length = 16) Then
            timeAuto = TCON.Substring(0, 4)
            CmbTurnOff.SelectedIndex = CmbTurnOff.FindStringExact(Convert.ToInt32(timeAuto, 2))

            timeFirst = TCON.Substring(12, 4)
            Dim tF As Integer
            tF = Convert.ToInt32(timeFirst, 2)
            cmbTFirst.SelectedIndex = cmbTFirst.FindStringExact((tF + 1) / 2)

            timeOff = TCON.Substring(8, 4)
            tF = Convert.ToInt32(timeOff, 2)
            cmbToff.SelectedIndex = cmbToff.FindStringExact((tF + 1) / 2)

            timeOn = TCON.Substring(4, 4)
            tF = Convert.ToInt32(timeOn, 2)
            CmbTon.SelectedIndex = CmbTon.FindStringExact((tF + 1) / 2)


        End If

    End Function
    Private Sub GetListOfSettings()

        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\SETTINGS")
        'MessageBox.Show(Application.StartupPath)
        If (di.Exists = False) Then
            IO.Directory.CreateDirectory(Application.StartupPath & "\SETTINGS")
        End If

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
    Private Sub btnLOAD_Click(sender As Object, e As EventArgs)
        Dim testString As String = LoadSpecFile("")

        Dim testArray() As String = Split(testString)

        Dim received_M2CONByte() As Byte = ConvertBitStringToByteArray(testArray(1))

        'M2CON = received_M2CONByte

    End Sub

    Private Function ConvertBitStringToByteArray(paramString As String) As Byte()

        Dim paramByte(paramString.Length - 1) As Byte
        Dim ind As Integer = 0
        If paramString.Length > 0 Then
            If paramString <> "" Then
                Dim parameterChar() As Char = paramString.ToCharArray
                For i As Integer = paramString.Length - 1 To 0 Step -1
                    paramByte(i) = Char.GetNumericValue(parameterChar(ind))
                    ind = ind + 1
                Next
            End If
        End If
        Return paramByte
    End Function

    Private Function ConvertIntegerToBinaryString(value As Integer, isComplete As Boolean) As String
        Dim bb As String
        bb = 0
        If value > 0 Then
            bb = Convert.ToString(value, 2)
        End If
        If isComplete = True Then
            Return Complete8BitPadRight(bb)
        End If
        Return bb
    End Function

    Private Function Complete8BitPadRight(paramString As String) As String
        Dim strlen As Integer
        strlen = paramString.Length
        If strlen < 8 Then
            paramString = paramString.PadRight(8, "0")
        ElseIf strlen > 8 And strlen < 16 Then
            paramString = paramString.PadRight(16, "0")
        ElseIf strlen > 16 And strlen < 32 Then
            paramString = paramString.PadRight(32, "0")
        ElseIf strlen > 32 And strlen < 64 Then
            paramString = paramString.PadRight(64, "0")
        End If
        Return paramString
    End Function

    Private Function Complete8BitPadLeft(paramString As String) As String
        Dim strlen As Integer
        strlen = paramString.Length
        If strlen < 8 Then
            paramString = paramString.PadLeft(8, "0")
        ElseIf strlen > 8 And strlen < 16 Then
            paramString = paramString.PadLeft(16, "0")
        ElseIf strlen > 16 And strlen < 32 Then
            paramString = paramString.PadLeft(32, "0")
        ElseIf strlen > 32 And strlen < 64 Then
            paramString = paramString.PadLeft(64, "0")
        End If
        Return paramString
    End Function


    Private Sub received_M2CON_Click(sender As Object, e As EventArgs)

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

        For indexA = 15 To 0 Step -1
            sb1.Append(M2CON(indexA))
        Next indexA
        M2CONstring = sb1.ToString

        M2CONstring = Complete8BitPadLeft(M2CONstring)

        Dim L1CONstring As String = ""
        Dim sb2 As New System.Text.StringBuilder()
        For indexA = 15 To 0 Step -1
            sb2.Append(L1CON(indexA))
        Next indexA
        L1CONstring = sb2.ToString

        L1CONstring = Complete8BitPadLeft(L1CONstring)

        Dim L2CONstring As String = ""
        Dim sb3 As New System.Text.StringBuilder()
        For indexA = 15 To 0 Step -1
            sb3.Append(L2CON(indexA))
        Next indexA
        L2CONstring = sb3.ToString

        L2CONstring = Complete8BitPadLeft(L2CONstring)

        Dim DCRCONstring As String = ""
        Dim sb4 As New System.Text.StringBuilder()
        For indexA = 15 To 0 Step -1
            sb4.Append(DCR(indexA))
        Next indexA
        DCRCONstring = sb4.ToString

        DCRCONstring = Complete8BitPadLeft(DCRCONstring)

        Dim timeLine As String

        Dim Tfirst As String
        Tfirst = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble(cmbTFirst.Text) * 2 - 1), False)
        Tfirst = Tfirst.PadLeft(4, "0")

        Dim Ton As String
        Ton = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble((CmbTon.Text) * 2 - 1)), False)
        Ton = Ton.PadLeft(4, "0")

        Dim Toff As String
        Toff = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble((cmbToff.Text) * 2 - 1)), False)
        Toff = Toff.PadLeft(4, "0")

        Dim Ato As String
        Ato = ConvertIntegerToBinaryString(Convert.ToInt32(CmbTurnOff.Text), False)
        Ato = Ato.PadLeft(3, "0")

        timeLine = Ato + Ton + Toff + Tfirst
        TCON = Complete8BitPadLeft(timeLine)


        Dim records As List(Of Input)
        records = New List(Of Input)

        Dim input1 As Input = New Input()
        Dim input2 As Input = New Input()
        Dim input3 As Input = New Input()
        Dim input4 As Input = New Input()
        Dim input5 As Input = New Input()
        Dim input6 As Input = New Input()

        input1.name = "M1Con"
        input1.address = "0x10"
        input1.amount = "2"
        input1.data1 = "0000000000000001"

        input2.name = "M2Con"
        input2.address = "0x12"
        input2.amount = "2"
        input2.data1 = M2CONstring

        input3.name = "L1Con"
        input3.address = "0x14"
        input3.amount = "2"
        input3.data1 = L1CONstring

        input4.name = "L2Con"
        input4.address = "0x16"
        input4.amount = "2"
        input4.data1 = L2CONstring

        input5.name = "DCR"
        input5.address = "0x0E"
        input5.amount = "2"
        input5.data1 = DCRCONstring

        input6.name = "DCR"
        input6.address = "0x0C"
        input6.amount = "2"
        input6.data1 = timeLine

        records.Add(input1)
        records.Add(input2)
        records.Add(input3)
        records.Add(input4)
        records.Add(input5)
        records.Add(input6)

        Dim M1ConString As String
        M1ConString = "0000000000000001" 'Address 0x10

        Dim st As String
        st = M2CONstring + " " + L1CONstring + " " + L2CONstring + " " + DCRCONstring + " " + TCON

        Return st
    End Function

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click

        If InputControl() = 0 Then
            Exit Sub
        End If

        Dim st As String
        st = Save()

        'Dim M2CONstring As String = System.Text.Encoding.UTF8.GetString(M2CON)

        Dim FILE_NAME As String = Application.StartupPath & "\SETTINGS\" + cmbPrograms.SelectedItem + ".txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(cmbPrograms.SelectedItem + " " + st)
            objWriter.Close()
            MessageBox.Show("File is succesfully saved.")
        Else

            Dim myValue As String = InputBox("Program Name:", "Program Name", "Please enter a valid program name here")
            myValue = myValue.Trim.Replace(" ", "_").ToUpper
            If (myValue = "" Or myValue = "Please enter a valid program name here" Or cmbPrograms.Items.Contains(myValue)) Then
                MessageBox.Show("Please enter a valid program name.")
                Exit Sub
            End If

            FILE_NAME = Application.StartupPath & "\SETTINGS\" + myValue + ".txt"
            System.IO.File.Create(FILE_NAME).Dispose()
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(myValue + " " + st)
            objWriter.Close()

            'MENUYE EKLEME
            AddMenuItem(myValue)

            cmbPrograms.SelectedItem = myValue

            MessageBox.Show("Settings are saved in a file named: " + myValue)

        End If

    End Sub

    Private Function InputControl() As Boolean
        If (cmbPrograms.SelectedItem = "") Then
            MessageBox.Show("No program selected!")
            Return 0
        End If
        If btnMOTOR2onOFF.Text = "ON" And btnMOTOR2pwrON.Text = "" Then
            MessageBox.Show("select Motor2 PowerON button other than empty ")
            Return 0
        End If
        If btnLIGHT1onOFF.Text = "ON" And btnLIGHT1powerON.Text = "" Then
            MessageBox.Show("Select Light 1 PowerON button other than empty ")
            Return 0
        End If
        If btnLIGHT2onOFF.Text = "ON" And btnLIGHT2powerON.Text = "" Then
            MessageBox.Show("Select Light2 PowerON button other than empty ")
            Return 0
        End If
        Return 1
    End Function

    Private Sub btnBitToByte_Click(sender As Object, e As EventArgs)


    End Sub

    Private Function UnicodeBytesToString(
    ByVal bytes() As Byte) As String

        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Private Sub btnMOTOR1_Click(sender As Object, e As EventArgs) Handles btnMOTOR1.Click

        If (CheckPortConnection() = False) Then
            MessageBox.Show("Please check the port connection.")
            Exit Sub
        End If
        If (btnMOTOR1.BackColor = Color.LightGray) Then
            TestOperation(0, 1)
            btnMOTOR1.BackColor = Color.LightGreen
        Else
            TestOperation(0, 0)
            btnMOTOR1.BackColor = Color.LightGray
        End If


    End Sub

    Private Sub ProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramsToolStripMenuItem.Click
        gbProgram.Visible = True
        gbMaintenance.Visible = False
        gbConSettings.Visible = False
        Timer_Stop()
        'thReadDev.Abort()
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
        gbMaintenance.Visible = True
        gbProgram.Visible = False
        gbConSettings.Visible = False
        ClearDeviceProperty()
        ClearTimeProperty()
        If (CheckPortConnection() = False) Then
            MessageBox.Show("Please check the port connection.")
            ClearDeviceProperty()
            ClearTimeProperty()
            'ClearForm()
            Exit Sub
        End If

        ' Timer1.Start()
        ReadAll()

        '--------------------

        'If (thReadAll.IsAlive = False) Then

        '    thReadAll = New Thread(New ThreadStart(AddressOf Me.ReadAll))

        '    thReadAll.Start()

        '    thReadAll.Join()
        '    'thReadAll.Priority = ThreadPriority.AboveNormal
        '    'thReadAll.IsBackground = True
        '    'Else
        '    '    If (thReadAll.IsBackground = False) Then
        '    '        'thReadAll.Resume()
        '    '    End If
        'End If

        'Thread.Sleep(100)

        '--------------------

        'If (thReadDev.IsAlive = False) Then

        '    thReadDev = New Thread(New ThreadStart(AddressOf Me.ReadDev))
        '    thReadDev.IsBackground = True
        '    thReadDev.Start()
        '    thReadDev.Join()
        '    thReadDev.Priority = ThreadPriority.Highest
        'Else
        '    thReadDev.Resume()
        'End If

    End Sub

    Private Sub GetLastStateBeforeSave()
        If btnMOTOR2onOFF.Text = "ON" Then
            M2CON(0) = 1
        Else
            M2CON(0) = 0
        End If

        M2CON(1) = 0

        If btnMOTOR2pwrON.Text = "AUTO" Then
            M2CON(4) = 0
            M2CON(3) = 0
            M2CON(2) = 0
        ElseIf btnMOTOR2pwrON.Text = "SYNC" Then
            M2CON(4) = 0
            M2CON(3) = 0
            M2CON(2) = 1
        ElseIf btnMOTOR2pwrON.Text = "PEDAL" Then
            M2CON(4) = 0
            M2CON(3) = 1
            M2CON(2) = 0
        ElseIf btnMOTOR2pwrON.Text = "RUN" Then
            M2CON(4) = 0
            M2CON(3) = 1
            M2CON(2) = 1
        ElseIf btnMOTOR2pwrON.Text = "OFF" Then
            M2CON(4) = 1
            M2CON(3) = 0
            M2CON(2) = 0
        ElseIf btnMOTOR2pwrON.Text = "" Then
            M2CON(4) = 1
            M2CON(3) = 0
            M2CON(2) = 1

        End If
        If btnMOTOR2_1Press.Text = "AUTO" Then
            M2CON(7) = 0
            M2CON(6) = 0
            M2CON(5) = 0
        ElseIf btnMOTOR2_1Press.Text = "SYNC" Then
            M2CON(7) = 0
            M2CON(6) = 0
            M2CON(5) = 1
        ElseIf btnMOTOR2_1Press.Text = "PEDAL" Then
            M2CON(7) = 0
            M2CON(6) = 1
            M2CON(5) = 0
        ElseIf btnMOTOR2_1Press.Text = "RUN" Then
            M2CON(7) = 0
            M2CON(6) = 1
            M2CON(5) = 1
        ElseIf btnMOTOR2_1Press.Text = "OFF" Then
            M2CON(7) = 1
            M2CON(6) = 0
            M2CON(5) = 0
        ElseIf btnMOTOR2_1Press.Text = "" Then
            M2CON(7) = 1
            M2CON(6) = 0
            M2CON(5) = 1

        End If
        If btnMOTOR2_2Press.Text = "AUTO" Then
            M2CON(10) = 0
            M2CON(9) = 0
            M2CON(8) = 0
        ElseIf btnMOTOR2_2Press.Text = "SYNC" Then
            M2CON(10) = 0
            M2CON(9) = 0
            M2CON(8) = 1
        ElseIf btnMOTOR2_2Press.Text = "PEDAL" Then
            M2CON(10) = 0
            M2CON(9) = 1
            M2CON(8) = 0
        ElseIf btnMOTOR2_2Press.Text = "RUN" Then
            M2CON(10) = 0
            M2CON(9) = 1
            M2CON(8) = 1
        ElseIf btnMOTOR2_2Press.Text = "OFF" Then
            M2CON(10) = 1
            M2CON(9) = 0
            M2CON(8) = 0
        ElseIf btnMOTOR2_2Press.Text = "" Then
            M2CON(10) = 1
            M2CON(9) = 0
            M2CON(8) = 1

        End If
        If btnMOTOR2_3Press.Text = "AUTO" Then
            M2CON(13) = 0
            M2CON(12) = 0
            M2CON(11) = 0
        ElseIf btnMOTOR2_3Press.Text = "SYNC" Then
            M2CON(13) = 0
            M2CON(12) = 0
            M2CON(11) = 1
        ElseIf btnMOTOR2_3Press.Text = "PEDAL" Then
            M2CON(13) = 0
            M2CON(12) = 1
            M2CON(11) = 0
        ElseIf btnMOTOR2_3Press.Text = "RUN" Then
            M2CON(13) = 0
            M2CON(12) = 1
            M2CON(11) = 1
        ElseIf btnMOTOR2_3Press.Text = "OFF" Then
            M2CON(13) = 1
            M2CON(12) = 0
            M2CON(11) = 0
        ElseIf btnMOTOR2_3Press.Text = "" Then
            M2CON(13) = 1
            M2CON(12) = 0
            M2CON(11) = 1

        End If
        M2CON(14) = 0
        M2CON(15) = 0


        If btnLIGHT1onOFF.Text = "ON" Then
            L1CON(0) = 1
        Else
            L1CON(0) = 0
        End If
        If btnLIGHT1powerON.Text = "OFF" Then
            L1CON(4) = 0
            L1CON(3) = 0
            L1CON(2) = 0
        ElseIf btnLIGHT1powerON.Text = "ON" Then
            L1CON(4) = 0
            L1CON(3) = 0
            L1CON(2) = 1
        ElseIf btnLIGHT1powerON.Text = "FLASH" Then
            L1CON(4) = 0
            L1CON(3) = 1
            L1CON(2) = 0
        ElseIf btnLIGHT1powerON.Text = "" Then
            L1CON(4) = 0
            L1CON(3) = 1
            L1CON(2) = 1
        End If

        If btnLIGHT1_1Press.Text = "OFF" Then
            L1CON(7) = 0
            L1CON(6) = 0
            L1CON(5) = 0
        ElseIf btnLIGHT1_1Press.Text = "ON" Then
            L1CON(7) = 0
            L1CON(6) = 0
            L1CON(5) = 1
        ElseIf btnLIGHT1_1Press.Text = "FLASH" Then
            L1CON(7) = 0
            L1CON(6) = 1
            L1CON(5) = 0
        ElseIf btnLIGHT1_1Press.Text = "" Then 'NA
            L1CON(7) = 0
            L1CON(6) = 1
            L1CON(5) = 1
        End If

        If btnLIGHT1_2Press.Text = "OFF" Then
            L1CON(10) = 0
            L1CON(9) = 0
            L1CON(8) = 0
        ElseIf btnLIGHT1_2Press.Text = "ON" Then
            L1CON(10) = 0
            L1CON(9) = 0
            L1CON(8) = 1
        ElseIf btnLIGHT1_2Press.Text = "FLASH" Then
            L1CON(10) = 0
            L1CON(9) = 1
            L1CON(8) = 0
        ElseIf btnLIGHT1_2Press.Text = "" Then 'NA
            L1CON(10) = 0
            L1CON(9) = 1
            L1CON(8) = 1
        End If

        If btnLIGHT1_3Press.Text = "OFF" Then
            L1CON(13) = 0
            L1CON(12) = 0
            L1CON(11) = 0
        ElseIf btnLIGHT1_3Press.Text = "ON" Then
            L1CON(13) = 0
            L1CON(12) = 0
            L1CON(11) = 1
        ElseIf btnLIGHT1_3Press.Text = "FLASH" Then
            L1CON(13) = 0
            L1CON(12) = 1
            L1CON(11) = 0
        ElseIf btnLIGHT1_3Press.Text = "" Then 'NA
            L1CON(13) = 0
            L1CON(12) = 1
            L1CON(11) = 1
        End If

        L1CON(14) = 0
        L1CON(15) = 0

        If btnLIGHT2onOFF.Text = "ON" Then
            L2CON(0) = 1
        Else
            L2CON(0) = 0
        End If
        If btnLIGHT2powerON.Text = "OFF" Then
            L2CON(4) = 0
            L2CON(3) = 0
            L2CON(2) = 0
        ElseIf btnLIGHT2powerON.Text = "ON" Then
            L2CON(4) = 0
            L2CON(3) = 0
            L2CON(2) = 1
        ElseIf btnLIGHT2powerON.Text = "FLASH" Then
            L2CON(4) = 0
            L2CON(3) = 1
            L2CON(2) = 0
        ElseIf btnLIGHT2powerON.Text = "" Then
            L2CON(4) = 1
            L2CON(3) = 0
            L2CON(2) = 1
        End If

        If btnLIGHT2_1Press.Text = "OFF" Then
            L2CON(7) = 0
            L2CON(6) = 0
            L2CON(5) = 0
        ElseIf btnLIGHT2_1Press.Text = "ON" Then
            L2CON(7) = 0
            L2CON(6) = 0
            L2CON(5) = 1
        ElseIf btnLIGHT2_1Press.Text = "FLASH" Then
            L2CON(7) = 0
            L2CON(6) = 1
            L2CON(5) = 0
        ElseIf btnLIGHT2_1Press.Text = "" Then 'NA
            L2CON(7) = 0
            L2CON(6) = 1
            L2CON(5) = 1
        End If

        If btnLIGHT2_2Press.Text = "OFF" Then
            L2CON(10) = 0
            L2CON(9) = 0
            L2CON(8) = 0
        ElseIf btnLIGHT2_2Press.Text = "ON" Then
            L2CON(10) = 0
            L2CON(9) = 0
            L2CON(8) = 1
        ElseIf btnLIGHT2_2Press.Text = "FLASH" Then
            L2CON(10) = 0
            L2CON(9) = 1
            L2CON(8) = 0
        ElseIf btnLIGHT2_2Press.Text = "" Then 'NA
            L2CON(10) = 0
            L2CON(9) = 1
            L2CON(8) = 1
        End If

        If btnLIGHT2_3Press.Text = "OFF" Then
            L2CON(13) = 0
            L2CON(12) = 0
            L2CON(11) = 0
        ElseIf btnLIGHT2_3Press.Text = "ON" Then
            L2CON(13) = 0
            L2CON(12) = 0
            L2CON(11) = 1
        ElseIf btnLIGHT2_3Press.Text = "FLASH" Then
            L2CON(13) = 0
            L2CON(12) = 1
            L2CON(11) = 0
        ElseIf btnLIGHT2_3Press.Text = "" Then 'NA
            L2CON(13) = 0
            L2CON(12) = 1
            L2CON(11) = 1
        End If  'EKLE

        L2CON(14) = 0
        L2CON(15) = 0

        If btnNumberOfCells.Text = "1" Then
            DCR(0) = 0
        ElseIf btnNumberOfCells.Text = "2" Then
            DCR(0) = 1
        End If

        If btnRFP.Text = "ON" Then
            DCR(1) = 1
        ElseIf btnRFP.Text = "OFF" Then
            DCR(1) = 0
        End If

        If btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1" Then
            DCR(6) = 0
            DCR(5) = 1
            DCR(4) = 1

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2" Then
            DCR(6) = 1
            DCR(5) = 0
            DCR(4) = 1

        ElseIf btnAlarm_Buzzer_Light.Text = "OFF" Then
            DCR(6) = 0
            DCR(5) = 0
            DCR(4) = 0

        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            DCR(6) = 0
            DCR(5) = 0
            DCR(4) = 1

        End If

        If lblDelay.Text = "0,2s" Then
            DCR(13) = 0
            DCR(12) = 0
            DCR(11) = 0
            DCR(10) = 0
            DCR(9) = 0
            DCR(8) = 1
            DCR(7) = 0

        ElseIf lblDelay.Text = "0,4s" Then
            DCR(13) = 0
            DCR(12) = 0
            DCR(11) = 0
            DCR(10) = 0
            DCR(9) = 1
            DCR(8) = 0
            DCR(7) = 0

        ElseIf lblDelay.Text = "0,6s" Then
            DCR(13) = 0
            DCR(12) = 0
            DCR(11) = 0
            DCR(10) = 0
            DCR(9) = 1
            DCR(8) = 1
            DCR(7) = 0

        ElseIf lblDelay.Text = "0,8s" Then
            DCR(13) = 0
            DCR(12) = 0
            DCR(11) = 0
            DCR(10) = 1
            DCR(9) = 0
            DCR(8) = 0
            DCR(7) = 0

        ElseIf lblDelay.Text = "1s" Then
            DCR(13) = 0
            DCR(12) = 0
            DCR(11) = 0
            DCR(10) = 1
            DCR(9) = 0
            DCR(8) = 1
            DCR(7) = 0
        End If

        DCR(15) = 0
        DCR(14) = 0

        Dim timeLine As String

        Dim Tfirst As String
        Tfirst = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble(cmbTFirst.Text) * 2 - 1), False)
        Tfirst = Tfirst.PadLeft(4, "0")

        Dim Ton As String
        Ton = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble((CmbTon.Text) * 2 - 1)), False)
        Ton = Ton.PadLeft(4, "0")

        Dim Toff As String
        Toff = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble((cmbToff.Text) * 2 - 1)), False)
        Toff = Toff.PadLeft(4, "0")

        Dim Ato As String
        Ato = ConvertIntegerToBinaryString(Convert.ToInt32(CmbTurnOff.Text), False)
        Ato = Ato.PadLeft(3, "0")
        '0123456789
        timeLine = Ato + Ton + Toff + Tfirst
        TCON = Complete8BitPadLeft(timeLine)

    End Sub

    Private Sub RadioButton_F_SWITCH_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_F_SWITCH.CheckedChanged

    End Sub

    Function GetBluetoothConnectedDevices() As List(Of String)
        Dim R As New List(Of String)
        Try
            Dim searcher As New ManagementObjectSearcher(New ManagementScope("\\.\root\CIMV2", Nothing),
                                                         New WqlObjectQuery("Select Name from Win32_SerialPort"), Nothing)
            'where pnpclass = 'bluetooth' and service is null and description = 'bluetooth device'
            For Each share As ManagementObject In searcher.[Get]()
                Console.WriteLine(searcher.[Get].Count.ToString)

                Try
                    If Not IsNothing(share("Name")) AndAlso share("Name").ToString.Trim = "" Then
                        R.Add(share("Name").ToString.Trim)
                    End If
                Catch
                    Continue For
                End Try
            Next
        Catch
        End Try
        Return R
    End Function

    Private Sub ConnectionSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSToolStripMenuItem.Click
        gbConSettings.Visible = True
        gbProgram.Visible = False
        gbMaintenance.Visible = False

        cmbPorts.SelectedText = ""
        cmbPorts.Items.Clear()
        'cmbPorts.SelectedIndex = -1
        'cmbPorts.SelectedItem = Nothing

        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()
        Dim port As String
        'Dim PortName As String

        ' GetBluetoothConnectedDevices()

        For Each port In ports
            cmbPorts.Items.Add(port)
            'MsgBox(port, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Serial port detecetd")
        Next port

        'MessageBox.Show("PORTLAR" + port)
        ''Win32_DeviceChangeEvent --Win32_SerialPort
        'Dim ManObjSearch As ManagementObjectSearcher = New ManagementObjectSearcher("root\cimv2", "SELECT * FROM Win32_DeviceChangeEvent")
        'Dim ManObjReturn As ManagementObjectCollection
        'ManObjReturn = ManObjSearch.Get()
        'For Each ManObj In ManObjReturn
        '    Console.WriteLine("for ici")
        '    Console.WriteLine("-----------------------------------" + ManObj.GetPropertyValue("Name").ToString())
        '    Console.WriteLine("MSSerial_PortName instance")
        '    Console.WriteLine("-----------------------------------")
        '    Console.WriteLine("InstanceName: {0}", ManObj["InstanceName"])
        '    Console.WriteLine("-----------------------------------")
        '    Console.WriteLine("MSSerial_PortName instance")
        '    Console.WriteLine("-----------------------------------")
        '    ' Console.WriteLine("PortName: {0}", ManObj["PortName"])

        '    Dim ss As PropertyDataCollection
        '    ss = ManObj.Properties
        'Next

        Timer_Stop()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PortName = cmbPorts.SelectedItem
        If PortName <> "" Then

            If SerialPort1.IsOpen = True Then
                MsgBox("Serial Port that you want to connect is using by another program")
                lblStatus.Text = "Port connection is successfull"
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


            TEST(7) = 0
            TEST(6) = 0
            TEST(5) = 0
            TEST(4) = 0
            TEST(3) = 0
            TEST(2) = 0
            TEST(1) = 0
            TEST(0) = 0

            If SerialPort1.IsOpen = False Then
                Try
                    SerialPort1.Open()
                Catch ex As Exception
                    MsgBox("Serial Port that you want to connect is using by another program")
                End Try

            End If
            lblStatus.Text = "Port connection is successfull"

        End If
    End Sub

    Private Sub cmbPrograms_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPrograms.SelectedValueChanged
        ClearForm()
        ParseText(cmbPrograms.Text)
        GetLastStateBeforeSave()
    End Sub


    Private Sub cmbPrograms_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmbPrograms.DrawItem
        Dim myFont As System.Drawing.Font = cmbPrograms.Font
        Dim TextColor As New System.Drawing.Color
        If e.Index = 0 Then
            TextColor = System.Drawing.Color.Salmon
        Else
            TextColor = System.Drawing.Color.Black
        End If

        cmbPrograms.ForeColor = System.Drawing.Color.Salmon

        Dim myBrush As SolidBrush = New SolidBrush(TextColor)
        ' Draw the background of the item.
        e.DrawBackground()

        e.Graphics.DrawString(cmbPrograms.Items(0), myFont, myBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))

        ' Draw the focus rectangle if the mouse hovers over an item.
        'e.DrawFocusRectangle()
    End Sub

    Private Function ReadPortByAddress(address As String, timeType As Boolean) As String

        Dim txtBuff As String = ""

        Dim buffIndx As Integer = 0

        'READ D
        Try
            If (SerialPort1.IsOpen) Then

                Dim first As Byte
                Dim second As Byte
                Dim third As Byte
                Dim data1 As String = "0"
                Dim data2 As String = "0"
                Dim data3 As String = "0"
                Dim data4 As String = "0"

                Dim writeBytes() As Byte

                first = Convert.ToByte("23", 16)  ' 34 22 write
                second = Convert.ToByte(address, 16)  'inp.address ' 16 adres
                third = Convert.ToByte("4", 16)    ' 2 kaç byte

                writeBytes = {first, second, third}

                Console.WriteLine("------------------>SerialPort1.Wite DEV YAZMA: ADRESS(" + address + ")" + "->" + first.ToString + " " + second.ToString + " " + third.ToString)

                SerialPort1.Write(writeBytes, 0, writeBytes.Length)

                If (SerialPort1_DataReceived(Convert.ToInt32(third)) = False) Then
                    'lblStatus.Text = "No device connection."
                    Return txtBuff
                    Exit Function
                End If

                Try
                    Dim buff(SerialPort1.BytesToRead) As Byte
                    Dim bytesRead As Integer

                    Dim defM1C As String
                    defM1C = ""
                    bytesRead = SerialPort1.Read(buff, 0, buff.Length)
                    For Each valM1C As Byte In buff
                        defM1C = defM1C + " " + valM1C.ToString
                        If (buffIndx = 0) Then
                            data1 = Convert.ToString(Convert.ToInt32(valM1C.ToString), 2)

                        ElseIf (buffIndx = 1) Then
                            data2 = Convert.ToString(Convert.ToInt32(valM1C.ToString), 2)

                        ElseIf (buffIndx = 2) Then
                            data3 = Convert.ToString(Convert.ToInt32(valM1C.ToString), 2)

                        ElseIf (buffIndx = 3) Then
                            data4 = Convert.ToString(Convert.ToInt32(valM1C.ToString), 2)

                        End If
                        buffIndx = buffIndx + 1
                    Next

                    data1 = Complete8BitPadLeft(data1)
                    data2 = Complete8BitPadLeft(data2)
                    data3 = Complete8BitPadLeft(data3)
                    data4 = Complete8BitPadLeft(data4)

                    If (address = "0A") Then
                        txtBuff = data1 + data2 + data4 + data3
                    Else
                        txtBuff = data1 + data2 + data3 + data4
                    End If

                    Console.WriteLine("------------------>READ DATA  (ADDRESS) ->(" + address + ")" + txtBuff)

                    Console.WriteLine("------------------>READ RAW DATA ->" + defM1C)
                    'If (txtBuff = "11111111111111111111111111111111") Then
                    '    'msjFlag = 1
                    '    'MessageBox.Show("Please check the device connection.")
                    '    'Thread.CurrentThread.Abort()
                    '    'lblStatus.Text = "No device connection."

                    'End If
                Catch ex As Exception
                    Console.WriteLine("------------------>READ ERROR ->" + ex.Message)
                    'lblStatus.Text = "No device connection."
                End Try
            Else
                'MessageBox.Show("Please check the port connection.")
                'msjFlag = 1
                lblStatus.Text = "No port connection."

            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            'lblStatus.Text = "No device connection."
            'msjFlag = 1
        End Try
        Return txtBuff
    End Function

    Private Sub ClearDeviceProperty()
        lblCell1Intensity.Text = ""
        lblCell2Intensity.Text = ""
        RadioButton_Cell1_RX.Checked = False
        RadioButton_Cell1_TX.Checked = False
        RadioButton_Cell2_RX.Checked = False
        RadioButton_Cell2_TX.Checked = False
        RadioButton_Inputs_P1.Checked = False
        RadioButton_Inputs_P2.Checked = False
        RadioButton_Inputs_ALM.Checked = False

        btnMOTOR1.BackColor = Color.LightGray
        btnMOTOR2.BackColor = Color.LightGray
        btnLIGHT1.BackColor = Color.LightGray
        btnLIGHT2.BackColor = Color.LightGray
        btnAlarm.BackColor = Color.LightGray

        TEST(7) = 0
        TEST(6) = 0
        TEST(5) = 0
        TEST(4) = 0
        TEST(3) = 0
        TEST(2) = 0
        TEST(1) = 0
        TEST(0) = 0

        lblVs.Text = ""
    End Sub


    Private Sub ClearTimeProperty()

        lblM1C.Text = ""
        lblM1TCon.Text = ""
        lblM2C.Text = ""
        lblM2TCon.Text = ""
        lblL1C.Text = ""
        lblL1TCon.Text = ""
        lblL2C.Text = ""
        lblL2TCon.Text = ""

    End Sub

    Private Sub ViewDeviceVersionRegister(txtBuffProperty As String)
        'ClearDeviceProperty()

        If (txtBuffProperty <> Nothing) Then
            If (txtBuffProperty.Length > 0) Then

                txtBuffProperty = txtBuffProperty.PadLeft(32, "0")

                Dim txtBuffChrArr As Char()
                txtBuffChrArr = txtBuffProperty.ToCharArray()

                Dim vsNum As String = txtBuffProperty.Substring(12, 4)
                vsNum = ConvertBinToStr(vsNum, 0, 0)

                Dim rvsNum As String = txtBuffProperty.Substring(8, 4)
                rvsNum = ConvertBinToStr(rvsNum, 0, 0)

                If (vsNum = "0" Or rvsNum = "0") Then
                    MessageBox.Show("Versiyon hatası oluştu.")
                    Exit Sub
                End If

                Dim cell1Int As String = txtBuffProperty.Substring(24, 8)

                Dim cell2Int As String = txtBuffProperty.Substring(16, 8)

                lblVs.Text = "V" + ((10 + vsNum).ToString) + "-R" + ((-1 + rvsNum).ToString)

                If txtBuffChrArr(6) = "0" Then
                    RadioButton_Cell1_RX.Checked = False
                    RadioButton_Cell1_RX.ForeColor = Color.Black
                ElseIf txtBuffChrArr(6) = "1" Then
                    RadioButton_Cell1_RX.ForeColor = Color.Red
                    RadioButton_Cell1_RX.Checked = True
                End If
                If txtBuffChrArr(5) = "0" Then
                    RadioButton_Cell1_TX.Checked = False
                    RadioButton_Cell1_TX.ForeColor = Color.Black
                ElseIf txtBuffChrArr(5) = "1" Then
                    RadioButton_Cell1_TX.Checked = True
                    RadioButton_Cell1_TX.ForeColor = Color.Red
                End If

                If txtBuffChrArr(4) = "0" Then
                    RadioButton_Cell2_RX.Checked = False
                ElseIf txtBuffChrArr(4) = "1" Then
                    RadioButton_Cell2_RX.Checked = True
                End If
                If txtBuffChrArr(3) = "0" Then
                    RadioButton_Cell2_TX.Checked = False
                ElseIf txtBuffChrArr(3) = "1" Then
                    RadioButton_Cell2_TX.Checked = True
                End If

                If txtBuffChrArr(2) = "0" Then
                    RadioButton_Inputs_P1.Checked = False
                ElseIf txtBuffChrArr(2) = "1" Then
                    RadioButton_Inputs_P1.Checked = True
                End If
                If txtBuffChrArr(1) = "0" Then
                    RadioButton_Inputs_P2.Checked = False
                ElseIf txtBuffChrArr(1) = "1" Then
                    RadioButton_Inputs_P2.Checked = True
                End If

                If txtBuffChrArr(0) = "0" Then
                    RadioButton_Inputs_ALM.Checked = False
                ElseIf txtBuffChrArr(0) = "1" Then
                    RadioButton_Inputs_ALM.Checked = True
                End If

                lblCell1Intensity.Text = ConvertBinToStr(cell1Int, 1, 1)
                lblCell2Intensity.Text = ConvertBinToStr(cell2Int, 1, 1)
            End If
        End If
    End Sub

    Private Sub ReadAll()
        Console.WriteLine("ReadAll BEGIN")

        'Thread.Sleep(1000)

        Dim txtBuffM1C As String = ReadPortByAddress("19", True) '

        If (txtBuffM1C Is Nothing Or txtBuffM1C = "" Or txtBuffM1C = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        Dim txtBuffM1TCon As String = ReadPortByAddress("1E", True)

        If (txtBuffM1TCon Is Nothing Or txtBuffM1TCon = "" Or txtBuffM1TCon = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        Dim txtBuffM2C As String = ReadPortByAddress("23", True)

        If (txtBuffM2C Is Nothing Or txtBuffM2C = "" Or txtBuffM2C = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        Dim txtbuffm2ton As String = ReadPortByAddress("28", True)

        If (txtbuffm2ton Is Nothing Or txtbuffm2ton = "" Or txtbuffm2ton = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        Dim txtbuffl1c As String = ReadPortByAddress("2d", True)

        If (txtbuffl1c Is Nothing Or txtbuffl1c = "" Or txtbuffl1c = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        Dim txtBuffL1Tcon As String = ReadPortByAddress("32", True)

        If (txtBuffL1Tcon Is Nothing Or txtBuffL1Tcon = "" Or txtBuffL1Tcon = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        Dim txtBuffL2C As String = ReadPortByAddress("37", True)

        If (txtBuffL2C Is Nothing Or txtBuffL2C = "" Or txtBuffL2C = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        Dim txtBuffL2Tcon As String = ReadPortByAddress("3C", True)

        If (txtBuffL2Tcon Is Nothing Or txtBuffL2Tcon = "" Or txtBuffL2Tcon = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()
            Timer1.Start()
            Exit Sub
        End If

        If txtBuffM1C.Length > 0 Then
            lblM1C.Text = ConvertBinToStr(txtBuffM1C, 0, 0)
        End If

        If txtBuffM1TCon.Length > 0 Then
            lblM1TCon.Text = ConvertBinToStr(txtBuffM1TCon, 0, 0)
        End If

        If txtBuffM2C.Length > 0 Then
            lblM2C.Text = ConvertBinToStr(txtBuffM2C, 0, 0)
        End If

        If txtbuffm2ton.Length > 0 Then
            lblM2TCon.Text = ConvertBinToStr(txtbuffm2ton, 0, 0)
        End If

        If txtbuffl1c.Length > 0 Then
            lblL1C.Text = ConvertBinToStr(txtbuffl1c, 0, 0)
        End If

        If txtBuffL1Tcon.Length > 0 Then
            lblL1TCon.Text = ConvertBinToStr(txtBuffL1Tcon, 0, 0)
        End If

        If txtBuffL2C.Length > 0 Then
            lblL2C.Text = ConvertBinToStr(txtBuffL2C, 0, 0)
        End If

        If txtBuffL2Tcon.Length > 0 Then
            lblL2TCon.Text = ConvertBinToStr(txtBuffL2Tcon, 0, 0)
        End If
        Thread.Sleep(100)

        Timer1.Start()

        Console.WriteLine("ReadAll END")

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs)

        Dim Stopwatch As New Stopwatch

        Stopwatch.Start()
        ''// Test Code
        ReadAll()
        'Dim txtBuffDev As String = ReadPortByAddress("0A",False) ' Device version register

        Stopwatch.Stop()
        Console.WriteLine("ELAPSED TIME :" + Stopwatch.Elapsed.ToString)
    End Sub



    Private Function SentToWriteOne(inp As Input, tryNumber As Integer) As Input

        Try
            SerialPort1.ReadTimeout = 10000
            SerialPort1.WriteTimeout = 10000
            Dim status As String = ""
            Dim strPart As String

            Dim first As Byte
            Dim second As Byte
            Dim third As Byte
            Dim fourth As Byte
            Dim fifth As Byte

            Dim writeBytes() As Byte

            If (inp.bitText.Length > 0) Then
                strPart = inp.bitText.Substring(0, 8)
                Dim x As Integer
                x = Convert.ToInt32(strPart, 2)
                inp.data1 = Hex(x)
                If (inp.bitText.Length > 8) Then
                    strPart = inp.bitText.Substring(8, 8)
                    x = Convert.ToInt32(strPart, 2)
                    inp.data2 = Hex(x)
                End If
            End If

            first = Convert.ToByte("22", 16)  ' 34 22 write
            second = Convert.ToByte(inp.address, 16)  'inp.address ' 16 adres
            third = Convert.ToByte(inp.amount, 16)    ' 2 kaç byte
            fourth = Convert.ToByte(inp.data1, 16)  ' 2
            If inp.amount = 2 Then
                fifth = Convert.ToByte(inp.data2, 16) ' 18'
            End If

            writeBytes = {first, second, third, fourth, fifth}

            Console.WriteLine("------------------>SerialPort1.Wite YAZMA:" + inp.name + "->" + first.ToString + " " + second.ToString + " " + third.ToString + " " + fourth.ToString + " " + fifth.ToString)

            SerialPort1.Write(writeBytes, 0, writeBytes.Length)

            If (SerialPort1_DataReceived(Convert.ToInt32(inp.amount)) = False) Then
                msjFlag = 2
            End If

            'Timer1.Enabled = False

            'For i = 1 To 3 '3sn
            '    Threading.Thread.Sleep(100)
            '    Application.DoEvents()
            'Next



            ' Timer1.Enabled = True

            Try
                Dim buff2(SerialPort1.BytesToRead) As Byte
                Dim bytesRead As Integer

                Dim def As String
                def = ""
                bytesRead = SerialPort1.Read(buff2, 0, buff2.Length)
                For Each val As Byte In buff2
                    def = def + " " + val.ToString
                Next

                If inp.amount = 2 Then
                    If (buff2(0) = fourth And buff2(1) = fifth) Then
                        inp.status = "S"
                    Else
                        inp.status = "F"
                    End If
                ElseIf inp.amount = 1 Then
                    If (buff2(0) = fourth) Then
                        inp.status = "S"
                    Else
                        inp.status = "F"
                    End If
                End If

                Console.WriteLine("------------------>SerialPort1.Read BUFF OKUMA 1:" + inp.name + "->" + def)
            Catch ex As Exception
                Console.WriteLine("------------------>SerialPort1.ReadLine BUFF OKUMA HATA:" + inp.name + " " + ex.Message)
                inp.status = "F"
            End Try
            Console.WriteLine("STATUS:" + inp.status + " " + inp.name + "try number ->" + tryNumber.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            inp.status = "F"

        End Try
        Return inp
    End Function

    Private Function WriteBulk(records As List(Of Input))
        Dim len As Integer = 0
        Dim input As Input
        Dim tryNumber As Integer
        'REPAIR
        Try
            If SerialPort1.IsOpen Then
                For Each input In records

                    tryNumber = 1

                    For tryNumber = 1 To 3
                        If (input.status = Nothing Or input.status = "F") Then
                            input = SentToWriteOne(input, tryNumber)
                        Else
                            Exit For
                        End If
                    Next

                    If (input.status = "F") Then
                        MessageBox.Show("Transmit Error! Please check the port connection and SEND again.")
                        Exit For
                    ElseIf (input.status = "S") Then
                        len = len + 1
                    End If
                Next

                If (len = records.Count) Then
                    MessageBox.Show("Successfully transmitted.")
                    lblActionStatus.Text = "The last program was sent " + Environment.NewLine + System.DateTime.Now
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Function

    Private Shared buffer As String = ""
    Private Function SerialPort1_DataReceived(length As Integer) As Boolean
        Dim return_key As Boolean = True

        Try
            Dim count As Integer = 0
            If SerialPort1.IsOpen Then
                While SerialPort1.BytesToRead < length
                    'Console.WriteLine("while" + count.ToString + "->" + SerialPort1.BytesToRead.ToString)
                    count += 1
                    If (count > 100000) Then
                        return_key = False
                        Exit While
                    End If
                End While
                ' Console.WriteLine("while" + count.ToString + "->" + SerialPort1.BytesToRead.ToString)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Return return_key
    End Function

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
            'If (strOfInt > 0) Then
            'Console.WriteLine(strOfInt)
            'End If
        End If
        Return strOfInt
    End Function

    Private Function CheckPortConnection() As Boolean
        If SerialPort1.IsOpen = False Then
            lblStatus.Text = "No port connection."
            SerialPort1.Close()
            Return False
        Else
            lblStatus.Text = "Port connection is successfull"
        End If
        Return True
    End Function



    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        btnSend.Enabled = False

        If (CheckPortConnection() = False) Then
            MessageBox.Show("Please check the port connection.")
            btnSend.Enabled = True
            Exit Sub
        End If

        GetLastStateBeforeSave()
        Dim M2CONstring As String = ""
        Dim sb1 As New System.Text.StringBuilder()

        For indexA = 15 To 0 Step -1
            sb1.Append(M2CON(indexA))
        Next indexA
        M2CONstring = sb1.ToString

        M2CONstring = Complete8BitPadLeft(M2CONstring)

        Dim L1CONstring As String = ""
        Dim sb2 As New System.Text.StringBuilder()
        For indexA = 15 To 0 Step -1
            sb2.Append(L1CON(indexA))
        Next indexA
        L1CONstring = sb2.ToString

        L1CONstring = Complete8BitPadLeft(L1CONstring)

        Dim L2CONstring As String = ""
        Dim sb3 As New System.Text.StringBuilder()
        For indexA = 15 To 0 Step -1
            sb3.Append(L2CON(indexA))
        Next indexA
        L2CONstring = sb3.ToString

        L2CONstring = Complete8BitPadLeft(L2CONstring)

        Dim DCRCONstring As String = ""
        Dim sb4 As New System.Text.StringBuilder()
        For indexA = 15 To 0 Step -1
            sb4.Append(DCR(indexA))
        Next indexA
        DCRCONstring = sb4.ToString

        DCRCONstring = Complete8BitPadLeft(DCRCONstring)

        Dim timeLine As String

        Dim Tfirst As String
        Tfirst = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble(cmbTFirst.Text) * 2 - 1), False)
        Tfirst = Tfirst.PadLeft(4, "0")

        Dim Ton As String
        Ton = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble((CmbTon.Text) * 2 - 1)), False)
        Ton = Ton.PadLeft(4, "0")

        Dim Toff As String
        Toff = ConvertIntegerToBinaryString(Convert.ToInt32(Convert.ToDouble((cmbToff.Text) * 2 - 1)), False)
        Toff = Toff.PadLeft(4, "0")

        Dim Ato As String
        Ato = ConvertIntegerToBinaryString(Convert.ToInt32(CmbTurnOff.Text), False)
        Ato = Ato.PadLeft(3, "0")

        timeLine = Ato + Ton + Toff + Tfirst
        TCON = Complete8BitPadLeft(timeLine)

        Dim records As List(Of Input) = New List(Of Input)

        'Dim input1 As Input = New Input()
        Dim input2 As Input = New Input()
        Dim input3 As Input = New Input()
        Dim input4 As Input = New Input()
        Dim input5 As Input = New Input()
        Dim input6 As Input = New Input()

        'input1.name = "M1Con"
        'input1.address = "10"
        'input1.amount = "02"
        'input1.bitText = "0000000000000001"

        input2.name = "M2Con"
        input2.address = "12" ' DEC: 18 HEX :12 
        input2.amount = "02"
        input2.bitText = M2CONstring

        input3.name = "L1Con"
        input3.address = "14" ' 20 HEX : 14
        input3.amount = "02"
        input3.bitText = L1CONstring

        input4.name = "L2Con"
        input4.address = "16" ' 22HEX :  16
        input4.amount = "02"
        input4.bitText = L2CONstring

        input5.name = "DCR"
        input5.address = "0E" '14HEX :  0E
        input5.amount = "02"
        input5.bitText = DCRCONstring

        input6.name = "TCON"
        input6.address = "0C" '12HEX : 0C
        input6.amount = "02"
        input6.bitText = TCON

        ' records.Add(input1)
        records.Add(input2)
        records.Add(input3)
        records.Add(input4)
        records.Add(input5)
        records.Add(input6)
        WriteBulk(records)
        btnSend.Enabled = True
    End Sub

    Private Sub btnRFP_Click(sender As Object, e As EventArgs) Handles btnRFP.Click
        If btnRFP.Text = "ON" Then
            btnRFP.Text = "OFF"
            btnRFP.BackColor = Color.Salmon

            'M2CON(0) = 0
        Else
            btnRFP.Text = "ON"
            btnRFP.BackColor = Color.LightGreen
            'M2CON(0) = 1
        End If
    End Sub

    Private Sub readTcon_Click(sender As Object, e As EventArgs)
        GetLastStateBeforeSave()
        MsgBox("TCON Bit Status; " +
                          TCON)
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReadDev()

        msjFlag = 0
        'While SerialPort1.IsOpen
        Console.WriteLine("ReadDev BEGIN")

        Dim txtBuffDev As String = ReadPortByAddress("0A", False) ' Device version register


        If (txtBuffDev Is Nothing Or txtBuffDev = "" Or txtBuffDev = "11111111111111111111111111111111") Then
            lblVs.Text = "Device not found."
            ClearDeviceProperty()
            ClearTimeProperty()

            Exit Sub
        End If

        ViewDeviceVersionRegister(txtBuffDev)
        'TEST gönder

        SendTest()
        System.Threading.Thread.Sleep(400)
        Console.WriteLine("ReadDev END")
        'End While

    End Sub

    Private Sub lblM1C_Click(sender As Object, e As EventArgs) Handles lblM1C.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Timer_Stop()
    End Sub

    Private Sub lblCell1Intensity_Click(sender As Object, e As EventArgs) Handles lblCell1Intensity.Click

    End Sub

    Private Sub btnLIGHT1_Click(sender As Object, e As EventArgs) Handles btnLIGHT1.Click

        If (CheckPortConnection() = False) Then
            MessageBox.Show("Please check the port connection.")
            Exit Sub
        End If
        If (btnLIGHT1.BackColor = Color.LightGray) Then
            TestOperation(2, 1)
            btnLIGHT1.BackColor = Color.LightGreen
        Else
            TestOperation(2, 0)
            btnLIGHT1.BackColor = Color.LightGray
        End If

    End Sub

    Private Sub TestOperation(bitOrder As Integer, onOff As Integer)
        TEST(bitOrder) = onOff
        Dim i As Integer
        Dim flag As Boolean = False
        For i = 0 To 6
            If (TEST(i) = "1") Then
                flag = True
                Exit For
            End If
        Next

        If (flag = False) Then
            TEST(7) = "0"
        Else
            TEST(7) = "1"
        End If

    End Sub

    Private Sub SendTest()
        Dim record As List(Of Input) = New List(Of Input)
        Dim tryNumber As Integer
        Dim input As Input = New Input
        input.address = "18"
        input.amount = 1
        input.name = "TEST"
        input.bitText = "00000000"

        Dim sb1 As New System.Text.StringBuilder()

        For indexA = 7 To 0 Step -1
            sb1.Append(TEST(indexA))
        Next indexA
        input.bitText = sb1.ToString

        input.bitText = Complete8BitPadLeft(input.bitText)

        Console.WriteLine("INPUT TEXT---------------------->" + input.bitText)

        'input.bitText = "10000100"
        Try
            'WriteBulk(record)
            'BAK Burayı otomatikleştirmek lazım

            If SerialPort1.IsOpen Then
                tryNumber = 1

                For tryNumber = 1 To 3
                    If (input.status = Nothing Or input.status = "F") Then
                        input = SentToWriteOne(input, tryNumber)
                    Else
                        Exit For
                    End If
                Next
                If (input.status = "F") Then
                    'btnMOTOR2.BackColor = Color.LightGray
                    MessageBox.Show("Transmit Error please SEND again.")
                Else
                    'btnMOTOR2.BackColor = Color.LightGreen
                End If
            End If
        Catch ex As Exception
            'btnMOTOR2.BackColor = Color.LightGray
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub btnMOTOR2_Click(sender As Object, e As EventArgs) Handles btnMOTOR2.Click

        If (CheckPortConnection() = False) Then
            MessageBox.Show("Please check the port connection.")
            Exit Sub
        End If
        If (btnMOTOR2.BackColor = Color.LightGray) Then
            TestOperation(1, 1)
            btnMOTOR2.BackColor = Color.LightGreen
        Else
            TestOperation(1, 0)
            btnMOTOR2.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnLIGHT2_Click(sender As Object, e As EventArgs) Handles btnLIGHT2.Click

        If (CheckPortConnection() = False) Then
            MessageBox.Show("Please check the port connection.")
            Exit Sub
        End If
        If (btnLIGHT2.BackColor = Color.LightGray) Then
            TestOperation(3, 1)
            btnLIGHT2.BackColor = Color.LightGreen
        Else
            TestOperation(3, 0)
            btnLIGHT2.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnAlarm_Click(sender As Object, e As EventArgs) Handles btnAlarm.Click

        If (CheckPortConnection() = False) Then
            MessageBox.Show("Please check the port connection.")
            Exit Sub
        End If
        If (btnAlarm.BackColor = Color.LightGray) Then
            TestOperation(4, 1)
            btnAlarm.BackColor = Color.LightGreen
        Else
            TestOperation(4, 0)
            btnAlarm.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub GetHistoric(lineNum As Integer, levelNum As Integer)

        If (lineNum = 1) Then

            'Dim M2CON() As Byte = ConvertBitStringToByteArray(testArray(1))

            If (levelNum = 1) Then

                'MOTOR2 Power On
                If M2CON(4) = "0" And M2CON(3) = "0" AndAlso M2CON(2) = "0" Then
                    btnMOTOR2pwrON.Text = "AUTO"
                    btnMOTOR2pwrON.BackColor = Color.Orange
                ElseIf M2CON(4) = "0" And M2CON(3) = "0" AndAlso M2CON(2) = "1" Then
                    btnMOTOR2pwrON.Text = "SYNC"
                    btnMOTOR2pwrON.BackColor = Color.Orange
                ElseIf M2CON(4) = "0" And M2CON(3) = "1" AndAlso M2CON(2) = "0" Then
                    btnMOTOR2pwrON.Text = "PEDAL"
                    btnMOTOR2pwrON.BackColor = Color.Orange
                ElseIf M2CON(4) = "0" And M2CON(3) = "1" AndAlso M2CON(2) = "1" Then
                    btnMOTOR2pwrON.Text = "RUN"
                    btnMOTOR2pwrON.BackColor = Color.LightGreen
                ElseIf M2CON(4) = "1" And M2CON(3) = "0" AndAlso M2CON(2) = "0" Then
                    btnMOTOR2pwrON.Text = "OFF"
                    btnMOTOR2pwrON.BackColor = Color.Salmon
                ElseIf M2CON(4) = "1" And M2CON(3) = "0" AndAlso M2CON(2) = "1" Then
                    btnMOTOR2pwrON.Text = ""
                    btnMOTOR2pwrON.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2) Then

                'Motor2 1.Press
                If M2CON(7) = "0" And M2CON(6) = "0" AndAlso M2CON(5) = "0" Then
                    btnMOTOR2_1Press.Text = "AUTO"
                    btnMOTOR2_1Press.BackColor = Color.Orange
                ElseIf M2CON(7) = "0" And M2CON(6) = "0" AndAlso M2CON(5) = "1" Then
                    btnMOTOR2_1Press.Text = "SYNC"
                    btnMOTOR2_1Press.BackColor = Color.Orange
                ElseIf M2CON(7) = "0" And M2CON(6) = "1" AndAlso M2CON(5) = "0" Then
                    btnMOTOR2_1Press.Text = "PEDAL"
                    btnMOTOR2_1Press.BackColor = Color.Orange
                ElseIf M2CON(7) = "0" And M2CON(6) = "1" AndAlso M2CON(5) = "1" Then
                    btnMOTOR2_1Press.Text = "RUN"
                    btnMOTOR2_1Press.BackColor = Color.LightGreen
                ElseIf M2CON(7) = "1" And M2CON(6) = "0" AndAlso M2CON(5) = "0" Then
                    btnMOTOR2_1Press.Text = "OFF"
                    btnMOTOR2_1Press.BackColor = Color.Salmon
                ElseIf M2CON(7) = "1" And M2CON(6) = "0" AndAlso M2CON(5) = "1" Then
                    btnMOTOR2_1Press.Text = ""
                    btnMOTOR2_1Press.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2 Or levelNum = 3) Then

                'Motor2 2.Press
                If M2CON(10) = "0" And M2CON(9) = "0" AndAlso M2CON(8) = "0" Then
                    btnMOTOR2_2Press.Text = "AUTO"
                    btnMOTOR2_2Press.BackColor = Color.Orange
                ElseIf M2CON(10) = "0" And M2CON(9) = "0" AndAlso M2CON(8) = "1" Then
                    btnMOTOR2_2Press.Text = "SYNC"
                    btnMOTOR2_2Press.BackColor = Color.Orange
                ElseIf M2CON(10) = "0" And M2CON(9) = "1" AndAlso M2CON(8) = "0" Then
                    btnMOTOR2_2Press.Text = "PEDAL"
                    btnMOTOR2_2Press.BackColor = Color.Orange
                ElseIf M2CON(10) = "0" And M2CON(9) = "1" AndAlso M2CON(8) = "1" Then
                    btnMOTOR2_2Press.Text = "RUN"
                    btnMOTOR2_2Press.BackColor = Color.LightGreen
                ElseIf M2CON(10) = "1" And M2CON(9) = "0" AndAlso M2CON(8) = "0" Then
                    btnMOTOR2_2Press.Text = "OFF"
                    btnMOTOR2_2Press.BackColor = Color.Salmon
                ElseIf M2CON(10) = "1" And M2CON(9) = "0" AndAlso M2CON(8) = "1" Then
                    btnMOTOR2_2Press.Text = ""
                    btnMOTOR2_2Press.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2 Or levelNum = 3 Or levelNum = 4) Then

                'Motor2 3.Press
                If M2CON(13) = "0" And M2CON(12) = "0" AndAlso M2CON(11) = "0" Then
                    btnMOTOR2_3Press.Text = "AUTO"
                    btnMOTOR2_3Press.BackColor = Color.Orange
                ElseIf M2CON(13) = "0" And M2CON(12) = "0" AndAlso M2CON(11) = "1" Then
                    btnMOTOR2_3Press.Text = "SYNC"
                    btnMOTOR2_3Press.BackColor = Color.Orange
                ElseIf M2CON(13) = "0" And M2CON(12) = "1" AndAlso M2CON(11) = "0" Then
                    btnMOTOR2_3Press.Text = "PEDAL"
                    btnMOTOR2_3Press.BackColor = Color.Orange
                ElseIf M2CON(13) = "0" And M2CON(12) = "1" AndAlso M2CON(11) = "1" Then
                    btnMOTOR2_3Press.Text = "RUN"
                    btnMOTOR2_3Press.BackColor = Color.LightGreen
                ElseIf M2CON(13) = "1" And M2CON(12) = "0" AndAlso M2CON(11) = "0" Then
                    btnMOTOR2_3Press.Text = "OFF"
                    btnMOTOR2_3Press.BackColor = Color.Salmon
                ElseIf M2CON(13) = "1" And M2CON(12) = "0" AndAlso M2CON(11) = "1" Then
                    btnMOTOR2_3Press.Text = ""
                    btnMOTOR2_3Press.BackColor = Color.LightGray
                End If

            End If

        End If

        If (lineNum = 2) Then

            'Dim L1CON() As Byte = ConvertBitStringToByteArray(testArray(2)) 'testArray(2).ToCharArray

            If (levelNum = 1) Then
                'LIGHT1 Power On
                If L1CON(4) = "0" And L1CON(3) = "0" AndAlso L1CON(2) = "0" Then
                    btnLIGHT1powerON.Text = "OFF"
                    btnLIGHT1powerON.BackColor = Color.Salmon
                ElseIf L1CON(4) = "0" And L1CON(3) = "0" AndAlso L1CON(2) = "1" Then
                    btnLIGHT1powerON.Text = "ON"
                    btnLIGHT1powerON.BackColor = Color.LightGreen
                ElseIf L1CON(4) = "0" And L1CON(3) = "1" AndAlso L1CON(2) = "0" Then
                    btnLIGHT1powerON.Text = "FLASH"
                    btnLIGHT1powerON.BackColor = Color.Orange
                ElseIf L1CON(4) = "0" And L1CON(3) = "1" AndAlso L1CON(2) = "1" Then
                    btnLIGHT1powerON.Text = ""
                    btnLIGHT1powerON.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2) Then

                'LIGHT1 1.Press
                If L1CON(7) = "0" And L1CON(6) = "0" AndAlso L1CON(5) = "0" Then
                    btnLIGHT1_1Press.Text = "OFF"
                    btnLIGHT1_1Press.BackColor = Color.Salmon
                ElseIf L1CON(7) = "0" And L1CON(6) = "0" AndAlso L1CON(5) = "1" Then
                    btnLIGHT1_1Press.Text = "ON"
                    btnLIGHT1_1Press.BackColor = Color.LightGreen
                ElseIf L1CON(7) = "0" And L1CON(6) = "1" AndAlso L1CON(5) = "0" Then
                    btnLIGHT1_1Press.Text = "FLASH"
                    btnLIGHT1_1Press.BackColor = Color.Orange
                ElseIf L1CON(7) = "0" And L1CON(6) = "1" AndAlso L1CON(5) = "1" Then
                    btnLIGHT1_1Press.Text = ""
                    btnLIGHT1_1Press.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2 Or levelNum = 3) Then
                'LIGHT1 2.Press
                If L1CON(10) = "0" And L1CON(9) = "0" AndAlso L1CON(8) = "0" Then
                    btnLIGHT1_2Press.Text = "OFF"
                    btnLIGHT1_2Press.BackColor = Color.Salmon
                ElseIf L1CON(10) = "0" And L1CON(9) = "0" AndAlso L1CON(8) = "1" Then
                    btnLIGHT1_2Press.Text = "ON"
                    btnLIGHT1_2Press.BackColor = Color.LightGreen
                ElseIf L1CON(10) = "0" And L1CON(9) = "1" AndAlso L1CON(8) = "0" Then
                    btnLIGHT1_2Press.Text = "FLASH"
                    btnLIGHT1_2Press.BackColor = Color.Orange
                ElseIf L1CON(10) = "0" And L1CON(9) = "1" AndAlso L1CON(8) = "1" Then
                    btnLIGHT1_2Press.Text = ""
                    btnLIGHT1_2Press.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2 Or levelNum = 3 Or levelNum = 4) Then

                'LIGHT1 3.Press
                If L1CON(13) = "0" And L1CON(12) = "0" AndAlso L1CON(11) = "0" Then
                    btnLIGHT1_3Press.Text = "OFF"
                    btnLIGHT1_3Press.BackColor = Color.Salmon
                ElseIf L1CON(13) = "0" And L1CON(12) = "0" AndAlso L1CON(11) = "1" Then
                    btnLIGHT1_3Press.Text = "ON"
                    btnLIGHT1_3Press.BackColor = Color.LightGreen
                ElseIf L1CON(13) = "0" And L1CON(12) = "1" AndAlso L1CON(11) = "0" Then
                    btnLIGHT1_3Press.Text = "FLASH"
                    btnLIGHT1_3Press.BackColor = Color.Orange
                ElseIf L1CON(13) = "0" And L1CON(12) = "1" AndAlso L1CON(11) = "1" Then
                    btnLIGHT1_3Press.Text = ""
                    btnLIGHT1_3Press.BackColor = Color.LightGray
                End If
            End If

        End If

        If (lineNum = 3) Then

            'Dim L2CON() As Byte = ConvertBitStringToByteArray(testArray(3)) 'testArray(3).ToCharArray

            If (levelNum = 1) Then
                'LIGHT2 Power On
                If L2CON(4) = "0" And L2CON(3) = "0" AndAlso L2CON(2) = "0" Then
                    btnLIGHT2powerON.Text = "OFF"
                    btnLIGHT2powerON.BackColor = Color.Salmon
                ElseIf L2CON(4) = "0" And L2CON(3) = "0" AndAlso L2CON(2) = "1" Then
                    btnLIGHT2powerON.Text = "ON"
                    btnLIGHT2powerON.BackColor = Color.LightGreen
                ElseIf L2CON(4) = "0" And L2CON(3) = "1" AndAlso L2CON(2) = "0" Then
                    btnLIGHT2powerON.Text = "FLASH"
                    btnLIGHT2powerON.BackColor = Color.Orange
                ElseIf L2CON(4) = "0" And L2CON(3) = "1" AndAlso L2CON(2) = "1" Then
                    btnLIGHT2powerON.Text = ""
                    btnLIGHT2powerON.BackColor = Color.LightGray
                End If
            End If

            If (levelNum = 1 Or levelNum = 2) Then
                'LIGHT2 1.Press
                If L2CON(7) = "0" And L2CON(6) = "0" AndAlso L2CON(5) = "0" Then
                    btnLIGHT2_1Press.Text = "OFF"
                    btnLIGHT2_1Press.BackColor = Color.Salmon
                ElseIf L2CON(7) = "0" And L2CON(6) = "0" AndAlso L2CON(5) = "1" Then
                    btnLIGHT2_1Press.Text = "ON"
                    btnLIGHT2_1Press.BackColor = Color.LightGreen
                ElseIf L2CON(7) = "0" And L2CON(6) = "1" AndAlso L2CON(5) = "0" Then
                    btnLIGHT2_1Press.Text = "FLASH"
                    btnLIGHT2_1Press.BackColor = Color.Orange
                ElseIf L2CON(7) = "0" And L2CON(6) = "1" AndAlso L2CON(5) = "1" Then
                    btnLIGHT2_1Press.Text = ""
                    btnLIGHT2_1Press.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2 Or levelNum = 3) Then
                'LIGHT2 2.Press
                If L2CON(10) = "0" And L2CON(9) = "0" AndAlso L2CON(8) = "0" Then
                    btnLIGHT2_2Press.Text = "OFF"
                    btnLIGHT2_2Press.BackColor = Color.Salmon
                ElseIf L2CON(10) = "0" And L2CON(9) = "0" AndAlso L2CON(8) = "1" Then
                    btnLIGHT2_2Press.Text = "ON"
                    btnLIGHT2_2Press.BackColor = Color.LightGreen
                ElseIf L2CON(10) = "0" And L2CON(9) = "1" AndAlso L2CON(8) = "0" Then
                    btnLIGHT2_2Press.Text = "FLASH"
                    btnLIGHT2_2Press.BackColor = Color.Orange
                ElseIf L2CON(10) = "0" And L2CON(9) = "1" AndAlso L2CON(8) = "1" Then
                    btnLIGHT2_2Press.Text = ""
                    btnLIGHT2_2Press.BackColor = Color.LightGray
                End If

            End If

            If (levelNum = 1 Or levelNum = 2 Or levelNum = 3 Or levelNum = 4) Then
                'LIGHT2 3.Press
                If L2CON(13) = "0" And L2CON(12) = "0" AndAlso L2CON(11) = "0" Then
                    btnLIGHT2_3Press.Text = "OFF"
                    btnLIGHT2_3Press.BackColor = Color.Salmon
                ElseIf L2CON(13) = "0" And L2CON(12) = "0" AndAlso L2CON(11) = "1" Then
                    btnLIGHT2_3Press.Text = "ON"
                    btnLIGHT2_3Press.BackColor = Color.LightGreen
                ElseIf L2CON(13) = "0" And L2CON(12) = "1" AndAlso L2CON(11) = "0" Then
                    btnLIGHT2_3Press.Text = "FLASH"
                    btnLIGHT2_3Press.BackColor = Color.Orange
                ElseIf L2CON(13) = "0" And L2CON(12) = "1" AndAlso L2CON(11) = "1" Then
                    btnLIGHT2_3Press.Text = ""
                    btnLIGHT2_3Press.BackColor = Color.LightGray
                End If
            End If
        End If

    End Sub

    Private Sub cmbPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPorts.SelectedIndexChanged
        'ports = IO.Ports.SerialPort.GetPortNames()
        ''varsa ekleme yoksa cıkar
        'For Each port In ports
        '    cmbPorts.Items.Add(port)
        '    'MsgBox(port, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Serial port detecetd")
        'Next port

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        btnRefresh.Enabled = False
        Timer_Stop()
        ReadAll()
        btnRefresh.Enabled = True
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim portFlag As Boolean = True
        portFlag = CheckPortConnection()
        If (portFlag) Then
            ReadDev()
            If (msjFlag = 1) Then
                lblStatus.Text = "Please check the connection."
                'msjFlag = -1
            End If
        Else
            'msjFlag = 1
            ClearDeviceProperty()
            ClearTimeProperty()
            'If (msjFlag = 0) Then
            '    lblStatus.Text = "Please check the connection."
            '    msjFlag = 1
            'End If


        End If
    End Sub

    Private Sub Timer_Stop()
        Timer1.Stop()
        'ClearDeviceProperty()
    End Sub


    Private Sub chbLock_CheckStateChanged(sender As Object, e As EventArgs) Handles chbLock.CheckStateChanged
        If (chbLock.Checked = True) Then
            gbLock.Enabled = False
        Else
            Dim result As DialogResult
            result = MessageBox.Show("Unlock the screen?", "Unlock Screen", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                chbLock.Checked = True
                gbLock.Enabled = False
            ElseIf result = DialogResult.Yes Then
                gbLock.Enabled = True
            End If
        End If

    End Sub

End Class
