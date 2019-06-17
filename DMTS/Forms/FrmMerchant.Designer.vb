<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMerchant
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMerchant))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MerchantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MerchantBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.MerchantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantDS = New DMTS.MerchantDS()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.MerchantBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MerchantBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.MerchantBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MerchantBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.MerchantDataGridView = New System.Windows.Forms.DataGridView()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.MerchantTableAdapter = New DMTS.MerchantDSTableAdapters.merchantTableAdapter()
        Me.TableAdapterManager = New DMTS.MerchantDSTableAdapters.TableAdapterManager()
        Me.City = New DMTS.City()
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityTableAdapter = New DMTS.CityTableAdapters.cityTableAdapter()
        Me.District = New DMTS.District()
        Me.DistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistrictTableAdapter = New DMTS.DistrictTableAdapters.DistrictTableAdapter()
        Me.Country = New DMTS.Country()
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryTableAdapter = New DMTS.CountryTableAdapters.CountryTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDGCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DistrictDGCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CityDGCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MerchantBindingNavigator.SuspendLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.City, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Maroon
        Label4.Location = New System.Drawing.Point(12, 14)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 17)
        Label4.TabIndex = 10
        Label4.Text = "Search"
        '
        'MerchantBindingNavigator
        '
        Me.MerchantBindingNavigator.AddNewItem = Me.MerchantBNavAddNewItem
        Me.MerchantBindingNavigator.BindingSource = Me.MerchantBindingSource
        Me.MerchantBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MerchantBindingNavigator.DeleteItem = Me.MerchantBNavDeleteItem
        Me.MerchantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.MerchantBNavAddNewItem, Me.MerchantBNavEditItem, Me.MerchantBNavDeleteItem, Me.MerchantBNavSaveItem, Me.MerchantBNavCancel})
        Me.MerchantBindingNavigator.Location = New System.Drawing.Point(2, 20)
        Me.MerchantBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MerchantBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MerchantBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MerchantBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MerchantBindingNavigator.Name = "MerchantBindingNavigator"
        Me.MerchantBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MerchantBindingNavigator.Size = New System.Drawing.Size(978, 25)
        Me.MerchantBindingNavigator.TabIndex = 0
        Me.MerchantBindingNavigator.Text = "BindingNavigator1"
        '
        'MerchantBNavAddNewItem
        '
        Me.MerchantBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBNavAddNewItem.Image = CType(resources.GetObject("MerchantBNavAddNewItem.Image"), System.Drawing.Image)
        Me.MerchantBNavAddNewItem.Name = "MerchantBNavAddNewItem"
        Me.MerchantBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.MerchantBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavAddNewItem.Text = "Add new"
        Me.MerchantBNavAddNewItem.ToolTipText = "Add New Merchant"
        '
        'MerchantBindingSource
        '
        Me.MerchantBindingSource.DataMember = "merchant"
        Me.MerchantBindingSource.DataSource = Me.MerchantDS
        '
        'MerchantDS
        '
        Me.MerchantDS.DataSetName = "MerchantDS"
        Me.MerchantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'MerchantBNavDeleteItem
        '
        Me.MerchantBNavDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBNavDeleteItem.Enabled = False
        Me.MerchantBNavDeleteItem.Image = CType(resources.GetObject("MerchantBNavDeleteItem.Image"), System.Drawing.Image)
        Me.MerchantBNavDeleteItem.Name = "MerchantBNavDeleteItem"
        Me.MerchantBNavDeleteItem.RightToLeftAutoMirrorImage = True
        Me.MerchantBNavDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MerchantBNavEditItem
        '
        Me.MerchantBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBNavEditItem.Image = Global.DMTS.My.Resources.Resources.Edit
        Me.MerchantBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MerchantBNavEditItem.Name = "MerchantBNavEditItem"
        Me.MerchantBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavEditItem.Text = "Edit Data"
        '
        'MerchantBNavSaveItem
        '
        Me.MerchantBNavSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBNavSaveItem.Enabled = False
        Me.MerchantBNavSaveItem.Image = CType(resources.GetObject("MerchantBNavSaveItem.Image"), System.Drawing.Image)
        Me.MerchantBNavSaveItem.Name = "MerchantBNavSaveItem"
        Me.MerchantBNavSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavSaveItem.Text = "Save Data"
        '
        'MerchantBNavCancel
        '
        Me.MerchantBNavCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBNavCancel.Enabled = False
        Me.MerchantBNavCancel.Image = Global.DMTS.My.Resources.Resources.Undo
        Me.MerchantBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MerchantBNavCancel.Name = "MerchantBNavCancel"
        Me.MerchantBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavCancel.Text = "Cancel Operation"
        '
        'MerchantDataGridView
        '
        Me.MerchantDataGridView.AllowUserToAddRows = False
        Me.MerchantDataGridView.AllowUserToDeleteRows = False
        Me.MerchantDataGridView.AllowUserToOrderColumns = True
        Me.MerchantDataGridView.AutoGenerateColumns = False
        Me.MerchantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MerchantDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.rate, Me.CountryDGCol, Me.DistrictDGCol, Me.CityDGCol})
        Me.MerchantDataGridView.DataSource = Me.MerchantBindingSource
        Me.MerchantDataGridView.Location = New System.Drawing.Point(17, 48)
        Me.MerchantDataGridView.Name = "MerchantDataGridView"
        Me.MerchantDataGridView.ReadOnly = True
        Me.MerchantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MerchantDataGridView.Size = New System.Drawing.Size(920, 346)
        Me.MerchantDataGridView.TabIndex = 1
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Location = New System.Drawing.Point(72, 12)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(237, 20)
        Me.TxtSearch.TabIndex = 9
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.MerchantDataGridView)
        Me.GroupControl1.Controls.Add(Me.MerchantBindingNavigator)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 38)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(982, 471)
        Me.GroupControl1.TabIndex = 11
        Me.GroupControl1.Text = "MERCHANT LISTING"
        '
        'MerchantTableAdapter
        '
        Me.MerchantTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.merchantTableAdapter = Me.MerchantTableAdapter
        Me.TableAdapterManager.UpdateOrder = DMTS.MerchantDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'City
        '
        Me.City.DataSetName = "City"
        Me.City.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "city"
        Me.CityBindingSource.DataSource = Me.City
        Me.CityBindingSource.Filter = ""
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'District
        '
        Me.District.DataSetName = "District"
        Me.District.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistrictBindingSource
        '
        Me.DistrictBindingSource.DataMember = "District"
        Me.DistrictBindingSource.DataSource = Me.District
        Me.DistrictBindingSource.Filter = ""
        '
        'DistrictTableAdapter
        '
        Me.DistrictTableAdapter.ClearBeforeFill = True
        '
        'Country
        '
        Me.Country.DataSetName = "Country"
        Me.Country.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "Country"
        Me.CountryBindingSource.DataSource = Me.Country
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "merchant_rec_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "merchant_rec_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "merchant_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "merchant_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "m_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "m_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "m_contact"
        Me.DataGridViewTextBoxColumn7.HeaderText = "m_contact"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "m_email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "m_email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "phone_1"
        DataGridViewCellStyle6.Format = "(###)###-####"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn9.HeaderText = "phone_1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "phone_2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "phone_2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'rate
        '
        Me.rate.DataPropertyName = "rate"
        Me.rate.HeaderText = "rate"
        Me.rate.Name = "rate"
        Me.rate.ReadOnly = True
        '
        'CountryDGCol
        '
        Me.CountryDGCol.DataPropertyName = "country_rec_no"
        Me.CountryDGCol.DataSource = Me.CountryBindingSource
        Me.CountryDGCol.DisplayMember = "description"
        Me.CountryDGCol.HeaderText = "country_rec_no"
        Me.CountryDGCol.Name = "CountryDGCol"
        Me.CountryDGCol.ReadOnly = True
        Me.CountryDGCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CountryDGCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CountryDGCol.ValueMember = "country_rec_no"
        '
        'DistrictDGCol
        '
        Me.DistrictDGCol.DataPropertyName = "district_rec_no"
        Me.DistrictDGCol.DataSource = Me.DistrictBindingSource
        Me.DistrictDGCol.DisplayMember = "description"
        Me.DistrictDGCol.HeaderText = "district_rec_no"
        Me.DistrictDGCol.Name = "DistrictDGCol"
        Me.DistrictDGCol.ReadOnly = True
        Me.DistrictDGCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DistrictDGCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DistrictDGCol.ValueMember = "District_rec_no"
        '
        'CityDGCol
        '
        Me.CityDGCol.DataPropertyName = "city_rec_no"
        Me.CityDGCol.DataSource = Me.CityBindingSource
        Me.CityDGCol.DisplayMember = "Description"
        Me.CityDGCol.HeaderText = "city_rec_no"
        Me.CityDGCol.Name = "CityDGCol"
        Me.CityDGCol.ReadOnly = True
        Me.CityDGCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CityDGCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CityDGCol.ValueMember = "City_rec_no"
        '
        'FrmMerchant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 521)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMerchant"
        Me.Text = "Merchant Maintenance"
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MerchantBindingNavigator.ResumeLayout(False)
        Me.MerchantBindingNavigator.PerformLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.City, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MerchantDS As MerchantDS
    Friend WithEvents MerchantBindingSource As BindingSource
    Friend WithEvents MerchantTableAdapter As MerchantDSTableAdapters.merchantTableAdapter
    Friend WithEvents TableAdapterManager As MerchantDSTableAdapters.TableAdapterManager
    Friend WithEvents MerchantBindingNavigator As BindingNavigator
    Friend WithEvents MerchantBNavAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents MerchantBNavDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MerchantBNavSaveItem As ToolStripButton
    Friend WithEvents MerchantDataGridView As DataGridView
    Friend WithEvents MerchantBNavEditItem As ToolStripButton
    Friend WithEvents MerchantBNavCancel As ToolStripButton
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents City As City
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents CityTableAdapter As CityTableAdapters.cityTableAdapter
    Friend WithEvents District As District
    Friend WithEvents DistrictBindingSource As BindingSource
    Friend WithEvents DistrictTableAdapter As DistrictTableAdapters.DistrictTableAdapter
    Friend WithEvents Country As Country
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As CountryTableAdapters.CountryTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents rate As DataGridViewTextBoxColumn
    Friend WithEvents CountryDGCol As DataGridViewComboBoxColumn
    Friend WithEvents DistrictDGCol As DataGridViewComboBoxColumn
    Friend WithEvents CityDGCol As DataGridViewComboBoxColumn
End Class
