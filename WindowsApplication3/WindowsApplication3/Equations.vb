Public Class frmEquations

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        If MsgBox("Going back will cause you to lose all your current work on this page if you have not pressed 'mark'. Are you sure you want to continue?", vbYesNo, "Caution") = vbYes Then
            Me.Close()
            frmMain.Show()
        End If
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Going back will cause you to lose all your current work on this page if you have not pressed 'mark'. Are you sure you want to continue?", vbYesNo, "Caution") = vbYes Then
            Me.Close()
            frmMain.Show()
        End If
    End Sub
End Class