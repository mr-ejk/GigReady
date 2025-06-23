Imports System.Data.OleDb

Public Class Create

    Dim con As New OleDbConnection
    Dim dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=D:\Download\integDatabase.accdb"

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Dispose()
    End Sub
    Private Sub usrnm_GotFocus(sender As Object, e As EventArgs) Handles usrnm.GotFocus
        If usrnm.Text = "Username" Then
            usrnm.Text = ""
            usrnm.ForeColor = Color.DarkGray
        End If
        usrnm.ForeColor = Color.Black
    End Sub

    Private Sub usrnm_LostFocus(sender As Object, e As EventArgs) Handles usrnm.LostFocus
        If usrnm.Text = "" Then
            usrnm.Text = "Username"
            usrnm.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub passwrd_GotFocus(sender As Object, e As EventArgs) Handles passwrd.GotFocus
        If showpass.Checked = True Then
            passwrd.UseSystemPasswordChar = False
        Else
            passwrd.UseSystemPasswordChar = True
        End If
        If passwrd.Text = "Password" Then
            passwrd.Text = ""
            passwrd.ForeColor = Color.DarkGray
        End If
        passwrd.ForeColor = Color.Black
        If showpass.Checked = True Then
            passwrd.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub passwrd_LostFocus(sender As Object, e As EventArgs) Handles passwrd.LostFocus
        If passwrd.Text = "" Then
            passwrd.Text = "Password"
            passwrd.UseSystemPasswordChar = False
            passwrd.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub cnfrmpss_GotFocus(sender As Object, e As EventArgs) Handles cnfrmpss.GotFocus
        If showpass.Checked = True Then
            cnfrmpss.UseSystemPasswordChar = False
        Else
            cnfrmpss.UseSystemPasswordChar = True
        End If
        If cnfrmpss.Text = "Confirm Password" Then
            cnfrmpss.Text = ""
            cnfrmpss.ForeColor = Color.DarkGray
        End If
        cnfrmpss.ForeColor = Color.Black
    End Sub
    Private Sub cnfrmpss_LostFocus(sender As Object, e As EventArgs) Handles cnfrmpss.LostFocus
        If cnfrmpss.Text = "" Then
            cnfrmpss.Text = "Confirm Password"
            cnfrmpss.UseSystemPasswordChar = False
            cnfrmpss.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            passwrd.UseSystemPasswordChar = False
            cnfrmpss.UseSystemPasswordChar = False
        ElseIf passwrd.Text <> "Password" Then
            passwrd.UseSystemPasswordChar = True
            If cnfrmpss.Text <> "Confirm Password" Then
                cnfrmpss.UseSystemPasswordChar = True

            End If

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles role.SelectedIndexChanged
        If role.SelectedItem.Equals("Singer") Then
            role_img.Image = Image.FromFile("D:\Download\singer_icon.png")
        ElseIf role.SelectedItem.Equals("Musician") Then
            role_img.Image = Image.FromFile("D:\Download\musician_icon.png")
        End If
    End Sub



    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbprovider & dbsource

    End Sub

    Private Sub sign_inbtn_Click(sender As Object, e As EventArgs) Handles sign_inbtn.Click
        If usrnm.Text = "Username" Or passwrd.Text = "Password" Or cnfrmpss.Text = "Confirm Password" Then
            MessageBox.Show("All fields are required!")
        Else
            If passwrd.Text <> cnfrmpss.Text Then
                MessageBox.Show("Password don't match")
            Else
                Try
                    con.Open()
                    Dim cmd As New OleDb.OleDbCommand("INSERT INTO [User] ([Username], [Password], [Role]) VALUES (?, ?, ?)", con)
                    cmd.Parameters.AddWithValue("@Username", usrnm.Text.Trim)
                    cmd.Parameters.AddWithValue("@Password", passwrd.Text.Trim)
                    cmd.Parameters.AddWithValue("@Role", role.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Login.Show()
                Catch ex As Exception
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub
End Class