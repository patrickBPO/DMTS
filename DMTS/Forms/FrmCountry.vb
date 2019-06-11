Imports DMTS.MySQLCom
Public Class FrmCountry
    'Private Sub CountryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.CountryBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.Country)

    'End Sub

    Private Sub FrmCountry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Country._Country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.Country._Country)

    End Sub

    Private Sub TxtCSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtCSearch.TextChanged
        CountryBindingSource.Filter = String.Format("{0} LIKE '{1}%'", "description", TxtCSearch.Text)
        CountryBindingSource.Sort = "description ASC"
    End Sub


    Private Sub CountryBNavEditItem_Click(sender As Object, e As EventArgs) Handles CountryBNavEditItem.Click
        DoEdit(CountryBNavEditItem,
             CountryBNavAddNewItem,
             CountryBNavSaveItem,
             CountryBNavDeleteItem,
             CountryBNavCancel)
        CountryDataGridView.ReadOnly = False
        CountryDataGridView.Focus()
    End Sub

    Private Sub CountryDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CountryDataGridView.CellEndEdit
        Dim NewValue As String
        If CountryDataGridView.Columns(e.ColumnIndex).ValueType Is GetType(String) Then
            NewValue = CountryDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            CountryDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = NewValue.ToUpper
        End If
    End Sub

    Private Sub CountryDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles CountryDataGridView.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            DirectCast(e.Control, TextBox).ForeColor = Color.Blue
        End If
    End Sub

    Private Sub CountryBNavSaveItem_Click(sender As Object, e As EventArgs) Handles CountryBNavSaveItem.Click
        Me.Validate()
        Me.CountryBindingSource.EndEdit()
        Me.CountryTableAdapter.Update(Country._Country)
        DoSave(CountryBNavEditItem,
              CountryBNavAddNewItem,
              CountryBNavSaveItem,
              CountryBNavDeleteItem,
              CountryBNavCancel)
        CountryDataGridView.ReadOnly = True
        CountryDataGridView.AllowUserToAddRows = False
        'Me.DistrictTableAdapter.Fill(Me.DistrictDS.district) '-- Refresh Grid
    End Sub

    Private Sub CountryBNavDeleteItem_Click(sender As Object, e As EventArgs) Handles CountryBNavDeleteItem.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            Try
                Me.CountryBindingSource.RemoveCurrent()
                Me.Validate()
                Me.CountryBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.CountryDS)
                Me.CountryTableAdapter.Update(Country._Country)

                MessageBox.Show("Record successfully deleted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            CountryBindingSource.ResetCurrentItem()
        End If
        'RefreshDatagrid(CountryTableAdapter, CountryDS.Country)

        DoDelete(CountryBNavEditItem,
              CountryBNavAddNewItem,
              CountryBNavSaveItem,
              CountryBNavDeleteItem,
              CountryBNavCancel)
        CountryDataGridView.ReadOnly = True
    End Sub

    Private Sub CountryBNavCancel_Click(sender As Object, e As EventArgs) Handles CountryBNavCancel.Click
        Me.Validate()
        CountryDataGridView.CancelEdit()
        Country._Country.RejectChanges()
        'Me.CountryTableAdapter.Update(Me.CountryDS.Country)
        DoCancel(CountryBNavEditItem,
              CountryBNavAddNewItem,
              CountryBNavSaveItem,
              CountryBNavDeleteItem,
              CountryBNavCancel)
        CountryDataGridView.ReadOnly = True
        CountryDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub CountryBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles CountryBNavAddNewItem.Click
        DoAdd(CountryBNavEditItem,
              CountryBNavAddNewItem,
              CountryBNavSaveItem,
              CountryBNavDeleteItem,
              CountryBNavCancel)
        CountryDataGridView.ReadOnly = False '- Edit
        CountryDataGridView.AllowUserToAddRows = True '- Add
        'CountryDataGridView.AllowUserToDeleteRows = False '- Delete
        CountryDataGridView.Focus()
        CountryDataGridView.Rows((CountryDataGridView.Rows.Count - 1)).Selected = True
        CountryDataGridView.CurrentCell = CountryDataGridView.Rows((CountryDataGridView.Rows.Count - 1)).Cells(1)
    End Sub
End Class