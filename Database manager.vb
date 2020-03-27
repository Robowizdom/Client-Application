Imports System.Data.SQLite
Imports Client_Application.Client_Management

Public Class Database_manager
    Public Shared ReadOnly clientDb As String = "ClientDb.db"
    Public Shared ReadOnly connectionString As String = "Data Source={0};Version=3;"
    Public Shared ReadOnly tableName As String = "Client_Details"
    Public Shared ReadOnly projects() As Array

    Public Shared Sub createDatabase()
        Dim connectionString As String = "Data Source={0};Version=3;"
        connectionString = String.Format(connectionString, clientDb)

        If Not My.Computer.FileSystem.FileExists(clientDb) Then
            Try
                ' Create the SQLite database
                SQLiteConnection.CreateFile(clientDb)
                MessageBox.Show("Database Created...")
            Catch ex As Exception
                MessageBox.Show("Database Created Failed...")
            End Try
        End If
    End Sub

    Public Shared Sub createTable()
        Dim connectionString As String = "Data Source={0};Version=3;"
        Dim create_table As String
        Dim table_name As String = "Client_Details"
        Dim dt As New DataTable

        ' create table sql statement
        create_table = "CREATE TABLE IF NOT EXISTS " & table_name & "("
        create_table &= "Project_ID INTEGER,"
        create_table &= "Name TEXT,"
        create_table &= "Contact NUMERIC,"
        create_table &= "institution TEXT,"
        create_table &= "Project_Name TEXT,"
        create_table &= "Project_StartDate TEXT,"
        create_table &= "Project_EndDate TEXT,"
        create_table &= "Milestone TEXT)"

        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(create_table, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Table created successfully")
            End Using
            con.Close()
        End Using


    End Sub

    Public Shared Sub InsertData()
        Dim connectionString As String = "Data Source={0};Version=3;"
        Dim client As New Client_Management.Client
        Dim table_name As String = "Client_Details"

        Try
            ' insert data into the data table
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction
                        ' create the SQL statements

                        cmd.CommandText = "INSERT INTO " & table_name & "(Name,Contact,Institution,Project_Name,Project_StartDate,Project_EndDate,Milestone) VALUES(@Name,@Contact,@Institution,@Project_Name,@Project_StartDate,@Project_EndDate,@Milestone)"
                        cmd.Prepare()

                        cmd.Parameters.AddWithValue("@Name", client.name)
                        cmd.Parameters.AddWithValue("@Contact", client.contact)
                        cmd.Parameters.AddWithValue("@Institution", client.institution)
                        cmd.Parameters.AddWithValue("@Project_Name", client.projectName)
                        cmd.Parameters.AddWithValue("@Project_StartDate", client.startDate)
                        cmd.Parameters.AddWithValue("@Project_EndDate", client.endDate)
                        cmd.Parameters.AddWithValue("@Milestone", client.milestone)
                        cmd.ExecuteNonQuery()

                    End Using
                    transaction.Commit()
                End Using
                con.Close()
            End Using
            MessageBox.Show("Insert Data successful")
            MessageBox.Show("client added", "", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("Insert Data failed")
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Shared Sub retrieveData(source As String, projects As ArrayList)
        Dim retrieve
        Dim table_name As String = "Client_Details"
        retrieve = "SELECT" & source & "FROM " & table_name & ""
        projects.Add(retrieve)
    End Sub

End Class
