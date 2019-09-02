<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDloader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDloader))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLdFile = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtRecs = New System.Windows.Forms.TextBox()
        Me.BtnFndFile = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.PBLoad = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLoad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.GroupBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.GroupBox1.Controls.Add(Me.PBLoad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnLdFile)
        Me.GroupBox1.Controls.Add(Me.TxtRecs)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 69)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Label1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Records Loaded"
        '
        'BtnLdFile
        '
        Me.BtnLdFile.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnLdFile.Appearance.Options.UseFont = True
        Me.BtnLdFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.BtnLdFile.Location = New System.Drawing.Point(8, 11)
        Me.BtnLdFile.Name = "BtnLdFile"
        Me.BtnLdFile.Size = New System.Drawing.Size(83, 23)
        Me.BtnLdFile.TabIndex = 8
        Me.BtnLdFile.Text = "&Load Debits"
        '
        'TxtRecs
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.TxtRecs, DevExpress.Utils.DefaultBoolean.[Default])
        Me.TxtRecs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecs.ForeColor = System.Drawing.Color.Blue
        Me.TxtRecs.Location = New System.Drawing.Point(213, 11)
        Me.TxtRecs.Name = "TxtRecs"
        Me.TxtRecs.Size = New System.Drawing.Size(92, 23)
        Me.TxtRecs.TabIndex = 5
        '
        'BtnFndFile
        '
        Me.BtnFndFile.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnFndFile.Appearance.Options.UseFont = True
        Me.BtnFndFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.BtnFndFile.Location = New System.Drawing.Point(12, 128)
        Me.BtnFndFile.Name = "BtnFndFile"
        Me.BtnFndFile.Size = New System.Drawing.Size(75, 23)
        Me.BtnFndFile.TabIndex = 12
        Me.BtnFndFile.Text = "&Find File"
        '
        'TextBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.TextBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.ForeColor = System.Drawing.Color.AliceBlue
        Me.TextBox1.Location = New System.Drawing.Point(94, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 20)
        Me.TextBox1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PictureBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.DMTS.My.Resources.Resources.HB_NEW_logo_FINAL
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 83)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Label2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date Stamp -->"
        '
        'DateTimePicker1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.DateTimePicker1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.DateTimePicker1.CustomFormat = "MM-dd-yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 14
        Me.DefaultToolTipController1.SetToolTip(Me.DateTimePicker1, "Select File Date Stamp You Wish To Use")
        '
        'PBLoad
        '
        Me.PBLoad.Location = New System.Drawing.Point(8, 40)
        Me.PBLoad.Name = "PBLoad"
        Me.PBLoad.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PBLoad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PBLoad.Size = New System.Drawing.Size(297, 18)
        Me.PBLoad.TabIndex = 16
        '
        'FrmDloader
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(334, 226)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnFndFile)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDloader"
        Me.Text = "Debits File Loader"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLoad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLdFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtRecs As TextBox
    Friend WithEvents BtnFndFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents PBLoad As DevExpress.XtraEditors.ProgressBarControl
End Class
