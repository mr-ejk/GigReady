<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Musician
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Musician))
        Panel1 = New Panel()
        Panel7 = New Panel()
        PictureBox6 = New PictureBox()
        selectsong = New ComboBox()
        Label2 = New Label()
        del_musicbtn = New Button()
        edit_musicbtn = New Button()
        add_musicbtn = New Button()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        ComboBox1 = New ComboBox()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(del_musicbtn)
        Panel1.Controls.Add(edit_musicbtn)
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
        Panel7.Location = New Point(18, 413)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(402, 67)
        Panel7.TabIndex = 10
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
        Label2.Location = New Point(152, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 35)
        Label2.TabIndex = 5
        Label2.Text = "Musician"
        ' 
        ' del_musicbtn
        ' 
        del_musicbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        del_musicbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        del_musicbtn.Location = New Point(301, 503)
        del_musicbtn.Name = "del_musicbtn"
        del_musicbtn.Size = New Size(129, 53)
        del_musicbtn.TabIndex = 4
        del_musicbtn.Text = "Delete Chords"
        del_musicbtn.UseVisualStyleBackColor = False
        ' 
        ' edit_musicbtn
        ' 
        edit_musicbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        edit_musicbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        edit_musicbtn.Location = New Point(163, 503)
        edit_musicbtn.Name = "edit_musicbtn"
        edit_musicbtn.Size = New Size(124, 53)
        edit_musicbtn.TabIndex = 3
        edit_musicbtn.Text = "Edit Chords"
        edit_musicbtn.UseVisualStyleBackColor = False
        ' 
        ' add_musicbtn
        ' 
        add_musicbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        add_musicbtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        add_musicbtn.Location = New Point(18, 503)
        add_musicbtn.Name = "add_musicbtn"
        add_musicbtn.Size = New Size(135, 53)
        add_musicbtn.TabIndex = 2
        add_musicbtn.Text = "Add Chords"
        add_musicbtn.UseVisualStyleBackColor = False
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
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Location = New Point(18, 323)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(402, 67)
        Panel3.TabIndex = 10
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
        ComboBox1.Text = "Select Set List"
        ' 
        ' Musician
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 610)
        Controls.Add(Panel1)
        MinimumSize = New Size(973, 657)
        Name = "Musician"
        Text = "Musician"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents del_musicbtn As Button
    Friend WithEvents edit_musicbtn As Button
    Friend WithEvents add_musicbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents selectsong As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
