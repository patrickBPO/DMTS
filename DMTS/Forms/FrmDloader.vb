Imports DMTS.ExcelToDb
Public Class FrmDloader

    Dim open As New OpenFileDialog
    Dim cnt As Integer = 0
    Private Sub BtnFndFile_Click(sender As Object, e As EventArgs) Handles BtnFndFile.Click
        With open
            .Filter = "Excel files(*.xlsx, *.xls)|*.xlsx;*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data from Excel file"
        End With
        If open.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = open.FileName
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) > 0 And Trim(TextBox1.Text) <> "" Then
            BtnLdFile.Enabled = True
        Else
            BtnLdFile.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PBLoad.EditValue = 100 Then
            Timer1.Stop()
            'MsgBox("Successfully Loaded " & cnt)
            TxtRecs.Text = cnt
            PBLoad.EditValue = 0
        Else
            PBLoad.EditValue += 1

        End If
    End Sub

    Private Sub BtnLdFile_Click(sender As Object, e As EventArgs) Handles BtnLdFile.Click
        Dim OLEcon As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & TextBox1.Text & " ; " & "Extended Properties=Excel 8.0;")
        Dim OLEcmd As New OleDb.OleDbCommand
        Dim OLEda As New OleDb.OleDbDataAdapter
        Dim OLEdt As New DataTable
        Dim sql As String
        Dim resul As Boolean

        Try
            OLEcon.Open()
            With OLEcmd
                .Connection = OLEcon
                .CommandText = "select * from [Sheet1$A3:D135]"
            End With
            OLEda.SelectCommand = OLEcmd
            OLEda.Fill(OLEdt)

            For Each r As DataRow In OLEdt.Rows

                sql = "INSERT INTO d_transactions (lt_rec_no,t_count,amount, t_date) 
                            VALUES (CAST('" & r(1).ToString & "' AS UNSIGNED),CAST('" & r(2).ToString & "' AS UNSIGNED),'" & r(3).ToString & "' + 0.0 ,STR_TO_DATE('" & DateTimePicker1.Text & "','%m-%d-%Y'))"
                resul = SaveData(sql)
                If resul Then
                    Timer1.Start()
                End If
                cnt += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OLEcon.Close()
        End Try

    End Sub

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
End Class