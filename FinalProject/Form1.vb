
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public Property DatabaseConnection As Object
    Public Shared connString As String = "server=localhost; user=root; password=root; database=employee_db;"

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            Using conn As New MySqlConnection(DatabaseConnection.connString)
                conn.Open()
                Dim query As String = "INSERT INTO employees (name, position, salary, department) VALUES (@name, @position, @salary, @department)"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text)
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee added successfully.")
                LoadEmployees()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LoadEmployees()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT * FROM employees"
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvEmployees.DataSource = table
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Using conn As New MySqlConnection(DatabaseConnection.connString)
                conn.Open()
                Dim query As String = "UPDATE employees SET name=@name, position=@position, salary=@salary, department=@department WHERE emp_id=@id"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@id", txtID.Text)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text)
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee updated successfully.")
                LoadEmployees()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Using conn As New MySqlConnection(DatabaseConnection.connString)
                conn.Open()
                Dim query As String = "DELETE FROM employees WHERE emp_id=@id"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@id", txtID.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee deleted.")
                LoadEmployees()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEmployees.Rows(e.RowIndex)
            txtID.Text = row.Cells("emp_id").Value.ToString()
            txtName.Text = row.Cells("name").Value.ToString()
            txtPosition.Text = row.Cells("position").Value.ToString()
            txtSalary.Text = row.Cells("salary").Value.ToString()
            txtDepartment.Text = row.Cells("department").Value.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
        txtName.Clear()
        txtPosition.Clear()
        txtSalary.Clear()
        txtDepartment.Clear()
    End Sub
End Class
