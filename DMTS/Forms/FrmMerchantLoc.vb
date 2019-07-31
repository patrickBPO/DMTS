Imports DMTS.ClsControls
Public Class FrmMerchantLoc
    Private Sub Merch_locBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles merch_locBNavSaveItem.Click
        Me.Validate()
        Me.Merch_locBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MerchantLocDS)
        '- Below will record the position of last record added
        'LastPosition(cityBindingSource, cityDataGridView, "city_rec_no", 0)
        'GPosition = Merch_locBindingSource.Position
        GPosition = MerchantmerchlocBindingSource.Position

        Me.Merch_locTableAdapter.Update(Me.MerchantLocDS.merch_loc)
        DoSave(merch_locBNavEditItem,
              merch_locBNavAddNewItem,
              merch_locBNavSaveItem,
              merch_locBNavDeleteItem,
              merch_locBNavCancel)
        HandleGrpInputCtrls(False)

        '--Me.Merch_locTableAdapter.Fill(MerchantLocDS.merch_loc) '-- Refresh Dataset

        '- Below will move the cursor to the last recorded position
        'LastPosition(merchantBindingSource, merchantDataGridView, "merchant_rec_no", 1)
        'MerchantBindingSource.Position = GPosition
        MerchantmerchlocBindingSource.Position = GPosition

    End Sub

    Private Sub FrmMerchantLoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'City._city' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.City._city)
        'TODO: This line of code loads data into the 'District._District' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.District._District)
        'TODO: This line of code loads data into the 'Country._Country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.Country._Country)
        'TODO: This line of code loads data into the 'MerchantLocDS.merchant' table. You can move, or remove it, as needed.
        Me.MerchantTableAdapter.Fill(Me.MerchantLocDS.merchant)
        'TODO: This line of code loads data into the 'MerchantLocDS.merch_loc' table. You can move, or remove it, as needed.
        Me.Merch_locTableAdapter.Fill(Me.MerchantLocDS.merch_loc)

    End Sub

    Private Sub Merch_locBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles merch_locBNavAddNewItem.Click
        DoAdd(merch_locBNavEditItem,
             merch_locBNavAddNewItem,
             merch_locBNavSaveItem,
             merch_locBNavDeleteItem,
             merch_locBNavCancel)
        HandleGrpInputCtrls(True)
    End Sub

    Private Sub Merch_locBNavEditItem_Click(sender As Object, e As EventArgs) Handles merch_locBNavEditItem.Click
        DoEdit(merch_locBNavEditItem,
            merch_locBNavAddNewItem,
            merch_locBNavSaveItem,
            merch_locBNavDeleteItem,
            merch_locBNavCancel)
        HandleGrpInputCtrls(True)
    End Sub

    Private Sub Merch_locBNavDeleteItem_Click(sender As Object, e As EventArgs) Handles merch_locBNavDeleteItem.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            'Me.Merch_locBindingSource.RemoveCurrent()

            Try
                Me.Validate()
                Me.Merch_locBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.merch_locDS)
                Me.Merch_locTableAdapter.Update(Me.MerchantLocDS.merch_loc)

                MessageBox.Show("Record successfully deleted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Merch_locBindingSource.ResetCurrentItem()
            RefreshDatagrid(Merch_locTableAdapter, MerchantLocDS.merch_loc)
        End If
        'RefreshDatagrid(merch_locTableAdapter, merch_locDS.merch_loc)

        DoDelete(merch_locBNavEditItem,
              merch_locBNavAddNewItem,
              merch_locBNavSaveItem,
              merch_locBNavDeleteItem,
              merch_locBNavCancel)
        HandleGrpInputCtrls(False)
    End Sub

    Private Sub Merch_locBNavCancel_Click(sender As Object, e As EventArgs) Handles merch_locBNavCancel.Click
        Me.Validate()
        MerchantLocDS.merch_loc.RejectChanges()
        'Me.merch_locTableAdapter.Update(Me.merch_locDS.merch_loc)
        DoCancel(merch_locBNavEditItem,
              merch_locBNavAddNewItem,
              merch_locBNavSaveItem,
              merch_locBNavDeleteItem,
              merch_locBNavCancel)
        HandleGrpInputCtrls(False)
        'merch_locDataGridView.ReadOnly = True
        'Me.merch_locTableAdapter.Fill(merch_locDS.merch_loc) '-- Refresh Data
        Merch_locBindingNavigator.MoveNextItem.PerformClick()
        Merch_locBindingNavigator.MovePreviousItem.PerformClick()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        MerchantBindingSource.Filter = String.Format("{0} LIKE '{4}%' OR {1} LIKE '{4}%' OR {2} LIKE '{4}%' OR {3} LIKE '{4}%'",
                                                      "merchant_id", "m_name", "m_contact", "m_email", TxtSearch.Text)
        MerchantBindingSource.Sort = "m_name ASC"
    End Sub

    Private Sub TxtMLSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtMLSearch.TextChanged
        Merch_locBindingSource.Filter = String.Format("{0} LIKE '{4}%' OR {1} LIKE '{4}%' OR {2} LIKE '{4}%' OR {3} LIKE '{4}%'",
                                                      "ml_id", "ml_name", "m_contact", "m_email", TxtMLSearch.Text)
        Merch_locBindingSource.Sort = "ml_name ASC"
    End Sub

    Private Sub Country_rec_noComboBox_TextChanged(sender As Object, e As EventArgs) Handles CboMLCountry.TextChanged
        If Not IsNothing(CboMLCountry.SelectedValue) Then
            Dim selectionStart As Integer = Me.CboMLCountry.SelectionStart

            Me.CboMLCountry.Text = Me.CboMLCountry.Text.ToUpper()
            Me.CboMLCountry.SelectionStart = selectionStart
            DistrictBindingSource1.Filter = " country_rec_no = " & CboMLCountry.SelectedValue
            If Not IsNothing(CboMLDistrict.SelectedValue) Then
                CityBindingSource1.Filter = " district_rec_no = " & CboMLDistrict.SelectedValue
            Else
                CityBindingSource1.Filter = " district_rec_no = " & 0
            End If
        Else
            DistrictBindingSource1.Filter = " country_rec_no = " & 0
        End If
    End Sub

    Private Sub District_rec_noComboBox_TextChanged(sender As Object, e As EventArgs) Handles CboMLDistrict.TextChanged
        If Not IsNothing(CboMLDistrict.SelectedValue) Then

            CityBindingSource1.Filter = " district_rec_no = " & CboMLDistrict.SelectedValue
        Else
            CityBindingSource1.Filter = " district_rec_no = " & 0
        End If
    End Sub

    Private Sub City_rec_noComboBox_TextChanged(sender As Object, e As EventArgs) Handles CboMLCity.TextChanged
        If Not IsNothing(CboMLCity.SelectedValue) Then
            Dim selectionStart As Integer = Me.CboMLCity.SelectionStart

            Me.CboMLCity.Text = Me.CboMLCity.Text.ToUpper()
            Me.CboMLCity.SelectionStart = selectionStart

        End If
    End Sub

    Private Sub District_rec_noComboBox_LostFocus(sender As Object, e As EventArgs) Handles CboMLDistrict.LostFocus
        Dim selectionStart As Integer = Me.CboMLDistrict.SelectionStart

        Me.CboMLDistrict.Text = Me.CboMLDistrict.Text.ToUpper()
        Me.CboMLDistrict.SelectionStart = selectionStart
    End Sub
    Private Sub HandleGrpInputCtrls(ByVal Enable_Disable As Boolean)

        If Enable_Disable = True Then
            GCMLDetails.Enabled = True
            GCMLLocation.Enabled = True
            TxtLocID.Focus()
        Else
            GCMLDetails.Enabled = False
            GCMLLocation.Enabled = False
        End If
    End Sub
End Class