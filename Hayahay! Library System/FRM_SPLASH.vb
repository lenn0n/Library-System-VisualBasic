Public Class FRM_SPLASH

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            FRM_LOGIN.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FRM_SPLASH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        mysql.connect()
        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
    End Sub
End Class
