Public Class frmUserList
    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LMSDBDataSet.Users)

    End Sub
End Class