Public Class FrmCity
    Private Sub CityBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CityDS)

    End Sub

    Private Sub FrmCity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CityDS.district' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.CityDS.district)
        'TODO: This line of code loads data into the 'CityDS.country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.CityDS.country)
        'TODO: This line of code loads data into the 'CityDS.city' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.CityDS.city)

    End Sub

    Private Sub TxtCSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtCSearch.TextChanged
        CountryBindingSource.Filter = String.Format("{0} LIKE '{1}%'", "description", TxtCSearch.Text)
        CountryBindingSource.Sort = "description ASC"
    End Sub

    Private Sub TxtDSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtDSearch.TextChanged
        DistrictBindingSource.Filter = String.Format("{0} LIKE '{1}%'", "description", TxtDSearch.Text)
        DistrictBindingSource.Sort = "description ASC"
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        CityBindingSource.Filter = String.Format("{0} LIKE '{1}%'", "description", TxtSearch.Text)
        CityBindingSource.Sort = "description ASC"
    End Sub
End Class