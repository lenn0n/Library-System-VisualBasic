Public Class FRM_PAY

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text < tmpdata.penalty.Text) Then
            MsgBox("You dont have enough money to pay!")
            Exit Sub

        Else
            change.Text = TextBox1.Text - tmpdata.penalty.Text
            MsgBox("Success!")
            FRM_MAIN.status_return.Show()
            FRM_MAIN.status_borrow.Hide()
            FRM_MAIN.status_foot.Text = "You paid " + tmpdata.penalty.Text + " pesos for not returning this book. (" + tmpdata.COUNT.Text + " days)"
      
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "update books set av=1, holder='0', dueday='0', duemonth='0' where bookid='" & tmpdata.BOOKID.Text & "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            sqlcon.Open()
            FRM_MAIN.notavailablebooks()
            tmpdata.BOOKID.Text = ""
            FRM_MAIN.confirmation.Show()
            Me.Hide()
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub FRM_PAY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
        status.Text = "You have to pay " + tmpdata.penalty.Text + " pesos."
    End Sub

End Class