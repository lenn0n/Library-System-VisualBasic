<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USERS_MASTERLIST
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.hayahayDataSet1 = New Hayahay__Library_System.hayahayDataSet1()
        Me.user_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.user_infoTableAdapter = New Hayahay__Library_System.hayahayDataSet1TableAdapters.user_infoTableAdapter()
        CType(Me.hayahayDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.user_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.user_infoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hayahay__Library_System.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1196, 371)
        Me.ReportViewer1.TabIndex = 0
        '
        'hayahayDataSet1
        '
        Me.hayahayDataSet1.DataSetName = "hayahayDataSet1"
        Me.hayahayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'user_infoBindingSource
        '
        Me.user_infoBindingSource.DataMember = "user_info"
        Me.user_infoBindingSource.DataSource = Me.hayahayDataSet1
        '
        'user_infoTableAdapter
        '
        Me.user_infoTableAdapter.ClearBeforeFill = True
        '
        'USERS_MASTERLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 371)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "USERS_MASTERLIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USERS_MASTERLIST"
        CType(Me.hayahayDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.user_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents user_infoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents hayahayDataSet1 As Hayahay__Library_System.hayahayDataSet1
    Friend WithEvents user_infoTableAdapter As Hayahay__Library_System.hayahayDataSet1TableAdapters.user_infoTableAdapter
End Class
