<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.masterDataSet = New Mysystem.masterDataSet()
        Me.newpatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.newpatientTableAdapter = New Mysystem.masterDataSetTableAdapters.newpatientTableAdapter()
        CType(Me.masterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newpatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.newpatientBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Mysystem.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(637, 402)
        Me.ReportViewer1.TabIndex = 4
        '
        'masterDataSet
        '
        Me.masterDataSet.DataSetName = "masterDataSet"
        Me.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'newpatientBindingSource
        '
        Me.newpatientBindingSource.DataMember = "newpatient"
        Me.newpatientBindingSource.DataSource = Me.masterDataSet
        '
        'newpatientTableAdapter
        '
        Me.newpatientTableAdapter.ClearBeforeFill = True
        '
        'Doctor_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 400)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Doctor_Payment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Doctor_Payment"
        CType(Me.masterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newpatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents newpatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents masterDataSet As Mysystem.masterDataSet
    Friend WithEvents newpatientTableAdapter As Mysystem.masterDataSetTableAdapters.newpatientTableAdapter

End Class
