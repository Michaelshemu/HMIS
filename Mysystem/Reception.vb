Imports System.Data.SqlClient
Public Class Reception
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim strquery As String
    Dim da As SqlDataAdapter
    Dim dts As DataSet
    Dim dt As DataTable
    Dim amount As Integer
    Dim queryResult As Integer
    Dim currentpass As String
    Dim newpassowrd1 As String
    Dim newpassowrd2 As String
    Dim textToPrint As String = ""
    Public Sub conn()
        con = New SqlConnection(My.Settings.con)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
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
                'write some
                If (checkduplicate() > 0) Then
                    MsgBox("The patient already exist")
                    emptyfield()
                Else
                    Try

                        query = "INSERT INTO newpatient(firstname,middlename,lastname,gender,placeofbirth,age,contacts,date,status)" & _
                                    "VALUES('" + txtReceNewPatFname.Text + "','" + txtReceNewPatMname.Text + "', " & _
                                    "'" + txtReceNewPatLname.Text + "','" + cbReceNewPatGender.Text + "'," & _
                                    "'" + txtReceNewPatPlaceOfBirth.Text + "','" + txtReceNewPatPCAge.Text + "','" & _
                                    "" + txtReceNewPatContact.Text + " ','" + DateReceNewPatDate.Text + "','UNTREATED'); "
                        conn()
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
                        MsgBox("Successifully...!")
                        retrieve()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf btnReceNewPatSave.Text = "UPDATE" Then
                Dim x As Integer = 0
                Try
                    conn()
                    query = "UPDATE newpatient SET firstname='" + txtReceNewPatFname.Text + "',middlename='" & _
                              "" + txtReceNewPatMname.Text + "',lastname='" + txtReceNewPatLname.Text + "'," & _
                              "contacts='" + txtReceNewPatContact.Text + "',placeofbirth='" + txtReceNewPatPlaceOfBirth.Text + "'" & _
                             ",age='" + txtReceNewPatPCAge.Text + "',gender='" + cbReceNewPatGender.Text + "',date='" + DateReceNewPatDate.Text + "',status='" & cbReceNewPatstatus.Text & "'" & _
                              "WHERE Pid = " + txtReceNewPatIDs.Text
                    With com
                        com = New SqlCommand(query, con)
                        x = .ExecuteNonQuery
                    End With
                    If (x > 0) Then
                        MsgBox("Update " & x & " row is successifully")
                        btnReceNewPatSave.Text = "SAVE"
                        retrieve()
                        retrievetreated()
                        retrieveFromLab()
                        retrieveFromMedical()
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

    Public Sub PrintHeader()
        TextToPrint = ""
        'send Business Name
        Dim StringToPrint As String = "Business Name"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "12345 Street Avenue"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        ' send city, state, zip
        StringToPrint = "City, State, Zip code"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine

        ' send phone number
        StringToPrint = "999-999-9999"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

        'send website
        StringToPrint = "website.com"
        LineLen = StringToPrint.Length
        Dim spcLen4b As New String(" "c, Math.Round((33 - LineLen) / 2))
        textToPrint &= spcLen4b & StringToPrint & Environment.NewLine
    End Sub

    Public Sub ItemsToBePrinted()


        Dim StringToPrint As String = "    " & "1" & " @ " & "3.99" & "         " & "3.99"
        Dim LineLen As String = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((30 - LineLen)))


        TextToPrint &= "Description" & Environment.NewLine
        TextToPrint &= StringToPrint & Environment.NewLine

    End Sub

    Public Sub printFooter()
        TextToPrint &= Environment.NewLine & Environment.NewLine
        Dim globalLengt As Integer = 0

        'SubTotal Amount
        Dim StringToPrint As String = "Sub Total   " & FormatCurrency("3.99", , , TriState.True, TriState.True)  'Change here to subtotal
        Dim LineLen As String = StringToPrint.Length
        globalLengt = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen5 & StringToPrint & Environment.NewLine

        'Tax Amount
        StringToPrint = "Tax         " & FormatCurrency("0.05", , , TriState.True, TriState.True) 'Change to tax amount
        LineLen = globalLengt
        Dim spcLen6 As New String(" "c, Math.Round((26 - LineLen)))
        If Not StringToPrint = "Tax         $0.00" Then
            TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine
        End If

        'Total Amount
        StringToPrint = "Total       " & "$4.04"
        LineLen = globalLengt
        Dim spcLen8 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= spcLen8 & StringToPrint & Environment.NewLine & Environment.NewLine

        'Cash Entered Amount
        StringToPrint = "Cash        " & FormatCurrency("5.00", , , TriState.True, TriState.True)
        LineLen = globalLengt
        Dim spcLen9 As New String(" "c, Math.Round((26 - LineLen)))
        If Not StringToPrint = "Cash        $0.00" Then
            TextToPrint &= spcLen9 & StringToPrint & Environment.NewLine
        End If

        'Change Amount
        StringToPrint = "Change      " & FormatCurrency("0.96", , , TriState.True, TriState.True)
        LineLen = globalLengt
        Dim spcLen10 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen10 & StringToPrint & Environment.NewLine
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub

    Private Sub Reception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintDocument1.PrinterSettings.PrinterName = "EPSON TM-T88V Receipt"
        retrieve()
        retrievetreated()
        retrieveFromLab()
        lbfirstname.Text = firstname
        lblastname.Text = username
        lbdate.Text = dateRecRegSearch.Text
        retrieveFromMedical()
        With DataGridView1
            .Columns(0).HeaderText = "PAT.NUMB"
            .Columns(1).HeaderText = "FIRST NAME"
            .Columns(2).HeaderText = "MIDDLE NAME"
            .Columns(3).HeaderText = "LAST NAME"
            .Columns(4).HeaderText = "SEX"
            .Columns(5).HeaderText = "PLACE OF BIRTH"
            .Columns(6).HeaderText = "AGE"
            .Columns(7).HeaderText = "CONTACTS"
            .Columns(7).Width = 170
            .Columns(4).Width = 50
            .Columns(5).Width = 119
            .Columns(2).Width = 130
        End With
        With DataGridView3
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
        With DtgvRecReg
            .Columns(0).HeaderText = "PATNO"
            .Columns(1).HeaderText = "FIRST NAME"
            .Columns(2).HeaderText = "MIDDLE NAME"
            .Columns(3).HeaderText = "LAST NAME"
            .Columns(4).HeaderText = "SEX"
            .Columns(5).HeaderText = "PLACE OF BIRTH"
            .Columns(6).HeaderText = "AGE"
            .Columns(7).HeaderText = "CONTACTS"
            .Columns(8).HeaderText = "REGISTERED DATE"
            .Columns(0).Width = 100
            .Columns(1).Width = 200
            .Columns(2).Width = 140
            .Columns(3).Width = 130
            .Columns(4).Width = 100
            .Columns(5).Width = 130
            .Columns(6).Width = 130
            .Columns(7).Width = 130
            .Columns(8).Width = 250
        End With
        With DtgvReceNewPat
            .Columns(0).HeaderText = "PATNO"
            .Columns(1).HeaderText = "FIRST NAME"
            .Columns(2).HeaderText = "MIDDLE NAME"
            .Columns(3).HeaderText = "LAST NAME"
            .Columns(4).HeaderText = "SEX"
            .Columns(5).HeaderText = "PLACE OF BIRTH"
            .Columns(6).HeaderText = "AGE"
            .Columns(7).HeaderText = "CONTACTS"
            .Columns(8).HeaderText = "REGISTERED DATE"
            .Columns(0).Width = 50
            .Columns(1).Width = 100
            .Columns(2).Width = 140
            .Columns(3).Width = 130
            .Columns(4).Width = 60
            .Columns(5).Width = 120
            .Columns(6).Width = 50
            .Columns(7).Width = 100
            .Columns(8).Width = 160
        End With
        DtgvReceNewPat.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub
    Private Sub retrieveFromLab()
        Try
            conn()
            query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM newpatient WHERE status='TREATED' AND submittedTo='LAB-TECH'"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("newpatient")
            da.Fill(dts, "newpatient")
            DataGridView1.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub retrieveFromMedical()
        conn()
        query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM" & _
        " newpatient WHERE (status='TREATED' OR status='') AND submittedTo='RECEPTION'"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("newpatient")
        da.Fill(dts, "newpatient")
        DataGridView3.DataSource = dts.Tables(0)
    End Sub
    Private Sub retrievetreated()
        conn()
        query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts,date FROM newpatient WHERE status='TREATED' OR status=''"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("newpatient")
        da.Fill(dts, "newpatient")
        DtgvReceNewPat.DataSource = dts.Tables(0)
        txtReceNewPatIDs.Enabled = False
    End Sub
    Private Sub retrieve()
        Try
            conn()
            query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts,date FROM newpatient WHERE status='UNTREATED' "
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("newpatient")
            da.Fill(dts, "newpatient")
            DtgvRecReg.DataSource = dts.Tables(0)
            txtReceNewPatIDs.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
        Ptid = txtRecRegIDs.Text
    End Sub

    Private Sub RdobtnRecRegPayDir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdobtnRecRegPayDir.CheckedChanged
        If txtRecRegIDs.Text = "" Then
            MsgBox("Select the patient first to make payment")
        Else
            Try
                amount = InputBox("Enter the amount")
                If cbRecRegSubmittedTo.Text = "LAB-TECH" Then
                    While (amount < TotalAmount)
                        btnRecRegSubmit.Enabled = False
                        amount = InputBox("The amount paid not enough plesase Enter again")
                    End While
                End If
            Catch ex As Exception

            End Try
            btnRecRegSubmit.Enabled = True
        End If

    End Sub
    Public Function retrievePrice()
        Dim payment As Integer = 0
        Dim price As Integer = 0
        Try
            conn()
            Dim strquery As String = "SELECT SUM(t.price) as 'cost' FROM Assignedtests a,tests t WHERE" & _
        " a.id=t.id AND a.dateoftest='" & DateTimePicker1.Text & "'AND a.Pid=" & TextBox3.Text
            com = New SqlCommand(strquery, con)
            queryResult = com.ExecuteScalar
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    price = reader("cost")
                End While
            End Using
            Dim strquery2 As String = "SELECT payments  FROM treatment  WHERE Dateoftreatment" & _
        " ='" & DateTimePicker2.Text & "' AND Pid='" & TextBox12.Text & "' "
            com = New SqlCommand(strquery2, con)
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    payment = reader("payments")
                End While
            End Using
            queryResult = payment + price
        Catch ex As Exception
            queryResult = 0
        End Try
        Return queryResult
    End Function
    Public Function retrieveMedPrice()
        Dim result As Integer = 0
        Dim payment As Integer=0
        Dim price As Integer

        Try
            conn()
            Dim strquery1 As String = "SELECT SUM(m.price) as 'cost' FROM Asignedmedical a,treatment t," & _
"medicines m WHERE (m.Mid=a.Mid) AND (t.TrId=a.TrId) AND (a.AssignedDate=t.Dateoftreatment) AND " & _
"a.AssignedDate='" & DateTimePicker2.Text & "' AND t.Pid='" & TextBox12.Text & "' "
            com = New SqlCommand(strquery1, con)
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    price = reader("cost")
                End While
            End Using
            Dim strquery2 As String = "SELECT payments  FROM treatment  WHERE Dateoftreatment" & _
            " ='" & DateTimePicker2.Text & "' AND Pid='" & TextBox12.Text & "' "
            com = New SqlCommand(strquery2, con)
            Using reader As SqlDataReader = com.ExecuteReader
                While (reader.Read())
                    payment = reader("payments")
                End While
            End Using
            result = payment + price
        Catch ex As Exception
            queryResult = 0
        End Try
        Return result
    End Function

    Private Sub btnRecRegSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecRegSubmit.Click
        checkduplicateTreatments()
        Dim myquery As String
        If (cbRecRegSubmittedTo.Text = "" Or _
             cbRecRegSubmittedTo.Text = "" Or _
              txtRecRegFname.Text = "" Or _
              txtRecRegLname.Text = "") Then
            MsgBox("You must fill all fields", MsgBoxStyle.Information)
        ElseIf amount = 0 Then
            MsgBox("Please make payment first", MsgBoxStyle.Exclamation)
        Else
            cbRecRegSubmittedTo.Text = cbRecRegSubmittedTo.Text.Trim
            txtReceNewPatMname.Text = txtReceNewPatMname.Text.Trim
            cbRecRegSubmittedTo.Text = cbRecRegSubmittedTo.Text.Trim
            txtRecRegLname.Text = txtReceNewPatPlaceOfBirth.Text.Trim

            If cbRecRegSubmittedTo.Text = "DOCTOR" Then
                If (checkduplicateTreatments() > 0) Then
                    MsgBox("Record exist")
                Else
                    myquery = "INSERT INTO treatment (Dateoftreatment,payments,DrName,Pid,problem)" & _
                                      "VALUES('" & dateRecRegSearch.Text & "'," & amount & ",'" & cbRecRegSubmittedTo.Text & "'," + txtRecRegIDs.Text + ",'" & TextBox1.Text & "'); "
                    Try
                        conn()
                        Dim updatequery As String = "UPDATE newpatient SET submittedTo='DOCTOR' WHERE Pid=" + txtRecRegIDs.Text + ""
                        com = New SqlCommand(updatequery, con)
                        com.ExecuteNonQuery()
                        com = New SqlCommand(myquery, con)
                        com.ExecuteNonQuery()
                        MsgBox("Successifully...!")
                        retrieve()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If


            ElseIf cbRecRegSubmittedTo.Text = "LAB-TECH" Then

                Try
                    If amount = 0 Then
                        btnRecRegSubmit.Enabled = False
                        MsgBox("You must make a payments first")
                    Else
                        conn()
                        query = "UPDATE newpatient SET submittedTo='LAB-TECH' WHERE Pid='" & txtRecRegIDs.Text & "'"
                        com = New SqlCommand(query, con)
                        com.ExecuteNonQuery()
                        MsgBox("Successifully")
                        txtRecRegIDs.Clear()
                        txtRecRegLname.Clear()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MsgBox("Select the submission please")
            End If
        End If

    End Sub
    Private Sub retrieveToCombobox()
        conn()
        Dim strquery As String = "SELECT firstname,lastname FROM users WHERE status LIKE '%" & cbRecRegSubmittedTo.Text & "%'"
        com = New SqlCommand(strquery, con)
        dt = New DataTable
        da = New SqlDataAdapter(strquery, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            With ComboBox1
                .Items.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    .Items.Add(dt.Rows(i).Item("firstname") & " " & dt.Rows(i).Item("lastname"))
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
        conn()
        query = "SELECT * FROM newpatient WHERE (Pid  like '%" + txtReceNewPatSearch.Text + "%' or firstname like '%" + txtReceNewPatSearch.Text + "%') AND status='TREATED' or status=NULL"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        DtgvReceNewPat.DataSource = dts.Tables(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, txtRecRegSearch.TextChanged

        conn()
        query = "SELECT * FROM newpatient WHERE status='UNTREATED' AND (Pid  like '%" + txtRecRegSearch.Text + "%' or firstname like '%" + txtRecRegSearch.Text + "%')"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("users")
        da.Fill(dts, "users")
        DtgvRecReg.DataSource = dts.Tables(0)
    End Sub
    Function checkduplicate()
        Try
            conn()
            Dim strquery As String = "SELECT COUNT(*) As numRows FROM newpatient WHERE Pid= " & _
            "'" + txtReceNewPatIDs.Text + "' OR firstname= '" + txtReceNewPatFname.Text + "'" & _
           " and lastname='" + txtReceNewPatLname.Text + "'"
            com = New SqlCommand(strquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function
    Public Function checkduplicateTreatments()
        Try
            conn()
            strquery = "SELECT COUNT(*) As numRows FROM treatment WHERE Pid= " & _
            "'" + txtRecRegIDs.Text + "'AND Dateoftreatment='" & dateRecRegSearch.Text & "'"
            com = New SqlCommand(strquery, con)
            queryResult = com.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return queryResult
    End Function

    Private Sub btnReceNewPatDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceNewPatDelete.Click
        Dim i As Integer = 0
        Try
            conn()

            Dim query1 = "DELETE RecomMedicines FROM treatment INNER JOIN RecomMedicines ON (RecomMedicines.TrId=treatment.TrId) WHERE treatment.Pid = '" & txtReceNewPatIDs.Text & "' "
            com = New SqlCommand(query1, con)
            com.ExecuteNonQuery()
            Dim query2 As String = "DELETE AsignedMedical FROM treatment INNER JOIN AsignedMedical ON (treatment.Trid=AsignedMedical.Trid) WHERE treatment.Pid = '" & txtReceNewPatIDs.Text & "' "
            com = New SqlCommand(query2, con)
            com.ExecuteNonQuery()
            Dim query3 As String = "DELETE treatment FROM newpatient INNER JOIN treatment ON (treatment.Pid=newpatient.Pid) WHERE treatment.Pid = '" & txtReceNewPatIDs.Text & "' "
            com = New SqlCommand(query3, con)
            com.ExecuteNonQuery()
            Dim query4 As String = "DELETE assignedtests FROM newpatient INNER JOIN Assignedtests ON (Assignedtests.Pid=newpatient.Pid) WHERE Assignedtests.Pid = '" & txtReceNewPatIDs.Text & "' "
            com = New SqlCommand(query4, con)
            com.ExecuteNonQuery()
            Dim query As String = "DELETE newpatient WHERE Pid = '" & txtReceNewPatIDs.Text & "' "
            com = New SqlCommand(query, con)
            i = com.ExecuteNonQuery()
            If (i > 0) Then
                MsgBox("Delete " & txtReceNewPatFname.Text & " " & txtReceNewPatLname.Text & " was successifully")
                retrieve()
                retrievetreated()
                retrieveFromMedical()
                retrieveFromLab()
                emptyfield()
                btnReceNewPatSave.Text = "SAVE"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        retrieve()
    End Sub

    Private Sub cbRecRegSubmittedTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRecRegSubmittedTo.SelectedIndexChanged
        If (txtRecRegIDs.Text = "") Then
            MsgBox("Sorry you must specify patient first ", MsgBoxStyle.Information)
        Else
            If txtRecRegIDs.Text = " " Then
                MsgBox("Please select the responsible officer first")
                ComboBox1.SelectedItem = Nothing
                ComboBox1.Text = ""
                ComboBox1.Enabled = False
                Exit Sub
            ElseIf cbRecRegSubmittedTo.Text = "LAB-TECH" Then
                userTests.Show()
                retrieveToCombobox()
            ElseIf cbRecRegSubmittedTo.Text = "DOCTOR" Then
                retrieveToCombobox()
            End If
        End If

    End Sub
    Private Sub retrieveResults()
        Try
            conn()
            query = "SELECT t.TestName,Results,Recommendation,t.price FROM Assignedtests a,tests t WHERE a.id=t.id AND a.dateoftest='" & DateTimePicker1.Text & "'AND a.Pid='" & TextBox3.Text & "' "
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

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        currentpass = InputBox("Enter the current password")
        If (checkdpassword() > 0) Then
            newpassowrd1 = InputBox("Enter the New password")
            newpassowrd2 = InputBox("Cofirm the New password")
            If (newpassowrd1 = newpassowrd2) Then
                Dim x As Integer = 0
                Try
                    conn()
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

    Private Sub ChangeUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeUserToolStripMenuItem.Click
        MsgBox("You are now logout")
        Me.Close()
        Home.Show()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            TextBox3.Text = DataGridView1.Item(0, e.RowIndex).Value
            TextBox4.Text = DataGridView1.Item(1, e.RowIndex).Value
            TextBox5.Text = DataGridView1.Item(6, e.RowIndex).Value
            TextBox6.Text = DataGridView1.Item(3, e.RowIndex).Value
            TextBox7.Text = DataGridView1.Item(4, e.RowIndex).Value
            TextBox14.Text = retrievePrice()
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
                .Columns(0).HeaderText = "TEST"
                .Columns(1).HeaderText = "RESULT"
                .Columns(2).HeaderText = "RECOMMENDATIONS"
                .Columns(3).HeaderText = "PRICE"
                .Columns(0).Width = 80
                .Columns(1).Width = 119
                .Columns(2).Width = 180
                .Columns(3).Width = 180
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End With
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        retrieveResults()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If cbRecRegSubmittedTo.Text = "" Then
            ComboBox1.SelectedItem = Nothing
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub DataGridView3_CellMouseClick1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseClick
        Try
            TextBox12.Text = DataGridView3.Item(0, e.RowIndex).Value
            TextBox11.Text = DataGridView3.Item(1, e.RowIndex).Value
            TextBox10.Text = DataGridView3.Item(6, e.RowIndex).Value
            TextBox9.Text = DataGridView3.Item(3, e.RowIndex).Value
            TextBox8.Text = DataGridView3.Item(4, e.RowIndex).Value
            TextBox15.Text = retrieveMedPrice()
            TextBox11.Enabled = False
            TextBox12.Enabled = False
            TextBox10.Enabled = False
            TextBox9.Enabled = False
            TextBox8.Enabled = False
        Catch ex As Exception

        End Try
        retrieveResultsFromMedical()
        With DataGridView4
            Try
                .Columns(0).HeaderText = "DRUG NAME"
                .Columns(1).HeaderText = "DESCRIPTIONS"
                .Columns(2).HeaderText = "AMOUNT"
                .Columns(3).HeaderText = "COST"
                .Columns(0).Width = 120
                .Columns(1).Width = 180
                .Columns(2).Width = 80
                .Columns(3).Width = 150
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End With
    End Sub

  
    Private Sub retrieveResultsFromMedical()
        Try
            conn()
            query = "SELECT m.MName,Descriptions,a.Amount,a.cost FROM Asignedmedical a,treatment t, medicines m WHERE " & _
"a.Trid=t.Trid AND  m.Mid=a.Mid AND a.AssignedDate='" & DateTimePicker2.Text & "'AND t.Pid='" & TextBox12.Text & "' "
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("newpatient")
            da.Fill(dts, "newpatient")
            DataGridView4.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        retrieveResultsFromMedical()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Doctor_Payment.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        con = New SqlConnection(My.Settings.con)
        retrieve()
        retrievetreated()
        retrieveFromLab()
        retrieveFromMedical()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(textToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(textToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < textToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, TextBox13.TextChanged
        conn()
        query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM" & _
        " newpatient WHERE (status='TREATED' OR status=NULL) AND submittedTo='RECEPTION' AND Pid like '%" & TextBox13.Text & "%' or firstname like '%" & TextBox13.Text & "%'"
        com = New SqlCommand(query, con)
        com.ExecuteNonQuery()
        da = New SqlDataAdapter(query, con)
        dts = New DataSet("newpatient")
        da.Fill(dts, "newpatient")
        DataGridView3.DataSource = dts.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn()
            query = "SELECT Pid,firstname,middlename,lastname,gender,placeofbirth,age,contacts FROM " & _
   "newpatient WHERE status='TREATED' AND submittedTo='LAB-TECH' and Pid like '%" & TextBox2.Text & "%' OR firstname like '%" & TextBox2.Text & "%'"
            com = New SqlCommand(query, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter(query, con)
            dts = New DataSet("newpatient")
            da.Fill(dts, "newpatient")
            DataGridView1.DataSource = dts.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
