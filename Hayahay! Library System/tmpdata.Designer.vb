<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tmpdata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tmpdata))
        Me.uid = New System.Windows.Forms.Label()
        Me.ANIMATED_BOOK_2 = New System.Windows.Forms.PictureBox()
        Me.OKAY_BUTTON = New System.Windows.Forms.PictureBox()
        Me.ANIMATED_WB = New System.Windows.Forms.PictureBox()
        Me.un = New System.Windows.Forms.Label()
        Me.BOOKID = New System.Windows.Forms.Label()
        Me.TEMPCAT = New System.Windows.Forms.Label()
        Me.TEMPCAT2 = New System.Windows.Forms.Label()
        Me.dueday = New System.Windows.Forms.Label()
        Me.duemonth = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.penalty = New System.Windows.Forms.Label()
        Me.COUNT = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        CType(Me.ANIMATED_BOOK_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OKAY_BUTTON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANIMATED_WB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uid
        '
        Me.uid.AutoSize = True
        Me.uid.Location = New System.Drawing.Point(9, 9)
        Me.uid.Name = "uid"
        Me.uid.Size = New System.Drawing.Size(48, 13)
        Me.uid.TabIndex = 0
        Me.uid.Text = "USERID"
        '
        'ANIMATED_BOOK_2
        '
        Me.ANIMATED_BOOK_2.BackColor = System.Drawing.Color.Transparent
        Me.ANIMATED_BOOK_2.Image = CType(resources.GetObject("ANIMATED_BOOK_2.Image"), System.Drawing.Image)
        Me.ANIMATED_BOOK_2.Location = New System.Drawing.Point(377, 110)
        Me.ANIMATED_BOOK_2.Name = "ANIMATED_BOOK_2"
        Me.ANIMATED_BOOK_2.Size = New System.Drawing.Size(127, 113)
        Me.ANIMATED_BOOK_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ANIMATED_BOOK_2.TabIndex = 27
        Me.ANIMATED_BOOK_2.TabStop = False
        '
        'OKAY_BUTTON
        '
        Me.OKAY_BUTTON.BackColor = System.Drawing.Color.Transparent
        Me.OKAY_BUTTON.Image = CType(resources.GetObject("OKAY_BUTTON.Image"), System.Drawing.Image)
        Me.OKAY_BUTTON.Location = New System.Drawing.Point(523, 127)
        Me.OKAY_BUTTON.Name = "OKAY_BUTTON"
        Me.OKAY_BUTTON.Size = New System.Drawing.Size(102, 83)
        Me.OKAY_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OKAY_BUTTON.TabIndex = 28
        Me.OKAY_BUTTON.TabStop = False
        '
        'ANIMATED_WB
        '
        Me.ANIMATED_WB.Image = CType(resources.GetObject("ANIMATED_WB.Image"), System.Drawing.Image)
        Me.ANIMATED_WB.Location = New System.Drawing.Point(523, 25)
        Me.ANIMATED_WB.Name = "ANIMATED_WB"
        Me.ANIMATED_WB.Size = New System.Drawing.Size(102, 86)
        Me.ANIMATED_WB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ANIMATED_WB.TabIndex = 56
        Me.ANIMATED_WB.TabStop = False
        '
        'un
        '
        Me.un.AutoSize = True
        Me.un.Location = New System.Drawing.Point(9, 28)
        Me.un.Name = "un"
        Me.un.Size = New System.Drawing.Size(68, 13)
        Me.un.TabIndex = 57
        Me.un.Text = "USERNAME"
        '
        'BOOKID
        '
        Me.BOOKID.AutoSize = True
        Me.BOOKID.Location = New System.Drawing.Point(21, 56)
        Me.BOOKID.Name = "BOOKID"
        Me.BOOKID.Size = New System.Drawing.Size(0, 13)
        Me.BOOKID.TabIndex = 58
        '
        'TEMPCAT
        '
        Me.TEMPCAT.AutoSize = True
        Me.TEMPCAT.Location = New System.Drawing.Point(77, 56)
        Me.TEMPCAT.Name = "TEMPCAT"
        Me.TEMPCAT.Size = New System.Drawing.Size(0, 13)
        Me.TEMPCAT.TabIndex = 59
        '
        'TEMPCAT2
        '
        Me.TEMPCAT2.AutoSize = True
        Me.TEMPCAT2.Location = New System.Drawing.Point(96, 56)
        Me.TEMPCAT2.Name = "TEMPCAT2"
        Me.TEMPCAT2.Size = New System.Drawing.Size(0, 13)
        Me.TEMPCAT2.TabIndex = 60
        '
        'dueday
        '
        Me.dueday.AutoSize = True
        Me.dueday.Location = New System.Drawing.Point(42, 56)
        Me.dueday.Name = "dueday"
        Me.dueday.Size = New System.Drawing.Size(0, 13)
        Me.dueday.TabIndex = 61
        '
        'duemonth
        '
        Me.duemonth.AutoSize = True
        Me.duemonth.Location = New System.Drawing.Point(96, 56)
        Me.duemonth.Name = "duemonth"
        Me.duemonth.Size = New System.Drawing.Size(0, 13)
        Me.duemonth.TabIndex = 62
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"January", "March", "May", "July", "August", "October", "December"})
        Me.ListBox1.Location = New System.Drawing.Point(125, 9)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 63
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Febuary"})
        Me.ListBox2.Location = New System.Drawing.Point(251, 9)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 64
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Items.AddRange(New Object() {"April", "June", "September", "November"})
        Me.ListBox3.Location = New System.Drawing.Point(377, 9)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 65
        '
        'penalty
        '
        Me.penalty.AutoSize = True
        Me.penalty.Location = New System.Drawing.Point(12, 69)
        Me.penalty.Name = "penalty"
        Me.penalty.Size = New System.Drawing.Size(56, 13)
        Me.penalty.TabIndex = 66
        Me.penalty.Text = "PENALTY"
        '
        'COUNT
        '
        Me.COUNT.AutoSize = True
        Me.COUNT.Location = New System.Drawing.Point(12, 91)
        Me.COUNT.Name = "COUNT"
        Me.COUNT.Size = New System.Drawing.Size(45, 13)
        Me.COUNT.TabIndex = 67
        Me.COUNT.Text = "COUNT"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(12, 110)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(48, 13)
        Me.id.TabIndex = 68
        Me.id.Text = "USERID"
        '
        'tmpdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 304)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.COUNT)
        Me.Controls.Add(Me.penalty)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.duemonth)
        Me.Controls.Add(Me.dueday)
        Me.Controls.Add(Me.TEMPCAT2)
        Me.Controls.Add(Me.TEMPCAT)
        Me.Controls.Add(Me.BOOKID)
        Me.Controls.Add(Me.un)
        Me.Controls.Add(Me.ANIMATED_WB)
        Me.Controls.Add(Me.ANIMATED_BOOK_2)
        Me.Controls.Add(Me.OKAY_BUTTON)
        Me.Controls.Add(Me.uid)
        Me.Name = "tmpdata"
        Me.Text = "tmpdata"
        CType(Me.ANIMATED_BOOK_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OKAY_BUTTON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANIMATED_WB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uid As System.Windows.Forms.Label
    Friend WithEvents ANIMATED_BOOK_2 As System.Windows.Forms.PictureBox
    Friend WithEvents OKAY_BUTTON As System.Windows.Forms.PictureBox
    Friend WithEvents ANIMATED_WB As System.Windows.Forms.PictureBox
    Friend WithEvents un As System.Windows.Forms.Label
    Friend WithEvents BOOKID As System.Windows.Forms.Label
    Friend WithEvents TEMPCAT As System.Windows.Forms.Label
    Friend WithEvents TEMPCAT2 As System.Windows.Forms.Label
    Friend WithEvents dueday As System.Windows.Forms.Label
    Friend WithEvents duemonth As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents penalty As System.Windows.Forms.Label
    Friend WithEvents COUNT As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.Label
End Class
