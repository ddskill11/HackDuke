Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmFunctions
    Dim rand As New Random
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim firstQHint As String
    Dim ans(8) As String
    Dim answer(4) As String
    Dim marked As Boolean
    Dim SQL As New SQLControl
    Dim mark As Integer

    Private Sub frmFunctions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcRandNumber(0) = rand.Next(1, 3)
        funcRandNumber(1) = rand.Next(3, 6)
        funcRandNumber(2) = rand.Next(8, 10)

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = " & funcRandNumber(0) & ""
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        While lrd.Read()
            lblQ1.Text = lrd("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = " & funcRandNumber(0) & ""
        Dim lrd1 As SqlDataReader = cmd.ExecuteReader()
        While lrd1.Read()
            pbQ1.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & lrd1("Picture") & ".jpg")
        End While
        con.Close()

        If funcRandNumber(0) = 1 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 2"
            Dim hwklrd As SqlDataReader = cmd.ExecuteReader()
            While hwklrd.Read()
                frmHomeworkFunctions.lblQ1.Text = hwklrd("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 2"
            Dim hwklrd1 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd1.Read()
                frmHomeworkFunctions.pbQ1.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwklrd1("Picture") & ".jpg")
            End While
            con.Close()
        Else
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 1"
            Dim hwklrd As SqlDataReader = cmd.ExecuteReader()
            While hwklrd.Read()
                frmHomeworkFunctions.lblQ1.Text = hwklrd("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 1"
            Dim hwklrd1 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd1.Read()
                frmHomeworkFunctions.pbQ1.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwklrd1("Picture") & ".jpg")
            End While
            con.Close()
        End If

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = " & funcRandNumber(1) & ""
        Dim lrd2 As SqlDataReader = cmd.ExecuteReader()
        While lrd2.Read()
            lblQ2.Text = lrd2("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = " & funcRandNumber(1) & ""
        Dim lrd3 As SqlDataReader = cmd.ExecuteReader()
        While lrd3.Read()
            pbQ2.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & lrd3("Picture") & ".png")
        End While
        con.Close()

        If funcRandNumber(1) = 3 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 4 "
            Dim hwklrd2 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd2.Read()
                frmHomeworkFunctions.lblQ2.Text = hwklrd2("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 4"
            Dim hwklrd3 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd3.Read()
                frmHomeworkFunctions.pbQ2.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwklrd3("Picture") & ".png")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 5 "
            Dim hwkflrd2 As SqlDataReader = cmd.ExecuteReader()
            While hwkflrd2.Read()
                frmHomeworkFunctions.lblQ3.Text = hwkflrd2("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 5"
            Dim hwkflrd3 As SqlDataReader = cmd.ExecuteReader()
            While hwkflrd3.Read()
                frmHomeworkFunctions.pbQ3.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwkflrd3("Picture") & ".png")
            End While
            con.Close()
        ElseIf funcRandNumber(1) = 4 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 5 "
            Dim hwkflrd2 As SqlDataReader = cmd.ExecuteReader()
            While hwkflrd2.Read()
                frmHomeworkFunctions.lblQ2.Text = hwkflrd2("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 5"
            Dim hwkflrd3 As SqlDataReader = cmd.ExecuteReader()
            While hwkflrd3.Read()
                frmHomeworkFunctions.pbQ2.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwkflrd3("Picture") & ".png")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 3"
            Dim hwklrd2 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd2.Read()
                frmHomeworkFunctions.lblQ3.Text = hwklrd2("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 3"
            Dim hwklrd3 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd3.Read()
                frmHomeworkFunctions.pbQ3.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwklrd3("Picture") & ".png")
            End While
            con.Close()

        ElseIf funcRandNumber(1) = 5 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 3"
            Dim hwklrd2 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd2.Read()
                frmHomeworkFunctions.lblQ2.Text = hwklrd2("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 3"
            Dim hwklrd3 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd3.Read()
                frmHomeworkFunctions.pbQ2.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwklrd3("Picture") & ".png")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 4 "
            Dim hwkflrd2 As SqlDataReader = cmd.ExecuteReader()
            While hwkflrd2.Read()
                frmHomeworkFunctions.lblQ3.Text = hwkflrd2("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 4"
            Dim hwkflrd3 As SqlDataReader = cmd.ExecuteReader()
            While hwkflrd3.Read()
                frmHomeworkFunctions.pbQ3.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwkflrd3("Picture") & ".png")
            End While
            con.Close()

        End If

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 6"
        Dim lrd4 As SqlDataReader = cmd.ExecuteReader()
        While lrd4.Read()
            lblQ3.Text = lrd4("qHint")
            frmHomeworkFunctions.lblQ4.Text = lrd4("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 6"
        Dim lrd5 As SqlDataReader = cmd.ExecuteReader()
        While lrd5.Read()
            pbQ3.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & lrd5("Picture") & ".png")
            frmHomeworkFunctions.pbQ4.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & lrd5("Picture") & ".png")
        End While
        con.Close()



        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 7"
        Dim lrd6 As SqlDataReader = cmd.ExecuteReader()
        While lrd6.Read()
            lblQ4.Text = lrd6("qHint")
            frmHomeworkFunctions.lblQ5.Text = lrd6("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = 7"
        Dim lrd7 As SqlDataReader = cmd.ExecuteReader()
        While lrd7.Read()
            pbQ4.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & lrd7("Picture") & ".png")
            frmHomeworkFunctions.pbQ5.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & lrd7("Picture") & ".png")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = " & funcRandNumber(2) & ""
        Dim lrd8 As SqlDataReader = cmd.ExecuteReader()
        While lrd8.Read()
            lblQ5.Text = lrd8("qHint")
        End While
        con.Close()

        con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Picture FROM Functions WHERE ID = " & funcRandNumber(2) & ""
        Dim lrd9 As SqlDataReader = cmd.ExecuteReader()
        While lrd9.Read()
            pbQ5.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & lrd9("Picture") & ".png")
        End While
        con.Close()

        If funcRandNumber(2) = 8 Then
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 9"
            Dim hwklrd8 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd8.Read()
                frmHomeworkFunctions.lblQ6.Text = hwklrd8("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID =9"
            Dim hwklrd9 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd9.Read()
                frmHomeworkFunctions.pbQ6.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwklrd9("Picture") & ".png")
            End While
            con.Close()
        Else
            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT qHint FROM Functions WHERE ID = 8"
            Dim hwklrd8 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd8.Read()
                frmHomeworkFunctions.lblQ6.Text = hwklrd8("qHint")
            End While
            con.Close()

            con.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT Picture FROM Functions WHERE ID =8"
            Dim hwklrd9 As SqlDataReader = cmd.ExecuteReader()
            While hwklrd9.Read()
                frmHomeworkFunctions.pbQ6.Image = Image.FromFile("C:\Users\David\Documents\GitHub\HackDuke\WindowsApplication3\Question pictures\Functions\" & hwklrd9("Picture") & ".png")
            End While
            con.Close()
        End If


        ans(0) = "(-infinity,6]"
        ans(1) = "(1/5,infinity)"
        ans(2) = "(0,1),(-1,0),increasing"
        ans(3) = "(0,2),(-3,0),increasing"
        ans(4) = "(-3/4)x"
        ans(5) = "x>=0"
        ans(6) = "3^x"
        ans(7) = "2cosx"
        ans(8) = "sinx+1"
    End Sub

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
        If funcRandNumber(0) = 1 Then
            answer(0) = ans(0)
        ElseIf funcRandNumber(0) = 2 Then
            answer(0) = ans(1)
        End If

        If funcRandNumber(1) = 3 Then
            answer(1) = ans(2)
        ElseIf funcRandNumber(1) = 4 Then
            answer(1) = ans(3)
        ElseIf funcRandNumber(1) = 5 Then
            answer(1) = ans(4)
        End If

        answer(2) = ans(5)
        answer(3) = ans(6)

        If funcRandNumber(2) = 8 Then
            answer(4) = ans(7)
        ElseIf funcRandNumber(2) = 9 Then
            answer(4) = ans(8)
        End If

        If txtQ1.Text = answer(0) Then
            gbQ1.Text = "Correct!"
            gbQ1.BackColor = Color.Green
            mark += 1
        Else
            gbQ1.Text = "Wrong"
            gbQ1.BackColor = Color.Red
        End If

        If txtQ2.Text = answer(1) Then
            gbQ2.Text = "Correct!"
            gbQ2.BackColor = Color.Green
            mark += 1
        Else
            gbQ2.Text = "Wrong"
            gbQ2.BackColor = Color.Red
        End If

        If txtQ3.Text = answer(2) Then
            gbQ3.Text = "Correct!"
            gbQ3.BackColor = Color.Green
            mark += 1
        Else
            gbQ3.Text = "Wrong"
            gbQ3.BackColor = Color.Red
        End If

        If txtQ4.Text = answer(3) Then
            gbQ4.Text = "Correct!"
            gbQ4.BackColor = Color.Green
            mark += 1
        Else
            gbQ4.Text = "Wrong"
            gbQ4.BackColor = Color.Red
        End If

        If txtQ5.Text = answer(4) Then
            gbQ5.Text = "Correct!"
            gbQ5.BackColor = Color.Green
            mark += 1
        Else
            gbQ5.Text = "Wrong"
            gbQ5.BackColor = Color.Red
        End If
        If mark = 5 Then
            MsgBox("Wow! You got perfect Congrats!")
        Else
            MsgBox("Your score was " & mark & "/5.")
        End If
        marked = True
        btnMark.Enabled = False
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Going back will cause you to lose all your current work on this page if you have not pressed 'mark'. Are you sure you want to continue?", vbYesNo, "Caution") = vbYes Then
            If marked = True Then
                frmMain.Button4.Enabled = True
                frmMain.btnFunctions.Enabled = False
            End If
            Me.Close()
            frmMain.Show()
        End If
    End Sub

    Private Sub pbQ4_Click(sender As Object, e As EventArgs) Handles pbQ4.Click
        
    End Sub
End Class