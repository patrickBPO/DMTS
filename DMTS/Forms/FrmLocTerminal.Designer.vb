<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLocTerminal
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
        Dim Label13 As System.Windows.Forms.Label
        Dim Country_rec_noLabel As System.Windows.Forms.Label
        Dim District_rec_noLabel As System.Windows.Forms.Label
        Dim City_rec_noLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Merchant_idLabel As System.Windows.Forms.Label
        Dim M_nameLabel As System.Windows.Forms.Label
        Dim Country_rec_noLabel1 As System.Windows.Forms.Label
        Dim District_rec_noLabel1 As System.Windows.Forms.Label
        Dim City_rec_noLabel1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLocTerminal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Merch_locBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Merch_locBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantmerchlocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocTerminalDS = New DMTS.LocTerminalDS()
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
        Me.Merch_locBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtMLSearch = New System.Windows.Forms.TextBox()
        Me.Merchant_rec_noTextBox = New System.Windows.Forms.TextBox()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Loc_terminalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.loc_terminalBNavAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Loc_terminalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.loc_terminalBNavDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.loc_terminalBNavEditItem = New System.Windows.Forms.ToolStripButton()
        Me.loc_terminalBNavSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.loc_terminalBNavCancel = New System.Windows.Forms.ToolStripButton()
        Me.Loc_terminalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtLTSearch = New System.Windows.Forms.TextBox()
        Me.Merch_locTableAdapter = New DMTS.LocTerminalDSTableAdapters.merch_locTableAdapter()
        Me.TableAdapterManager = New DMTS.LocTerminalDSTableAdapters.TableAdapterManager()
        Me.CountryTableAdapter = New DMTS.CountryTableAdapters.CountryTableAdapter()
        Me.DistrictTableAdapter = New DMTS.DistrictTableAdapters.DistrictTableAdapter()
        Me.CityTableAdapter = New DMTS.CityTableAdapters.cityTableAdapter()
        Me.Loc_terminalTableAdapter = New DMTS.LocTerminalDSTableAdapters.loc_terminalTableAdapter()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GCMerchant = New DevExpress.XtraEditors.GroupControl()
        Me.District_rec_noComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DistrictBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Country_rec_noComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CountryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.City_rec_noComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerchantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.TxtMSearch = New System.Windows.Forms.TextBox()
        Me.M_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Merchant_idTextBox = New System.Windows.Forms.TextBox()
        Me.MerchantTableAdapter = New DMTS.LocTerminalDSTableAdapters.merchantTableAdapter()
        Label13 = New System.Windows.Forms.Label()
        Country_rec_noLabel = New System.Windows.Forms.Label()
        District_rec_noLabel = New System.Windows.Forms.Label()
        City_rec_noLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Merchant_idLabel = New System.Windows.Forms.Label()
        M_nameLabel = New System.Windows.Forms.Label()
        Country_rec_noLabel1 = New System.Windows.Forms.Label()
        District_rec_noLabel1 = New System.Windows.Forms.Label()
        City_rec_noLabel1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Merch_locBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Merch_locBindingNavigator.SuspendLayout()
        CType(Me.Merch_locBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantmerchlocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocTerminalDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Loc_terminalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Loc_terminalBindingNavigator.SuspendLayout()
        CType(Me.Loc_terminalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loc_terminalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GCMerchant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCMerchant.SuspendLayout()
        CType(Me.DistrictBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MerchantBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.BackColor = System.Drawing.Color.Transparent
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.Color.Maroon
        Label13.Location = New System.Drawing.Point(11, 61)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(59, 17)
        Label13.TabIndex = 32
        Label13.Text = "Search"
        '
        'Country_rec_noLabel
        '
        Country_rec_noLabel.AutoSize = True
        Country_rec_noLabel.BackColor = System.Drawing.Color.Transparent
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
        District_rec_noLabel.BackColor = System.Drawing.Color.Transparent
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
        City_rec_noLabel.BackColor = System.Drawing.Color.Transparent
        City_rec_noLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        City_rec_noLabel.Location = New System.Drawing.Point(28, 90)
        City_rec_noLabel.Name = "City_rec_noLabel"
        City_rec_noLabel.Size = New System.Drawing.Size(29, 13)
        City_rec_noLabel.TabIndex = 21
        City_rec_noLabel.Text = "City"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Maroon
        Label12.Location = New System.Drawing.Point(14, 49)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(59, 17)
        Label12.TabIndex = 32
        Label12.Text = "Search"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(624, 61)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 13)
        Label2.TabIndex = 35
        Label2.Text = "Loc Record #"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(132, 29)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(147, 13)
        Label1.TabIndex = 27
        Label1.Text = "Merchant Location Name"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label3.Location = New System.Drawing.Point(302, 76)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 13)
        Label3.TabIndex = 39
        Label3.Text = "Phone 2"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label4.Location = New System.Drawing.Point(14, 29)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(71, 13)
        Label4.TabIndex = 26
        Label4.Text = "Location ID"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.BackColor = System.Drawing.Color.Transparent
        Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label15.Location = New System.Drawing.Point(199, 76)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(52, 13)
        Label15.TabIndex = 38
        Label15.Text = "Phone 1"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.BackColor = System.Drawing.Color.Transparent
        Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label16.Location = New System.Drawing.Point(383, 76)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(79, 13)
        Label16.TabIndex = 32
        Label16.Text = "Shadow Acct"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.BackColor = System.Drawing.Color.Transparent
        Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(365, 30)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(51, 13)
        Label17.TabIndex = 28
        Label17.Text = "Contact"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.BackColor = System.Drawing.Color.Transparent
        Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label18.Location = New System.Drawing.Point(46, 77)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(84, 13)
        Label18.TabIndex = 29
        Label18.Text = "Contact Email"
        '
        'Merchant_idLabel
        '
        Merchant_idLabel.AutoSize = True
        Merchant_idLabel.BackColor = System.Drawing.Color.Transparent
        Merchant_idLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Merchant_idLabel.Location = New System.Drawing.Point(26, 87)
        Merchant_idLabel.Name = "Merchant_idLabel"
        Merchant_idLabel.Size = New System.Drawing.Size(77, 13)
        Merchant_idLabel.TabIndex = 2
        Merchant_idLabel.Text = "Merchant ID"
        '
        'M_nameLabel
        '
        M_nameLabel.AutoSize = True
        M_nameLabel.BackColor = System.Drawing.Color.Transparent
        M_nameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        M_nameLabel.Location = New System.Drawing.Point(158, 87)
        M_nameLabel.Name = "M_nameLabel"
        M_nameLabel.Size = New System.Drawing.Size(96, 13)
        M_nameLabel.TabIndex = 4
        M_nameLabel.Text = "Merchant Name"
        '
        'Country_rec_noLabel1
        '
        Country_rec_noLabel1.AutoSize = True
        Country_rec_noLabel1.BackColor = System.Drawing.Color.Transparent
        Country_rec_noLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Country_rec_noLabel1.Location = New System.Drawing.Point(352, 83)
        Country_rec_noLabel1.Name = "Country_rec_noLabel1"
        Country_rec_noLabel1.Size = New System.Drawing.Size(52, 13)
        Country_rec_noLabel1.TabIndex = 6
        Country_rec_noLabel1.Text = "Country"
        '
        'District_rec_noLabel1
        '
        District_rec_noLabel1.AutoSize = True
        District_rec_noLabel1.BackColor = System.Drawing.Color.Transparent
        District_rec_noLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        District_rec_noLabel1.Location = New System.Drawing.Point(683, 83)
        District_rec_noLabel1.Name = "District_rec_noLabel1"
        District_rec_noLabel1.Size = New System.Drawing.Size(48, 13)
        District_rec_noLabel1.TabIndex = 8
        District_rec_noLabel1.Text = "District"
        '
        'City_rec_noLabel1
        '
        City_rec_noLabel1.AutoSize = True
        City_rec_noLabel1.BackColor = System.Drawing.Color.Transparent
        City_rec_noLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        City_rec_noLabel1.Location = New System.Drawing.Point(525, 83)
        City_rec_noLabel1.Name = "City_rec_noLabel1"
        City_rec_noLabel1.Size = New System.Drawing.Size(29, 13)
        City_rec_noLabel1.TabIndex = 10
        City_rec_noLabel1.Text = "City"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.Maroon
        Label5.Location = New System.Drawing.Point(11, 52)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(59, 17)
        Label5.TabIndex = 34
        Label5.Text = "Search"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl1.Appearance.BorderColor = System.Drawing.Color.Lime
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseBorderColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.Merch_locBindingNavigator)
        Me.GroupControl1.Controls.Add(Me.PictureBox2)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Label13)
        Me.GroupControl1.Controls.Add(Me.TxtMLSearch)
        Me.GroupControl1.Controls.Add(Me.Merchant_rec_noTextBox)
        Me.GroupControl1.Controls.Add(Me.GCMLocation)
        Me.GroupControl1.Controls.Add(Me.GCMDetails)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 146)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(801, 535)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "MERCHANT LOCATION"
        '
        'Merch_locBindingNavigator
        '
        Me.Merch_locBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Merch_locBindingNavigator.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Merch_locBindingNavigator.BindingSource = Me.Merch_locBindingSource
        Me.Merch_locBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Merch_locBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Merch_locBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Merch_locBindingNavigatorSaveItem})
        Me.Merch_locBindingNavigator.Location = New System.Drawing.Point(2, 21)
        Me.Merch_locBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Merch_locBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Merch_locBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Merch_locBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Merch_locBindingNavigator.Name = "Merch_locBindingNavigator"
        Me.Merch_locBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Merch_locBindingNavigator.Size = New System.Drawing.Size(797, 25)
        Me.Merch_locBindingNavigator.TabIndex = 2
        Me.Merch_locBindingNavigator.Text = "BindingNavigator1"
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
        'Merch_locBindingSource
        '
        Me.Merch_locBindingSource.DataSource = Me.MerchantmerchlocBindingSource
        '
        'MerchantmerchlocBindingSource
        '
        Me.MerchantmerchlocBindingSource.DataMember = "merchant_merch_loc"
        Me.MerchantmerchlocBindingSource.DataSource = Me.MerchantBindingSource
        '
        'MerchantBindingSource
        '
        Me.MerchantBindingSource.DataMember = "merchant"
        Me.MerchantBindingSource.DataSource = Me.LocTerminalDS
        '
        'LocTerminalDS
        '
        Me.LocTerminalDS.DataSetName = "LocTerminalDS"
        Me.LocTerminalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Merch_locBindingNavigatorSaveItem
        '
        Me.Merch_locBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Merch_locBindingNavigatorSaveItem.Enabled = False
        Me.Merch_locBindingNavigatorSaveItem.Image = CType(resources.GetObject("Merch_locBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Merch_locBindingNavigatorSaveItem.Name = "Merch_locBindingNavigatorSaveItem"
        Me.Merch_locBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Merch_locBindingNavigatorSaveItem.Text = "Save Data"
        Me.Merch_locBindingNavigatorSaveItem.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(497, 214)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(292, 308)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'TxtMLSearch
        '
        Me.TxtMLSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtMLSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMLSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TxtMLSearch.Location = New System.Drawing.Point(71, 59)
        Me.TxtMLSearch.Name = "TxtMLSearch"
        Me.TxtMLSearch.Size = New System.Drawing.Size(237, 21)
        Me.TxtMLSearch.TabIndex = 1
        '
        'Merchant_rec_noTextBox
        '
        Me.Merchant_rec_noTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.Merchant_rec_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "ml_rec_no", True))
        Me.Merchant_rec_noTextBox.Location = New System.Drawing.Point(710, 59)
        Me.Merchant_rec_noTextBox.Name = "Merchant_rec_noTextBox"
        Me.Merchant_rec_noTextBox.ReadOnly = True
        Me.Merchant_rec_noTextBox.Size = New System.Drawing.Size(80, 21)
        Me.Merchant_rec_noTextBox.TabIndex = 30
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
        Me.GCMLocation.Location = New System.Drawing.Point(497, 86)
        Me.GCMLocation.Name = "GCMLocation"
        Me.GCMLocation.Size = New System.Drawing.Size(292, 122)
        Me.GCMLocation.TabIndex = 28
        Me.GCMLocation.Text = "Location"
        '
        'Country_rec_noComboBox
        '
        Me.Country_rec_noComboBox.BackColor = System.Drawing.Color.LightBlue
        Me.Country_rec_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Merch_locBindingSource, "country_rec_no", True))
        Me.Country_rec_noComboBox.DataSource = Me.CountryBindingSource
        Me.Country_rec_noComboBox.DisplayMember = "description"
        Me.Country_rec_noComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Country_rec_noComboBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Country_rec_noComboBox.FormattingEnabled = True
        Me.Country_rec_noComboBox.Location = New System.Drawing.Point(100, 31)
        Me.Country_rec_noComboBox.Name = "Country_rec_noComboBox"
        Me.Country_rec_noComboBox.Size = New System.Drawing.Size(182, 21)
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
        Me.District_rec_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Merch_locBindingSource, "district_rec_no", True))
        Me.District_rec_noComboBox.DataSource = Me.DistrictBindingSource
        Me.District_rec_noComboBox.DisplayMember = "description"
        Me.District_rec_noComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.District_rec_noComboBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.District_rec_noComboBox.FormattingEnabled = True
        Me.District_rec_noComboBox.Location = New System.Drawing.Point(100, 58)
        Me.District_rec_noComboBox.Name = "District_rec_noComboBox"
        Me.District_rec_noComboBox.Size = New System.Drawing.Size(182, 21)
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
        Me.City_rec_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Merch_locBindingSource, "city_rec_no", True))
        Me.City_rec_noComboBox.DataSource = Me.CityBindingSource
        Me.City_rec_noComboBox.DisplayMember = "Description"
        Me.City_rec_noComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.City_rec_noComboBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.City_rec_noComboBox.FormattingEnabled = True
        Me.City_rec_noComboBox.Location = New System.Drawing.Point(100, 85)
        Me.City_rec_noComboBox.Name = "City_rec_noComboBox"
        Me.City_rec_noComboBox.Size = New System.Drawing.Size(182, 21)
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
        Me.GCMDetails.Controls.Add(Label1)
        Me.GCMDetails.Controls.Add(Label3)
        Me.GCMDetails.Controls.Add(Me.TextBox1)
        Me.GCMDetails.Controls.Add(Me.MaskedTextBox3)
        Me.GCMDetails.Controls.Add(Label4)
        Me.GCMDetails.Controls.Add(Label15)
        Me.GCMDetails.Controls.Add(Me.TextBox2)
        Me.GCMDetails.Controls.Add(Me.MaskedTextBox4)
        Me.GCMDetails.Controls.Add(Me.TextBox7)
        Me.GCMDetails.Controls.Add(Label16)
        Me.GCMDetails.Controls.Add(Label17)
        Me.GCMDetails.Controls.Add(Me.TextBox8)
        Me.GCMDetails.Controls.Add(Me.TextBox9)
        Me.GCMDetails.Controls.Add(Label18)
        Me.GCMDetails.Enabled = False
        Me.GCMDetails.Location = New System.Drawing.Point(13, 86)
        Me.GCMDetails.Name = "GCMDetails"
        Me.GCMDetails.Size = New System.Drawing.Size(478, 122)
        Me.GCMDetails.TabIndex = 3
        Me.GCMDetails.Text = "Location Details"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightBlue
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "ml_id", True))
        Me.TextBox1.Location = New System.Drawing.Point(9, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(84, 21)
        Me.TextBox1.TabIndex = 30
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.BackColor = System.Drawing.Color.LightBlue
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "phone_2", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(275, 93)
        Me.MaskedTextBox3.Mask = "(5\01) 000-0000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.ReadOnly = True
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox3.TabIndex = 36
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightBlue
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "ml_name", True))
        Me.TextBox2.Location = New System.Drawing.Point(133, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(144, 21)
        Me.TextBox2.TabIndex = 31
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.BackColor = System.Drawing.Color.LightBlue
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "phone_1", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(169, 93)
        Me.MaskedTextBox4.Mask = "(5\01) 000-0000"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.ReadOnly = True
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox4.TabIndex = 35
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.LightBlue
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "m_contact", True))
        Me.TextBox7.Location = New System.Drawing.Point(319, 47)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(144, 21)
        Me.TextBox7.TabIndex = 33
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.LightBlue
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "shadow_acc", True))
        Me.TextBox8.Location = New System.Drawing.Point(381, 93)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(84, 21)
        Me.TextBox8.TabIndex = 37
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.LightBlue
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Merch_locBindingSource, "m_email", True))
        Me.TextBox9.Location = New System.Drawing.Point(8, 94)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(155, 21)
        Me.TextBox9.TabIndex = 34
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.Loc_terminalBindingNavigator)
        Me.GroupControl2.Controls.Add(Me.Loc_terminalDataGridView)
        Me.GroupControl2.Controls.Add(Label12)
        Me.GroupControl2.Controls.Add(Me.TxtLTSearch)
        Me.GroupControl2.Location = New System.Drawing.Point(13, 214)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(478, 308)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Location Terminals"
        '
        'Loc_terminalBindingNavigator
        '
        Me.Loc_terminalBindingNavigator.AddNewItem = Me.loc_terminalBNavAddNewItem
        Me.Loc_terminalBindingNavigator.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Loc_terminalBindingNavigator.BindingSource = Me.Loc_terminalBindingSource
        Me.Loc_terminalBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.Loc_terminalBindingNavigator.DeleteItem = Me.loc_terminalBNavDeleteItem
        Me.Loc_terminalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.loc_terminalBNavAddNewItem, Me.loc_terminalBNavEditItem, Me.loc_terminalBNavDeleteItem, Me.loc_terminalBNavSaveItem, Me.loc_terminalBNavCancel})
        Me.Loc_terminalBindingNavigator.Location = New System.Drawing.Point(2, 21)
        Me.Loc_terminalBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.Loc_terminalBindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.Loc_terminalBindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.Loc_terminalBindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.Loc_terminalBindingNavigator.Name = "Loc_terminalBindingNavigator"
        Me.Loc_terminalBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.Loc_terminalBindingNavigator.Size = New System.Drawing.Size(474, 25)
        Me.Loc_terminalBindingNavigator.TabIndex = 33
        Me.Loc_terminalBindingNavigator.Text = "BindingNavigator1"
        '
        'loc_terminalBNavAddNewItem
        '
        Me.loc_terminalBNavAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.loc_terminalBNavAddNewItem.Image = CType(resources.GetObject("loc_terminalBNavAddNewItem.Image"), System.Drawing.Image)
        Me.loc_terminalBNavAddNewItem.Name = "loc_terminalBNavAddNewItem"
        Me.loc_terminalBNavAddNewItem.RightToLeftAutoMirrorImage = True
        Me.loc_terminalBNavAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.loc_terminalBNavAddNewItem.Text = "Add New Location"
        '
        'Loc_terminalBindingSource
        '
        Me.Loc_terminalBindingSource.DataMember = "merch_loc_loc_terminal"
        Me.Loc_terminalBindingSource.DataSource = Me.Merch_locBindingSource
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'loc_terminalBNavDeleteItem
        '
        Me.loc_terminalBNavDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.loc_terminalBNavDeleteItem.Enabled = False
        Me.loc_terminalBNavDeleteItem.Image = CType(resources.GetObject("loc_terminalBNavDeleteItem.Image"), System.Drawing.Image)
        Me.loc_terminalBNavDeleteItem.Name = "loc_terminalBNavDeleteItem"
        Me.loc_terminalBNavDeleteItem.RightToLeftAutoMirrorImage = True
        Me.loc_terminalBNavDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.loc_terminalBNavDeleteItem.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
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
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'loc_terminalBNavEditItem
        '
        Me.loc_terminalBNavEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.loc_terminalBNavEditItem.Image = Global.DMTS.My.Resources.Resources.Edit
        Me.loc_terminalBNavEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.loc_terminalBNavEditItem.Name = "loc_terminalBNavEditItem"
        Me.loc_terminalBNavEditItem.Size = New System.Drawing.Size(23, 22)
        Me.loc_terminalBNavEditItem.Text = "Edit Data"
        '
        'loc_terminalBNavSaveItem
        '
        Me.loc_terminalBNavSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.loc_terminalBNavSaveItem.Enabled = False
        Me.loc_terminalBNavSaveItem.Image = CType(resources.GetObject("loc_terminalBNavSaveItem.Image"), System.Drawing.Image)
        Me.loc_terminalBNavSaveItem.Name = "loc_terminalBNavSaveItem"
        Me.loc_terminalBNavSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.loc_terminalBNavSaveItem.Text = "Save Data"
        '
        'loc_terminalBNavCancel
        '
        Me.loc_terminalBNavCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.loc_terminalBNavCancel.Enabled = False
        Me.loc_terminalBNavCancel.Image = Global.DMTS.My.Resources.Resources.Undo
        Me.loc_terminalBNavCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.loc_terminalBNavCancel.Name = "loc_terminalBNavCancel"
        Me.loc_terminalBNavCancel.Size = New System.Drawing.Size(23, 22)
        Me.loc_terminalBNavCancel.Text = "ToolStripButton8"
        '
        'Loc_terminalDataGridView
        '
        Me.Loc_terminalDataGridView.AllowUserToAddRows = False
        Me.Loc_terminalDataGridView.AutoGenerateColumns = False
        Me.Loc_terminalDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Loc_terminalDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Loc_terminalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Loc_terminalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Loc_terminalDataGridView.DataSource = Me.Loc_terminalBindingSource
        Me.Loc_terminalDataGridView.Location = New System.Drawing.Point(12, 73)
        Me.Loc_terminalDataGridView.Name = "Loc_terminalDataGridView"
        Me.Loc_terminalDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Loc_terminalDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Loc_terminalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Loc_terminalDataGridView.Size = New System.Drawing.Size(453, 220)
        Me.Loc_terminalDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "lt_rec_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "lt_rec_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ml_rec_no"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ml_rec_no"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lt_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Terminal ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lt_desc"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Terminal Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'TxtLTSearch
        '
        Me.TxtLTSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtLTSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLTSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TxtLTSearch.Location = New System.Drawing.Point(74, 47)
        Me.TxtLTSearch.Name = "TxtLTSearch"
        Me.TxtLTSearch.Size = New System.Drawing.Size(237, 21)
        Me.TxtLTSearch.TabIndex = 13
        '
        'Merch_locTableAdapter
        '
        Me.Merch_locTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.loc_terminalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMTS.LocTerminalDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Loc_terminalTableAdapter
        '
        Me.Loc_terminalTableAdapter.ClearBeforeFill = True
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.GCMerchant)
        Me.GroupControl3.Controls.Add(Me.MerchantBindingNavigator)
        Me.GroupControl3.Controls.Add(Label5)
        Me.GroupControl3.Controls.Add(Me.TxtMSearch)
        Me.GroupControl3.Controls.Add(City_rec_noLabel1)
        Me.GroupControl3.Controls.Add(District_rec_noLabel1)
        Me.GroupControl3.Controls.Add(Country_rec_noLabel1)
        Me.GroupControl3.Controls.Add(M_nameLabel)
        Me.GroupControl3.Controls.Add(Me.M_nameTextBox)
        Me.GroupControl3.Controls.Add(Merchant_idLabel)
        Me.GroupControl3.Controls.Add(Me.Merchant_idTextBox)
        Me.GroupControl3.Location = New System.Drawing.Point(14, 3)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(801, 139)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "MERCHANT"
        '
        'GCMerchant
        '
        Me.GCMerchant.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCMerchant.AppearanceCaption.Options.UseFont = True
        Me.GCMerchant.Controls.Add(Me.District_rec_noComboBox1)
        Me.GCMerchant.Controls.Add(Me.Country_rec_noComboBox1)
        Me.GCMerchant.Controls.Add(Me.City_rec_noComboBox1)
        Me.GCMerchant.Enabled = False
        Me.GCMerchant.Location = New System.Drawing.Point(292, 101)
        Me.GCMerchant.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GCMerchant.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCMerchant.Name = "GCMerchant"
        Me.GCMerchant.ShowCaption = False
        Me.GCMerchant.Size = New System.Drawing.Size(498, 31)
        Me.GCMerchant.TabIndex = 37
        Me.GCMerchant.Text = "Location"
        '
        'District_rec_noComboBox1
        '
        Me.District_rec_noComboBox1.BackColor = System.Drawing.Color.LightBlue
        Me.District_rec_noComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MerchantBindingSource, "district_rec_no", True))
        Me.District_rec_noComboBox1.DataSource = Me.DistrictBindingSource1
        Me.District_rec_noComboBox1.DisplayMember = "description"
        Me.District_rec_noComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.District_rec_noComboBox1.FormattingEnabled = True
        Me.District_rec_noComboBox1.Location = New System.Drawing.Point(170, 5)
        Me.District_rec_noComboBox1.Name = "District_rec_noComboBox1"
        Me.District_rec_noComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.District_rec_noComboBox1.TabIndex = 9
        Me.District_rec_noComboBox1.ValueMember = "District_rec_no"
        '
        'DistrictBindingSource1
        '
        Me.DistrictBindingSource1.DataMember = "District"
        Me.DistrictBindingSource1.DataSource = Me.District
        '
        'Country_rec_noComboBox1
        '
        Me.Country_rec_noComboBox1.BackColor = System.Drawing.Color.LightBlue
        Me.Country_rec_noComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MerchantBindingSource, "country_rec_no", True))
        Me.Country_rec_noComboBox1.DataSource = Me.CountryBindingSource1
        Me.Country_rec_noComboBox1.DisplayMember = "description"
        Me.Country_rec_noComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Country_rec_noComboBox1.FormattingEnabled = True
        Me.Country_rec_noComboBox1.Location = New System.Drawing.Point(5, 5)
        Me.Country_rec_noComboBox1.Name = "Country_rec_noComboBox1"
        Me.Country_rec_noComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.Country_rec_noComboBox1.TabIndex = 7
        Me.Country_rec_noComboBox1.ValueMember = "country_rec_no"
        '
        'CountryBindingSource1
        '
        Me.CountryBindingSource1.DataMember = "Country"
        Me.CountryBindingSource1.DataSource = Me.Country
        '
        'City_rec_noComboBox1
        '
        Me.City_rec_noComboBox1.BackColor = System.Drawing.Color.LightBlue
        Me.City_rec_noComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MerchantBindingSource, "city_rec_no", True))
        Me.City_rec_noComboBox1.DataSource = Me.CityBindingSource1
        Me.City_rec_noComboBox1.DisplayMember = "Description"
        Me.City_rec_noComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.City_rec_noComboBox1.FormattingEnabled = True
        Me.City_rec_noComboBox1.Location = New System.Drawing.Point(335, 5)
        Me.City_rec_noComboBox1.Name = "City_rec_noComboBox1"
        Me.City_rec_noComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.City_rec_noComboBox1.TabIndex = 11
        Me.City_rec_noComboBox1.ValueMember = "City_rec_no"
        '
        'CityBindingSource1
        '
        Me.CityBindingSource1.DataMember = "city"
        Me.CityBindingSource1.DataSource = Me.City
        '
        'MerchantBindingNavigator
        '
        Me.MerchantBindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.MerchantBindingNavigator.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MerchantBindingNavigator.BindingSource = Me.MerchantBindingSource
        Me.MerchantBindingNavigator.CountItem = Me.ToolStripLabel2
        Me.MerchantBindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.MerchantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton11})
        Me.MerchantBindingNavigator.Location = New System.Drawing.Point(2, 21)
        Me.MerchantBindingNavigator.MoveFirstItem = Me.ToolStripButton7
        Me.MerchantBindingNavigator.MoveLastItem = Me.ToolStripButton10
        Me.MerchantBindingNavigator.MoveNextItem = Me.ToolStripButton9
        Me.MerchantBindingNavigator.MovePreviousItem = Me.ToolStripButton8
        Me.MerchantBindingNavigator.Name = "MerchantBindingNavigator"
        Me.MerchantBindingNavigator.PositionItem = Me.ToolStripTextBox2
        Me.MerchantBindingNavigator.Size = New System.Drawing.Size(797, 25)
        Me.MerchantBindingNavigator.TabIndex = 35
        Me.MerchantBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        Me.ToolStripButton5.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Delete"
        Me.ToolStripButton6.Visible = False
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Move first"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move next"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Enabled = False
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Save Data"
        Me.ToolStripButton11.Visible = False
        '
        'TxtMSearch
        '
        Me.TxtMSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.TxtMSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TxtMSearch.Location = New System.Drawing.Point(71, 50)
        Me.TxtMSearch.Name = "TxtMSearch"
        Me.TxtMSearch.Size = New System.Drawing.Size(237, 21)
        Me.TxtMSearch.TabIndex = 33
        '
        'M_nameTextBox
        '
        Me.M_nameTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.M_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "m_name", True))
        Me.M_nameTextBox.Location = New System.Drawing.Point(133, 105)
        Me.M_nameTextBox.Name = "M_nameTextBox"
        Me.M_nameTextBox.ReadOnly = True
        Me.M_nameTextBox.Size = New System.Drawing.Size(145, 21)
        Me.M_nameTextBox.TabIndex = 5
        '
        'Merchant_idTextBox
        '
        Me.Merchant_idTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.Merchant_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerchantBindingSource, "merchant_id", True))
        Me.Merchant_idTextBox.Location = New System.Drawing.Point(14, 105)
        Me.Merchant_idTextBox.Name = "Merchant_idTextBox"
        Me.Merchant_idTextBox.ReadOnly = True
        Me.Merchant_idTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Merchant_idTextBox.TabIndex = 3
        '
        'MerchantTableAdapter
        '
        Me.MerchantTableAdapter.ClearBeforeFill = True
        '
        'FrmLocTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 698)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLocTerminal"
        Me.Text = "Location Terminal Maintenance"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Merch_locBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Merch_locBindingNavigator.ResumeLayout(False)
        Me.Merch_locBindingNavigator.PerformLayout()
        CType(Me.Merch_locBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantmerchlocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocTerminalDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Loc_terminalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Loc_terminalBindingNavigator.ResumeLayout(False)
        Me.Loc_terminalBindingNavigator.PerformLayout()
        CType(Me.Loc_terminalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loc_terminalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GCMerchant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCMerchant.ResumeLayout(False)
        CType(Me.DistrictBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerchantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MerchantBindingNavigator.ResumeLayout(False)
        Me.MerchantBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtMLSearch As TextBox
    Friend WithEvents Merchant_rec_noTextBox As TextBox
    Friend WithEvents GCMLocation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Country_rec_noComboBox As ComboBox
    Friend WithEvents District_rec_noComboBox As ComboBox
    Friend WithEvents City_rec_noComboBox As ComboBox
    Friend WithEvents GCMDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtLTSearch As TextBox
    Friend WithEvents LocTerminalDS As LocTerminalDS
    Friend WithEvents Merch_locBindingSource As BindingSource
    Friend WithEvents Merch_locTableAdapter As LocTerminalDSTableAdapters.merch_locTableAdapter
    Friend WithEvents TableAdapterManager As LocTerminalDSTableAdapters.TableAdapterManager
    Friend WithEvents Merch_locBindingNavigator As BindingNavigator
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
    Friend WithEvents Merch_locBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Country As Country
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As CountryTableAdapters.CountryTableAdapter
    Friend WithEvents District As District
    Friend WithEvents DistrictBindingSource As BindingSource
    Friend WithEvents DistrictTableAdapter As DistrictTableAdapters.DistrictTableAdapter
    Friend WithEvents City As City
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents CityTableAdapter As CityTableAdapters.cityTableAdapter
    Friend WithEvents Loc_terminalBindingSource As BindingSource
    Friend WithEvents Loc_terminalTableAdapter As LocTerminalDSTableAdapters.loc_terminalTableAdapter
    Friend WithEvents Loc_terminalDataGridView As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Loc_terminalBindingNavigator As BindingNavigator
    Friend WithEvents loc_terminalBNavAddNewItem As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents loc_terminalBNavDeleteItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents loc_terminalBNavEditItem As ToolStripButton
    Friend WithEvents loc_terminalBNavSaveItem As ToolStripButton
    Friend WithEvents loc_terminalBNavCancel As ToolStripButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MerchantBindingSource As BindingSource
    Friend WithEvents MerchantTableAdapter As LocTerminalDSTableAdapters.merchantTableAdapter
    Friend WithEvents TxtMSearch As TextBox
    Friend WithEvents City_rec_noComboBox1 As ComboBox
    Friend WithEvents District_rec_noComboBox1 As ComboBox
    Friend WithEvents Country_rec_noComboBox1 As ComboBox
    Friend WithEvents M_nameTextBox As TextBox
    Friend WithEvents Merchant_idTextBox As TextBox
    Friend WithEvents MerchantBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents DistrictBindingSource1 As BindingSource
    Friend WithEvents CountryBindingSource1 As BindingSource
    Friend WithEvents CityBindingSource1 As BindingSource
    Friend WithEvents MerchantmerchlocBindingSource As BindingSource
    Friend WithEvents GCMerchant As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
