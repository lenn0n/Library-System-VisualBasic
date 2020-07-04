Imports Microsoft.Reporting.WinForms

Public Class SINGLE_REPORT

    Private Sub SINGLE_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bookname As New ReportParameter("bookname", FRM_MAIN.TB_BNAME.Text)
        Dim bookauthor As New ReportParameter("bookauthor", FRM_MAIN.TB_BAUTHOR.Text)
        Dim bookcat As New ReportParameter("bookcat", FRM_MAIN.CB_BCAT.Text)
        Dim bookyear As New ReportParameter("bookyear", FRM_MAIN.TB_BYEAR.Text)

        ReportViewer1.LocalReport.SetParameters(bookname)
        ReportViewer1.LocalReport.SetParameters(bookauthor)
        ReportViewer1.LocalReport.SetParameters(bookcat)
        ReportViewer1.LocalReport.SetParameters(bookyear)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class