﻿Public Class FrmViewDTrans
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        D_transactionsTableAdapter1.Fill(DTransactionDS1.d_transactions)
    End Sub
End Class