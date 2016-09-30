<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnDoctorExternal = New System.Windows.Forms.Button
        Me.btnDoctorIcu = New System.Windows.Forms.Button
        Me.btnDoctorLab = New System.Windows.Forms.Button
        Me.btnDoctor = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.LootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewPersonalDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbfirstname = New System.Windows.Forms.Label
        Me.lbsurname = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.lbsurname)
        Me.GroupBox1.Controls.Add(Me.lbfirstname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnDoctorExternal)
        Me.GroupBox1.Controls.Add(Me.btnDoctorIcu)
        Me.GroupBox1.Controls.Add(Me.btnDoctorLab)
        Me.GroupBox1.Controls.Add(Me.btnDoctor)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 472)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(134, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(88, 62)
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(50, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MAIN MENU"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(17, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 31)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDoctorExternal
        '
        Me.btnDoctorExternal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDoctorExternal.Location = New System.Drawing.Point(15, 280)
        Me.btnDoctorExternal.Name = "btnDoctorExternal"
        Me.btnDoctorExternal.Size = New System.Drawing.Size(187, 31)
        Me.btnDoctorExternal.TabIndex = 3
        Me.btnDoctorExternal.Text = "Request for  help"
        Me.btnDoctorExternal.UseVisualStyleBackColor = True
        '
        'btnDoctorIcu
        '
        Me.btnDoctorIcu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDoctorIcu.Location = New System.Drawing.Point(14, 242)
        Me.btnDoctorIcu.Name = "btnDoctorIcu"
        Me.btnDoctorIcu.Size = New System.Drawing.Size(188, 31)
        Me.btnDoctorIcu.TabIndex = 2
        Me.btnDoctorIcu.Text = "Comments to Administration"
        Me.btnDoctorIcu.UseVisualStyleBackColor = True
        '
        'btnDoctorLab
        '
        Me.btnDoctorLab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDoctorLab.Location = New System.Drawing.Point(14, 205)
        Me.btnDoctorLab.Name = "btnDoctorLab"
        Me.btnDoctorLab.Size = New System.Drawing.Size(188, 31)
        Me.btnDoctorLab.TabIndex = 1
        Me.btnDoctorLab.Text = "FROM LABARATORY"
        Me.btnDoctorLab.UseVisualStyleBackColor = True
        '
        'btnDoctor
        '
        Me.btnDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDoctor.Location = New System.Drawing.Point(15, 166)
        Me.btnDoctor.Name = "btnDoctor"
        Me.btnDoctor.Size = New System.Drawing.Size(187, 31)
        Me.btnDoctor.TabIndex = 0
        Me.btnDoctor.Text = "FROM RECEPTION"
        Me.btnDoctor.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LootToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(219, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LootToolStripMenuItem
        '
        Me.LootToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LootToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ViewPersonalDetailsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.LootToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LootToolStripMenuItem.Name = "LootToolStripMenuItem"
        Me.LootToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.LootToolStripMenuItem.Text = "Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ViewPersonalDetailsToolStripMenuItem
        '
        Me.ViewPersonalDetailsToolStripMenuItem.Name = "ViewPersonalDetailsToolStripMenuItem"
        Me.ViewPersonalDetailsToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.ViewPersonalDetailsToolStripMenuItem.Text = "View personal details"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Logged in: Dr "
        '
        'lbfirstname
        '
        Me.lbfirstname.AutoSize = True
        Me.lbfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbfirstname.Location = New System.Drawing.Point(11, 91)
        Me.lbfirstname.Name = "lbfirstname"
        Me.lbfirstname.Size = New System.Drawing.Size(99, 16)
        Me.lbfirstname.TabIndex = 11
        Me.lbfirstname.Text = "FIRST NAME"
        '
        'lbsurname
        '
        Me.lbsurname.AutoSize = True
        Me.lbsurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbsurname.Location = New System.Drawing.Point(116, 91)
        Me.lbsurname.Name = "lbsurname"
        Me.lbsurname.Size = New System.Drawing.Size(83, 16)
        Me.lbsurname.TabIndex = 12
        Me.lbsurname.Text = "SURNAME"
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1066, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Doctor"
        Me.Text = "Doctor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDoctorExternal As System.Windows.Forms.Button
    Friend WithEvents btnDoctorIcu As System.Windows.Forms.Button
    Friend WithEvents btnDoctorLab As System.Windows.Forms.Button
    Friend WithEvents btnDoctor As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPersonalDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lbsurname As System.Windows.Forms.Label
    Friend WithEvents lbfirstname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
