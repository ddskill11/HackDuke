
Public Class frmHomeworkFunctions
    Dim answer(5) As String
    Dim ans(7) As String

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
       


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

    Private Sub frmHomeworkFunctions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ans(0) = "(-infinity,6]"
        ans(1) = "(1/5,infinity)"
        ans(2) = "(0,1),(-1,0),increasing"
        ans(3) = "(0,2),(-3,0),increasing"
        ans(4) = "(-3/4)x"
        ans(5) = "x>=0"
        ans(6) = "3^x"
    End Sub
End Class