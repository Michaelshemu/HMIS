Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class Doctor_Payment

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Doctor_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim patnum As New ReportParameter("patnum", Reception.txtRecRegIDs.Text)
            Dim firstname As New ReportParameter("fname", Reception.txtRecRegFname.Text)
            Dim lastname As New ReportParameter("lname", Reception.txtRecRegLname.Text)
            ReportViewer1.LocalReport.SetParameters(patnum)
            ReportViewer1.LocalReport.SetParameters(firstname)
            ReportViewer1.LocalReport.SetParameters(lastname)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
