Imports MySql.Data.MySqlClient 'Library to use MYSQL connection

'Information about database and use to access database
Module MYSQL_MODULE
    Public MYconnectionString As String = "server=localhost;userid=root;database=GROUP11_DB;password=mysqlroot"
    Public MYconnection As MySqlConnection
End Module
