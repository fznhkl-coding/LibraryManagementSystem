Imports System.Runtime.InteropServices.ComTypes

Public Class frmDateCheck
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'variable declaration
        Dim intBookNo As Integer
        Dim dteBorrowDate As Date
        Dim dteCurrentDate As Date
        Dim latefee As Double

        'initiate var value from input
        intBookNo = nudBookNo.Value
        dteBorrowDate = dtpBorrowDate.Value
        dteCurrentDate = DateTime.Today 'get system date

        'calculate No of borrowing days
        Dim tsBorrowDay As TimeSpan = dteCurrentDate.Subtract(dteBorrowDate)

        'late fee calculations and display message
        If tsBorrowDay.Days <= 14 Then
            latefee = 0.00
            If tsBorrowDay.Days = 14 Then
                lblDateMessage.Text = "Today marks the 14th day."
            Else
                lblDateMessage.Text = "There are " & (14 - tsBorrowDay.Days) & " days left until borrowing period end."
            End If
            lblFees.Text = "Late Fee: " & latefee.ToString("C2")
        Else
            latefee = (tsBorrowDay.Days - 14) * (0.2 * intBookNo)
            lblDateMessage.Text = "It has been " & (tsBorrowDay.Days - 14) & " days since borrowing period ended."
            lblFees.Text = "Late Fee: " & latefee.ToString("C2")
        End If

    End Sub
End Class