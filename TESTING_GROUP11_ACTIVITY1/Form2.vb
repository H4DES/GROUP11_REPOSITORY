Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form2

    'SEARCH BAR IN DATA GRID VIEW

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

        Dim MScommand As New SqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info;", MSconnection)

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

            Dim query As String = "INSERT INTO tbl_info (firstname, middlename, lastname, course) VALUES (@Fname, @Mname, @Lname, @Course)"
            Dim MScommand As New SqlCommand(query, MSconnection)

            MScommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MScommand.Parameters.AddWithValue("@Course", selectedCourse)

            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Inserted Successfully!")

            loadData()
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

            Dim query As String = "INSERT INTO tbl_info (firstname, middlename, lastname, course) VALUES (@Fname, @Mname, @Lname, @Course)"
            Dim MYcommand As New MySqlCommand(query, MYconnection)

            MYcommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MYcommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MYcommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MYcommand.Parameters.AddWithValue("@Course", selectedCourse) 'new add combo box codes

            MessageBox.Show("Records inserted successfully!")

            MYcommand.ExecuteNonQuery() ' codes for execution of upper codes

            loadData()
            MSloadData()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub

    Public ID As String = ""

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        MYconnection = New MySqlConnection(MYconnectionString)

        Try

            MYconnection.Open()

            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            ID = dr.Cells(0).Value.ToString()
            course.Text = dr.Cells(2).Value.ToString()

            Dim query As String = "SELECT firstname, middlename, lastname FROM tbl_info WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)
            MYcommand.Parameters.AddWithValue("@ID", ID)

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

        MSconnection = New SqlConnection(MSconnectionString)

        Try

            MSconnection.Open()

            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)

            ID = dr.Cells(0).Value.ToString()
            course.Text = dr.Cells(2).Value.ToString()

            Dim query As String = "SELECT firstname, middlename, lastname FROM tbl_info WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@ID", ID)

            Dim Reader As SqlDataReader = MScommand.ExecuteReader()

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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loadData()
        'MSloadData()
    End Sub

    Private Sub btn_MY_Update_Click(sender As Object, e As EventArgs) Handles btn_MY_Update.Click

        MYconnection = New MySqlConnection(MYconnectionString)


        Try
            MYconnection.Open()
            Dim query As String = "UPDATE tbl_info SET firstname = @Fname, middlename = @Mname, lastname = @Lname, course = @Course WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)

            MYcommand.Parameters.AddWithValue("@ID", ID)
            MYcommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MYcommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MYcommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MYcommand.Parameters.AddWithValue("@Course", course.SelectedItem.ToString())

            MYcommand.ExecuteNonQuery()
            MessageBox.Show("Records Updated Successfully!")
            loadData()
            MSloadData()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try

    End Sub

    Private Sub btn_MS_Update_Click(sender As Object, e As EventArgs) Handles btn_MS_Update.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Try
            MSconnection.Open()
            Dim query As String = "UPDATE tbl_info SET firstname = @Fname, middlename = @Mname, lastname = @Lname, course = @Course WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)

            MScommand.Parameters.AddWithValue("@ID", ID)
            MScommand.Parameters.AddWithValue("@Fname", txtfname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtmname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtlname.Text)
            MScommand.Parameters.AddWithValue("@Course", course.SelectedItem.ToString())


            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Updated Successfully!")

            'txtID.Clear()
            'txtfname.Clear()
            'txtmname.Clear()
            'txtlname.Clear()
            'course.SelectedItem = Nothing

            loadData()
            MSloadData()

        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try

    End Sub

    Private Sub btn_MS_Delete_Click(sender As Object, e As EventArgs) Handles btn_MS_Delete.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Try
            MSconnection.Open()
            Dim query As String = "DELETE FROM tbl_info WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@ID", ID)

            MScommand.ExecuteNonQuery()
            MessageBox.Show("Records Deleted Successfully!")

            txtfname.Clear()
            txtmname.Clear()
            txtlname.Clear()
            course.SelectedItem = Nothing

            loadData()
            MSloadData()
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try

    End Sub

    Private Sub btn_MY_Delete_Click(sender As Object, e As EventArgs) Handles btn_MY_Delete.Click
        MYconnection = New MySqlConnection(MYconnectionString)

        Try
            MYconnection.Open()
            Dim query As String = "DELETE FROM tbl_info WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, MYconnection)
            MYcommand.Parameters.AddWithValue("@ID", ID)

            MYcommand.ExecuteNonQuery()
            MessageBox.Show("Records Deleted Successfully!")


            txtfname.Clear()
            txtmname.Clear()
            txtlname.Clear()
            course.SelectedItem = Nothing

            MSloadData()
            loadData()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try

    End Sub

    Private Sub btn_loadRecords_Click(sender As Object, e As EventArgs) Handles btn_MSloadRecords.Click
        MSloadData()
    End Sub

    Private Sub btn_MYloadRecords_Click(sender As Object, e As EventArgs) Handles btn_MYloadRecords.Click
        loadData()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txtfname.Clear()
        txtmname.Clear()
        txtlname.Clear()
        course.SelectedItem = Nothing

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            MSconnection.Open()

            Dim MScommand As New SqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info WHERE firstname LIKE @holder OR lastname LIKE @holder;", MSconnection)
            MScommand.Parameters.AddWithValue("@holder", txtSearch.Text & "%")

            Dim da As New SqlDataAdapter(MScommand)
            Dim dt As New DataTable

            da.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try

        Try
            MYconnection.Open()

            Dim MYcommand As New MySqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info WHERE firstname LIKE @holder OR lastname LIKE @holder;", MYconnection)
            MYcommand.Parameters.AddWithValue("@holder", txtSearch.Text & "%")

            Dim dta As New MySqlDataAdapter(MYcommand)
            Dim dtl As New DataTable

            dta.Fill(dtl)
            DataGridView1.DataSource = dtl
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            MYconnection.Close()
        End Try
    End Sub

End Class