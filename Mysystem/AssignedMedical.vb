Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AssignedMedical
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AssignedMedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieve()
    End Sub
    Private Sub retrieve()
        Try
            connection()
            query = "SELECT m.Mname,m.category,a.Amount,a.cost FROM medicines m, AsignedMedical a , treatment t WHERE m.Mid=a.Mid AND a.TrId=t.TrId AND a.TrId='" & trId & "'"
            com = New SqlCommand(query, con)
            da = New SqlDataAdapter(query, con)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Sub connection()
          con = New SqlConnection(My.Settings.con)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
