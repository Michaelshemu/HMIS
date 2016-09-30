Imports System.Data.SqlClient
Public Class Registration
    Dim con As SqlConnection
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
                connection()

                If (checkduplicate() > 0) Then
                    MsgBox("The record exist")
                    emptyfield()
                Else
                    query = "INSERT INTO users(FNAME,MNAME,SURNAME,CONTACTS,STATUS,PASSWORD)" & _
                    "VALUES('" + txtRegistrationFname.Text + "','" + txtRegistrationMname.Text + "', " & _
                    "'" + txtRegistrationSurname.Text + "','" + txtRegistrationContacts.Text + "'," & _
                    "'" + cbRegistrationStutasName.Text + "','" + txtRegistrationPassword.Text + "'); "
                    Try
                        connection()
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
                connection()
                query = "UPDATE users SET FNAME='" + txtRegistrationFname.Text + "',MNAME='" & _
                          "" + txtRegistrationMname.Text + "',SURNAME='" + txtRegistrationSurname.Text + "'" & _
                          ",CONTACTS='" + txtRegistrationContacts.Text + "',STATUS='" + cbRegistrationStutasName.Text + "" & _
                         "',PASSWORD='" + txtRegistrationPassword.Text + "' WHERE Empid=" + txtRegistrationId.Text
                With com
                    com = New SqlCommand(query, con)
                    x = .ExecuteNonQuery
                End With
                If (x > 0) Then
                    MsgBox("Update " & x & " row is successifully")
                    bntRegistrationSave.Text = "SAVE"
                    retrieve()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Function checkduplicate()
        Try
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE Empid= " & _
            "'" + txtRegistrationId.Text + "' or FNAME= '" + txtRegistrationFname.Text + "'" & _
           " and SURNAME='" + txtRegistrationUsername.Text + "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Sub connection()
        Dim str As String = "Data Source=.\sqlexpress;Initial Catalog=master;Integrated Security=True"
        Try
            con = New SqlConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRegistrationId.Enabled = False
        retrieve()
        lbfirstname.Text = firstname
        lbsurname.Text = username
    End Sub
    Private Sub retrieve()
        connection()
        query = "SELECT * FROM users"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        dtgvRegistration.DataSource = dts.Tables(0)
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
        connection()
        query = "SELECT * FROM users WHERE Empid  like '%" + txtRegistrationSearch.Text + "%' or FNAME like '%" + txtRegistrationSearch.Text + "%'"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        dtgvRegistration.DataSource = dts.Tables(0)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnRegistrationDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrationDelete.Click
        Dim i As Integer = 0
        Try
            connection()
            query = "DELETE FROM users WHERE Empid =" + txtRegistrationId.Text
            com = New SqlCommand(query, con)
            i = com.ExecuteNonQuery()
            If (i > 0) Then
                MsgBox("Delete " & txtRegistrationFname.Text & " " & txtRegistrationSurname.Text & " was successifully")
                retrieve()
                emptyfield()
            End If
        Catch ex As Exception

        End Try
 
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("You are logout now")
        Me.Close()
    End Sub
    Function checkdpassword()
        Try
            connection()
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE SURNAME= '" & username & "' AND PASSWORD= '" & currentpass & "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
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
                    connection()
                    query = "UPDATE users SET PASSWORD='" + newpassowrd1 + "' WHERE SURNAME= '" & username & "' AND PASSWORD= '" & currentpass & "'"
                    com = New SqlCommand(query, con)
                    x = com.ExecuteNonQuery
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
