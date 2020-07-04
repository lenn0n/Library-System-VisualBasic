Imports MySql.Data
Imports MySql.Data.MySqlClient

Module mysql
    Public sqlcon As MySqlConnection = New MySqlConnection
    Public sqlcmd As New MySqlCommand
    Public sqldr As MySqlDataReader

    Sub connect()
        sqlcon.ConnectionString = "server=localhost;database=hayahay;uid=root;pwd="
    End Sub

End Module
