Imports MySql.Data.MySqlClient
Public Class ExcelToDb
    Public Shared Function SaveData(sql As String)
        Dim mysqlCOn As MySqlConnection = New MySqlConnection("server=localhost;user id=DMTS;password=dmts@xs4db;database=dmts;sslMode=none")
        Dim mysqlCmd As MySqlCommand
        Dim resul As Boolean

        Try

            mysqlCOn.Open()
            mysqlCmd = New MySqlCommand
            With mysqlCmd
                .Connection = mysqlCOn
                .CommandText = sql
                resul = .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlCOn.Close()
        End Try
        Return resul
    End Function
End Class
