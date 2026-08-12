Public Class frmBorrowingRecord
    Private Sub frmBorrowingRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDBDataSet.BookRecord_Query' table. You can move, or remove it, as needed.
        Me.BookRecord_QueryTableAdapter.Fill(Me.LMSDBDataSet.BookRecord_Query)

    End Sub
End Class