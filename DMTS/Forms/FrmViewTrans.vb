Imports MySql.Data.MySqlClient
Public Class FrmViewTrans
    Dim MyConn As New MySqlConnection
    Dim MyComm As New MySqlCommand
    Dim MyDS As New DataSet


    Private Sub FrmViewTrans_Load(sender As Object, e As EventArgs) Handles Me.Load
        MyConn.ConnectionString = "server=localhost;user id=dmtsuser;password=Dmtsuser@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3308;
            database=dmts;defaultcommandtimeout=180"


    End Sub
End Class