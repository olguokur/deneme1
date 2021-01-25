
Imports System.IO

Module Module1
    Public btnMOTOR2onOFF_state As Integer
    Public btnLIGHT1onOFF_state As Integer
    Public btnLIGHT2onOFF_state As Integer
    Public btnMOTOR2pwrON_state As Integer
    Public btnMOTOR2_1Press_state As Integer
    Public btnMOTOR2_2Press_state As Integer
    Public btnMOTOR2_3Press_state As Integer
    Public btnLIGHT1powerON_state As Integer
    Public btnLIGHT1_1Press_state As Integer
    Public btnLIGHT1_2Press_state As Integer
    Public btnLIGHT1_3Press_state As Integer
    Public btnLIGHT2powerON_state As Integer
    Public btnLIGHT2_1Press_state As Integer
    Public btnLIGHT2_2Press_state As Integer
    Public btnLIGHT2_3Press_state As Integer
    Public btnNumberOfCells_state As Integer
    Public btnAlarm_Buzzer_Light_state As Integer
    Public lblDelay_state As Integer
    Public RadioButton_R_PEDAL_state As Integer
    Public RadioButton_F_SWITCH_state As Integer



End Module

Public Class Form1

    Private Sub btnMOTOR2onOFF_Click(sender As Object, e As EventArgs) Handles btnMOTOR2onOFF.Click
        If btnMOTOR2onOFF.Text = "ON" Then
            btnMOTOR2onOFF.Text = "OFF"
            btnMOTOR2onOFF.BackColor = Color.LightGray
        Else
            btnMOTOR2onOFF.Text = "ON"
            btnMOTOR2onOFF.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub btnLIGHT1onOFF_Click(sender As Object, e As EventArgs) Handles btnLIGHT1onOFF.Click
        If btnLIGHT1onOFF.Text = "ON" Then
            btnLIGHT1onOFF.Text = "OFF"
            btnLIGHT1onOFF.BackColor = Color.LightGray
        Else
            btnLIGHT1onOFF.Text = "ON"
            btnLIGHT1onOFF.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub btnLIGHT2onOFF_Click(sender As Object, e As EventArgs) Handles btnLIGHT2onOFF.Click
        If btnLIGHT2onOFF.Text = "ON" Then
            btnLIGHT2onOFF.Text = "OFF"
            btnLIGHT2onOFF.BackColor = Color.LightGray
        Else
            btnLIGHT2onOFF.Text = "ON"
            btnLIGHT2onOFF.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub btnMOTOR2pwrON_Click(sender As Object, e As EventArgs) Handles btnMOTOR2pwrON.Click
        If btnMOTOR2pwrON.Text = "AUTO" Then
            btnMOTOR2pwrON.Text = "SYNC"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf btnMOTOR2pwrON.Text = "SYNC" Then
            btnMOTOR2pwrON.Text = "PEDAL"
            btnMOTOR2pwrON.BackColor = Color.Orange
        ElseIf btnMOTOR2pwrON.Text = "PEDAL" Then
            btnMOTOR2pwrON.Text = "RUN"
            btnMOTOR2pwrON.BackColor = Color.LightGreen
        ElseIf btnMOTOR2pwrON.Text = "RUN" Then
            btnMOTOR2pwrON.Text = "OFF"
            btnMOTOR2pwrON.BackColor = Color.Red
        ElseIf btnMOTOR2pwrON.Text = "OFF" Then
            btnMOTOR2pwrON.Text = "AUTO"
            btnMOTOR2pwrON.BackColor = Color.Orange
        End If
    End Sub

    Private Sub btnMOTOR2_1Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_1Press.Click
        If btnMOTOR2_1Press.Text = "AUTO" Then
            btnMOTOR2_1Press.Text = "SYNC"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf btnMOTOR2_1Press.Text = "SYNC" Then
            btnMOTOR2_1Press.Text = "PEDAL"
            btnMOTOR2_1Press.BackColor = Color.Orange
        ElseIf btnMOTOR2_1Press.Text = "PEDAL" Then
            btnMOTOR2_1Press.Text = "RUN"
            btnMOTOR2_1Press.BackColor = Color.LightGreen
        ElseIf btnMOTOR2_1Press.Text = "RUN" Then
            btnMOTOR2_1Press.Text = "OFF"
            btnMOTOR2_1Press.BackColor = Color.Red
        ElseIf btnMOTOR2_1Press.Text = "OFF" Then
            btnMOTOR2_1Press.Text = ""
            btnMOTOR2_1Press.BackColor = Color.LightGray
        ElseIf btnMOTOR2_1Press.Text = "" Then
            btnMOTOR2_1Press.Text = "AUTO"
            btnMOTOR2_1Press.BackColor = Color.Orange
        End If
    End Sub

    Private Sub btnMOTOR2_2Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_2Press.Click
        If btnMOTOR2_2Press.Text = "AUTO" Then
            btnMOTOR2_2Press.Text = "SYNC"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf btnMOTOR2_2Press.Text = "SYNC" Then
            btnMOTOR2_2Press.Text = "PEDAL"
            btnMOTOR2_2Press.BackColor = Color.Orange
        ElseIf btnMOTOR2_2Press.Text = "PEDAL" Then
            btnMOTOR2_2Press.Text = "RUN"
            btnMOTOR2_2Press.BackColor = Color.LightGreen
        ElseIf btnMOTOR2_2Press.Text = "RUN" Then
            btnMOTOR2_2Press.Text = "OFF"
            btnMOTOR2_2Press.BackColor = Color.Red
        ElseIf btnMOTOR2_2Press.Text = "OFF" Then
            btnMOTOR2_2Press.Text = ""
            btnMOTOR2_2Press.BackColor = Color.LightGray
        ElseIf btnMOTOR2_2Press.Text = "" Then
            btnMOTOR2_2Press.Text = "AUTO"
            btnMOTOR2_2Press.BackColor = Color.Orange
        End If
    End Sub

    Private Sub btnMOTOR2_3Press_Click(sender As Object, e As EventArgs) Handles btnMOTOR2_3Press.Click
        If btnMOTOR2_3Press.Text = "AUTO" Then
            btnMOTOR2_3Press.Text = "SYNC"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf btnMOTOR2_3Press.Text = "SYNC" Then
            btnMOTOR2_3Press.Text = "PEDAL"
            btnMOTOR2_3Press.BackColor = Color.Orange
        ElseIf btnMOTOR2_3Press.Text = "PEDAL" Then
            btnMOTOR2_3Press.Text = "RUN"
            btnMOTOR2_3Press.BackColor = Color.LightGreen
        ElseIf btnMOTOR2_3Press.Text = "RUN" Then
            btnMOTOR2_3Press.Text = "OFF"
            btnMOTOR2_3Press.BackColor = Color.Red
        ElseIf btnMOTOR2_3Press.Text = "OFF" Then
            btnMOTOR2_3Press.Text = ""
            btnMOTOR2_3Press.BackColor = Color.LightGray
        ElseIf btnMOTOR2_3Press.Text = "" Then
            btnMOTOR2_3Press.Text = "AUTO"
            btnMOTOR2_3Press.BackColor = Color.Orange
        End If
    End Sub

    Private Sub btnLIGHT1powerON_Click(sender As Object, e As EventArgs) Handles btnLIGHT1powerON.Click
        If btnLIGHT1powerON.Text = "OFF" Then
            btnLIGHT1powerON.Text = "ON"
            btnLIGHT1powerON.BackColor = Color.LightGreen
        ElseIf btnLIGHT1powerON.Text = "ON" Then
            btnLIGHT1powerON.Text = "FLASH"
            btnLIGHT1powerON.BackColor = Color.Orange
        ElseIf btnLIGHT1powerON.Text = "FLASH" Then
            btnLIGHT1powerON.Text = "OFF"
            btnLIGHT1powerON.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnLIGHT1_1Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_1Press.Click
        If btnLIGHT1_1Press.Text = "OFF" Then
            btnLIGHT1_1Press.Text = "ON"
            btnLIGHT1_1Press.BackColor = Color.LightGreen
        ElseIf btnLIGHT1_1Press.Text = "ON" Then
            btnLIGHT1_1Press.Text = "FLASH"
            btnLIGHT1_1Press.BackColor = Color.Orange
        ElseIf btnLIGHT1_1Press.Text = "FLASH" Then
            btnLIGHT1_1Press.Text = ""
            btnLIGHT1_1Press.BackColor = Color.LightGray
        ElseIf btnLIGHT1_1Press.Text = "" Then
            btnLIGHT1_1Press.Text = "OFF"
            btnLIGHT1_1Press.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnLIGHT2powerON_Click(sender As Object, e As EventArgs) Handles btnLIGHT2powerON.Click
        If btnLIGHT2powerON.Text = "OFF" Then
            btnLIGHT2powerON.Text = "ON"
            btnLIGHT2powerON.BackColor = Color.LightGreen
        ElseIf btnLIGHT2powerON.Text = "ON" Then
            btnLIGHT2powerON.Text = "FLASH"
            btnLIGHT2powerON.BackColor = Color.Orange
        ElseIf btnLIGHT2powerON.Text = "FLASH" Then
            btnLIGHT2powerON.Text = "OFF"
            btnLIGHT2powerON.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnLIGHT2_1Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_1Press.Click
        If btnLIGHT2_1Press.Text = "OFF" Then
            btnLIGHT2_1Press.Text = "ON"
            btnLIGHT2_1Press.BackColor = Color.LightGreen
        ElseIf btnLIGHT2_1Press.Text = "ON" Then
            btnLIGHT2_1Press.Text = "FLASH"
            btnLIGHT2_1Press.BackColor = Color.Orange
        ElseIf btnLIGHT2_1Press.Text = "FLASH" Then
            btnLIGHT2_1Press.Text = ""
            btnLIGHT2_1Press.BackColor = Color.LightGray
        ElseIf btnLIGHT2_1Press.Text = "" Then
            btnLIGHT2_1Press.Text = "OFF"
            btnLIGHT2_1Press.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnNumberOfCells_Click(sender As Object, e As EventArgs) Handles btnNumberOfCells.Click
        If btnNumberOfCells.Text = "1" Then
            btnNumberOfCells.Text = "2"
            btnNumberOfCells.BackColor = Color.LightGray
        ElseIf btnNumberOfCells.Text = "2" Then
            btnNumberOfCells.Text = "1"
            btnNumberOfCells.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub btnAlarm_Buzzer_Light_Click(sender As Object, e As EventArgs) Handles btnAlarm_Buzzer_Light.Click
        If btnAlarm_Buzzer_Light.Text = "BUZZER" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 1" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
        ElseIf btnAlarm_Buzzer_Light.Text = "BUZZER+LIGHT 2" Then
            btnAlarm_Buzzer_Light.Text = "OFF"
            btnAlarm_Buzzer_Light.BackColor = Color.Red
        ElseIf btnAlarm_Buzzer_Light.Text = "OFF" Then
            btnAlarm_Buzzer_Light.Text = "BUZZER"
            btnAlarm_Buzzer_Light.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub btnLIGHT1_2Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_2Press.Click
        If btnLIGHT1_2Press.Text = "OFF" Then
            btnLIGHT1_2Press.Text = "ON"
            btnLIGHT1_2Press.BackColor = Color.LightGreen
        ElseIf btnLIGHT1_2Press.Text = "ON" Then
            btnLIGHT1_2Press.Text = "FLASH"
            btnLIGHT1_2Press.BackColor = Color.Orange
        ElseIf btnLIGHT1_2Press.Text = "FLASH" Then
            btnLIGHT1_2Press.Text = ""
            btnLIGHT1_2Press.BackColor = Color.LightGray
        ElseIf btnLIGHT1_2Press.Text = "" Then
            btnLIGHT1_2Press.Text = "OFF"
            btnLIGHT1_2Press.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnLIGHT1_3Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT1_3Press.Click
        If btnLIGHT1_3Press.Text = "OFF" Then
            btnLIGHT1_3Press.Text = "ON"
            btnLIGHT1_3Press.BackColor = Color.LightGreen
        ElseIf btnLIGHT1_3Press.Text = "ON" Then
            btnLIGHT1_3Press.Text = "FLASH"
            btnLIGHT1_3Press.BackColor = Color.Orange
        ElseIf btnLIGHT1_3Press.Text = "FLASH" Then
            btnLIGHT1_3Press.Text = ""
            btnLIGHT1_3Press.BackColor = Color.LightGray
        ElseIf btnLIGHT1_3Press.Text = "" Then
            btnLIGHT1_3Press.Text = "OFF"
            btnLIGHT1_3Press.BackColor = Color.Red
        End If

    End Sub

    Private Sub btnLIGHT2_2Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_2Press.Click
        If btnLIGHT2_2Press.Text = "OFF" Then
            btnLIGHT2_2Press.Text = "ON"
            btnLIGHT2_2Press.BackColor = Color.LightGreen
        ElseIf btnLIGHT2_2Press.Text = "ON" Then
            btnLIGHT2_2Press.Text = "FLASH"
            btnLIGHT2_2Press.BackColor = Color.Orange
        ElseIf btnLIGHT2_2Press.Text = "FLASH" Then
            btnLIGHT2_2Press.Text = ""
            btnLIGHT2_2Press.BackColor = Color.LightGray
        ElseIf btnLIGHT2_2Press.Text = "" Then
            btnLIGHT2_2Press.Text = "OFF"
            btnLIGHT2_2Press.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnLIGHT2_3Press_Click(sender As Object, e As EventArgs) Handles btnLIGHT2_3Press.Click
        If btnLIGHT2_3Press.Text = "OFF" Then
            btnLIGHT2_3Press.Text = "ON"
            btnLIGHT2_3Press.BackColor = Color.LightGreen
        ElseIf btnLIGHT2_3Press.Text = "ON" Then
            btnLIGHT2_3Press.Text = "FLASH"
            btnLIGHT2_3Press.BackColor = Color.Orange
        ElseIf btnLIGHT2_3Press.Text = "FLASH" Then
            btnLIGHT2_3Press.Text = ""
            btnLIGHT2_3Press.BackColor = Color.LightGray
        ElseIf btnLIGHT2_3Press.Text = "" Then
            btnLIGHT2_3Press.Text = "OFF"
            btnLIGHT2_3Press.BackColor = Color.Red
        End If
    End Sub
End Class
