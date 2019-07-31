<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMerchantLoc
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
        Dim Merchant_rec_noLabel As System.Windows.Forms.Label
        Dim M_nameLabel As System.Windows.Forms.Label
        Dim Phone_2Label1 As System.Windows.Forms.Label
        Dim Merchant_idLabel As System.Windows.Forms.Label
        Dim Phone_1Label1 As System.Windows.Forms.Label
        Dim RateLabel As System.Windows.Forms.Label
        Dim M_contactLabel As System.Windows.Forms.Label
        Dim M_emailLabel As System.Windows.Forms.Label
        Dim Country_rec_noLabel As System.Windows.Forms.Label
        Dim District_rec_noLabel As System.Windows.Forms.Label
        Dim City_rec_noLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMerchantLoc))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Merchant_rec_noTextBox = New System.Windows.Forms.TextBox()
        Me.MerchantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantLocDS = New DMTS.MerchantLocDS()
        Me.GCMLocation = New DevExpress.XtraEditors.GroupControl()
        Me.Country_rec_noComboBox = New System.Windows.Forms.ComboBox()
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Country = New DMTS.Country()
        Me.District_rec_noComboBox = New System.Windows.Forms.ComboBox()
        Me.DistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.District = New DMTS.District()
        Me.City_rec_noComboBox = New System.Windows.Forms.ComboBox()
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.City = New DMTS.City()
        Me.GCMDetails = New DevExpress.XtraEditors.GroupControl()
        Me.Merchant_idTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_2MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.M_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.M_contactTextBox = New System.Windows.Forms.TextBox()
        Me.RateTextBox = New System.Windows.Forms.TextBox()
        Me.M_emailTextBox = New System.Windows.Forms.TextBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Ml_rec_noTextBox = New System.Windows.Forms.TextBox()
        Me.Merch_locBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtMLSearch = New System.Windows.Forms.TextBox()
        Me.GCMLLocation = New DevExpress.XtraEditors.GroupControl()
        Me.CboMLCountry = New System.Windows.Forms.ComboBox()
        Me.Merch_locBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantmerchlocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboMLDistrict = New System.Windows.Forms.ComboBox()
        Me.DistrictBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboMLCity = New System.Windows.Forms.ComboBox()
        Me.CityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GCMLDetails = New DevExpress.XtraEditors.GroupControl()
        Me.TxtLocID = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Merch_locBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.merch_locBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.merch_locBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.merch_locBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.merch_locBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.merch_locBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.Merch_locTableAdapter = New DMTS.MerchantLocDSTableAdapters.merch_locTableAdapter()
        Me.TableAdapterManager = New DMTS.MerchantLocDSTableAdapters.TableAdapterManager()
        Me.MerchantTableAdapter = New DMTS.MerchantLocDSTableAdapters.merchantTableAdapter()
        Me.MerchantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.CountryTableAdapter = New DMTS.CountryTableAdapters.CountryTableAdapter()
        Me.DistrictTableAdapter = New DMTS.DistrictTableAdapters.DistrictTableAdapter()
        Me.CityTableAdapter = New DMTS.CityTableAdapters.cityTableAdapter()
        Me.TTCMSearch = New DevExpress.Utils.ToolTipController(Me.components)
        Me.TTCMLSearch = New DevExpress.Utils.ToolTipController(Me.components)
        Merchant_rec_noLabel = New System.Windows.Forms.Label()
        M_nameLabel = New System.Windows.Forms.Label()
        Phone_2Label1 = New System.Windows.Forms.Label()
        Merchant_idLabel = New System.Windows.Forms.Label()
        Phone_1Label1 = New System.Windows.Forms.Label()
        RateLabel = New System.Windows.Forms.Label()
        M_contactLabel = New System.Windows.Forms.Label()
        M_emailLabel = New System.Windows.Forms.Label()
        Country_rec_noLabel = New System.Windows.Forms.Label()
        District_rec_noLabel = New System.Windows.Forms.Label()
        City_rec_noLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantLocDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCMLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCMLocation.SuspendLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.City, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCMDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCMDetails.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Merch_locBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCMLLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCMLLocation.SuspendLayout()
        CType(Me.Merch_locBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantmerchlocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistrictBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCMLDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCMLDetails.SuspendLayout()
        CType(Me.Merch_locBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Merch_locBindingNavigator.SuspendLayout()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MerchantBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Merchant_rec_noLabel
        '
        Merchant_rec_noLabel.AutoSize = True
        Merchant_rec_noLabel.Location = New System.Drawing.Point(206, 26)
        Merchant_rec_noLabel.Name = "Merchant_rec_noLabel"
        Merchant_rec_noLabel.Size = New System.Drawing.Size(89, 13)
        Merchant_rec_noLabel.TabIndex = 1
        Merchant_rec_noLabel.Text = "merchant rec no:"
        '
        'M_nameLabel
        '
        M_nameLabel.AutoSize = True
        M_nameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        M_nameLabel.Location = New System.Drawing.Point(145, 28)
        M_nameLabel.Name = "M_nameLabel"
        M_nameLabel.Size = New System.Drawing.Size(96, 13)
        M_nameLabel.TabIndex = 5
        M_nameLabel.Text = "Merchant Name"
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
        'Merchant_idLabel
        '
        Merchant_idLabel.AutoSize = True
        Merchant_idLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Merchant_idLabel.Location = New System.Drawing.Point(15, 27)
        Merchant_idLabel.Name = "Merchant_idLabel"
        Merchant_idLabel.Size = New System.Drawing.Size(77, 13)
        Merchant_idLabel.TabIndex = 3
        Merchant_idLabel.Text = "Merchant ID"
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
        M_emailLabel.Location = New System.Drawing.Point(46, 75)
        M_emailLabel.Name = "M_emailLabel"
        M_emailLabel.Size = New System.Drawing.Size(84, 13)
        M_emailLabel.TabIndex = 9
        M_emailLabel.Text = "Contact Email"
        '
        'Country_rec_noLabel
        '
        Country_rec_noLabel.AutoSize = True
        Country_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Country_rec_noLabel.Location = New System.Drawing.Point(60, 34)
        Country_rec_noLabel.Name = "Country_rec_noLabel"
        Country_rec_noLabel.Size = New System.Drawing.Size(52, 13)
        Country_rec_noLabel.TabIndex = 17
        Country_rec_noLabel.Text = "Country"
        '
        'District_rec_noLabel
        '
        District_rec_noLabel.AutoSize = True
        District_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        District_rec_noLabel.Location = New System.Drawing.Point(4, 61)
        District_rec_noLabel.Name = "District_rec_noLabel"
        District_rec_noLabel.Size = New System.Drawing.Size(108, 13)
        District_rec_noLabel.TabIndex = 19
        District_rec_noLabel.Text = "City/Town/Village"
        '
        'City_rec_noLabel
        '
        City_rec_noLabel.AutoSize = True
        City_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        City_rec_noLabel.Location = New System.Drawing.Point(66, 88)
        City_rec_noLabel.Name = "City_rec_noLabel"
        City_rec_noLabel.Size = New System.Drawing.Size(46, 13)
        City_rec_noLabel.TabIndex = 21
        City_rec_noLabel.Text = "Branch"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(647, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 29
        Label1.Text = "Record #"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(64, 34)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 17
        Label2.Text = "Country"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label3.Location = New System.Drawing.Point(8, 61)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(108, 13)
        Label3.TabIndex = 19
        Label3.Text = "City/Town/Village"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label4.Location = New System.Drawing.Point(70, 88)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(46, 13)
        Label4.TabIndex = 21
        Label4.Text = "Branch"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label5.Location = New System.Drawing.Point(133, 27)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(147, 13)
        Label5.TabIndex = 5
        Label5.Text = "Merchant Location Name"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label6.Location = New System.Drawing.Point(303, 74)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(52, 13)
        Label6.TabIndex = 25
        Label6.Text = "Phone 2"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label7.Location = New System.Drawing.Point(15, 27)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(71, 13)
        Label7.TabIndex = 3
        Label7.Text = "Location ID"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label8.Location = New System.Drawing.Point(200, 74)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(52, 13)
        Label8.TabIndex = 23
        Label8.Text = "Phone 1"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label9.Location = New System.Drawing.Point(384, 74)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(79, 13)
        Label9.TabIndex = 15
        Label9.Text = "Shadow Acct"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(366, 28)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(51, 13)
        Label10.TabIndex = 7
        Label10.Text = "Contact"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label11.Location = New System.Drawing.Point(47, 75)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(84, 13)
        Label11.TabIndex = 9
        Label11.Text = "Contact Email"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Maroon
        Label12.Location = New System.Drawing.Point(14, 63)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(59, 17)
        Label12.TabIndex = 32
        Label12.Text = "Search"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.BackColor = System.Drawing.Color.Transparent
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.Color.Maroon
        Label13.Location = New System.Drawing.Point(18, 25)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(59, 17)
        Label13.TabIndex = 32
        Label13.Text = "Search"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label14.Location = New System.Drawing.Point(592, 63)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(81, 13)
        Label14.TabIndex = 34
        Label14.Text = "Loc Record #"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Label13)
        Me.GroupControl1.Controls.Add(Me.TxtSearch)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.Merchant_rec_noTextBox)
        Me.GroupControl1.Controls.Add(Me.GCMLocation)
        Me.GroupControl1.Controls.Add(Me.GCMDetails)
        Me.GroupControl1.Controls.Add(Merchant_rec_noLabel)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 34)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(812, 430)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "MERCHANTS"
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TxtSearch.Location = New System.Drawing.Point(78, 23)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(237, 21)
        Me.TxtSearch.TabIndex = 1
        Me.TTCMLSearch.SetToolTip(Me.TxtSearch, "Search Merchant Locations")
        Me.TTCMSearch.SetToolTip(Me.TxtSearch, "Search Merchants")
        Me.TTCMLSearch.SetToolTipIconType(Me.TxtSearch, DevExpress.Utils.ToolTipIconType.Information)
        Me.TTCMSearch.SetToolTipIconType(Me.TxtSearch, DevExpress.Utils.ToolTipIconType.Information)
        '
        'Merchant_rec_noTextBox
        '
        Me.Merchant_rec_noTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.Merchant_rec_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "merchant_rec_no", True))
        Me.Merchant_rec_noTextBox.Location = New System.Drawing.Point(710, 23)
        Me.Merchant_rec_noTextBox.Name = "Merchant_rec_noTextBox"
        Me.Merchant_rec_noTextBox.ReadOnly = True
        Me.Merchant_rec_noTextBox.Size = New System.Drawing.Size(80, 21)
        Me.Merchant_rec_noTextBox.TabIndex = 30
        '
        'MerchantBindingSource
        '
        Me.MerchantBindingSource.DataMember = "merchant"
        Me.MerchantBindingSource.DataSource = Me.MerchantLocDS
        '
        'MerchantLocDS
        '
        Me.MerchantLocDS.DataSetName = "MerchantLocDS"
        Me.MerchantLocDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GCMLocation
        '
        Me.GCMLocation.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCMLocation.AppearanceCaption.Options.UseFont = True
        Me.GCMLocation.Controls.Add(Me.Country_rec_noComboBox)
        Me.GCMLocation.Controls.Add(Country_rec_noLabel)
        Me.GCMLocation.Controls.Add(Me.District_rec_noComboBox)
        Me.GCMLocation.Controls.Add(District_rec_noLabel)
        Me.GCMLocation.Controls.Add(City_rec_noLabel)
        Me.GCMLocation.Controls.Add(Me.City_rec_noComboBox)
        Me.GCMLocation.Enabled = False
        Me.GCMLocation.Location = New System.Drawing.Point(500, 51)
        Me.GCMLocation.Name = "GCMLocation"
        Me.GCMLocation.Size = New System.Drawing.Size(292, 122)
        Me.GCMLocation.TabIndex = 28
        Me.GCMLocation.Text = "Location"
        '
        'Country_rec_noComboBox
        '
        Me.Country_rec_noComboBox.BackColor = System.Drawing.Color.LightBlue
        Me.Country_rec_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MerchantBindingSource, "country_rec_no", True))
        Me.Country_rec_noComboBox.DataSource = Me.CountryBindingSource
        Me.Country_rec_noComboBox.DisplayMember = "description"
        Me.Country_rec_noComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Country_rec_noComboBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Country_rec_noComboBox.FormattingEnabled = True
        Me.Country_rec_noComboBox.Location = New System.Drawing.Point(115, 31)
        Me.Country_rec_noComboBox.Name = "Country_rec_noComboBox"
        Me.Country_rec_noComboBox.Size = New System.Drawing.Size(169, 21)
        Me.Country_rec_noComboBox.TabIndex = 9
        Me.Country_rec_noComboBox.ValueMember = "country_rec_no"
        '
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "Country"
        Me.CountryBindingSource.DataSource = Me.Country
        '
        'Country
        '
        Me.Country.DataSetName = "Country"
        Me.Country.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'District_rec_noComboBox
        '
        Me.District_rec_noComboBox.BackColor = System.Drawing.Color.LightBlue
        Me.District_rec_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MerchantBindingSource, "district_rec_no", True))
        Me.District_rec_noComboBox.DataSource = Me.DistrictBindingSource
        Me.District_rec_noComboBox.DisplayMember = "description"
        Me.District_rec_noComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.District_rec_noComboBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.District_rec_noComboBox.FormattingEnabled = True
        Me.District_rec_noComboBox.Location = New System.Drawing.Point(115, 58)
        Me.District_rec_noComboBox.Name = "District_rec_noComboBox"
        Me.District_rec_noComboBox.Size = New System.Drawing.Size(169, 21)
        Me.District_rec_noComboBox.TabIndex = 10
        Me.District_rec_noComboBox.ValueMember = "District_rec_no"
        '
        'DistrictBindingSource
        '
        Me.DistrictBindingSource.DataMember = "District"
        Me.DistrictBindingSource.DataSource = Me.District
        '
        'District
        '
        Me.District.DataSetName = "District"
        Me.District.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'City_rec_noComboBox
        '
        Me.City_rec_noComboBox.BackColor = System.Drawing.Color.LightBlue
        Me.City_rec_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MerchantBindingSource, "city_rec_no", True))
        Me.City_rec_noComboBox.DataSource = Me.CityBindingSource
        Me.City_rec_noComboBox.DisplayMember = "Description"
        Me.City_rec_noComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.City_rec_noComboBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.City_rec_noComboBox.FormattingEnabled = True
        Me.City_rec_noComboBox.Location = New System.Drawing.Point(115, 85)
        Me.City_rec_noComboBox.Name = "City_rec_noComboBox"
        Me.City_rec_noComboBox.Size = New System.Drawing.Size(169, 21)
        Me.City_rec_noComboBox.TabIndex = 11
        Me.City_rec_noComboBox.ValueMember = "City_rec_no"
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "city"
        Me.CityBindingSource.DataSource = Me.City
        '
        'City
        '
        Me.City.DataSetName = "City"
        Me.City.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GCMDetails
        '
        Me.GCMDetails.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCMDetails.AppearanceCaption.Options.UseFont = True
        Me.GCMDetails.Controls.Add(M_nameLabel)
        Me.GCMDetails.Controls.Add(Phone_2Label1)
        Me.GCMDetails.Controls.Add(Me.Merchant_idTextBox)
        Me.GCMDetails.Controls.Add(Me.Phone_2MaskedTextBox)
        Me.GCMDetails.Controls.Add(Merchant_idLabel)
        Me.GCMDetails.Controls.Add(Phone_1Label1)
        Me.GCMDetails.Controls.Add(Me.M_nameTextBox)
        Me.GCMDetails.Controls.Add(Me.Phone_1MaskedTextBox)
        Me.GCMDetails.Controls.Add(Me.M_contactTextBox)
        Me.GCMDetails.Controls.Add(RateLabel)
        Me.GCMDetails.Controls.Add(M_contactLabel)
        Me.GCMDetails.Controls.Add(Me.RateTextBox)
        Me.GCMDetails.Controls.Add(Me.M_emailTextBox)
        Me.GCMDetails.Controls.Add(M_emailLabel)
        Me.GCMDetails.Location = New System.Drawing.Point(18, 50)
        Me.GCMDetails.Name = "GCMDetails"
        Me.GCMDetails.Size = New System.Drawing.Size(439, 122)
        Me.GCMDetails.TabIndex = 3
        Me.GCMDetails.Text = "Merchant Details"
        '
        'Merchant_idTextBox
        '
        Me.Merchant_idTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.Merchant_idTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Merchant_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "merchant_id", True))
        Me.Merchant_idTextBox.Location = New System.Drawing.Point(10, 44)
        Me.Merchant_idTextBox.Name = "Merchant_idTextBox"
        Me.Merchant_idTextBox.ReadOnly = True
        Me.Merchant_idTextBox.Size = New System.Drawing.Size(84, 21)
        Me.Merchant_idTextBox.TabIndex = 2
        '
        'Phone_2MaskedTextBox
        '
        Me.Phone_2MaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.Phone_2MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "phone_2", True))
        Me.Phone_2MaskedTextBox.Location = New System.Drawing.Point(276, 91)
        Me.Phone_2MaskedTextBox.Mask = "(5\01) 000-0000"
        Me.Phone_2MaskedTextBox.Name = "Phone_2MaskedTextBox"
        Me.Phone_2MaskedTextBox.ReadOnly = True
        Me.Phone_2MaskedTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Phone_2MaskedTextBox.TabIndex = 7
        '
        'M_nameTextBox
        '
        Me.M_nameTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.M_nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.M_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "m_name", True))
        Me.M_nameTextBox.Location = New System.Drawing.Point(117, 45)
        Me.M_nameTextBox.Name = "M_nameTextBox"
        Me.M_nameTextBox.ReadOnly = True
        Me.M_nameTextBox.Size = New System.Drawing.Size(144, 21)
        Me.M_nameTextBox.TabIndex = 3
        '
        'Phone_1MaskedTextBox
        '
        Me.Phone_1MaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.Phone_1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "phone_1", True))
        Me.Phone_1MaskedTextBox.Location = New System.Drawing.Point(170, 91)
        Me.Phone_1MaskedTextBox.Mask = "(5\01) 000-0000"
        Me.Phone_1MaskedTextBox.Name = "Phone_1MaskedTextBox"
        Me.Phone_1MaskedTextBox.ReadOnly = True
        Me.Phone_1MaskedTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Phone_1MaskedTextBox.TabIndex = 6
        '
        'M_contactTextBox
        '
        Me.M_contactTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.M_contactTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.M_contactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "m_contact", True))
        Me.M_contactTextBox.Location = New System.Drawing.Point(285, 45)
        Me.M_contactTextBox.Name = "M_contactTextBox"
        Me.M_contactTextBox.ReadOnly = True
        Me.M_contactTextBox.Size = New System.Drawing.Size(144, 21)
        Me.M_contactTextBox.TabIndex = 4
        '
        'RateTextBox
        '
        Me.RateTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.RateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "rate", True))
        Me.RateTextBox.Location = New System.Drawing.Point(382, 91)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.ReadOnly = True
        Me.RateTextBox.Size = New System.Drawing.Size(47, 21)
        Me.RateTextBox.TabIndex = 8
        '
        'M_emailTextBox
        '
        Me.M_emailTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.M_emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.M_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "m_email", True))
        Me.M_emailTextBox.Location = New System.Drawing.Point(9, 92)
        Me.M_emailTextBox.Name = "M_emailTextBox"
        Me.M_emailTextBox.ReadOnly = True
        Me.M_emailTextBox.Size = New System.Drawing.Size(155, 21)
        Me.M_emailTextBox.TabIndex = 5
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Label14)
        Me.GroupControl2.Controls.Add(Me.Ml_rec_noTextBox)
        Me.GroupControl2.Controls.Add(Label12)
        Me.GroupControl2.Controls.Add(Me.TxtMLSearch)
        Me.GroupControl2.Controls.Add(Me.GCMLLocation)
        Me.GroupControl2.Controls.Add(Me.GCMLDetails)
        Me.GroupControl2.Controls.Add(Me.Merch_locBindingNavigator)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 183)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(782, 231)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Merchant Locations"
        '
        'Ml_rec_noTextBox
        '
        Me.Ml_rec_noTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.Ml_rec_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource1, "ml_rec_no", True))
        Me.Ml_rec_noTextBox.Location = New System.Drawing.Point(678, 59)
        Me.Ml_rec_noTextBox.Name = "Ml_rec_noTextBox"
        Me.Ml_rec_noTextBox.ReadOnly = True
        Me.Ml_rec_noTextBox.Size = New System.Drawing.Size(84, 21)
        Me.Ml_rec_noTextBox.TabIndex = 33
        '
        'Merch_locBindingSource1
        '
        Me.Merch_locBindingSource1.DataMember = "merchant_merch_loc"
        Me.Merch_locBindingSource1.DataSource = Me.MerchantBindingSource
        '
        'TxtMLSearch
        '
        Me.TxtMLSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtMLSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMLSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TxtMLSearch.Location = New System.Drawing.Point(74, 61)
        Me.TxtMLSearch.Name = "TxtMLSearch"
        Me.TxtMLSearch.Size = New System.Drawing.Size(237, 21)
        Me.TxtMLSearch.TabIndex = 13
        '
        'GCMLLocation
        '
        Me.GCMLLocation.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCMLLocation.AppearanceCaption.Options.UseFont = True
        Me.GCMLLocation.Controls.Add(Me.CboMLCountry)
        Me.GCMLLocation.Controls.Add(Label2)
        Me.GCMLLocation.Controls.Add(Me.CboMLDistrict)
        Me.GCMLLocation.Controls.Add(Label3)
        Me.GCMLLocation.Controls.Add(Label4)
        Me.GCMLLocation.Controls.Add(Me.CboMLCity)
        Me.GCMLLocation.Enabled = False
        Me.GCMLLocation.Location = New System.Drawing.Point(491, 89)
        Me.GCMLLocation.Name = "GCMLLocation"
        Me.GCMLLocation.Size = New System.Drawing.Size(271, 122)
        Me.GCMLLocation.TabIndex = 30
        Me.GCMLLocation.Text = "Location"
        '
        'CboMLCountry
        '
        Me.CboMLCountry.BackColor = System.Drawing.Color.White
        Me.CboMLCountry.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Merch_locBindingSource, "country_rec_no", True))
        Me.CboMLCountry.DataSource = Me.CountryBindingSource1
        Me.CboMLCountry.DisplayMember = "description"
        Me.CboMLCountry.FormattingEnabled = True
        Me.CboMLCountry.Location = New System.Drawing.Point(120, 31)
        Me.CboMLCountry.Name = "CboMLCountry"
        Me.CboMLCountry.Size = New System.Drawing.Size(141, 21)
        Me.CboMLCountry.TabIndex = 21
        Me.CboMLCountry.ValueMember = "country_rec_no"
        '
        'Merch_locBindingSource
        '
        Me.Merch_locBindingSource.DataSource = Me.MerchantmerchlocBindingSource
        '
        'MerchantmerchlocBindingSource
        '
        Me.MerchantmerchlocBindingSource.DataMember = "merchant_merch_loc"
        Me.MerchantmerchlocBindingSource.DataSource = Me.MerchantBindingSource
        '
        'CountryBindingSource1
        '
        Me.CountryBindingSource1.DataMember = "Country"
        Me.CountryBindingSource1.DataSource = Me.Country
        '
        'CboMLDistrict
        '
        Me.CboMLDistrict.BackColor = System.Drawing.Color.White
        Me.CboMLDistrict.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Merch_locBindingSource, "district_rec_no", True))
        Me.CboMLDistrict.DataSource = Me.DistrictBindingSource1
        Me.CboMLDistrict.DisplayMember = "description"
        Me.CboMLDistrict.FormattingEnabled = True
        Me.CboMLDistrict.Location = New System.Drawing.Point(120, 58)
        Me.CboMLDistrict.Name = "CboMLDistrict"
        Me.CboMLDistrict.Size = New System.Drawing.Size(141, 21)
        Me.CboMLDistrict.TabIndex = 22
        Me.CboMLDistrict.ValueMember = "District_rec_no"
        '
        'DistrictBindingSource1
        '
        Me.DistrictBindingSource1.DataMember = "District"
        Me.DistrictBindingSource1.DataSource = Me.District
        '
        'CboMLCity
        '
        Me.CboMLCity.BackColor = System.Drawing.Color.White
        Me.CboMLCity.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Merch_locBindingSource, "city_rec_no", True))
        Me.CboMLCity.DataSource = Me.CityBindingSource1
        Me.CboMLCity.DisplayMember = "Description"
        Me.CboMLCity.FormattingEnabled = True
        Me.CboMLCity.Location = New System.Drawing.Point(120, 85)
        Me.CboMLCity.Name = "CboMLCity"
        Me.CboMLCity.Size = New System.Drawing.Size(141, 21)
        Me.CboMLCity.TabIndex = 23
        Me.CboMLCity.ValueMember = "City_rec_no"
        '
        'CityBindingSource1
        '
        Me.CityBindingSource1.DataMember = "city"
        Me.CityBindingSource1.DataSource = Me.City
        '
        'GCMLDetails
        '
        Me.GCMLDetails.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCMLDetails.AppearanceCaption.Options.UseFont = True
        Me.GCMLDetails.Controls.Add(Label5)
        Me.GCMLDetails.Controls.Add(Label6)
        Me.GCMLDetails.Controls.Add(Me.TxtLocID)
        Me.GCMLDetails.Controls.Add(Me.MaskedTextBox1)
        Me.GCMLDetails.Controls.Add(Label7)
        Me.GCMLDetails.Controls.Add(Label8)
        Me.GCMLDetails.Controls.Add(Me.TextBox3)
        Me.GCMLDetails.Controls.Add(Me.MaskedTextBox2)
        Me.GCMLDetails.Controls.Add(Me.TextBox4)
        Me.GCMLDetails.Controls.Add(Label9)
        Me.GCMLDetails.Controls.Add(Label10)
        Me.GCMLDetails.Controls.Add(Me.TextBox5)
        Me.GCMLDetails.Controls.Add(Me.TextBox6)
        Me.GCMLDetails.Controls.Add(Label11)
        Me.GCMLDetails.Enabled = False
        Me.GCMLDetails.Location = New System.Drawing.Point(14, 88)
        Me.GCMLDetails.Name = "GCMLDetails"
        Me.GCMLDetails.Size = New System.Drawing.Size(471, 122)
        Me.GCMLDetails.TabIndex = 29
        Me.GCMLDetails.Text = "Merchant Location Details"
        '
        'TxtLocID
        '
        Me.TxtLocID.BackColor = System.Drawing.Color.White
        Me.TxtLocID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLocID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "ml_id", True))
        Me.TxtLocID.Location = New System.Drawing.Point(10, 44)
        Me.TxtLocID.Name = "TxtLocID"
        Me.TxtLocID.Size = New System.Drawing.Size(84, 21)
        Me.TxtLocID.TabIndex = 14
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "phone_2", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(276, 91)
        Me.MaskedTextBox1.Mask = "(5\01) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox1.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "ml_name", True))
        Me.TextBox3.Location = New System.Drawing.Point(134, 45)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 21)
        Me.TextBox3.TabIndex = 15
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "phone_1", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(170, 91)
        Me.MaskedTextBox2.Mask = "(5\01) 000-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox2.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "m_contact", True))
        Me.TextBox4.Location = New System.Drawing.Point(320, 45)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(144, 21)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "shadow_acc", True))
        Me.TextBox5.Location = New System.Drawing.Point(382, 91)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(84, 21)
        Me.TextBox5.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "m_email", True))
        Me.TextBox6.Location = New System.Drawing.Point(9, 92)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(155, 21)
        Me.TextBox6.TabIndex = 17
        '
        'Merch_locBindingNavigator
        '
        Me.Merch_locBindingNavigator.AddNewItem = Me.merch_locBNavAddNewItem
        Me.Merch_locBindingNavigator.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Merch_locBindingNavigator.BindingSource = Me.Merch_locBindingSource
        Me.Merch_locBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Merch_locBindingNavigator.DeleteItem = Me.merch_locBNavDeleteItem
        Me.Merch_locBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.merch_locBNavAddNewItem, Me.merch_locBNavEditItem, Me.merch_locBNavDeleteItem, Me.merch_locBNavSaveItem, Me.merch_locBNavCancel})
        Me.Merch_locBindingNavigator.Location = New System.Drawing.Point(2, 21)
        Me.Merch_locBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Merch_locBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Merch_locBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Merch_locBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Merch_locBindingNavigator.Name = "Merch_locBindingNavigator"
        Me.Merch_locBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Merch_locBindingNavigator.Size = New System.Drawing.Size(778, 25)
        Me.Merch_locBindingNavigator.TabIndex = 12
        Me.Merch_locBindingNavigator.Text = "BindingNavigator1"
        '
        'merch_locBNavAddNewItem
        '
        Me.merch_locBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.merch_locBNavAddNewItem.Image = CType(resources.GetObject("merch_locBNavAddNewItem.Image"), System.Drawing.Image)
        Me.merch_locBNavAddNewItem.Name = "merch_locBNavAddNewItem"
        Me.merch_locBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.merch_locBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.merch_locBNavAddNewItem.Text = "Add New Location"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'merch_locBNavDeleteItem
        '
        Me.merch_locBNavDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.merch_locBNavDeleteItem.Enabled = False
        Me.merch_locBNavDeleteItem.Image = CType(resources.GetObject("merch_locBNavDeleteItem.Image"), System.Drawing.Image)
        Me.merch_locBNavDeleteItem.Name = "merch_locBNavDeleteItem"
        Me.merch_locBNavDeleteItem.RightToLeftAutoMirrorImage = True
        Me.merch_locBNavDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.merch_locBNavDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'merch_locBNavEditItem
        '
        Me.merch_locBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.merch_locBNavEditItem.Image = Global.DMTS.My.Resources.Resources.Edit
        Me.merch_locBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.merch_locBNavEditItem.Name = "merch_locBNavEditItem"
        Me.merch_locBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.merch_locBNavEditItem.Text = "Edit Data"
        '
        'merch_locBNavSaveItem
        '
        Me.merch_locBNavSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.merch_locBNavSaveItem.Enabled = False
        Me.merch_locBNavSaveItem.Image = CType(resources.GetObject("merch_locBNavSaveItem.Image"), System.Drawing.Image)
        Me.merch_locBNavSaveItem.Name = "merch_locBNavSaveItem"
        Me.merch_locBNavSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.merch_locBNavSaveItem.Text = "Save Data"
        '
        'merch_locBNavCancel
        '
        Me.merch_locBNavCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.merch_locBNavCancel.Enabled = False
        Me.merch_locBNavCancel.Image = Global.DMTS.My.Resources.Resources.Undo
        Me.merch_locBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.merch_locBNavCancel.Name = "merch_locBNavCancel"
        Me.merch_locBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.merch_locBNavCancel.Text = "ToolStripButton8"
        '
        'Merch_locTableAdapter
        '
        Me.Merch_locTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.merch_locTableAdapter = Me.Merch_locTableAdapter
        Me.TableAdapterManager.UpdateOrder = DMTS.MerchantLocDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MerchantTableAdapter
        '
        Me.MerchantTableAdapter.ClearBeforeFill = True
        '
        'MerchantBindingNavigator
        '
        Me.MerchantBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.MerchantBindingNavigator.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MerchantBindingNavigator.BindingSource = Me.MerchantBindingSource
        Me.MerchantBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.MerchantBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.MerchantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.MerchantBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MerchantBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.MerchantBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.MerchantBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.MerchantBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.MerchantBindingNavigator.Name = "MerchantBindingNavigator"
        Me.MerchantBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.MerchantBindingNavigator.Size = New System.Drawing.Size(836, 25)
        Me.MerchantBindingNavigator.TabIndex = 0
        Me.MerchantBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
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
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Save Data"
        Me.ToolStripButton7.Visible = False
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'DistrictTableAdapter
        '
        Me.DistrictTableAdapter.ClearBeforeFill = True
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'FrmMerchantLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(836, 470)
        Me.Controls.Add(Me.MerchantBindingNavigator)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMerchantLoc"
        Me.Text = "Merchant Location Maintenance"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantLocDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCMLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCMLocation.ResumeLayout(False)
        Me.GCMLocation.PerformLayout()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Country, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.City, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCMDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCMDetails.ResumeLayout(False)
        Me.GCMDetails.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.Merch_locBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCMLLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCMLLocation.ResumeLayout(False)
        Me.GCMLLocation.PerformLayout()
        CType(Me.Merch_locBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantmerchlocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistrictBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCMLDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCMLDetails.ResumeLayout(False)
        Me.GCMLDetails.PerformLayout()
        CType(Me.Merch_locBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Merch_locBindingNavigator.ResumeLayout(False)
        Me.Merch_locBindingNavigator.PerformLayout()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MerchantBindingNavigator.ResumeLayout(False)
        Me.MerchantBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MerchantLocDS As MerchantLocDS
    Friend WithEvents Merch_locBindingSource As BindingSource
    Friend WithEvents Merch_locTableAdapter As MerchantLocDSTableAdapters.merch_locTableAdapter
    Friend WithEvents TableAdapterManager As MerchantLocDSTableAdapters.TableAdapterManager
    Friend WithEvents Merch_locBindingNavigator As BindingNavigator
    Friend WithEvents merch_locBNavAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents merch_locBNavDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents merch_locBNavSaveItem As ToolStripButton
    Friend WithEvents MerchantBindingSource As BindingSource
    Friend WithEvents MerchantTableAdapter As MerchantLocDSTableAdapters.merchantTableAdapter
    Friend WithEvents GCMDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Merchant_idTextBox As TextBox
    Friend WithEvents Phone_2MaskedTextBox As MaskedTextBox
    Friend WithEvents M_nameTextBox As TextBox
    Friend WithEvents Phone_1MaskedTextBox As MaskedTextBox
    Friend WithEvents M_contactTextBox As TextBox
    Friend WithEvents RateTextBox As TextBox
    Friend WithEvents M_emailTextBox As TextBox
    Friend WithEvents GCMLocation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Country_rec_noComboBox As ComboBox
    Friend WithEvents District_rec_noComboBox As ComboBox
    Friend WithEvents City_rec_noComboBox As ComboBox
    Friend WithEvents MerchantBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
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
    Friend WithEvents GCMLLocation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CboMLCountry As ComboBox
    Friend WithEvents CboMLDistrict As ComboBox
    Friend WithEvents CboMLCity As ComboBox
    Friend WithEvents GCMLDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtLocID As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TxtMLSearch As TextBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents TTCMSearch As DevExpress.Utils.ToolTipController
    Friend WithEvents TTCMLSearch As DevExpress.Utils.ToolTipController
    Friend WithEvents Ml_rec_noTextBox As TextBox
    Friend WithEvents Merch_locBindingSource1 As BindingSource
    Friend WithEvents CountryBindingSource1 As BindingSource
    Friend WithEvents DistrictBindingSource1 As BindingSource
    Friend WithEvents CityBindingSource1 As BindingSource
    Friend WithEvents merch_locBNavEditItem As ToolStripButton
    Friend WithEvents merch_locBNavCancel As ToolStripButton
    Friend WithEvents MerchantmerchlocBindingSource As BindingSource
End Class
