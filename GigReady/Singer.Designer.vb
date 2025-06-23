<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Singer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Singer))
        Panel1 = New Panel()
        setlist_btn = New Button()
        user = New TextBox()
        Label2 = New Label()
        del_songbtn = New Button()
        edit_songbtn = New Button()
        add_songbtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        ListOfSongs = New ListBox()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        ComboBox1 = New ComboBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(setlist_btn)
        Panel1.Controls.Add(user)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(del_songbtn)
        Panel1.Controls.Add(edit_songbtn)
        Panel1.Controls.Add(add_songbtn)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(23, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(447, 580)
        Panel1.TabIndex = 0
        ' 
        ' setlist_btn
        ' 
        setlist_btn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        setlist_btn.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        setlist_btn.Location = New Point(18, 444)
        setlist_btn.Name = "setlist_btn"
        setlist_btn.Size = New Size(412, 53)
        setlist_btn.TabIndex = 8
        setlist_btn.Text = "Create a Set List"
        setlist_btn.UseVisualStyleBackColor = False
        ' 
        ' user
        ' 
        user.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        user.BorderStyle = BorderStyle.None
        user.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        user.Location = New Point(136, 329)
        user.Name = "user"
        user.ReadOnly = True
        user.Size = New Size(213, 27)
        user.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(161, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 35)
        Label2.TabIndex = 5
        Label2.Text = "Singer"
        ' 
        ' del_songbtn
        ' 
        del_songbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        del_songbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        del_songbtn.Location = New Point(301, 503)
        del_songbtn.Name = "del_songbtn"
        del_songbtn.Size = New Size(129, 53)
        del_songbtn.TabIndex = 4
        del_songbtn.Text = "Delete Song"
        del_songbtn.UseVisualStyleBackColor = False
        ' 
        ' edit_songbtn
        ' 
        edit_songbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        edit_songbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        edit_songbtn.Location = New Point(163, 503)
        edit_songbtn.Name = "edit_songbtn"
        edit_songbtn.Size = New Size(124, 53)
        edit_songbtn.TabIndex = 3
        edit_songbtn.Text = "Edit Song"
        edit_songbtn.UseVisualStyleBackColor = False
        ' 
        ' add_songbtn
        ' 
        add_songbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        add_songbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        add_songbtn.Location = New Point(18, 503)
        add_songbtn.Name = "add_songbtn"
        add_songbtn.Size = New Size(135, 53)
        add_songbtn.TabIndex = 2
        add_songbtn.Text = "Add Song"
        add_songbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 329)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 29)
        Label1.TabIndex = 1
        Label1.Text = "Welcome"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(93, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(259, 221)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.mang_boy__2_
        PictureBox2.Location = New Point(497, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(446, 256)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Firebrick
        Label3.Location = New Point(639, 276)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 29)
        Label3.TabIndex = 7
        Label3.Text = "List of Songs"
        ' 
        ' ListOfSongs
        ' 
        ListOfSongs.FormattingEnabled = True
        ListOfSongs.Location = New Point(493, 313)
        ListOfSongs.Name = "ListOfSongs"
        ListOfSongs.Size = New Size(450, 284)
        ListOfSongs.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Location = New Point(28, 366)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(402, 67)
        Panel3.TabIndex = 9
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
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.Control
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = Color.DarkGray
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(64, 18)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(324, 33)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Set List"
        ' 
        ' Singer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(955, 610)
        Controls.Add(ListOfSongs)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        MinimumSize = New Size(973, 657)
        Name = "Singer"
        Text = " GigReady | Singer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents del_songbtn As Button
    Friend WithEvents edit_songbtn As Button
    Friend WithEvents add_songbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListOfSongs As ListBox
    Friend WithEvents user As TextBox
    Friend WithEvents setlist_btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
