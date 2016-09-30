Imports System.Data.SqlClient
Public Class LabTech
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Dim queryResult As Integer = 0
    Dim currentpass As String
    Dim newpassowrd1 As String
    Dim newpassowrd2 As String

    Private Sub LabTech_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'retrieve()
        lbfirstname.Text = firstname
        lbsurname.Text = username
    End Sub
    'Private Sub retrieve()
    '    connection()
    '    query = "SELECT * FROM testItems"
    '    com = New SqlCommand(query, con)
    '    com.ExecuteNonQuery()
    '    da = New SqlDataAdapter(query, con)
    '    dts = New DataSet("users")
    '    da.Fill(dts, "users")
    '    dtgvLabtech.DataSource = dts.Tables(0)
    'End Sub
    Sub connection()
        Dim str As String = "Data Source=.\sqlexpress;Initial Catalog=master;Integrated Security=True"
        Try
            con = New SqlConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
    Function checkdpassword()
        Try
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE SURNAME= '" & username & "' AND PASSWORD= '" & currentpass & "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function
End Class