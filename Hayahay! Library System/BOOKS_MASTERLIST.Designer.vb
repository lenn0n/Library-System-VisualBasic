<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOKS_MASTERLIST
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
        Me.booksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.hayahayDataSet = New Hayahay__Library_System.hayahayDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.booksTableAdapter = New Hayahay__Library_System.hayahayDataSetTableAdapters.booksTableAdapter()
        CType(Me.booksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hayahayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'booksBindingSource
        '
        Me.booksBindingSource.DataMember = "books"
        Me.booksBindingSource.DataSource = Me.hayahayDataSet
        '
        'hayahayDataSet
        '
        Me.hayahayDataSet.DataSetName = "hayahayDataSet"
        Me.hayahayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.booksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hayahay__Library_System.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(813, 469)
        Me.ReportViewer1.TabIndex = 0
        '
        'booksTableAdapter
        '
        Me.booksTableAdapter.ClearBeforeFill = True
        '
        'BOOKS_MASTERLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 469)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "BOOKS_MASTERLIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER LIST"
        CType(Me.booksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hayahayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents booksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents hayahayDataSet As Hayahay__Library_System.hayahayDataSet
    Friend WithEvents booksTableAdapter As Hayahay__Library_System.hayahayDataSetTableAdapters.booksTableAdapter
End Class
