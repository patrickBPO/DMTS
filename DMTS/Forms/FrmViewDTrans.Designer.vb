<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmViewDTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewDTrans))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.d_transactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTransactionDS1 = New DMTS.DTransactionDS()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colt_count = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colt_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colm_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colml_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collt_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cold_trans_rec_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.D_transactionsTableAdapter1 = New DMTS.DTransactionDSTableAdapters.d_transactionsTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d_transactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTransactionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.d_transactionsBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(16, 32)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1007, 377)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'd_transactionsBindingSource
        '
        Me.d_transactionsBindingSource.DataMember = "d_transactions"
        Me.d_transactionsBindingSource.DataSource = Me.DTransactionDS1
        Me.d_transactionsBindingSource.Sort = ""
        '
        'DTransactionDS1
        '
        Me.DTransactionDS1.DataSetName = "DTransactionDS"
        Me.DTransactionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.LightBlue
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colt_count, Me.colamount, Me.colt_date, Me.colm_name, Me.colml_name, Me.collt_desc, Me.cold_trans_rec_no})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "t_count", Nothing, "(Count ={0:###,###})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", Nothing, "(Total={0:$###,##0.00})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colt_count
        '
        Me.colt_count.Caption = "Count"
        Me.colt_count.FieldName = "t_count"
        Me.colt_count.Name = "colt_count"
        Me.colt_count.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "t_count", "Count ={0:###,###}")})
        Me.colt_count.Visible = True
        Me.colt_count.VisibleIndex = 4
        Me.colt_count.Width = 206
        '
        'colamount
        '
        Me.colamount.Caption = "Amount"
        Me.colamount.FieldName = "amount"
        Me.colamount.Name = "colamount"
        Me.colamount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", "Grand Tot={0:$#,###,##0.00}")})
        Me.colamount.Visible = True
        Me.colamount.VisibleIndex = 5
        Me.colamount.Width = 217
        '
        'colt_date
        '
        Me.colt_date.Caption = "Date"
        Me.colt_date.FieldName = "t_date"
        Me.colt_date.Name = "colt_date"
        Me.colt_date.Visible = True
        Me.colt_date.VisibleIndex = 0
        Me.colt_date.Width = 92
        '
        'colm_name
        '
        Me.colm_name.Caption = "Merchant"
        Me.colm_name.FieldName = "m_name"
        Me.colm_name.Name = "colm_name"
        Me.colm_name.Visible = True
        Me.colm_name.VisibleIndex = 1
        Me.colm_name.Width = 166
        '
        'colml_name
        '
        Me.colml_name.Caption = "Location"
        Me.colml_name.FieldName = "ml_name"
        Me.colml_name.Name = "colml_name"
        Me.colml_name.Visible = True
        Me.colml_name.VisibleIndex = 2
        Me.colml_name.Width = 179
        '
        'collt_desc
        '
        Me.collt_desc.Caption = "Terminal"
        Me.collt_desc.FieldName = "lt_desc"
        Me.collt_desc.Name = "collt_desc"
        Me.collt_desc.Visible = True
        Me.collt_desc.VisibleIndex = 3
        Me.collt_desc.Width = 129
        '
        'cold_trans_rec_no
        '
        Me.cold_trans_rec_no.FieldName = "d_trans_rec_no"
        Me.cold_trans_rec_no.Name = "cold_trans_rec_no"
        Me.cold_trans_rec_no.Width = 71
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 12)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1042, 426)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Terminal Transaction History"
        '
        'D_transactionsTableAdapter1
        '
        Me.D_transactionsTableAdapter1.ClearBeforeFill = True
        '
        'FrmViewDTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 450)
        Me.Controls.Add(Me.GroupControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmViewDTrans"
        Me.Text = "Disbursed Debit Transactions Viewer"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d_transactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTransactionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents d_transactionsBindingSource As BindingSource
    Friend WithEvents DTransactionDS1 As DTransactionDS
    Friend WithEvents colt_count As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colt_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colm_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colml_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collt_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cold_trans_rec_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_transactionsTableAdapter1 As DTransactionDSTableAdapters.d_transactionsTableAdapter
End Class
