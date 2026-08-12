<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBookLocate = New System.Windows.Forms.Button()
        Me.btnDateCheck = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Library Management System"
        '
        'btnBookLocate
        '
        Me.btnBookLocate.BackColor = System.Drawing.Color.LightGray
        Me.btnBookLocate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBookLocate.Location = New System.Drawing.Point(133, 143)
        Me.btnBookLocate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBookLocate.Name = "btnBookLocate"
        Me.btnBookLocate.Size = New System.Drawing.Size(125, 43)
        Me.btnBookLocate.TabIndex = 7
        Me.btnBookLocate.Text = "Book Locator"
        Me.btnBookLocate.UseVisualStyleBackColor = False
        '
        'btnDateCheck
        '
        Me.btnDateCheck.BackColor = System.Drawing.Color.LightGray
        Me.btnDateCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDateCheck.Location = New System.Drawing.Point(319, 201)
        Me.btnDateCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDateCheck.Name = "btnDateCheck"
        Me.btnDateCheck.Size = New System.Drawing.Size(125, 43)
        Me.btnDateCheck.TabIndex = 8
        Me.btnDateCheck.Text = "Due Date Checker"
        Me.btnDateCheck.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.LightGray
        Me.btnAbout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAbout.Location = New System.Drawing.Point(167, 273)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(91, 29)
        Me.btnAbout.TabIndex = 9
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.BackColor = System.Drawing.Color.LightGray
        Me.btnBorrowBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBorrowBook.Location = New System.Drawing.Point(319, 143)
        Me.btnBorrowBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(125, 43)
        Me.btnBorrowBook.TabIndex = 10
        Me.btnBorrowBook.Text = "Borrow Book"
        Me.btnBorrowBook.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.LightGray
        Me.btnReturnBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReturnBook.Location = New System.Drawing.Point(133, 201)
        Me.btnReturnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(125, 43)
        Me.btnReturnBook.TabIndex = 11
        Me.btnReturnBook.Text = "Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.LightGray
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQuit.Location = New System.Drawing.Point(319, 273)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(91, 29)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Welcome,"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(61, 29)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(38, 17)
        Me.lblUserName.TabIndex = 14
        Me.lblUserName.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.User2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(61, 48)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log out"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.btnBorrowBook)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnDateCheck)
        Me.Controls.Add(Me.btnBookLocate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
	Friend WithEvents btnBookLocate As Button
	Friend WithEvents btnDateCheck As Button
	Friend WithEvents btnAbout As Button
	Friend WithEvents btnBorrowBook As Button
	Friend WithEvents btnReturnBook As Button
	Friend WithEvents btnQuit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
