<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        login_btn = New Button()
        LinkLabel1 = New LinkLabel()
        Panel1 = New Panel()
        showpass = New CheckBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        cancel_btn = New Button()
        Panel3 = New Panel()
        passwrd = New TextBox()
        PictureBox4 = New PictureBox()
        Panel2 = New Panel()
        usrnm = New TextBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        Label1.Font = New Font("Showcard Gothic", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(564, -3)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 83)
        Label1.TabIndex = 1
        Label1.Text = "GigReady"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-68, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(655, 698)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' login_btn
        ' 
        login_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        login_btn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        login_btn.FlatAppearance.BorderColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        login_btn.FlatAppearance.BorderSize = 0
        login_btn.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        login_btn.Location = New Point(35, 447)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(370, 50)
        login_btn.TabIndex = 7
        login_btn.Text = "Log in"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Red
        LinkLabel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(140, 504)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(158, 23)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create an account?"
        ' 
        ' Panel1
        ' 
        Panel1.AccessibleRole = AccessibleRole.None
        Panel1.Anchor = AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(showpass)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(cancel_btn)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(login_btn)
        Panel1.Location = New Point(528, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(429, 608)
        Panel1.TabIndex = 9
        ' 
        ' showpass
        ' 
        showpass.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        showpass.AutoSize = True
        showpass.Location = New Point(35, 420)
        showpass.Name = "showpass"
        showpass.Size = New Size(148, 27)
        showpass.TabIndex = 16
        showpass.Text = "Show Password"
        showpass.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(169, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 41)
        Label3.TabIndex = 13
        Label3.Text = "Log in"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox2.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(230))
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(105, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(229, 210)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' cancel_btn
        ' 
        cancel_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        cancel_btn.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(66))
        cancel_btn.FlatAppearance.BorderSize = 0
        cancel_btn.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancel_btn.Location = New Point(35, 538)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(370, 50)
        cancel_btn.TabIndex = 12
        cancel_btn.Text = "Cancel"
        cancel_btn.UseVisualStyleBackColor = False
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
        PictureBox4.Location = New Point(11, 11)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(45, 45)
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
        PictureBox3.Location = New Point(11, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 45)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        ClientSize = New Size(978, 709)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MinimumSize = New Size(996, 730)
        Name = "Login"
        Text = "GigReady | Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents login_btn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents usrnm As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cancel_btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents passwrd As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents showpass As CheckBox

End Class
