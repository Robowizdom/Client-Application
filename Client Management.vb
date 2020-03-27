Imports Client_Application.Database_manager
Public Class Client_Management
    Public Structure Client

        'client personal details
        Dim name As String
        Dim contact As String
        Dim institution As String

        'project details
        Dim projectName As String
        Dim startDate As String
        Dim endDate As String

        'referred details
        Dim milestone As String

    End Structure

    Dim allProjects As New ArrayList
    Dim loginTime
    Private Sub Client_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' sql commands
        createDatabase()
        createTable()
        timeCount()

        ' connect the combo box to the datasource
        retrieveData("Project_Name", allProjects)
        projectList.DataSource = Nothing
        projectList.DataSource = allProjects

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newClient As New Client
        If Not txtName.Text = Nothing And Not txtContact.Text = Nothing And Not txtProject.Text = Nothing And Not txtInstitution.Text = Nothing And Not txtStartDate.Text = Nothing And Not txtEndDate.Text = Nothing Then
            newClient.name = txtName.Text
            newClient.contact = txtContact.Text
            newClient.institution = txtInstitution.Text
            newClient.projectName = txtProject.Text
            newClient.startDate = txtStartDate.Text
            newClient.endDate = txtEndDate.Text
            newClient.milestone = txtMilestone.Text & " " & txtMilePercent.Text

            allProjects.Add(newClient.projectName)

            Try
                InsertData()
            Catch ex As Exception
                MessageBox.Show("client addition failed", "", MessageBoxButtons.OK)
            End Try



            clearField()
        Else
            MessageBox.Show("Missing field(s)", "Check your input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub
    'clearing the field of text boxes after use
    Private Sub clearField()

        txtEndDate.Clear()
        txtContact.Clear()
        txtName.Clear()
        txtInstitution.Clear()
        txtStartDate.Clear()
        txtProject.Clear()

    End Sub
    'logging out of the application
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Application.Exit()
    End Sub
    ' scrolling through all the available project and their basic details before entering the milestone for each of them
    Private Sub projectList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles projectList.SelectedIndexChanged


    End Sub
    'timer that shows the time since last login
    Private Sub tmrSinceLogin_Tick(sender As Object, e As EventArgs) Handles tmrSinceLogin.Tick
        Dim showtime = Now.Subtract(loginTime)
        lblTimeSinceLogin.Text = showtime.Hour.ToString & ":" & showtime.Minute.ToString & ":" & showtime.Second.ToString
    End Sub
    'timer that instantiate the time once the application is on and running
    Private Sub timeCount()
        ' preset initial values for timing
        loginTime = Now.TimeOfDay
        tmrSinceLogin.Enabled = True
        tmrSinceLogin.Start()
    End Sub
End Class