Public Class FrmDMerchant
    Private Sub MerchantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MerchantBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MerchantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MerchantDS)

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
        DistrictBindingSource.Filter = " country_rec_no = " & Country_rec_noComboBox.SelectedValue
        CityBindingSource.Filter = " district_rec_no = " & District_rec_noComboBox.SelectedValue

    End Sub

    Private Sub District_rec_noComboBox_TextChanged(sender As Object, e As EventArgs) Handles District_rec_noComboBox.TextChanged
        CityBindingSource.Filter = " district_rec_no = " & District_rec_noComboBox.SelectedValue

    End Sub
End Class