Imports System.Data.OleDb

Public Class Singer
    Public Shared singerm

    Dim con As New OleDbConnection
    Dim dbprovider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=D:\Download\integDatabase.accdb"
    Private Sub Singer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.Text = singerm
        con.ConnectionString = dbprovider & dbsource
    End Sub

    Private Sub add_musicbtn_Click(sender As Object, e As EventArgs) Handles add_songbtn.Click
        Music.title.Text = "Title"
        Music.lyrics.Text = "Enter Lyrics..."
        Music.title.ForeColor = Color.DarkGray
        Music.lyrics.ForeColor = Color.DarkGray
        Music.Show()
    End Sub

    Private Sub ListOfSongs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListOfSongs.SelectedIndexChanged

    End Sub

    Private Sub setlist_btn_Click(sender As Object, e As EventArgs) Handles setlist_btn.Click

    End Sub
End Class