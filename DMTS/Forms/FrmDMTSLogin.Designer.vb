<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDMTSLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDMTSLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.CmdLogin = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.TxtSname = New System.Windows.Forms.TextBox()
        Me.LblSname = New System.Windows.Forms.Label()
        Me.SnameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SNameDS = New DMTS.SNameDS()
        Me.S_nameTableAdapter = New DMTS.SNameDSTableAdapters.s_nameTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SNameDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 182)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TxtUserName
        '
        Me.TxtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TxtUserName.Location = New System.Drawing.Point(270, 43)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(100, 20)
        Me.TxtUserName.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(270, 78)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'CmdLogin
        '
        Me.CmdLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.CmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CmdLogin.Location = New System.Drawing.Point(181, 150)
        Me.CmdLogin.Name = "CmdLogin"
        Me.CmdLogin.Size = New System.Drawing.Size(84, 23)
        Me.CmdLogin.TabIndex = 5
        Me.CmdLogin.Text = "Login"
        Me.CmdLogin.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(286, 150)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(84, 23)
        Me.CmdCancel.TabIndex = 7
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'TxtSname
        '
        Me.TxtSname.BackColor = System.Drawing.Color.White
        Me.TxtSname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SnameBindingSource, "description", True))
        Me.TxtSname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSname.ForeColor = System.Drawing.Color.Blue
        Me.TxtSname.Location = New System.Drawing.Point(270, 117)
        Me.TxtSname.Name = "TxtSname"
        Me.TxtSname.Size = New System.Drawing.Size(100, 20)
        Me.TxtSname.TabIndex = 8
        Me.TxtSname.Visible = False
        '
        'LblSname
        '
        Me.LblSname.AutoSize = True
        Me.LblSname.BackColor = System.Drawing.Color.Transparent
        Me.LblSname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSname.ForeColor = System.Drawing.Color.Red
        Me.LblSname.Location = New System.Drawing.Point(40, 120)
        Me.LblSname.Name = "LblSname"
        Me.LblSname.Size = New System.Drawing.Size(225, 13)
        Me.LblSname.TabIndex = 9
        Me.LblSname.Text = "Correct Server Name or IP required -->"
        Me.LblSname.Visible = False
        '
        'SnameBindingSource
        '
        Me.SnameBindingSource.DataMember = "s_name"
        Me.SnameBindingSource.DataSource = Me.SNameDS
        '
        'SNameDS
        '
        Me.SNameDS.DataSetName = "SNameDS"
        Me.SNameDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'S_nameTableAdapter
        '
        Me.S_nameTableAdapter.ClearBeforeFill = True
        '
        'FrmDMTSLogin
        '
        Me.AcceptButton = Me.CmdLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 199)
        Me.Controls.Add(Me.LblSname)
        Me.Controls.Add(Me.TxtSname)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdLogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDMTSLogin"
        Me.Text = "User Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SNameDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents CmdLogin As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents LblSname As Label
    Friend WithEvents SNameDS As SNameDS
    Friend WithEvents SnameBindingSource As BindingSource
    Friend WithEvents S_nameTableAdapter As SNameDSTableAdapters.s_nameTableAdapter
End Class
