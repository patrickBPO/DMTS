﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCountry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCountry))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.CountryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CountryBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Country = New DMTS.Country()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.CountryBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CountryBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.CountryBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CountryBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.CountryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCSearch = New System.Windows.Forms.TextBox()
        Me.CountryTableAdapter = New DMTS.CountryTableAdapters.CountryTableAdapter()
        Me.TableAdapterManager = New DMTS.CountryTableAdapters.TableAdapterManager()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.CountryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CountryBindingNavigator.SuspendLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Maroon
        Label2.Location = New System.Drawing.Point(13, 64)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 17)
        Label2.TabIndex = 12
        Label2.Text = "Search"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.CountryBindingNavigator)
        Me.GroupControl2.Controls.Add(Me.CountryDataGridView)
        Me.GroupControl2.Controls.Add(Label2)
        Me.GroupControl2.Controls.Add(Me.TxtCSearch)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(278, 321)
        Me.GroupControl2.TabIndex = 9
        Me.GroupControl2.Text = "COUNTRY LISTING"
        '
        'CountryBindingNavigator
        '
        Me.CountryBindingNavigator.AddNewItem = Me.CountryBNavAddNewItem
        Me.CountryBindingNavigator.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CountryBindingNavigator.BindingSource = Me.CountryBindingSource
        Me.CountryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CountryBindingNavigator.DeleteItem = Me.CountryBNavDeleteItem
        Me.CountryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.CountryBNavAddNewItem, Me.CountryBNavEditItem, Me.CountryBNavDeleteItem, Me.CountryBNavSaveItem, Me.CountryBNavCancel})
        Me.CountryBindingNavigator.Location = New System.Drawing.Point(2, 21)
        Me.CountryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CountryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CountryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CountryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CountryBindingNavigator.Name = "CountryBindingNavigator"
        Me.CountryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CountryBindingNavigator.Size = New System.Drawing.Size(274, 25)
        Me.CountryBindingNavigator.TabIndex = 10
        Me.CountryBindingNavigator.Text = "BindingNavigator1"
        '
        'CountryBNavAddNewItem
        '
        Me.CountryBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CountryBNavAddNewItem.Image = CType(resources.GetObject("CountryBNavAddNewItem.Image"), System.Drawing.Image)
        Me.CountryBNavAddNewItem.Name = "CountryBNavAddNewItem"
        Me.CountryBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.CountryBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.CountryBNavAddNewItem.Text = "Add New Country"
        '
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "Country"
        Me.CountryBindingSource.DataSource = Me.Country
        Me.CountryBindingSource.Sort = "description"
        '
        'Country
        '
        Me.Country.DataSetName = "Country"
        Me.Country.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'CountryBNavDeleteItem
        '
        Me.CountryBNavDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CountryBNavDeleteItem.Enabled = False
        Me.CountryBNavDeleteItem.Image = CType(resources.GetObject("CountryBNavDeleteItem.Image"), System.Drawing.Image)
        Me.CountryBNavDeleteItem.Name = "CountryBNavDeleteItem"
        Me.CountryBNavDeleteItem.RightToLeftAutoMirrorImage = True
        Me.CountryBNavDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.CountryBNavDeleteItem.Text = "Delete"
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
        'CountryBNavEditItem
        '
        Me.CountryBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CountryBNavEditItem.Image = Global.DMTS.My.Resources.Resources.Edit
        Me.CountryBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CountryBNavEditItem.Name = "CountryBNavEditItem"
        Me.CountryBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.CountryBNavEditItem.Text = "Edit Data"
        '
        'CountryBNavSaveItem
        '
        Me.CountryBNavSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CountryBNavSaveItem.Enabled = False
        Me.CountryBNavSaveItem.Image = CType(resources.GetObject("CountryBNavSaveItem.Image"), System.Drawing.Image)
        Me.CountryBNavSaveItem.Name = "CountryBNavSaveItem"
        Me.CountryBNavSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CountryBNavSaveItem.Text = "Save Data"
        '
        'CountryBNavCancel
        '
        Me.CountryBNavCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CountryBNavCancel.Enabled = False
        Me.CountryBNavCancel.Image = Global.DMTS.My.Resources.Resources.Undo
        Me.CountryBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CountryBNavCancel.Name = "CountryBNavCancel"
        Me.CountryBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.CountryBNavCancel.Text = "Cancel Operation"
        '
        'CountryDataGridView
        '
        Me.CountryDataGridView.AllowUserToAddRows = False
        Me.CountryDataGridView.AutoGenerateColumns = False
        Me.CountryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CountryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CountryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CountryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.CountryDataGridView.DataSource = Me.CountryBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CountryDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.CountryDataGridView.Location = New System.Drawing.Point(16, 86)
        Me.CountryDataGridView.Name = "CountryDataGridView"
        Me.CountryDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.CountryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.CountryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CountryDataGridView.Size = New System.Drawing.Size(244, 220)
        Me.CountryDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "country_rec_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "country_rec_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'TxtCSearch
        '
        Me.TxtCSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtCSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCSearch.Location = New System.Drawing.Point(74, 59)
        Me.TxtCSearch.Name = "TxtCSearch"
        Me.TxtCSearch.Size = New System.Drawing.Size(186, 21)
        Me.TxtCSearch.TabIndex = 11
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CountryTableAdapter = Me.CountryTableAdapter
        Me.TableAdapterManager.UpdateOrder = DMTS.CountryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 343)
        Me.Controls.Add(Me.GroupControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCountry"
        Me.Text = "Country Maintenance"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.CountryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CountryBindingNavigator.ResumeLayout(False)
        Me.CountryBindingNavigator.PerformLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtCSearch As TextBox
    Friend WithEvents Country As Country
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As CountryTableAdapters.CountryTableAdapter
    Friend WithEvents TableAdapterManager As CountryTableAdapters.TableAdapterManager
    Friend WithEvents CountryBindingNavigator As BindingNavigator
    Friend WithEvents CountryBNavAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents CountryBNavDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CountryBNavSaveItem As ToolStripButton
    Friend WithEvents CountryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CountryBNavCancel As ToolStripButton
    Friend WithEvents CountryBNavEditItem As ToolStripButton
End Class
