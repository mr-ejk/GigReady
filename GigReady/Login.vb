Imports System.Data.OleDb

Public Class Login

    Dim con As New OleDbConnection
    Dim dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=D:\Download\IntegDB.accdb"
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Create.Show()
        Me.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If usrnm.Text = "Username" Or passwrd.Text = "Password" Then
            MessageBox.Show("All fields are required!")
        Else
            Try
                con.Open()
                Using cmd As New OleDbCommand("SELECT * FROM [User_Table] WHERE [Username] = ? AND [Password] = ?", con)
                    cmd.Parameters.AddWithValue("@Username", usrnm.Text.Trim)
                    cmd.Parameters.AddWithValue("@Password", passwrd.Text.Trim)

                    Dim ds As New OleDbDataAdapter(cmd)
                    Dim myTable As New DataTable
                    ds.Fill(myTable)

                    If myTable.Rows.Count > 0 Then
                        Dim role As String = myTable.Rows(0)("Role").ToString()
                        Dim message As String = "You have log in successfully. Please click ok to proceed"
                        Dim caption As String = "Success"
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If role = "Admin" Then
                            Dim adminm As New Admin
                            adminm.Show()
                        ElseIf role = "Singer" Then
                            Dim singerm As New Singer
                            Singer.singerm = usrnm.Text
                            singerm.Show()
                        ElseIf role = "Musician" Then
                            Dim musicianm As New Musician
                            musicianm.Show()
                        End If
                    Else
                        MessageBox.Show("Wrong password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        passwrd.UseSystemPasswordChar = False
                        usrnm.Text = "Username"
                        passwrd.Text = "Password"
                        usrnm.ForeColor = Color.DarkGray
                        passwrd.ForeColor = Color.DarkGray

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Wrong password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Dispose()
    End Sub

    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            passwrd.UseSystemPasswordChar = False
        ElseIf passwrd.Text <> "Password" Then
            passwrd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbprovider & dbsource
    End Sub
End Class
