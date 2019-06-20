<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmViewTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewTrans))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsDS = New DMTS.TransactionsDS()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coltrans_rec_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lt_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltrans_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldiv_nbr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrency_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ct_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RICboCardType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.TransactionsTableAdapter = New DMTS.TransactionsDSTableAdapters.transactionsTableAdapter()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RICboCardType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TransactionsBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(19, 36)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2010 Black"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RICboCardType})
        Me.GridControl1.Size = New System.Drawing.Size(853, 369)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "transactions"
        Me.TransactionsBindingSource.DataSource = Me.TransactionsDS
        '
        'TransactionsDS
        '
        Me.TransactionsDS.DataSetName = "TransactionsDS"
        Me.TransactionsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coltrans_rec_no, Me.lt_desc, Me.colfh, Me.coltrans_date, Me.coldiv_nbr, Me.colcurrency_code, Me.colamount, Me.ct_desc})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", Nothing, "(Total={0:$###,##0.00})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "trans_date", Nothing, "(# Trans={0:###,###})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coltrans_date, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'coltrans_rec_no
        '
        Me.coltrans_rec_no.FieldName = "trans_rec_no"
        Me.coltrans_rec_no.Name = "coltrans_rec_no"
        Me.coltrans_rec_no.Width = 99
        '
        'lt_desc
        '
        Me.lt_desc.Caption = "Terminal"
        Me.lt_desc.FieldName = "lt_desc"
        Me.lt_desc.Name = "lt_desc"
        Me.lt_desc.OptionsColumn.AllowEdit = False
        Me.lt_desc.Visible = True
        Me.lt_desc.VisibleIndex = 6
        Me.lt_desc.Width = 396
        '
        'colfh
        '
        Me.colfh.Caption = "FH"
        Me.colfh.FieldName = "fh"
        Me.colfh.Name = "colfh"
        Me.colfh.OptionsColumn.AllowEdit = False
        Me.colfh.Visible = True
        Me.colfh.VisibleIndex = 0
        Me.colfh.Width = 36
        '
        'coltrans_date
        '
        Me.coltrans_date.Caption = "Date"
        Me.coltrans_date.FieldName = "trans_date"
        Me.coltrans_date.Name = "coltrans_date"
        Me.coltrans_date.OptionsColumn.AllowEdit = False
        Me.coltrans_date.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "trans_date", "# Trans={0:###,###}")})
        Me.coltrans_date.Visible = True
        Me.coltrans_date.VisibleIndex = 1
        Me.coltrans_date.Width = 100
        '
        'coldiv_nbr
        '
        Me.coldiv_nbr.Caption = "Div Nbr"
        Me.coldiv_nbr.FieldName = "div_nbr"
        Me.coldiv_nbr.Name = "coldiv_nbr"
        Me.coldiv_nbr.OptionsColumn.AllowEdit = False
        Me.coldiv_nbr.Visible = True
        Me.coldiv_nbr.VisibleIndex = 2
        Me.coldiv_nbr.Width = 50
        '
        'colcurrency_code
        '
        Me.colcurrency_code.Caption = "Code"
        Me.colcurrency_code.FieldName = "currency_code"
        Me.colcurrency_code.Name = "colcurrency_code"
        Me.colcurrency_code.OptionsColumn.AllowEdit = False
        Me.colcurrency_code.Visible = True
        Me.colcurrency_code.VisibleIndex = 3
        Me.colcurrency_code.Width = 43
        '
        'colamount
        '
        Me.colamount.AppearanceCell.Image = Global.DMTS.My.Resources.Resources.DollarSign
        Me.colamount.AppearanceCell.Options.UseImage = True
        Me.colamount.Caption = "Amount"
        Me.colamount.FieldName = "amount"
        Me.colamount.Name = "colamount"
        Me.colamount.OptionsColumn.AllowEdit = False
        Me.colamount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", "Grand Tot={0:$#,###,##0.00}")})
        Me.colamount.Visible = True
        Me.colamount.VisibleIndex = 4
        Me.colamount.Width = 143
        '
        'ct_desc
        '
        Me.ct_desc.Caption = "Card Type"
        Me.ct_desc.FieldName = "ct_desc"
        Me.ct_desc.Name = "ct_desc"
        Me.ct_desc.OptionsColumn.AllowEdit = False
        Me.ct_desc.Visible = True
        Me.ct_desc.VisibleIndex = 5
        Me.ct_desc.Width = 67
        '
        'RICboCardType
        '
        Me.RICboCardType.AutoHeight = False
        Me.RICboCardType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RICboCardType.Name = "RICboCardType"
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(894, 425)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Terminal Transaction History"
        '
        'FrmViewTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 450)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmViewTrans"
        Me.Text = "Transaction Viewer"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RICboCardType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TransactionsDS As TransactionsDS
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As TransactionsDSTableAdapters.transactionsTableAdapter
    Friend WithEvents coltrans_rec_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltrans_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldiv_nbr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrency_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RICboCardType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents lt_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ct_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
