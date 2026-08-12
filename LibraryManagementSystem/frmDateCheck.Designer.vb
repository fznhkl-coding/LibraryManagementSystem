<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDateCheck))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dtpBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.nudBookNo = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.lblDateMessage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nudBookNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Due Date Checker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. of Book"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Borrowing Date"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightGray
        Me.btnCancel.Location = New System.Drawing.Point(31, 305)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 28)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightGray
        Me.btnSubmit.Location = New System.Drawing.Point(241, 305)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(95, 28)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Check"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'dtpBorrowDate
        '
        Me.dtpBorrowDate.Location = New System.Drawing.Point(112, 88)
        Me.dtpBorrowDate.Name = "dtpBorrowDate"
        Me.dtpBorrowDate.Size = New System.Drawing.Size(224, 20)
        Me.dtpBorrowDate.TabIndex = 15
        '
        'nudBookNo
        '
        Me.nudBookNo.Location = New System.Drawing.Point(113, 61)
        Me.nudBookNo.Name = "nudBookNo"
        Me.nudBookNo.Size = New System.Drawing.Size(223, 20)
        Me.nudBookNo.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFees)
        Me.GroupBox1.Controls.Add(Me.lblDateMessage)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 150)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.Location = New System.Drawing.Point(5, 65)
        Me.lblFees.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(0, 15)
        Me.lblFees.TabIndex = 5
        '
        'lblDateMessage
        '
        Me.lblDateMessage.AutoSize = True
        Me.lblDateMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateMessage.Location = New System.Drawing.Point(5, 16)
        Me.lblDateMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateMessage.Name = "lblDateMessage"
        Me.lblDateMessage.Size = New System.Drawing.Size(0, 15)
        Me.lblDateMessage.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.datetime
        Me.PictureBox1.Location = New System.Drawing.Point(404, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 367)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmDateCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nudBookNo)
        Me.Controls.Add(Me.dtpBorrowDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDateCheck"
        Me.Text = "Due Date Checker - Library Management System"
        CType(Me.nudBookNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents dtpBorrowDate As DateTimePicker
    Friend WithEvents nudBookNo As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFees As Label
    Friend WithEvents lblDateMessage As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
