Public Class FrmDistrict
    Private Sub FrmDistrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DistrictDS.district' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.DistrictDS.district)
        'TODO: This line of code loads data into the 'DistrictDS.country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.DistrictDS.country)

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'DistrictTableAdapter.Update(DistrictDS.district)
        'TableAdapterManager.UpdateAll(DistrictDS)

        DistrictBindingSource.EndEdit()
        'DistrictTableAdapter.Adapter.UpdateCommand.Connection.Open()
        'DistrictTableAdapter.Adapter.InsertCommand.ExecuteNonQuery()
        'DistrictTableAdapter.Adapter.UpdateCommand.Connection.Close()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DistrictDataGridView.CancelEdit()
        DistrictDS.RejectChanges()
    End Sub

   
End Class