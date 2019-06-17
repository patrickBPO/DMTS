Imports DMTS.ClsControls
Public Class FrmMerchant
    Private Sub MerchantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MerchantBNavSaveItem.Click
        Me.Validate()
        Me.MerchantBindingSource.EndEdit()
        '- Below will record the position of last record added
        'LastPosition(MerchantBindingSource, MerchantDataGridView, "merchant_rec_no", 0)
        GPosition = MerchantBindingSource.Position

        Me.TableAdapterManager.UpdateAll(Me.MerchantDS)
        DoSave(MerchantBNavEditItem,
              MerchantBNavAddNewItem,
              MerchantBNavSaveItem,
              MerchantBNavDeleteItem,
              MerchantBNavCancel)
        MerchantDataGridView.ReadOnly = True
        'merchantDataGridView.AllowUserToAddRows = False
        '''''''''''''''Me.MerchantTableAdapter.Fill(MerchantDS.merchant) '-- Refresh Grid

        '- Below will move the cursor to the last recorded position
        'LastPosition(MerchantBindingSource, MerchantDataGridView, "merchant_rec_no", 1)
        MerchantBindingSource.Position = GPosition

        'Me.Validate()
        'Me.MerchantBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.MerchantDS)

        'Me.MerchantTableAdapter.Fill(Me.MerchantDS.merchant)

    End Sub

    Private Sub FrmMerchant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Country._Country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.Country._Country)
        'TODO: This line of code loads data into the 'District._District' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.District._District)
        'TODO: This line of code loads data into the 'City._city' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.City._city)
        'TODO: This line of code loads data into the 'MerchantDS.merchant' table. You can move, or remove it, as needed.
        Me.MerchantTableAdapter.Fill(Me.MerchantDS.merchant)

    End Sub

    Private Sub MerchantBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles MerchantBNavAddNewItem.Click
        DoAdd(MerchantBNavEditItem,
              MerchantBNavAddNewItem,
              MerchantBNavSaveItem,
              MerchantBNavDeleteItem,
              MerchantBNavCancel)
        MerchantDataGridView.ReadOnly = False
        'MerchantDataGridView.AllowUserToAddRows = True
        MerchantDataGridView.Focus()
        MerchantDataGridView.Rows(MerchantDataGridView.Rows.Count - 1).Selected = True
        MerchantDataGridView.CurrentCell = MerchantDataGridView.Rows(MerchantDataGridView.Rows.Count - 1).Cells(1)
    End Sub

    Private Sub MerchantBNavCancel_Click(sender As Object, e As EventArgs) Handles MerchantBNavCancel.Click
        Me.Validate()
        MerchantDataGridView.CancelEdit()
        MerchantDS.merchant.RejectChanges()
        'Me.merchantTableAdapter.Update(Me.merchantDS.merchant)
        DoCancel(MerchantBNavEditItem,
              MerchantBNavAddNewItem,
              MerchantBNavSaveItem,
              MerchantBNavDeleteItem,
              MerchantBNavCancel)
        MerchantDataGridView.ReadOnly = True
        Me.MerchantTableAdapter.Fill(MerchantDS.merchant) '-- Refresh Grid
        'cityDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub MerchantBNavEditItem_Click(sender As Object, e As EventArgs) Handles MerchantBNavEditItem.Click
        DoEdit(MerchantBNavEditItem,
            MerchantBNavAddNewItem,
            MerchantBNavSaveItem,
            MerchantBNavDeleteItem,
            MerchantBNavCancel)
        MerchantDataGridView.ReadOnly = False
        MerchantDataGridView.Focus()
    End Sub

    Private Sub MerchantBNavDeleteItem_Click(sender As Object, e As EventArgs) Handles MerchantBNavDeleteItem.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            'Me.MerchantBindingSource.RemoveCurrent()

            Try
                Me.Validate()
                Me.MerchantBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.merchantDS)
                Me.MerchantTableAdapter.Update(Me.MerchantDS.merchant)

                MessageBox.Show("Record successfully deleted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MerchantBindingSource.ResetCurrentItem()
            RefreshDatagrid(MerchantTableAdapter, MerchantDS.merchant)
        End If
        'RefreshDatagrid(merchantTableAdapter, merchantDS.merchant)

        DoDelete(MerchantBNavEditItem,
              MerchantBNavAddNewItem,
              MerchantBNavSaveItem,
              MerchantBNavDeleteItem,
              MerchantBNavCancel)
        MerchantDataGridView.ReadOnly = True
    End Sub


    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        MerchantBindingSource.Filter = String.Format("{0} LIKE '{4}%' OR {1} LIKE '{4}%' OR {2} LIKE '{4}%' OR {3} LIKE '{4}%'",
                                                      "merchant_id", "m_name", "m_contact", "m_email", TxtSearch.Text)
        MerchantBindingSource.Sort = "m_name ASC"
    End Sub

    Private Sub Country_rec_noComboBox_SelectedValueChanged(sender As Object, e As EventArgs)
        'DistrictBindingSource.Filter = " country_rec_no = " & Country_rec_noComboBox.SelectedValue
    End Sub

    Private Sub District_rec_noComboBox_SelectedValueChanged(sender As Object, e As EventArgs)
        'CityBindingSource.Filter = " district_rec_no = " & District_rec_noComboBox.SelectedValue
    End Sub

    Private Sub MerchantDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MerchantDataGridView.DataError
        ' Do nothings
    End Sub

    Private Sub MerchantDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles MerchantDataGridView.CellBeginEdit
        '- District field -> Use country to set filter
        If e.ColumnIndex = 9 Then '- Use country_rec_no as filter
            Dim Pdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView((e.ColumnIndex - 1), e.RowIndex), DataGridViewComboBoxCell)
            Dim Chdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView(e.ColumnIndex, e.RowIndex), DataGridViewComboBoxCell)
            Dim dgBS As BindingSource = Chdgcb.DataSource
            dgBS.Filter = "country_rec_no = " & Pdgcb.Value.ToString
        End If
        '- City field -> Use district to set filter
        If e.ColumnIndex = 10 Then '- Use District_rec_no as filter
            Dim Pdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView((e.ColumnIndex - 1), e.RowIndex), DataGridViewComboBoxCell)
            Dim Chdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView(e.ColumnIndex, e.RowIndex), DataGridViewComboBoxCell)
            Dim dgBS As BindingSource = Chdgcb.DataSource
            dgBS.Filter = "district_rec_no = " & Pdgcb.Value.ToString
        End If
    End Sub
    Private Sub MerchantDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MerchantDataGridView.CellEndEdit
        Dim NewValue As String
        If MerchantDataGridView.Columns(e.ColumnIndex).ValueType Is GetType(String) Then
            NewValue = MerchantDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            MerchantDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = NewValue.ToUpper
        End If
    End Sub

    Private Sub MerchantDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles MerchantDataGridView.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    Private Sub MerchantDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles MerchantDataGridView.RowEnter
        '- District field -> Use country to set filter
        If e.ColumnIndex = 9 Then '- Use country_rec_no as filter
            Dim Pdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView((e.ColumnIndex - 1), e.RowIndex), DataGridViewComboBoxCell)
            Dim Chdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView(e.ColumnIndex, e.RowIndex), DataGridViewComboBoxCell)
            Dim dgBS As BindingSource = Chdgcb.DataSource
            dgBS.Filter = "country_rec_no = " & Pdgcb.Value.ToString
        End If
        '- City field -> Use district to set filter
        If e.ColumnIndex = 10 Then '- Use District_rec_no as filter
            Dim Pdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView((e.ColumnIndex - 1), e.RowIndex), DataGridViewComboBoxCell)
            Dim Chdgcb As DataGridViewComboBoxCell = DirectCast(MerchantDataGridView(e.ColumnIndex, e.RowIndex), DataGridViewComboBoxCell)
            Dim dgBS As BindingSource = Chdgcb.DataSource
            dgBS.Filter = "district_rec_no = " & Pdgcb.Value.ToString
        End If
    End Sub
End Class