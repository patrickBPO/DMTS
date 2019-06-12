


Public Class FrmDMTSMain
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Me.Text = “My First VB2017 Program”
        'Me.BackColor = Color.Cyan
        'Me.MaximizeBox = False
        'Me.MinimizeBox = True
        ''Specifying the form size to 400pixel x 400pixel
        'Me.Size = New Size(400, 400)
        ''To set the form opacity at 85%
        'Me.Opacity = 0.85
        ''To position the form at the center of the screen
        'Me.CenterToParent()



        'connect to mysql database
        'Dim MyConString As String = "DRIVER={MySQL ODBC 3.51};" +
        '"SERVER=SERVER;" +
        '"DATABASE=pasmaster;" +
        '"UID=PAYC;" +
        '"PASSWORD=PAYC@xs4db;"

        'Dim MyConString As String = "DSN=paymaster; SERVER=SERVER;DATABASE=paymaster;UID=PAYC;PASSWORD=PAYC@xs4db;"
        'Dim MyConnection As New OdbcConnection(MyConString)

        'Try
        '    MyConnection.Open()
        '    'MsgBox(MyConnection.State.ToString)
        '    Console.WriteLine("Connection State::" & MyConnection.State.ToString)

        '    Dim MyCommand As New OdbcCommand()
        '    MyCommand.Connection = MyConnection

        '    MyCommand.CommandText = "SELECT count(*) FROM user_admin"
        '    Console.WriteLine("Total Rows:" & MyCommand.ExecuteScalar())

        '    MyCommand.CommandText = "SELECT * FROM user_admin"
        '    Dim MyDataReader As OdbcDataReader
        '    MyDataReader = MyCommand.ExecuteReader
        '    While MyDataReader.Read

        '        Console.WriteLine("id = " &
        '            CStr(MyDataReader("user_id")) & "  user_name = " &
        '            CStr(MyDataReader("user_name")))

        '    End While

        'Catch ex As Exception
        'Console.WriteLine(ex.ToString)
        'End Try
    End Sub

    Private Sub CmdOpenForm_Click(sender As Object, e As EventArgs)


    End Sub





    Private Sub ReferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferencesToolStripMenuItem.Click

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub ViewEditTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEditTransactionsToolStripMenuItem.Click
        FrmViewTrans.Show()
    End Sub

    Private Sub FileLoaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileLoaderToolStripMenuItem.Click
        FrmFLoader.Show()
    End Sub

    Private Sub FileConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileConverterToolStripMenuItem.Click
        FrmFParser.Show()
    End Sub

    Private Sub DistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistrictToolStripMenuItem.Click
        FrmDistrict.Show()
    End Sub

    Private Sub CountryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountryToolStripMenuItem.Click
        FrmCountry.Show()
    End Sub

    Private Sub CardTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardTypeToolStripMenuItem.Click
        FrmCardType.Show()
    End Sub

    Private Sub MerchantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerchantToolStripMenuItem.Click
        FrmMerchant.Show()
    End Sub

    Private Sub CityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CityToolStripMenuItem.Click
        FrmCity.Show()
    End Sub
End Class
