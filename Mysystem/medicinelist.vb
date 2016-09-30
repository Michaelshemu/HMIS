Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Public Class medicinelist
    Private da As SqlDataAdapter
    Private dts As DataSet
    Private dt As DataTable
    Private query As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub medicinelist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrieve()
    End Sub
    Private Sub retrieve()
        connection()
        query = "SELECT Mid,Mname,category,price FROM medicines"
        com = New SqlCommand(query, con)
        da = New SqlDataAdapter(query, con)
        dt = New DataTable()
        da.Fill(dt)
        dtgvmedicallist.DataSource = dt
    End Sub
    Sub connection()
          con = New SqlConnection(My.Settings.con)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection()
            Dim price As Integer = 0
            Dim Amount As Integer = ComboBox1.Text
            Dim cost As Integer
            Dim item As Integer
            Dim updatedItem As Integer = 0
            Dim strquery As String = "SELECT * FROM medicines where Mid='" & Me.dtgvmedicallist.SelectedRows(0).Cells(0).Value.ToString & "'"
            com = New SqlCommand(strquery, con)
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    price = reader("price")
                    item = reader("item")
                End While
            End Using
            cost = price * Amount
            For i As Integer = Me.dtgvmedicallist.SelectedRows.Count - 1 To 0 Step -1
                query = "INSERT INTO AsignedMedical(TrId,Mid,AssignedDate,Amount,cost) VALUES('" & trId & "','" & Me.dtgvmedicallist.SelectedRows(i).Cells(0).Value.ToString & "','" & DateMedicalList.Text & "','" & ComboBox1.Text & "'," & cost & ");"
                da = New SqlDataAdapter(query, con)
                dts = New DataSet()
                da.Fill(dts)
                updatedItem = item - ComboBox1.Text
                Dim update = "UPDATE Medicines set item=" & updatedItem & " where Mid='" & Me.dtgvmedicallist.SelectedRows(i).Cells(0).Value.ToString & "'"
                com = New SqlCommand(update, con)
                com.ExecuteNonQuery()
                retrieve()
            Next
            retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMedicalListSearch_Click(sender As Object, e As EventArgs) Handles btnMedicalListSearch.Click, txtMedicalListSearch.TextChanged
        connection()
        Try
            query = "SELECT * FROM medicines WHERE Mid  like '%" + txtMedicalListSearch.Text + "%' or Mname like '%" + txtMedicalListSearch.Text + "%'"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("medicines")
            da.Fill(dts, "medicine")
            dtgvmedicallist.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
