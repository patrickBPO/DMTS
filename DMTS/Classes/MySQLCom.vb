Imports MySql.Data.MySqlClient

Public Class MySQLCom
    'Public Shared GPosition As Int32
    Public Shared ConnStr As String = "server=localhost;user id=dmtsuser;password=Dmtsuser@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3308;
            database=dmts;defaultcommandtimeout=180"
    Public Structure InsStruct
        Dim FH As String
        Dim CPD As String
        Dim DIV_NBR As String
        Dim TERMINAL_NBR As String
        Dim CURRENCY_CODE As String
        Dim AMOUNT As String
        Dim CARD_TYPE As String
    End Structure
    Public Shared Function GetCardType(ByVal CTypeStr As String) As String
        Dim OpInt As String = "0"

        Dim MyConn As New MySqlConnection("server=localhost;user id=dmtsuser;password=Dmtsuser@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3308;
            database=dmts;defaultcommandtimeout=180")
        Dim MyComm As New MySqlCommand("SELECT ct_rec_no AS c_type_int FROM card_type 
            WHERE ct_code = '" & CTypeStr & "'", MyConn)
        MyConn.Open()
        Try
            Dim Urdr As MySqlDataReader = MyComm.ExecuteReader
            While Urdr.Read
                OpInt = Urdr("c_type_int").ToString

            End While
            Urdr.Close()
            MyConn.Close()

        Catch ex As Exception
            Return False
            MyConn.Close()
        End Try

        If OpInt <> "0" Then
            Return OpInt
        Else
            Return "0"
        End If
    End Function
    Public Shared Function InsertTrans(ByRef ITStruct As InsStruct) As Boolean

        Dim MyConn As New MySqlConnection("server=localhost;user id=dmtsuser;password=Dmtsuser@xs4db;
            persistsecurityinfo=True;allowzerodatetime=True;convertzerodatetime=True;port=3308;
            database=dmts;defaultcommandtimeout=180")
        Dim MyComm As New MySqlCommand("INSERT INTO transactions (lt_rec_no,fh,trans_date,div_nbr,currency_code,amount,ct_rec_no) 
            VALUES (" & ITStruct.TERMINAL_NBR & "," &
                       "'" & ITStruct.FH & "'," &
                      "'" & ITStruct.CPD & "'," &
                        ITStruct.DIV_NBR & "," &
                        ITStruct.CURRENCY_CODE & "," &
                        ITStruct.AMOUNT & "," &
                        ITStruct.CARD_TYPE & ")", MyConn)

        Try
            MyConn.Open()
            MyComm.ExecuteNonQuery()
            MyConn.Close()
            Return True

        Catch ex As Exception
            MyConn.Close()
            Return False
        End Try

    End Function
    Public Shared Function InsertTransPrep(ByRef MyComm As MySqlCommand) As Boolean

        Try
            MyComm.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    'Public Shared Sub refreshDatagrid(ByRef DGV As DataGridView, ByVal TabName As String, ByVal ConnectString As String,
    '                                  ByRef DS As DataSet, ByRef TableAdapter As Object, ByRef DatTable As DataTable)
    '    Dim con As MySqlConnection = New MySqlConnection(ConnectString)
    '    Dim sql As MySqlCommand = New MySqlCommand("SELECT * FROM " & TabName, con)

    '    con.Open()
    '    TableAdapter.Adapter.SelectCommand = sql
    '    TableAdapter.Fill(DS, DatTable)
    '    DGV.DataSource = DS
    '    DGV.DataMember = TabName
    '    con.Close()

    '    'Dim ds As DataSet = New DataSet()
    '    'Dim DataAdapter1 As MySqlDataAdapter = New MySqlDataAdapter()
    '    'con.Open()
    '    'DataAdapter1.SelectCommand = sql
    '    'DataAdapter1.Fill(ds, TabName)
    '    'DGV.DataSource = ds
    '    'DGV.DataMember = TabName
    '    'con.Close()

    'End Sub
    'Public Shared Sub RefreshDatagrid(ByRef TableAdapter As Object, ByRef DatTable As DataTable)
    '    TableAdapter.Fill(DatTable) '-- Refresh Grid

    'End Sub
    'Public Shared Sub DoEdit(ByRef EditBtn As ToolStripButton,
    '                         ByRef AddBtn As ToolStripButton,
    '                         ByRef SaveBtn As ToolStripButton,
    '                         ByRef DelBtn As ToolStripButton,
    '                         ByRef CanBtn As ToolStripButton)

    '    SaveBtn.Enabled = True
    '    EditBtn.Enabled = False
    '    AddBtn.Enabled = False
    '    DelBtn.Enabled = True
    '    CanBtn.Enabled = True
    'End Sub
    'Public Shared Sub DoAdd(ByRef EditBtn As ToolStripButton,
    '                         ByRef AddBtn As ToolStripButton,
    '                         ByRef SaveBtn As ToolStripButton,
    '                         ByRef DelBtn As ToolStripButton,
    '                         ByRef CanBtn As ToolStripButton)

    '    SaveBtn.Enabled = True
    '    EditBtn.Enabled = False
    '    AddBtn.Enabled = False
    '    DelBtn.Enabled = False
    '    CanBtn.Enabled = True
    'End Sub
    'Public Shared Sub DoSave(ByRef EditBtn As ToolStripButton,
    '                         ByRef AddBtn As ToolStripButton,
    '                         ByRef SaveBtn As ToolStripButton,
    '                         ByRef DelBtn As ToolStripButton,
    '                         ByRef CanBtn As ToolStripButton)

    '    SaveBtn.Enabled = False
    '    EditBtn.Enabled = True
    '    AddBtn.Enabled = True
    '    DelBtn.Enabled = False
    '    CanBtn.Enabled = False
    'End Sub
    'Public Shared Sub DoCancel(ByRef EditBtn As ToolStripButton,
    '                         ByRef AddBtn As ToolStripButton,
    '                         ByRef SaveBtn As ToolStripButton,
    '                         ByRef DelBtn As ToolStripButton,
    '                         ByRef CanBtn As ToolStripButton)

    '    SaveBtn.Enabled = False
    '    EditBtn.Enabled = True
    '    AddBtn.Enabled = True
    '    DelBtn.Enabled = False
    '    CanBtn.Enabled = False
    'End Sub

    'Public Shared Sub DoDelete(ByRef EditBtn As ToolStripButton,
    '                         ByRef AddBtn As ToolStripButton,
    '                         ByRef SaveBtn As ToolStripButton,
    '                         ByRef DelBtn As ToolStripButton,
    '                         ByRef CanBtn As ToolStripButton)

    '    SaveBtn.Enabled = False
    '    EditBtn.Enabled = True
    '    AddBtn.Enabled = True
    '    DelBtn.Enabled = False
    '    CanBtn.Enabled = False
    'End Sub
    'Public Shared Sub LastPosition(ByRef DgBindingSource As BindingSource,
    '                              ByRef DGView As DataGridView,
    '                              ByVal PrimaryKey As String,
    '                               ByVal MoveOrGet As Byte)
    '    Try
    '        Select Case MoveOrGet
    '            Case 0 '- Record Cursor Position
    '                Dim CurrRec As Int32
    '                CurrRec = DirectCast(DgBindingSource.Current, DataRowView).Item(PrimaryKey)
    '                GPosition = DgBindingSource.Find(PrimaryKey, CurrRec)
    '                'GPosition = DgBindingSource.Position
    '                DgBindingSource.Position = GPosition '- Record the position of last record added

    '            Case 1 '- Move Cursor to recorded Position
    '                '- Below will move the cursor to the last recorded position
    '                DGView.Rows(GPosition - 1).Selected = True
    '                DGView.CurrentCell = DGView.Rows(GPosition - 1).Cells(1)

    '            Case Else
    '                '- Do Nothing

    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
End Class
