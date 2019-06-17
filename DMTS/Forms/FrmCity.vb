Imports DMTS.ClsControls
Public Class FrmCity
    Private Sub CityBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CityDS)

    End Sub

    Private Sub FrmCity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CityBindingSource.ResetBindings(False)
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

    Private Sub CityBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles CityBNavAddNewItem.Click
        DoAdd(CityBNavEditItem,
              CityBNavAddNewItem,
              CityBNavSaveItem,
              CityBNavDeleteItem,
              CityBNavCancel)
        CityDataGridView.ReadOnly = False
        CityDataGridView.AllowUserToAddRows = True
        CityDataGridView.Focus()
        CityDataGridView.Rows(CityDataGridView.Rows.Count - 1).Selected = True
        CityDataGridView.CurrentCell = CityDataGridView.Rows(CityDataGridView.Rows.Count - 1).Cells(1)
    End Sub

    Private Sub CityBNavSaveItem_Click(sender As Object, e As EventArgs) Handles CityBNavSaveItem.Click
        Me.Validate()
        Me.CityBindingSource.EndEdit()
        '- Below will record the position of last record added
        'LastPosition(cityBindingSource, cityDataGridView, "city_rec_no", 0)
        GPosition = CityBindingSource.Position

        Me.CityTableAdapter.Update(Me.CityDS.city)
        DoSave(CityBNavEditItem,
              CityBNavAddNewItem,
              CityBNavSaveItem,
              CityBNavDeleteItem,
              CityBNavCancel)
        CityDataGridView.ReadOnly = True
        'cityDataGridView.AllowUserToAddRows = False
        Me.CityTableAdapter.Fill(CityDS.city) '-- Refresh Grid

        '- Below will move the cursor to the last recorded position
        'LastPosition(cityBindingSource, cityDataGridView, "city_rec_no", 1)
        CityBindingSource.Position = GPosition
    End Sub

    Private Sub CityBNavEditItem_Click(sender As Object, e As EventArgs) Handles CityBNavEditItem.Click
        DoEdit(CityBNavEditItem,
             CityBNavAddNewItem,
             CityBNavSaveItem,
             CityBNavDeleteItem,
             CityBNavCancel)
        CityDataGridView.ReadOnly = False
        CityDataGridView.Focus()
    End Sub

    Private Sub CityBNavDeleteItem_Click(sender As Object, e As EventArgs) Handles CityBNavDeleteItem.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.CityBindingSource.RemoveCurrent()

            Try
                Me.Validate()
                Me.CityBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.cityDS)
                Me.CityTableAdapter.Update(Me.CityDS.city)

                MessageBox.Show("Record successfully deleted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            CityBindingSource.ResetCurrentItem()
            RefreshDatagrid(CityTableAdapter, CityDS.city)
        End If
        'RefreshDatagrid(cityTableAdapter, cityDS.city)

        DoDelete(CityBNavEditItem,
              CityBNavAddNewItem,
              CityBNavSaveItem,
              CityBNavDeleteItem,
              CityBNavCancel)
        CityDataGridView.ReadOnly = True
    End Sub

    Private Sub CityBNavCancel_Click(sender As Object, e As EventArgs) Handles CityBNavCancel.Click
        Me.Validate()
        CityDataGridView.CancelEdit()
        CityDS.city.RejectChanges()
        Me.CityTableAdapter.Update(Me.CityDS.city)
        DoCancel(CityBNavEditItem,
              CityBNavAddNewItem,
              CityBNavSaveItem,
              CityBNavDeleteItem,
              CityBNavCancel)
        CityDataGridView.ReadOnly = True
        Me.CityTableAdapter.Fill(CityDS.city) '-- Refresh Grid
        'cityDataGridView.AllowUserToAddRows = False
    End Sub
    Private Sub CityDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles CityDataGridView.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub
    Private Sub CityDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CityDataGridView.CellEndEdit
        Dim NewValue As String
        If CityDataGridView.Columns(e.ColumnIndex).ValueType Is GetType(String) Then
            If IsDBNull(CityDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                NewValue = 0
            Else
                NewValue = CityDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If


            CityDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = NewValue.ToUpper
            End If
    End Sub
End Class