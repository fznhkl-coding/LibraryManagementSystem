<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.White
        Me.ApplicationTitle.Location = New System.Drawing.Point(173, 88)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(191, 30)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Application Name"
        Me.ApplicationTitle.UseWaitCursor = True
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Location = New System.Drawing.Point(175, 118)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(51, 17)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version"
        Me.Version.UseWaitCursor = True
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Copyright.Location = New System.Drawing.Point(307, 281)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(189, 13)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright ©  2026 Gaehwa Systems"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Copyright.UseWaitCursor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 295)
        Me.ProgressBar1.MarqueeAnimationSpeed = 50
        Me.ProgressBar1.Maximum = 150
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(496, 8)
        Me.ProgressBar1.Step = 5
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Starting up..."
        Me.Label1.UseWaitCursor = True
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibraryManagementSystem.My.Resources.Resources.splashbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Starting up..."
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
End Class
