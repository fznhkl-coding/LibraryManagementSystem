Imports LibraryManagementSystem.LMSDBDataSetTableAdapters

Public Class frmReturnBook

    Private receiptItems As New List(Of ReturnReceiptItem)
    Private totalLateFee As Decimal = 0

    Private Class ReturnReceiptItem
        Public BookTitle As String
        Public BorrowDate As Date
        Public DueDate As Date
        Public ReturnedDate As Date
        Public DayDiff As Integer
        Public LateFee As Decimal
    End Class


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDBDataSet.BookRecord' table. You can move, or remove it, as needed.
        Me.BookRecordTableAdapter.Fill(Me.LMSDBDataSet.BookRecord)

        lblUserName.Text = Session.LoggedInUserName
        lblUserID.Text = Session.LoggedInUserID

        'set datatable
        Dim dt As New LMSDBDataSet.BookRecordDataTable
        BookRecordTableAdapter.Fill(dt)

        'Load Book list to lbxBookList
        Dim filter As String = "userID='" & Session.LoggedInUserID & "' AND BorrowStatus='Borrowing'"
        'filter rows using Select() method of database
        Dim FilteredRows() As DataRow = dt.Select(filter)
        If FilteredRows.Count <> 0 Then
            For Each row As DataRow In FilteredRows
                lbxBookList.Items.Add(row("BookTitle"))
            Next
        Else
            MessageBox.Show("No Borrowing books recorrded")
        End If
    End Sub

    Private Sub BookRecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BookRecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDBDataSet)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For i As Integer = lbxBookList.SelectedItems.Count - 1 To 0 Step -1
            ' Get the selected item
            Dim selectedItem As Object = lbxBookList.SelectedItems(i)

            ' Add the item to the destination ListBox (ListBox2)
            lbxReturnList.Items.Add(selectedItem)

            ' Remove the item from the source ListBox (ListBox1)
            lbxBookList.Items.Remove(selectedItem)
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For i As Integer = lbxReturnList.SelectedItems.Count - 1 To 0 Step -1
            ' Get the selected item
            Dim selectedItem As Object = lbxReturnList.SelectedItems(i)

            ' Add the item to the destination ListBox (ListBox2)
            lbxBookList.Items.Add(selectedItem)

            ' Remove the item from the source ListBox (ListBox1)
            lbxReturnList.Items.Remove(selectedItem)
        Next
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'set datatable
        Dim dt As New LMSDBDataSet.BookRecordDataTable
        BookRecordTableAdapter.Fill(dt)

        If lbxReturnList.Items.Count = 0 Then
            ' Code to execute if the ListBox doesn't contains items
            MessageBox.Show("No book in Return List!")
            Exit Sub
        Else
            For Each item As Object In lbxReturnList.Items
                'Check list of books to be returned
                Dim filter As String = "userID='" & Session.LoggedInUserID & "' AND BookTitle='" & item & "'"
                'filter rows using Select() method of database
                Dim FilteredRows() As DataRow = dt.Select(filter)
                If FilteredRows.Count <> 0 Then
                    For Each row As DataRow In FilteredRows
                        Dim borrowDate As Date = CDate(row("BorrowDate"))
                        Dim dueDate As Date = borrowDate.AddDays(14)
                        Dim returnedDate As Date = Date.Today

                        Dim dayDiff As Integer = DateDiff(DateInterval.Day, dueDate, returnedDate)

                        Dim lateFee As Decimal = 0
                        If dayDiff > 0 Then
                            lateFee = dayDiff * 0.2
                        End If

                        totalLateFee += lateFee

                        'Simpan untuk receipt
                        receiptItems.Add(New ReturnReceiptItem With {
                                         .BookTitle = item.ToString(),
                                         .BorrowDate = borrowDate,
                                         .DueDate = dueDate,
                                         .ReturnedDate = returnedDate,
                                         .DayDiff = dayDiff,
                                         .LateFee = lateFee
                                         })

                        'Change BorrowStatus value to "Returned"
                        BookRecordTableAdapter.UpdateReturnStatus(Date.Today, "Returned", Session.LoggedInUserID, item)
                    Next
                Else

                End If
            Next
        End If

        'Update Table
        BookRecordTableAdapter.Update(dt)
        'return success
        MessageBox.Show("Books returned successfully!")

        'printing
        ppdReturnReceipt.ShowDialog()

        Me.Close()
    End Sub

    Private Sub pdReturnReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdReturnReceipt.PrintPage
        Dim g = e.Graphics

        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim normalFont As New Font("Arial", 10)

        Dim y As Integer = 40

        g.DrawString("Library Return Receipt", titleFont, Brushes.Black, 180, y)
        y += 40

        g.DrawString("User ID: " & Session.LoggedInUserID, normalFont, Brushes.Black, 40, y)
        y += 20
        g.DrawString("User Name: " & Session.LoggedInUserName, normalFont, Brushes.Black, 40, y)
        y += 30

        g.DrawString("Returned Books:", headerFont, Brushes.Black, 40, y)
        y += 20

        For Each item In receiptItems

            g.DrawString("Title: " & item.BookTitle, normalFont, Brushes.Black, 40, y)
            y += 18

            g.DrawString("Borrowed: " & item.BorrowDate.ToShortDateString(), normalFont, Brushes.Black, 60, y)
            y += 18

            g.DrawString("Due Date: " & item.DueDate.ToShortDateString(), normalFont, Brushes.Black, 60, y)
            y += 18

            If item.DayDiff < 0 Then
                g.DrawString("Status: Returned early (" & Math.Abs(item.DayDiff) & " day(s) left)",
                             normalFont, Brushes.Black, 60, y)
            ElseIf item.DayDiff = 0 Then
                g.DrawString("Status: Returned on due date",
                             normalFont, Brushes.Black, 60, y)
            Else
                g.DrawString("Status: Late by " & item.DayDiff & " day(s)",
                             normalFont, Brushes.Black, 60, y)
                g.DrawString("Late Fee: RM " & item.LateFee.ToString("0.00"),
                             normalFont, Brushes.Black, 80, y + 18)
                y += 18
            End If

            y += 30
        Next

        g.DrawString("Total Late Fee: RM " & totalLateFee.ToString("0.00"),
                     headerFont, Brushes.Black, 40, y + 10)
    End Sub
End Class