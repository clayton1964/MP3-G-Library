<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBOptions
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
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnOpen = New System.Windows.Forms.Button()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.chkboxSelectAfterCreate = New System.Windows.Forms.CheckBox()
		Me.txtBoxFilename = New System.Windows.Forms.TextBox()
		Me.lblFldrServer = New System.Windows.Forms.Label()
		Me.btnBrowse = New System.Windows.Forms.Button()
		Me.txtBoxFolder = New System.Windows.Forms.TextBox()
		Me.lblFNorDBN = New System.Windows.Forms.Label()
		Me.btnCreateDB = New System.Windows.Forms.Button()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.lbl2 = New System.Windows.Forms.Label()
		Me.lvDBList = New System.Windows.Forms.ListView()
		Me.CHDBName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.CHDBType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.CHDBLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.txtBoxSelectedDB = New System.Windows.Forms.TextBox()
		Me.lbl5 = New System.Windows.Forms.Label()
		Me.lbl6 = New System.Windows.Forms.Label()
		Me.txtBoxSelectedDBType = New System.Windows.Forms.TextBox()
		Me.lbl7 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.TSStatusLabStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Location = New System.Drawing.Point(352, 238)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 24)
		Me.btnClose.TabIndex = 8
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnOpen
		'
		Me.btnOpen.Enabled = False
		Me.btnOpen.Location = New System.Drawing.Point(271, 238)
		Me.btnOpen.Name = "btnOpen"
		Me.btnOpen.Size = New System.Drawing.Size(75, 24)
		Me.btnOpen.TabIndex = 7
		Me.btnOpen.Text = "Open"
		Me.btnOpen.UseVisualStyleBackColor = True
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(12, 12)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(415, 155)
		Me.TabControl1.TabIndex = 1
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.chkboxSelectAfterCreate)
		Me.TabPage1.Controls.Add(Me.txtBoxFilename)
		Me.TabPage1.Controls.Add(Me.lblFldrServer)
		Me.TabPage1.Controls.Add(Me.btnBrowse)
		Me.TabPage1.Controls.Add(Me.txtBoxFolder)
		Me.TabPage1.Controls.Add(Me.lblFNorDBN)
		Me.TabPage1.Controls.Add(Me.btnCreateDB)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(407, 129)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "New DB"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'chkboxSelectAfterCreate
		'
		Me.chkboxSelectAfterCreate.AutoSize = True
		Me.chkboxSelectAfterCreate.Location = New System.Drawing.Point(77, 86)
		Me.chkboxSelectAfterCreate.Name = "chkboxSelectAfterCreate"
		Me.chkboxSelectAfterCreate.Size = New System.Drawing.Size(113, 17)
		Me.chkboxSelectAfterCreate.TabIndex = 19
		Me.chkboxSelectAfterCreate.Text = "Select after create"
		Me.chkboxSelectAfterCreate.UseVisualStyleBackColor = True
		'
		'txtBoxFilename
		'
		Me.txtBoxFilename.Location = New System.Drawing.Point(61, 60)
		Me.txtBoxFilename.Name = "txtBoxFilename"
		Me.txtBoxFilename.Size = New System.Drawing.Size(322, 20)
		Me.txtBoxFilename.TabIndex = 4
		'
		'lblFldrServer
		'
		Me.lblFldrServer.AutoSize = True
		Me.lblFldrServer.Location = New System.Drawing.Point(6, 6)
		Me.lblFldrServer.Name = "lblFldrServer"
		Me.lblFldrServer.Size = New System.Drawing.Size(36, 13)
		Me.lblFldrServer.TabIndex = 16
		Me.lblFldrServer.Text = "Folder"
		'
		'btnBrowse
		'
		Me.btnBrowse.Location = New System.Drawing.Point(308, 31)
		Me.btnBrowse.Name = "btnBrowse"
		Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
		Me.btnBrowse.TabIndex = 3
		Me.btnBrowse.Text = "Browse..."
		Me.btnBrowse.UseVisualStyleBackColor = True
		'
		'txtBoxFolder
		'
		Me.txtBoxFolder.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBoxFolder.Location = New System.Drawing.Point(61, 6)
		Me.txtBoxFolder.Name = "txtBoxFolder"
		Me.txtBoxFolder.ReadOnly = True
		Me.txtBoxFolder.Size = New System.Drawing.Size(322, 20)
		Me.txtBoxFolder.TabIndex = 12
		'
		'lblFNorDBN
		'
		Me.lblFNorDBN.AutoSize = True
		Me.lblFNorDBN.Location = New System.Drawing.Point(6, 63)
		Me.lblFNorDBN.Name = "lblFNorDBN"
		Me.lblFNorDBN.Size = New System.Drawing.Size(49, 13)
		Me.lblFNorDBN.TabIndex = 11
		Me.lblFNorDBN.Text = "Filename"
		'
		'btnCreateDB
		'
		Me.btnCreateDB.Enabled = False
		Me.btnCreateDB.Location = New System.Drawing.Point(308, 86)
		Me.btnCreateDB.Name = "btnCreateDB"
		Me.btnCreateDB.Size = New System.Drawing.Size(75, 23)
		Me.btnCreateDB.TabIndex = 5
		Me.btnCreateDB.Text = "Create"
		Me.btnCreateDB.UseVisualStyleBackColor = True
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.lbl2)
		Me.TabPage2.Controls.Add(Me.lvDBList)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(407, 178)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Existing DB"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'lbl2
		'
		Me.lbl2.AutoSize = True
		Me.lbl2.Location = New System.Drawing.Point(3, 12)
		Me.lbl2.Name = "lbl2"
		Me.lbl2.Size = New System.Drawing.Size(77, 13)
		Me.lbl2.TabIndex = 8
		Me.lbl2.Text = "Recently Used"
		'
		'lvDBList
		'
		Me.lvDBList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHDBName, Me.CHDBType, Me.CHDBLocation})
		Me.lvDBList.FullRowSelect = True
		Me.lvDBList.GridLines = True
		Me.lvDBList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvDBList.Location = New System.Drawing.Point(3, 28)
		Me.lvDBList.MultiSelect = False
		Me.lvDBList.Name = "lvDBList"
		Me.lvDBList.ShowGroups = False
		Me.lvDBList.ShowItemToolTips = True
		Me.lvDBList.Size = New System.Drawing.Size(393, 144)
		Me.lvDBList.TabIndex = 6
		Me.lvDBList.UseCompatibleStateImageBehavior = False
		Me.lvDBList.View = System.Windows.Forms.View.Details
		'
		'CHDBName
		'
		Me.CHDBName.Text = "DB Name"
		Me.CHDBName.Width = 113
		'
		'CHDBType
		'
		Me.CHDBType.Text = "Type"
		Me.CHDBType.Width = 89
		'
		'CHDBLocation
		'
		Me.CHDBLocation.Text = "Location"
		Me.CHDBLocation.Width = 178
		'
		'txtBoxSelectedDB
		'
		Me.txtBoxSelectedDB.Location = New System.Drawing.Point(77, 194)
		Me.txtBoxSelectedDB.Name = "txtBoxSelectedDB"
		Me.txtBoxSelectedDB.ReadOnly = True
		Me.txtBoxSelectedDB.Size = New System.Drawing.Size(346, 20)
		Me.txtBoxSelectedDB.TabIndex = 9
		Me.txtBoxSelectedDB.TabStop = False
		'
		'lbl5
		'
		Me.lbl5.AutoSize = True
		Me.lbl5.Location = New System.Drawing.Point(9, 178)
		Me.lbl5.Name = "lbl5"
		Me.lbl5.Size = New System.Drawing.Size(94, 13)
		Me.lbl5.TabIndex = 10
		Me.lbl5.Text = "Database to Open"
		'
		'lbl6
		'
		Me.lbl6.AutoSize = True
		Me.lbl6.Location = New System.Drawing.Point(13, 197)
		Me.lbl6.Name = "lbl6"
		Me.lbl6.Size = New System.Drawing.Size(35, 13)
		Me.lbl6.TabIndex = 11
		Me.lbl6.Text = "Name"
		'
		'txtBoxSelectedDBType
		'
		Me.txtBoxSelectedDBType.Location = New System.Drawing.Point(77, 220)
		Me.txtBoxSelectedDBType.Name = "txtBoxSelectedDBType"
		Me.txtBoxSelectedDBType.ReadOnly = True
		Me.txtBoxSelectedDBType.Size = New System.Drawing.Size(129, 20)
		Me.txtBoxSelectedDBType.TabIndex = 12
		Me.txtBoxSelectedDBType.TabStop = False
		'
		'lbl7
		'
		Me.lbl7.AutoSize = True
		Me.lbl7.Location = New System.Drawing.Point(13, 223)
		Me.lbl7.Name = "lbl7"
		Me.lbl7.Size = New System.Drawing.Size(31, 13)
		Me.lbl7.TabIndex = 13
		Me.lbl7.Text = "Type"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSStatusLabStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 270)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(434, 22)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 14
		'
		'TSStatusLabStatus
		'
		Me.TSStatusLabStatus.AutoSize = False
		Me.TSStatusLabStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
			Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
			Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.TSStatusLabStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
		Me.TSStatusLabStatus.Name = "TSStatusLabStatus"
		Me.TSStatusLabStatus.Size = New System.Drawing.Size(200, 17)
		Me.TSStatusLabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'frmDBOptions
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnClose
		Me.ClientSize = New System.Drawing.Size(434, 292)
		Me.ControlBox = False
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.lbl7)
		Me.Controls.Add(Me.txtBoxSelectedDBType)
		Me.Controls.Add(Me.lbl6)
		Me.Controls.Add(Me.lbl5)
		Me.Controls.Add(Me.txtBoxSelectedDB)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.btnOpen)
		Me.Controls.Add(Me.btnClose)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmDBOptions"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Database Options"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents btnOpen As System.Windows.Forms.Button
	Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
	Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
	Friend WithEvents btnCreateDB As System.Windows.Forms.Button
	Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
	Friend WithEvents lbl2 As System.Windows.Forms.Label
	Friend WithEvents lvDBList As System.Windows.Forms.ListView
	Friend WithEvents CHDBName As System.Windows.Forms.ColumnHeader
	Friend WithEvents CHDBType As System.Windows.Forms.ColumnHeader
	Friend WithEvents CHDBLocation As System.Windows.Forms.ColumnHeader
	Friend WithEvents txtBoxFilename As System.Windows.Forms.TextBox
	Friend WithEvents lblFldrServer As System.Windows.Forms.Label
	Friend WithEvents btnBrowse As System.Windows.Forms.Button
	Friend WithEvents txtBoxFolder As System.Windows.Forms.TextBox
	Friend WithEvents lblFNorDBN As System.Windows.Forms.Label
	Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
	Friend WithEvents txtBoxSelectedDB As System.Windows.Forms.TextBox
	Friend WithEvents lbl5 As System.Windows.Forms.Label
	Friend WithEvents lbl6 As System.Windows.Forms.Label
	Friend WithEvents txtBoxSelectedDBType As System.Windows.Forms.TextBox
	Friend WithEvents lbl7 As System.Windows.Forms.Label
	Friend WithEvents chkboxSelectAfterCreate As System.Windows.Forms.CheckBox
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents TSStatusLabStatus As System.Windows.Forms.ToolStripStatusLabel
End Class
