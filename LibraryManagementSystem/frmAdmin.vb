Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = Session.LoggedInUserName
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub frmAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm1.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        frmUserList.Show()
    End Sub

    Private Sub btnDateCheck_Click(sender As Object, e As EventArgs) Handles btnDateCheck.Click
        frmBorrowingRecord.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
    End Sub
End Class