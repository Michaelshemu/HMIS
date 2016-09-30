Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class Login
    Dim con As New SqlConnection(My.Settings.Con)
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Public QueryResult As Integer = 0
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim status As Object
        If (UsernameTextBox.Text = "" Or _
         PasswordTextBox.Text = "") Then
            MsgBox("You must fill all fields", MsgBoxStyle.Information)
        ElseIf (checkusers() > 0) Then
            con.Close()
            con.Open()
            query = "SELECT STATUS FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND password= '" + PasswordTextBox.Text + "'"
            com = New SqlCommand(query, con)
            status = com.ExecuteScalar
            If status = "ADMINISTRATOR" Then
                query = "SELECT firstname FROM users WHERE lastname= " & _
          "'" + UsernameTextBox.Text + "' AND password= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND password= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Registration.Show()
            ElseIf status = "DOCTOR" Then
                query = "SELECT firstname FROM users WHERE lastname= " & _
          "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Doctor.Show()
            ElseIf status = "MEDICAL" Then
                query = "SELECT firstname FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Medical.Show()
            ElseIf status = "RECEPTIONIST" Then
                query = "SELECT firstname FROM users WHERE lastname= " & _
          "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                Reception.Show()
            ElseIf status = "LAB-TECH" Then
                query = "SELECT firstname FROM users WHERE lastname= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                firstname = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                username = com.ExecuteScalar
                query = "SELECT lastname FROM users WHERE lastname= " & _
        "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
                com = New SqlCommand(query, con)
                password = com.ExecuteScalar
                LabTech.Show()
            End If
        Else
            MsgBox("Wrong username or password")
            con.Close()
            Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
         
        End If
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        con.Close()
    End Sub
    Function checkusers()
        Try
            con.Open()
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE lastname= " & _
            "'" + UsernameTextBox.Text + "' AND PASSWORD= '" + PasswordTextBox.Text + "'"
            com = New SqlCommand(myquery, con)
            QueryResult = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        Return QueryResult
    End Function

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
        Home.Close()
    End Sub
End Class
