<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTermCntRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTermCntRpt))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DsmLocTermCnt1 = New DMTS.DSMLocTermCnt()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colm_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmerchant_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colml_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colml_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collt_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collt_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MLocTermCntTableAdapter1 = New DMTS.DSMLocTermCntTableAdapters.MLocTermCntTableAdapter()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsmLocTermCnt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.GroupControl1.Controls.Add(Me.BtnPrint)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.LookAndFeel.SkinName = "Seven Classic"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(776, 426)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Location Terminal Counts Report"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(696, 21)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "&Printing"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "MLocTermCnt"
        Me.GridControl1.DataSource = Me.DsmLocTermCnt1
        Me.GridControl1.Location = New System.Drawing.Point(6, 50)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(765, 371)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DsmLocTermCnt1
        '
        Me.DsmLocTermCnt1.DataSetName = "DSMLocTermCnt"
        Me.DsmLocTermCnt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colm_name, Me.colmerchant_id, Me.colml_name, Me.colBranch, Me.colml_id, Me.collt_desc, Me.collt_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "lt_id", Nothing, "(Count ={0:###,###})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.RtfPageFooter = resources.GetString("GridView1.OptionsPrint.RtfPageFooter")
        Me.GridView1.OptionsPrint.RtfReportHeader = resources.GetString("GridView1.OptionsPrint.RtfReportHeader")
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colm_name
        '
        Me.colm_name.Caption = "Merchant"
        Me.colm_name.FieldName = "m_name"
        Me.colm_name.Name = "colm_name"
        Me.colm_name.Visible = True
        Me.colm_name.VisibleIndex = 1
        Me.colm_name.Width = 145
        '
        'colmerchant_id
        '
        Me.colmerchant_id.Caption = "Merch ID"
        Me.colmerchant_id.FieldName = "merchant_id"
        Me.colmerchant_id.Name = "colmerchant_id"
        Me.colmerchant_id.Visible = True
        Me.colmerchant_id.VisibleIndex = 0
        Me.colmerchant_id.Width = 63
        '
        'colml_name
        '
        Me.colml_name.Caption = "Location"
        Me.colml_name.FieldName = "ml_name"
        Me.colml_name.Name = "colml_name"
        Me.colml_name.Visible = True
        Me.colml_name.VisibleIndex = 3
        Me.colml_name.Width = 134
        '
        'colBranch
        '
        Me.colBranch.Caption = "Branch"
        Me.colBranch.FieldName = "Branch"
        Me.colBranch.Name = "colBranch"
        Me.colBranch.Visible = True
        Me.colBranch.VisibleIndex = 4
        Me.colBranch.Width = 111
        '
        'colml_id
        '
        Me.colml_id.Caption = "Loc ID"
        Me.colml_id.FieldName = "ml_id"
        Me.colml_id.Name = "colml_id"
        Me.colml_id.Visible = True
        Me.colml_id.VisibleIndex = 2
        Me.colml_id.Width = 57
        '
        'collt_desc
        '
        Me.collt_desc.Caption = "Terminal"
        Me.collt_desc.FieldName = "lt_desc"
        Me.collt_desc.Name = "collt_desc"
        Me.collt_desc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lt_desc", "(Count ={0:###,###})")})
        Me.collt_desc.Visible = True
        Me.collt_desc.VisibleIndex = 6
        Me.collt_desc.Width = 174
        '
        'collt_id
        '
        Me.collt_id.Caption = "Term ID"
        Me.collt_id.FieldName = "lt_id"
        Me.collt_id.Name = "collt_id"
        Me.collt_id.Visible = True
        Me.collt_id.VisibleIndex = 5
        Me.collt_id.Width = 63
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Location Name"
        Me.GridColumn1.FieldName = "merchant.merchant_merch_loc.ml_name"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Location ID"
        Me.GridColumn2.FieldName = "merchant.merchant_merch_loc.ml_id"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Terminal"
        Me.GridColumn3.FieldName = "merchant.merchant_merch_loc.merch_loc_loc_terminal.lt_desc"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Terminal ID"
        Me.GridColumn4.FieldName = "merchant.merchant_merch_loc.merch_loc_loc_terminal.lt_id"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Merchant"
        Me.GridColumn5.FieldName = "merchant.m_name"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Merchant ID"
        Me.GridColumn6.FieldName = "merchant.merchant_id"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'MLocTermCntTableAdapter1
        '
        Me.MLocTermCntTableAdapter1.ClearBeforeFill = True
        '
        'FrmTermCntRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTermCntRpt"
        Me.Text = "Terminal Counts Report"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsmLocTermCnt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsmLocTermCnt1 As DSMLocTermCnt
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colmerchant_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colm_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colml_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colml_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collt_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collt_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MLocTermCntTableAdapter1 As DSMLocTermCntTableAdapters.MLocTermCntTableAdapter
    Friend WithEvents BtnPrint As DevExpress.XtraEditors.SimpleButton
End Class
