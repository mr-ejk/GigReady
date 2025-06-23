Imports System.Data.OleDb

Public Class Music
    Dim con As New OleDbConnection
    Dim dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=D:\Download\integDatabase.accdb"
    Private Sub title_GotFocus(sender As Object, e As EventArgs) Handles title.GotFocus
        If title.Text = "Title" Then
            title.Text = ""
            title.ForeColor = Color.DarkGray
        End If
        title.ForeColor = Color.Black
    End Sub

    Private Sub title_LostFocus(sender As Object, e As EventArgs) Handles title.LostFocus
        If title.Text = "" Then
            title.Text = "Title"
            title.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub lyrics_GotFocus(sender As Object, e As EventArgs) Handles lyrics.GotFocus
        If lyrics.Text = "Enter Lyrics..." Then
            lyrics.Text = ""
            lyrics.ForeColor = Color.DarkGray
        End If
        lyrics.ForeColor = Color.Black
    End Sub

    Private Sub lyrics_LostFocus(sender As Object, e As EventArgs) Handles lyrics.LostFocus
        If lyrics.Text = "" Then
            lyrics.Text = "Enter Lyrics..."
            lyrics.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub undobtn_Click(sender As Object, e As EventArgs) Handles undobtn.Click
        lyrics.Undo()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Hide()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        lyrics.Clear()
        lyrics.Text = "Enter Lyrics..."
        lyrics.ForeColor = Color.DarkGray
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If title.Text = "" Then
            MessageBox.Show("Please Enter the Title!")
        Else
            Try
                con.Open()
                Dim cmd As New OleDb.OleDbCommand("INSERT INTO [Song_Table] ([Title], [Lyrics]) VALUES (?, ?)", con)
                cmd.Parameters.AddWithValue("@Title", title.Text.Trim)
                cmd.Parameters.AddWithValue("@Lyrics", lyrics.Text.Trim)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Song created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                con.Close()
            End Try
        End If

    End Sub

    Private Sub Music_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbprovider & dbsource
    End Sub
End Class