Public Class FRM_MAIN


    Private Sub FRM_MAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        hideitems()
        ComboBox1.SelectedIndex = 1
        ComboBox2.SelectedIndex = 0
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from user_info where uid='" & tmpdata.uid.Text & "'"
        sqldr = sqlcmd.ExecuteReader

        While sqldr.Read
            Label2.Text = sqldr("fname") + " " + sqldr("mname") + ". " + sqldr("lname")
            Label6.Text = sqldr("stud_id")
            Label7.Text = sqldr("section")
            Label16.Text = sqldr("sex")
            Label17.Text = sqldr("stud_id")
            Label18.Text = sqldr("fname") + " " + sqldr("mname") + ". " + sqldr("lname")
            Label19.Text = sqldr("section")
            Label20.Text = sqldr("email")
            Label21.Text = sqldr("contactnumber")
            Label22.Text = sqldr("address")
            Label23.Text = sqldr("status")

            If sqldr("status") = "Admin" Then
                CP_BOOKS.Show()
                Button5.Show()
            Else
                CP_BOOKS.Hide()
                Button5.Hide()
            End If
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()

        ComboBox3.SelectedIndex = 0
        CB_SECTION.Items.Clear()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from user_section"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            CB_SECTION.Items.Add(sqldr("course"))
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


    Private Sub MB_LOGOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MB_LOGOUT.Click
        Dim ans = MsgBox("Are you sure you want to LOGOUT?", vbYesNo, "Account Logout")
        If ans = vbYes Then
            Application.Restart()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub EXT_MAIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXT_MAIN.Click
        Dim ans = MsgBox("Are you sure you want to exit?", vbYesNo, "Exit Application")
        If ans = vbYes Then
            tmpdata.systemexit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub SEARCH_QUERY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SEARCH_QUERY.Click
        SEARCH_QUERY.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label8.Text = Date.Now.ToString("dddd, dd MMMM yyyy, hh:mm:ss")
    End Sub

    Sub hideitems()
        BTN_BORROW.Hide()
        BTN_RETURN.Hide()
        VIEWER.Hide()
        Panel2.Hide()
        tmpdata.BOOKID.Text = ""
        tmpdata.id.Text = ""
        confirmation.Hide()
        MANAGE_BOOKS.Hide()
        ADMIN_USERS.Hide()


    End Sub

    Private Sub MB_BORROW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MB_BORROW.Click
        hideitems()
        BTN_BORROW.Show()
        VIEWER.Show()
        bookcolumns()
        availablebooks()
    End Sub

    Private Sub BTN_BORROW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BORROW.Click
        If tmpdata.BOOKID.Text = "" Then
            MsgBox("Please select book to proceed!")
        Else
            
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select * from books where bookid='" & tmpdata.BOOKID.Text & "'"
                sqldr = sqlcmd.ExecuteReader
                While sqldr.Read
                    tmpdata.dueday.Text = sqldr("dueday")
                    tmpdata.duemonth.Text = sqldr("duemonth")
                    title.Text = sqldr("bookname")
                    author.Text = sqldr("bookauthor")
                    category.Text = sqldr("bookcat")
                    yearpub.Text = sqldr("bookyear")
                End While
                sqldr.Close()
                sqlcmd.Dispose()
                sqlcon.Close()
                sqlcon.Open()

                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "update books set av=0, holder='" & tmpdata.un.Text & "', dueday='" & Date.Now.ToString("dd") & "', duemonth='" & Date.Now.ToString("MMMM") & "' where bookid='" & tmpdata.BOOKID.Text & "'"
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()
                sqlcon.Close()
                sqlcon.Open()
                confirmation.Show()
                status_borrow.Show()
                status_return.Hide()
                status_foot.Text = "You will get penalty if you didn't this book within 2 days."
                tmpdata.BOOKID.Text = ""
                availablebooks()

        End If
    End Sub

    Private Sub MB_RETURN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MB_RETURN.Click
        hideitems()
        BTN_RETURN.Show()
        VIEWER.Show()
        bookcolumns()
        notavailablebooks()
    End Sub

    Sub bookcolumns()
        VIEWER.Columns.Clear()
        VIEWER.Columns.Add("ID", CInt(VIEWER.Width / 131313))
        VIEWER.Columns.Add("Title", CInt(VIEWER.Width / 3))
        VIEWER.Columns.Add("Author", CInt(VIEWER.Width / 3.5))
        VIEWER.Columns.Add("Category", CInt(VIEWER.Width / 5))
        VIEWER.Columns.Add("Date Published", CInt(VIEWER.Width / 5))
    End Sub

    Sub availablebooks()
        VIEWER.Items.Clear()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from books where av=1"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            Dim books As ListViewItem
            books = VIEWER.Items.Add(sqldr("bookid"))
            books.SubItems.Add(sqldr("bookname"))
            books.SubItems.Add(sqldr("bookauthor"))
            books.SubItems.Add(sqldr("bookcat"))
            books.SubItems.Add(sqldr("bookyear"))
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()
    End Sub

    Sub notavailablebooks()
        sqlcmd.Dispose()
        sqlcon.Close()
        sqlcon.Open()
        VIEWER.Items.Clear()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from books where av=0 and holder='" & tmpdata.un.Text & "'"
        sqldr = sqlcmd.ExecuteReader
        While (sqldr.Read)
            Dim nbooks As ListViewItem
            nbooks = VIEWER.Items.Add(sqldr("bookid"))
            nbooks.SubItems.Add(sqldr("bookname"))
            nbooks.SubItems.Add(sqldr("bookauthor"))
            nbooks.SubItems.Add(sqldr("bookcat"))
            nbooks.SubItems.Add(sqldr("bookyear"))
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()
    End Sub

    Private Sub VIEWER_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles VIEWER.ItemSelectionChanged
        tmpdata.BOOKID.Text = e.Item.Text
    End Sub

    Private Sub BTN_RETURN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_RETURN.Click

        If tmpdata.BOOKID.Text = "" Then
            MsgBox("Please select book to proceed!")
            Exit Sub
        Else
            Dim ans = MsgBox("Are you sure you want to return this book?", vbYesNo, "Return Book?")
            If ans = vbYes Then

                Dim process As String = "update books set av=1, holder='0', dueday='0', duemonth='0' where bookid='" & tmpdata.BOOKID.Text & "'"

                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select * from books where bookid='" & tmpdata.BOOKID.Text & "'"
                sqldr = sqlcmd.ExecuteReader
                While sqldr.Read
                    tmpdata.dueday.Text = sqldr("dueday")
                    tmpdata.duemonth.Text = sqldr("duemonth")
                    title.Text = sqldr("bookname")
                    author.Text = sqldr("bookauthor")
                    category.Text = sqldr("bookcat")
                    yearpub.Text = sqldr("bookyear")
                End While
                sqldr.Close()
                sqlcmd.Dispose()
                sqlcon.Close()

                Dim dueday As Integer = tmpdata.dueday.Text
                Dim duemonth As String = tmpdata.duemonth.Text
                Dim daytoday As Integer = Date.Now.ToString("dd")
                If Mid(daytoday, 1, 1) = 0 Then
                    daytoday = Mid(daytoday, 2, 1)
                End If
                If dueday <= daytoday Then
                    Dim calc As Integer = daytoday - dueday
                    If calc = 0 Then
                        confirmation.Show()
                        status_borrow.Hide()
                        status_return.Show()
                        status_foot.Text = "You borrowed this book today. No penalty was charged."
                        sqlcon.Open()
                        sqlcmd.Connection = sqlcon
                        sqlcmd.CommandText = process
                        sqlcmd.ExecuteNonQuery()
                        sqlcmd.Dispose()
                        sqlcon.Close()
                        sqlcon.Open()
                        notavailablebooks()
                        tmpdata.BOOKID.Text = ""
                        Exit Sub
                    ElseIf calc = 1 Then
                        confirmation.Show()
                        status_borrow.Hide()
                        status_return.Show()
                        status_foot.Text = "You borrowed this book yesterday. No penalty was charged."
                        sqlcon.Open()
                        sqlcmd.Connection = sqlcon
                        sqlcmd.CommandText = process
                        sqlcmd.ExecuteNonQuery()
                        sqlcmd.Dispose()
                        sqlcon.Close()
                        sqlcon.Open()
                        notavailablebooks()
                        tmpdata.BOOKID.Text = ""
                        Exit Sub
                    ElseIf calc = 2 Then
                        confirmation.Show()
                        status_borrow.Hide()
                        status_return.Show()
                        status_foot.Text = "You borrowed this book two days ago. No penalty was charged."
                        sqlcon.Open()
                        sqlcmd.Connection = sqlcon
                        sqlcmd.CommandText = process
                        sqlcmd.ExecuteNonQuery()
                        sqlcmd.Dispose()
                        sqlcon.Close()
                        sqlcon.Open()
                        notavailablebooks()
                        tmpdata.BOOKID.Text = ""
                        Exit Sub
                    End If

                    Dim penalty As Integer
                    Dim dayscount As Integer

                    For c = 3 To calc
                        penalty = penalty + 10
                        dayscount = dayscount + 1
                        If calc = c Then
                            tmpdata.penalty.Text = penalty
                            tmpdata.COUNT.Text = dayscount
                        End If

                    Next c

                    FRM_PAY.Show()
                    Exit Sub
                Else
                    Dim monthdue As Integer
                    If tmpdata.ListBox1.Items.Contains(duemonth) Then
                        monthdue = 31
                    End If
                    If tmpdata.ListBox2.Items.Contains(duemonth) Then
                        monthdue = 28
                    End If
                    If tmpdata.ListBox3.Items.Contains(duemonth) Then
                        monthdue = 30
                    End If

                    Dim submonth As Integer = monthdue - dueday
                    Dim calc2 As Integer = submonth + daytoday

                    If calc2 = 1 Then
                        confirmation.Show()
                        status_borrow.Hide()
                        status_return.Show()
                        status_foot.Text = "You borrowed this book yesterday. No penalty was charged."
                        sqlcon.Open()
                        sqlcmd.Connection = sqlcon
                        sqlcmd.CommandText = process
                        sqlcmd.ExecuteNonQuery()
                        sqlcmd.Dispose()
                        sqlcon.Close()
                        sqlcon.Open()
                        notavailablebooks()
                        tmpdata.BOOKID.Text = ""
                        Exit Sub
                    ElseIf calc2 = 2 Then
                        confirmation.Show()
                        status_borrow.Hide()
                        status_return.Show()
                        status_foot.Text = "You borrowed this book two days ago. No penalty was charged."
                        sqlcon.Open()
                        sqlcmd.Connection = sqlcon
                        sqlcmd.CommandText = process
                        sqlcmd.ExecuteNonQuery()
                        sqlcmd.Dispose()
                        sqlcon.Close()
                        sqlcon.Open()
                        notavailablebooks()
                        tmpdata.BOOKID.Text = ""
                        Exit Sub
                    End If

                    Dim penalty2 As Integer
                    Dim dayscount2 As Integer

                    For a = 3 To calc2
                        penalty2 = penalty2 + 10
                        dayscount2 = dayscount2 + 1
                        If calc2 = a Then
                            tmpdata.penalty.Text = penalty2
                            tmpdata.COUNT.Text = dayscount2
                        End If

                    Next a

                    FRM_PAY.Show()
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub MB_PROFILE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MB_PROFILE.Click
        hideitems()
        Panel2.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        hideitems()
        VIEWER.Show()
        bookcolumns()
        If ComboBox2.SelectedIndex = 0 Then
            tmpdata.TEMPCAT.Text = "bookname"
        ElseIf ComboBox2.SelectedIndex = 1 Then
            tmpdata.TEMPCAT.Text = "bookauthor"
        ElseIf ComboBox2.SelectedIndex = 2 Then
            tmpdata.TEMPCAT.Text = "bookcat"
        End If

        Dim go As String = ""
        If ComboBox1.SelectedIndex = 0 Then
            go = "select * from books where " & tmpdata.TEMPCAT.Text & " like '%" & SEARCH_QUERY.Text & "%' and av='" & ComboBox1.SelectedIndex & "' and holder='" & tmpdata.un.Text & "'"
        Else
            go = "select * from books where " & tmpdata.TEMPCAT.Text & " like '%" & SEARCH_QUERY.Text & "%' and av='" & ComboBox1.SelectedIndex & "'"
        End If

        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = go
        sqldr = sqlcmd.ExecuteReader

        VIEWER.Items.Clear()
        While sqldr.Read
            Dim books As ListViewItem
            books = VIEWER.Items.Add(sqldr("bookid"))
            books.SubItems.Add(sqldr("bookname"))
            books.SubItems.Add(sqldr("bookauthor"))
            books.SubItems.Add(sqldr("bookcat"))
            books.SubItems.Add(sqldr("bookyear"))
        End While
        If ComboBox1.SelectedIndex = 0 Then
            BTN_RETURN.Show()
            BTN_BORROW.Hide()
        Else
            BTN_BORROW.Show()
            BTN_RETURN.Hide()
        End If
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()
    End Sub

    Private Sub SEARCH_QUERY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH_QUERY.TextChanged
        hideitems()
        VIEWER.Show()
        bookcolumns()
        If ComboBox2.SelectedIndex = 0 Then
            tmpdata.TEMPCAT.Text = "bookname"
        ElseIf ComboBox2.SelectedIndex = 1 Then
            tmpdata.TEMPCAT.Text = "bookauthor"
        ElseIf ComboBox2.SelectedIndex = 2 Then
            tmpdata.TEMPCAT.Text = "bookcat"
        End If

        Dim go As String = ""
        If ComboBox1.SelectedIndex = 0 Then
            go = "select * from books where " & tmpdata.TEMPCAT.Text & " like '%" & SEARCH_QUERY.Text & "%' and av='" & ComboBox1.SelectedIndex & "' and holder='" & tmpdata.un.Text & "'"
        Else
            go = "select * from books where " & tmpdata.TEMPCAT.Text & " like '%" & SEARCH_QUERY.Text & "%' and av='" & ComboBox1.SelectedIndex & "'"
        End If

        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = go
        sqldr = sqlcmd.ExecuteReader

        VIEWER.Items.Clear()
        While sqldr.Read
            Dim books As ListViewItem
            books = VIEWER.Items.Add(sqldr("bookid"))
            books.SubItems.Add(sqldr("bookname"))
            books.SubItems.Add(sqldr("bookauthor"))
            books.SubItems.Add(sqldr("bookcat"))
            books.SubItems.Add(sqldr("bookyear"))
        End While
        If ComboBox1.SelectedIndex = 0 Then
            BTN_RETURN.Show()
            BTN_BORROW.Hide()
        Else
            BTN_BORROW.Show()
            BTN_RETURN.Hide()
        End If
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()
    End Sub

    Private Sub OKAY_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKAY_BUTTON.Click
        confirmation.Hide()
    End Sub

    Private Sub CB_BCAT_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MANAGE_BOOKS.Paint

    End Sub

    Private Sub CP_BOOKS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP_BOOKS.Click
        hideitems()
        MANAGE_BOOKS.Show()

        ADMIN_VIEWER.Columns.Clear()
        ADMIN_VIEWER.Columns.Add("ID", CInt(ADMIN_VIEWER.Width / 131313))
        ADMIN_VIEWER.Columns.Add("Title", CInt(ADMIN_VIEWER.Width / 2))
        ADMIN_VIEWER.Columns.Add("Status", CInt(ADMIN_VIEWER.Width / 3))
        ADMIN_VIEWER.Columns.Add("Author", CInt(ADMIN_VIEWER.Width / 3))

        books()
    End Sub



    Private Sub ADMIN_VIEWER_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ADMIN_VIEWER.ItemSelectionChanged
        tmpdata.BOOKID.Text = e.Item.Text
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from books where bookid='" & e.Item.Text & "'"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            TB_BNAME.Text = sqldr("bookname")
            TB_BAUTHOR.Text = sqldr("bookauthor")
            TB_BYEAR.Text = sqldr("bookyear")
            CB_BCAT.Text() = sqldr("bookcat")
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()
    End Sub

    Sub books()
        ADMIN_VIEWER.Items.Clear()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from books"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            Dim books As ListViewItem
            books = ADMIN_VIEWER.Items.Add(sqldr("bookid"))
            books.SubItems.Add(sqldr("bookname"))
            If sqldr("av") = 1 Then
                books.SubItems.Add("Available")
            End If
            If sqldr("av") = 0 Then
                books.SubItems.Add("Borrowed By " + sqldr("holder"))
            End If
            books.SubItems.Add(sqldr("bookauthor"))
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()
    End Sub

    Private Sub BTN_ADDBOOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ADDBOOK.Click
        Dim ans = MsgBox("Are you sure you want to add this book?", vbYesNo, "Add Book")
        If ans = vbYes Then
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "insert into books(bookname,bookauthor,bookyear,bookcat,av)values('" & TB_BNAME.Text & "', '" & TB_BAUTHOR.Text & "', '" & TB_BYEAR.Text & "', '" & CB_BCAT.Text & "', '1')"
            sqlcmd.ExecuteNonQuery()
            MsgBox("The book was added!")
            TB_BNAME.Text = ""
            TB_BAUTHOR.Text = ""
            TB_BYEAR.Text = ""
            sqlcmd.Dispose()
            sqlcon.Close()
            sqlcon.Open()
            books()

        Else

            Exit Sub
        End If
    End Sub

    Private Sub BTN_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_UPDATE.Click
        If tmpdata.BOOKID.Text = "" Then
            MsgBox("Please select book to edit!")
            Exit Sub
        Else
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "update books set bookname='" & TB_BNAME.Text & "', bookauthor='" & TB_BAUTHOR.Text & "', bookyear='" & TB_BYEAR.Text & "', bookcat='" & CB_BCAT.Text & "' where bookid='" & tmpdata.BOOKID.Text & "'"
            sqlcmd.ExecuteNonQuery()
            tmpdata.BOOKID.Text = ""
            MsgBox("The book was updated!")
            TB_BNAME.Text = ""
            TB_BAUTHOR.Text = ""
            TB_BYEAR.Text = ""
            sqlcmd.Dispose()
            sqlcon.Close()
            sqlcon.Open()
            books()
        End If
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ANS = MsgBox("Do you want to add this user?", vbYesNo, "ADD ACCOUNT")
        If ANS = vbYes Then
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
            Else
                Dim userlogin As String = "insert into user_login(username,password)values('" & TB_UN.Text & "','" & TB_PWD.Text & "')"
                Dim userinfo As String = "insert into user_info(status,fname,mname,lname,email,contactnumber,address,stud_id,section,sex)values('User','" & TB_FNAME.Text & "','" & TB_MNAME.Text.ToUpper & "','" & TB_LNAME.Text & "','" & TB_EMAIL.Text & "','" & TB_CNUM.Text & "','" & TB_LOC.Text & "','" & TB_STUDID.Text & "','" & CB_SECTION.Text & "', '" & ComboBox3.Text & "')"

                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = userlogin
                sqlcmd.ExecuteNonQuery()
                sqlcmd.CommandText = userinfo
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()

                MsgBox("UserSuccessfully Added!", vbOKOnly, "Success!")
                TB_FNAME.Text = ""
                TB_MNAME.Text = ""
                TB_LNAME.Text = ""
                TB_EMAIL.Text = ""
                TB_CNUM.Text = ""
                TB_LOC.Text = ""
                ComboBox4.Text = ""
                TB_STUDID.Text = ""
                CB_SECTION.Text = ""
                ComboBox3.Text = ""
                TB_UN.Text = ""
                TB_PWD.Text = ""
                TB_RPWD.Text = ""

            End If
        Else
            Exit Sub
        End If

    End Sub
    Sub userlist()
        ListView1.Items.Clear()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from user_info"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            Dim users As ListViewItem
            users = ListView1.Items.Add(sqldr("uid"))
            users.SubItems.Add(sqldr("fname") + " " + sqldr("mname") + "  " + sqldr("lname"))
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()

    End Sub

    Private Sub ListView1_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        tmpdata.id.Text = e.Item.Text
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from user_login where uid='" & e.Item.Text & "'"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            TB_UN.Text = sqldr("username")
            TB_PWD.Text = sqldr("password")
            TB_RPWD.Text = sqldr("password")
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from user_info where uid='" & e.Item.Text & "'"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            TB_FNAME.Text = sqldr("fname")
            TB_MNAME.Text = sqldr("mname")
            TB_LNAME.Text = sqldr("lname")
            TB_EMAIL.Text = sqldr("email")
            TB_CNUM.Text = sqldr("contactnumber")
            TB_LOC.Text = sqldr("address")
            ComboBox4.Text = sqldr("status")
            TB_STUDID.Text = sqldr("stud_id")
            CB_SECTION.Text = sqldr("section")
            ComboBox3.Text = sqldr("sex")
        End While
        sqlcmd.Dispose()
        sqldr.Close()
        sqlcon.Close()
        sqlcon.Open()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        hideitems()
        ADMIN_USERS.Show()
        ListView1.Columns.Clear()
        ComboBox4.SelectedIndex = 0
        ListView1.Columns.Add("ID", CInt(ListView1.Width / 212121))
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 1))
        userlist()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If tmpdata.id.Text = "" Then
            MsgBox("Please select user to edit!")
            Exit Sub
        Else
            Dim userlogin As String = "update user_login set username='" & TB_UN.Text & "', password='" & TB_PWD.Text & "' where uid='" & tmpdata.id.Text & "'"
            Dim userinfo As String = "update user_info set status='" & ComboBox4.Text & "', fname='" & TB_FNAME.Text & "', mname='" & TB_MNAME.Text & "', lname='" & TB_LNAME.Text & "', email='" & TB_EMAIL.Text & "', contactnumber='" & TB_CNUM.Text & "', address='" & TB_LOC.Text & "', stud_id='" & TB_STUDID.Text & "', section='" & CB_SECTION.Text & "', sex='" & ComboBox3.Text & "' where uid='" & tmpdata.id.Text & "'"

            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = userlogin
            sqlcmd.ExecuteNonQuery()
            sqlcmd.CommandText = userinfo
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            userlist()
            MsgBox("Account Successfully Edited!", vbOKOnly, "Success!")
            tmpdata.id.Text = ""
            TB_FNAME.Text = ""
            TB_MNAME.Text = ""
            TB_LNAME.Text = ""
            TB_EMAIL.Text = ""
            TB_CNUM.Text = ""
            TB_LOC.Text = ""
            ComboBox4.Text = ""
            TB_STUDID.Text = ""
            CB_SECTION.Text = ""
            ComboBox3.Text = ""
            TB_UN.Text = ""
            TB_PWD.Text = ""
            TB_RPWD.Text = ""

        End If

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tmpdata.BOOKID.Text = "" Then
            MsgBox("Please select book to print!")
        Else
            SINGLE_REPORT.Show()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BOOKS_MASTERLIST.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        USERS_MASTERLIST.Show()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub VIEWER_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWER.SelectedIndexChanged

    End Sub
End Class