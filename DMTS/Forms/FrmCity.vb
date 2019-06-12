Public Class FrmCity
    Private Sub CityBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CityBindingNavigatorSaveItem.Click
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
End Class