Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmHomeworkExponents
    Dim answer(5) As String
    Dim ans(5) As String

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
        If expRandNumber(0) = 1 Then
            answer(0) = ans(1)
            answer(3) = ans(0)
        ElseIf expRandNumber(0) = 2 Then
            answer(0) = ans(0)
        End If
        If expRandNumber(1) = 3 Then
            answer(1) = ans(3)
            answer(4) = ans(2)
        ElseIf expRandNumber(1) = 4 Then
            answer(1) = ans(2)
        End If
        If expRandNumber(2) = 5 Then
            answer(2) = ans(5)
            answer(5) = ans(4)
        ElseIf expRandNumber(2) = 6 Then
            answer(2) = ans(4)
        End If
        If txtQ1.Text = answer(0) Then
            gbQ1.Text = "Correct!"
            gbQ1.BackColor = Color.Green
        Else
            gbQ1.Text = "Wrong"
            gbQ1.BackColor = Color.Red
        End If
        If txtQ2.Text = answer(1) Then
            gbQ2.Text = "Correct!"
            gbQ2.BackColor = Color.Green
        Else
            gbQ2.Text = "Wrong"
            gbQ2.BackColor = Color.Red
        End If
        If txtQ3.Text = answer(2) Then
            gbQ3.Text = "Correct!"
            gbQ3.BackColor = Color.Green
        Else
            gbQ3.Text = "Wrong"
            gbQ3.BackColor = Color.Red
        End If
        If txtQ4.Text = answer(3) Then
            gbQ4.Text = "Correct!"
            gbQ4.BackColor = Color.Green
        Else
            gbQ4.Text = "Wrong"
            gbQ4.BackColor = Color.Red
        End If
        If txtQ5.Text = answer(4) Then
            gbQ5.Text = "Correct!"
            gbQ5.BackColor = Color.Green
        Else
            gbQ5.Text = "Wrong"
            gbQ5.BackColor = Color.Red
        End If
        If txtQ6.Text = answer(5) Then
            gbQ6.Text = "Correct!"
            gbQ6.BackColor = Color.Green
        Else
            gbQ6.Text = "Wrong"
            gbQ6.BackColor = Color.Red
        End If
    End Sub

    Private Sub frmHomeworkExponents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ans(0) = "1"
        ans(1) = "a^2x"
        ans(2) = "3t^2"
        ans(3) = "1/3"
        ans(4) = "0"
        ans(5) = "4"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Going back will cause you to lose all your current work on this page if you have not pressed 'mark'. Are you sure you want to continue?", vbYesNo, "Caution") = vbYes Then
            frmMain.Button3.Enabled = False
            frmMain.Button3.BackColor = Color.FromArgb(128, 255, 128)
            Me.Close()
            frmMain.Show()
        End If
    End Sub
End Class