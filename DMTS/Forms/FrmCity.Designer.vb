﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCity
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
        Dim Label2 As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCity))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CityDataGridView = New System.Windows.Forms.DataGridView()
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityDS = New DMTS.CityDS()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.TxtDSearch = New System.Windows.Forms.TextBox()
        Me.TxtCSearch = New System.Windows.Forms.TextBox()
        Me.CityTableAdapter = New DMTS.CityDSTableAdapters.cityTableAdapter()
        Me.TableAdapterManager = New DMTS.CityDSTableAdapters.TableAdapterManager()
        Me.CountryTableAdapter = New DMTS.CityDSTableAdapters.countryTableAdapter()
        Me.CountryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistrictTableAdapter = New DMTS.CityDSTableAdapters.districtTableAdapter()
        Me.DistrictDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CityBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CityBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.CityBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CityBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CityBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.CountryrecnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDistrict = New System.Windows.Forms.TextBox()
        Label2 = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CityBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Maroon
        Label2.Location = New System.Drawing.Point(33, 14)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 17)
        Label2.TabIndex = 10
        Label2.Text = "Search"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(28, 39)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(64, 17)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Country"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Maroon
        Label1.Location = New System.Drawing.Point(15, 14)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 17)
        Label1.TabIndex = 10
        Label1.Text = "Search"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(14, 39)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 17)
        Label3.TabIndex = 3
        Label3.Text = "District"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Maroon
        Label4.Location = New System.Drawing.Point(17, 45)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 17)
        Label4.TabIndex = 8
        Label4.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DistrictDataGridView)
        Me.GroupBox1.Controls.Add(Me.TxtCountry)
        Me.GroupBox1.Controls.Add(Me.CountryDataGridView)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCSearch)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 470)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDistrict)
        Me.GroupBox2.Controls.Add(Me.GroupControl1)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDSearch)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 395)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CityBindingNavigator)
        Me.GroupControl1.Controls.Add(Me.CityDataGridView)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.TxtSearch)
        Me.GroupControl1.Location = New System.Drawing.Point(18, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(326, 321)
        Me.GroupControl1.TabIndex = 11
        Me.GroupControl1.Text = "GroupControl1"
        '
        'CityDataGridView
        '
        Me.CityDataGridView.AutoGenerateColumns = False
        Me.CityDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CityDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.CityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CityDataGridView.DataSource = Me.CityBindingSource
        Me.CityDataGridView.Location = New System.Drawing.Point(21, 69)
        Me.CityDataGridView.Name = "CityDataGridView"
        Me.CityDataGridView.Size = New System.Drawing.Size(294, 247)
        Me.CityDataGridView.TabIndex = 9
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "district_city"
        Me.CityBindingSource.DataSource = Me.DistrictBindingSource
        '
        'DistrictBindingSource
        '
        Me.DistrictBindingSource.DataMember = "country_district"
        Me.DistrictBindingSource.DataSource = Me.CountryBindingSource
        '
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "country"
        Me.CountryBindingSource.DataSource = Me.CityDS
        '
        'CityDS
        '
        Me.CityDS.DataSetName = "CityDS"
        Me.CityDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Location = New System.Drawing.Point(78, 42)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(237, 21)
        Me.TxtSearch.TabIndex = 7
        '
        'TxtDSearch
        '
        Me.TxtDSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TxtDSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDSearch.Location = New System.Drawing.Point(76, 11)
        Me.TxtDSearch.Name = "TxtDSearch"
        Me.TxtDSearch.Size = New System.Drawing.Size(207, 20)
        Me.TxtDSearch.TabIndex = 9
        '
        'TxtCSearch
        '
        Me.TxtCSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TxtCSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCSearch.Location = New System.Drawing.Point(94, 11)
        Me.TxtCSearch.Name = "TxtCSearch"
        Me.TxtCSearch.Size = New System.Drawing.Size(207, 20)
        Me.TxtCSearch.TabIndex = 9
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cityTableAdapter = Me.CityTableAdapter
        Me.TableAdapterManager.UpdateOrder = DMTS.CityDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'CountryDataGridView
        '
        Me.CountryDataGridView.AllowUserToAddRows = False
        Me.CountryDataGridView.AllowUserToDeleteRows = False
        Me.CountryDataGridView.AllowUserToOrderColumns = True
        Me.CountryDataGridView.AutoGenerateColumns = False
        Me.CountryDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CountryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.CountryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CountryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountryrecnoDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.CountryDataGridView.DataSource = Me.CountryBindingSource
        Me.CountryDataGridView.Location = New System.Drawing.Point(388, 11)
        Me.CountryDataGridView.Name = "CountryDataGridView"
        Me.CountryDataGridView.ReadOnly = True
        Me.CountryDataGridView.Size = New System.Drawing.Size(244, 220)
        Me.CountryDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "country_rec_no"
        Me.DataGridViewTextBoxColumn5.HeaderText = "country_rec_no"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DistrictTableAdapter
        '
        Me.DistrictTableAdapter.ClearBeforeFill = True
        '
        'DistrictDataGridView
        '
        Me.DistrictDataGridView.AutoGenerateColumns = False
        Me.DistrictDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DistrictDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DistrictDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DistrictDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DistrictDataGridView.DataSource = Me.DistrictBindingSource
        Me.DistrictDataGridView.Location = New System.Drawing.Point(388, 235)
        Me.DistrictDataGridView.Name = "DistrictDataGridView"
        Me.DistrictDataGridView.Size = New System.Drawing.Size(244, 220)
        Me.DistrictDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "City_rec_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "City_rec_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "City"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "District_rec_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "District_rec_no"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Country_rec_no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Country_rec_no"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'CityBindingNavigator
        '
        Me.CityBindingNavigator.AddNewItem = Nothing
        Me.CityBindingNavigator.BindingSource = Me.CityBindingSource
        Me.CityBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.CityBindingNavigator.DeleteItem = Nothing
        Me.CityBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.CityBNavAddNewItem, Me.CityBNavEditItem, Me.CityBNavDeleteItem, Me.ToolStripSeparator4, Me.CityBNavSaveItem, Me.CityBNavCancel})
        Me.CityBindingNavigator.Location = New System.Drawing.Point(2, 2)
        Me.CityBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.CityBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.CityBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.CityBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.CityBindingNavigator.Name = "CityBindingNavigator"
        Me.CityBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.CityBindingNavigator.Size = New System.Drawing.Size(322, 25)
        Me.CityBindingNavigator.TabIndex = 10
        Me.CityBindingNavigator.Text = "BindingNavigator1"
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
        'CityBNavAddNewItem
        '
        Me.CityBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CityBNavAddNewItem.Image = CType(resources.GetObject("CityBNavAddNewItem.Image"), System.Drawing.Image)
        Me.CityBNavAddNewItem.Name = "CityBNavAddNewItem"
        Me.CityBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.CityBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.CityBNavAddNewItem.Text = "Add new"
        Me.CityBNavAddNewItem.ToolTipText = "Add New District"
        '
        'CityBNavEditItem
        '
        Me.CityBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CityBNavEditItem.Image = CType(resources.GetObject("CityBNavEditItem.Image"), System.Drawing.Image)
        Me.CityBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CityBNavEditItem.Name = "CityBNavEditItem"
        Me.CityBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.CityBNavEditItem.Text = "Edit Data"
        '
        'CityBNavDeleteItem
        '
        Me.CityBNavDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CityBNavDeleteItem.Enabled = False
        Me.CityBNavDeleteItem.Image = CType(resources.GetObject("CityBNavDeleteItem.Image"), System.Drawing.Image)
        Me.CityBNavDeleteItem.Name = "CityBNavDeleteItem"
        Me.CityBNavDeleteItem.RightToLeftAutoMirrorImage = True
        Me.CityBNavDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.CityBNavDeleteItem.Text = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'CityBNavSaveItem
        '
        Me.CityBNavSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CityBNavSaveItem.Enabled = False
        Me.CityBNavSaveItem.Image = CType(resources.GetObject("CityBNavSaveItem.Image"), System.Drawing.Image)
        Me.CityBNavSaveItem.Name = "CityBNavSaveItem"
        Me.CityBNavSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CityBNavSaveItem.Text = "Save Data"
        '
        'CityBNavCancel
        '
        Me.CityBNavCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CityBNavCancel.Enabled = False
        Me.CityBNavCancel.Image = CType(resources.GetObject("CityBNavCancel.Image"), System.Drawing.Image)
        Me.CityBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CityBNavCancel.Name = "CityBNavCancel"
        Me.CityBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.CityBNavCancel.Text = "Cancel Operation"
        '
        'TxtCountry
        '
        Me.TxtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CountryBindingSource, "description", True))
        Me.TxtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCountry.Location = New System.Drawing.Point(94, 39)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.ReadOnly = True
        Me.TxtCountry.Size = New System.Drawing.Size(207, 21)
        Me.TxtCountry.TabIndex = 12
        Me.TxtCountry.Text = "COUNTRY"
        '
        'CountryrecnoDataGridViewTextBoxColumn
        '
        Me.CountryrecnoDataGridViewTextBoxColumn.DataPropertyName = "country_rec_no"
        Me.CountryrecnoDataGridViewTextBoxColumn.HeaderText = "country_rec_no"
        Me.CountryrecnoDataGridViewTextBoxColumn.Name = "CountryrecnoDataGridViewTextBoxColumn"
        Me.CountryrecnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CountryrecnoDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "District_rec_no"
        Me.DataGridViewTextBoxColumn7.HeaderText = "District_rec_no"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn8.HeaderText = "District"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Country_rec_no"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Country_rec_no"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'TxtDistrict
        '
        Me.TxtDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDistrict.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DistrictBindingSource, "description", True))
        Me.TxtDistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDistrict.Location = New System.Drawing.Point(76, 36)
        Me.TxtDistrict.Name = "TxtDistrict"
        Me.TxtDistrict.ReadOnly = True
        Me.TxtDistrict.Size = New System.Drawing.Size(207, 21)
        Me.TxtDistrict.TabIndex = 12
        '
        'FrmCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 487)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCity"
        Me.Text = "City Maintenance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CityBindingNavigator.ResumeLayout(False)
        Me.CityBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCSearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtDSearch As TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents CityDS As CityDS
    Friend WithEvents CityTableAdapter As CityDSTableAdapters.cityTableAdapter
    Friend WithEvents TableAdapterManager As CityDSTableAdapters.TableAdapterManager
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As CityDSTableAdapters.countryTableAdapter
    Friend WithEvents CountryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DistrictBindingSource As BindingSource
    Friend WithEvents DistrictTableAdapter As CityDSTableAdapters.districtTableAdapter
    Friend WithEvents DistrictDataGridView As DataGridView
    Friend WithEvents CityDataGridView As DataGridView
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CityBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CityBNavAddNewItem As ToolStripButton
    Friend WithEvents CityBNavEditItem As ToolStripButton
    Friend WithEvents CityBNavDeleteItem As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents CityBNavSaveItem As ToolStripButton
    Friend WithEvents CityBNavCancel As ToolStripButton
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents CountryrecnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents TxtDistrict As TextBox
End Class
