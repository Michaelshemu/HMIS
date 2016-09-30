<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DRUGS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDrugsDetailsName = New System.Windows.Forms.TextBox
        Me.btnDrugsDetailsSearch = New System.Windows.Forms.Button
        Me.RadioDrugsDetailsperPerDrug = New System.Windows.Forms.RadioButton
        Me.RadioDrugsDetailsperBottle = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDrugsDetailsAmount = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDrugsDetailsPayment = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDrugsDetailsDescriptions = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDrugsDetailsSearch = New System.Windows.Forms.TextBox
        Me.btnDrugsDetailsSubmit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DgvDrugsDetails = New System.Windows.Forms.DataGridView
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDrugsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(718, 369)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDrugsDetailsName)
        Me.GroupBox1.Controls.Add(Me.btnDrugsDetailsSearch)
        Me.GroupBox1.Controls.Add(Me.RadioDrugsDetailsperPerDrug)
        Me.GroupBox1.Controls.Add(Me.RadioDrugsDetailsperBottle)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDrugsDetailsAmount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDrugsDetailsPayment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDrugsDetailsDescriptions)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDrugsDetailsSearch)
        Me.GroupBox1.Controls.Add(Me.btnDrugsDetailsSubmit)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 410)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drug's Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "NAME"
        '
        'txtDrugsDetailsName
        '
        Me.txtDrugsDetailsName.Location = New System.Drawing.Point(129, 124)
        Me.txtDrugsDetailsName.Name = "txtDrugsDetailsName"
        Me.txtDrugsDetailsName.Size = New System.Drawing.Size(188, 20)
        Me.txtDrugsDetailsName.TabIndex = 14
        '
        'btnDrugsDetailsSearch
        '
        Me.btnDrugsDetailsSearch.Location = New System.Drawing.Point(344, 12)
        Me.btnDrugsDetailsSearch.Name = "btnDrugsDetailsSearch"
        Me.btnDrugsDetailsSearch.Size = New System.Drawing.Size(63, 23)
        Me.btnDrugsDetailsSearch.TabIndex = 13
        Me.btnDrugsDetailsSearch.Text = "Search"
        Me.btnDrugsDetailsSearch.UseVisualStyleBackColor = True
        '
        'RadioDrugsDetailsperPerDrug
        '
        Me.RadioDrugsDetailsperPerDrug.AutoSize = True
        Me.RadioDrugsDetailsperPerDrug.Location = New System.Drawing.Point(225, 209)
        Me.RadioDrugsDetailsperPerDrug.Name = "RadioDrugsDetailsperPerDrug"
        Me.RadioDrugsDetailsperPerDrug.Size = New System.Drawing.Size(67, 17)
        Me.RadioDrugsDetailsperPerDrug.TabIndex = 12
        Me.RadioDrugsDetailsperPerDrug.TabStop = True
        Me.RadioDrugsDetailsperPerDrug.Text = "Per Drug"
        Me.RadioDrugsDetailsperPerDrug.UseVisualStyleBackColor = True
        '
        'RadioDrugsDetailsperBottle
        '
        Me.RadioDrugsDetailsperBottle.AutoSize = True
        Me.RadioDrugsDetailsperBottle.Location = New System.Drawing.Point(129, 207)
        Me.RadioDrugsDetailsperBottle.Name = "RadioDrugsDetailsperBottle"
        Me.RadioDrugsDetailsperBottle.Size = New System.Drawing.Size(71, 17)
        Me.RadioDrugsDetailsperBottle.TabIndex = 11
        Me.RadioDrugsDetailsperBottle.TabStop = True
        Me.RadioDrugsDetailsperBottle.Text = "Per Bottle"
        Me.RadioDrugsDetailsperBottle.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "AMOUNT"
        '
        'txtDrugsDetailsAmount
        '
        Me.txtDrugsDetailsAmount.Location = New System.Drawing.Point(129, 241)
        Me.txtDrugsDetailsAmount.Name = "txtDrugsDetailsAmount"
        Me.txtDrugsDetailsAmount.Size = New System.Drawing.Size(188, 20)
        Me.txtDrugsDetailsAmount.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PAYMENT"
        '
        'txtDrugsDetailsPayment
        '
        Me.txtDrugsDetailsPayment.Location = New System.Drawing.Point(124, 287)
        Me.txtDrugsDetailsPayment.Name = "txtDrugsDetailsPayment"
        Me.txtDrugsDetailsPayment.Size = New System.Drawing.Size(193, 20)
        Me.txtDrugsDetailsPayment.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DESCRIPTIONS"
        '
        'txtDrugsDetailsDescriptions
        '
        Me.txtDrugsDetailsDescriptions.Location = New System.Drawing.Point(129, 164)
        Me.txtDrugsDetailsDescriptions.Name = "txtDrugsDetailsDescriptions"
        Me.txtDrugsDetailsDescriptions.Size = New System.Drawing.Size(188, 20)
        Me.txtDrugsDetailsDescriptions.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DOSE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH"
        '
        'txtDrugsDetailsSearch
        '
        Me.txtDrugsDetailsSearch.Location = New System.Drawing.Point(223, 13)
        Me.txtDrugsDetailsSearch.Name = "txtDrugsDetailsSearch"
        Me.txtDrugsDetailsSearch.Size = New System.Drawing.Size(115, 20)
        Me.txtDrugsDetailsSearch.TabIndex = 1
        '
        'btnDrugsDetailsSubmit
        '
        Me.btnDrugsDetailsSubmit.Location = New System.Drawing.Point(157, 320)
        Me.btnDrugsDetailsSubmit.Name = "btnDrugsDetailsSubmit"
        Me.btnDrugsDetailsSubmit.Size = New System.Drawing.Size(108, 32)
        Me.btnDrugsDetailsSubmit.TabIndex = 0
        Me.btnDrugsDetailsSubmit.Text = "SUBMIT"
        Me.btnDrugsDetailsSubmit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvDrugsDetails)
        Me.Panel1.Location = New System.Drawing.Point(413, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 366)
        Me.Panel1.TabIndex = 2
        '
        'DgvDrugsDetails
        '
        Me.DgvDrugsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDrugsDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDrugsDetails.Location = New System.Drawing.Point(0, 0)
        Me.DgvDrugsDetails.Name = "DgvDrugsDetails"
        Me.DgvDrugsDetails.Size = New System.Drawing.Size(463, 366)
        Me.DgvDrugsDetails.TabIndex = 0
        '
        'DRUGS
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(876, 410)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DRUGS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DRUGS"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvDrugsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DgvDrugsDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDrugsDetailsPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDrugsDetailsDescriptions As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDrugsDetailsSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDrugsDetailsSubmit As System.Windows.Forms.Button
    Friend WithEvents RadioDrugsDetailsperBottle As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDrugsDetailsAmount As System.Windows.Forms.TextBox
    Friend WithEvents RadioDrugsDetailsperPerDrug As System.Windows.Forms.RadioButton
    Friend WithEvents btnDrugsDetailsSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDrugsDetailsName As System.Windows.Forms.TextBox

End Class
