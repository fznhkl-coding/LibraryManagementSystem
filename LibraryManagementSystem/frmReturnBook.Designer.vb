<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturnBook
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturnBook))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbxBookList = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.LMSDBDataSet = New LibraryManagementSystem.LMSDBDataSet()
        Me.BookRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookRecordTableAdapter = New LibraryManagementSystem.LMSDBDataSetTableAdapters.BookRecordTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.LMSDBDataSetTableAdapters.TableAdapterManager()
        Me.lbxReturnList = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pdReturnReceipt = New System.Drawing.Printing.PrintDocument()
        Me.ppdReturnReceipt = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(312, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 26)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Return Book"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "User ID"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightGray
        Me.btnAdd.Location = New System.Drawing.Point(196, 176)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 20)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = ">>"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lbxBookList
        '
        Me.lbxBookList.FormattingEnabled = True
        Me.lbxBookList.Location = New System.Drawing.Point(86, 133)
        Me.lbxBookList.Margin = New System.Windows.Forms.Padding(2)
        Me.lbxBookList.Name = "lbxBookList"
        Me.lbxBookList.Size = New System.Drawing.Size(105, 173)
        Me.lbxBookList.TabIndex = 35
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.LightGray
        Me.btnRemove.Location = New System.Drawing.Point(196, 248)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(56, 20)
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = "<<"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightGray
        Me.btnCancel.Location = New System.Drawing.Point(87, 329)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 28)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightGray
        Me.btnSubmit.Location = New System.Drawing.Point(268, 329)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(95, 28)
        Me.btnSubmit.TabIndex = 36
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserID.Location = New System.Drawing.Point(84, 91)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(43, 13)
        Me.lblUserID.TabIndex = 41
        Me.lblUserID.Text = "User ID"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(84, 64)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblUserName.TabIndex = 40
        Me.lblUserName.Text = "User Name"
        '
        'LMSDBDataSet
        '
        Me.LMSDBDataSet.DataSetName = "LMSDBDataSet"
        Me.LMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookRecordBindingSource
        '
        Me.BookRecordBindingSource.DataMember = "BookRecord"
        Me.BookRecordBindingSource.DataSource = Me.LMSDBDataSet
        '
        'BookRecordTableAdapter
        '
        Me.BookRecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookRecordTableAdapter = Me.BookRecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = LibraryManagementSystem.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'lbxReturnList
        '
        Me.lbxReturnList.FormattingEnabled = True
        Me.lbxReturnList.Location = New System.Drawing.Point(256, 133)
        Me.lbxReturnList.Margin = New System.Windows.Forms.Padding(2)
        Me.lbxReturnList.Name = "lbxReturnList"
        Me.lbxReturnList.Size = New System.Drawing.Size(107, 173)
        Me.lbxReturnList.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 118)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Currently Borrowed:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(253, 118)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "To Return:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 118)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Book List"
        '
        'pdReturnReceipt
        '
        '
        'ppdReturnReceipt
        '
        Me.ppdReturnReceipt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdReturnReceipt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdReturnReceipt.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdReturnReceipt.Document = Me.pdReturnReceipt
        Me.ppdReturnReceipt.Enabled = True
        Me.ppdReturnReceipt.Icon = CType(resources.GetObject("ppdReturnReceipt.Icon"), System.Drawing.Icon)
        Me.ppdReturnReceipt.Name = "ppdReturnReceipt"
        Me.ppdReturnReceipt.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.bookpen
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(399, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 377)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'frmReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 377)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbxReturnList)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lbxBookList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmReturnBook"
        Me.Text = "Return Book - Library Management System"
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lbxBookList As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents LMSDBDataSet As LMSDBDataSet
    Friend WithEvents BookRecordBindingSource As BindingSource
    Friend WithEvents BookRecordTableAdapter As LMSDBDataSetTableAdapters.BookRecordTableAdapter
    Friend WithEvents TableAdapterManager As LMSDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lbxReturnList As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pdReturnReceipt As Printing.PrintDocument
    Friend WithEvents ppdReturnReceipt As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
