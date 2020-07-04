<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_REGISTRATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_REGISTRATION))
        Me.TB_UN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_PWD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_RPWD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_FNAME = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_MNAME = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_LNAME = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_EMAIL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_CNUM = New System.Windows.Forms.TextBox()
        Me.TB_LOC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_STUDID = New System.Windows.Forms.TextBox()
        Me.BTN_REG = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_SECTION = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.lblsem = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.Users = New System.Windows.Forms.ListBox()
        Me.IDs = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TB_UN
        '
        Me.TB_UN.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_UN.Location = New System.Drawing.Point(120, 103)
        Me.TB_UN.Name = "TB_UN"
        Me.TB_UN.Size = New System.Drawing.Size(159, 27)
        Me.TB_UN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(36, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(36, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'TB_PWD
        '
        Me.TB_PWD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PWD.Location = New System.Drawing.Point(120, 136)
        Me.TB_PWD.Name = "TB_PWD"
        Me.TB_PWD.Size = New System.Drawing.Size(159, 27)
        Me.TB_PWD.TabIndex = 2
        Me.TB_PWD.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(19, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Retype Pass:"
        '
        'TB_RPWD
        '
        Me.TB_RPWD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_RPWD.Location = New System.Drawing.Point(120, 169)
        Me.TB_RPWD.Name = "TB_RPWD"
        Me.TB_RPWD.Size = New System.Drawing.Size(159, 27)
        Me.TB_RPWD.TabIndex = 4
        Me.TB_RPWD.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(21, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "First Name:"
        '
        'TB_FNAME
        '
        Me.TB_FNAME.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FNAME.Location = New System.Drawing.Point(120, 221)
        Me.TB_FNAME.Name = "TB_FNAME"
        Me.TB_FNAME.Size = New System.Drawing.Size(159, 27)
        Me.TB_FNAME.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(18, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Middle Initial:"
        '
        'TB_MNAME
        '
        Me.TB_MNAME.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_MNAME.Location = New System.Drawing.Point(141, 254)
        Me.TB_MNAME.MaxLength = 1
        Me.TB_MNAME.Name = "TB_MNAME"
        Me.TB_MNAME.Size = New System.Drawing.Size(36, 27)
        Me.TB_MNAME.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(18, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Last Name:"
        '
        'TB_LNAME
        '
        Me.TB_LNAME.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LNAME.Location = New System.Drawing.Point(120, 287)
        Me.TB_LNAME.Name = "TB_LNAME"
        Me.TB_LNAME.Size = New System.Drawing.Size(159, 27)
        Me.TB_LNAME.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Orange
        Me.Label7.Location = New System.Drawing.Point(19, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email Add:"
        '
        'TB_EMAIL
        '
        Me.TB_EMAIL.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EMAIL.Location = New System.Drawing.Point(120, 320)
        Me.TB_EMAIL.Name = "TB_EMAIL"
        Me.TB_EMAIL.Size = New System.Drawing.Size(159, 27)
        Me.TB_EMAIL.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Orange
        Me.Label8.Location = New System.Drawing.Point(15, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Contact Num:"
        '
        'TB_CNUM
        '
        Me.TB_CNUM.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CNUM.Location = New System.Drawing.Point(120, 353)
        Me.TB_CNUM.Name = "TB_CNUM"
        Me.TB_CNUM.Size = New System.Drawing.Size(159, 27)
        Me.TB_CNUM.TabIndex = 14
        '
        'TB_LOC
        '
        Me.TB_LOC.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LOC.Location = New System.Drawing.Point(453, 103)
        Me.TB_LOC.Name = "TB_LOC"
        Me.TB_LOC.Size = New System.Drawing.Size(159, 27)
        Me.TB_LOC.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Location = New System.Drawing.Point(367, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Location:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label10.Location = New System.Drawing.Point(355, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Student ID:"
        '
        'TB_STUDID
        '
        Me.TB_STUDID.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_STUDID.Location = New System.Drawing.Point(453, 142)
        Me.TB_STUDID.MaxLength = 9
        Me.TB_STUDID.Name = "TB_STUDID"
        Me.TB_STUDID.Size = New System.Drawing.Size(159, 27)
        Me.TB_STUDID.TabIndex = 18
        '
        'BTN_REG
        '
        Me.BTN_REG.BackgroundImage = CType(resources.GetObject("BTN_REG.BackgroundImage"), System.Drawing.Image)
        Me.BTN_REG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_REG.Location = New System.Drawing.Point(624, 324)
        Me.BTN_REG.Name = "BTN_REG"
        Me.BTN_REG.Size = New System.Drawing.Size(148, 47)
        Me.BTN_REG.TabIndex = 20
        Me.BTN_REG.Text = " "
        Me.BTN_REG.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(624, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 42)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = " "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Location = New System.Drawing.Point(359, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Semester:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label12.Location = New System.Drawing.Point(378, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Year: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label13.Location = New System.Drawing.Point(378, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label14.Location = New System.Drawing.Point(363, 335)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Section:"
        '
        'CB_SECTION
        '
        Me.CB_SECTION.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CB_SECTION.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SECTION.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CB_SECTION.FormattingEnabled = True
        Me.CB_SECTION.Location = New System.Drawing.Point(439, 332)
        Me.CB_SECTION.Name = "CB_SECTION"
        Me.CB_SECTION.Size = New System.Drawing.Size(121, 28)
        Me.CB_SECTION.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label15.Location = New System.Drawing.Point(16, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(390, 45)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "ACCOUNT REGISTRATION"
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.BackColor = System.Drawing.Color.Transparent
        Me.lblnum.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblnum.Location = New System.Drawing.Point(462, 273)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(16, 26)
        Me.lblnum.TabIndex = 31
        Me.lblnum.Text = " "
        '
        'lblsem
        '
        Me.lblsem.AutoSize = True
        Me.lblsem.BackColor = System.Drawing.Color.Transparent
        Me.lblsem.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsem.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblsem.Location = New System.Drawing.Point(462, 237)
        Me.lblsem.Name = "lblsem"
        Me.lblsem.Size = New System.Drawing.Size(16, 26)
        Me.lblsem.TabIndex = 30
        Me.lblsem.Text = " "
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.BackColor = System.Drawing.Color.Transparent
        Me.lblyear.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblyear.Location = New System.Drawing.Point(462, 200)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(16, 26)
        Me.lblyear.TabIndex = 29
        Me.lblyear.Text = " "
        '
        'Users
        '
        Me.Users.FormattingEnabled = True
        Me.Users.Location = New System.Drawing.Point(744, 12)
        Me.Users.Name = "Users"
        Me.Users.Size = New System.Drawing.Size(10, 4)
        Me.Users.TabIndex = 32
        Me.Users.Visible = False
        '
        'IDs
        '
        Me.IDs.FormattingEnabled = True
        Me.IDs.Location = New System.Drawing.Point(721, 12)
        Me.IDs.Name = "IDs"
        Me.IDs.Size = New System.Drawing.Size(10, 4)
        Me.IDs.TabIndex = 33
        Me.IDs.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ComboBox1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(688, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(84, 28)
        Me.ComboBox1.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label16.Location = New System.Drawing.Point(625, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Sex:"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ComboBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(651, 184)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 36
        Me.ComboBox2.Visible = False
        '
        'FRM_REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 471)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IDs)
        Me.Controls.Add(Me.Users)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.lblsem)
        Me.Controls.Add(Me.lblyear)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CB_SECTION)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_REG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TB_STUDID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TB_LOC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_CNUM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_EMAIL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_LNAME)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_MNAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_FNAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_RPWD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_PWD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_UN)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_REGISTRATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_REGISTRATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_UN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_PWD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_RPWD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_FNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_MNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_LNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_CNUM As System.Windows.Forms.TextBox
    Friend WithEvents TB_LOC As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_STUDID As System.Windows.Forms.TextBox
    Friend WithEvents BTN_REG As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CB_SECTION As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblnum As System.Windows.Forms.Label
    Friend WithEvents lblsem As System.Windows.Forms.Label
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents Users As System.Windows.Forms.ListBox
    Friend WithEvents IDs As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
