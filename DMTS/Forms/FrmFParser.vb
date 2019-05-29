Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions

Public Class FrmFParser

    Dim open As New OpenFileDialog
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    'Dim LastName As String = Nothing '-- 1,4
    '    'Dim FirstName As String = Nothing '-- 2,null
    '    'Dim Street As String = Nothing  '-- 3,12
    '    'Dim City As String = Nothing '-- 4,14
    '    'Dim State As String = Nothing  '-- 5,BZE
    '    'Dim CountryCode As String = Nothing  '-- 6,null
    '    'Dim ZipCode As String = Nothing  '-- 7,null
    '    'Dim Mnth As String = Nothing  '-- 8,6
    '    'Dim Yr As String = Nothing ' -- 9,6
    '    'Dim MthYrSplit As String = Nothing  '-- Split,6
    '    'Dim AccountNumber_1 As String = Nothing  '-- 10,null
    '    'Dim AccountType_1 As String = Nothing  '-- 11,null
    '    'Dim AccountNumber_2 As String = Nothing  '-- 12,null
    '    'Dim AccountType_2 As String = Nothing  '-- 13,null
    '    'Dim CardNo As String = Nothing '-- 14,3
    '    'Dim Email As String = Nothing  '-- 15,null
    '    'Dim Cell As String = Nothing  '-- 16,null

    '    Dim sr As New StreamReader("c:\Debit format.txt")
    '    'Dim pattern As String = "^(?<a>.{11}),(?<b>.{16}),(?<cardno>.{19}),(?<LastName>.{22})," &
    '    '        "(?<c>.{80})(?<MthYrSplit>.{6})(?<d>.{4})(?<e>.{82})(?<f>.{40})(?<g>.{11})(?<h>.{11})" &
    '    '        "(?<street>.{41})(?<i>.{41})(?<CitySplit>.{81})(?<State>.{41})(?<j>.{2})(?<k>.{27})" &
    '    '        "(?<l>.{14})(?<m>.{41})(?<n>.{3})(?<o>.{2})(?<p>.{4})(?<q>.{3})(?<last>.+)$"

    '    Dim pattern As String = "^\s*(?<a>.*)\s*,(?<b>.*)\s*,(?<cardno>.*)\s*,(?<LastName>.*)\s*," &
    '            "(?<c>.*)\s*,(?<MthYrSplit>.*)\s*,(?<d>.*)\s*,(?<e>.*)\s*,(?<f>.*)\s*,(?<g>.*)\s*,(?<h>.*)\s*," &
    '            "(?<street>.*)\s*,(?<i>.*)\s*,(?<CitySplit>.*)\s*,(?<State>.*)\s*,(?<j>.*)\s*,(?<k>.*)\s*," &
    '            "(?<l>.*)\s*,(?<m>.*)\s*,(?<n>.*)\s*,(?<o>.*)\s*,(?<p>.*)\s*,(?<q>.*)\s*,(?<last>.*)\s*$"

    '    Dim re As New Regex(pattern)
    '    Console.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
    '        "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")
    '    Do While sr.Peek <> -1

    '        Dim ma As Match = re.Match(sr.ReadLine())
    '        Console.Write(Trim(ma.Groups("LastName").Value.TrimEnd()))
    '        Console.Write("NULL,")
    '        Console.Write(ma.Groups("street").Value.TrimEnd())
    '        Console.Write(ma.Groups("CitySplit").Value.TrimEnd())
    '        Console.Write("BZE,")
    '        Console.Write("NULL,")
    '        Console.Write("NULL,")
    '        Console.Write(ma.Groups("MthYrSplit").Value.TrimEnd()) '-- Month
    '        Console.Write("Year,") '-- Year
    '        Console.Write("NULL,")
    '        Console.Write("NULL,")
    '        Console.Write("NULL,")
    '        Console.Write("NULL,")
    '        Console.Write(ma.Groups("cardno").Value.TrimEnd())
    '        Console.Write("NULL,")
    '        Console.WriteLine(space(0))
    '    Loop

    '    sr.Close()

    '    '-- Easier Way Below Not!!!
    '    'Dim currentRow As String()
    '    'Dim currentField As String
    '    'Dim currentRec As String
    '    'Dim currentLine As String

    '    'Dim cntr As Int16
    '    'Dim LastName As String = Nothing '-- 1,4
    '    'Dim FirstName As String = Nothing '-- 2,null
    '    'Dim Street As String = Nothing  '-- 3,12
    '    'Dim City As String = Nothing '-- 4,14
    '    'Dim State As String = Nothing  '-- 5,BZE
    '    'Dim CountryCode As String = Nothing  '-- 6,null
    '    'Dim ZipCode As String = Nothing  '-- 7,null
    '    'Dim Mnth As String = Nothing  '-- 8,6
    '    'Dim Yr As String = Nothing ' -- 9,6
    '    'Dim MthYrSplit As String = Nothing  '-- Split,6
    '    'Dim AccountNumber_1 As String = Nothing  '-- 10,null
    '    'Dim AccountType_1 As String = Nothing  '-- 11,null
    '    'Dim AccountNumber_2 As String = Nothing  '-- 12,null
    '    'Dim AccountType_2 As String = Nothing  '-- 13,null
    '    'Dim CardNo As String = Nothing '-- 14,3
    '    'Dim Email As String = Nothing  '-- 15,null
    '    'Dim Cell As String = Nothing  '-- 16,null

    '    'cntr = 0
    '    'Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Debit format.txt")
    '    '    MyReader.TextFieldType = FileIO.FieldType.Delimited
    '    '    MyReader.SetDelimiters(",")
    '    '    For Each line As String In File.ReadLines("C:\Debit format.txt")
    '    '        Console.WriteLine(LastName & "|" & FirstName & "|" & Street & "|" & City & "|" & State)
    '    '        Console.WriteLine(line)
    '    '    Next
    '    '    While Not MyReader.EndOfData
    '    '        Try
    '    '            currentRow = MyReader.ReadFields()

    '    '            For Each currentField In currentRow
    '    '                cntr += 1
    '    '                Select Case cntr
    '    '                    Case 3 '-- 14
    '    '                        CardNo = currentField
    '    '                    Case 4 '-- 1
    '    '                        LastName = currentField
    '    '                    Case 6 '-- 8 & 9
    '    '                        MthYrSplit = currentField
    '    '                        Mnth = "" '-- 8
    '    '                        Yr = "" '-- 9
    '    '                    Case 12 '-- 3
    '    '                        Street = currentField
    '    '                    Case 14 '-- 4
    '    '                        City = currentField
    '    '                        'Case 24
    '    '                        'MsgBox(LastName & "|" & FirstName & "|" & Street & "|" & City & "|" & State & Environment.NewLine & "yes")
    '    '                    Case Else
    '    '                        FirstName = space(0) '-- 2
    '    '                        State = "BZE" '-- 5
    '    '                        CountryCode = space(0) '-- 6
    '    '                        ZipCode = space(0) '-- 7
    '    '                        AccountNumber_1 = space(0) '-- 10
    '    '                        AccountType_1 = space(0) '-- 11
    '    '                        AccountNumber_2 = space(0) '-- 12
    '    '                        AccountType_2 = space(0) '-- 13
    '    '                        Email = space(0) '-- 15
    '    '                        Cell = space(0) '-- 16
    '    '                End Select
    '    '                'MsgBox(currentField & Environment.NewLine & cntr)
    '    '            Next
    '    '        Catch ex As Microsoft.VisualBasic.
    '    '                    FileIO.MalformedLineException
    '    '            MsgBox("Line " & ex.Message &
    '    '        "is not valid and will be skipped.")
    '    '        End Try
    '    '    End While
    '    '    'MsgBox(LastName & "|" & FirstName & "|" & Street & "|" & City & "|" & State)
    '    '    ' MyReader.ReadLine()
    '    '    'MsgBox(LastName & "|" & FirstName & "|" & Street & "|" & City & "|" & State)
    '    'End Using
    '    'Do While sr.Peek <> -1
    '    '    Dim ma As Match = re.Match(sr.ReadLine())
    '    '    Console.Write("First name = " &
    '    'ma.Groups("first").Value.TrimEnd())
    '    '    Console.Write(", Last name = " &
    '    'ma.Groups("last").Value.TrimEnd())
    '    '    Console.WriteLine(", City= " &
    '    'ma.Groups("city").Value.TrimEnd())
    '    'Loop

    'End Sub

    ' Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    'Dim cnt As Int16 = 0

    'Dim LastName As String = Nothing '-- 1,4
    'Dim FirstName As String = Nothing '-- 2,null
    'Dim Street As String = Nothing  '-- 3,12
    'Dim City As String = Nothing '-- 4,14
    'Dim State As String = Nothing  '-- 5,BZE
    'Dim CountryCode As String = Nothing  '-- 6,null
    'Dim ZipCode As String = Nothing  '-- 7,null
    'Dim Mnth As String = Nothing  '-- 8,6
    'Dim Yr As String = Nothing ' -- 9,6
    'Dim MthYrSplit As String = Nothing  '-- Split,6
    'Dim AccountNumber_1 As String = Nothing  '-- 10,null
    'Dim AccountType_1 As String = Nothing  '-- 11,null
    'Dim AccountNumber_2 As String = Nothing  '-- 12,null
    'Dim AccountType_2 As String = Nothing  '-- 13,null
    'Dim CardNo As String = Nothing '-- 14,3
    'Dim Email As String = Nothing  '-- 15,null
    'Dim Cell As String = Nothing  '-- 16,null
    'Dim TargetPath As String
    'Dim TargetFile As String
    'Dim TargetLine As String
    'Dim OutputPath As String
    'Dim MainPath As String

    'MainPath = Strings.Left(open.FileName.ToString, Len(open.FileName) - Len(open.SafeFileName))

    ''-- Extract the main path(e.g. C:\...
    ''TargetFile = MainPath & "file.csv"
    'TargetFile = "file.csv"
    'TargetPath = "Completed\"
    'OutputPath = "Output\"
    'Dim MyFname As String = open.FileName
    ''Dim ValidPath As String = "^(?:[\w]\:|\\)(\\_\-\s0-9\.]{0,})+\.(txt|gif|pdf|doc|docx|xls|xlsx)$"
    'Dim ValidPath As String = "^(?:[\w]\:|\\)(\\_\-\s0-9\.]{0,})+\.(txt|gif|pdf|doc|docx|xls|xlsx)$"
    'Dim ReValidPath As New Regex(ValidPath)

    'If MyFname = "" Then
    '    MyFname = TextBox1.Text.Trim
    'End If
    'Dim Myfile As System.IO.StreamWriter
    'Myfile = My.Computer.FileSystem.OpenTextFileWriter(MainPath & TargetFile, True)
    ''Myfile = My.Computer.FileSystem.OpenTextFileWriter(TargetFile, True)
    ''Console.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
    ''    "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")

    'Myfile.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
    '    "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")
    'Try
    '    'If Not ReValidPath.IsMatch(TextBox1.Text, RegexOptions.IgnoreCase) Then

    '    '    MsgBox("Please specify a valid file...", vbExclamation, "No File Specified")
    '    '    TextBox1.Focus()
    '    '    open.FileName = ""
    '    '    Myfile.Close()
    '    '    Exit Sub

    '    'End If
    '    For Each line As String In File.ReadLines(MyFname) ' Loop over lines in file.
    '        cnt = 1
    '        Dim itm = Split(line, ",", -1) ' Display the item.
    '        For Each x In itm
    '            If cnt < 24 Then
    '                'Console.Write(x.TrimEnd)
    '                'Console.Write(",")

    '            Else
    '                'Console.WriteLine(x.TrimEnd)
    '            End If

    '            Select Case cnt
    '                Case 3 '-- 14
    '                    CardNo = "=""" & x.TrimEnd & """"
    '                Case 4 '-- 1
    '                    LastName = x.TrimEnd
    '                Case 6 '-- 8 & 9
    '                    MthYrSplit = x.TrimEnd
    '                    Mnth = MthYrSplit.Substring(0, 2)  '-- 8
    '                    Yr = MthYrSplit.Substring(3, 2)  '-- 8" '-- 9
    '                Case 12 '-- 3
    '                    Street = x.TrimEnd
    '                Case 14 '-- 4
    '                    City = x.TrimEnd
    '                    City = Strings.Left(City, Len(City) - Len("Belize 00000")) '--Trim out Belize 00...
    '                    ''Case 24
    '                    ''    Myfile.WriteLine(",", x.TrimEnd)
    '                Case Else
    '                    FirstName = Space(0) '-- 2
    '                    State = "BZE" '-- 5
    '                    CountryCode = Space(0) '-- 6
    '                    ZipCode = Space(0) '-- 7
    '                    AccountNumber_1 = Space(0) '-- 10
    '                    AccountType_1 = Space(0) '-- 11
    '                    AccountNumber_2 = Space(0) '-- 12
    '                    AccountType_2 = Space(0) '-- 13
    '                    Email = Space(0) '-- 15
    '                    Cell = Space(0) '-- 16
    '            End Select

    '            cnt += 1

    '        Next
    '        TargetLine = String.Concat(LastName, ",", FirstName, ",", Street, ",", City, ",",
    '                      State, ",", CountryCode, ",", ZipCode, ",", Mnth, ",", Yr, ",",
    '                      AccountNumber_1, ",", AccountType_1, ",", AccountNumber_2, ",",
    '                      AccountType_2, ",", CardNo, ",", Email, ",", Cell)
    '        'Myfile.WriteLine(LastName & "," & FirstName & "," & Street & "," & City & ",")
    '        Myfile.WriteLine(TargetLine)
    '    Next
    'Catch ex As FileNotFoundException
    '    MsgBox(ex.Message, vbExclamation, "File Not Found")
    '    TextBox1.Focus()
    '    open.FileName = ""
    '    Myfile.Close()
    '    Exit Sub
    'End Try

    'Myfile.Close()
    ''-- Move the TXT to the completed directory
    'My.Computer.FileSystem.MoveFile(MyFname, MainPath & TargetPath & open.SafeFileName,
    '        FileIO.UIOption.AllDialogs,
    '        FileIO.UICancelOption.ThrowException)
    ''-- Move the CSV to the output directory
    'My.Computer.FileSystem.MoveFile(MainPath & TargetFile, MainPath & OutputPath & TargetFile,
    '        FileIO.UIOption.AllDialogs,
    '        FileIO.UICancelOption.ThrowException)
    'MsgBox("File Processing Complete...Check [ " & MainPath & TargetPath & " ] for Processed Files" &
    '       Constants.vbCrLf & "and [ " & MainPath & OutputPath & " ] for Output Files", vbOK, "Process Complete")
    'TextBox1.Clear()
    'open.FileName = ""
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim open = OpenFileDialog1
    'open.Filter = "All Files|*.*"
    'open.ShowDialog()
    'TextBox1.Text = open.FileName
    'End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Dim txtBx As TextBox = TryCast(sender, TextBox)
        If Not IsNothing(e.KeyValue) Then
            If txtBx.Text.Trim <> "" Then
                BtnProcFile.Enabled = True
            Else
                BtnProcFile.Enabled = False
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) > 0 And Trim(TextBox1.Text) <> "" Then
            BtnProcFile.Enabled = True
        Else
            BtnProcFile.Enabled = False
        End If
    End Sub

    Private Sub BtnFndFile_Click(sender As Object, e As EventArgs) Handles BtnFndFile.Click
        open.Filter = "All Files|*.*"
        open.ShowDialog()
        TextBox1.Text = open.FileName
    End Sub

    Private Sub BtnProcFile_Click(sender As Object, e As EventArgs) Handles BtnProcFile.Click
        Dim cnt As Int16 = 0

        Dim LastName As String = Nothing '-- 1,4
        Dim FirstName As String = Nothing '-- 2,null
        Dim Street As String = Nothing  '-- 3,12
        Dim City As String = Nothing '-- 4,14
        Dim State As String = Nothing  '-- 5,BZE
        Dim CountryCode As String = Nothing  '-- 6,null
        Dim ZipCode As String = Nothing  '-- 7,null
        Dim Mnth As String = Nothing  '-- 8,6
        Dim Yr As String = Nothing ' -- 9,6
        Dim MthYrSplit As String = Nothing  '-- Split,6
        Dim AccountNumber_1 As String = Nothing  '-- 10,null
        Dim AccountType_1 As String = Nothing  '-- 11,null
        Dim AccountNumber_2 As String = Nothing  '-- 12,null
        Dim AccountType_2 As String = Nothing  '-- 13,null
        Dim CardNo As String = Nothing '-- 14,3
        Dim Email As String = Nothing  '-- 15,null
        Dim Cell As String = Nothing  '-- 16,null
        Dim TargetPath As String
        Dim TargetFile As String
        Dim TargetLine As String
        Dim OutputPath As String
        Dim MainPath As String

        MainPath = Strings.Left(open.FileName.ToString, Len(open.FileName) - Len(open.SafeFileName))

        '-- Extract the main path(e.g. C:\...
        'TargetFile = MainPath & "file.csv"
        TargetFile = "file.csv"
        TargetPath = "Completed\"
        OutputPath = "Output\"
        Dim MyFname As String = open.FileName
        'Dim ValidPath As String = "^(?:[\w]\:|\\)(\\_\-\s0-9\.]{0,})+\.(txt|gif|pdf|doc|docx|xls|xlsx)$"
        Dim ValidPath As String = "^(?:[\w]\:|\\)(\\_\-\s0-9\.]{0,})+\.(txt|gif|pdf|doc|docx|xls|xlsx)$"
        Dim ReValidPath As New Regex(ValidPath)

        If MyFname = "" Then
            MyFname = TextBox1.Text.Trim
        End If
        Dim Myfile As System.IO.StreamWriter
        Myfile = My.Computer.FileSystem.OpenTextFileWriter(MainPath & TargetFile, True)
        'Myfile = My.Computer.FileSystem.OpenTextFileWriter(TargetFile, True)
        'Console.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
        '    "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")

        Myfile.WriteLine("LastName,FirstName,Address1_1 Street,City_1,State_1,CountryCode_1,ZipCode_1," &
            "Exp Month,Exp Year,AccountNumber_1,AccountType_1,AccountNumber_2,AccountType_2,Card Number_3,Email,Cell")
        Try
            'If Not ReValidPath.IsMatch(TextBox1.Text, RegexOptions.IgnoreCase) Then

            '    MsgBox("Please specify a valid file...", vbExclamation, "No File Specified")
            '    TextBox1.Focus()
            '    open.FileName = ""
            '    Myfile.Close()
            '    Exit Sub

            'End If
            For Each line As String In File.ReadLines(MyFname) ' Loop over lines in file.
                cnt = 1
                Dim itm = Split(line, ",", -1) ' Display the item.
                For Each x In itm
                    If cnt < 24 Then
                        'Console.Write(x.TrimEnd)
                        'Console.Write(",")

                    Else
                        'Console.WriteLine(x.TrimEnd)
                    End If

                    Select Case cnt
                        Case 3 '-- 14
                            CardNo = "=""" & x.TrimEnd & """"
                        Case 4 '-- 1
                            LastName = x.TrimEnd
                        Case 6 '-- 8 & 9
                            MthYrSplit = x.TrimEnd
                            Mnth = MthYrSplit.Substring(0, 2)  '-- 8
                            Yr = MthYrSplit.Substring(3, 2)  '-- 8" '-- 9
                        Case 12 '-- 3
                            Street = x.TrimEnd
                        Case 14 '-- 4
                            City = x.TrimEnd
                            City = Strings.Left(City, Len(City) - Len("Belize 00000")) '--Trim out Belize 00...
                            ''Case 24
                            ''    Myfile.WriteLine(",", x.TrimEnd)
                        Case Else
                            FirstName = Space(0) '-- 2
                            State = "BZE" '-- 5
                            CountryCode = Space(0) '-- 6
                            ZipCode = Space(0) '-- 7
                            AccountNumber_1 = Space(0) '-- 10
                            AccountType_1 = Space(0) '-- 11
                            AccountNumber_2 = Space(0) '-- 12
                            AccountType_2 = Space(0) '-- 13
                            Email = Space(0) '-- 15
                            Cell = Space(0) '-- 16
                    End Select

                    cnt += 1

                Next
                TargetLine = String.Concat(LastName, ",", FirstName, ",", Street, ",", City, ",",
                              State, ",", CountryCode, ",", ZipCode, ",", Mnth, ",", Yr, ",",
                              AccountNumber_1, ",", AccountType_1, ",", AccountNumber_2, ",",
                              AccountType_2, ",", CardNo, ",", Email, ",", Cell)
                'Myfile.WriteLine(LastName & "," & FirstName & "," & Street & "," & City & ",")
                Myfile.WriteLine(TargetLine)
            Next
        Catch ex As FileNotFoundException
            MsgBox(ex.Message, vbExclamation, "File Not Found")
            TextBox1.Focus()
            open.FileName = ""
            Myfile.Close()
            Exit Sub
        End Try

        Myfile.Close()
        '-- Move the TXT to the completed directory
        My.Computer.FileSystem.MoveFile(MyFname, MainPath & TargetPath & open.SafeFileName,
                FileIO.UIOption.AllDialogs,
                FileIO.UICancelOption.ThrowException)
        '-- Move the CSV to the output directory
        My.Computer.FileSystem.MoveFile(MainPath & TargetFile, MainPath & OutputPath & TargetFile,
                FileIO.UIOption.AllDialogs,
                FileIO.UICancelOption.ThrowException)
        MsgBox("File Processing Complete...Check [ " & MainPath & TargetPath & " ] for Processed Files" &
               Constants.vbCrLf & "and [ " & MainPath & OutputPath & " ] for Output Files", vbOK, "Process Complete")
        TextBox1.Clear()
        open.FileName = ""
    End Sub

    Private Sub FrmFParser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmDMTSMain.Show()
    End Sub

    Private Sub FrmFParser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FrmDMTSMain.Hide()
    End Sub
End Class
