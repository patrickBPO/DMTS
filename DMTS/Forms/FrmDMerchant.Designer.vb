<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDMerchant
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
        Dim Merchant_rec_noLabel As System.Windows.Forms.Label
        Dim Merchant_idLabel As System.Windows.Forms.Label
        Dim M_nameLabel As System.Windows.Forms.Label
        Dim M_contactLabel As System.Windows.Forms.Label
        Dim M_emailLabel As System.Windows.Forms.Label
        Dim RateLabel As System.Windows.Forms.Label
        Dim Country_rec_noLabel As System.Windows.Forms.Label
        Dim District_rec_noLabel As System.Windows.Forms.Label
        Dim City_rec_noLabel As System.Windows.Forms.Label
        Dim Phone_1Label1 As System.Windows.Forms.Label
        Dim Phone_2Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDMerchant))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Merchant_idTextBox = New System.Windows.Forms.TextBox()
        Me.MerchantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantDS = New DMTS.MerchantDS()
        Me.Phone_2MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.M_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.M_contactTextBox = New System.Windows.Forms.TextBox()
        Me.RateTextBox = New System.Windows.Forms.TextBox()
        Me.M_emailTextBox = New System.Windows.Forms.TextBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Country_rec_noComboBox = New System.Windows.Forms.ComboBox()
        Me.District_rec_noComboBox = New System.Windows.Forms.ComboBox()
        Me.City_rec_noComboBox = New System.Windows.Forms.ComboBox()
        Me.MerchantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MerchantBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Merchant_rec_noTextBox = New System.Windows.Forms.TextBox()
        Me.MerchantTableAdapter = New DMTS.MerchantDSTableAdapters.merchantTableAdapter()
        Me.TableAdapterManager = New DMTS.MerchantDSTableAdapters.TableAdapterManager()
        Me.Country = New DMTS.Country()
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryTableAdapter = New DMTS.CountryTableAdapters.CountryTableAdapter()
        Me.District = New DMTS.District()
        Me.DistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistrictTableAdapter = New DMTS.DistrictTableAdapters.DistrictTableAdapter()
        Me.City = New DMTS.City()
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityTableAdapter = New DMTS.CityTableAdapters.cityTableAdapter()
        Merchant_rec_noLabel = New System.Windows.Forms.Label()
        Merchant_idLabel = New System.Windows.Forms.Label()
        M_nameLabel = New System.Windows.Forms.Label()
        M_contactLabel = New System.Windows.Forms.Label()
        M_emailLabel = New System.Windows.Forms.Label()
        RateLabel = New System.Windows.Forms.Label()
        Country_rec_noLabel = New System.Windows.Forms.Label()
        District_rec_noLabel = New System.Windows.Forms.Label()
        City_rec_noLabel = New System.Windows.Forms.Label()
        Phone_1Label1 = New System.Windows.Forms.Label()
        Phone_2Label1 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MerchantBindingNavigator.SuspendLayout()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.City, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Merchant_rec_noLabel
        '
        Merchant_rec_noLabel.AutoSize = True
        Merchant_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Merchant_rec_noLabel.Location = New System.Drawing.Point(6, 53)
        Merchant_rec_noLabel.Name = "Merchant_rec_noLabel"
        Merchant_rec_noLabel.Size = New System.Drawing.Size(59, 13)
        Merchant_rec_noLabel.TabIndex = 0
        Merchant_rec_noLabel.Text = "Record #"
        '
        'Merchant_idLabel
        '
        Merchant_idLabel.AutoSize = True
        Merchant_idLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Merchant_idLabel.Location = New System.Drawing.Point(21, 27)
        Merchant_idLabel.Name = "Merchant_idLabel"
        Merchant_idLabel.Size = New System.Drawing.Size(77, 13)
        Merchant_idLabel.TabIndex = 3
        Merchant_idLabel.Text = "Merchant ID"
        '
        'M_nameLabel
        '
        M_nameLabel.AutoSize = True
        M_nameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        M_nameLabel.Location = New System.Drawing.Point(160, 28)
        M_nameLabel.Name = "M_nameLabel"
        M_nameLabel.Size = New System.Drawing.Size(96, 13)
        M_nameLabel.TabIndex = 5
        M_nameLabel.Text = "Merchant Name"
        '
        'M_contactLabel
        '
        M_contactLabel.AutoSize = True
        M_contactLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        M_contactLabel.Location = New System.Drawing.Point(331, 28)
        M_contactLabel.Name = "M_contactLabel"
        M_contactLabel.Size = New System.Drawing.Size(51, 13)
        M_contactLabel.TabIndex = 7
        M_contactLabel.Text = "Contact"
        '
        'M_emailLabel
        '
        M_emailLabel.AutoSize = True
        M_emailLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        M_emailLabel.Location = New System.Drawing.Point(57, 75)
        M_emailLabel.Name = "M_emailLabel"
        M_emailLabel.Size = New System.Drawing.Size(84, 13)
        M_emailLabel.TabIndex = 9
        M_emailLabel.Text = "Contact Email"
        '
        'RateLabel
        '
        RateLabel.AutoSize = True
        RateLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        RateLabel.Location = New System.Drawing.Point(389, 74)
        RateLabel.Name = "RateLabel"
        RateLabel.Size = New System.Drawing.Size(34, 13)
        RateLabel.TabIndex = 15
        RateLabel.Text = "Rate"
        '
        'Country_rec_noLabel
        '
        Country_rec_noLabel.AutoSize = True
        Country_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Country_rec_noLabel.Location = New System.Drawing.Point(4, 36)
        Country_rec_noLabel.Name = "Country_rec_noLabel"
        Country_rec_noLabel.Size = New System.Drawing.Size(52, 13)
        Country_rec_noLabel.TabIndex = 17
        Country_rec_noLabel.Text = "Country"
        '
        'District_rec_noLabel
        '
        District_rec_noLabel.AutoSize = True
        District_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        District_rec_noLabel.Location = New System.Drawing.Point(8, 63)
        District_rec_noLabel.Name = "District_rec_noLabel"
        District_rec_noLabel.Size = New System.Drawing.Size(48, 13)
        District_rec_noLabel.TabIndex = 19
        District_rec_noLabel.Text = "District"
        '
        'City_rec_noLabel
        '
        City_rec_noLabel.AutoSize = True
        City_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        City_rec_noLabel.Location = New System.Drawing.Point(28, 90)
        City_rec_noLabel.Name = "City_rec_noLabel"
        City_rec_noLabel.Size = New System.Drawing.Size(29, 13)
        City_rec_noLabel.TabIndex = 21
        City_rec_noLabel.Text = "City"
        '
        'Phone_1Label1
        '
        Phone_1Label1.AutoSize = True
        Phone_1Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Phone_1Label1.Location = New System.Drawing.Point(200, 74)
        Phone_1Label1.Name = "Phone_1Label1"
        Phone_1Label1.Size = New System.Drawing.Size(52, 13)
        Phone_1Label1.TabIndex = 23
        Phone_1Label1.Text = "Phone 1"
        '
        'Phone_2Label1
        '
        Phone_2Label1.AutoSize = True
        Phone_2Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Phone_2Label1.Location = New System.Drawing.Point(303, 74)
        Phone_2Label1.Name = "Phone_2Label1"
        Phone_2Label1.Size = New System.Drawing.Size(52, 13)
        Phone_2Label1.TabIndex = 25
        Phone_2Label1.Text = "Phone 2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.GroupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.MediumSpringGreen
        Me.GroupControl1.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.MerchantBindingNavigator)
        Me.GroupControl1.Controls.Add(Merchant_rec_noLabel)
        Me.GroupControl1.Controls.Add(Me.Merchant_rec_noTextBox)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(769, 221)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "MERCHANTS"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(M_nameLabel)
        Me.GroupControl3.Controls.Add(Phone_2Label1)
        Me.GroupControl3.Controls.Add(Me.Merchant_idTextBox)
        Me.GroupControl3.Controls.Add(Me.Phone_2MaskedTextBox)
        Me.GroupControl3.Controls.Add(Merchant_idLabel)
        Me.GroupControl3.Controls.Add(Phone_1Label1)
        Me.GroupControl3.Controls.Add(Me.M_nameTextBox)
        Me.GroupControl3.Controls.Add(Me.Phone_1MaskedTextBox)
        Me.GroupControl3.Controls.Add(Me.M_contactTextBox)
        Me.GroupControl3.Controls.Add(RateLabel)
        Me.GroupControl3.Controls.Add(M_contactLabel)
        Me.GroupControl3.Controls.Add(Me.RateTextBox)
        Me.GroupControl3.Controls.Add(Me.M_emailTextBox)
        Me.GroupControl3.Controls.Add(M_emailLabel)
        Me.GroupControl3.Location = New System.Drawing.Point(14, 77)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(439, 122)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Merchant Details"
        '
        'Merchant_idTextBox
        '
        Me.Merchant_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "merchant_id", True))
        Me.Merchant_idTextBox.Location = New System.Drawing.Point(10, 44)
        Me.Merchant_idTextBox.Name = "Merchant_idTextBox"
        Me.Merchant_idTextBox.Size = New System.Drawing.Size(84, 21)
        Me.Merchant_idTextBox.TabIndex = 4
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
        'Phone_2MaskedTextBox
        '
        Me.Phone_2MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "phone_2", True))
        Me.Phone_2MaskedTextBox.Location = New System.Drawing.Point(276, 91)
        Me.Phone_2MaskedTextBox.Mask = "(5\01) 000-0000"
        Me.Phone_2MaskedTextBox.Name = "Phone_2MaskedTextBox"
        Me.Phone_2MaskedTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Phone_2MaskedTextBox.TabIndex = 26
        '
        'M_nameTextBox
        '
        Me.M_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "m_name", True))
        Me.M_nameTextBox.Location = New System.Drawing.Point(117, 45)
        Me.M_nameTextBox.Name = "M_nameTextBox"
        Me.M_nameTextBox.Size = New System.Drawing.Size(144, 21)
        Me.M_nameTextBox.TabIndex = 6
        '
        'Phone_1MaskedTextBox
        '
        Me.Phone_1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "phone_1", True))
        Me.Phone_1MaskedTextBox.Location = New System.Drawing.Point(170, 91)
        Me.Phone_1MaskedTextBox.Mask = "(5\01) 000-0000"
        Me.Phone_1MaskedTextBox.Name = "Phone_1MaskedTextBox"
        Me.Phone_1MaskedTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Phone_1MaskedTextBox.TabIndex = 24
        '
        'M_contactTextBox
        '
        Me.M_contactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "m_contact", True))
        Me.M_contactTextBox.Location = New System.Drawing.Point(285, 45)
        Me.M_contactTextBox.Name = "M_contactTextBox"
        Me.M_contactTextBox.Size = New System.Drawing.Size(144, 21)
        Me.M_contactTextBox.TabIndex = 8
        '
        'RateTextBox
        '
        Me.RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "rate", True))
        Me.RateTextBox.Location = New System.Drawing.Point(382, 91)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.Size = New System.Drawing.Size(47, 21)
        Me.RateTextBox.TabIndex = 16
        '
        'M_emailTextBox
        '
        Me.M_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "m_email", True))
        Me.M_emailTextBox.Location = New System.Drawing.Point(9, 92)
        Me.M_emailTextBox.Name = "M_emailTextBox"
        Me.M_emailTextBox.Size = New System.Drawing.Size(155, 21)
        Me.M_emailTextBox.TabIndex = 10
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Country_rec_noComboBox)
        Me.GroupControl2.Controls.Add(Country_rec_noLabel)
        Me.GroupControl2.Controls.Add(Me.District_rec_noComboBox)
        Me.GroupControl2.Controls.Add(District_rec_noLabel)
        Me.GroupControl2.Controls.Add(City_rec_noLabel)
        Me.GroupControl2.Controls.Add(Me.City_rec_noComboBox)
        Me.GroupControl2.Location = New System.Drawing.Point(459, 77)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(292, 122)
        Me.GroupControl2.TabIndex = 27
        Me.GroupControl2.Text = "Location"
        '
        'Country_rec_noComboBox
        '
        Me.Country_rec_noComboBox.DataSource = Me.CountryBindingSource
        Me.Country_rec_noComboBox.DisplayMember = "description"
        Me.Country_rec_noComboBox.FormattingEnabled = True
        Me.Country_rec_noComboBox.Location = New System.Drawing.Point(100, 31)
        Me.Country_rec_noComboBox.Name = "Country_rec_noComboBox"
        Me.Country_rec_noComboBox.Size = New System.Drawing.Size(182, 21)
        Me.Country_rec_noComboBox.TabIndex = 18
        Me.Country_rec_noComboBox.ValueMember = "country_rec_no"
        '
        'District_rec_noComboBox
        '
        Me.District_rec_noComboBox.DataSource = Me.DistrictBindingSource
        Me.District_rec_noComboBox.DisplayMember = "description"
        Me.District_rec_noComboBox.FormattingEnabled = True
        Me.District_rec_noComboBox.Location = New System.Drawing.Point(100, 58)
        Me.District_rec_noComboBox.Name = "District_rec_noComboBox"
        Me.District_rec_noComboBox.Size = New System.Drawing.Size(182, 21)
        Me.District_rec_noComboBox.TabIndex = 20
        Me.District_rec_noComboBox.ValueMember = "District_rec_no"
        '
        'City_rec_noComboBox
        '
        Me.City_rec_noComboBox.DataSource = Me.CityBindingSource
        Me.City_rec_noComboBox.DisplayMember = "Description"
        Me.City_rec_noComboBox.FormattingEnabled = True
        Me.City_rec_noComboBox.Location = New System.Drawing.Point(100, 85)
        Me.City_rec_noComboBox.Name = "City_rec_noComboBox"
        Me.City_rec_noComboBox.Size = New System.Drawing.Size(182, 21)
        Me.City_rec_noComboBox.TabIndex = 22
        Me.City_rec_noComboBox.ValueMember = "City_rec_no"
        '
        'MerchantBindingNavigator
        '
        Me.MerchantBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MerchantBindingNavigator.BindingSource = Me.MerchantBindingSource
        Me.MerchantBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MerchantBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MerchantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MerchantBindingNavigatorSaveItem})
        Me.MerchantBindingNavigator.Location = New System.Drawing.Point(2, 20)
        Me.MerchantBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MerchantBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MerchantBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MerchantBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MerchantBindingNavigator.Name = "MerchantBindingNavigator"
        Me.MerchantBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MerchantBindingNavigator.Size = New System.Drawing.Size(765, 25)
        Me.MerchantBindingNavigator.TabIndex = 1
        Me.MerchantBindingNavigator.Text = "BindingNavigator1"
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
        'MerchantBindingNavigatorSaveItem
        '
        Me.MerchantBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MerchantBindingNavigatorSaveItem.Image = CType(resources.GetObject("MerchantBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MerchantBindingNavigatorSaveItem.Name = "MerchantBindingNavigatorSaveItem"
        Me.MerchantBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MerchantBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Merchant_rec_noTextBox
        '
        Me.Merchant_rec_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "merchant_rec_no", True))
        Me.Merchant_rec_noTextBox.Location = New System.Drawing.Point(69, 50)
        Me.Merchant_rec_noTextBox.Name = "Merchant_rec_noTextBox"
        Me.Merchant_rec_noTextBox.ReadOnly = True
        Me.Merchant_rec_noTextBox.Size = New System.Drawing.Size(80, 21)
        Me.Merchant_rec_noTextBox.TabIndex = 1
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
        'District
        '
        Me.District.DataSetName = "District"
        Me.District.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistrictBindingSource
        '
        Me.DistrictBindingSource.DataMember = "District"
        Me.DistrictBindingSource.DataSource = Me.District
        '
        'DistrictTableAdapter
        '
        Me.DistrictTableAdapter.ClearBeforeFill = True
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
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'FrmDMerchant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 246)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDMerchant"
        Me.Text = "Merchant Maintenance"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MerchantBindingNavigator.ResumeLayout(False)
        Me.MerchantBindingNavigator.PerformLayout()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.City, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MerchantDS As MerchantDS
    Friend WithEvents MerchantBindingSource As BindingSource
    Friend WithEvents MerchantTableAdapter As MerchantDSTableAdapters.merchantTableAdapter
    Friend WithEvents TableAdapterManager As MerchantDSTableAdapters.TableAdapterManager
    Friend WithEvents MerchantBindingNavigator As BindingNavigator
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
    Friend WithEvents MerchantBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Merchant_idTextBox As TextBox
    Friend WithEvents Phone_2MaskedTextBox As MaskedTextBox
    Friend WithEvents M_nameTextBox As TextBox
    Friend WithEvents Phone_1MaskedTextBox As MaskedTextBox
    Friend WithEvents M_contactTextBox As TextBox
    Friend WithEvents RateTextBox As TextBox
    Friend WithEvents M_emailTextBox As TextBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Country_rec_noComboBox As ComboBox
    Friend WithEvents District_rec_noComboBox As ComboBox
    Friend WithEvents City_rec_noComboBox As ComboBox
    Friend WithEvents Merchant_rec_noTextBox As TextBox
    Friend WithEvents Country As Country
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As CountryTableAdapters.CountryTableAdapter
    Friend WithEvents District As District
    Friend WithEvents DistrictBindingSource As BindingSource
    Friend WithEvents DistrictTableAdapter As DistrictTableAdapters.DistrictTableAdapter
    Friend WithEvents City As City
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents CityTableAdapter As CityTableAdapters.cityTableAdapter
End Class
