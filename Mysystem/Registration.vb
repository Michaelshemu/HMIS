Imports System.Data.SqlClient
Public Class Registration
    Dim con As New SqlConnection(My.Settings.con)
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Dim queryResult As Integer = 0
    Dim currentpass As String
    Dim newpassowrd1 As String
    Dim newpassowrd2 As String
    Private Sub bntRegistrationSLave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntRegistrationSave.Click
        If bntRegistrationSave.Text = "SAVE" Then
            If (txtRegistrationFname.Text = "" Or _
           txtRegistrationMname.Text = "" Or _
            txtRegistrationSurname.Text = "" Or _
             txtRegistrationUsername.Text = "" Or _
              txtRegistrationContacts.Text = "" Or _
               txtRegistrationPassword.Text = "" Or _
               cbRegistrationStutasName.Text = "") Then
                MsgBox("You must fill all fields", MsgBoxStyle.Information)
            Else
                txtRegistrationFname.Text = txtRegistrationFname.Text.Trim
                txtRegistrationMname.Text = txtRegistrationMname.Text.Trim
                txtRegistrationUsername.Text = txtRegistrationSurname.Text.Trim
                txtRegistrationPassword.Text = txtRegistrationPassword.Text.Trim
                cbRegistrationStutasName.Text = cbRegistrationStutasName.Text.Trim
                If (checkduplicate() > 0) Then
                    MsgBox("The record exist")
                    emptyfield()
                Else
                    con.Open()
                    query = "INSERT INTO users(firstname,middlename,lastname,contacts,status,password)" & _
                    "VALUES('" + txtRegistrationFname.Text + "','" + txtRegistrationMname.Text + "', " & _
                    "'" + txtRegistrationSurname.Text + "','" + txtRegistrationContacts.Text + "'," & _
                    "'" + cbRegistrationStutasName.Text + "','" + txtRegistrationPassword.Text + "'); "
                    Try
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Data saved")
                        retrieve()
                    Catch ex As Exception
                    End Try
                End If
            End If

        Else

            'update start hear
            Dim x As Integer = 0
            Try
                con.open()
                query = "UPDATE users SET firstname='" + txtRegistrationFname.Text + "',middlename='" & _
                          "" + txtRegistrationMname.Text + "',lastname='" + txtRegistrationSurname.Text + "'" & _
                          ",contacts='" + txtRegistrationContacts.Text + "',status='" + cbRegistrationStutasName.Text + "" & _
                         "',password='" + txtRegistrationPassword.Text + "' WHERE Empid=" + txtRegistrationId.Text
                With com
                    com = New SqlCommand(query, con)
                    x = .ExecuteNonQuery
                    con.Close()
                End With
                If (x > 0) Then
                    MsgBox("Update " & x & " row is successifully")
                    bntRegistrationSave.Text = "SAVE"
                    retrieve()
                    emptyfield()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Function checkduplicate()
        Try
            con.Open()
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE Empid= " & _
            "'" + txtRegistrationId.Text + "' or firstname= '" + txtRegistrationFname.Text + "'" & _
           " and lastname='" + txtRegistrationUsername.Text + "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        Return queryResult
    End Function
    Sub emptyfield()
        txtRegistrationId.Clear()
        txtRegistrationFname.Clear()
        txtRegistrationMname.Clear()
        txtRegistrationSurname.Clear()
        txtRegistrationUsername.Clear()
        txtRegistrationContacts.Clear()
        cbRegistrationStutasName.Text = ""
        txtRegistrationPassword.Clear()
    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRegistrationId.Enabled = False
        retrieve()
        lbfirstname.Text = firstname
        lbsurname.Text = username
        With dtgvRegistration
            .Columns(0).HeaderText = "EMPNO"
            .Columns(1).HeaderText = "FIRST NAME"
            .Columns(2).HeaderText = "MIDDLE NAME"
            .Columns(3).HeaderText = "LAST NAME"
            .Columns(4).HeaderText = "CONTACTS"
            .Columns(5).HeaderText = "STATUS"
            .Columns(6).HeaderText = "PASSWORD"
            .Columns(4).Width = 190
            .Columns(5).Width = 120
            .Columns(2).Width = 130
            .Columns(1).Width = 130
            .Columns(6).Width = 130
        End With
    End Sub
    Private Sub retrieve()
        con.Open()
        query = "SELECT * FROM users"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        dtgvRegistration.DataSource = dts.Tables(0)
        con.Close()
    End Sub
    Private Sub dtgvRegistration_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgvRegistration.CellMouseClick
        Try
            txtRegistrationId.Text = dtgvRegistration.Item(0, e.RowIndex).Value
            txtRegistrationFname.Text = dtgvRegistration.Item(1, e.RowIndex).Value
            txtRegistrationMname.Text = dtgvRegistration.Item(2, e.RowIndex).Value
            txtRegistrationSurname.Text = dtgvRegistration.Item(3, e.RowIndex).Value
            txtRegistrationUsername.Text = dtgvRegistration.Item(3, e.RowIndex).Value
            txtRegistrationContacts.Text = dtgvRegistration.Item(4, e.RowIndex).Value
            cbRegistrationStutasName.Text = dtgvRegistration.Item(5, e.RowIndex).Value
            txtRegistrationPassword.Text = dtgvRegistration.Item(6, e.RowIndex).Value
            btnRegistrationDelete.Visible = True
            bntRegistrationSave.Text = "UPDATE"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRegistrationSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrationSearch.Click, GroupBox1.SizeChanged, dtgvRegistration.SizeChanged, txtRegistrationSearch.TextChanged
        con.open()
        query = "SELECT * FROM users WHERE Empid  like '%" + txtRegistrationSearch.Text + "%' or firstname like '%" + txtRegistrationSearch.Text + "%'"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        dtgvRegistration.DataSource = dts.Tables(0)
        con.Close()
    End Sub

    Private Sub btnRegistrationDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrationDelete.Click
        Dim i As Integer = 0
        Try
            con.open()
            query = "DELETE FROM users WHERE Empid =" + txtRegistrationId.Text
            com = New SqlCommand(query, con)
            i = com.ExecuteNonQuery()
            con.Close()
            If (i > 0) Then
                MsgBox("Delete " & txtRegistrationFname.Text & " " & txtRegistrationSurname.Text & " was successifully")
                retrieve()
                emptyfield()
                bntRegistrationSave.Text = "SAVE"
                con.Close 
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("You are logout now")
        Me.Close()
    End Sub
    Function checkdpassword()
        Try
            con.open()
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE lastname= '" & username & "' AND password= '" & currentpass & "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        Return queryResult
    End Function

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        currentpass = InputBox("Enter the current password")
        If (checkdpassword() > 0) Then
            newpassowrd1 = InputBox("Enter the New password")
            newpassowrd2 = InputBox("Cofirm the New password")
            If (newpassowrd1 = newpassowrd2) Then
                Dim x As Integer = 0
                Try
                    con.open()
                    query = "UPDATE users SET password='" + newpassowrd1 + "' WHERE lastname= '" & username & "' AND password= '" & currentpass & "'"
                    com = New SqlCommand(query, con)
                    x = com.ExecuteNonQuery
                    con.Close()
                    If (x > 0) Then
                        MsgBox("password changed successifully")
                        retrieve()
                    Else
                        MsgBox(x)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Password does not match")
            End If
        Else
            MsgBox("Incorrect password")
        End If
    End Sub

End Class
