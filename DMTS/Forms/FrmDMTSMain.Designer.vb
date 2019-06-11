<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDMTSMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDMTSMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationTerminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MerchantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MerchantLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEditTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileLoaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileConverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(556, 585)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.POSTransactionsToolStripMenuItem, Me.ImportToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReferencesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReferencesToolStripMenuItem
        '
        Me.ReferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CardTypeToolStripMenuItem, Me.CityToolStripMenuItem, Me.CountryToolStripMenuItem, Me.DistrictToolStripMenuItem, Me.LocationTerminalToolStripMenuItem, Me.MerchantToolStripMenuItem, Me.MerchantLocationToolStripMenuItem})
        Me.ReferencesToolStripMenuItem.Name = "ReferencesToolStripMenuItem"
        Me.ReferencesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReferencesToolStripMenuItem.Text = "References"
        '
        'CardTypeToolStripMenuItem
        '
        Me.CardTypeToolStripMenuItem.Name = "CardTypeToolStripMenuItem"
        Me.CardTypeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CardTypeToolStripMenuItem.Text = "Card Type"
        '
        'CityToolStripMenuItem
        '
        Me.CityToolStripMenuItem.Name = "CityToolStripMenuItem"
        Me.CityToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CityToolStripMenuItem.Text = "City"
        '
        'CountryToolStripMenuItem
        '
        Me.CountryToolStripMenuItem.Name = "CountryToolStripMenuItem"
        Me.CountryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CountryToolStripMenuItem.Text = "Country"
        '
        'DistrictToolStripMenuItem
        '
        Me.DistrictToolStripMenuItem.Name = "DistrictToolStripMenuItem"
        Me.DistrictToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DistrictToolStripMenuItem.Text = "District"
        '
        'LocationTerminalToolStripMenuItem
        '
        Me.LocationTerminalToolStripMenuItem.Name = "LocationTerminalToolStripMenuItem"
        Me.LocationTerminalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LocationTerminalToolStripMenuItem.Text = "Location Terminal"
        '
        'MerchantToolStripMenuItem
        '
        Me.MerchantToolStripMenuItem.Name = "MerchantToolStripMenuItem"
        Me.MerchantToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MerchantToolStripMenuItem.Text = "Merchant"
        '
        'MerchantLocationToolStripMenuItem
        '
        Me.MerchantLocationToolStripMenuItem.Name = "MerchantLocationToolStripMenuItem"
        Me.MerchantLocationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MerchantLocationToolStripMenuItem.Text = "Merchant Location"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'POSTransactionsToolStripMenuItem
        '
        Me.POSTransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewEditTransactionsToolStripMenuItem})
        Me.POSTransactionsToolStripMenuItem.Name = "POSTransactionsToolStripMenuItem"
        Me.POSTransactionsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.POSTransactionsToolStripMenuItem.Text = "POS Transactions"
        '
        'ViewEditTransactionsToolStripMenuItem
        '
        Me.ViewEditTransactionsToolStripMenuItem.Name = "ViewEditTransactionsToolStripMenuItem"
        Me.ViewEditTransactionsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ViewEditTransactionsToolStripMenuItem.Text = "View Transactions"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileLoaderToolStripMenuItem, Me.FileConverterToolStripMenuItem})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'FileLoaderToolStripMenuItem
        '
        Me.FileLoaderToolStripMenuItem.Name = "FileLoaderToolStripMenuItem"
        Me.FileLoaderToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.FileLoaderToolStripMenuItem.Text = "File Loader"
        '
        'FileConverterToolStripMenuItem
        '
        Me.FileConverterToolStripMenuItem.Name = "FileConverterToolStripMenuItem"
        Me.FileConverterToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.FileConverterToolStripMenuItem.Text = "File Converter"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTransactionsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ViewTransactionsToolStripMenuItem
        '
        Me.ViewTransactionsToolStripMenuItem.Name = "ViewTransactionsToolStripMenuItem"
        Me.ViewTransactionsToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ViewTransactionsToolStripMenuItem.Text = "Transactions Report (Date Range)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'FrmDMTSMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(579, 623)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmDMTSMain"
        Me.Opacity = 0.85R
        Me.Text = "Domestic Mechant Turnover System Main Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MerchantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MerchantLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationTerminalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents POSTransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileLoaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewEditTransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileConverterToolStripMenuItem As ToolStripMenuItem
End Class
