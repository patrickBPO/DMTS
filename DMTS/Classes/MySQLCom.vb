Imports MySql.Data.MySqlClient

Public Class MySQLCom
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
End Class
