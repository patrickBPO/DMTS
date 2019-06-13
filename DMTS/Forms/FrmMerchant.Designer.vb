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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMerchant))
        Me.MerchantDataGridView = New System.Windows.Forms.DataGridView()
        Me.MerchantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MerchantBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.MerchantBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.MerchantBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MerchantBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MerchantBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.MerchantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantDS = New DMTS.MerchantDS()
        Me.MerchantTableAdapter = New DMTS.MerchantDSTableAdapters.merchantTableAdapter()
        Me.TableAdapterManager = New DMTS.MerchantDSTableAdapters.TableAdapterManager()
        Me.Country = New DMTS.Country()
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryTableAdapter = New DMTS.CountryTableAdapters.CountryTableAdapter()
        Me.DistrictDS = New DMTS.DistrictDS()
        Me.DistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistrictTableAdapter = New DMTS.DistrictDSTableAdapters.districtTableAdapter()
        Me.CityDS = New DMTS.CityDS()
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityTableAdapter = New DMTS.CityDSTableAdapters.cityTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.MerchantDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MerchantBindingNavigator.SuspendLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MerchantDataGridView
        '
        Me.MerchantDataGridView.AllowUserToAddRows = False
        Me.MerchantDataGridView.AutoGenerateColumns = False
        Me.MerchantDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MerchantDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MerchantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MerchantDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MerchantDataGridView.DataSource = Me.MerchantBindingSource
        Me.MerchantDataGridView.Location = New System.Drawing.Point(28, 54)
        Me.MerchantDataGridView.Name = "MerchantDataGridView"
        Me.MerchantDataGridView.ReadOnly = True
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Cornsilk
        Me.MerchantDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.MerchantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MerchantDataGridView.Size = New System.Drawing.Size(846, 344)
        Me.MerchantDataGridView.TabIndex = 1
        '
        'MerchantBindingNavigator
        '
        Me.MerchantBindingNavigator.AddNewItem = Nothing
        Me.MerchantBindingNavigator.BindingSource = Me.MerchantBindingSource
        Me.MerchantBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.MerchantBindingNavigator.DeleteItem = Nothing
        Me.MerchantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.MerchantBNavAddNewItem, Me.MerchantBNavEditItem, Me.MerchantBNavDeleteItem, Me.ToolStripSeparator4, Me.MerchantBNavSaveItem, Me.MerchantBNavCancel})
        Me.MerchantBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MerchantBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.MerchantBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.MerchantBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.MerchantBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.MerchantBindingNavigator.Name = "MerchantBindingNavigator"
        Me.MerchantBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.MerchantBindingNavigator.Size = New System.Drawing.Size(909, 25)
        Me.MerchantBindingNavigator.TabIndex = 11
        Me.MerchantBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        Me.ToolStripButton3.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        Me.ToolStripButton4.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        Me.ToolStripButton5.Visible = False
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        Me.ToolStripButton6.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'MerchantBNavAddNewItem
        '
        Me.MerchantBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBNavAddNewItem.Image = CType(resources.GetObject("MerchantBNavAddNewItem.Image"), System.Drawing.Image)
        Me.MerchantBNavAddNewItem.Name = "MerchantBNavAddNewItem"
        Me.MerchantBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.MerchantBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavAddNewItem.Text = "Add New Merchant"
        Me.MerchantBNavAddNewItem.ToolTipText = "Add New Merchant"
        '
        'MerchantBNavEditItem
        '
        Me.MerchantBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBNavEditItem.Image = CType(resources.GetObject("MerchantBNavEditItem.Image"), System.Drawing.Image)
        Me.MerchantBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MerchantBNavEditItem.Name = "MerchantBNavEditItem"
        Me.MerchantBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavEditItem.Text = "Edit Data"
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        Me.MerchantBNavCancel.Image = CType(resources.GetObject("MerchantBNavCancel.Image"), System.Drawing.Image)
        Me.MerchantBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MerchantBNavCancel.Name = "MerchantBNavCancel"
        Me.MerchantBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBNavCancel.Text = "Cancel Operation"
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
        'DistrictDS
        '
        Me.DistrictDS.DataSetName = "DistrictDS"
        Me.DistrictDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistrictBindingSource
        '
        Me.DistrictBindingSource.DataMember = "district"
        Me.DistrictBindingSource.DataSource = Me.DistrictDS
        '
        'DistrictTableAdapter
        '
        Me.DistrictTableAdapter.ClearBeforeFill = True
        '
        'CityDS
        '
        Me.CityDS.DataSetName = "CityDS"
        Me.CityDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "city"
        Me.CityBindingSource.DataSource = Me.CityDS
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "merchant_rec_no"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "merchant_rec_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "merchant_id"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID #"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Merchant ID Number"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "m_name"
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Merchant"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Merchant Name"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "m_contact"
        Me.DataGridViewTextBoxColumn7.Frozen = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.ToolTipText = "Contact Name"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "m_email"
        Me.DataGridViewTextBoxColumn8.Frozen = True
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.ToolTipText = "Merchant Email"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "phone_1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Phone 1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.ToolTipText = "Primary Phone Number"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "phone_2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Phone 2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.ToolTipText = "Secondary Phone Number"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "rate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.ToolTipText = "Rate"
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "country_rec_no"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.CountryBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Location Country"
        Me.DataGridViewTextBoxColumn4.ValueMember = "country_rec_no"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "district_rec_no"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.DistrictBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "description"
        Me.DataGridViewTextBoxColumn5.HeaderText = "District"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ToolTipText = "Location District"
        Me.DataGridViewTextBoxColumn5.ValueMember = "District_rec_no"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "city_rec_no"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.CityBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ToolTipText = "Location City"
        Me.DataGridViewTextBoxColumn6.ValueMember = "City_rec_no"
        '
        'FrmMerchant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 437)
        Me.Controls.Add(Me.MerchantBindingNavigator)
        Me.Controls.Add(Me.MerchantDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMerchant"
        Me.Text = "Merchant Maintenance"
        CType(Me.MerchantDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MerchantBindingNavigator.ResumeLayout(False)
        Me.MerchantBindingNavigator.PerformLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MerchantDS As MerchantDS
    Friend WithEvents MerchantBindingSource As BindingSource
    Friend WithEvents MerchantTableAdapter As MerchantDSTableAdapters.merchantTableAdapter
    Friend WithEvents TableAdapterManager As MerchantDSTableAdapters.TableAdapterManager
    Friend WithEvents MerchantDataGridView As DataGridView
    Friend WithEvents MerchantBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MerchantBNavAddNewItem As ToolStripButton
    Friend WithEvents MerchantBNavEditItem As ToolStripButton
    Friend WithEvents MerchantBNavDeleteItem As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents MerchantBNavSaveItem As ToolStripButton
    Friend WithEvents MerchantBNavCancel As ToolStripButton
    Friend WithEvents Country As Country
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As CountryTableAdapters.CountryTableAdapter
    Friend WithEvents DistrictDS As DistrictDS
    Friend WithEvents DistrictBindingSource As BindingSource
    Friend WithEvents DistrictTableAdapter As DistrictDSTableAdapters.districtTableAdapter
    Friend WithEvents CityDS As CityDS
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents CityTableAdapter As CityDSTableAdapters.cityTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn

    'Friend WithEvents MerchantDS As MerchantDS
    'Friend WithEvents MerchantBindingSource As BindingSource
    'Friend WithEvents MerchantTableAdapter As MerchantDSTableAdapters.merchantTableAdapter
    'Friend WithEvents TableAdapterManager As MerchantDSTableAdapters.TableAdapterManager
    'Friend WithEvents MerchantBindingNavigator As BindingNavigator
    'Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    'Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    'Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    'Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    'Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    'Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    'Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    'Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    'Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    'Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    'Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    'Friend WithEvents MerchantBindingNavigatorSaveItem As ToolStripButton
    'Friend WithEvents MerchantDataGridView As DataGridView
    'Friend WithEvents CityDS As CityDS
    'Friend WithEvents CountryBindingSource As BindingSource
    'Friend WithEvents CountryTableAdapter As CityDSTableAdapters.countryTableAdapter
    'Friend WithEvents DistrictBindingSource As BindingSource
    'Friend WithEvents DistrictTableAdapter As CityDSTableAdapters.districtTableAdapter
    'Friend WithEvents CityBindingSource As BindingSource
    'Friend WithEvents CityTableAdapter As CityDSTableAdapters.cityTableAdapter
    'Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    'Friend WithEvents country_rec_no As DataGridViewComboBoxColumn
    'Friend WithEvents District_rec_no As DataGridViewComboBoxColumn
    'Friend WithEvents City_rec_no As DataGridViewComboBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    'Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
