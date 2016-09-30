Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class FromLb
    Dim query As String
    Dim con As SqlConnection

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FromLb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrieveFromLab()
        With DataGridView1
            .Columns(0).HeaderText = "PATNO"
            .Columns(1).HeaderText = "FIRST NAME"
            .Columns(2).HeaderText = "MIDDLE NAME"
            .Columns(3).HeaderText = "LAST NAME"
            .Columns(4).HeaderText = "SEX"
            .Columns(5).HeaderText = "PLACE OF BIRTH"
            .Columns(6).HeaderText = "AGE"
            .Columns(7).HeaderText = "CONTACTS"
            .Columns(7).Width = 160
            .Columns(4).Width = 50
            .Columns(5).Width = 119
            .Columns(2).Width = 130
        End With
      
    End Sub
    Private Sub retrieveFromLab()
        connection()
        query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM newpatient WHERE status='TREATED'"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("newpatient")
        da.Fill(dts, "newpatient")
        DataGridView1.DataSource = dts.Tables(0)
    End Sub
    Sub connection()
      con = New SqlConnection(My.Settings.con)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            TextBox3.Text = DataGridView1.Item(0, e.RowIndex).Value
            TextBox4.Text = DataGridView1.Item(1, e.RowIndex).Value
            TextBox5.Text = DataGridView1.Item(6, e.RowIndex).Value
            TextBox6.Text = DataGridView1.Item(3, e.RowIndex).Value
            TextBox7.Text = DataGridView1.Item(4, e.RowIndex).Value
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
        Catch ex As Exception

        End Try
        retrieveResults()
        With DataGridView2
            Try
                .Columns(0).HeaderText = "NAME OF TEST TAKEN"
                .Columns(1).HeaderText = "RESULT"
                .Columns(2).HeaderText = "RECOMMENDATIONS"
                .Columns(0).Width = 180
                .Columns(1).Width = 119
                .Columns(2).Width = 150
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End With
    End Sub
    Private Sub retrieveResults()
        Try
            connection()
            query = "SELECT t.TestName,Results,Recommendation FROM Assignedtests a,tests t WHERE a.id=t.id AND a.dateoftest='" & DateTimePicker1.Text & "'AND a.Pid='" & TextBox3.Text & "' "
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("newpatient")
            da.Fill(dts, "newpatient")
            DataGridView2.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, TextBox2.TextChanged

        Try
            connection()
            query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM newpatient WHERE " & _
           " status='TREATED' AND (Pid  like '%" + TextBox2.Text + "%' or firstname like '%" + TextBox2.Text + "%')"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("users")
            da.Fill(dts, "users")
            DataGridView1.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub
End Class
