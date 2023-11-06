Imports System.Data.SqlClient 'Library to use MSSQL connection

'Information about database and use to access database
Module MSSQL_MODULE
    Public MSconnectionString As String = "Data Source=SUKUNA\SQLEXPRESS;Initial Catalog=GROUP11_DB;User Id=HadesServer;Password=mysqlroot;"
    Public MSconnection As SqlConnection 'OBJECT MSSQL
End Module
