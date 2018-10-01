<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
		Me.TSStatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.TSStatusLabStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.TSStatusLabCurrentDB = New System.Windows.Forms.ToolStripStatusLabel()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenCreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.gbChoices = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtbWorkingDirectory = New System.Windows.Forms.TextBox()
		Me.btnBrowse = New System.Windows.Forms.Button()
		Me.lblWD = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblVersion = New System.Windows.Forms.Label()
		Me.lblCopyright = New System.Windows.Forms.Label()
		Me.lblProgName = New System.Windows.Forms.Label()
		Me.lboxOutput = New System.Windows.Forms.ListBox()
		Me.TSStatusStrip1.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.gbChoices.SuspendLayout()
		Me.SuspendLayout()
		'
		'TSStatusStrip1
		'
		Me.TSStatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSStatusLabStatus, Me.TSStatusLabCurrentDB})
		Me.TSStatusStrip1.Location = New System.Drawing.Point(0, 363)
		Me.TSStatusStrip1.Name = "TSStatusStrip1"
		Me.TSStatusStrip1.Size = New System.Drawing.Size(762, 22)
		Me.TSStatusStrip1.TabIndex = 2
		Me.TSStatusStrip1.Text = "StatusStrip1"
		'
		'TSStatusLabStatus
		'
		Me.TSStatusLabStatus.AutoSize = False
		Me.TSStatusLabStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
			Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
			Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.TSStatusLabStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
		Me.TSStatusLabStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.TSStatusLabStatus.Name = "TSStatusLabStatus"
		Me.TSStatusLabStatus.Size = New System.Drawing.Size(200, 17)
		Me.TSStatusLabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TSStatusLabCurrentDB
		'
		Me.TSStatusLabCurrentDB.AutoSize = False
		Me.TSStatusLabCurrentDB.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
			Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
			Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.TSStatusLabCurrentDB.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
		Me.TSStatusLabCurrentDB.Name = "TSStatusLabCurrentDB"
		Me.TSStatusLabCurrentDB.Size = New System.Drawing.Size(350, 17)
		Me.TSStatusLabCurrentDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(762, 24)
		Me.MenuStrip1.TabIndex = 4
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.PreferencesToolStripMenuItem, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		Me.FileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
		'
		'PreferencesToolStripMenuItem
		'
		Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
		Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
		Me.PreferencesToolStripMenuItem.Text = "Preferences"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
		Me.ExitToolStripMenuItem.Text = "E&xit"
		'
		'DatabaseToolStripMenuItem
		'
		Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenCreateToolStripMenuItem, Me.CloseToolStripMenuItem})
		Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
		Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
		Me.DatabaseToolStripMenuItem.Text = "&Database"
		'
		'OpenCreateToolStripMenuItem
		'
		Me.OpenCreateToolStripMenuItem.Name = "OpenCreateToolStripMenuItem"
		Me.OpenCreateToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
		Me.OpenCreateToolStripMenuItem.Text = "Open/Create"
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
		Me.CloseToolStripMenuItem.Text = "Close"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'gbChoices
		'
		Me.gbChoices.BackColor = System.Drawing.Color.White
		Me.gbChoices.Controls.Add(Me.Label2)
		Me.gbChoices.Controls.Add(Me.Label3)
		Me.gbChoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbChoices.Location = New System.Drawing.Point(205, 94)
		Me.gbChoices.Name = "gbChoices"
		Me.gbChoices.Size = New System.Drawing.Size(132, 261)
		Me.gbChoices.TabIndex = 7
		Me.gbChoices.TabStop = False
		Me.gbChoices.Text = "Choices"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(6, 25)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(173, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "ZIP to MP3+G"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(6, 45)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(173, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "MP3+G to ZIP"
		'
		'txtbWorkingDirectory
		'
		Me.txtbWorkingDirectory.Location = New System.Drawing.Point(205, 60)
		Me.txtbWorkingDirectory.Name = "txtbWorkingDirectory"
		Me.txtbWorkingDirectory.Size = New System.Drawing.Size(464, 20)
		Me.txtbWorkingDirectory.TabIndex = 8
		'
		'btnBrowse
		'
		Me.btnBrowse.Location = New System.Drawing.Point(675, 58)
		Me.btnBrowse.Name = "btnBrowse"
		Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
		Me.btnBrowse.TabIndex = 9
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.UseVisualStyleBackColor = True
		'
		'lblWD
		'
		Me.lblWD.AutoSize = True
		Me.lblWD.Location = New System.Drawing.Point(202, 44)
		Me.lblWD.Name = "lblWD"
		Me.lblWD.Size = New System.Drawing.Size(92, 13)
		Me.lblWD.TabIndex = 10
		Me.lblWD.Text = "Working Directory"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(24, 60)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(42, 13)
		Me.Label1.TabIndex = 16
		Me.Label1.Text = "Version"
		'
		'lblVersion
		'
		Me.lblVersion.AutoSize = True
		Me.lblVersion.BackColor = System.Drawing.Color.Transparent
		Me.lblVersion.Location = New System.Drawing.Point(68, 60)
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(12, 13)
		Me.lblVersion.TabIndex = 14
		Me.lblVersion.Text = "x"
		'
		'lblCopyright
		'
		Me.lblCopyright.AutoSize = True
		Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
		Me.lblCopyright.Location = New System.Drawing.Point(28, 76)
		Me.lblCopyright.Name = "lblCopyright"
		Me.lblCopyright.Size = New System.Drawing.Size(12, 13)
		Me.lblCopyright.TabIndex = 15
		Me.lblCopyright.Text = "x"
		'
		'lblProgName
		'
		Me.lblProgName.AutoSize = True
		Me.lblProgName.BackColor = System.Drawing.Color.Transparent
		Me.lblProgName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProgName.Location = New System.Drawing.Point(12, 32)
		Me.lblProgName.Name = "lblProgName"
		Me.lblProgName.Size = New System.Drawing.Size(48, 25)
		Me.lblProgName.TabIndex = 13
		Me.lblProgName.Text = "xxx"
		'
		'lboxOutput
		'
		Me.lboxOutput.ColumnWidth = 50
		Me.lboxOutput.Cursor = System.Windows.Forms.Cursors.Default
		Me.lboxOutput.FormattingEnabled = True
		Me.lboxOutput.Location = New System.Drawing.Point(354, 93)
		Me.lboxOutput.MultiColumn = True
		Me.lboxOutput.Name = "lboxOutput"
		Me.lboxOutput.ScrollAlwaysVisible = True
		Me.lboxOutput.Size = New System.Drawing.Size(395, 264)
		Me.lboxOutput.TabIndex = 17
		Me.lboxOutput.TabStop = False
		'
		'frmMainMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(762, 385)
		Me.Controls.Add(Me.lboxOutput)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblVersion)
		Me.Controls.Add(Me.lblCopyright)
		Me.Controls.Add(Me.lblProgName)
		Me.Controls.Add(Me.lblWD)
		Me.Controls.Add(Me.btnBrowse)
		Me.Controls.Add(Me.txtbWorkingDirectory)
		Me.Controls.Add(Me.gbChoices)
		Me.Controls.Add(Me.TSStatusStrip1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "frmMainMenu"
		Me.ShowIcon = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "xxx"
		Me.TSStatusStrip1.ResumeLayout(False)
		Me.TSStatusStrip1.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.gbChoices.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TSStatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents TSStatusLabStatus As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
	Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TSStatusLabCurrentDB As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents OpenCreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents gbChoices As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtbWorkingDirectory As TextBox
	Friend WithEvents btnBrowse As Button
	Friend WithEvents lblWD As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lblVersion As Label
	Friend WithEvents lblCopyright As Label
	Friend WithEvents lblProgName As Label
	Friend WithEvents lboxOutput As ListBox
End Class
