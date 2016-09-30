<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medical
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbsurname = New System.Windows.Forms.Label
        Me.lbfirstname = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewMyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Dtgvmedical = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnmedicaldelete = New System.Windows.Forms.Button
        Me.DatemedicalExpiredDate = New System.Windows.Forms.DateTimePicker
        Me.cbmedicalcategory = New System.Windows.Forms.ComboBox
        Me.btnmedicalSearch = New System.Windows.Forms.Button
        Me.txtmedicalSearch = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnmedicalSell = New System.Windows.Forms.Button
        Me.txtmedicalName = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtmedicalPrice = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtmedicalQuantity = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtmedicalId = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnmedicalSave = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DgvMedFrmDoct = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtMedFrmDoctSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnMedFrmDoctSearch = New System.Windows.Forms.Button
        Me.btnMedFrmDoctAssDrug = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMedFrmDoctAge = New System.Windows.Forms.TextBox
        Me.txtMedFrmDoctSex = New System.Windows.Forms.TextBox
        Me.txtMedFrmDoctId = New System.Windows.Forms.TextBox
        Me.txtMedFrmDoctSurName = New System.Windows.Forms.TextBox
        Me.txtMedFrmDoctFname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Dtgvmedical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvMedFrmDoct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lbsurname)
        Me.Panel2.Controls.Add(Me.lbfirstname)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(869, 24)
        Me.Panel2.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(115, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Logged in :"
        '
        'lbsurname
        '
        Me.lbsurname.AutoSize = True
        Me.lbsurname.BackColor = System.Drawing.SystemColors.Control
        Me.lbsurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsurname.ForeColor = System.Drawing.Color.Blue
        Me.lbsurname.Location = New System.Drawing.Point(315, 4)
        Me.lbsurname.Name = "lbsurname"
        Me.lbsurname.Size = New System.Drawing.Size(87, 20)
        Me.lbsurname.TabIndex = 2
        Me.lbsurname.Text = "last name"
        '
        'lbfirstname
        '
        Me.lbfirstname.AutoSize = True
        Me.lbfirstname.BackColor = System.Drawing.SystemColors.Control
        Me.lbfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfirstname.ForeColor = System.Drawing.Color.Blue
        Me.lbfirstname.Location = New System.Drawing.Point(210, 4)
        Me.lbfirstname.Name = "lbfirstname"
        Me.lbfirstname.Size = New System.Drawing.Size(89, 20)
        Me.lbfirstname.TabIndex = 1
        Me.lbfirstname.Text = "first name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACCOUNTToolStripMenuItem
        '
        Me.ACCOUNTToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ACCOUNTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMyProfileToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ACCOUNTToolStripMenuItem.Name = "ACCOUNTToolStripMenuItem"
        Me.ACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ACCOUNTToolStripMenuItem.Text = "ACCOUNT"
        '
        'ViewMyProfileToolStripMenuItem
        '
        Me.ViewMyProfileToolStripMenuItem.Name = "ViewMyProfileToolStripMenuItem"
        Me.ViewMyProfileToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ViewMyProfileToolStripMenuItem.Text = "View my profile"
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Dtgvmedical)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(861, 497)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MEDICINES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Dtgvmedical
        '
        Me.Dtgvmedical.AllowUserToAddRows = False
        Me.Dtgvmedical.AllowUserToDeleteRows = False
        Me.Dtgvmedical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgvmedical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dtgvmedical.Location = New System.Drawing.Point(367, 3)
        Me.Dtgvmedical.Name = "Dtgvmedical"
        Me.Dtgvmedical.ReadOnly = True
        Me.Dtgvmedical.Size = New System.Drawing.Size(491, 491)
        Me.Dtgvmedical.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Controls.Add(Me.btnmedicaldelete)
        Me.GroupBox2.Controls.Add(Me.DatemedicalExpiredDate)
        Me.GroupBox2.Controls.Add(Me.cbmedicalcategory)
        Me.GroupBox2.Controls.Add(Me.btnmedicalSearch)
        Me.GroupBox2.Controls.Add(Me.txtmedicalSearch)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.btnmedicalSell)
        Me.GroupBox2.Controls.Add(Me.txtmedicalName)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtmedicalPrice)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtmedicalQuantity)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtmedicalId)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btnmedicalSave)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 491)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAILS"
        '
        'btnmedicaldelete
        '
        Me.btnmedicaldelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnmedicaldelete.Location = New System.Drawing.Point(152, 413)
        Me.btnmedicaldelete.Name = "btnmedicaldelete"
        Me.btnmedicaldelete.Size = New System.Drawing.Size(173, 38)
        Me.btnmedicaldelete.TabIndex = 26
        Me.btnmedicaldelete.Text = "DELETE"
        Me.btnmedicaldelete.UseVisualStyleBackColor = True
        Me.btnmedicaldelete.Visible = False
        '
        'DatemedicalExpiredDate
        '
        Me.DatemedicalExpiredDate.Location = New System.Drawing.Point(140, 252)
        Me.DatemedicalExpiredDate.Name = "DatemedicalExpiredDate"
        Me.DatemedicalExpiredDate.Size = New System.Drawing.Size(200, 20)
        Me.DatemedicalExpiredDate.TabIndex = 25
        '
        'cbmedicalcategory
        '
        Me.cbmedicalcategory.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmedicalcategory.FormattingEnabled = True
        Me.cbmedicalcategory.Location = New System.Drawing.Point(140, 286)
        Me.cbmedicalcategory.Name = "cbmedicalcategory"
        Me.cbmedicalcategory.Size = New System.Drawing.Size(200, 24)
        Me.cbmedicalcategory.TabIndex = 24
        '
        'btnmedicalSearch
        '
        Me.btnmedicalSearch.Location = New System.Drawing.Point(254, 45)
        Me.btnmedicalSearch.Name = "btnmedicalSearch"
        Me.btnmedicalSearch.Size = New System.Drawing.Size(74, 28)
        Me.btnmedicalSearch.TabIndex = 23
        Me.btnmedicalSearch.Text = "search"
        Me.btnmedicalSearch.UseVisualStyleBackColor = True
        Me.btnmedicalSearch.Visible = False
        '
        'txtmedicalSearch
        '
        Me.txtmedicalSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmedicalSearch.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedicalSearch.Location = New System.Drawing.Point(250, 19)
        Me.txtmedicalSearch.Name = "txtmedicalSearch"
        Me.txtmedicalSearch.Size = New System.Drawing.Size(108, 22)
        Me.txtmedicalSearch.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(180, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "SEARCH"
        '
        'btnmedicalSell
        '
        Me.btnmedicalSell.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnmedicalSell.Location = New System.Drawing.Point(155, 369)
        Me.btnmedicalSell.Name = "btnmedicalSell"
        Me.btnmedicalSell.Size = New System.Drawing.Size(173, 38)
        Me.btnmedicalSell.TabIndex = 19
        Me.btnmedicalSell.Text = "SELL"
        Me.btnmedicalSell.UseVisualStyleBackColor = True
        '
        'txtmedicalName
        '
        Me.txtmedicalName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtmedicalName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedicalName.Location = New System.Drawing.Point(152, 119)
        Me.txtmedicalName.Name = "txtmedicalName"
        Me.txtmedicalName.Size = New System.Drawing.Size(176, 22)
        Me.txtmedicalName.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 16)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "NAME"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 291)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 16)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "CATEGORIES"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 211)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "PRICE"
        '
        'txtmedicalPrice
        '
        Me.txtmedicalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtmedicalPrice.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedicalPrice.Location = New System.Drawing.Point(152, 207)
        Me.txtmedicalPrice.Name = "txtmedicalPrice"
        Me.txtmedicalPrice.Size = New System.Drawing.Size(176, 22)
        Me.txtmedicalPrice.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "EXPIRE DATE"
        '
        'txtmedicalQuantity
        '
        Me.txtmedicalQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtmedicalQuantity.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedicalQuantity.Location = New System.Drawing.Point(152, 161)
        Me.txtmedicalQuantity.Name = "txtmedicalQuantity"
        Me.txtmedicalQuantity.Size = New System.Drawing.Size(176, 22)
        Me.txtmedicalQuantity.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "QUANTITY"
        '
        'txtmedicalId
        '
        Me.txtmedicalId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtmedicalId.Enabled = False
        Me.txtmedicalId.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedicalId.Location = New System.Drawing.Point(152, 79)
        Me.txtmedicalId.Name = "txtmedicalId"
        Me.txtmedicalId.Size = New System.Drawing.Size(78, 22)
        Me.txtmedicalId.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "ID"
        '
        'btnmedicalSave
        '
        Me.btnmedicalSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnmedicalSave.Location = New System.Drawing.Point(155, 325)
        Me.btnmedicalSave.Name = "btnmedicalSave"
        Me.btnmedicalSave.Size = New System.Drawing.Size(173, 38)
        Me.btnmedicalSave.TabIndex = 20
        Me.btnmedicalSave.Text = "SAVE"
        Me.btnmedicalSave.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(861, 497)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FROM DOCTOR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DgvMedFrmDoct)
        Me.Panel1.Location = New System.Drawing.Point(3, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 198)
        Me.Panel1.TabIndex = 0
        '
        'DgvMedFrmDoct
        '
        Me.DgvMedFrmDoct.AllowUserToAddRows = False
        Me.DgvMedFrmDoct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMedFrmDoct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMedFrmDoct.Location = New System.Drawing.Point(0, 0)
        Me.DgvMedFrmDoct.Name = "DgvMedFrmDoct"
        Me.DgvMedFrmDoct.ReadOnly = True
        Me.DgvMedFrmDoct.Size = New System.Drawing.Size(855, 198)
        Me.DgvMedFrmDoct.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtMedFrmDoctSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnMedFrmDoctSearch)
        Me.GroupBox1.Controls.Add(Me.btnMedFrmDoctAssDrug)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMedFrmDoctAge)
        Me.GroupBox1.Controls.Add(Me.txtMedFrmDoctSex)
        Me.GroupBox1.Controls.Add(Me.txtMedFrmDoctId)
        Me.GroupBox1.Controls.Add(Me.txtMedFrmDoctSurName)
        Me.GroupBox1.Controls.Add(Me.txtMedFrmDoctFname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 491)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(382, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 47)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "RIPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(382, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 32)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "SUBMIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 37)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "ASSIGN DRUGS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "DISEASES"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "SURNAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(397, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "SURNAME"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(72, 95)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(304, 29)
        Me.TextBox2.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(602, 28)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 29)
        Me.TextBox1.TabIndex = 28
        '
        'txtMedFrmDoctSearch
        '
        Me.txtMedFrmDoctSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedFrmDoctSearch.Location = New System.Drawing.Point(698, 193)
        Me.txtMedFrmDoctSearch.Multiline = True
        Me.txtMedFrmDoctSearch.Name = "txtMedFrmDoctSearch"
        Me.txtMedFrmDoctSearch.Size = New System.Drawing.Size(86, 29)
        Me.txtMedFrmDoctSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(626, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Search"
        '
        'btnMedFrmDoctSearch
        '
        Me.btnMedFrmDoctSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMedFrmDoctSearch.Location = New System.Drawing.Point(788, 193)
        Me.btnMedFrmDoctSearch.Name = "btnMedFrmDoctSearch"
        Me.btnMedFrmDoctSearch.Size = New System.Drawing.Size(62, 29)
        Me.btnMedFrmDoctSearch.TabIndex = 25
        Me.btnMedFrmDoctSearch.Text = "Search"
        Me.btnMedFrmDoctSearch.UseVisualStyleBackColor = True
        Me.btnMedFrmDoctSearch.Visible = False
        '
        'btnMedFrmDoctAssDrug
        '
        Me.btnMedFrmDoctAssDrug.Location = New System.Drawing.Point(382, 95)
        Me.btnMedFrmDoctAssDrug.Name = "btnMedFrmDoctAssDrug"
        Me.btnMedFrmDoctAssDrug.Size = New System.Drawing.Size(144, 37)
        Me.btnMedFrmDoctAssDrug.TabIndex = 23
        Me.btnMedFrmDoctAssDrug.Text = "ASSIGN DRUGS"
        Me.btnMedFrmDoctAssDrug.UseVisualStyleBackColor = True
        Me.btnMedFrmDoctAssDrug.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 130)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(376, 95)
        Me.ListBox1.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(627, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "SEX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(544, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "AGE"
        '
        'txtMedFrmDoctAge
        '
        Me.txtMedFrmDoctAge.Enabled = False
        Me.txtMedFrmDoctAge.Location = New System.Drawing.Point(547, 28)
        Me.txtMedFrmDoctAge.Multiline = True
        Me.txtMedFrmDoctAge.Name = "txtMedFrmDoctAge"
        Me.txtMedFrmDoctAge.Size = New System.Drawing.Size(49, 29)
        Me.txtMedFrmDoctAge.TabIndex = 11
        '
        'txtMedFrmDoctSex
        '
        Me.txtMedFrmDoctSex.Enabled = False
        Me.txtMedFrmDoctSex.Location = New System.Drawing.Point(453, 28)
        Me.txtMedFrmDoctSex.Multiline = True
        Me.txtMedFrmDoctSex.Name = "txtMedFrmDoctSex"
        Me.txtMedFrmDoctSex.Size = New System.Drawing.Size(73, 29)
        Me.txtMedFrmDoctSex.TabIndex = 9
        '
        'txtMedFrmDoctId
        '
        Me.txtMedFrmDoctId.Enabled = False
        Me.txtMedFrmDoctId.Location = New System.Drawing.Point(6, 28)
        Me.txtMedFrmDoctId.Multiline = True
        Me.txtMedFrmDoctId.Name = "txtMedFrmDoctId"
        Me.txtMedFrmDoctId.Size = New System.Drawing.Size(62, 29)
        Me.txtMedFrmDoctId.TabIndex = 1
        '
        'txtMedFrmDoctSurName
        '
        Me.txtMedFrmDoctSurName.Enabled = False
        Me.txtMedFrmDoctSurName.Location = New System.Drawing.Point(272, 28)
        Me.txtMedFrmDoctSurName.Multiline = True
        Me.txtMedFrmDoctSurName.Name = "txtMedFrmDoctSurName"
        Me.txtMedFrmDoctSurName.Size = New System.Drawing.Size(175, 29)
        Me.txtMedFrmDoctSurName.TabIndex = 3
        '
        'txtMedFrmDoctFname
        '
        Me.txtMedFrmDoctFname.Enabled = False
        Me.txtMedFrmDoctFname.Location = New System.Drawing.Point(88, 29)
        Me.txtMedFrmDoctFname.Multiline = True
        Me.txtMedFrmDoctFname.Name = "txtMedFrmDoctFname"
        Me.txtMedFrmDoctFname.Size = New System.Drawing.Size(161, 29)
        Me.txtMedFrmDoctFname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SURNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FIRST NAME"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(869, 523)
        Me.TabControl1.TabIndex = 0
        '
        'Medical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 553)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Medical"
        Me.Text = "Medical"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Dtgvmedical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvMedFrmDoct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMyProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Dtgvmedical As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnmedicaldelete As System.Windows.Forms.Button
    Friend WithEvents DatemedicalExpiredDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbmedicalcategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnmedicalSearch As System.Windows.Forms.Button
    Friend WithEvents txtmedicalSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnmedicalSell As System.Windows.Forms.Button
    Friend WithEvents txtmedicalName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtmedicalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtmedicalQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtmedicalId As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnmedicalSave As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DgvMedFrmDoct As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMedFrmDoctSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMedFrmDoctSearch As System.Windows.Forms.Button
    Friend WithEvents btnMedFrmDoctAssDrug As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMedFrmDoctAge As System.Windows.Forms.TextBox
    Friend WithEvents txtMedFrmDoctSex As System.Windows.Forms.TextBox
    Friend WithEvents txtMedFrmDoctId As System.Windows.Forms.TextBox
    Friend WithEvents txtMedFrmDoctSurName As System.Windows.Forms.TextBox
    Friend WithEvents txtMedFrmDoctFname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbsurname As System.Windows.Forms.Label
    Friend WithEvents lbfirstname As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
