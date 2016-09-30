Imports System.Data.SqlClient
Public Class Medical
    Dim queryResult As Integer = 0
    Dim currentpass As String
    Dim newpassowrd1 As String
    Dim newpassowrd2 As String

    Private Sub Medical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrieve()
        retrieveFrmDoctor()
        lbfirstname.Text = firstname
        lbsurname.Text = username
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMedFrmDoctFname.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmedicalSave.Click
        If btnmedicalSave.Text = "SAVE" Then
            If (txtmedicalName.Text = "" Or _
            cbmedicalcategory.Text = "" Or _
             txtmedicalName.Text = "" Or _
              txtmedicalPrice.Text = "" Or _
               DatemedicalExpiredDate.Text = "") Then
                MsgBox("You must fill all fields", MsgBoxStyle.Information)
            Else
                If (checkduplicate() > 0) Then
                    MsgBox("The record exist")
                    emptyfield()
                Else
                    query = "INSERT INTO medicines(Mname,amount,price,expireddate,category)" & _
                    "VALUES('" & txtmedicalName.Text & "','" & txtmedicalQuantity.Text & "','" & txtmedicalPrice.Text & "', " & _
                    "'" & DatemedicalExpiredDate.Text & "','" & cbmedicalcategory.Text & "'); "
                    Try
                        connection()
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Medicine successfully saved")
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
                query = "UPDATE medicines SET Mname='" + txtmedicalName.Text + "',amount='" & _
                          "" + txtmedicalQuantity.Text + "',category='" + cbmedicalcategory.Text + "'" & _
                          ",price='" + txtmedicalPrice.Text + "',expireddate='" + DatemedicalExpiredDate.Text + "" & _
                         "' WHERE Mid=" + txtmedicalId.Text
                With com
                    com = New SqlCommand(query, con)
                    x = .ExecuteNonQuery
                End With
                If (x > 0) Then
                    MsgBox("Update " & x & " row is successifully")
                    btnmedicalSave.Text = "SAVE"
                    retrieve()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Function checkduplicate()
        Try
            Dim myquery As String = "SELECT COUNT(*) As me FROM medicines WHERE Mid= " & _
            "'" + txtmedicalId.Text + "' or Mname= '" + txtmedicalName.Text + "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function

    Private Sub retrieve()
        connection()
        query = "SELECT * FROM medicines"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        Dtgvmedical.DataSource = dts.Tables(0)
    End Sub
    Private Sub retrieveFrmDoctor()
        Try
            query = "SELECT p.Pid,firstname,middlename,lastname,age,gender,problem,Recomendation,Dateoftreatment FROM newpatient p , treatment t " & _
          "WHERE p.Pid = t.Pid AND status='treated'"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("treatment")
            da.Fill(dts, "treatment")
            DgvMedFrmDoct.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnmedicalSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmedicalSearch.Click, txtmedicalSearch.TextChanged
        connection()
        Try
            query = "SELECT * FROM medicines WHERE Mid  like '%" + txtmedicalSearch.Text + "%' or Mname like '%" + txtmedicalSearch.Text + "%'"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("medicines")
            da.Fill(dts, "medicine")
            Dtgvmedical.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    Sub connection()
        Dim str As String = "Data Source=.\sqlexpress;Initial Catalog=master;Integrated Security=True"
        Try
            con = New SqlConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dtgvmedical_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dtgvmedical.CellMouseClick
        Try
            txtmedicalId.Text = Dtgvmedical.Item(0, e.RowIndex).Value
            txtmedicalName.Text = Dtgvmedical.Item(1, e.RowIndex).Value
            txtmedicalQuantity.Text = Dtgvmedical.Item(2, e.RowIndex).Value
            txtmedicalPrice.Text = Dtgvmedical.Item(3, e.RowIndex).Value
            DatemedicalExpiredDate.Text = Dtgvmedical.Item(4, e.RowIndex).Value
            btnmedicaldelete.Visible = True
            cbmedicalcategory.Text = Dtgvmedical.Item(5, e.RowIndex).Value
            btnmedicalSave.Text = "UPDATE"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub emptyfield()
        txtmedicalId.Clear()
        txtmedicalName.Clear()
        DatemedicalExpiredDate.Text = ""
        txtmedicalQuantity.Clear()
        cbmedicalcategory.Text = ""
        txtmedicalQuantity.Clear()
        txtmedicalPrice.Clear()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("You about to logout")
        Me.Close()
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

    Private Sub Dtgvmedical_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtgvmedical.CellContentClick

    End Sub

    Private Sub btnmedicaldelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmedicaldelete.Click
        Dim i As Integer = 0
        Try
            connection()
            query = "DELETE FROM medicines WHERE Mid =" + txtmedicalId.Text
            com = New SqlCommand(query, con)
            i = com.ExecuteNonQuery()
            If (i > 0) Then
                MsgBox("Delete " & txtmedicalName.Text & " was successifully")
                retrieve()
                btnmedicalSave.Text = "SAVE"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMedFrmDoctSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedFrmDoctSearch.Click, txtMedFrmDoctSearch.TextChanged
        Try

            connection()
            query = "SELECT p.Pid,firstname,middlename,lastname,age,gender,problem , Recomendation,Dateoftreatment FROM " & _
            "newpatient p,treatment t WHERE p.Pid = t.Pid and status='treated' and (p.Pid like '%" & txtMedFrmDoctSearch.Text & "%' or p.firstname like '%" & txtMedFrmDoctSearch.Text & "%') "
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("treatment")
            da.Fill(dts, "treatment")
            DgvMedFrmDoct.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DgvMedFrmDoct_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgvMedFrmDoct.CellMouseClick
        Try
            txtMedFrmDoctId.Text = DgvMedFrmDoct.Item(0, e.RowIndex).Value
            txtMedFrmDoctFname.Text = DgvMedFrmDoct.Item(1, e.RowIndex).Value
            txtMedFrmDoctSurName.Text = DgvMedFrmDoct.Item(3, e.RowIndex).Value
            txtMedFrmDoctSex.Text = DgvMedFrmDoct.Item(5, e.RowIndex).Value
            txtMedFrmDoctAge.Text = DgvMedFrmDoct.Item(4, e.RowIndex).Value
            TextBox1.Text = DgvMedFrmDoct.Item(8, e.RowIndex).Value
            TextBox2.Text = DgvMedFrmDoct.Item(6, e.RowIndex).Value
            Dim c As String = DgvMedFrmDoct.SelectedRows(0).Cells(7).Value
            ListBox1.Items.Clear()
            ListBox1.Items.Add(c)
            btnMedFrmDoctAssDrug.Visible = True
        Catch ex As Exception
            MsgBox("Sorry press the row to view the descriptions")
        End Try

    End Sub

    Private Sub btnMedFrmDoctAssDrug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedFrmDoctAssDrug.Click
        PatId = txtMedFrmDoctId.Text
        Dim str As String = ""
        str = str & ListBox1.SelectedItem
        If (str = "") Then
            MsgBox("Please select the desciptions from doctor")
        Else
            query = "INSERT INTO outpatient(patId,date,disease,treatment)" & _
                               "VALUES('" + txtMedFrmDoctId.Text + "','" + TextBox1.Text + "', " & _
                               "'" + TextBox2.Text + "','" + str + "'); "
            Try
                connection()
                com = New SqlCommand(query, con)
                com.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        medicinelist.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            connection()
            query = "DELETE FROM treatment WHERE  status='treated'"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

