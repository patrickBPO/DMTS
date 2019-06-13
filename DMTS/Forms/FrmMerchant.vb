Imports DMTS.ClsControls
Public Class FrmMerchant
    Private Sub FrmMerchant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CityDS.city' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.CityDS.city)
        'TODO: This line of code loads data into the 'DistrictDS.district' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.DistrictDS.district)
        'TODO: This line of code loads data into the 'Country._Country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.Country._Country)
        'TODO: This line of code loads data into the 'MerchantDS.merchant' table. You can move, or remove it, as needed.
        Me.MerchantTableAdapter.Fill(Me.MerchantDS.merchant)

        'MerchantDataGridView.Columns("country_rec_no").ValueType = 
    End Sub

    Private Sub MerchantDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub


    Private Sub MerchantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MerchantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MerchantDS)

    End Sub

    Private Sub MerchantBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles MerchantBNavAddNewItem.Click
        DoAdd(MerchantBNavEditItem,
              MerchantBNavAddNewItem,
              MerchantBNavSaveItem,
              MerchantBNavDeleteItem,
              MerchantBNavCancel)
        MerchantDataGridView.ReadOnly = False
        MerchantDataGridView.AllowUserToAddRows = True
        MerchantDataGridView.Focus()
        MerchantDataGridView.Rows(MerchantDataGridView.Rows.Count - 1).Selected = True
        MerchantDataGridView.CurrentCell = MerchantDataGridView.Rows(MerchantDataGridView.Rows.Count - 1).Cells(1)
    End Sub

    Private Sub MerchantBNavSaveItem_Click(sender As Object, e As EventArgs) Handles MerchantBNavSaveItem.Click
        Me.Validate()
        Me.MerchantBindingSource.EndEdit()
        '- Below will record the position of last record added
        'LastPosition(merchantBindingSource, merchantDataGridView, "merchant_rec_no", 0)
        GPosition = MerchantBindingSource.Position

        Me.MerchantTableAdapter.Update(Me.MerchantDS.merchant)
        DoSave(MerchantBNavEditItem,
              MerchantBNavAddNewItem,
              MerchantBNavSaveItem,
              MerchantBNavDeleteItem,
              MerchantBNavCancel)
        MerchantDataGridView.ReadOnly = True
        'merchantDataGridView.AllowUserToAddRows = False
        Me.MerchantTableAdapter.Fill(MerchantDS.merchant) '-- Refresh Grid

        '- Below will move the cursor to the last recorded position
        'LastPosition(merchantBindingSource, merchantDataGridView, "merchant_rec_no", 1)
        MerchantBindingSource.Position = GPosition
    End Sub
End Class