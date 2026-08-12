<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBorrowBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowBook))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.lbxBookList = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.LMSDBDataSet = New LibraryManagementSystem.LMSDBDataSet()
        Me.BookRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookRecordTableAdapter = New LibraryManagementSystem.LMSDBDataSetTableAdapters.BookRecordTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.LMSDBDataSetTableAdapters.TableAdapterManager()
        Me.lblBookNo = New System.Windows.Forms.Label()
        Me.pdBorrowReceipt = New System.Drawing.Printing.PrintDocument()
        Me.ppdBorrowReceipt = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtBookTitle
        '
        resources.ApplyResources(Me.txtBookTitle, "txtBookTitle")
        Me.txtBookTitle.Name = "txtBookTitle"
        '
        'lbxBookList
        '
        Me.lbxBookList.FormattingEnabled = True
        resources.ApplyResources(Me.lbxBookList, "lbxBookList")
        Me.lbxBookList.Name = "lbxBookList"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.btnSubmit, "btnSubmit")
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'lblUserName
        '
        resources.ApplyResources(Me.lblUserName, "lblUserName")
        Me.lblUserName.Name = "lblUserName"
        '
        'lblUserID
        '
        resources.ApplyResources(Me.lblUserID, "lblUserID")
        Me.lblUserID.Name = "lblUserID"
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
        'lblBookNo
        '
        resources.ApplyResources(Me.lblBookNo, "lblBookNo")
        Me.lblBookNo.Name = "lblBookNo"
        '
        'pdBorrowReceipt
        '
        '
        'ppdBorrowReceipt
        '
        resources.ApplyResources(Me.ppdBorrowReceipt, "ppdBorrowReceipt")
        Me.ppdBorrowReceipt.Document = Me.pdBorrowReceipt
        Me.ppdBorrowReceipt.Name = "ppdBorrowReceipt"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.bookpen
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'frmBorrowBook
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBookNo)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbxBookList)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBorrowBook"
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents lbxBookList As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents LMSDBDataSet As LMSDBDataSet
    Friend WithEvents BookRecordBindingSource As BindingSource
    Friend WithEvents BookRecordTableAdapter As LMSDBDataSetTableAdapters.BookRecordTableAdapter
    Friend WithEvents TableAdapterManager As LMSDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblBookNo As Label
    Friend WithEvents pdBorrowReceipt As Printing.PrintDocument
    Friend WithEvents ppdBorrowReceipt As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
