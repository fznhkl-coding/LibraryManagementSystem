Imports Microsoft.VisualBasic.ApplicationServices


Public Class frmBorrowBook
    Private receiptBorrowDate As Date
    Private receiptDueDate As Date
    Private receiptBook As New List(Of String)

    'Default Variable Declaration
    Dim intBookNo As Integer = 0
    Dim dtTodayDate As Date = DateTime.Today

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmBorrowBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'LMSDBDataSet.BookRecord' table. You can move, or remove it, as needed.
        Me.BookRecordTableAdapter.Fill(Me.LMSDBDataSet.BookRecord)

        'Displaying User info
        lblUserName.Text = Session.LoggedInUserName
        lblUserID.Text = Session.LoggedInUserID
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Variable declaration
        Dim strBookTitle As String

        'Data initialization
        strBookTitle = txtBookTitle.Text

        'Placing data on ListBox
        lbxBookList.Items.Add(strBookTitle)

        'Update Book Number
        intBookNo += 1
        lblBookNo.Text = intBookNo.ToString()

        'Clear textbox
        txtBookTitle.Text = ""
    End Sub

    Private Sub BookRecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BookRecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDBDataSet)

    End Sub

    Private Sub BookRecordBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BookRecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDBDataSet)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If lbxBookList.Items.Count = 0 Then
            MessageBox.Show("No books added to borrow list")
            Exit Sub
        End If

        Dim dt As New LMSDBDataSet.BookRecordDataTable

        'loop through each book in lbxBookList
        For Each item As Object In lbxBookList.Items
            BookRecordTableAdapter.InsertBorrowedBook(item.ToString(), Date.Today, "Borrowing", Session.LoggedInUserID)
        Next

        MessageBox.Show("Books borrow succesfully")

        'record receipt info
        receiptBorrowDate = Date.Today
        receiptDueDate = receiptBorrowDate.AddDays(14)
        receiptBook.Clear()

        For Each item As Object In lbxBookList.Items
            receiptBook.Add(item.ToString())
        Next

        'Show print preview
        ppdBorrowReceipt.ShowDialog()

        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lbxBookList.Items.Remove(lbxBookList.SelectedItem)
        intBookNo -= 1
        lblBookNo.Text = intBookNo.ToString()
    End Sub

    Private Sub pdBorrowReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdBorrowReceipt.PrintPage
        Dim g As Graphics = e.Graphics

        'Fonts
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim normalFont As New Font("Arial", 10)

        Dim y As Integer = 40

        'Title
        g.DrawString("Library Borrow Receipt", titleFont, Brushes.Black, 200, y)
        y += 40

        'User info
        g.DrawString("User ID: " & Session.LoggedInUserID, normalFont, Brushes.Black, 40, y)
        y += 20
        g.DrawString("User Name: " & Session.LoggedInUserName, normalFont, Brushes.Black, 40, y)
        y += 20

        'Dates
        g.DrawString("Borrow Date: " & receiptBorrowDate.ToShortDateString(), normalFont, Brushes.Black, 40, y)
        y += 20
        g.DrawString("Due Date: " & receiptDueDate.ToShortDateString(), normalFont, Brushes.Black, 40, y)
        y += 30

        'Books header
        g.DrawString("Borrowed Books:", headerFont, Brushes.Black, 40, y)
        y += 20

        'Book list
        For Each book As String In receiptBook
            g.DrawString("- " & book, normalFont, Brushes.Black, 60, y)
            y += 18
        Next

        y += 20
        g.DrawString("Please return books within 14 days to avoid late fees.", normalFont, Brushes.Black, 40, y)
    End Sub
End Class