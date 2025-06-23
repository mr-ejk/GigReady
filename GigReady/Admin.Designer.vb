<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel7 = New Panel()
        PictureBox6 = New PictureBox()
        selectsong = New ComboBox()
        Label2 = New Label()
        del_musicbtn = New Button()
        Panel4 = New Panel()
        PictureBox3 = New PictureBox()
        gig_sched = New DateTimePicker()
        edit_musicbtn = New Button()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        singer = New ComboBox()
        add_musicbtn = New Button()
        Label3 = New Label()
        Panel2 = New Panel()
        delsched_btn = New Button()
        Label4 = New Label()
        Panel6 = New Panel()
        PictureBox5 = New PictureBox()
        TextBox2 = New TextBox()
        Panel5 = New Panel()
        PictureBox4 = New PictureBox()
        TextBox1 = New TextBox()
        save_schedbtn = New Button()
        songlist = New ListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(107, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(240, 228)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(del_musicbtn)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(edit_musicbtn)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(add_musicbtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(23, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(447, 580)
        Panel1.TabIndex = 1
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.Control
        Panel7.Controls.Add(PictureBox6)
        Panel7.Controls.Add(selectsong)
        Panel7.Location = New Point(23, 432)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(402, 67)
        Panel7.TabIndex = 8
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Control
        PictureBox6.BackgroundImageLayout = ImageLayout.None
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(14, 14)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(40, 40)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 7
        PictureBox6.TabStop = False
        ' 
        ' selectsong
        ' 
        selectsong.BackColor = SystemColors.Control
        selectsong.FlatStyle = FlatStyle.Flat
        selectsong.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectsong.ForeColor = Color.DarkGray
        selectsong.FormattingEnabled = True
        selectsong.Location = New Point(64, 18)
        selectsong.Name = "selectsong"
        selectsong.Size = New Size(324, 33)
        selectsong.TabIndex = 6
        selectsong.Text = "Select Song"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(173, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 35)
        Label2.TabIndex = 5
        Label2.Text = "Admin"
        ' 
        ' del_musicbtn
        ' 
        del_musicbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        del_musicbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        del_musicbtn.Location = New Point(301, 513)
        del_musicbtn.Name = "del_musicbtn"
        del_musicbtn.Size = New Size(129, 53)
        del_musicbtn.TabIndex = 4
        del_musicbtn.Text = "Delete Song"
        del_musicbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(gig_sched)
        Panel4.Location = New Point(23, 359)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(402, 67)
        Panel4.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Control
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(14, 14)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' gig_sched
        ' 
        gig_sched.BackColor = SystemColors.Control
        gig_sched.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gig_sched.CalendarMonthBackground = SystemColors.Control
        gig_sched.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        gig_sched.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gig_sched.Location = New Point(60, 17)
        gig_sched.Name = "gig_sched"
        gig_sched.Size = New Size(328, 34)
        gig_sched.TabIndex = 2
        ' 
        ' edit_musicbtn
        ' 
        edit_musicbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        edit_musicbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        edit_musicbtn.Location = New Point(163, 513)
        edit_musicbtn.Name = "edit_musicbtn"
        edit_musicbtn.Size = New Size(124, 53)
        edit_musicbtn.TabIndex = 3
        edit_musicbtn.Text = "Edit Song"
        edit_musicbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(singer)
        Panel3.Location = New Point(23, 284)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(402, 67)
        Panel3.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Control
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(14, 14)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' singer
        ' 
        singer.BackColor = SystemColors.Control
        singer.FlatStyle = FlatStyle.Flat
        singer.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        singer.ForeColor = Color.DarkGray
        singer.FormattingEnabled = True
        singer.Location = New Point(64, 18)
        singer.Name = "singer"
        singer.Size = New Size(324, 33)
        singer.TabIndex = 6
        singer.Text = "Select Song Leader to Schedule"
        ' 
        ' add_musicbtn
        ' 
        add_musicbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        add_musicbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        add_musicbtn.Location = New Point(18, 513)
        add_musicbtn.Name = "add_musicbtn"
        add_musicbtn.Size = New Size(135, 53)
        add_musicbtn.TabIndex = 2
        add_musicbtn.Text = "Add Song"
        add_musicbtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(587, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 46)
        Label3.TabIndex = 7
        Label3.Text = "Schedule Gig"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        Panel2.Controls.Add(delsched_btn)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(save_schedbtn)
        Panel2.Controls.Add(songlist)
        Panel2.Location = New Point(494, 65)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(442, 523)
        Panel2.TabIndex = 8
        ' 
        ' delsched_btn
        ' 
        delsched_btn.BackColor = Color.IndianRed
        delsched_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        delsched_btn.Location = New Point(271, 457)
        delsched_btn.Name = "delsched_btn"
        delsched_btn.Size = New Size(151, 53)
        delsched_btn.TabIndex = 13
        delsched_btn.Text = "Delete Sched"
        delsched_btn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(128, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(206, 29)
        Label4.TabIndex = 9
        Label4.Text = "Scheduled Song"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Control
        Panel6.Controls.Add(PictureBox5)
        Panel6.Controls.Add(TextBox2)
        Panel6.Location = New Point(21, 95)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(401, 67)
        Panel6.TabIndex = 12
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.Control
        PictureBox5.BackgroundImageLayout = ImageLayout.None
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(10, 14)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(40, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Control
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(56, 21)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(335, 27)
        TextBox2.TabIndex = 10
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(TextBox1)
        Panel5.Location = New Point(21, 13)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(401, 67)
        Panel5.TabIndex = 11
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Control
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(10, 14)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(40, 40)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(56, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(335, 27)
        TextBox1.TabIndex = 10
        ' 
        ' save_schedbtn
        ' 
        save_schedbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        save_schedbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        save_schedbtn.Location = New Point(21, 457)
        save_schedbtn.Name = "save_schedbtn"
        save_schedbtn.Size = New Size(142, 53)
        save_schedbtn.TabIndex = 6
        save_schedbtn.Text = "Save Schedule"
        save_schedbtn.UseVisualStyleBackColor = False
        ' 
        ' songlist
        ' 
        songlist.BackColor = SystemColors.Control
        songlist.BorderStyle = BorderStyle.None
        songlist.FormattingEnabled = True
        songlist.Location = New Point(21, 220)
        songlist.Name = "songlist"
        songlist.Size = New Size(401, 220)
        songlist.TabIndex = 9
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 610)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        MinimumSize = New Size(973, 657)
        Name = "Admin"
        Text = "Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents singer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents del_musicbtn As Button
    Friend WithEvents edit_musicbtn As Button
    Friend WithEvents add_musicbtn As Button
    Friend WithEvents gig_sched As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents save_schedbtn As Button
    Friend WithEvents songlist As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents selectsong As ComboBox
    Friend WithEvents delsched_btn As Button
End Class
