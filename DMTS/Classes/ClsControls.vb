Public Class ClsControls
    Public Shared GPosition As Int32
    Public Shared Sub RefreshDatagrid(ByRef TableAdapter As Object, ByRef DatTable As DataTable)
        TableAdapter.Fill(DatTable) '-- Refresh Grid

    End Sub
    Public Shared Sub DoEdit(ByRef EditBtn As ToolStripButton,
                             ByRef AddBtn As ToolStripButton,
                             ByRef SaveBtn As ToolStripButton,
                             ByRef DelBtn As ToolStripButton,
                             ByRef CanBtn As ToolStripButton)

        SaveBtn.Enabled = True
        EditBtn.Enabled = False
        AddBtn.Enabled = False
        DelBtn.Enabled = True
        CanBtn.Enabled = True
    End Sub
    Public Shared Sub DoAdd(ByRef EditBtn As ToolStripButton,
                             ByRef AddBtn As ToolStripButton,
                             ByRef SaveBtn As ToolStripButton,
                             ByRef DelBtn As ToolStripButton,
                             ByRef CanBtn As ToolStripButton)

        SaveBtn.Enabled = True
        EditBtn.Enabled = False
        AddBtn.Enabled = False
        DelBtn.Enabled = False
        CanBtn.Enabled = True
    End Sub
    Public Shared Sub DoSave(ByRef EditBtn As ToolStripButton,
                             ByRef AddBtn As ToolStripButton,
                             ByRef SaveBtn As ToolStripButton,
                             ByRef DelBtn As ToolStripButton,
                             ByRef CanBtn As ToolStripButton)

        SaveBtn.Enabled = False
        EditBtn.Enabled = True
        AddBtn.Enabled = True
        DelBtn.Enabled = False
        CanBtn.Enabled = False
    End Sub
    Public Shared Sub DoCancel(ByRef EditBtn As ToolStripButton,
                             ByRef AddBtn As ToolStripButton,
                             ByRef SaveBtn As ToolStripButton,
                             ByRef DelBtn As ToolStripButton,
                             ByRef CanBtn As ToolStripButton)

        SaveBtn.Enabled = False
        EditBtn.Enabled = True
        AddBtn.Enabled = True
        DelBtn.Enabled = False
        CanBtn.Enabled = False
    End Sub

    Public Shared Sub DoDelete(ByRef EditBtn As ToolStripButton,
                             ByRef AddBtn As ToolStripButton,
                             ByRef SaveBtn As ToolStripButton,
                             ByRef DelBtn As ToolStripButton,
                             ByRef CanBtn As ToolStripButton)

        SaveBtn.Enabled = False
        EditBtn.Enabled = True
        AddBtn.Enabled = True
        DelBtn.Enabled = False
        CanBtn.Enabled = False
    End Sub
    Public Shared Sub LastPosition(ByRef DgBindingSource As BindingSource,
                                  ByRef DGView As DataGridView,
                                  ByVal PrimaryKey As String,
                                   ByVal MoveOrGet As Byte)
        Try
            Select Case MoveOrGet
                Case 0 '- Record Cursor Position
                    Dim CurrRec As Int32
                    CurrRec = DirectCast(DgBindingSource.Current, DataRowView).Item(PrimaryKey)
                    GPosition = DgBindingSource.Find(PrimaryKey, CurrRec)
                    'GPosition = DgBindingSource.Position
                    DgBindingSource.Position = GPosition '- Record the position of last record added

                Case 1 '- Move Cursor to recorded Position
                    '- Below will move the cursor to the last recorded position
                    DGView.Rows(GPosition - 1).Selected = True
                    DGView.CurrentCell = DGView.Rows(GPosition - 1).Cells(1)

                Case Else
                    '- Do Nothing

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
