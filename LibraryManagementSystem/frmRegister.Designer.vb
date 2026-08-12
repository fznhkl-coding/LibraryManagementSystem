<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblViewPass = New System.Windows.Forms.LinkLabel()
        Me.cbxAccountLevel = New System.Windows.Forms.ComboBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LMSDBDataSet = New LibraryManagementSystem.LMSDBDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New LibraryManagementSystem.LMSDBDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.LMSDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 10)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "User ID"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 53)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "User Name"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(174, 30)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(220, 20)
        Me.txtUserID.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(174, 73)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(220, 20)
        Me.txtUserName.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(197, 214)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "Register"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 214)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(174, 116)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 20)
        Me.txtPassword.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(172, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(171, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Account Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblViewPass
        '
        Me.lblViewPass.AutoSize = True
        Me.lblViewPass.Location = New System.Drawing.Point(311, 140)
        Me.lblViewPass.Name = "lblViewPass"
        Me.lblViewPass.Size = New System.Drawing.Size(83, 13)
        Me.lblViewPass.TabIndex = 10
        Me.lblViewPass.TabStop = True
        Me.lblViewPass.Text = "Show Password"
        Me.lblViewPass.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbxAccountLevel
        '
        Me.cbxAccountLevel.FormattingEnabled = True
        Me.cbxAccountLevel.Items.AddRange(New Object() {"Standard", "Administrator"})
        Me.cbxAccountLevel.Location = New System.Drawing.Point(173, 173)
        Me.cbxAccountLevel.Name = "cbxAccountLevel"
        Me.cbxAccountLevel.Size = New System.Drawing.Size(221, 21)
        Me.cbxAccountLevel.TabIndex = 11
        Me.cbxAccountLevel.Text = "Select..."
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.LibraryManagementSystem.My.Resources.Resources.Screenshot_2026_01_16_014641
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 248)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LMSDBDataSet
        '
        Me.LMSDBDataSet.DataSetName = "LMSDBDataSet"
        Me.LMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.LMSDBDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookRecordTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LibraryManagementSystem.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'frmRegister
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 248)
        Me.Controls.Add(Me.cbxAccountLevel)
        Me.Controls.Add(Me.lblViewPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New User registration - Library Management System"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblViewPass As LinkLabel
    Friend WithEvents cbxAccountLevel As ComboBox
    Friend WithEvents LMSDBDataSet As LMSDBDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As LMSDBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As LMSDBDataSetTableAdapters.TableAdapterManager
End Class
