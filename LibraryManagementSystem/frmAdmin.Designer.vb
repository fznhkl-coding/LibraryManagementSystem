<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnDateCheck = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(61, 51)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log out"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(61, 32)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(91, 17)
        Me.lblUserName.TabIndex = 18
        Me.lblUserName.Text = "Administrator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Welcome,"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 26)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Library Management System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Administrator Dashboard"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.LightGray
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQuit.Location = New System.Drawing.Point(321, 264)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(91, 29)
        Me.btnQuit.TabIndex = 27
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.LightGray
        Me.btnReturnBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReturnBook.Location = New System.Drawing.Point(135, 156)
        Me.btnReturnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(125, 43)
        Me.btnReturnBook.TabIndex = 26
        Me.btnReturnBook.Text = "View Users List"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.LightGray
        Me.btnAbout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAbout.Location = New System.Drawing.Point(169, 264)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(91, 29)
        Me.btnAbout.TabIndex = 25
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnDateCheck
        '
        Me.btnDateCheck.BackColor = System.Drawing.Color.LightGray
        Me.btnDateCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDateCheck.Location = New System.Drawing.Point(321, 156)
        Me.btnDateCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDateCheck.Name = "btnDateCheck"
        Me.btnDateCheck.Size = New System.Drawing.Size(125, 43)
        Me.btnDateCheck.TabIndex = 24
        Me.btnDateCheck.Text = "View Borrowing Record"
        Me.btnDateCheck.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.User2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.LightGray
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegister.Location = New System.Drawing.Point(229, 209)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(125, 43)
        Me.btnRegister.TabIndex = 28
        Me.btnRegister.Text = "New User Registration"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnDateCheck)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Dashboard - Library Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblUserName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnDateCheck As Button
    Friend WithEvents btnRegister As Button
End Class
