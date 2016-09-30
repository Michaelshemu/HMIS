Imports System.Data.SqlClient
Public Class Medical
    Dim queryResult As Integer = 0
    Dim currentpass As String
    Dim newpassowrd1 As String
    Dim newpassowrd2 As String
    Dim quantity As Integer
    Dim initialQuantity As Integer = 0
    Dim newQuantity As Integer = 0
    Dim item As Integer
    Dim NewItem As Integer = 0
    Private Sub Medical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrieve()
        retrieveFrmDoctor()
        lbfirstname.Text = firstname
        lbsurname.Text = username
        Button5.Visible = False

        With DgvMedFrmDoct
            .Columns(0).HeaderText = "PATNO"
            .Columns(1).HeaderText = "FIRST NAME"
            .Columns(2).HeaderText = "MIDDLE NAME"
            .Columns(3).HeaderText = "LAST NAME"
            .Columns(4).HeaderText = "AGE"
            .Columns(5).HeaderText = "SEX"
            .Columns(7).HeaderText = "DESCRIPTIONS"
            .Columns(8).HeaderText = "DATE OF TREATMENTS"
            .Columns(9).HeaderText = "TNO"
            .Columns(6).HeaderText = "PROBLEM"
            .Columns(0).Width = 100
            .Columns(1).Width = 200
            .Columns(2).Width = 140
            .Columns(3).Width = 130
            .Columns(8).Width = 230
            .Columns(7).Width = 130
        
        End With
        With Dtgvmedical
            .Columns(0).HeaderText = "MED NO"
            .Columns(1).HeaderText = "MEDICINE NAME"
            .Columns(2).HeaderText = "QUANTITY"
            .Columns(3).HeaderText = "ITEMS"
            .Columns(4).HeaderText = "PRICE"
            .Columns(5).HeaderText = "EXPIREDED DATE"
            .Columns(6).HeaderText = "CATEGORY"
            .Columns(1).Width = 140
            .Columns(5).Width = 240
            .Columns(1).Width = 190
        End With
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
                    query = "INSERT INTO medicines(Mname,amount,item,price,expireddate,category)" & _
                    "VALUES('" & txtmedicalName.Text & "','" & txtmedicalQuantity.Text & "','" & TextBox4.Text & "','" & txtmedicalPrice.Text & "', " & _
                    "'" & DatemedicalExpiredDate.Text & "','" & cbmedicalcategory.Text & "'); "
                    Try
                        connection()
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
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
                          "" + txtmedicalQuantity.Text + "',category='" + cbmedicalcategory.Text + "',item='" & TextBox4.Text & "'" & _
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
                    emptyfield()
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
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub
    Private Sub retrieveFrmDoctor()
        Try
            connection()
            query = "SELECT p.Pid,firstname,middlename,lastname,age,gender,problem,Descriptions,Dateoftreatment,t.TrId FROM newpatient p , treatment t " & _
          "WHERE p.Pid = t.Pid AND p.status='TREATED' AND Dateoftreatment='" & DateTimePicker1.Text & "' AND submittedTo='DOCTOR'"
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
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM users WHERE lastname= '" & username & "' AND password= '" & currentpass & "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function
    Sub connection()
      con = New SqlConnection(My.Settings.con)
        Try
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
            txtmedicalPrice.Text = Dtgvmedical.Item(4, e.RowIndex).Value
            TextBox4.Text = Dtgvmedical.Item(3, e.RowIndex).Value
            DatemedicalExpiredDate.Text = Dtgvmedical.Item(5, e.RowIndex).Value
            btnmedicaldelete.Visible = True
            cbmedicalcategory.Text = Dtgvmedical.Item(6, e.RowIndex).Value
            quantity = txtmedicalQuantity.Text
            item = TextBox4.Text
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
        TextBox4.Clear()
        cbmedicalcategory.Text = ""
        txtmedicalQuantity.Clear()
        txtmedicalPrice.Clear()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("You about to logout")
        Me.Close()
        Home.Show()
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

    Private Sub DgvMedFrmDoct_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgvMedFrmDoct.CellMouseClick
        Try
            ListBox1.Items.Clear()
            txtMedFrmDoctId.Text = DgvMedFrmDoct.Item(0, e.RowIndex).Value
            txtMedFrmDoctFname.Text = DgvMedFrmDoct.Item(1, e.RowIndex).Value
            txtMedFrmDoctSurName.Text = DgvMedFrmDoct.Item(3, e.RowIndex).Value
            txtMedFrmDoctSex.Text = DgvMedFrmDoct.Item(5, e.RowIndex).Value
            txtMedFrmDoctAge.Text = DgvMedFrmDoct.Item(4, e.RowIndex).Value
            TextBox1.Text = DgvMedFrmDoct.Item(8, e.RowIndex).Value
            TextBox2.Text = DgvMedFrmDoct.Item(6, e.RowIndex).Value
            txtMedFrmDoctITrid.Text = DgvMedFrmDoct.Item(9, e.RowIndex).Value
            trId = txtMedFrmDoctITrid.Text
            Button5.Visible = True
            retrieveToListbox()
            TextBox3.Text = DgvMedFrmDoct.Item(7, e.RowIndex).Value
        Catch ex As Exception
        End Try

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AssignedMedical.Show()
    End Sub

    Private Sub btnMedFrmDoctAssDrug_Click_1(sender As Object, e As EventArgs)
        PatId = txtMedFrmDoctId.Text
        Dim str As String = ""
        str = str & ListBox1.SelectedItem
        If (str = "") Then
            MsgBox("Please select the desciptions from doctor")
        Else
            medicinelist.Show()
            Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, txtMedFrmDoctSearch.TextChanged
        Try
            connection()
            query = "SELECT p.Pid,firstname,middlename,lastname,age,gender,problem,Descriptions,Dateoftreatment,t.TrId FROM newpatient p , treatment t " & _
          "WHERE p.Pid = t.Pid AND p.status='TREATED' AND Dateoftreatment='" & DateTimePicker1.Text & "' AND ( p.Pid like '%" + txtMedFrmDoctSearch.Text + "%' or p.firstname like '%" + txtMedFrmDoctSearch.Text + "%')"
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        medicinelist.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        AssignedMedical.Show()
        retrieve()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        retrieveFrmDoctor()
    End Sub
    Private Sub retrieveToListbox()
        Try
            connection()
            Dim cmd As String = "SELECT * FROM RecomMedicines r, treatment t WHERE r.Trid = t.Trid AND r.Trid='" & txtMedFrmDoctITrid.Text & "' AND dateofissue='" & DateTimePicker1.Text & "'"
            com = New SqlCommand(cmd, con)
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    Me.ListBox1.Items.Add(reader("RecomMedicines"))
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            connection()
            query = "UPDATE newpatient SET submittedTo='RECEPTION' WHERE Pid='" & txtMedFrmDoctId.Text & "'"
            com = New SqlCommand(query, con)
            With com
                .ExecuteNonQuery()
            End With
            retrieveFrmDoctor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtMedFrmDoctId.Clear()
        txtMedFrmDoctFname.Clear()
        txtMedFrmDoctId.Clear()
        txtMedFrmDoctSurName.Clear()
        txtMedFrmDoctAge.Clear()
        txtMedFrmDoctSex.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ListBox1.Items.Clear()

    End Sub

    Private Sub btnmedicalSell_Click(sender As Object, e As EventArgs) Handles btnmedicalSell.Click
        Dim x As Integer = 0
        If CheckBox2.Checked = True Then
            NewItem = item - NewItem
            Try

                connection()
                query = "UPDATE medicines SET item=" & NewItem & "  WHERE Mid=" + txtmedicalId.Text
                With com
                    com = New SqlCommand(query, con)
                    x = .ExecuteNonQuery
                End With
                If (x > 0) Then
                    MsgBox("Selling " & item & " medicines is successifully")
                    quantity = 0
                    btnmedicalSave.Text = "SAVE"
                    retrieve()
                    btnmedicalSell.Enabled = False
                    emptyfield()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf CheckBox1.Checked = True Then
            newQuantity = quantity - newQuantity
            Try

                connection()
                query = "UPDATE medicines SET Amount=" & newQuantity & "  WHERE Mid=" + txtmedicalId.Text
                With com
                    com = New SqlCommand(query, con)
                    x = .ExecuteNonQuery
                End With
                If (x > 0) Then
                    MsgBox("Selling " & quantity & " medicines is successifully")
                    quantity = 0
                    btnmedicalSave.Text = "SAVE"
                    retrieve()
                    btnmedicalSell.Enabled = False
                    emptyfield()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Try
                If (quantity <> 0) Then
                    btnmedicalSell.Enabled = True
                    newQuantity = InputBox("Enter the amount to sell")
                    If (newQuantity > quantity) Then
                        MsgBox("The quantity entered exceeded the available quantity")
                        CheckBox1.Checked = False
                        newQuantity = 0
                    End If
                End If
            Catch ex As Exception
            End Try
        End If
 
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Try
                If (quantity <> 0) Then
                    If (item <> 0) Then
                        btnmedicalSell.Enabled = True
                        NewItem = InputBox("Enter the amount to sell")
                        If (NewItem > item) Then
                            MsgBox("The items entered exceeded the available items")
                            NewItem = 0
                            CheckBox2.Checked = False
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
        End If
   
    End Sub
End Class

