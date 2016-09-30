Imports System.Data.SqlClient
Public Class Reception
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Dim dt As DataTable
    Dim amount As Integer
    Dim queryResult As Integer
    Dim currentpass As String
    Dim newpassowrd1 As String
    Dim newpassowrd2 As String
    Private Sub btnReceNewPatSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceNewPatSave.Click
        txtReceNewPatFname.Text = txtReceNewPatFname.Text.Trim
        txtReceNewPatMname.Text = txtReceNewPatMname.Text.Trim
        txtReceNewPatLname.Text = txtReceNewPatLname.Text.Trim
        txtReceNewPatPlaceOfBirth.Text = txtReceNewPatPlaceOfBirth.Text.Trim
        cbReceNewPatGender.Text = cbReceNewPatGender.Text.Trim
        If (txtReceNewPatFname.Text = "" Or _
                  txtReceNewPatMname.Text = "" Or _
                   txtReceNewPatLname.Text = "" Or _
                    txtReceNewPatPlaceOfBirth.Text = "" Or _
                     cbReceNewPatGender.Text = "" Or _
                     txtReceNewPatPCAge.Text = "") Then
            MsgBox("You must fill all fields", MsgBoxStyle.Information)
        Else

            If btnReceNewPatSave.Text = "SAVE" Then
                connection() 'write some
                If (checkduplicate() > 0) Then
                    MsgBox("The patient already exist")
                    emptyfield()
                Else
                    Try
                        query = "INSERT INTO newpatient(firstname,middlename,lastname,gender,placeofbirth,age,contact,date)" & _
                                    "VALUES('" + txtReceNewPatFname.Text + "','" + txtReceNewPatMname.Text + "', " & _
                                    "'" + txtReceNewPatLname.Text + "','" + cbReceNewPatGender.Text + "'," & _
                                    "'" + txtReceNewPatPlaceOfBirth.Text + "','" + txtReceNewPatPCAge.Text + "','" & _
                                    "" + txtReceNewPatContact.Text + " ','" + DateReceNewPatDate.Text + "'); "
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Successifully...!")
                        retrieve()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf btnReceNewPatSave.Text = "UPDATE" Then
                Dim x As Integer = 0
                Try
                    connection()
                    query = "UPDATE newpatient SET firstname='" + txtReceNewPatFname.Text + "',middlename='" & _
                              "" + txtReceNewPatMname.Text + "',lastname='" + txtReceNewPatLname.Text + "'," & _
                              "contact='" + txtReceNewPatContact.Text + "',placeofbirth='" + txtReceNewPatPlaceOfBirth.Text + "'" & _
                             ",age='" + txtReceNewPatPCAge.Text + "',gender='" + cbReceNewPatGender.Text + "',date='" + DateReceNewPatDate.Text + "' WHERE Pid=" + txtReceNewPatIDs.Text
                    With com
                        com = New SqlCommand(query, con)
                        x = .ExecuteNonQuery
                    End With
                    If (x > 0) Then
                        MsgBox("Update " & x & " row is successifully")
                        btnReceNewPatSave.Text = "SAVE"
                        retrieve()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
    End Sub
    Sub emptyfield()
        txtReceNewPatIDs.Clear()
        txtReceNewPatFname.Clear()
        txtReceNewPatMname.Clear()
        txtReceNewPatLname.Clear()
        txtReceNewPatPCAge.Clear()
        txtReceNewPatContact.Clear()
        cbReceNewPatGender.Text = ""
        txtReceNewPatPlaceOfBirth.Clear()
        DateReceNewPatDate.Text = ""
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

    Private Sub Reception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        retrieve()
        lbfirstname.Text = firstname
        lblastname.Text = username
        lbdate.Text = dateRecRegSearch.Text
    End Sub
    Private Sub retrieve()
        connection()
        query = "SELECT * FROM newpatient"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("newpatient")
        da.Fill(dts, "newpatient")
        DtgvRecReg.DataSource = dts.Tables(0)
        DtgvReceNewPat.DataSource = dts.Tables(0)
        txtReceNewPatIDs.Enabled = False
    End Sub

    Private Sub DtgvReceNewPat_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtgvReceNewPat.CellMouseClick
        Try
            txtReceNewPatIDs.Text = DtgvReceNewPat.Item(0, e.RowIndex).Value
            txtReceNewPatFname.Text = DtgvReceNewPat.Item(1, e.RowIndex).Value
            txtReceNewPatMname.Text = DtgvReceNewPat.Item(2, e.RowIndex).Value
            txtReceNewPatLname.Text = DtgvReceNewPat.Item(3, e.RowIndex).Value
            cbReceNewPatGender.Text = DtgvReceNewPat.Item(4, e.RowIndex).Value
            txtReceNewPatPlaceOfBirth.Text = DtgvReceNewPat.Item(5, e.RowIndex).Value
            txtReceNewPatPCAge.Text = DtgvReceNewPat.Item(6, e.RowIndex).Value
            txtReceNewPatContact.Text = DtgvReceNewPat.Item(7, e.RowIndex).Value
            DateReceNewPatDate.Text = DtgvReceNewPat.Item(8, e.RowIndex).Value
            btnReceNewPatSave.Text = "UPDATE"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DtgvRecReg_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DtgvRecReg.CellMouseClick
        Try
            If (txtRecRegSearch.Text = "") Then
                txtRecRegIDs.Text = DtgvRecReg.Item(0, e.RowIndex).Value
                txtRecRegFname.Text = DtgvRecReg.Item(1, e.RowIndex).Value
                txtRecRegLname.Text = DtgvRecReg.Item(3, e.RowIndex).Value
            ElseIf (IsNumeric(txtRecRegSearch.Text)) Then
                txtRecRegIDs.Text = txtRecRegSearch.Text
                txtRecRegFname.Text = DtgvRecReg.Item(1, e.RowIndex).Value
                txtRecRegLname.Text = DtgvRecReg.Item(3, e.RowIndex).Value
                txtRecRegSearch.Clear()
            Else
                txtRecRegIDs.Text = DtgvRecReg.Item(0, e.RowIndex).Value
                txtRecRegFname.Text = DtgvRecReg.Item(1, e.RowIndex).Value
                txtRecRegLname.Text = DtgvRecReg.Item(3, e.RowIndex).Value
                txtRecRegSearch.Clear()
            End If
      
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RdobtnRecRegPayDir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdobtnRecRegPayDir.CheckedChanged
        Try
            amount = InputBox("Enter the amount")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnRecRegSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecRegSubmit.Click
        If (cbRecRegSubmittedTo.Text = "" Or _
             cbRecRegSubmittedTo.Text = "" Or _
              txtRecRegFname.Text = "" Or _
              txtRecRegLname.Text = "") Then
            MsgBox("You must fill all fields", MsgBoxStyle.Information)
        Else
            cbRecRegSubmittedTo.Text = cbRecRegSubmittedTo.Text.Trim
            txtReceNewPatMname.Text = txtReceNewPatMname.Text.Trim
            cbRecRegSubmittedTo.Text = cbRecRegSubmittedTo.Text.Trim
            txtRecRegLname.Text = txtReceNewPatPlaceOfBirth.Text.Trim
            connection()
            If (checkduplicate2() > 0) Then
                MsgBox("The record exist")
                'emptyfield()
            Else
                If btnRecRegSubmit.Text = "SUBMIT" Then
                    query = "INSERT INTO treatment (Dateoftreatment,payments,DrName,Pid,problem)" & _
                    "VALUES('" & dateRecRegSearch.Text & "'," & amount & ",'" & cbRecRegSubmittedTo.Text & "'," + txtRecRegIDs.Text + ",'" & TextBox1.Text & "'); "
                    Try
                        connection()
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Successifully...!")
                        retrieve()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
            End If
        End If
           
    End Sub
    Private Sub retrieveToCombobox()
        connection()
        Dim strquery As String = "SELECT FNAME,SURNAME FROM users WHERE STATUS= '" & cbRecRegSubmittedTo.Text & "'"
        com = New SqlCommand(strquery, con)
        dt = New DataTable
        da = New SqlDataAdapter(strquery, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            With ComboBox1
                .Items.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    .Items.Add(dt.Rows(i).Item("FNAME") & " " & dt.Rows(i).Item("SURNAME"))
                Next
                .SelectedIndex = -1
            End With
        End If
        With con
            .Close()
            .Dispose()
        End With
        con = Nothing
        dt.Dispose()
        dt = Nothing
        da = Nothing
    End Sub

    Private Sub btnReceNewPatSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceNewPatSearch.Click, txtReceNewPatSearch.TextChanged
        connection()
        query = "SELECT * FROM newpatient WHERE Pid  like '%" + txtReceNewPatSearch.Text + "%' or firstname like '%" + txtReceNewPatSearch.Text + "%'"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        DtgvReceNewPat.DataSource = dts.Tables(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, txtRecRegSearch.TextChanged
        connection()
        query = "SELECT * FROM newpatient WHERE Pid  like '%" + txtRecRegSearch.Text + "%' or firstname like '%" + txtRecRegSearch.Text + "%'"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        DtgvRecReg.DataSource = dts.Tables(0)
    End Sub
    Function checkduplicate()
        Try
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM newpatient WHERE Pid= " & _
            "'" + txtRecRegIDs.Text + "' or firstname= '" + txtReceNewPatFname.Text + "'" & _
           " and lastname='" + txtReceNewPatLname.Text + "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function
    Function checkduplicate2()
        Try
            Dim myquery As String = "SELECT COUNT(*) As numRows FROM treatment WHERE Pid= " & _
            "'" + txtRecRegIDs.Text + "'"
            com = New SqlCommand(myquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function
    Private Sub btnReceNewPatDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceNewPatDelete.Click
        Dim i As Integer = 0
        Try
            connection()
            query = "DELETE FROM newpatient WHERE Pid =" + txtReceNewPatIDs.Text
            com = New SqlCommand(query, con)
            i = com.ExecuteNonQuery()
            If (i > 0) Then
                MsgBox("Delete " & txtReceNewPatFname.Text & " " & txtReceNewPatLname.Text & " was successifully")
                retrieve()
                emptyfield()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        retrieve()
    End Sub

    Private Sub cbRecRegSubmittedTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRecRegSubmittedTo.SelectedIndexChanged
        If cbRecRegSubmittedTo.Text = " " Then
            MsgBox("Please select the responsible officer first")
            Exit Sub
            ComboBox1.Enabled = False
        ElseIf cbRecRegSubmittedTo.Text = "LABORATORY" Then
            userTests.Show()
        Else

            retrieveToCombobox()
        End If

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

    Private Sub ChangeUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeUserToolStripMenuItem.Click
        MsgBox("You are now logout")
        Me.Close()
    End Sub

End Class