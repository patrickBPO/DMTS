Imports MySql.Data.MySqlClient
Public Class FrmViewTrans
    Dim MyConn As New MySqlConnection
    Dim MyComm As New MySqlCommand
    Dim MyDS As New DataSet


    Private Sub FrmViewTrans_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'TransactionsDS.transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.TransactionsDS.transactions)
        MyConn.ConnectionString = "server=localhost;user id=dmtsuser;password=Dmtsuser@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3308;
            database=dmts;defaultcommandtimeout=180"


    End Sub
End Class