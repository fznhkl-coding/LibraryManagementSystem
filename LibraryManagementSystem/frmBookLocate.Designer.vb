<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookLocate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookLocate))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNovel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEncyclopedia = New System.Windows.Forms.Button()
        Me.btnBiography = New System.Windows.Forms.Button()
        Me.btnDictionary = New System.Windows.Forms.Button()
        Me.btnMagazine = New System.Windows.Forms.Button()
        Me.btnLanguage = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.pbBiography = New System.Windows.Forms.PictureBox()
        Me.pbDictionary = New System.Windows.Forms.PictureBox()
        Me.pbMagazine = New System.Windows.Forms.PictureBox()
        Me.pbLanguage = New System.Windows.Forms.PictureBox()
        Me.pbNovel = New System.Windows.Forms.PictureBox()
        Me.pbDefault = New System.Windows.Forms.PictureBox()
        Me.pbEncyclopedia = New System.Windows.Forms.PictureBox()
        CType(Me.pbBiography, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDictionary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMagazine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNovel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEncyclopedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Locator"
        '
        'btnNovel
        '
        Me.btnNovel.BackColor = System.Drawing.Color.LightGray
        Me.btnNovel.Location = New System.Drawing.Point(47, 110)
        Me.btnNovel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovel.Name = "btnNovel"
        Me.btnNovel.Size = New System.Drawing.Size(90, 43)
        Me.btnNovel.TabIndex = 1
        Me.btnNovel.Text = "Novel"
        Me.btnNovel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Select Book Type:"
        '
        'btnEncyclopedia
        '
        Me.btnEncyclopedia.BackColor = System.Drawing.Color.LightGray
        Me.btnEncyclopedia.Location = New System.Drawing.Point(142, 206)
        Me.btnEncyclopedia.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEncyclopedia.Name = "btnEncyclopedia"
        Me.btnEncyclopedia.Size = New System.Drawing.Size(90, 43)
        Me.btnEncyclopedia.TabIndex = 10
        Me.btnEncyclopedia.Text = "Encyclopedia"
        Me.btnEncyclopedia.UseVisualStyleBackColor = False
        '
        'btnBiography
        '
        Me.btnBiography.BackColor = System.Drawing.Color.LightGray
        Me.btnBiography.Location = New System.Drawing.Point(47, 206)
        Me.btnBiography.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBiography.Name = "btnBiography"
        Me.btnBiography.Size = New System.Drawing.Size(90, 43)
        Me.btnBiography.TabIndex = 11
        Me.btnBiography.Text = "Biography"
        Me.btnBiography.UseVisualStyleBackColor = False
        '
        'btnDictionary
        '
        Me.btnDictionary.BackColor = System.Drawing.Color.LightGray
        Me.btnDictionary.Location = New System.Drawing.Point(142, 158)
        Me.btnDictionary.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDictionary.Name = "btnDictionary"
        Me.btnDictionary.Size = New System.Drawing.Size(90, 43)
        Me.btnDictionary.TabIndex = 12
        Me.btnDictionary.Text = "Dictionary"
        Me.btnDictionary.UseVisualStyleBackColor = False
        '
        'btnMagazine
        '
        Me.btnMagazine.BackColor = System.Drawing.Color.LightGray
        Me.btnMagazine.Location = New System.Drawing.Point(47, 158)
        Me.btnMagazine.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMagazine.Name = "btnMagazine"
        Me.btnMagazine.Size = New System.Drawing.Size(90, 43)
        Me.btnMagazine.TabIndex = 13
        Me.btnMagazine.Text = "Magazine"
        Me.btnMagazine.UseVisualStyleBackColor = False
        '
        'btnLanguage
        '
        Me.btnLanguage.BackColor = System.Drawing.Color.LightGray
        Me.btnLanguage.Location = New System.Drawing.Point(142, 110)
        Me.btnLanguage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLanguage.Name = "btnLanguage"
        Me.btnLanguage.Size = New System.Drawing.Size(90, 43)
        Me.btnLanguage.TabIndex = 14
        Me.btnLanguage.Text = "Language"
        Me.btnLanguage.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.LightGray
        Me.btnDone.Location = New System.Drawing.Point(95, 279)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(90, 26)
        Me.btnDone.TabIndex = 15
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'pbBiography
        '
        Me.pbBiography.Image = Global.LibraryManagementSystem.My.Resources.Resources.CSC301_Library_layout__biography_only_
        Me.pbBiography.Location = New System.Drawing.Point(317, 19)
        Me.pbBiography.Name = "pbBiography"
        Me.pbBiography.Size = New System.Drawing.Size(261, 336)
        Me.pbBiography.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBiography.TabIndex = 21
        Me.pbBiography.TabStop = False
        '
        'pbDictionary
        '
        Me.pbDictionary.Image = Global.LibraryManagementSystem.My.Resources.Resources.CSC301_Library_layout__dictionary_only_
        Me.pbDictionary.Location = New System.Drawing.Point(317, 19)
        Me.pbDictionary.Name = "pbDictionary"
        Me.pbDictionary.Size = New System.Drawing.Size(261, 336)
        Me.pbDictionary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDictionary.TabIndex = 20
        Me.pbDictionary.TabStop = False
        '
        'pbMagazine
        '
        Me.pbMagazine.Image = Global.LibraryManagementSystem.My.Resources.Resources.CSC301_Library_layout__magazine_only_
        Me.pbMagazine.Location = New System.Drawing.Point(317, 19)
        Me.pbMagazine.Name = "pbMagazine"
        Me.pbMagazine.Size = New System.Drawing.Size(261, 336)
        Me.pbMagazine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMagazine.TabIndex = 19
        Me.pbMagazine.TabStop = False
        '
        'pbLanguage
        '
        Me.pbLanguage.Image = Global.LibraryManagementSystem.My.Resources.Resources.CSC301_Library_layout__language_only_
        Me.pbLanguage.Location = New System.Drawing.Point(317, 19)
        Me.pbLanguage.Name = "pbLanguage"
        Me.pbLanguage.Size = New System.Drawing.Size(261, 336)
        Me.pbLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLanguage.TabIndex = 18
        Me.pbLanguage.TabStop = False
        '
        'pbNovel
        '
        Me.pbNovel.Image = Global.LibraryManagementSystem.My.Resources.Resources.CSC301_Library_layout__novel_only_
        Me.pbNovel.Location = New System.Drawing.Point(317, 19)
        Me.pbNovel.Name = "pbNovel"
        Me.pbNovel.Size = New System.Drawing.Size(261, 336)
        Me.pbNovel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNovel.TabIndex = 17
        Me.pbNovel.TabStop = False
        '
        'pbDefault
        '
        Me.pbDefault.Image = Global.LibraryManagementSystem.My.Resources.Resources.CSC301_Library_layout__default_
        Me.pbDefault.Location = New System.Drawing.Point(317, 19)
        Me.pbDefault.Name = "pbDefault"
        Me.pbDefault.Size = New System.Drawing.Size(261, 336)
        Me.pbDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDefault.TabIndex = 16
        Me.pbDefault.TabStop = False
        '
        'pbEncyclopedia
        '
        Me.pbEncyclopedia.Image = Global.LibraryManagementSystem.My.Resources.Resources.CSC301_Library_layout__encyclopedia_only_
        Me.pbEncyclopedia.Location = New System.Drawing.Point(317, 19)
        Me.pbEncyclopedia.Name = "pbEncyclopedia"
        Me.pbEncyclopedia.Size = New System.Drawing.Size(261, 336)
        Me.pbEncyclopedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEncyclopedia.TabIndex = 22
        Me.pbEncyclopedia.TabStop = False
        '
        'frmBookLocate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.pbEncyclopedia)
        Me.Controls.Add(Me.pbBiography)
        Me.Controls.Add(Me.pbDictionary)
        Me.Controls.Add(Me.pbMagazine)
        Me.Controls.Add(Me.pbLanguage)
        Me.Controls.Add(Me.pbNovel)
        Me.Controls.Add(Me.pbDefault)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnLanguage)
        Me.Controls.Add(Me.btnMagazine)
        Me.Controls.Add(Me.btnDictionary)
        Me.Controls.Add(Me.btnBiography)
        Me.Controls.Add(Me.btnEncyclopedia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNovel)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBookLocate"
        Me.Text = "Book Locator - Library Management System"
        CType(Me.pbBiography, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDictionary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMagazine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNovel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEncyclopedia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNovel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEncyclopedia As Button
    Friend WithEvents btnBiography As Button
    Friend WithEvents btnDictionary As Button
    Friend WithEvents btnMagazine As Button
    Friend WithEvents btnLanguage As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents pbDefault As PictureBox
    Friend WithEvents pbNovel As PictureBox
    Friend WithEvents pbLanguage As PictureBox
    Friend WithEvents pbMagazine As PictureBox
    Friend WithEvents pbDictionary As PictureBox
    Friend WithEvents pbBiography As PictureBox
    Friend WithEvents pbEncyclopedia As PictureBox
End Class
