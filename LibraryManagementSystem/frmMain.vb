Public Class frmMain
    Private Sub btnBookLocate_Click(sender As Object, e As EventArgs) Handles btnBookLocate.Click
        frmBookLocate.Show()
    End Sub

    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        frmBorrowBook.Show()
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        frmReturnBook.Show()
    End Sub

    Private Sub btnDateCheck_Click(sender As Object, e As EventArgs) Handles btnDateCheck.Click
        frmDateCheck.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUserName.Text = Session.LoggedInUserName
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm1.Show()
    End Sub
End Class
