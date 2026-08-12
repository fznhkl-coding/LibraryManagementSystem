Imports LibraryManagementSystem.LMSDBDataSetTableAdapters

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'set datatable
        Dim dt As New LMSDBDataSet.UsersDataTable
        UsersTableAdapter.Fill(dt)

        'define filter
        Dim filter As String = "userID='" & UsernameTextBox.Text & "'AND password='" & PasswordTextBox.Text & "'"
        'filter rows using Select() method of database
        Dim FilteredRows() As DataRow = dt.Select(filter)
        If FilteredRows.Count <> 0 Then
            For Each row As DataRow In FilteredRows
                'Save current session account credentials
                Session.LoggedInUserID = row("userID").ToString()
                Session.LoggedInAccountLevel = row("accountLevel").ToString()
                Session.LoggedInUserName = row("UserName").ToString()

                If row("accountLevel") = "Administrator" Then
                    frmAdmin.Show()
                    Me.Hide()
                End If
                If row("accountLevel") = "Standard" Then
                    frmMain.Show()
                    Me.Hide()
                End If
            Next
        Else
            MessageBox.Show("Invalid User ID and/or Password")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDBDataSet)

    End Sub

    Private Sub LoginForm1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LMSDBDataSet.Users)

    End Sub

    Private Sub lblViewPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblViewPass.LinkClicked
        If lblViewPass.Text = "Show Password" Then
            PasswordTextBox.PasswordChar = ""
            lblViewPass.Text = "Hide Password"
        Else
            PasswordTextBox.PasswordChar = "*"
            lblViewPass.Text = "Show Password"
        End If
    End Sub

    Private Sub LoginForm1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmRegisterStd.Show()
        Me.Hide()
    End Sub

    Private Sub LoginForm1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmSplash.Close()
    End Sub
End Class
