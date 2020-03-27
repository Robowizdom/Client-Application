<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_Management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.lblTimeSinceLogin = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbClient = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvlContact = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtProject = New System.Windows.Forms.TextBox()
        Me.txtInstitution = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.tbProject = New System.Windows.Forms.TabPage()
        Me.txtMilePercent = New System.Windows.Forms.TextBox()
        Me.txtMilestone = New System.Windows.Forms.TextBox()
        Me.projectList = New System.Windows.Forms.ComboBox()
        Me.paymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblMilestone = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPrjDaysLeft = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPrjEndDate = New System.Windows.Forms.Label()
        Me.lblPrjStartDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrjName = New System.Windows.Forms.Label()
        Me.tbSummary = New System.Windows.Forms.TabPage()
        Me.tmrSinceLogin = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbClient.SuspendLayout()
        Me.tbProject.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.lblHello)
        Me.Panel1.Controls.Add(Me.lblTimeSinceLogin)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(123, 317)
        Me.Panel1.TabIndex = 0
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(11, 9)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(96, 19)
        Me.lblHello.TabIndex = 1
        Me.lblHello.Text = "Hello World!"
        '
        'lblTimeSinceLogin
        '
        Me.lblTimeSinceLogin.AutoSize = True
        Me.lblTimeSinceLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSinceLogin.Location = New System.Drawing.Point(61, 237)
        Me.lblTimeSinceLogin.Name = "lblTimeSinceLogin"
        Me.lblTimeSinceLogin.Size = New System.Drawing.Size(61, 15)
        Me.lblTimeSinceLogin.TabIndex = 1
        Me.lblTimeSinceLogin.Text = "hh:mm:ss"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(4, 222)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 15)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Time Since Login"
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Poor Richard", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(19, 276)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 28)
        Me.btnLogOut.TabIndex = 0
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(30, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(123, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 28)
        Me.Panel2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbClient)
        Me.TabControl1.Controls.Add(Me.tbProject)
        Me.TabControl1.Controls.Add(Me.tbSummary)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(123, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(416, 289)
        Me.TabControl1.TabIndex = 0
        '
        'tbClient
        '
        Me.tbClient.BackColor = System.Drawing.Color.Transparent
        Me.tbClient.Controls.Add(Me.Label5)
        Me.tbClient.Controls.Add(Me.Label4)
        Me.tbClient.Controls.Add(Me.btnSave)
        Me.tbClient.Controls.Add(Me.Label3)
        Me.tbClient.Controls.Add(Me.Label2)
        Me.tbClient.Controls.Add(Me.lvlContact)
        Me.tbClient.Controls.Add(Me.Label6)
        Me.tbClient.Controls.Add(Me.lblName)
        Me.tbClient.Controls.Add(Me.txtEndDate)
        Me.tbClient.Controls.Add(Me.txtStartDate)
        Me.tbClient.Controls.Add(Me.txtProject)
        Me.tbClient.Controls.Add(Me.txtInstitution)
        Me.tbClient.Controls.Add(Me.txtContact)
        Me.tbClient.Controls.Add(Me.txtName)
        Me.tbClient.Location = New System.Drawing.Point(4, 22)
        Me.tbClient.Name = "tbClient"
        Me.tbClient.Padding = New System.Windows.Forms.Padding(3)
        Me.tbClient.Size = New System.Drawing.Size(408, 263)
        Me.tbClient.TabIndex = 0
        Me.tbClient.Text = "Client Profile"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Start Date"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(285, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Details"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Institution"
        '
        'lvlContact
        '
        Me.lvlContact.AutoSize = True
        Me.lvlContact.BackColor = System.Drawing.Color.Transparent
        Me.lvlContact.ForeColor = System.Drawing.Color.Black
        Me.lvlContact.Location = New System.Drawing.Point(30, 71)
        Me.lvlContact.Name = "lvlContact"
        Me.lvlContact.Size = New System.Drawing.Size(44, 13)
        Me.lvlContact.TabIndex = 1
        Me.lvlContact.Text = "Contact"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(88, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Client Details"
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(91, 172)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(269, 20)
        Me.txtEndDate.TabIndex = 0
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(91, 146)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(269, 20)
        Me.txtStartDate.TabIndex = 0
        '
        'txtProject
        '
        Me.txtProject.Location = New System.Drawing.Point(91, 120)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(269, 20)
        Me.txtProject.TabIndex = 0
        '
        'txtInstitution
        '
        Me.txtInstitution.Location = New System.Drawing.Point(91, 94)
        Me.txtInstitution.Name = "txtInstitution"
        Me.txtInstitution.Size = New System.Drawing.Size(269, 20)
        Me.txtInstitution.TabIndex = 0
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(91, 68)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(269, 20)
        Me.txtContact.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(91, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 20)
        Me.txtName.TabIndex = 0
        '
        'tbProject
        '
        Me.tbProject.BackColor = System.Drawing.Color.Transparent
        Me.tbProject.Controls.Add(Me.txtMilePercent)
        Me.tbProject.Controls.Add(Me.txtMilestone)
        Me.tbProject.Controls.Add(Me.projectList)
        Me.tbProject.Controls.Add(Me.paymentMethod)
        Me.tbProject.Controls.Add(Me.Label13)
        Me.tbProject.Controls.Add(Me.lblMilestone)
        Me.tbProject.Controls.Add(Me.Label14)
        Me.tbProject.Controls.Add(Me.lblPrjDaysLeft)
        Me.tbProject.Controls.Add(Me.Label15)
        Me.tbProject.Controls.Add(Me.lblPrjEndDate)
        Me.tbProject.Controls.Add(Me.lblPrjStartDate)
        Me.tbProject.Controls.Add(Me.Label1)
        Me.tbProject.Controls.Add(Me.lblPrjName)
        Me.tbProject.Location = New System.Drawing.Point(4, 22)
        Me.tbProject.Name = "tbProject"
        Me.tbProject.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProject.Size = New System.Drawing.Size(408, 263)
        Me.tbProject.TabIndex = 1
        Me.tbProject.Text = "Project"
        '
        'txtMilePercent
        '
        Me.txtMilePercent.Location = New System.Drawing.Point(330, 116)
        Me.txtMilePercent.Name = "txtMilePercent"
        Me.txtMilePercent.Size = New System.Drawing.Size(55, 20)
        Me.txtMilePercent.TabIndex = 2
        '
        'txtMilestone
        '
        Me.txtMilestone.Location = New System.Drawing.Point(87, 116)
        Me.txtMilestone.Name = "txtMilestone"
        Me.txtMilestone.Size = New System.Drawing.Size(198, 20)
        Me.txtMilestone.TabIndex = 2
        '
        'projectList
        '
        Me.projectList.FormattingEnabled = True
        Me.projectList.Location = New System.Drawing.Point(112, 6)
        Me.projectList.Name = "projectList"
        Me.projectList.Size = New System.Drawing.Size(288, 21)
        Me.projectList.TabIndex = 1
        '
        'paymentMethod
        '
        Me.paymentMethod.FormattingEnabled = True
        Me.paymentMethod.Location = New System.Drawing.Point(135, 225)
        Me.paymentMethod.Name = "paymentMethod"
        Me.paymentMethod.Size = New System.Drawing.Size(267, 21)
        Me.paymentMethod.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Payment Method"
        '
        'lblMilestone
        '
        Me.lblMilestone.AutoSize = True
        Me.lblMilestone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilestone.ForeColor = System.Drawing.Color.Black
        Me.lblMilestone.Location = New System.Drawing.Point(6, 116)
        Me.lblMilestone.Name = "lblMilestone"
        Me.lblMilestone.Size = New System.Drawing.Size(75, 16)
        Me.lblMilestone.TabIndex = 0
        Me.lblMilestone.Text = "Milestone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(303, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "%"
        '
        'lblPrjDaysLeft
        '
        Me.lblPrjDaysLeft.AutoSize = True
        Me.lblPrjDaysLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjDaysLeft.ForeColor = System.Drawing.Color.Black
        Me.lblPrjDaysLeft.Location = New System.Drawing.Point(224, 71)
        Me.lblPrjDaysLeft.Name = "lblPrjDaysLeft"
        Me.lblPrjDaysLeft.Size = New System.Drawing.Size(81, 16)
        Me.lblPrjDaysLeft.TabIndex = 0
        Me.lblPrjDaysLeft.Text = "Days Left :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(84, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Mile per Stone"
        '
        'lblPrjEndDate
        '
        Me.lblPrjEndDate.AutoSize = True
        Me.lblPrjEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjEndDate.ForeColor = System.Drawing.Color.Black
        Me.lblPrjEndDate.Location = New System.Drawing.Point(6, 84)
        Me.lblPrjEndDate.Name = "lblPrjEndDate"
        Me.lblPrjEndDate.Size = New System.Drawing.Size(118, 16)
        Me.lblPrjEndDate.TabIndex = 0
        Me.lblPrjEndDate.Text = "Date when due :"
        '
        'lblPrjStartDate
        '
        Me.lblPrjStartDate.AutoSize = True
        Me.lblPrjStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjStartDate.ForeColor = System.Drawing.Color.Black
        Me.lblPrjStartDate.Location = New System.Drawing.Point(6, 61)
        Me.lblPrjStartDate.Name = "lblPrjStartDate"
        Me.lblPrjStartDate.Size = New System.Drawing.Size(85, 16)
        Me.lblPrjStartDate.TabIndex = 0
        Me.lblPrjStartDate.Text = "Start Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project List :"
        '
        'lblPrjName
        '
        Me.lblPrjName.AutoSize = True
        Me.lblPrjName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjName.ForeColor = System.Drawing.Color.Black
        Me.lblPrjName.Location = New System.Drawing.Point(6, 37)
        Me.lblPrjName.Name = "lblPrjName"
        Me.lblPrjName.Size = New System.Drawing.Size(110, 16)
        Me.lblPrjName.TabIndex = 0
        Me.lblPrjName.Text = "Project Name :"
        '
        'tbSummary
        '
        Me.tbSummary.BackColor = System.Drawing.Color.Transparent
        Me.tbSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbSummary.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbSummary.Location = New System.Drawing.Point(4, 22)
        Me.tbSummary.Name = "tbSummary"
        Me.tbSummary.Size = New System.Drawing.Size(408, 263)
        Me.tbSummary.TabIndex = 2
        Me.tbSummary.Text = "Summary"
        '
        'tmrSinceLogin
        '
        Me.tmrSinceLogin.Interval = 1000
        '
        'Client_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(539, 317)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Client_Management"
        Me.Text = "Client_Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbClient.ResumeLayout(False)
        Me.tbClient.PerformLayout()
        Me.tbProject.ResumeLayout(False)
        Me.tbProject.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbClient As TabPage
    Friend WithEvents tbProject As TabPage
    Friend WithEvents lblName As Label
    Friend WithEvents lblHello As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents tbSummary As TabPage
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents txtProject As TextBox
    Friend WithEvents txtInstitution As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvlContact As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblPrjDaysLeft As Label
    Friend WithEvents lblPrjEndDate As Label
    Friend WithEvents lblPrjStartDate As Label
    Friend WithEvents lblPrjName As Label
    Friend WithEvents lblTimeSinceLogin As Label
    Friend WithEvents lblMilestone As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents paymentMethod As ComboBox
    Friend WithEvents txtMilePercent As TextBox
    Friend WithEvents txtMilestone As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tmrSinceLogin As Timer
    Friend WithEvents projectList As ComboBox
    Friend WithEvents Label1 As Label
End Class
