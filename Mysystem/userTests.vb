Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class userTests
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim price As Integer = 0
    Dim strprice As String
    Dim queryResult As String
    Dim testId As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        TotalAmount = price
        price = 0
        TextBox2.Clear()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub userTests_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrieve()
        TextBox2.Enabled = False
    End Sub
     Private Sub retrieve()
        connection()
        query = "SELECT * FROM tests"
        com = New SqlCommand(query, con)
        da = New SqlDataAdapter(query, con)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Sub connection()
        Dim str As String = "Data Source=.\sqlexpress;Initial Catalog=master;Integrated Security=True"
        con = New SqlConnection(My.Settings.con)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "select checkbox"

#End Region

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection()
        If (checkduplicate() > 0) Then
            MsgBox("The record exist")
        Else
            Try
                For i As Integer = Me.DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                    query = "INSERT INTO Assignedtests(id,Pid,dateoftest) VALUES('" & Me.DataGridView1.SelectedRows(i).Cells(0).Value.ToString & "','" & Ptid & "','" & DateTestList.Text & "');"
                    da = New SqlDataAdapter(query, con)
                    dts = New DataSet()
                    da.Fill(dts)
                Next
                MsgBox("successifully..")
                retrieve()
                TotalAmount = price
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        
    End Sub
    Function checkduplicate()
        Try
            Dim myquery As String = "SELECT COUNT(*) As me FROM Assignedtests WHERE Pid= " & _
            "'" & Ptid & "' AND dateoftest= '" & DateTestList.Text + "' AND id='" & testId & "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        testId = DataGridView1.Item(0, e.RowIndex).Value
        Try
            connection()
            Dim cmd As String = "SELECT price FROM tests WHERE id='" & DataGridView1.Item(0, e.RowIndex).Value & "'"
            com = New SqlCommand(cmd, con)
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    strprice = (reader("price"))
                End While
            End Using
            con.Close()
            price += Convert.ToInt32(strprice)
            TextBox2.Text = price
        Catch ex As Exception
        End Try
    End Sub
End Class
