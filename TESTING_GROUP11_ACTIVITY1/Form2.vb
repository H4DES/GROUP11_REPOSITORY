Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form2

    Public Sub loadData()
        MYconnection = New MySqlConnection(MYconnectionString)

        Dim MYcommand As New MySqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info;", MYconnection)

        Dim da As New MySqlDataAdapter(MYcommand)
        Dim dt As New DataTable

        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Public Sub MSloadData()
        MSconnection = New SqlConnection(MSconnectionString)

        Dim MScommand As New SqlCommand("SELECT * FROM tbl_info", MSconnection)

        Dim da As New SqlDataAdapter(MScommand)
        Dim dt As New DataTable

        da.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub btnMSSQL_INSERT_Click(sender As Object, e As EventArgs) Handles btnMSSQL_INSERT.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Try
            MSconnection.Open()

            Dim selectedCourse As String = course.SelectedItem.ToString()

            Dim query As String = "INSERT INTO tbl_info (idno, firstname, middlename, lastname, course) VALUES (@Id, @Fname, @Mname, @Lname, @Course)"
            Dim MScommand As New SqlCommand(query, MSconnection)

            MScommand.Parameters.AddWithValue("@Id", txtID.Text)
            MScommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MScommand.Parameters.AddWithValue("@Course", selectedCourse)

            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Inserted Successfully!")

            MSloadData()
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub


    'EVENT HANDLER NAME IS btnMYSQL_INSERT_Click
    Private Sub btnMYSQL_INSERT_Click(sender As Object, e As EventArgs) Handles btnMYSQL_INSERT.Click
        MYconnection = New MySqlConnection(MYconnectionString)

        Try
            MYconnection.Open()

            Dim selectedCourse As String = course.SelectedItem.ToString() 'new add combo box codes and course variable name

            Dim query As String = "INSERT INTO tbl_info (idno, firstname, middlename, lastname, course) VALUES (@Id, @Fname, @Mname, @Lname, @Course)"
            Dim MYcommand As New MySqlCommand(query, MYconnection)

            MYcommand.Parameters.AddWithValue("@Id", txtID.Text) ' variable name for all text boxes
            MYcommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MYcommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MYcommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MYcommand.Parameters.AddWithValue("@Course", selectedCourse) 'new add combo box codes

            MessageBox.Show("Records inserted successfully!")

            MYcommand.ExecuteNonQuery() ' codes for execution of upper codes

            loadData()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        MYconnection = New MySqlConnection(MYconnectionString)

        Try

            MYconnection.Open()

            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            txtID.Text = dr.Cells(0).Value.ToString()
            course.Text = dr.Cells(2).Value.ToString()

            Dim query As String = "SELECT firstname, middlename, lastname FROM tbl_info WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)
            MYcommand.Parameters.AddWithValue("@ID", txtID.Text)

            Dim Reader As MySqlDataReader = MYcommand.ExecuteReader()

            If Reader.Read() Then
                txtfname.Text = Reader("firstname").ToString()
                txtmname.Text = Reader("middlename").ToString()
                txtlname.Text = Reader("lastname").ToString()
            Else
                MessageBox.Show("Student not found.")
            End If
            Reader.Close()


        Catch ex As Exception
        Finally
            MYconnection.Close()
        End Try
    End Sub

    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick

        MYconnection = New MySqlConnection(MYconnectionString)

        Try

            MYconnection.Open()
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            txtID.Text = dr.Cells(0).Value.ToString()
            txtfname.Text = dr.Cells(1).Value.ToString()
            txtmname.Text = dr.Cells(2).Value.ToString()
            txtlname.Text = dr.Cells(3).Value.ToString()
            course.Text = dr.Cells(4).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        MSloadData()
    End Sub

    Private Sub btn_MY_Update_Click(sender As Object, e As EventArgs) Handles btn_MY_Update.Click

        MYconnection = New MySqlConnection(MYconnectionString)

        Dim idno As String = txtID.Text

        Try
            MYconnection.Open()
            Dim query As String = "UPDATE tbl_info SET idno = @ID, firstname = @Fname, middlename = @Mname, lastname = @Lname, course = @Course WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)

            MYcommand.Parameters.AddWithValue("@ID", txtID.Text)
            MYcommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MYcommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MYcommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MYcommand.Parameters.AddWithValue("@Course", course.SelectedItem.ToString())

            MYcommand.ExecuteNonQuery()

            MessageBox.Show("Records Updated Successfully!")
            loadData()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try

    End Sub

    Private Sub btn_MS_Update_Click(sender As Object, e As EventArgs) Handles btn_MS_Update.Click
        Dim update As DataGridViewRow = DataGridView2.SelectedRows(0)
        update.Cells(0).Value = txtID.Text
        update.Cells(1).Value = txtfname.Text
        update.Cells(2).Value = txtmname.Text
        update.Cells(3).Value = txtlname.Text
        update.Cells(4).Value = course.SelectedItem.ToString()
    End Sub
End Class