Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FromReception
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Dim queryResult As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
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

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnFrmRecEditFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmRecEditFile.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        TextBox5.AcceptsReturn = True
    End Sub
    Private Sub retrivePatients()
        Try
            connection()
            query = "SELECT  p.Pid,firstname,middlename,lastname,age,gender,problem,status FROM newpatient p , treatment t " & _
            "WHERE p.Pid = t.Pid "
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("treatment")
            da.Fill(dts, "treatment")
            dtgvpatients.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FromReception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrivePatients()
    End Sub

    Private Sub dtgvpatients_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgvpatients.CellMouseClick
        Try
            txtFrmRecID.Text = dtgvpatients.Item(0, e.RowIndex).Value
            txtFrmRecFname.Text = dtgvpatients.Item(1, e.RowIndex).Value
            txtFrmRecMname.Text = dtgvpatients.Item(2, e.RowIndex).Value
            txtFrmRecLname.Text = dtgvpatients.Item(3, e.RowIndex).Value
            TextBox2.Text = dtgvpatients.Item(4, e.RowIndex).Value
            TextBox3.Text = dtgvpatients.Item(5, e.RowIndex).Value
            TextBox4.Text = dtgvpatients.Item(6, e.RowIndex).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click, TextBox1.TextChanged
        connection()
        query = "SELECT p.Pid,firstname,middlename,lastname,age,gender,problem FROM " & _
        "newpatient p,treatment t WHERE p.Pid = t.Pid and (p.Pid like '%" & TextBox1.Text & "%' or p.firstname like '%" & TextBox1.Text & "%') "
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("treatment")
        da.Fill(dts, "treatment")
        dtgvpatients.DataSource = dts.Tables(0)
    End Sub

    Private Sub btnFrmRecMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmRecMedical.Click
        connection()
        Try
            query = "UPDATE treatment SET problem='" + TextBox4.Text + "',status='treated'" & _
                          ",Recomendation='" + TextBox5.Text + "' WHERE Pid='" & txtFrmRecID.Text & "'"
            com = New SqlCommand(query, con)
            With com
                .ExecuteNonQuery()
            End With
            MsgBox("send patient no: " & txtFrmRecID.Text & " is successifully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
