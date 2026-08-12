Public Class frmRegister

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim dt As New LMSDBDataSet.UsersDataTable
        Dim newRow As LMSDBDataSet.UsersRow
        newRow = dt.NewUsersRow()

        newRow.userID = txtUserID.Text
        newRow.UserName = txtUserName.Text
        newRow.password = txtPassword.Text
        newRow.accountLevel = cbxAccountLevel.SelectedItem.ToString()

        dt.AddUsersRow(newRow)

        UsersTableAdapter.Update(dt)

        MessageBox.Show("User Registration Successful!", "Success!", MessageBoxButtons.OK)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub lblViewPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblViewPass.LinkClicked
        If lblViewPass.Text = "Show Password" Then
            txtPassword.PasswordChar = ""
            lblViewPass.Text = "Hide Password"
        Else
            txtPassword.PasswordChar = "*"
            lblViewPass.Text = "Show Password"
        End If
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDBDataSet)

    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LMSDBDataSet.Users)

    End Sub
End Class
