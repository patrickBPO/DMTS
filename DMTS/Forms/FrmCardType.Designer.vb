<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCardType
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCardType))
        Me.CardTypeDS = New DMTS.CardTypeDS()
        Me.Card_typeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Card_typeTableAdapter = New DMTS.CardTypeDSTableAdapters.card_typeTableAdapter()
        Me.TableAdapterManager = New DMTS.CardTypeDSTableAdapters.TableAdapterManager()
        Me.Card_typeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CardTypeBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.CardTypeBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CardTypeBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.CardTypeBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CardTypeBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.Card_typeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCTSearch = New System.Windows.Forms.TextBox()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CardTypeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card_typeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card_typeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Card_typeBindingNavigator.SuspendLayout()
        CType(Me.Card_typeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Maroon
        Label2.Location = New System.Drawing.Point(19, 56)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 17)
        Label2.TabIndex = 14
        Label2.Text = "Search"
        '
        'CardTypeDS
        '
        Me.CardTypeDS.DataSetName = "CardTypeDS"
        Me.CardTypeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Card_typeBindingSource
        '
        Me.Card_typeBindingSource.DataMember = "card_type"
        Me.Card_typeBindingSource.DataSource = Me.CardTypeDS
        '
        'Card_typeTableAdapter
        '
        Me.Card_typeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.card_typeTableAdapter = Me.Card_typeTableAdapter
        Me.TableAdapterManager.UpdateOrder = DMTS.CardTypeDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Card_typeBindingNavigator
        '
        Me.Card_typeBindingNavigator.AddNewItem = Me.CardTypeBNavAddNewItem
        Me.Card_typeBindingNavigator.BindingSource = Me.Card_typeBindingSource
        Me.Card_typeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Card_typeBindingNavigator.DeleteItem = Me.CardTypeBNavDeleteItem
        Me.Card_typeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.CardTypeBNavAddNewItem, Me.CardTypeBNavEditItem, Me.CardTypeBNavDeleteItem, Me.CardTypeBNavSaveItem, Me.CardTypeBNavCancel})
        Me.Card_typeBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.Card_typeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Card_typeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Card_typeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Card_typeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Card_typeBindingNavigator.Name = "Card_typeBindingNavigator"
        Me.Card_typeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Card_typeBindingNavigator.Size = New System.Drawing.Size(334, 25)
        Me.Card_typeBindingNavigator.TabIndex = 0
        Me.Card_typeBindingNavigator.Text = "BindingNavigator1"
        '
        'CardTypeBNavAddNewItem
        '
        Me.CardTypeBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CardTypeBNavAddNewItem.Image = CType(resources.GetObject("CardTypeBNavAddNewItem.Image"), System.Drawing.Image)
        Me.CardTypeBNavAddNewItem.Name = "CardTypeBNavAddNewItem"
        Me.CardTypeBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.CardTypeBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.CardTypeBNavAddNewItem.Text = "Add New Card Type"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'CardTypeBNavDeleteItem
        '
        Me.CardTypeBNavDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CardTypeBNavDeleteItem.Enabled = False
        Me.CardTypeBNavDeleteItem.Image = CType(resources.GetObject("CardTypeBNavDeleteItem.Image"), System.Drawing.Image)
        Me.CardTypeBNavDeleteItem.Name = "CardTypeBNavDeleteItem"
        Me.CardTypeBNavDeleteItem.RightToLeftAutoMirrorImage = True
        Me.CardTypeBNavDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.CardTypeBNavDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CardTypeBNavEditItem
        '
        Me.CardTypeBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CardTypeBNavEditItem.Image = Global.DMTS.My.Resources.Resources.Edit
        Me.CardTypeBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CardTypeBNavEditItem.Name = "CardTypeBNavEditItem"
        Me.CardTypeBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.CardTypeBNavEditItem.Text = "Edit Data"
        '
        'CardTypeBNavSaveItem
        '
        Me.CardTypeBNavSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CardTypeBNavSaveItem.Enabled = False
        Me.CardTypeBNavSaveItem.Image = CType(resources.GetObject("CardTypeBNavSaveItem.Image"), System.Drawing.Image)
        Me.CardTypeBNavSaveItem.Name = "CardTypeBNavSaveItem"
        Me.CardTypeBNavSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CardTypeBNavSaveItem.Text = "Save Data"
        '
        'CardTypeBNavCancel
        '
        Me.CardTypeBNavCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CardTypeBNavCancel.Enabled = False
        Me.CardTypeBNavCancel.Image = Global.DMTS.My.Resources.Resources.Undo
        Me.CardTypeBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CardTypeBNavCancel.Name = "CardTypeBNavCancel"
        Me.CardTypeBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.CardTypeBNavCancel.Text = "Cancel Operation"
        '
        'Card_typeDataGridView
        '
        Me.Card_typeDataGridView.AllowUserToAddRows = False
        Me.Card_typeDataGridView.AutoGenerateColumns = False
        Me.Card_typeDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        Me.Card_typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Card_typeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2})
        Me.Card_typeDataGridView.DataSource = Me.Card_typeBindingSource
        Me.Card_typeDataGridView.Location = New System.Drawing.Point(19, 79)
        Me.Card_typeDataGridView.Name = "Card_typeDataGridView"
        Me.Card_typeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Card_typeDataGridView.Size = New System.Drawing.Size(293, 220)
        Me.Card_typeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ct_rec_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ct_rec_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ct_acc_type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Acct Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ct_desc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Card Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ct_code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCTSearch)
        Me.GroupBox1.Controls.Add(Me.Card_typeDataGridView)
        Me.GroupBox1.Controls.Add(Me.Card_typeBindingNavigator)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 316)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CARD TYPE LISTING"
        '
        'TxtCTSearch
        '
        Me.TxtCTSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TxtCTSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCTSearch.Location = New System.Drawing.Point(80, 53)
        Me.TxtCTSearch.Name = "TxtCTSearch"
        Me.TxtCTSearch.Size = New System.Drawing.Size(232, 20)
        Me.TxtCTSearch.TabIndex = 13
        '
        'FrmCardType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 344)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCardType"
        Me.Text = "Card Type Maintenance"
        CType(Me.CardTypeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card_typeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card_typeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Card_typeBindingNavigator.ResumeLayout(False)
        Me.Card_typeBindingNavigator.PerformLayout()
        CType(Me.Card_typeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CardTypeDS As CardTypeDS
    Friend WithEvents Card_typeBindingSource As BindingSource
    Friend WithEvents Card_typeTableAdapter As CardTypeDSTableAdapters.card_typeTableAdapter
    Friend WithEvents TableAdapterManager As CardTypeDSTableAdapters.TableAdapterManager
    Friend WithEvents Card_typeBindingNavigator As BindingNavigator
    Friend WithEvents CardTypeBNavAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents CardTypeBNavDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CardTypeBNavSaveItem As ToolStripButton
    Friend WithEvents Card_typeDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCTSearch As TextBox
    Friend WithEvents CardTypeBNavEditItem As ToolStripButton
    Friend WithEvents CardTypeBNavCancel As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
