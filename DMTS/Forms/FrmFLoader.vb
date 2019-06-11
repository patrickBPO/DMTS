Imports System.IO
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports DMTS.MySQLCom
Imports System.ComponentModel

Public Class FrmFLoader

    Dim open As New OpenFileDialog

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim cnt As Int16 = 0
    '    Dim lcnt As Int32 = 0

    '    Dim FH As String = Nothing '-- 1
    '    Dim CPD As String = Nothing '-- 2
    '    Dim DIV_NBR As String = Nothing '-- 3
    '    Dim TERMINAL_NBR As String = Nothing '-- 5
    '    Dim CURRENCY_CODE As String = Nothing '-- 8
    '    Dim AMOUNT As String = Nothing '-- 9
    '    Dim CARD_TYPE As String = Nothing '-- 10(Convert to Number)
    '    Dim TargetPath As String
    '    'Dim TargetFile As String
    '    'Dim TargetLine As String
    '    'Dim OutputPath As String
    '    Dim MainPath As String
    '    Dim UseInsStruct As InsStruct
    '    Dim Conn As New MySqlConnection
    '    Dim Comm As New MySqlCommand

    '    Conn.ConnectionString = "server=localhost;user id=dmtsuser;password=Dmtsuser@xs4db;
    '        persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3308;
    '        database=dmts;defaultcommandtimeout=180"

    '    MainPath = Strings.Left(open.FileName.ToString, Len(open.FileName) - Len(open.SafeFileName))

    '    '-- Extract the main path(e.g. C:\...
    '    'TargetFile = MainPath & "file.csv"
    '    'TargetFile = "file.csv"
    '    TargetPath = "Completed\"
    '    'OutputPath = "Output\"
    '    Dim MyFname As String = open.FileName
    '    Dim ValidPath As String = "^(?:[\w]\:|\\)(\\[A-Za-z]_\-\s0-9\.]{0,})+\.(txt|gif|pdf|doc|docx|xls|xlsx)$"
    '    Dim ReValidPath As New Regex(ValidPath)

    '    If MyFname = "" Then
    '        MyFname = TextBox1.Text.Trim
    '    End If
    '    'Dim Myfile As System.IO.StreamWriter
    '    'Myfile = My.Computer.FileSystem.OpenTextFileWriter(MainPath & TargetFile, True)
    '    'Myfile = My.Computer.FileSystem.OpenTextFileWriter(TargetFile, True)
    '    'Console.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
    '    '    "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")

    '    'Myfile.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
    '    '    "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")
    '    Try
    '        'If Not ReValidPath.IsMatch(TextBox1.Text) Then

    '        '    MsgBox("Please specify a valid file...", vbExclamation, "No File Specified")
    '        '    TextBox1.Focus()
    '        '    open.FileName = ""
    '        '    Myfile.Close()
    '        '    Exit Sub

    '        'End If
    '        Conn.Open()
    '        Comm.Connection = Conn
    '        Comm.CommandText = "INSERT INTO transactions (lt_rec_no,fh,trans_date,div_nbr,currency_code,amount,ct_rec_no) 
    '        VALUES (@lt_rec_no,@fh,@trans_date,@div_nbr,@currency_code,@amount,@ct_rec_no)"
    '        Comm.Prepare()
    '        Comm.Parameters.AddWithValue("@lt_rec_no", TERMINAL_NBR)
    '        Comm.Parameters.AddWithValue("@fh", FH)
    '        Comm.Parameters.AddWithValue("@trans_date", CPD)
    '        Comm.Parameters.AddWithValue("@div_nbr", DIV_NBR)
    '        Comm.Parameters.AddWithValue("@currency_code", CURRENCY_CODE)
    '        Comm.Parameters.AddWithValue("@amount", AMOUNT)
    '        Comm.Parameters.AddWithValue("@ct_rec_no", CARD_TYPE)

    '        For Each line As String In File.ReadLines(MyFname) ' Loop over lines in file.
    '            cnt = 1
    '            If lcnt > 0 Then
    '                Dim itm = Split(line, ",", -1) ' Display the item.
    '                For Each col In itm
    '                    'If cnt < 24 Then
    '                    '    'Console.Write(x.TrimEnd)
    '                    '    'Console.Write(",")

    '                    'Else
    '                    'Console.WriteLine(x.TrimEnd)
    '                    'End If

    '                    Select Case cnt
    '                        Case 1 '-- 3
    '                            FH = col.TrimEnd
    '                        Case 2 '-- 4
    '                            '-- Convert a string Date to a specified format
    '                            CPD = Format(DateTime.Parse(col.TrimEnd), "yyyy-MM-dd")
    '                        Case 3 '-- 5
    '                            DIV_NBR = col.TrimEnd
    '                        Case 5 '-- 2
    '                            TERMINAL_NBR = col.TrimEnd
    '                        Case 8 '-- 6
    '                            CURRENCY_CODE = col.TrimEnd
    '                        Case 9 '-- 7
    '                            AMOUNT = col.TrimEnd
    '                        Case 10 '-- 8
    '                            CARD_TYPE = GetCardType(col.TrimEnd)

    '                    End Select

    '                    cnt += 1
    '                Next

    '                UseInsStruct.TERMINAL_NBR = TERMINAL_NBR
    '                UseInsStruct.FH = FH
    '                UseInsStruct.CPD = CPD
    '                UseInsStruct.DIV_NBR = DIV_NBR
    '                UseInsStruct.CURRENCY_CODE = CURRENCY_CODE
    '                UseInsStruct.AMOUNT = AMOUNT
    '                UseInsStruct.CARD_TYPE = CARD_TYPE
    '                Try
    '                    'Comm.Parameters.AddWithValue("@lt_rec_no", TERMINAL_NBR)
    '                    'Comm.Parameters.AddWithValue("@fh", FH)
    '                    'Comm.Parameters.AddWithValue("@trans_date", CPD)
    '                    'Comm.Parameters.AddWithValue("@div_nbr", DIV_NBR)
    '                    'Comm.Parameters.AddWithValue("@currency_code", CURRENCY_CODE)
    '                    'Comm.Parameters.AddWithValue("@amount", AMOUNT)
    '                    'Comm.Parameters.AddWithValue("@ct_rec_no", CARD_TYPE)

    '                    Comm.Parameters("@lt_rec_no").Value = TERMINAL_NBR
    '                    Comm.Parameters("@fh").Value = FH
    '                    Comm.Parameters("@trans_date").Value = CPD
    '                    Comm.Parameters("@div_nbr").Value = DIV_NBR
    '                    Comm.Parameters("@currency_code").Value = CURRENCY_CODE
    '                    Comm.Parameters("@amount").Value = AMOUNT
    '                    Comm.Parameters("@ct_rec_no").Value = CARD_TYPE

    '                    If Not InsertTransPrep(Comm) Then
    '                        MsgBox("Record (" & lcnt & ") failed to load...", vbExclamation, "Insert Failed")
    '                        TextBox1.Focus()
    '                        open.FileName = ""
    '                        Conn.Close()
    '                        Exit Sub
    '                    Else
    '                        'Console.WriteLine("Records Entered (" & lcnt & ")")
    '                        TxtRecs.Clear()
    '                        TxtRecs.Text = lcnt
    '                        Me.Refresh()
    '                        'Console.Clear()
    '                    End If
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End Try

    '                'If Not InsertTransPrep(UseInsStruct, Conn) Then
    '                '    MsgBox("Record (" & lcnt & ") failed to load...", vbExclamation, "Insert Failed")
    '                '    TextBox1.Focus()
    '                '    open.FileName = ""
    '                '    Exit Sub
    '                'Else
    '                '    'Console.WriteLine("Records Entered (" & lcnt & ")")
    '                '    'Console.Clear()
    '                'End If

    '            End If
    '            'TargetLine = String.Concat(LastName, ",", FirstName, ",", Street, ",", City, ",",
    '            '              State, ",", CountryCode, ",", ZipCode, ",", Mnth, ",", Yr, ",",
    '            '              AccountNumber_1, ",", AccountType_1, ",", AccountNumber_2, ",",
    '            '              AccountType_2, ",", CardNo, ",", Email, ",", Cell)
    '            ''Myfile.WriteLine(LastName & "," & FirstName & "," & Street & "," & City & ",")
    '            'Myfile.WriteLine(TargetLine)
    '            lcnt += 1
    '        Next
    '    Catch ex As FileNotFoundException
    '        MsgBox(ex.Message, vbExclamation, "File Not Found")
    '        TextBox1.Focus()
    '        open.FileName = ""
    '        Conn.Close()
    '        'Myfile.Close()
    '        Exit Sub
    '    End Try

    '    Conn.Close()
    '    'Myfile.Close()
    '    '-- Move the TXT to the completed directory
    '    My.Computer.FileSystem.MoveFile(MyFname, MainPath & TargetPath & open.SafeFileName,
    '            FileIO.UIOption.AllDialogs,
    '            FileIO.UICancelOption.ThrowException)
    '    '-- Move the CSV to the output directory
    '    'My.Computer.FileSystem.MoveFile(MainPath & TargetFile, MainPath & OutputPath & TargetFile,
    '    '        FileIO.UIOption.AllDialogs,
    '    '        FileIO.UICancelOption.ThrowException)
    '    MsgBox("Loading(" & lcnt & ") Records Complete...Check [ " & MainPath & TargetPath & " ] for Processed Files", vbOK, "Loading Process Complete")
    '    TextBox1.Clear()
    '    open.FileName = ""
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''Dim open = OpenFileDialog1
    'open.Filter = "All Files|*.*"
    'open.ShowDialog()
    'TextBox1.Text = open.FileName
    ' End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Dim txtBx As TextBox = TryCast(sender, TextBox)
        If Not IsNothing(e.KeyValue) Then
            If txtBx.Text.Trim <> "" Then
                BtnLdFile.Enabled = True
            Else
                BtnLdFile.Enabled = False
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) > 0 And Trim(TextBox1.Text) <> "" Then
            BtnLdFile.Enabled = True
        Else
            BtnLdFile.Enabled = False
        End If
    End Sub

    Private Sub BtnFndFile_Click(sender As Object, e As EventArgs) Handles BtnFndFile.Click
        open.Filter = "All Files|*.*"
        open.ShowDialog()
        TextBox1.Text = open.FileName

    End Sub

    Private Sub BtnLdFile_Click(sender As Object, e As EventArgs) Handles BtnLdFile.Click
        Dim cnt As Int16 = 0
        Dim lcnt As Int32 = 0

        Dim FH As String = Nothing '-- 1
        Dim CPD As String = Nothing '-- 2
        Dim DIV_NBR As String = Nothing '-- 3
        Dim TERMINAL_NBR As String = Nothing '-- 5
        Dim CURRENCY_CODE As String = Nothing '-- 8
        Dim AMOUNT As String = Nothing '-- 9
        Dim CARD_TYPE As String = Nothing '-- 10(Convert to Number)
        Dim TargetPath As String
        'Dim TargetFile As String
        'Dim TargetLine As String
        'Dim OutputPath As String
        Dim MainPath As String
        Dim UseInsStruct As InsStruct
        Dim Conn As New MySqlConnection
        Dim Comm As New MySqlCommand

        Conn.ConnectionString = "server=localhost;user id=dmtsuser;password=Dmtsuser@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3308;
            database=dmts;defaultcommandtimeout=180"

        MainPath = Strings.Left(open.FileName.ToString, Len(open.FileName) - Len(open.SafeFileName))

        '-- Extract the main path(e.g. C:\...
        'TargetFile = MainPath & "file.csv"
        'TargetFile = "file.csv"
        TargetPath = "Completed\"
        'OutputPath = "Output\"
        Dim MyFname As String = open.FileName
        Dim ValidPath As String = "^(?:[\w]\:|\\)(\\[A-Za-z]_\-\s0-9\.]{0,})+\.(txt|gif|pdf|doc|docx|xls|xlsx)$"
        Dim ReValidPath As New Regex(ValidPath)

        If MyFname = "" Then
            MyFname = TextBox1.Text.Trim
        End If
        'Dim Myfile As System.IO.StreamWriter
        'Myfile = My.Computer.FileSystem.OpenTextFileWriter(MainPath & TargetFile, True)
        'Myfile = My.Computer.FileSystem.OpenTextFileWriter(TargetFile, True)
        'Console.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
        '    "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")

        'Myfile.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
        '    "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")
        Try
            'If Not ReValidPath.IsMatch(TextBox1.Text) Then

            '    MsgBox("Please specify a valid file...", vbExclamation, "No File Specified")
            '    TextBox1.Focus()
            '    open.FileName = ""
            '    Myfile.Close()
            '    Exit Sub

            'End If
            Conn.Open()
            Comm.Connection = Conn
            Comm.CommandText = "INSERT INTO transactions (lt_rec_no,fh,trans_date,div_nbr,currency_code,amount,ct_rec_no) 
            VALUES (@lt_rec_no,@fh,@trans_date,@div_nbr,@currency_code,@amount,@ct_rec_no)"
            Comm.Prepare()
            Comm.Parameters.AddWithValue("@lt_rec_no", TERMINAL_NBR)
            Comm.Parameters.AddWithValue("@fh", FH)
            Comm.Parameters.AddWithValue("@trans_date", CPD)
            Comm.Parameters.AddWithValue("@div_nbr", DIV_NBR)
            Comm.Parameters.AddWithValue("@currency_code", CURRENCY_CODE)
            Comm.Parameters.AddWithValue("@amount", AMOUNT)
            Comm.Parameters.AddWithValue("@ct_rec_no", CARD_TYPE)

            For Each line As String In File.ReadLines(MyFname) ' Loop over lines in file.
                cnt = 1
                If lcnt > 0 Then
                    Dim itm = Split(line, ",", -1) ' Display the item.
                    For Each col In itm

                        Select Case cnt
                            Case 1 '-- 3
                                FH = col.TrimEnd
                            Case 2 '-- 4
                                '-- Convert a string Date to a specified format
                                CPD = Format(DateTime.Parse(col.TrimEnd), "yyyy-MM-dd")
                            Case 3 '-- 5
                                DIV_NBR = col.TrimEnd
                            Case 5 '-- 2
                                TERMINAL_NBR = col.TrimEnd
                            Case 8 '-- 6
                                CURRENCY_CODE = col.TrimEnd
                            Case 9 '-- 7
                                AMOUNT = col.TrimEnd
                            Case 10 '-- 8
                                CARD_TYPE = GetCardType(col.TrimEnd)

                        End Select

                        cnt += 1
                    Next

                    UseInsStruct.TERMINAL_NBR = TERMINAL_NBR
                    UseInsStruct.FH = FH
                    UseInsStruct.CPD = CPD
                    UseInsStruct.DIV_NBR = DIV_NBR
                    UseInsStruct.CURRENCY_CODE = CURRENCY_CODE
                    UseInsStruct.AMOUNT = AMOUNT
                    UseInsStruct.CARD_TYPE = CARD_TYPE
                    Try

                        Comm.Parameters("@lt_rec_no").Value = TERMINAL_NBR
                        Comm.Parameters("@fh").Value = FH
                        Comm.Parameters("@trans_date").Value = CPD
                        Comm.Parameters("@div_nbr").Value = DIV_NBR
                        Comm.Parameters("@currency_code").Value = CURRENCY_CODE
                        Comm.Parameters("@amount").Value = AMOUNT
                        Comm.Parameters("@ct_rec_no").Value = CARD_TYPE

                        If Not InsertTransPrep(Comm) Then
                            MsgBox("Record (" & lcnt & ") failed to load...", vbExclamation, "Insert Failed")
                            TextBox1.Focus()
                            open.FileName = ""
                            Conn.Close()
                            Exit Sub
                        Else
                            'Console.WriteLine("Records Entered (" & lcnt & ")")
                            TxtRecs.Clear()
                            TxtRecs.Text = lcnt
                            Me.Refresh()
                            'Console.Clear()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End If
                'TargetLine = String.Concat(LastName, ",", FirstName, ",", Street, ",", City, ",",
                '              State, ",", CountryCode, ",", ZipCode, ",", Mnth, ",", Yr, ",",
                '              AccountNumber_1, ",", AccountType_1, ",", AccountNumber_2, ",",
                '              AccountType_2, ",", CardNo, ",", Email, ",", Cell)
                ''Myfile.WriteLine(LastName & "," & FirstName & "," & Street & "," & City & ",")
                'Myfile.WriteLine(TargetLine)
                lcnt += 1
            Next
        Catch ex As FileNotFoundException
            MsgBox(ex.Message, vbExclamation, "File Not Found")
            TextBox1.Focus()
            open.FileName = ""
            Conn.Close()
            'Myfile.Close()
            Exit Sub
        End Try

        Conn.Close()
        'Myfile.Close()
        '-- Move the TXT to the completed directory
        My.Computer.FileSystem.MoveFile(MyFname, MainPath & TargetPath & open.SafeFileName,
                FileIO.UIOption.AllDialogs,
                FileIO.UICancelOption.ThrowException)
        '-- Move the CSV to the output directory
        'My.Computer.FileSystem.MoveFile(MainPath & TargetFile, MainPath & OutputPath & TargetFile,
        '        FileIO.UIOption.AllDialogs,
        '        FileIO.UICancelOption.ThrowException)
        MsgBox("Loading(" & lcnt & ") Records Complete...Check [ " & MainPath & TargetPath & " ] for Processed Files", vbOK, "Loading Process Complete")
        TextBox1.Clear()
        open.FileName = ""

    End Sub

    Private Sub frmFLoader_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'FrmDMTSMain.Show()
    End Sub

    Private Sub frmFLoader_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'FrmDMTSMain.Hide()
    End Sub
End Class
