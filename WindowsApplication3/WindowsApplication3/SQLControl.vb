Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    Public SQLCon As New SQLCONNECTION With {.ConnectionString = "Server=q997wiw9u8.database.windows.net;Database=Test1;User=test12;Pwd=PassWord12"}
    Public SQLCmd As SqlCommand

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()

            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLCon.Open()

            SQLCmd = New SqlCommand(Query, SQLCon)
            SQLCmd.ExecuteReader()

            'Dim R As SqlDataReader = SQLCmd.ExecuteReader

            'While R.Read
            'Form1.Label1.Text = R.GetName(0) & ": " & R(0)
            'End While

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
