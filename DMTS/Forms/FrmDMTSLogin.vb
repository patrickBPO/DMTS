Imports System.Data
Imports System.Data.Odbc
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports DMTS.MySQLCom

Public Class FrmDMTSLogin
    Public LoginSucceeded As Boolean
    'Dim MyConString As String = "DSN=dmts;"
    'Dim MyConnection As New OdbcConnection(MyConString)
    'Dim MyCommand As New OdbcCommand()
    'Dim MyDataReader As OdbcDataReader
    'Dim OpenDatabase As Boolean

    'Dim MyConString As String = "server=local;user id=DMTS;password=dmts@xs4db;
    '        persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3306;
    '        database=dmts;defaultcommandtimeout=180"

    'Dim MyConnection As New MySqlConnection(MyConString)
    'Dim MyCommand As New MySqlCommand()
    Dim MyDataReader As MySqlDataReader
    Dim OpenDatabase As Boolean

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SNameDS.s_name' table. You can move, or remove it, as needed.
        Me.S_nameTableAdapter.Fill(Me.SNameDS.s_name)
        LoginSucceeded = False
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click
        Dim txtName As String
        LoginUserName = TxtUserName.Text
        LoginUserPassword = TxtPassword.Text
        OpenDatabase = False
        TxtSname.Visible = True
        txtName = TxtSname.Text
        GlbSName = txtName
        TxtSname.Visible = False
        If Trim(txtName) = "" Then
            CheckServerText(True)
            TxtSname.Focus()
        Else
            CheckServerText(False)
            If Not CheckServerName(txtName) Then
                If OpenDB() Then
                    AddServerName()
                    LoginSucceeded = True
                    Me.Close()
                Else
                    CheckServerText(True)
                    TxtSname.Text = ""
                    TxtSname.Focus()
                End If
            Else
                'CheckServerText(True)
                'TxtSname.Focus()
                LoginSucceeded = True
                Me.Close()
            End If

        End If
    End Sub
    Private Sub CheckServerText(ByVal DispFlag As Boolean)
        If DispFlag = True Then
            LblSname.Visible = True
            TxtSname.Visible = True
        Else
            LblSname.Visible = False
            TxtSname.Visible = False
        End If
    End Sub
    Private Function CheckServerName(ByVal Tname As String) As Boolean
        Dim ClInt As Int16
        Dim MyConn As New MySqlConnection("server=" & Tname & ";user id=DMTS;password=dmts@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3306;
            database=dmts;defaultcommandtimeout=180")
        Dim MyCCmd As New MySqlCommand("select COUNT(*) as c_c_stat from s_name where TRIM(description) = " & Trim(Tname), MyConn)
        ClInt = 0
        Try
            MyConn.Open()
        Catch ex As Exception
            Return False
        End Try
        Try
            Dim Urdr1 As MySqlDataReader = MyCCmd.ExecuteReader

            While Urdr1.Read
                ClInt = Urdr1("c_c_stat").ToString

            End While
            Urdr1.Close()
            MyConn.Close()

        Catch ex As Exception
            Return False
            MyConn.Close()
        End Try

        If ClInt > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub AddServerName()
        'Me.Validate()
        ''Me.SnameBindingSource.EndEdit()
        'Me.S_nameTableAdapter.Update(Me.SNameDS.s_name)
        Dim MyConString As String = "server=" & Trim(TxtSname.Text) & ";user id=DMTS;password=dmts@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3306;
            database=dmts;defaultcommandtimeout=180"

        Dim MyConnection As New MySqlConnection(MyConString)
        Dim MyCommand As New MySqlCommand()


        Try
            If MyConnection.State = ConnectionState.Closed Then
                'MyConnection.ConnectionString = MyConString
                Try
                    MyConnection.Open()

                Catch ex As Exception
                    Console.WriteLine("MySQL Connection Error...Check if Host Name/IP is valid")

                End Try
            End If
            MyCommand.Connection = MyConnection
            MyCommand.CommandText = "INSERT INTO s_name(description) VALUES('" & Trim(TxtSname.Text) & "')"

            MyCommand.ExecuteNonQuery()


        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            MyConnection.Close()
        End Try
    End Sub

    Private Function OpenDB() As Boolean
        Dim RecordCnt As Long

        Dim MyConString As String = "server=" & Trim(TxtSname.Text) & ";user id=DMTS;password=dmts@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3306;
            database=dmts;defaultcommandtimeout=180"

        Dim MyConnection As New MySqlConnection(MyConString)
        Dim MyCommand As New MySqlCommand()

        RecordCnt = 0

        Try
            If MyConnection.State = ConnectionState.Closed Then
                'MyConnection.ConnectionString = MyConString
                Try
                    MyConnection.Open()

                Catch ex As Exception
                    Console.WriteLine("MySQL Connection Error...Check if Host Name/IP is valid")
                    Return False

                End Try
            End If
            MyCommand.Connection = MyConnection
            MyCommand.CommandText = "Select * from user_admin where ua_user_name='" & LoginUserName & "' and ua_password=md5('" & LoginUserPassword & "')"

            ' Console.WriteLine("Total Rows:" & MyCommand.ExecuteScalar())

            MyDataReader = MyCommand.ExecuteReader
            While MyDataReader.Read
                RecordCnt = RecordCnt + 1

                Console.WriteLine("id = " &
                    CStr(MyDataReader("ua_rec_no")) & "  ua_user_name = " &
                    CStr(MyDataReader("ua_user_name")))
                Return True
            End While

            MyDataReader.Close()

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
            MyConnection.Close()
            Return False
        End Try
    End Function

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
End Class
