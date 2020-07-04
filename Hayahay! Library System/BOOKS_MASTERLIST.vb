Public Class BOOKS_MASTERLIST

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'hayahayDataSet.books' table. You can move, or remove it, as needed.
        Me.booksTableAdapter.Fill(Me.hayahayDataSet.books)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class