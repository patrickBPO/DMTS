Imports DMTS.ClsControls
Public Class FrmDMerchant
    Private Sub MerchantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles merchantBNavSaveItem.Click
        Me.Validate()
        Me.MerchantBindingSource.EndEdit()
        Try
            Me.TableAdapterManager.UpdateAll(Me.MerchantDS)

        Catch ex As Exception
            'Do nothing
        End Try

        '- Below will record the position of last record added
        'LastPosition(cityBindingSource, cityDataGridView, "city_rec_no", 0)
        GPosition = MerchantBindingSource.Position

        Me.MerchantTableAdapter.Update(Me.MerchantDS.merchant)
        DoSave(merchantBNavEditItem,
              merchantBNavAddNewItem,
              merchantBNavSaveItem,
              merchantBNavDeleteItem,
              merchantBNavCancel)
        HandleGrpInputCtrls(False)

        Me.MerchantTableAdapter.Fill(MerchantDS.merchant) '-- Refresh Dataset

        '- Below will move the cursor to the last recorded position
        'LastPosition(merchantBindingSource, merchantDataGridView, "merchant_rec_no", 1)
        MerchantBindingSource.Position = GPosition

    End Sub

    Private Sub FrmDMerchant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'City._city' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.City._city)
        'TODO: This line of code loads data into the 'District._District' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.District._District)
        'TODO: This line of code loads data into the 'Country._Country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.Country._Country)
        'TODO: This line of code loads data into the 'MerchantDS.merchant' table. You can move, or remove it, as needed.
        Me.MerchantTableAdapter.Fill(Me.MerchantDS.merchant)

    End Sub

    Private Sub Country_rec_noComboBox_TextChanged(sender As Object, e As EventArgs) Handles Country_rec_noComboBox.TextChanged

        If Not IsNothing(Country_rec_noComboBox.SelectedValue) Then
            Dim selectionStart As Integer = Me.Country_rec_noComboBox.SelectionStart

            Me.Country_rec_noComboBox.Text = Me.Country_rec_noComboBox.Text.ToUpper()
            Me.Country_rec_noComboBox.SelectionStart = selectionStart
            DistrictBindingSource.Filter = " country_rec_no = " & Country_rec_noComboBox.SelectedValue
            If Not IsNothing(District_rec_noComboBox.SelectedValue) Then
                CityBindingSource.Filter = " district_rec_no = " & District_rec_noComboBox.SelectedValue
            Else
                CityBindingSource.Filter = " district_rec_no = " & 0
            End If
        Else
            DistrictBindingSource.Filter = " country_rec_no = " & 0
        End If

    End Sub

    Private Sub District_rec_noComboBox_TextChanged(sender As Object, e As EventArgs) Handles District_rec_noComboBox.TextChanged

        If Not IsNothing(District_rec_noComboBox.SelectedValue) Then

            CityBindingSource.Filter = " district_rec_no = " & District_rec_noComboBox.SelectedValue
        Else
            CityBindingSource.Filter = " district_rec_no = " & 0
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles merchantBNavAddNewItem.Click
        DoAdd(merchantBNavEditItem,
              merchantBNavAddNewItem,
              merchantBNavSaveItem,
              merchantBNavDeleteItem,
              merchantBNavCancel)
        HandleGrpInputCtrls(True)
        'merchantDataGridView.ReadOnly = False
        'merchantDataGridView.AllowUserToAddRows = True
        'merchantDataGridView.Focus()
        'merchantDataGridView.Rows(merchantDataGridView.Rows.Count - 1).Selected = True
        'merchantDataGridView.CurrentCell = merchantDataGridView.Rows(merchantDataGridView.Rows.Count - 1).Cells(1)
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        MerchantBindingSource.Filter = String.Format("{0} LIKE '{4}%' OR {1} LIKE '{4}%' OR {2} LIKE '{4}%' OR {3} LIKE '{4}%'",
                                                      "merchant_id", "m_name", "m_contact", "m_email", TxtSearch.Text)
        MerchantBindingSource.Sort = "m_name ASC"
    End Sub

    Private Sub MerchantBNavEditItem_Click(sender As Object, e As EventArgs) Handles merchantBNavEditItem.Click
        DoEdit(merchantBNavEditItem,
             merchantBNavAddNewItem,
             merchantBNavSaveItem,
             merchantBNavDeleteItem,
             merchantBNavCancel)
        HandleGrpInputCtrls(True)
        'merchantDataGridView.ReadOnly = False
        'merchantDataGridView.Focus()
    End Sub

    Private Sub MerchantBNavDeleteItem_Click(sender As Object, e As EventArgs) Handles merchantBNavDeleteItem.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.MerchantBindingSource.RemoveCurrent()

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

        DoDelete(merchantBNavEditItem,
              merchantBNavAddNewItem,
              merchantBNavSaveItem,
              merchantBNavDeleteItem,
              merchantBNavCancel)
        HandleGrpInputCtrls(False)
        'merchantDataGridView.ReadOnly = True
    End Sub

    Private Sub MerchantBNavCancel_Click(sender As Object, e As EventArgs) Handles merchantBNavCancel.Click
        Me.Validate()
        MerchantDS.merchant.RejectChanges()
        'Me.merchantTableAdapter.Update(Me.merchantDS.merchant)
        DoCancel(merchantBNavEditItem,
              merchantBNavAddNewItem,
              merchantBNavSaveItem,
              merchantBNavDeleteItem,
              merchantBNavCancel)
        HandleGrpInputCtrls(False)
        'merchantDataGridView.ReadOnly = True
        'Me.MerchantTableAdapter.Fill(MerchantDS.merchant) '-- Refresh Data
        MerchantBindingNavigator.MoveNextItem.PerformClick()
        MerchantBindingNavigator.MovePreviousItem.PerformClick()

    End Sub

    Private Sub City_rec_noComboBox_TextChanged(sender As Object, e As EventArgs) Handles City_rec_noComboBox.TextChanged
        If Not IsNothing(City_rec_noComboBox.SelectedValue) Then
            Dim selectionStart As Integer = Me.City_rec_noComboBox.SelectionStart

            Me.City_rec_noComboBox.Text = Me.City_rec_noComboBox.Text.ToUpper()
            Me.City_rec_noComboBox.SelectionStart = selectionStart

        End If

    End Sub

    Private Sub District_rec_noComboBox_LostFocus(sender As Object, e As EventArgs) Handles District_rec_noComboBox.LostFocus

        Dim selectionStart As Integer = Me.District_rec_noComboBox.SelectionStart

        Me.District_rec_noComboBox.Text = Me.District_rec_noComboBox.Text.ToUpper()
        Me.District_rec_noComboBox.SelectionStart = selectionStart
    End Sub
    Private Sub HandleGrpInputCtrls(ByVal Enable_Disable As Boolean)

        If Enable_Disable = True Then
            GCMDetails.Enabled = True
            GCMLocation.Enabled = True
        Else
            GCMDetails.Enabled = False
            GCMLocation.Enabled = False
        End If
    End Sub
End Class