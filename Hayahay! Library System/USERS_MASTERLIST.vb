Public Class USERS_MASTERLIST

    Private Sub USERS_MASTERLIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'hayahayDataSet1.user_info' table. You can move, or remove it, as needed.
        Me.user_infoTableAdapter.Fill(Me.hayahayDataSet1.user_info)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class