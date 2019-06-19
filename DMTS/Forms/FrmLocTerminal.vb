Imports DMTS.ClsControls
Public Class FrmLocTerminal
    Private Sub FrmLocTerminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LocTerminalDS.merchant' table. You can move, or remove it, as needed.
        Me.MerchantTableAdapter.Fill(Me.LocTerminalDS.merchant)
        'TODO: This line of code loads data into the 'LocTerminalDS.loc_terminal' table. You can move, or remove it, as needed.
        Me.Loc_terminalTableAdapter.Fill(Me.LocTerminalDS.loc_terminal)
        'TODO: This line of code loads data into the 'City._city' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.City._city)
        'TODO: This line of code loads data into the 'District._District' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.District._District)
        'TODO: This line of code loads data into the 'Country._Country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.Country._Country)
        'TODO: This line of code loads data into the 'LocTerminalDS.merch_loc' table. You can move, or remove it, as needed.
        Me.Merch_locTableAdapter.Fill(Me.LocTerminalDS.merch_loc)

    End Sub

    Private Sub Loc_terminalBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles loc_terminalBNavAddNewItem.Click
        DoAdd(loc_terminalBNavEditItem,
                     loc_terminalBNavAddNewItem,
                     loc_terminalBNavSaveItem,
                     loc_terminalBNavDeleteItem,
                     loc_terminalBNavCancel)
        Loc_terminalDataGridView.ReadOnly = False
        'Loc_terminalDataGridView.AllowUserToAddRows = True
        Loc_terminalDataGridView.Focus()
        'Loc_terminalDataGridView.Rows(Loc_terminalDataGridView.Rows.Count + 1).Selected = True
        'Loc_terminalDataGridView.CurrentCell = Loc_terminalDataGridView.Rows(Loc_terminalDataGridView.Rows.Count + 1).Cells(2)
    End Sub

    Private Sub Loc_terminalBNavSaveItem_Click(sender As Object, e As EventArgs) Handles loc_terminalBNavSaveItem.Click
        Me.Validate()
        Me.Loc_terminalBindingSource.EndEdit()
        '- Below will record the position of last record added
        'LastPosition(loc_terminalBindingSource, loc_terminalDataGridView, "loc_terminal_rec_no", 0)
        GPosition = Loc_terminalBindingSource.Position

        Me.Loc_terminalTableAdapter.Update(Me.LocTerminalDS.loc_terminal)
        DoSave(loc_terminalBNavEditItem,
              loc_terminalBNavAddNewItem,
              loc_terminalBNavSaveItem,
              loc_terminalBNavDeleteItem,
              loc_terminalBNavCancel)
        Loc_terminalDataGridView.ReadOnly = True
        'loc_terminalDataGridView.AllowUserToAddRows = False
        Me.Loc_terminalTableAdapter.Fill(LocTerminalDS.loc_terminal) '-- Refresh Grid

        '- Below will move the cursor to the last recorded position
        'LastPosition(loc_terminalBindingSource, loc_terminalDataGridView, "loc_terminal_rec_no", 1)
        Loc_terminalBindingSource.Position = GPosition
    End Sub

    Private Sub TxtMSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtMSearch.TextChanged
        MerchantBindingSource.Filter = String.Format("{0} LIKE '{4}%' OR {1} LIKE '{4}%' OR {2} LIKE '{4}%' OR {3} LIKE '{4}%'",
                                                      "merchant_id", "m_name", "m_contact", "m_email", TxtMSearch.Text)
        MerchantBindingSource.Sort = "m_name ASC"
    End Sub

    Private Sub TxtMLSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtMLSearch.TextChanged
        Merch_locBindingSource.Filter = String.Format("{0} LIKE '{4}%' OR {1} LIKE '{4}%' OR {2} LIKE '{4}%' OR {3} LIKE '{4}%'",
                                                      "ml_id", "ml_name", "m_contact", "m_email", TxtMLSearch.Text)
        Merch_locBindingSource.Sort = "ml_name ASC"
    End Sub

    Private Sub TxtLTSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtLTSearch.TextChanged
        Loc_terminalBindingSource.Filter = String.Format("{0} LIKE '{2}%' OR {1} LIKE '{2}%' ",
                                                      "lt_id", "lt_desc", TxtLTSearch.Text)
        Loc_terminalBindingSource.Sort = "lt_desc ASC"
    End Sub
End Class