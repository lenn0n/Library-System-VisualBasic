Public Class FRM_LOGIN

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITBTN.Click
        tmpdata.systemexit()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_LOGIN.Click
            If TB_UN.Text = "" And TB_PWD.Text = "" Then
                MsgBox("Please Input Username/Password!")
                Exit Sub
            Else
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select * from user_login where username='" & TB_UN.Text & "' and password='" & TB_PWD.Text & "'"
                sqldr = sqlcmd.ExecuteReader

                If sqldr.HasRows = 0 Then
                    MsgBox("Account doesn't exist!", MsgBoxStyle.Critical, "Error!")
                    TB_PWD.Text = ""
                    TB_PWD.Focus()

            Else

                sqldr.Read()
                tmpdata.uid.Text = sqldr("uid")
                tmpdata.un.Text = sqldr("username")


                TIMER.Start()
                TB_UN.Hide()
                TB_PWD.Hide()
                Label5.Hide()
                BTN_SIGNUP.Hide()
                BTN_LOGIN.Hide()
                LOADINGPIC.Show()

            End If
        End If
        sqlcmd.Dispose()
        sqldr.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIMER.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            LOADINGPIC.Hide()
            TIMER.Stop()
            FRM_MAIN.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub FRM_LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LOADINGPIC.Hide()
    End Sub

    Private Sub TB_UN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_UN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TB_UN.Text = "" And TB_PWD.Text = "" Then
                MsgBox("Please Input Username/Password!")
                Exit Sub
            Else
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select * from user_login where username='" & TB_UN.Text & "' and password='" & TB_PWD.Text & "'"
                sqldr = sqlcmd.ExecuteReader

                If sqldr.HasRows = 0 Then
                    MsgBox("Account doesn't exist!", MsgBoxStyle.Critical, "Error!")
                    TB_PWD.Text = ""
                    TB_PWD.Focus()

                Else

                    While sqldr.Read
                        tmpdata.uid.Text = sqldr("uid")
                        tmpdata.un.Text = sqldr("username")
                    End While

                    TIMER.Start()
                    TB_UN.Hide()    
                    TB_PWD.Hide()
                    Label5.Hide()
                    BTN_SIGNUP.Hide()
                    BTN_LOGIN.Hide()
                    LOADINGPIC.Show()

                End If
            End If
            sqlcmd.Dispose()
            sqldr.Close()
        End If
    End Sub

    Private Sub TB_PWD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_PWD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TB_UN.Text = "" And TB_PWD.Text = "" Then
                MsgBox("Please Input Username/Password!")
                Exit Sub
            Else
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select * from user_login where username='" & TB_UN.Text & "' and password='" & TB_PWD.Text & "'"
                sqldr = sqlcmd.ExecuteReader

                If sqldr.HasRows = 0 Then
                    MsgBox("Account doesn't exist!", MsgBoxStyle.Critical, "Error!")
                    TB_PWD.Text = ""
                    TB_PWD.Focus()

                Else

                    While sqldr.Read
                        tmpdata.uid.Text = sqldr("uid")
                        tmpdata.un.Text = sqldr("username")
                    End While

                    TIMER.Start()
                    TB_UN.Hide()
                    TB_PWD.Hide()
                    Label5.Hide()
                    BTN_SIGNUP.Hide()
                    BTN_LOGIN.Hide()
                    LOADINGPIC.Show()

                End If
            End If
            sqlcmd.Dispose()
            sqldr.Close()
        End If
    End Sub

    Private Sub BTN_SIGNUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SIGNUP.Click
        FRM_REGISTRATION.Show()
        Me.Hide()

    End Sub
End Class