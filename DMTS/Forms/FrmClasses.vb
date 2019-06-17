Public Class FrmClasses
    Private Sub ClassesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClassesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClassesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClassesDS)

    End Sub

    Private Sub FrmClasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassesDS.classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.ClassesDS.classes)

    End Sub
End Class