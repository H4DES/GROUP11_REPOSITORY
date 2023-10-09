Imports System.Data.SqlClient 'Library to use MSSQL connection
Imports MySql.Data.MySqlClient 'Library to use MYSQL connection
Public Class Form1
    Private Sub btnMSSQL_Click(sender As Object, e As EventArgs) Handles btnMSSQL.Click
        MSconnection = New SqlConnection(MSconnectionString) 'INSTANCE NAME OF SQLCONNECTION

        Try
            MSconnection.Open() 'CONNECTION OPEN FOR CONNECTION MSSQL
            If MSconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success!")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Connection Failed!")
            End If
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try

    End Sub

    Private Sub btnMYSQL_Click(sender As Object, e As EventArgs) Handles btnMYSQL.Click
        MYconnection = New MySqlConnection(MYconnectionString)
        Try
            MYconnection.Open()
            If MYconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success!")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Connection Failed!")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub
End Class
