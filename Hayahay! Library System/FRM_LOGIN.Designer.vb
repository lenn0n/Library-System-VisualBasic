<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOGIN))
        Me.TB_UN = New System.Windows.Forms.TextBox()
        Me.TB_PWD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.BTN_LOGIN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EXITBTN = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_SIGNUP = New System.Windows.Forms.Button()
        Me.TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LOADINGPIC = New System.Windows.Forms.PictureBox()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOADINGPIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_UN
        '
        Me.TB_UN.Font = New System.Drawing.Font("Impact", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_UN.Location = New System.Drawing.Point(365, 245)
        Me.TB_UN.Name = "TB_UN"
        Me.TB_UN.Size = New System.Drawing.Size(228, 42)
        Me.TB_UN.TabIndex = 2
        '
        'TB_PWD
        '
        Me.TB_PWD.Font = New System.Drawing.Font("Impact", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PWD.Location = New System.Drawing.Point(365, 299)
        Me.TB_PWD.Name = "TB_PWD"
        Me.TB_PWD.Size = New System.Drawing.Size(228, 42)
        Me.TB_PWD.TabIndex = 3
        Me.TB_PWD.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Forte", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(204, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'LOGO
        '
        Me.LOGO.BackColor = System.Drawing.Color.Transparent
        Me.LOGO.Image = CType(resources.GetObject("LOGO.Image"), System.Drawing.Image)
        Me.LOGO.Location = New System.Drawing.Point(200, 112)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(393, 152)
        Me.LOGO.TabIndex = 6
        Me.LOGO.TabStop = False
        '
        'BTN_LOGIN
        '
        Me.BTN_LOGIN.BackColor = System.Drawing.SystemColors.Control
        Me.BTN_LOGIN.BackgroundImage = CType(resources.GetObject("BTN_LOGIN.BackgroundImage"), System.Drawing.Image)
        Me.BTN_LOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_LOGIN.Location = New System.Drawing.Point(430, 344)
        Me.BTN_LOGIN.Name = "BTN_LOGIN"
        Me.BTN_LOGIN.Size = New System.Drawing.Size(92, 44)
        Me.BTN_LOGIN.TabIndex = 7
        Me.BTN_LOGIN.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(370, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Library System"
        '
        'EXITBTN
        '
        Me.EXITBTN.BackColor = System.Drawing.Color.Transparent
        Me.EXITBTN.BackgroundImage = CType(resources.GetObject("EXITBTN.BackgroundImage"), System.Drawing.Image)
        Me.EXITBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EXITBTN.Location = New System.Drawing.Point(767, 0)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(33, 28)
        Me.EXITBTN.TabIndex = 10
        Me.EXITBTN.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(293, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hayahay! Library System 2016. All rights reserved."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(614, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Need an account?"
        Me.Label5.Visible = False
        '
        'BTN_SIGNUP
        '
        Me.BTN_SIGNUP.BackColor = System.Drawing.SystemColors.Control
        Me.BTN_SIGNUP.BackgroundImage = CType(resources.GetObject("BTN_SIGNUP.BackgroundImage"), System.Drawing.Image)
        Me.BTN_SIGNUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SIGNUP.Location = New System.Drawing.Point(630, 280)
        Me.BTN_SIGNUP.Name = "BTN_SIGNUP"
        Me.BTN_SIGNUP.Size = New System.Drawing.Size(104, 42)
        Me.BTN_SIGNUP.TabIndex = 13
        Me.BTN_SIGNUP.UseVisualStyleBackColor = False
        '
        'TIMER
        '
        Me.TIMER.Interval = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(528, 356)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(10, 23)
        Me.ProgressBar1.TabIndex = 14
        Me.ProgressBar1.Visible = False
        '
        'LOADINGPIC
        '
        Me.LOADINGPIC.Image = CType(resources.GetObject("LOADINGPIC.Image"), System.Drawing.Image)
        Me.LOADINGPIC.Location = New System.Drawing.Point(200, 108)
        Me.LOADINGPIC.Name = "LOADINGPIC"
        Me.LOADINGPIC.Size = New System.Drawing.Size(395, 295)
        Me.LOADINGPIC.TabIndex = 15
        Me.LOADINGPIC.TabStop = False
        '
        'FRM_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 510)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_SIGNUP)
        Me.Controls.Add(Me.EXITBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_LOGIN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_PWD)
        Me.Controls.Add(Me.TB_UN)
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.LOADINGPIC)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_LOGIN"
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOADINGPIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_UN As System.Windows.Forms.TextBox
    Friend WithEvents TB_PWD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_LOGIN As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EXITBTN As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTN_SIGNUP As System.Windows.Forms.Button
    Friend WithEvents TIMER As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LOADINGPIC As System.Windows.Forms.PictureBox
End Class
