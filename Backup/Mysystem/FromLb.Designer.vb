<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromLb
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnFromLbLabMed = New System.Windows.Forms.Button
        Me.btnFromLbLabRecept = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvFromLbLab = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtFromLbLabtechId = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFromLbLabtechDate = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFromLbLabtechSuname = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtFromLbLabtechFname = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtFromLbPatId = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFromLbPatFname = New System.Windows.Forms.TextBox
        Me.txtFromLbPatLname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFromLbPatMname = New System.Windows.Forms.TextBox
        Me.txtFromLbLabDescr = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvFromLbLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(622, 438)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFromLbLabMed)
        Me.GroupBox2.Controls.Add(Me.btnFromLbLabRecept)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 374)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(735, 69)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Submit to "
        '
        'btnFromLbLabMed
        '
        Me.btnFromLbLabMed.Location = New System.Drawing.Point(138, 25)
        Me.btnFromLbLabMed.Name = "btnFromLbLabMed"
        Me.btnFromLbLabMed.Size = New System.Drawing.Size(75, 32)
        Me.btnFromLbLabMed.TabIndex = 3
        Me.btnFromLbLabMed.Text = "MEDICAL"
        Me.btnFromLbLabMed.UseVisualStyleBackColor = True
        '
        'btnFromLbLabRecept
        '
        Me.btnFromLbLabRecept.Location = New System.Drawing.Point(28, 25)
        Me.btnFromLbLabRecept.Name = "btnFromLbLabRecept"
        Me.btnFromLbLabRecept.Size = New System.Drawing.Size(86, 32)
        Me.btnFromLbLabRecept.TabIndex = 0
        Me.btnFromLbLabRecept.Text = "RECEPTION"
        Me.btnFromLbLabRecept.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvFromLbLab)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 185)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results from Labaratory"
        '
        'DgvFromLbLab
        '
        Me.DgvFromLbLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFromLbLab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFromLbLab.Location = New System.Drawing.Point(3, 16)
        Me.DgvFromLbLab.Name = "DgvFromLbLab"
        Me.DgvFromLbLab.Size = New System.Drawing.Size(411, 166)
        Me.DgvFromLbLab.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(-4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 175)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFromLbLabtechId)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtFromLbLabtechDate)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtFromLbLabtechSuname)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtFromLbLabtechFname)
        Me.GroupBox4.Location = New System.Drawing.Point(435, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 162)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LAB TECH 'S DETAILS"
        '
        'txtFromLbLabtechId
        '
        Me.txtFromLbLabtechId.Location = New System.Drawing.Point(149, 10)
        Me.txtFromLbLabtechId.Name = "txtFromLbLabtechId"
        Me.txtFromLbLabtechId.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbLabtechId.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "SURNAME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "DATE"
        '
        'txtFromLbLabtechDate
        '
        Me.txtFromLbLabtechDate.Location = New System.Drawing.Point(149, 49)
        Me.txtFromLbLabtechDate.Name = "txtFromLbLabtechDate"
        Me.txtFromLbLabtechDate.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbLabtechDate.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "FIRST NAME"
        '
        'txtFromLbLabtechSuname
        '
        Me.txtFromLbLabtechSuname.Location = New System.Drawing.Point(149, 127)
        Me.txtFromLbLabtechSuname.Name = "txtFromLbLabtechSuname"
        Me.txtFromLbLabtechSuname.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbLabtechSuname.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "IDs"
        '
        'txtFromLbLabtechFname
        '
        Me.txtFromLbLabtechFname.Location = New System.Drawing.Point(149, 88)
        Me.txtFromLbLabtechFname.Name = "txtFromLbLabtechFname"
        Me.txtFromLbLabtechFname.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbLabtechFname.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFromLbPatId)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtFromLbPatFname)
        Me.GroupBox3.Controls.Add(Me.txtFromLbPatLname)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtFromLbPatMname)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 162)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PATIENT'S DETAILS"
        '
        'txtFromLbPatId
        '
        Me.txtFromLbPatId.Location = New System.Drawing.Point(149, 10)
        Me.txtFromLbPatId.Name = "txtFromLbPatId"
        Me.txtFromLbPatId.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbPatId.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MIDDLE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LAST NAME"
        '
        'txtFromLbPatFname
        '
        Me.txtFromLbPatFname.Location = New System.Drawing.Point(149, 49)
        Me.txtFromLbPatFname.Name = "txtFromLbPatFname"
        Me.txtFromLbPatFname.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbPatFname.TabIndex = 4
        '
        'txtFromLbPatLname
        '
        Me.txtFromLbPatLname.Location = New System.Drawing.Point(149, 127)
        Me.txtFromLbPatLname.Name = "txtFromLbPatLname"
        Me.txtFromLbPatLname.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbPatLname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IDs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "FIRST NAME"
        '
        'txtFromLbPatMname
        '
        Me.txtFromLbPatMname.Location = New System.Drawing.Point(149, 88)
        Me.txtFromLbPatMname.Name = "txtFromLbPatMname"
        Me.txtFromLbPatMname.Size = New System.Drawing.Size(148, 20)
        Me.txtFromLbPatMname.TabIndex = 1
        '
        'txtFromLbLabDescr
        '
        Me.txtFromLbLabDescr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFromLbLabDescr.Location = New System.Drawing.Point(3, 16)
        Me.txtFromLbLabDescr.Multiline = True
        Me.txtFromLbLabDescr.Name = "txtFromLbLabDescr"
        Me.txtFromLbLabDescr.Size = New System.Drawing.Size(307, 166)
        Me.txtFromLbLabDescr.TabIndex = 10
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtFromLbLabDescr)
        Me.GroupBox5.Location = New System.Drawing.Point(455, 183)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(313, 185)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Decriptions"
        '
        'FromLb
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(780, 479)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FromLb"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FromLb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvFromLbLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFromLbLabMed As System.Windows.Forms.Button
    Friend WithEvents btnFromLbLabRecept As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFromLbPatFname As System.Windows.Forms.TextBox
    Friend WithEvents txtFromLbPatMname As System.Windows.Forms.TextBox
    Friend WithEvents txtFromLbPatId As System.Windows.Forms.TextBox
    Friend WithEvents txtFromLbPatLname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromLbLabtechId As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFromLbLabtechDate As System.Windows.Forms.TextBox
    Friend WithEvents txtFromLbLabtechSuname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFromLbLabtechFname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DgvFromLbLab As System.Windows.Forms.DataGridView
    Friend WithEvents txtFromLbLabDescr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox

End Class
