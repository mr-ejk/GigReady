<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        sign_inbtn = New Button()
        Panel1 = New Panel()
        Panel5 = New Panel()
        role = New ComboBox()
        role_img = New PictureBox()
        showpass = New CheckBox()
        Panel4 = New Panel()
        cnfrmpss = New TextBox()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Panel3 = New Panel()
        passwrd = New TextBox()
        PictureBox4 = New PictureBox()
        Panel2 = New Panel()
        usrnm = New TextBox()
        PictureBox3 = New PictureBox()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(role_img, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Label1.Font = New Font("Showcard Gothic", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(562, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 83)
        Label1.TabIndex = 10
        Label1.Text = "GigReady"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-79, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(672, 776)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(127, 652)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(178, 20)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already have an account?"
        ' 
        ' sign_inbtn
        ' 
        sign_inbtn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        sign_inbtn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        sign_inbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        sign_inbtn.FlatAppearance.BorderSize = 0
        sign_inbtn.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sign_inbtn.Location = New Point(35, 597)
        sign_inbtn.Name = "sign_inbtn"
        sign_inbtn.Size = New Size(363, 52)
        sign_inbtn.TabIndex = 7
        sign_inbtn.Text = "Sign in"
        sign_inbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.AccessibleRole = AccessibleRole.None
        Panel1.Anchor = AnchorStyles.Right
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(showpass)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(sign_inbtn)
        Panel1.Location = New Point(526, 96)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(429, 690)
        Panel1.TabIndex = 12
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel5.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Panel5.Controls.Add(role)
        Panel5.Controls.Add(role_img)
        Panel5.Location = New Point(35, 530)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(363, 61)
        Panel5.TabIndex = 15
        ' 
        ' role
        ' 
        role.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        role.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        role.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        role.FormattingEnabled = True
        role.Items.AddRange(New Object() {"Singer", "Musician"})
        role.Location = New Point(58, 16)
        role.Name = "role"
        role.Size = New Size(293, 33)
        role.TabIndex = 1
        ' 
        ' role_img
        ' 
        role_img.AccessibleRole = AccessibleRole.None
        role_img.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        role_img.Location = New Point(8, 11)
        role_img.Name = "role_img"
        role_img.Size = New Size(40, 40)
        role_img.SizeMode = PictureBoxSizeMode.StretchImage
        role_img.TabIndex = 0
        role_img.TabStop = False
        ' 
        ' showpass
        ' 
        showpass.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        showpass.AutoSize = True
        showpass.Location = New Point(40, 500)
        showpass.Name = "showpass"
        showpass.Size = New Size(132, 24)
        showpass.TabIndex = 15
        showpass.Text = "Show Password"
        showpass.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel4.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Panel4.Controls.Add(cnfrmpss)
        Panel4.Controls.Add(PictureBox5)
        Panel4.Location = New Point(35, 425)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(363, 67)
        Panel4.TabIndex = 14
        ' 
        ' cnfrmpss
        ' 
        cnfrmpss.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        cnfrmpss.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        cnfrmpss.BorderStyle = BorderStyle.None
        cnfrmpss.Font = New Font("Segoe UI", 10.8F)
        cnfrmpss.ForeColor = Color.DarkGray
        cnfrmpss.Location = New Point(70, 24)
        cnfrmpss.Name = "cnfrmpss"
        cnfrmpss.Size = New Size(276, 24)
        cnfrmpss.TabIndex = 1
        cnfrmpss.Text = "Confirm Password"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(11, 11)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(45, 46)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(159, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 41)
        Label3.TabIndex = 13
        Label3.Text = "Sign in"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox2.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(105, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(229, 210)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        PictureBox2.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(171, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 38)
        Label2.TabIndex = 11
        Label2.Text = "Log in"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel3.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Panel3.Controls.Add(passwrd)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Location = New Point(35, 347)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(363, 67)
        Panel3.TabIndex = 10
        ' 
        ' passwrd
        ' 
        passwrd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        passwrd.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        passwrd.BorderStyle = BorderStyle.None
        passwrd.Font = New Font("Segoe UI", 10.8F)
        passwrd.ForeColor = Color.DarkGray
        passwrd.Location = New Point(70, 22)
        passwrd.Name = "passwrd"
        passwrd.Size = New Size(276, 24)
        passwrd.TabIndex = 1
        passwrd.Text = "Password"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(11, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(45, 46)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel2.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Panel2.Controls.Add(usrnm)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(35, 272)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(363, 67)
        Panel2.TabIndex = 9
        ' 
        ' usrnm
        ' 
        usrnm.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        usrnm.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        usrnm.BorderStyle = BorderStyle.None
        usrnm.Font = New Font("Segoe UI", 10.8F)
        usrnm.ForeColor = Color.DarkGray
        usrnm.Location = New Point(70, 22)
        usrnm.Name = "usrnm"
        usrnm.Size = New Size(276, 24)
        usrnm.TabIndex = 1
        usrnm.Text = "Username"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 46)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Create
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(978, 808)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "Create"
        Text = "GigReady | Sign In"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(role_img, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents sign_inbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents passwrd As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents usrnm As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cnfrmpss As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents showpass As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents role As ComboBox
    Friend WithEvents role_img As PictureBox
End Class
