Imports DMTS.MySQLCom
Public Class FrmDistrict
    Private Sub CountryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CountryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CountryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DistrictDS)

    End Sub

    Private Sub FrmDistrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DistrictDS.district' table. You can move, or remove it, as needed.
        Me.DistrictTableAdapter.Fill(Me.DistrictDS.district)
        'TODO: This line of code loads data into the 'DistrictDS.country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.DistrictDS.country)

    End Sub

    Private Sub DistrictBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DistrictBNavSaveItem.Click
        Me.Validate()
        Me.DistrictBindingSource.EndEdit()
        '- Below will record the position of last record added
        'LastPosition(DistrictBindingSource, DistrictDataGridView, "District_rec_no", 0)
        GPosition = DistrictBindingSource.Position

        Me.DistrictTableAdapter.Update(Me.DistrictDS.district)
        DoSave(DistrictBNavEditItem,
              DistrictBNavAddNewItem,
              DistrictBNavSaveItem,
              DistrictBNavDeleteItem,
              DistrictBNavCancel)
        DistrictDataGridView.ReadOnly = True
        'DistrictDataGridView.AllowUserToAddRows = False
        Me.DistrictTableAdapter.Fill(DistrictDS.district) '-- Refresh Grid

        '- Below will move the cursor to the last recorded position
        'LastPosition(DistrictBindingSource, DistrictDataGridView, "District_rec_no", 1)
        DistrictBindingSource.Position = GPosition - 1
    End Sub

    Private Sub DistrictBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles DistrictBNavAddNewItem.Click
        DoAdd(DistrictBNavEditItem,
              DistrictBNavAddNewItem,
              DistrictBNavSaveItem,
              DistrictBNavDeleteItem,
              DistrictBNavCancel)
        DistrictDataGridView.ReadOnly = False
        DistrictDataGridView.AllowUserToAddRows = True
        DistrictDataGridView.Focus()
        DistrictDataGridView.Rows(DistrictDataGridView.Rows.Count - 1).Selected = True
        DistrictDataGridView.CurrentCell = DistrictDataGridView.Rows(DistrictDataGridView.Rows.Count - 1).Cells(1)
    End Sub

    Private Sub DistrictBNavEditItem_Click(sender As Object, e As EventArgs) Handles DistrictBNavEditItem.Click
        DoEdit(DistrictBNavEditItem,
              DistrictBNavAddNewItem,
              DistrictBNavSaveItem,
              DistrictBNavDeleteItem,
              DistrictBNavCancel)
        DistrictDataGridView.ReadOnly = False
        DistrictDataGridView.Focus()
    End Sub

    Private Sub DistrictBNavCancel_Click(sender As Object, e As EventArgs) Handles DistrictBNavCancel.Click
        Me.Validate()
        DistrictDataGridView.CancelEdit()
        DistrictDS.district.RejectChanges()
        'Me.DistrictTableAdapter.Update(Me.DistrictDS.district)
        DoCancel(DistrictBNavEditItem,
              DistrictBNavAddNewItem,
              DistrictBNavSaveItem,
              DistrictBNavDeleteItem,
              DistrictBNavCancel)
        DistrictDataGridView.ReadOnly = True
        Me.DistrictTableAdapter.Fill(DistrictDS.district) '-- Refresh Grid
        'DistrictDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub DistrictBNavDeleteItem_Click(sender As Object, e As EventArgs) Handles DistrictBNavDeleteItem.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.DistrictBindingSource.RemoveCurrent()

            Try
                Me.Validate()
                Me.DistrictBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.DistrictDS)
                Me.DistrictTableAdapter.Update(Me.DistrictDS.district)

                MessageBox.Show("Record successfully deleted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            DistrictBindingSource.ResetCurrentItem()
            RefreshDatagrid(DistrictTableAdapter, DistrictDS.district)
        End If
        'RefreshDatagrid(DistrictTableAdapter, DistrictDS.district)

        DoDelete(DistrictBNavEditItem,
              DistrictBNavAddNewItem,
              DistrictBNavSaveItem,
              DistrictBNavDeleteItem,
              DistrictBNavCancel)
        DistrictDataGridView.ReadOnly = True
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        DistrictBindingSource.Filter = String.Format("{0} LIKE '{1}%'", "description", TxtSearch.Text)
        DistrictBindingSource.Sort = "description ASC"

    End Sub


    Private Sub DistrictDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DistrictDataGridView.CellEndEdit

        Dim NewValue As String

        'Apply to certin columns  
        'Select Case e.ColumnIndex
        '    Case 2, 3, 6
        '        NewValue = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        '        DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = NewValue.ToUpper
        'End Select

        'or  

        'Apply to all columns that are of String datatype  
        If DistrictDataGridView.Columns(e.ColumnIndex).ValueType Is GetType(String) Then
            NewValue = DistrictDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            DistrictDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = NewValue.ToUpper
        End If
    End Sub

    Private Sub DistrictDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DistrictDataGridView.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            DirectCast(e.Control, TextBox).ForeColor = Color.Blue
        End If
    End Sub

    Private Sub TxtCSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtCSearch.TextChanged
        CountryBindingSource.Filter = String.Format("{0} LIKE '{1}%'", "description", TxtCSearch.Text)
        CountryBindingSource.Sort = "description ASC"
    End Sub
End Class