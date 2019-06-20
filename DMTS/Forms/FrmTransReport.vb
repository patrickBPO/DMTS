Public Class FrmTransReport
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' Check whether or not the Grid Control can be printed. 
        If Not GridControl1.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub FrmTransReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransactionsDS.transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.TransactionsDS.transactions)

    End Sub
End Class