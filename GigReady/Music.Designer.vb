<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Music
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Music))
        title = New TextBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lyrics = New RichTextBox()
        PictureBox2 = New PictureBox()
        Panel4 = New Panel()
        closebtn = New Button()
        clearbtn = New Button()
        undobtn = New Button()
        savebtn = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        title.BorderStyle = BorderStyle.None
        title.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.ForeColor = Color.DarkGray
        title.Location = New Point(113, 54)
        title.Name = "title"
        title.Size = New Size(380, 40)
        title.TabIndex = 0
        title.Text = "Title"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(29, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(483, 75)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(244), CByte(194), CByte(32))
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(2, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(69, 70)
        Panel3.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Panel2.Controls.Add(lyrics)
        Panel2.Location = New Point(29, 139)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(483, 345)
        Panel2.TabIndex = 3
        ' 
        ' lyrics
        ' 
        lyrics.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        lyrics.BorderStyle = BorderStyle.None
        lyrics.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lyrics.ForeColor = Color.DarkGray
        lyrics.Location = New Point(84, 15)
        lyrics.Name = "lyrics"
        lyrics.Size = New Size(380, 310)
        lyrics.TabIndex = 1
        lyrics.Text = "Enter Lyrics..."
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 14)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(244), CByte(194), CByte(32))
        Panel4.Controls.Add(closebtn)
        Panel4.Controls.Add(clearbtn)
        Panel4.Controls.Add(undobtn)
        Panel4.Controls.Add(savebtn)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(29, 139)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(69, 345)
        Panel4.TabIndex = 3
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        closebtn.BackgroundImage = CType(resources.GetObject("closebtn.BackgroundImage"), Image)
        closebtn.BackgroundImageLayout = ImageLayout.Stretch
        closebtn.Location = New Point(4, 277)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(60, 60)
        closebtn.TabIndex = 4
        closebtn.TextImageRelation = TextImageRelation.ImageAboveText
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' clearbtn
        ' 
        clearbtn.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        clearbtn.BackgroundImage = CType(resources.GetObject("clearbtn.BackgroundImage"), Image)
        clearbtn.BackgroundImageLayout = ImageLayout.Stretch
        clearbtn.Location = New Point(4, 210)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(60, 60)
        clearbtn.TabIndex = 3
        clearbtn.TextImageRelation = TextImageRelation.ImageAboveText
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' undobtn
        ' 
        undobtn.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        undobtn.BackgroundImage = CType(resources.GetObject("undobtn.BackgroundImage"), Image)
        undobtn.BackgroundImageLayout = ImageLayout.Stretch
        undobtn.Location = New Point(4, 143)
        undobtn.Name = "undobtn"
        undobtn.Size = New Size(60, 60)
        undobtn.TabIndex = 2
        undobtn.TextImageRelation = TextImageRelation.ImageAboveText
        undobtn.UseVisualStyleBackColor = False
        ' 
        ' savebtn
        ' 
        savebtn.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        savebtn.BackgroundImage = CType(resources.GetObject("savebtn.BackgroundImage"), Image)
        savebtn.BackgroundImageLayout = ImageLayout.Stretch
        savebtn.Location = New Point(4, 77)
        savebtn.Name = "savebtn"
        savebtn.Size = New Size(60, 60)
        savebtn.TabIndex = 1
        savebtn.UseVisualStyleBackColor = False
        ' 
        ' Music
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(538, 514)
        Controls.Add(title)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        ImeMode = ImeMode.Off
        MaximumSize = New Size(556, 561)
        Name = "Music"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "GIgReady | Singer | Music"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents title As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lyrics As RichTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents savebtn As Button
    Friend WithEvents undobtn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents clearbtn As Button
End Class
