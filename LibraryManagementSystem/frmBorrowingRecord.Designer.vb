<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowingRecord
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowingRecord))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysBorrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LateFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookRecordQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMSDBDataSet = New LibraryManagementSystem.LMSDBDataSet()
        Me.BookRecord_QueryTableAdapter = New LibraryManagementSystem.LMSDBDataSetTableAdapters.BookRecord_QueryTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookRecordQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.BookTitleDataGridViewTextBoxColumn, Me.BorrowStatusDataGridViewTextBoxColumn, Me.BorrowDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.DaysBorrowedDataGridViewTextBoxColumn, Me.LateFeeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookRecordQueryBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(843, 366)
        Me.DataGridView1.TabIndex = 0
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'BookTitleDataGridViewTextBoxColumn
        '
        Me.BookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle"
        Me.BookTitleDataGridViewTextBoxColumn.HeaderText = "Book Title"
        Me.BookTitleDataGridViewTextBoxColumn.Name = "BookTitleDataGridViewTextBoxColumn"
        '
        'BorrowStatusDataGridViewTextBoxColumn
        '
        Me.BorrowStatusDataGridViewTextBoxColumn.DataPropertyName = "BorrowStatus"
        Me.BorrowStatusDataGridViewTextBoxColumn.HeaderText = "Borrow Status"
        Me.BorrowStatusDataGridViewTextBoxColumn.Name = "BorrowStatusDataGridViewTextBoxColumn"
        '
        'BorrowDateDataGridViewTextBoxColumn
        '
        Me.BorrowDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowDate"
        Me.BorrowDateDataGridViewTextBoxColumn.HeaderText = "Borrow Date"
        Me.BorrowDateDataGridViewTextBoxColumn.Name = "BorrowDateDataGridViewTextBoxColumn"
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "Return Date"
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        '
        'DaysBorrowedDataGridViewTextBoxColumn
        '
        Me.DaysBorrowedDataGridViewTextBoxColumn.DataPropertyName = "DaysBorrowed"
        Me.DaysBorrowedDataGridViewTextBoxColumn.HeaderText = "Days Borrowed"
        Me.DaysBorrowedDataGridViewTextBoxColumn.Name = "DaysBorrowedDataGridViewTextBoxColumn"
        '
        'LateFeeDataGridViewTextBoxColumn
        '
        Me.LateFeeDataGridViewTextBoxColumn.DataPropertyName = "LateFee"
        DataGridViewCellStyle1.Format = "C2"
        Me.LateFeeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.LateFeeDataGridViewTextBoxColumn.HeaderText = "Late Fee"
        Me.LateFeeDataGridViewTextBoxColumn.Name = "LateFeeDataGridViewTextBoxColumn"
        '
        'BookRecordQueryBindingSource
        '
        Me.BookRecordQueryBindingSource.DataMember = "BookRecord Query"
        Me.BookRecordQueryBindingSource.DataSource = Me.LMSDBDataSet
        '
        'LMSDBDataSet
        '
        Me.LMSDBDataSet.DataSetName = "LMSDBDataSet"
        Me.LMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookRecord_QueryTableAdapter
        '
        Me.BookRecord_QueryTableAdapter.ClearBeforeFill = True
        '
        'frmBorrowingRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 366)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrowingRecord"
        Me.Text = "Borrowing Record - Library Management System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookRecordQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMSDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LMSDBDataSet As LMSDBDataSet
    Friend WithEvents BookRecordQueryBindingSource As BindingSource
    Friend WithEvents BookRecord_QueryTableAdapter As LMSDBDataSetTableAdapters.BookRecord_QueryTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysBorrowedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LateFeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
