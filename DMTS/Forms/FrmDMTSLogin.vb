Imports System.Data.Odbc
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FrmDMTSLogin
    Public LoginSucceeded As Boolean
    Dim MyConString As String = "DSN=dmts;"
    Dim MyConnection As New OdbcConnection(MyConString)
    Dim MyCommand As New OdbcCommand()
    Dim MyDataReader As OdbcDataReader
    Dim OpenDatabase As Boolean

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoginSucceeded = False
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click
        LoginUserName = TxtUserName.Text
        LoginUserPassword = TxtPassword.Text
        OpenDatabase = False

        If OpenDB() Then
            LoginSucceeded = True

            Me.Close()
        End If
    End Sub

    Private Function OpenDB() As Boolean
        Dim RecordCnt As Long

        RecordCnt = 0

        Try
            MyConnection.Open()

            MyCommand.Connection = MyConnection
            MyCommand.CommandText = "Select * from user_admin where user_name='" & LoginUserName & "' and password='" & LoginUserPassword & "'"

            ' Console.WriteLine("Total Rows:" & MyCommand.ExecuteScalar())


            MyDataReader = MyCommand.ExecuteReader
            While MyDataReader.Read
                RecordCnt = RecordCnt + 1

                Console.WriteLine("id = " &
                    CStr(MyDataReader("user_id")) & "  user_name = " &
                    CStr(MyDataReader("user_name")))
                Return True
            End While

            If RecordCnt = 1 Then
                MessageBox.Show("Username and password are correct")
                Return True
            ElseIf RecordCnt > 1 Then
                MessageBox.Show("Username and password are Duplicate")
                Return False
            Else
                MessageBox.Show("Username or password are not correct")
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Function

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
End Class
