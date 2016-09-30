Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Public Class medicinelist

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Try
        '    For i As Integer = 0 To dtgvmedicallist.Rows.Count - 1
        '        Dim ck As Boolean =((CheckBox)row.Findcontrol("selection")).checked
        '    Next
        '    For Each row As DataGridViewRow In dtgvmedicallist.Rows
        '        Using com As New SqlCommand("INSERT INTO AssignedMedical(patId,Mid)" & _
        '            " VALUES(" & PatId & ",@Mid)", con)
        '            com.Parameters.AddWithValue("@Mid", row.Cells(0).Value)
        '            connection()
        '            com.ExecuteNonQuery()
        '        End Using
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub medicinelist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrieve()
    End Sub
    Private Sub retrieve()
        Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        checkBoxColumn.HeaderText = ""
        checkBoxColumn.Width = "30"
        connection()
        query = "SELECT Mid,Mname,category,price FROM medicines"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        dtgvmedicallist.DataSource = dts.Tables(0)
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
End Class
