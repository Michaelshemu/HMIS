<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbsurname = New System.Windows.Forms.Label
        Me.lbfirstname = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRegistrationDelete = New System.Windows.Forms.Button
        Me.txtRegistrationId = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtRegistrationContacts = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnRegistrationSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Search = New System.Windows.Forms.Label
        Me.txtRegistrationPassword = New System.Windows.Forms.TextBox
        Me.txtRegistrationSearch = New System.Windows.Forms.TextBox
        Me.txtRegistrationUsername = New System.Windows.Forms.TextBox
        Me.cbRegistrationStutasName = New System.Windows.Forms.ComboBox
        Me.txtRegistrationMname = New System.Windows.Forms.TextBox
        Me.txtRegistrationSurname = New System.Windows.Forms.TextBox
        Me.txtRegistrationFname = New System.Windows.Forms.TextBox
        Me.bntRegistrationSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dtgvRegistration = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtgvRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbsurname)
        Me.Panel1.Controls.Add(Me.lbfirstname)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 561)
        Me.Panel1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(96, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Logged in :"
        '
        'lbsurname
        '
        Me.lbsurname.AutoSize = True
        Me.lbsurname.BackColor = System.Drawing.SystemColors.Control
        Me.lbsurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsurname.ForeColor = System.Drawing.Color.Blue
        Me.lbsurname.Location = New System.Drawing.Point(296, 0)
        Me.lbsurname.Name = "lbsurname"
        Me.lbsurname.Size = New System.Drawing.Size(87, 20)
        Me.lbsurname.TabIndex = 11
        Me.lbsurname.Text = "last name"
        '
        'lbfirstname
        '
        Me.lbfirstname.AutoSize = True
        Me.lbfirstname.BackColor = System.Drawing.SystemColors.Control
        Me.lbfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfirstname.ForeColor = System.Drawing.Color.Blue
        Me.lbfirstname.Location = New System.Drawing.Point(191, 0)
        Me.lbfirstname.Name = "lbfirstname"
        Me.lbfirstname.Size = New System.Drawing.Size(89, 20)
        Me.lbfirstname.TabIndex = 10
        Me.lbfirstname.Text = "first name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Location = New System.Drawing.Point(0, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "EMPLOYEE 'S REGISTRATION"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegistrationDelete)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationId)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationContacts)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnRegistrationSearch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Search)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationPassword)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationSearch)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationUsername)
        Me.GroupBox1.Controls.Add(Me.cbRegistrationStutasName)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationMname)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationSurname)
        Me.GroupBox1.Controls.Add(Me.txtRegistrationFname)
        Me.GroupBox1.Controls.Add(Me.bntRegistrationSave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 486)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Users"
        '
        'btnRegistrationDelete
        '
        Me.btnRegistrationDelete.Location = New System.Drawing.Point(237, 441)
        Me.btnRegistrationDelete.Name = "btnRegistrationDelete"
        Me.btnRegistrationDelete.Size = New System.Drawing.Size(114, 39)
        Me.btnRegistrationDelete.TabIndex = 17
        Me.btnRegistrationDelete.Text = "DELETE"
        Me.btnRegistrationDelete.UseVisualStyleBackColor = True
        Me.btnRegistrationDelete.Visible = False
        '
        'txtRegistrationId
        '
        Me.txtRegistrationId.Location = New System.Drawing.Point(127, 79)
        Me.txtRegistrationId.Multiline = True
        Me.txtRegistrationId.Name = "txtRegistrationId"
        Me.txtRegistrationId.Size = New System.Drawing.Size(193, 27)
        Me.txtRegistrationId.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Id"
        '
        'txtRegistrationContacts
        '
        Me.txtRegistrationContacts.Location = New System.Drawing.Point(128, 294)
        Me.txtRegistrationContacts.Multiline = True
        Me.txtRegistrationContacts.Name = "txtRegistrationContacts"
        Me.txtRegistrationContacts.Size = New System.Drawing.Size(193, 27)
        Me.txtRegistrationContacts.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "PASSWORD"
        '
        'btnRegistrationSearch
        '
        Me.btnRegistrationSearch.Location = New System.Drawing.Point(320, 14)
        Me.btnRegistrationSearch.Name = "btnRegistrationSearch"
        Me.btnRegistrationSearch.Size = New System.Drawing.Size(66, 26)
        Me.btnRegistrationSearch.TabIndex = 11
        Me.btnRegistrationSearch.Text = "Search"
        Me.btnRegistrationSearch.UseVisualStyleBackColor = True
        Me.btnRegistrationSearch.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CONTACTS"
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(124, 16)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(70, 24)
        Me.Search.TabIndex = 10
        Me.Search.Text = "Search"
        '
        'txtRegistrationPassword
        '
        Me.txtRegistrationPassword.Location = New System.Drawing.Point(128, 374)
        Me.txtRegistrationPassword.Multiline = True
        Me.txtRegistrationPassword.Name = "txtRegistrationPassword"
        Me.txtRegistrationPassword.Size = New System.Drawing.Size(193, 27)
        Me.txtRegistrationPassword.TabIndex = 7
        '
        'txtRegistrationSearch
        '
        Me.txtRegistrationSearch.Location = New System.Drawing.Point(196, 14)
        Me.txtRegistrationSearch.Multiline = True
        Me.txtRegistrationSearch.Name = "txtRegistrationSearch"
        Me.txtRegistrationSearch.Size = New System.Drawing.Size(118, 26)
        Me.txtRegistrationSearch.TabIndex = 0
        '
        'txtRegistrationUsername
        '
        Me.txtRegistrationUsername.Location = New System.Drawing.Point(128, 250)
        Me.txtRegistrationUsername.Multiline = True
        Me.txtRegistrationUsername.Name = "txtRegistrationUsername"
        Me.txtRegistrationUsername.Size = New System.Drawing.Size(193, 27)
        Me.txtRegistrationUsername.TabIndex = 4
        '
        'cbRegistrationStutasName
        '
        Me.cbRegistrationStutasName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegistrationStutasName.FormattingEnabled = True
        Me.cbRegistrationStutasName.Items.AddRange(New Object() {"ADMINISTRATOR", "DOCTOR", "RECEPTIONIST", "LAB TECH", "MEDICAL", "MANAGER"})
        Me.cbRegistrationStutasName.Location = New System.Drawing.Point(128, 336)
        Me.cbRegistrationStutasName.Name = "cbRegistrationStutasName"
        Me.cbRegistrationStutasName.Size = New System.Drawing.Size(193, 21)
        Me.cbRegistrationStutasName.TabIndex = 6
        '
        'txtRegistrationMname
        '
        Me.txtRegistrationMname.Location = New System.Drawing.Point(128, 164)
        Me.txtRegistrationMname.Multiline = True
        Me.txtRegistrationMname.Name = "txtRegistrationMname"
        Me.txtRegistrationMname.Size = New System.Drawing.Size(193, 27)
        Me.txtRegistrationMname.TabIndex = 2
        '
        'txtRegistrationSurname
        '
        Me.txtRegistrationSurname.Location = New System.Drawing.Point(128, 208)
        Me.txtRegistrationSurname.Multiline = True
        Me.txtRegistrationSurname.Name = "txtRegistrationSurname"
        Me.txtRegistrationSurname.Size = New System.Drawing.Size(193, 27)
        Me.txtRegistrationSurname.TabIndex = 3
        '
        'txtRegistrationFname
        '
        Me.txtRegistrationFname.Location = New System.Drawing.Point(128, 122)
        Me.txtRegistrationFname.Multiline = True
        Me.txtRegistrationFname.Name = "txtRegistrationFname"
        Me.txtRegistrationFname.Size = New System.Drawing.Size(193, 27)
        Me.txtRegistrationFname.TabIndex = 1
        '
        'bntRegistrationSave
        '
        Me.bntRegistrationSave.Location = New System.Drawing.Point(117, 441)
        Me.bntRegistrationSave.Name = "bntRegistrationSave"
        Me.bntRegistrationSave.Size = New System.Drawing.Size(114, 39)
        Me.bntRegistrationSave.TabIndex = 8
        Me.bntRegistrationSave.Text = "SAVE"
        Me.bntRegistrationSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MIDDLE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SURNAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "STATUS NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FIRST NAME"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(426, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACCOUNTToolStripMenuItem
        '
        Me.ACCOUNTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ACCOUNTToolStripMenuItem.Name = "ACCOUNTToolStripMenuItem"
        Me.ACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ACCOUNTToolStripMenuItem.Text = "ACCOUNT"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'dtgvRegistration
        '
        Me.dtgvRegistration.AllowUserToAddRows = False
        Me.dtgvRegistration.AllowUserToDeleteRows = False
        Me.dtgvRegistration.AllowUserToOrderColumns = True
        Me.dtgvRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvRegistration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvRegistration.Location = New System.Drawing.Point(426, 0)
        Me.dtgvRegistration.Name = "dtgvRegistration"
        Me.dtgvRegistration.Size = New System.Drawing.Size(511, 561)
        Me.dtgvRegistration.TabIndex = 2
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(937, 561)
        Me.Controls.Add(Me.dtgvRegistration)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtgvRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRegistrationFname As System.Windows.Forms.TextBox
    Friend WithEvents bntRegistrationSave As System.Windows.Forms.Button
    Friend WithEvents cbRegistrationStutasName As System.Windows.Forms.ComboBox
    Friend WithEvents txtRegistrationMname As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistrationSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistrationUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrationSearch As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.Label
    Friend WithEvents txtRegistrationSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRegistrationPassword As System.Windows.Forms.TextBox
    Friend WithEvents dtgvRegistration As System.Windows.Forms.DataGridView
    Friend WithEvents txtRegistrationContacts As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRegistrationId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrationDelete As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbsurname As System.Windows.Forms.Label
    Friend WithEvents lbfirstname As System.Windows.Forms.Label

End Class
