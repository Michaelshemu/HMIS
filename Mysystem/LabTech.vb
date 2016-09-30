Imports System.Data.SqlClient
Public Class LabTech
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Dim dt As DataTable
    Dim queryResult As Integer = 0
    Dim currentpass As String
    Dim newpassowrd1 As String
    Dim newpassowrd2 As String
    Dim tId As Integer

    Private Sub LabTech_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox6.Enabled = False
        TextBox5.Enabled = False
        retrieve()
        retrieveTests()
        TextBox11.Enabled = False
        lbfirstname.Text = firstname
        lbsurname.Text = username
        'DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        With DataGridView1
            .Columns(0).Width = 100
            .Columns(1).Width = 170
            .Columns(2).Width = 140
            .Columns(3).Width = 330
            .Columns(4).Width = 200
            .Columns(5).Width = 130
            .Columns(6).Width = 130
            .Columns(7).Width = 130
        End With

    End Sub
    Sub connection()
         con = New SqlConnection(My.Settings.con)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub retrieveTests()
        Try
            connection()
            query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM newpatient" & _
            " WHERE status='UNTREATED' AND submittedTo='LAB-TECH' "
            com = New SqlCommand(query, con)
            da = New SqlDataAdapter(query, con)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub newretrieveData()
        Try
            connection()
            Dim cmd As String = "SELECT * FROM AssignedTests a, tests t , newpatient p WHERE a.id = t.id AND p.Pid=a.Pid AND a.Pid='" & TextBox1.Text & "' AND dateoftest='" & DateTimePicker1.Text & "'"
            com = New SqlCommand(cmd, con)
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    Me.ListBox1.Items.Add(reader("TestName"))
                    Me.TextBox5.Text = reader("Dateoftest")
                End While
            End Using
            con.Close()
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
                    query = "UPDATE users SET password='" + newpassowrd1 + "' WHERE lastname= '" & username & "' AND password= '" & currentpass & "'"
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
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE lastname= '" & username & "' AND password= '" & currentpass & "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "SAVE" Then
            connection()
            If (TextBox10.Text = "" Or TextBox9.Text = "") Then
                MsgBox("You must fill all fields", MsgBoxStyle.Information)
            Else
                If (checkduplicate() > 0) Then
                    MsgBox("The record exist")
                    emptyfield()
                Else
                    query = "INSERT INTO tests(TestName,price)" & _
                    "VALUES('" & TextBox9.Text & "','" & TextBox10.Text & "' ); "
                    Try
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Records successfully saved")
                        retrieve()
                        emptyfield()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Else
            Dim x As Integer = 0
            Try
                connection()
                query = "UPDATE tests SET TestName='" + TextBox9.Text + "',price='" & _
                          "" + TextBox10.Text + "'WHERE id=" + TextBox11.Text
                With com
                    com = New SqlCommand(query, con)
                    x = .ExecuteNonQuery
                End With
                If (x > 0) Then
                    MsgBox("Update " & x & " row is successifully")
                    Button2.Text = "SAVE"
                    retrieve()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub emptyfield()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox9.Text = ""
        TextBox1.Clear()
        TextBox2.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox8.Clear()
        TextBox6.Clear() : TextBox7.Clear()

    End Sub
    Private Sub retrieve()
        connection()
        query = "SELECT * FROM tests"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        DataGridView2.DataSource = dts.Tables(0)
    End Sub
    Function checkduplicate()
        Try
            Dim myquery As String = "SELECT COUNT(*) As me FROM tests WHERE id= " & _
            "'" + TextBox11.Text + "' or TestName= '" + TextBox9.Text + "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            ListBox1.Items.Clear()
            TextBox1.Text = DataGridView1.Item(0, e.RowIndex).Value
            TextBox2.Text = DataGridView1.Item(1, e.RowIndex).Value
            TextBox3.Text = DataGridView1.Item(6, e.RowIndex).Value
            TextBox4.Text = DataGridView1.Item(3, e.RowIndex).Value
            TextBox6.Text = DataGridView1.Item(4, e.RowIndex).Value
            newretrieveData()
        Catch ex As Exception

        End Try
     
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        retrieve()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, TextBox12.TextChanged
        Try
            connection()
            query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM newpatient" & _
            " WHERE status='UNTREATED' AND submittedTo='LAB-TECH' AND (Pid like '%" & TextBox12.Text & "%' OR firstname LIKE '%" & TextBox12.Text & "%')"
            com = New SqlCommand(query, con)
            da = New SqlDataAdapter(query, con)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub clearfield()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please select the patient field..", MsgBoxStyle.Information)
        Else
            Try
                connection()
                Dim query2 = "UPDATE newpatient SET status='TREATED' WHERE Pid='" & TextBox1.Text & "'"
                com = New SqlCommand(query2, con)
                With com
                    .ExecuteNonQuery()
                End With
                MsgBox("successifully")
                retrieveTests()
                clearfield()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

      
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox7.Text = "" Then
            MsgBox("please fill the result first", MsgBoxStyle.Information)
        ElseIf ListBox1.Text = "" Then
            MsgBox("please select the disease from the list", MsgBoxStyle.Information)
        Else
            connection()
            Try
                Dim cmd As String = "SELECT * FROM tests WHERE TestName='" & ListBox1.SelectedItem.ToString & "'"
                com = New SqlCommand(cmd, con)
                Using reader As SqlDataReader = com.ExecuteReader
                    While (reader.Read())
                        Me.tId = reader("id")
                    End While
                End Using
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                connection()
                query = "SELECT id FROM tests WHERE "
                Dim query1 As String = "UPDATE Assignedtests SET Results='" + TextBox7.Text + "',Recommendation='" & TextBox8.Text & "'" & _
               " WHERE Pid='" & TextBox1.Text & "' AND id='" & tId & "' "
                com = New SqlCommand(query1, con)
                With com
                    .ExecuteNonQuery()
                End With
                Label14.Text = "saved....!"
                TextBox7.Clear()
                TextBox8.Clear()
                retrieveTests()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Logout...!")
        Me.Close()
        Home.Show()

    End Sub

    Private Sub LabTech_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class