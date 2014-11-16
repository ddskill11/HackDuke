Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmExponents
    Dim rand As New Random
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim firstQHint As String
    Dim ans(5) As String
    Dim answer(2) As String
    Dim marked As Boolean
    Dim SQL As New SQLControl
    Dim correct(2) As Integer
    Dim mark As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Going back will cause you to lose all your current work on this page if you have not pressed 'mark'. Are you sure you want to continue?", vbYesNo, "Caution") = vbYes Then
            If marked = True Then
                frmMain.Button3.Enabled = True
                frmMain.btnExponents.Enabled = False
                frmMain.btnExponents.BackColor = Color.FromArgb(128, 255, 128)
            End If
            Me.Close()
            frmMain.Show()
        End If
    End Sub

    Private Sub frmExponents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        expRandNumber(0) = rand.Next(1, 3)
        expRandNumber(1) = rand.Next(3, 5)
        expRandNumber(2) = rand.Next(5, 7)

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = " & expRandNumber(0) & ""
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        While lrd.Read()
            lblQ1.Text = lrd("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = " & expRandNumber(0) & ""
        Dim lrd1 As SqlDataReader = cmd.ExecuteReader()
        While lrd1.Read()
            pbQ1.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrd1("Picture") & ".png")
        End While
        con.Close()

        If expRandNumber(0) = 1 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = 2"
            Dim lrdHwk As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk.Read()
                frmHomeworkExponents.lblQ1.Text = lrdHwk("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = 2"
            Dim lrdHwk1 As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk1.Read()
                frmHomeworkExponents.pbQ1.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrdHwk1("Picture") & ".png")
            End While
            con.Close()
        Else
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = 1"
            Dim lrdHwk As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk.Read()
                frmHomeworkExponents.lblQ1.Text = lrdHwk("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = 1"
            Dim lrdHwk1 As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk1.Read()
                frmHomeworkExponents.pbQ1.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrdHwk1("Picture") & ".png")
            End While
            con.Close()
        End If

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = " & expRandNumber(1) & ""
        Dim lrd2 As SqlDataReader = cmd.ExecuteReader()
        While lrd2.Read()
            lblQ2.Text = lrd2("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = " & expRandNumber(1) & ""
        Dim lrd3 As SqlDataReader = cmd.ExecuteReader()
        While lrd3.Read()
            pbQ2.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrd3("Picture") & ".png")
        End While
        con.Close()

        If expRandNumber(1) = 3 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = 4"
            Dim lrdHwk As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk.Read()
                frmHomeworkExponents.lblQ2.Text = lrdHwk("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = 4"
            Dim lrdHwk1 As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk1.Read()
                frmHomeworkExponents.pbQ2.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrdHwk1("Picture") & ".png")
            End While
            con.Close()
        Else
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = 3"
            Dim lrdHwk As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk.Read()
                frmHomeworkExponents.lblQ2.Text = lrdHwk("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = 3"
            Dim lrdHwk1 As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk1.Read()
                frmHomeworkExponents.pbQ2.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrdHwk1("Picture") & ".png")
            End While
            con.Close()
        End If

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = " & expRandNumber(2) & ""
        Dim lrd4 As SqlDataReader = cmd.ExecuteReader()
        While lrd4.Read()
            lblQ3.Text = lrd4("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = " & expRandNumber(2) & ""
        Dim lrd5 As SqlDataReader = cmd.ExecuteReader()
        While lrd5.Read()
            pbQ3.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrd5("Picture") & ".png")
        End While
        con.Close()
        If expRandNumber(2) = 5 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = 6"
            Dim lrdHwk As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk.Read()
                frmHomeworkExponents.lblQ3.Text = lrdHwk("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = 6"
            Dim lrdHwk1 As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk1.Read()
                frmHomeworkExponents.pbQ3.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrdHwk1("Picture") & ".png")
            End While
            con.Close()
        Else
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = 5"
            Dim lrdHwk As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk.Read()
                frmHomeworkExponents.lblQ3.Text = lrdHwk("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = 5"
            Dim lrdHwk1 As SqlDataReader = cmd.ExecuteReader()
            While lrdHwk1.Read()
                frmHomeworkExponents.pbQ3.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrdHwk1("Picture") & ".png")
            End While
            con.Close()
        End If

        ans(0) = "1"
        ans(1) = "a^2x"
        ans(2) = "3t^2"
        ans(3) = "1/3"
        ans(4) = "0"
        ans(5) = "4"
    End Sub

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
        If expRandNumber(0) = 1 Then
            answer(0) = ans(0)
        ElseIf expRandNumber(0) = 2 Then
            answer(0) = ans(1)
        End If
        If expRandNumber(1) = 3 Then
            answer(1) = ans(2)
        ElseIf expRandNumber(1) = 4 Then
            answer(1) = ans(3)
        End If
        If expRandNumber(2) = 5 Then
            answer(2) = ans(4)
        ElseIf expRandNumber(2) = 6 Then
            answer(2) = ans(5)
        End If
        If txtQ1.Text = answer(0) Then
            gbQ1.Text = "Correct!"
            gbQ1.BackColor = Color.Green
            correct(0) = 1
            mark += 1
        Else
            gbQ1.Text = "Wrong"
            gbQ1.BackColor = Color.Red
            correct(0) = 0
            frmHomeworkExponents.lblQ4.Visible = True
            frmHomeworkExponents.txtQ4.Visible = True
            frmHomeworkExponents.pbQ4.Visible = True
            frmHomeworkExponents.gbQ4.Visible = True
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = " & expRandNumber(0) & ""
            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            While lrd.Read()
                frmHomeworkExponents.lblQ4.Text = lrd("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = " & expRandNumber(0) & ""
            Dim lrd1 As SqlDataReader = cmd.ExecuteReader()
            While lrd1.Read()
                frmHomeworkExponents.pbQ4.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrd1("Picture") & ".png")
            End While
            con.Close()
        End If
        If txtQ2.Text = answer(1) Then
            gbQ2.Text = "Correct!"
            gbQ2.BackColor = Color.Green
            correct(1) = 1
            mark += 1
        Else
            gbQ2.Text = "Wrong"
            gbQ2.BackColor = Color.Red
            correct(1) = 0
            frmHomeworkExponents.lblQ5.Visible = True
            frmHomeworkExponents.txtQ5.Visible = True
            frmHomeworkExponents.pbQ5.Visible = True
            frmHomeworkExponents.gbQ5.Visible = True
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = " & expRandNumber(1) & ""
            Dim lrd2 As SqlDataReader = cmd.ExecuteReader()
            While lrd2.Read()
                frmHomeworkExponents.lblQ5.Text = lrd2("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = " & expRandNumber(1) & ""
            Dim lrd3 As SqlDataReader = cmd.ExecuteReader()
            While lrd3.Read()
                frmHomeworkExponents.pbQ5.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrd3("Picture") & ".png")
            End While
            con.Close()
        End If
        If txtQ3.Text = answer(2) Then
            gbQ3.Text = "Correct!"
            gbQ3.BackColor = Color.Green
            correct(2) = 1
            mark += 1
        Else
            gbQ3.Text = "Wrong"
            gbQ3.BackColor = Color.Red
            correct(2) = 0
            frmHomeworkExponents.lblQ6.Visible = True
            frmHomeworkExponents.txtQ6.Visible = True
            frmHomeworkExponents.pbQ6.Visible = True
            frmHomeworkExponents.gbQ6.Visible = True
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Exponents WHERE ID = " & expRandNumber(2) & ""
            Dim lrd4 As SqlDataReader = cmd.ExecuteReader()
            While lrd4.Read()
                frmHomeworkExponents.lblQ6.Text = lrd4("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Exponents WHERE ID = " & expRandNumber(2) & ""
            Dim lrd5 As SqlDataReader = cmd.ExecuteReader()
            While lrd5.Read()
                frmHomeworkExponents.pbQ6.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Exponents\" & lrd5("Picture") & ".png")
            End While
            con.Close()
        End If
        If SQL.HasConnection = True Then
            If correct(0) = 1 And expRandNumber(0) = 1 Then
                SQL.RunQuery("UPDATE Exponents SET Result= 1 WHERE ID=1")
            ElseIf correct(0) = 1 And expRandNumber(0) = 2 Then
                SQL.RunQuery("UPDATE Exponents SET Result= 1 WHERE ID=2")
            End If

            If correct(1) = 1 And expRandNumber(1) = 3 Then
                SQL.RunQuery("UPDATE Exponents SET Result= 1 WHERE ID=3")
            ElseIf correct(1) = 1 And expRandNumber(1) = 4 Then
                SQL.RunQuery("UPDATE Exponents SET Result= 1 WHERE ID=4")
            End If

            If correct(2) = 1 And expRandNumber(2) = 5 Then
                SQL.RunQuery("UPDATE Exponents SET Result= 1 WHERE ID=5")
            ElseIf correct(2) = 1 And expRandNumber(2) = 6 Then
                SQL.RunQuery("UPDATE Exponents SET Result= 1 WHERE ID=6")
            End If
        End If
        If mark = 3 Then
            MsgBox("Wow! You got perfect Congrats!")
        Else
            MsgBox("Your score was " & mark & "/3.")
        End If
        marked = True
        btnMark.Enabled = False
    End Sub
End Class