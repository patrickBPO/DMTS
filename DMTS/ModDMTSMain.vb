
Imports Microsoft.Office.Interop
Module ModDMTSMain
    Public LoginUserName As String
    Public LoginUserPassword As String
    Public LoginUserId As Long
    Dim OpenLoginform
    Dim OpenMainform

    Sub main()
        'Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value

        'xlWorkBook = xlApp.Workbooks.Add(misValue)

        'xlWorkSheet = xlWorkBook.Sheets("sheet1")
        'xlWorkSheet.Cells(1, 1) = "Sheet 1 content"

        'xlWorkSheet = xlWorkBook.Sheets("sheet2")
        'xlWorkSheet.Cells(1, 1) = "Sheet 2 content"
        'xlWorkBook.SaveAs("c:\sample.xls")
        'xlWorkBook.Close(True, misValue, misValue)
        'xlApp.Quit()


        'Dim MyConString As String = "DSN=paymaster; SERVER=SERVER;DATABASE=paymaster;UID=PAYC;"
        'Dim MyConString As String = "DSN=paymaster;"
        'Dim MyConnection As New OdbcConnection(MyConString)


        Try
            'MyConnection.Open()
            ''MsgBox(MyConnection.State.ToString)
            'Console.WriteLine("Connection State::" & MyConnection.State.ToString)

            'Dim MyCommand As New OdbcCommand()
            'MyCommand.Connection = MyConnection

            'MyCommand.CommandText = "SELECT count(*) FROM user_admin"
            'Console.WriteLine("Total Rows:" & MyCommand.ExecuteScalar())

            'MyCommand.CommandText = "SELECT * FROM user_admin"
            'Dim MyDataReader As OdbcDataReader
            'MyDataReader = MyCommand.ExecuteReader
            'While MyDataReader.Read

            '    Console.WriteLine("id = " &
            '        CStr(MyDataReader("user_id")) & "  user_name = " &
            '        CStr(MyDataReader("user_name")))

            'Dim currentRow As String()
            'Dim currentField As String

            'Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Debit format.txt")
            '    MyReader.TextFieldType = FileIO.FieldType.Delimited
            '    MyReader.SetDelimiters(",")

            '    While Not MyReader.EndOfData
            '        Try
            '            currentRow = MyReader.ReadFields()

            '            For Each currentField In currentRow
            '                ' MsgBox(currentField)
            '            Next
            '        Catch ex As Microsoft.VisualBasic.
            '                    FileIO.MalformedLineException
            '            MsgBox("Line " & ex.Message &
            '            "is not valid and will be skipped.")
            '        End Try
            '    End While
            'End Using

            ''End While

            OpenLoginform = FrmDMTSLogin
            OpenLoginform.Showdialog()


            If FrmDMTSLogin.LoginSucceeded = True Then
                OpenMainform = FrmDMTSMain
                OpenMainform.showdialog()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Module