Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FromReception
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Dim queryResult As Integer
    Dim query2 As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Sub connection()
      con = New SqlConnection(My.Settings.con)
        Try
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

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrmRecRecomendation.TextChanged
        txtFrmRecRecomendation.AcceptsReturn = True
    End Sub
    Private Sub retrivePatients()
        Try
            connection()
            query = "SELECT  p.Pid,firstname,middlename,lastname,age,gender,problem,trId FROM newpatient p , treatment t " & _
            "WHERE p.Pid = t.Pid AND status='UNTREATED' AND p.submittedTo='DOCTOR'AND Dateoftreatment='" & DateTimePicker1.Text & "'"
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
        btnFrmRecLab.Enabled = False
        With dtgvpatients
            .Columns(0).HeaderText = "PATNO"
            .Columns(1).HeaderText = "FIRST NAME"
            .Columns(2).HeaderText = "MIDDLE NAME"
            .Columns(3).HeaderText = "LAST NAME"
            .Columns(4).HeaderText = "AGE"
            .Columns(5).HeaderText = "SEX"
            .Columns(6).HeaderText = "PROBLEM"
            .Columns(7).HeaderText = "TNO"
            .Columns(7).Width = 160
            .Columns(4).Width = 50
            .Columns(5).Width = 119
            .Columns(2).Width = 130
        End With
     
    End Sub

    Private Sub dtgvpatients_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgvpatients.CellMouseClick
        Try
            txtFrmRecID.Text = dtgvpatients.Item(0, e.RowIndex).Value
            txtFrmRecFname.Text = dtgvpatients.Item(1, e.RowIndex).Value
            txtFrmRecMname.Text = dtgvpatients.Item(2, e.RowIndex).Value
            txtFrmRecLname.Text = dtgvpatients.Item(3, e.RowIndex).Value
            TextBox2.Text = dtgvpatients.Item(4, e.RowIndex).Value
            TextBox3.Text = dtgvpatients.Item(5, e.RowIndex).Value
            txtFrmRecProblem.Text = dtgvpatients.Item(6, e.RowIndex).Value
            TextBox5.Text = dtgvpatients.Item(7, e.RowIndex).Value
        Catch ex As Exception

        End Try
        Pdtid = txtFrmRecID.Text
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click, TextBox1.TextChanged
        Try
            connection()
            query = "SELECT  p.Pid,firstname,middlename,lastname,age,gender,problem,trId FROM newpatient p , treatment t " & _
            "WHERE p.Pid = t.Pid AND status='UNTREATED' AND p.submittedTo='DOCTOR'AND Dateoftreatment='" & DateTimePicker1.Text & "'" & _
            "and (p.Pid like '%" & TextBox1.Text & "%' or p.firstname like '%" & TextBox1.Text & "%')"
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

    Private Sub btnFrmRecMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmRecMedical.Click
        If txtFrmRecID.Text = "" Then
            MsgBox("Please select the patient to send", MsgBoxStyle.Information)
        Else
            connection()
            Try
                Dim query1 As String = "UPDATE treatment SET problem='" + txtFrmRecProblem.Text + "',Descriptions='" & txtFrmRecRecomendation.Text & "' WHERE Pid='" & txtFrmRecID.Text & "'"
                query2 = "UPDATE newpatient SET status='TREATED' WHERE Pid='" & txtFrmRecID.Text & "'"
                com = New SqlCommand(query1, con)
                With com
                    .ExecuteNonQuery()
                End With
                com = New SqlCommand(query2, con)
                With com
                    .ExecuteNonQuery()
                End With
                MsgBox("send patient no: " & txtFrmRecID.Text & " is successifully")
                retrivePatients()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        retrivePatients()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtFrmRecID.Text = "" Then
            MsgBox("You must select the patient first ", MsgBoxStyle.Information)
        Else
            If TextBox4.Text = "" Then
                MsgBox("You must fill the field required", MsgBoxStyle.Information)
            Else
                query = "INSERT INTO RecomMedicines(Trid,RecomMedicines,Dateofissue)" & _
                           "VALUES('" & TextBox5.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "'); "
                Try
                    connection()
                    com = New SqlCommand(query, con)
                    com.ExecuteNonQuery()
                    con.Close()
                    retrivePatients()
                    Label12.Text = "Data sent.."
                    TextBox4.Text = ""
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
       

    End Sub

    Private Sub btnFrmRecLab_Click(sender As Object, e As EventArgs) Handles btnFrmRecLab.Click
        If txtFrmRecID.Text = "" Then
            MsgBox("Please select the patient to send", MsgBoxStyle.Information)
        Else
            connection()
            query = "UPDATE newpatient SET submittedTo='LAB-TECH' WHERE Pid='" & txtFrmRecID.Text & "'"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            MsgBox("Successifully")
            retrivePatients()

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If Pdtid = 0 Then
                MsgBox("select the patient first")
            Else
                Ptid = Pdtid
                userTests.Show()
                btnFrmRecLab.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFrmRecReception_Click(sender As Object, e As EventArgs) Handles btnFrmRecReception.Click
        Dim x As Integer
        Try
            connection()
            query = "UPDATE newpatient SET status='TREATED' WHERE Pid='" & txtFrmRecID.Text & "'"
            With com
                com = New SqlCommand(query, con)
                x = .ExecuteNonQuery
            End With
            If (x > 0) Then
                Dim delete = "DELETE FROM treatment where Pid='" & txtFrmRecID.Text & "'"
                com = New SqlCommand(delete, con)
                com.ExecuteNonQuery()
                MsgBox("Patient " & x & " is successifully returned to reception")
                retrivePatients()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
