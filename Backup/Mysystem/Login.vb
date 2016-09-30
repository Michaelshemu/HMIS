Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class Login
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Public QueryResult As Integer = 0
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim status As Object
        If (UsernameTextBox.Text = "" Or _
         PasswordTextBox.Text = "") Then
            MsgBox("You must fill all fields", MsgBoxStyle.Information)
        ElseIf (checkusers() > 0) Then
            connection()
            query = "SELECT STATUS FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
            com = New SqlCommand(query, con)
            status = com.ExecuteScalar
            If status = "ADMINISTRATOR" Then
                query = "SELECT FNAME FROM users WHERE SURNAME= " & _
          "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Registration.Show()
            ElseIf status = "DOCTOR" Then
                query = "SELECT FNAME FROM users WHERE SURNAME= " & _
          "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Doctor.Show()
            ElseIf status = "MEDICAL" Then
                query = "SELECT FNAME FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Medical.Show()
            ElseIf status = "RECEPTIONIST" Then
                query = "SELECT FNAME FROM users WHERE SURNAME= " & _
          "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Reception.Show()
            ElseIf status = "LABORATORY" Then
                query = "SELECT FNAME FROM users WHERE SURNAME= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT SURNAME FROM users WHERE SURNAME= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                LabTech.Show()
            End If
        Else
            MsgBox("Wrong username or password")
        End If
    End Sub
    Function checkusers()
        Try
            connection()
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE SURNAME= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
            com = New SqlCommand(myquery, con)
            QueryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return QueryResult
    End Function
    Sub connection()
        Dim str As String = "Data Source=.\sqlexpress;Initial Catalog=master;Integrated Security=True"
        Try
            con = New SqlConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
