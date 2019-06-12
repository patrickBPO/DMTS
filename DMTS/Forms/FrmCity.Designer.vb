<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCity))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CityDataGridView = New System.Windows.Forms.DataGridView()
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityDS = New DMTS.CityDS()
        Me.CityBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CityBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.TxtDSearch = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtCSearch = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CityTableAdapter = New DMTS.CityDSTableAdapters.cityTableAdapter()
        Me.TableAdapterManager = New DMTS.CityDSTableAdapters.TableAdapterManager()
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryTableAdapter = New DMTS.CityDSTableAdapters.countryTableAdapter()
        Me.CountryDataGridView = New System.Windows.Forms.DataGridView()
        Me.CountryrecnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistrictTableAdapter = New DMTS.CityDSTableAdapters.districtTableAdapter()
        Me.DistrictDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityrecnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistrictrecnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryrecnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.CityDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CityBindingNavigator.SuspendLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Maroon
        Label2.Location = New System.Drawing.Point(15, 14)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 17)
        Label2.TabIndex = 10
        Label2.Text = "Search"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(10, 39)
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
        Label4.Location = New System.Drawing.Point(8, 45)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 17)
        Label4.TabIndex = 8
        Label4.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCSearch)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 455)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupControl1)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDSearch)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 377)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CityDataGridView1)
        Me.GroupControl1.Controls.Add(Me.CityDataGridView)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.CityBindingNavigator)
        Me.GroupControl1.Controls.Add(Me.TxtSearch)
        Me.GroupControl1.Location = New System.Drawing.Point(18, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(326, 300)
        Me.GroupControl1.TabIndex = 11
        Me.GroupControl1.Text = "GroupControl1"
        '
        'CityDataGridView
        '
        Me.CityDataGridView.AllowUserToAddRows = False
        Me.CityDataGridView.AutoGenerateColumns = False
        Me.CityDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CityDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CityrecnoDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn1, Me.DistrictrecnoDataGridViewTextBoxColumn, Me.CountryrecnoDataGridViewTextBoxColumn1})
        Me.CityDataGridView.DataSource = Me.CityBindingSource
        Me.CityDataGridView.Location = New System.Drawing.Point(11, 71)
        Me.CityDataGridView.Name = "CityDataGridView"
        Me.CityDataGridView.ReadOnly = True
        Me.CityDataGridView.Size = New System.Drawing.Size(295, 220)
        Me.CityDataGridView.TabIndex = 10
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "city"
        Me.CityBindingSource.DataSource = Me.CityDS
        '
        'CityDS
        '
        Me.CityDS.DataSetName = "CityDS"
        Me.CityDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CityBindingNavigator
        '
        Me.CityBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CityBindingNavigator.BindingSource = Me.CityBindingSource
        Me.CityBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CityBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CityBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CityBindingNavigatorSaveItem})
        Me.CityBindingNavigator.Location = New System.Drawing.Point(2, 2)
        Me.CityBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CityBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CityBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CityBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CityBindingNavigator.Name = "CityBindingNavigator"
        Me.CityBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CityBindingNavigator.Size = New System.Drawing.Size(322, 25)
        Me.CityBindingNavigator.TabIndex = 10
        Me.CityBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'CityBindingNavigatorSaveItem
        '
        Me.CityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CityBindingNavigatorSaveItem.Image = CType(resources.GetObject("CityBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CityBindingNavigatorSaveItem.Name = "CityBindingNavigatorSaveItem"
        Me.CityBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CityBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Location = New System.Drawing.Point(69, 42)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(187, 21)
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
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.ForestGreen
        Me.TextBox2.Location = New System.Drawing.Point(76, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(207, 21)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "DISTRICT"
        '
        'TxtCSearch
        '
        Me.TxtCSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TxtCSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCSearch.Location = New System.Drawing.Point(76, 11)
        Me.TxtCSearch.Name = "TxtCSearch"
        Me.TxtCSearch.Size = New System.Drawing.Size(207, 20)
        Me.TxtCSearch.TabIndex = 9
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.DescriptionTextBox.Location = New System.Drawing.Point(76, 37)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(207, 21)
        Me.DescriptionTextBox.TabIndex = 4
        Me.DescriptionTextBox.Text = "COUNTRY"
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
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "country"
        Me.CountryBindingSource.DataSource = Me.CityDS
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'CountryDataGridView
        '
        Me.CountryDataGridView.AutoGenerateColumns = False
        Me.CountryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CountryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountryrecnoDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.CountryDataGridView.DataSource = Me.CountryBindingSource
        Me.CountryDataGridView.Location = New System.Drawing.Point(428, 32)
        Me.CountryDataGridView.Name = "CountryDataGridView"
        Me.CountryDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.CountryDataGridView.TabIndex = 9
        '
        'CountryrecnoDataGridViewTextBoxColumn
        '
        Me.CountryrecnoDataGridViewTextBoxColumn.DataPropertyName = "country_rec_no"
        Me.CountryrecnoDataGridViewTextBoxColumn.HeaderText = "country_rec_no"
        Me.CountryrecnoDataGridViewTextBoxColumn.Name = "CountryrecnoDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
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
        'DistrictBindingSource
        '
        Me.DistrictBindingSource.DataMember = "country_district"
        Me.DistrictBindingSource.DataSource = Me.CountryBindingSource
        '
        'DistrictTableAdapter
        '
        Me.DistrictTableAdapter.ClearBeforeFill = True
        '
        'DistrictDataGridView
        '
        Me.DistrictDataGridView.AutoGenerateColumns = False
        Me.DistrictDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DistrictDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DistrictDataGridView.DataSource = Me.DistrictBindingSource
        Me.DistrictDataGridView.Location = New System.Drawing.Point(438, 229)
        Me.DistrictDataGridView.Name = "DistrictDataGridView"
        Me.DistrictDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DistrictDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "District_rec_no"
        Me.DataGridViewTextBoxColumn7.HeaderText = "District_rec_no"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn8.HeaderText = "description"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Country_rec_no"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Country_rec_no"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'CityrecnoDataGridViewTextBoxColumn
        '
        Me.CityrecnoDataGridViewTextBoxColumn.DataPropertyName = "City_rec_no"
        Me.CityrecnoDataGridViewTextBoxColumn.HeaderText = "City_rec_no"
        Me.CityrecnoDataGridViewTextBoxColumn.Name = "CityrecnoDataGridViewTextBoxColumn"
        Me.CityrecnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn1
        '
        Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
        Me.DescriptionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DistrictrecnoDataGridViewTextBoxColumn
        '
        Me.DistrictrecnoDataGridViewTextBoxColumn.DataPropertyName = "District_rec_no"
        Me.DistrictrecnoDataGridViewTextBoxColumn.HeaderText = "District_rec_no"
        Me.DistrictrecnoDataGridViewTextBoxColumn.Name = "DistrictrecnoDataGridViewTextBoxColumn"
        Me.DistrictrecnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountryrecnoDataGridViewTextBoxColumn1
        '
        Me.CountryrecnoDataGridViewTextBoxColumn1.DataPropertyName = "Country_rec_no"
        Me.CountryrecnoDataGridViewTextBoxColumn1.HeaderText = "Country_rec_no"
        Me.CountryrecnoDataGridViewTextBoxColumn1.Name = "CountryrecnoDataGridViewTextBoxColumn1"
        Me.CountryrecnoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CityBindingSource1
        '
        Me.CityBindingSource1.DataMember = "district_city"
        Me.CityBindingSource1.DataSource = Me.DistrictBindingSource
        '
        'CityDataGridView1
        '
        Me.CityDataGridView1.AutoGenerateColumns = False
        Me.CityDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CityDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CityDataGridView1.DataSource = Me.CityBindingSource1
        Me.CityDataGridView1.Location = New System.Drawing.Point(21, 69)
        Me.CityDataGridView1.Name = "CityDataGridView1"
        Me.CityDataGridView1.Size = New System.Drawing.Size(300, 220)
        Me.CityDataGridView1.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "City_rec_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "City_rec_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "District_rec_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "District_rec_no"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Country_rec_no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Country_rec_no"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FrmCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 516)
        Me.Controls.Add(Me.DistrictDataGridView)
        Me.Controls.Add(Me.CountryDataGridView)
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
        CType(Me.CityDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CityBindingNavigator.ResumeLayout(False)
        Me.CityBindingNavigator.PerformLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCSearch As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtDSearch As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents CityDS As CityDS
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents CityTableAdapter As CityDSTableAdapters.cityTableAdapter
    Friend WithEvents TableAdapterManager As CityDSTableAdapters.TableAdapterManager
    Friend WithEvents CityBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CityBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CityDataGridView As DataGridView
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As CityDSTableAdapters.countryTableAdapter
    Friend WithEvents CountryDataGridView As DataGridView
    Friend WithEvents CountryrecnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DistrictBindingSource As BindingSource
    Friend WithEvents DistrictTableAdapter As CityDSTableAdapters.districtTableAdapter
    Friend WithEvents DistrictDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents CityrecnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DistrictrecnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryrecnoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CityBindingSource1 As BindingSource
End Class
