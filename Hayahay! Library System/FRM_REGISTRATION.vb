Public Class FRM_REGISTRATION

 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FRM_LOGIN.Show()
        Me.Hide()

    End Sub

    Private Sub FRM_REGISTRATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox1.SelectedIndex = 0
        CB_SECTION.Items.Clear()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from user_section"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            CB_SECTION.Items.Add(sqldr("course"))
            ComboBox2.Items.Add(sqldr("course"))
        End While
        sqldr.Close()

        sqlcmd.CommandText = "select * from user_login"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            Users.Items.Add(sqldr("username"))
        End While
        sqldr.Close()

        sqlcmd.CommandText = "select * from user_info"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            IDs.Items.Add(sqldr("stud_id"))
        End While
        sqldr.Close()
        sqlcmd.Dispose()
        CB_SECTION.SelectedIndex = 0
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_STUDID.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please Enter Valid ID!", vbCritical, "Invalid Input!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_FNAME.KeyPress
        If Asc(e.KeyChar) AndAlso IsNumeric(e.KeyChar) Then
            MsgBox("Numbers are not allowed!", vbCritical, "Invalid!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_MNAME.KeyPress
        If Asc(e.KeyChar) AndAlso IsNumeric(e.KeyChar) Then
            MsgBox("Numbers are not allowed!", vbCritical, "Invalid!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_LNAME.KeyPress
        If Asc(e.KeyChar) AndAlso IsNumeric(e.KeyChar) Then
            MsgBox("Numbers are not allowed!", vbCritical, "Invalid!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_STUDID.TextChanged
        lblyear.Text = Mid(TB_STUDID.Text, 1, 4)
        lblnum.Text = Mid(TB_STUDID.Text, 6, 4)
        lblsem.Text = Mid(TB_STUDID.Text, 5, 1)
        If Mid(TB_STUDID.Text, 5, 1) = "0" Then
            MsgBox("Opps! Semester is invalid!", vbInformation, "Uh-oh..")
            TB_STUDID.Text = ""
        End If
        If Mid(TB_STUDID.Text, 5, 1) = "3" Then
            MsgBox("Opps! Semester is invalid!", vbInformation, "Uh-oh..")
            TB_STUDID.Text = ""
        End If
        If Mid(TB_STUDID.Text, 5, 1) = "4" Then
            MsgBox("Opps! Semester is invalid!", vbInformation, "Uh-oh..")
            TB_STUDID.Text = ""
        End If
        If Mid(TB_STUDID.Text, 5, 1) = "5" Then
            MsgBox("Opps! Semester is invalid!", vbInformation, "Uh-oh..")
            TB_STUDID.Text = ""
        End If

        If Mid(TB_STUDID.Text, 6, 1) = "0" Then
            lblnum.Text = Mid(TB_STUDID.Text, 7, 3)
            If Mid(TB_STUDID.Text, 7, 1) = "0" Then
                lblnum.Text = Mid(TB_STUDID.Text, 8, 2)
                If Mid(TB_STUDID.Text, 8, 1) = "0" Then
                    lblnum.Text = Mid(TB_STUDID.Text, 9, 1)
                    If Mid(TB_STUDID.Text, 9, 1) = "0" Then
                        MsgBox("Are you crazy? There's no such ID like this!", vbCritical, "Error!")
                        TB_STUDID.Text = ""
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub BTN_REG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_REG.Click
        If TB_UN.Text = "" Then
            MsgBox("Please Input Username!", vbCritical, "Empty!")
        ElseIf Users.Items.Contains(TB_UN.Text) Then
            MsgBox("Username is already taken!", vbInformation, "Error!")
        ElseIf Len(TB_UN.Text) < 5 Then
            MsgBox("Username must be atleast 5 characters!", vbInformation, "Error!")
        ElseIf TB_PWD.Text = "" Then
            MsgBox("Please Input Password!", vbCritical, "Empty!")
        ElseIf Len(TB_PWD.Text) < 6 Then
            MsgBox("Password must be atleast 6 characters!", vbInformation, "Error!")
        ElseIf (TB_RPWD.Text = TB_PWD.Text) = False Then
            MsgBox("Password didn't match!", vbCritical, "Error!")
            TB_RPWD.Text = ""
        ElseIf TB_FNAME.Text = "" Then
            MsgBox("Please Input First Name!", vbCritical, "Empty!")
        ElseIf Len(TB_FNAME.Text) < 2 Then
            MsgBox("First Name must be atleast 2 characters!", vbInformation, "Error!")
        ElseIf TB_MNAME.Text = "" Then
            MsgBox("Please Input Middle Initial!", vbCritical, "Empty!")
        ElseIf TB_LNAME.Text = "" Then
            MsgBox("Please Input Last Name!", vbCritical, "Empty!")
        ElseIf Len(TB_LNAME.Text) < 2 Then
            MsgBox("Last Name must be atleast 2 characters!", vbInformation, "Error!")
        ElseIf TB_EMAIL.Text = "" Then
            MsgBox("Please Input Email Address!", vbCritical, "Empty!")
        ElseIf TB_CNUM.Text = "" Then
            MsgBox("Please Input Contact Number!", vbCritical, "Empty!")
        ElseIf TB_LOC.Text = "" Then
            MsgBox("Please Input your address/location!", vbCritical, "Empty!")
        ElseIf TB_STUDID.Text = "" Then
            MsgBox("Please Input Student ID!", vbCritical, "Empty!")
        ElseIf Len(TB_STUDID.Text) < 9 Then
            MsgBox("Invalid Student ID!", vbInformation, "Error!")
        ElseIf IDs.Items.Contains(TB_STUDID.Text) Then
            MsgBox("Student ID is already taken!", vbInformation, "Error!")
        ElseIf Not ComboBox1.Text = "Male" Or ComboBox1.Text = "Female" Then
            MsgBox("Not human!", vbInformation, "Error!")

        Else
            Dim userlogin As String = "insert into user_login(username,password)values('" & TB_UN.Text & "','" & TB_PWD.Text & "')"
            Dim userinfo As String = "insert into user_info(status,fname,mname,lname,email,contactnumber,address,stud_id,section,sex)values('User','" & TB_FNAME.Text & "','" & TB_MNAME.Text.ToUpper & "','" & TB_LNAME.Text & "','" & TB_EMAIL.Text & "','" & TB_CNUM.Text & "','" & TB_LOC.Text & "','" & TB_STUDID.Text & "','" & CB_SECTION.Text & "', '" & ComboBox1.Text & "')"

            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = userlogin
            sqlcmd.ExecuteNonQuery()
            sqlcmd.CommandText = userinfo
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()

            MsgBox("Account Successfully Registered!", vbOKOnly, "Success!")

            FRM_LOGIN.TB_UN.Text = TB_UN.Text
            FRM_LOGIN.TB_PWD.Text = TB_PWD.Text
            FRM_LOGIN.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub CB_SECTION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SECTION.SelectedIndexChanged

    End Sub
End Class