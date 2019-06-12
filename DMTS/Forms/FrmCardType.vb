Imports DMTS.ClsControls
Public Class FrmCardType
    Private Sub Card_typeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CardTypeBNavSaveItem.Click
        Me.Validate()
        Me.Card_typeBindingSource.EndEdit()
        '- Below will record the position of last record added
        LastPosition(Card_typeBindingSource, Card_typeDataGridView, "ct_rec_no", 0)

        Me.Card_typeTableAdapter.Update(Me.CardTypeDS.card_type)

        DoSave(CardTypeBNavEditItem,
              CardTypeBNavAddNewItem,
              CardTypeBNavSaveItem,
              CardTypeBNavDeleteItem,
              CardTypeBNavCancel)
        Card_typeDataGridView.ReadOnly = True
        Me.Card_typeTableAdapter.Fill(CardTypeDS.card_type) '-- Refresh Grid

        '- Below will move the cursor to the last recorded position
        LastPosition(Card_typeBindingSource, Card_typeDataGridView, "ct_rec_no", 1)
    End Sub

    Private Sub FrmCardType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CardTypeDS.card_type' table. You can move, or remove it, as needed.
        Me.Card_typeTableAdapter.Fill(Me.CardTypeDS.card_type)

    End Sub

    Private Sub CardTypeBNavAddNewItem_Click(sender As Object, e As EventArgs) Handles CardTypeBNavAddNewItem.Click
        DoAdd(CardTypeBNavEditItem,
             CardTypeBNavAddNewItem,
             CardTypeBNavSaveItem,
             CardTypeBNavDeleteItem,
             CardTypeBNavCancel)
        Card_typeDataGridView.ReadOnly = False '- Edit
        'Card_typeDataGridView.AllowUserToAddRows = True '- Add
        'card_typeDataGridView.AllowUserToDeleteRows = False '- Delete
        Card_typeDataGridView.Focus()
        Card_typeDataGridView.Rows((Card_typeDataGridView.Rows.Count - 1)).Selected = True
        Card_typeDataGridView.CurrentCell = Card_typeDataGridView.Rows((Card_typeDataGridView.Rows.Count - 1)).Cells(1)
    End Sub

    Private Sub CardTypeBNavEditItem_Click(sender As Object, e As EventArgs) Handles CardTypeBNavEditItem.Click
        DoEdit(CardTypeBNavEditItem,
             CardTypeBNavAddNewItem,
             CardTypeBNavSaveItem,
             CardTypeBNavDeleteItem,
             CardTypeBNavCancel)
        Card_typeDataGridView.ReadOnly = False
        Card_typeDataGridView.Focus()
    End Sub

    Private Sub CardTypeBNavDeleteItem_Click(sender As Object, e As EventArgs) Handles CardTypeBNavDeleteItem.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            Try
                Me.Validate()
                Me.Card_typeBindingSource.EndEdit()
                'Me.Card_typeBindingSource.RemoveCurrent()
                'Me.TableAdapterManager.UpdateAll(Me.cardtypeDS)
                Me.Card_typeTableAdapter.Update(CardTypeDS.card_type)

                MessageBox.Show("Record successfully deleted.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Card_typeBindingSource.ResetCurrentItem()
            RefreshDatagrid(Card_typeTableAdapter, CardTypeDS.card_type)
        End If

        DoDelete(CardTypeBNavEditItem,
              CardTypeBNavAddNewItem,
              CardTypeBNavSaveItem,
              CardTypeBNavDeleteItem,
              CardTypeBNavCancel)
        Card_typeDataGridView.ReadOnly = True
    End Sub

    Private Sub CardTypeBNavCancel_Click(sender As Object, e As EventArgs) Handles CardTypeBNavCancel.Click
        Me.Validate()
        Card_typeDataGridView.CancelEdit()
        CardTypeDS.card_type.RejectChanges()
        'Me.cardtypeTableAdapter.Update(Me.cardtypeDS.cardtype)
        DoCancel(CardTypeBNavEditItem,
              CardTypeBNavAddNewItem,
              CardTypeBNavSaveItem,
              CardTypeBNavDeleteItem,
              CardTypeBNavCancel)
        Card_typeDataGridView.ReadOnly = True
        RefreshDatagrid(Card_typeTableAdapter, CardTypeDS.card_type)
        'card_typeDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub TxtCTSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtCTSearch.TextChanged
        Card_typeBindingSource.Filter = String.Format("{0} LIKE '{3}%' OR {1} LIKE '{3}%' OR {2} LIKE '{3}%'",
                                                      "ct_code", "ct_desc", "ct_acc_type", TxtCTSearch.Text)
        Card_typeBindingSource.Sort = "ct_acc_type ASC"
    End Sub

    Private Sub Card_typeDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Card_typeDataGridView.CellEndEdit
        Dim NewValue As String
        If Card_typeDataGridView.Columns(e.ColumnIndex).ValueType Is GetType(String) Then
            NewValue = Card_typeDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            Card_typeDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = NewValue.ToUpper
        End If
    End Sub

    Private Sub Card_typeDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Card_typeDataGridView.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            DirectCast(e.Control, TextBox).ForeColor = Color.Blue
        End If
    End Sub
End Class