<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDistrict
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDistrict))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CountryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistrictDS = New DMTS.DistrictDS()
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
        Me.CountryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistrictDataGridView = New System.Windows.Forms.DataGridView()
        Me.DistrictBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DistrictBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DistrictBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.DistrictBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DistrictBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DistrictBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.CountryTableAdapter = New DMTS.DistrictDSTableAdapters.countryTableAdapter()
        Me.TableAdapterManager = New DMTS.DistrictDSTableAdapters.TableAdapterManager()
        Me.DistrictTableAdapter = New DMTS.DistrictDSTableAdapters.districtTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCSearch = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.District_rec_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DescriptionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CountryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CountryBindingNavigator.SuspendLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DistrictBindingNavigator.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(6, 39)
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
        Label1.Location = New System.Drawing.Point(20, 52)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 17)
        Label1.TabIndex = 8
        Label1.Text = "Search"
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
        'CountryBindingNavigator
        '
        Me.CountryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CountryBindingNavigator.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CountryBindingNavigator.BindingSource = Me.CountryBindingSource
        Me.CountryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CountryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CountryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CountryBindingNavigatorSaveItem})
        Me.CountryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CountryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CountryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CountryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CountryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CountryBindingNavigator.Name = "CountryBindingNavigator"
        Me.CountryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CountryBindingNavigator.Size = New System.Drawing.Size(322, 25)
        Me.CountryBindingNavigator.TabIndex = 0
        Me.CountryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "country"
        Me.CountryBindingSource.DataSource = Me.DistrictDS
        Me.CountryBindingSource.Sort = "description"
        '
        'DistrictDS
        '
        Me.DistrictDS.DataSetName = "DistrictDS"
        Me.DistrictDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Visible = False
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
        'CountryBindingNavigatorSaveItem
        '
        Me.CountryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CountryBindingNavigatorSaveItem.Image = CType(resources.GetObject("CountryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CountryBindingNavigatorSaveItem.Name = "CountryBindingNavigatorSaveItem"
        Me.CountryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CountryBindingNavigatorSaveItem.Text = "Save Data"
        Me.CountryBindingNavigatorSaveItem.Visible = False
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CountryBindingSource, "description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.DescriptionTextBox.Location = New System.Drawing.Point(76, 37)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(207, 21)
        Me.DescriptionTextBox.TabIndex = 4
        Me.DescriptionTextBox.Text = "YAS"
        '
        'DistrictBindingSource
        '
        Me.DistrictBindingSource.AllowNew = True
        Me.DistrictBindingSource.DataMember = "country_district"
        Me.DistrictBindingSource.DataSource = Me.CountryBindingSource
        Me.DistrictBindingSource.Sort = "description"
        '
        'DistrictDataGridView
        '
        Me.DistrictDataGridView.AllowUserToAddRows = False
        Me.DistrictDataGridView.AutoGenerateColumns = False
        Me.DistrictDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DistrictDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DistrictDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DistrictDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.District_rec_no, Me.DataGridViewTextBoxColumn2})
        Me.DistrictDataGridView.DataSource = Me.DistrictBindingSource
        Me.DistrictDataGridView.Location = New System.Drawing.Point(24, 75)
        Me.DistrictDataGridView.MultiSelect = False
        Me.DistrictDataGridView.Name = "DistrictDataGridView"
        Me.DistrictDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DistrictDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.DistrictDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DistrictDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DistrictDataGridView.Size = New System.Drawing.Size(243, 220)
        Me.DistrictDataGridView.TabIndex = 5
        '
        'DistrictBindingNavigator
        '
        Me.DistrictBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DistrictBindingNavigator.BindingSource = Me.DistrictBindingSource
        Me.DistrictBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.DistrictBindingNavigator.DeleteItem = Nothing
        Me.DistrictBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.DistrictBNavAddNewItem, Me.DistrictBNavEditItem, Me.DistrictBNavDeleteItem, Me.ToolStripSeparator4, Me.DistrictBNavSaveItem, Me.DistrictBNavCancel})
        Me.DistrictBindingNavigator.Location = New System.Drawing.Point(2, 20)
        Me.DistrictBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.DistrictBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.DistrictBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.DistrictBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.DistrictBindingNavigator.Name = "DistrictBindingNavigator"
        Me.DistrictBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.DistrictBindingNavigator.Size = New System.Drawing.Size(288, 25)
        Me.DistrictBindingNavigator.TabIndex = 6
        Me.DistrictBindingNavigator.Text = "BindingNavigator1"
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
        'DistrictBNavAddNewItem
        '
        Me.DistrictBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DistrictBNavAddNewItem.Image = CType(resources.GetObject("DistrictBNavAddNewItem.Image"), System.Drawing.Image)
        Me.DistrictBNavAddNewItem.Name = "DistrictBNavAddNewItem"
        Me.DistrictBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.DistrictBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.DistrictBNavAddNewItem.Text = "Add new"
        Me.DistrictBNavAddNewItem.ToolTipText = "Add New District"
        '
        'DistrictBNavEditItem
        '
        Me.DistrictBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DistrictBNavEditItem.Image = CType(resources.GetObject("DistrictBNavEditItem.Image"), System.Drawing.Image)
        Me.DistrictBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DistrictBNavEditItem.Name = "DistrictBNavEditItem"
        Me.DistrictBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.DistrictBNavEditItem.Text = "Edit Data"
        '
        'DistrictBNavDeleteItem
        '
        Me.DistrictBNavDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DistrictBNavDeleteItem.Enabled = False
        Me.DistrictBNavDeleteItem.Image = CType(resources.GetObject("DistrictBNavDeleteItem.Image"), System.Drawing.Image)
        Me.DistrictBNavDeleteItem.Name = "DistrictBNavDeleteItem"
        Me.DistrictBNavDeleteItem.RightToLeftAutoMirrorImage = True
        Me.DistrictBNavDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.DistrictBNavDeleteItem.Text = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'DistrictBNavSaveItem
        '
        Me.DistrictBNavSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DistrictBNavSaveItem.Enabled = False
        Me.DistrictBNavSaveItem.Image = CType(resources.GetObject("DistrictBNavSaveItem.Image"), System.Drawing.Image)
        Me.DistrictBNavSaveItem.Name = "DistrictBNavSaveItem"
        Me.DistrictBNavSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DistrictBNavSaveItem.Text = "Save Data"
        '
        'DistrictBNavCancel
        '
        Me.DistrictBNavCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DistrictBNavCancel.Enabled = False
        Me.DistrictBNavCancel.Image = CType(resources.GetObject("DistrictBNavCancel.Image"), System.Drawing.Image)
        Me.DistrictBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DistrictBNavCancel.Name = "DistrictBNavCancel"
        Me.DistrictBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.DistrictBNavCancel.Text = "Cancel Operation"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.TxtSearch)
        Me.GroupControl1.Controls.Add(Me.DistrictDataGridView)
        Me.GroupControl1.Controls.Add(Me.DistrictBindingNavigator)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 101)
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(292, 300)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "BRANCH LISTING"
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Location = New System.Drawing.Point(80, 49)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(187, 21)
        Me.TxtSearch.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TxtSearch, "Search Districts")
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.countryTableAdapter = Me.CountryTableAdapter
        Me.TableAdapterManager.districtTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMTS.DistrictDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DistrictTableAdapter
        '
        Me.DistrictTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCSearch)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 67)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'TxtCSearch
        '
        Me.TxtCSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtCSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCSearch.Location = New System.Drawing.Point(76, 11)
        Me.TxtCSearch.Name = "TxtCSearch"
        Me.TxtCSearch.Size = New System.Drawing.Size(207, 20)
        Me.TxtCSearch.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.TxtCSearch, "Search Countries")
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'District_rec_no
        '
        Me.District_rec_no.DataPropertyName = "District_rec_no"
        Me.District_rec_no.HeaderText = "District_rec_no"
        Me.District_rec_no.Name = "District_rec_no"
        Me.District_rec_no.ReadOnly = True
        Me.District_rec_no.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Branch"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'FrmDistrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 413)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.CountryBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDistrict"
        Me.Text = "Branch Maintenance"
        CType(Me.CountryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CountryBindingNavigator.ResumeLayout(False)
        Me.CountryBindingNavigator.PerformLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DistrictBindingNavigator.ResumeLayout(False)
        Me.DistrictBindingNavigator.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DistrictDS As DistrictDS
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As DistrictDSTableAdapters.countryTableAdapter
    Friend WithEvents TableAdapterManager As DistrictDSTableAdapters.TableAdapterManager
    Friend WithEvents CountryBindingNavigator As BindingNavigator
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
    Friend WithEvents CountryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents DistrictBindingSource As BindingSource
    Friend WithEvents DistrictTableAdapter As DistrictDSTableAdapters.districtTableAdapter
    Friend WithEvents DistrictDataGridView As DataGridView
    Friend WithEvents DistrictBindingNavigator As BindingNavigator
    Friend WithEvents DistrictBNavAddNewItem As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents DistrictBNavDeleteItem As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DistrictBNavSaveItem As ToolStripButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DistrictBNavEditItem As ToolStripButton
    Friend WithEvents DistrictBNavCancel As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCSearch As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents District_rec_no As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
