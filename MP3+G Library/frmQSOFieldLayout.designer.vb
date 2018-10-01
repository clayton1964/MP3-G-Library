<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQSOFieldLayout
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
		Me.GBoxQSOInfo = New System.Windows.Forms.GroupBox()
		Me.nudStartCol = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtbFieldName = New System.Windows.Forms.TextBox()
		Me.lvQSO = New System.Windows.Forms.ListView()
		Me.lvColFieldName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.lvColStartPos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnQSODel = New System.Windows.Forms.Button()
		Me.btnQSOAdd = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.lblInUse = New System.Windows.Forms.Label()
		Me.lvColEndPos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label3 = New System.Windows.Forms.Label()
		Me.nudEndCol = New System.Windows.Forms.NumericUpDown()
		Me.GBoxQSOInfo.SuspendLayout()
		CType(Me.nudStartCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudEndCol, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GBoxQSOInfo
		'
		Me.GBoxQSOInfo.Controls.Add(Me.lblInUse)
		Me.GBoxQSOInfo.Controls.Add(Me.nudEndCol)
		Me.GBoxQSOInfo.Controls.Add(Me.nudStartCol)
		Me.GBoxQSOInfo.Controls.Add(Me.Label3)
		Me.GBoxQSOInfo.Controls.Add(Me.Label2)
		Me.GBoxQSOInfo.Controls.Add(Me.Label1)
		Me.GBoxQSOInfo.Controls.Add(Me.txtbFieldName)
		Me.GBoxQSOInfo.Controls.Add(Me.lvQSO)
		Me.GBoxQSOInfo.Controls.Add(Me.btnQSODel)
		Me.GBoxQSOInfo.Controls.Add(Me.btnQSOAdd)
		Me.GBoxQSOInfo.Location = New System.Drawing.Point(12, 12)
		Me.GBoxQSOInfo.Name = "GBoxQSOInfo"
		Me.GBoxQSOInfo.Size = New System.Drawing.Size(592, 312)
		Me.GBoxQSOInfo.TabIndex = 33
		Me.GBoxQSOInfo.TabStop = False
		Me.GBoxQSOInfo.Text = "QSO Field Layout"
		'
		'nudStartCol
		'
		Me.nudStartCol.Location = New System.Drawing.Point(380, 76)
		Me.nudStartCol.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me.nudStartCol.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudStartCol.Name = "nudStartCol"
		Me.nudStartCol.Size = New System.Drawing.Size(52, 20)
		Me.nudStartCol.TabIndex = 41
		Me.nudStartCol.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(296, 76)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 13)
		Me.Label2.TabIndex = 40
		Me.Label2.Text = "Start Column"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(296, 52)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 13)
		Me.Label1.TabIndex = 39
		Me.Label1.Text = "Field Name"
		'
		'txtbFieldName
		'
		Me.txtbFieldName.Location = New System.Drawing.Point(380, 48)
		Me.txtbFieldName.MaxLength = 50
		Me.txtbFieldName.Name = "txtbFieldName"
		Me.txtbFieldName.Size = New System.Drawing.Size(180, 20)
		Me.txtbFieldName.TabIndex = 2
		'
		'lvQSO
		'
		Me.lvQSO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvColFieldName, Me.lvColStartPos, Me.lvColEndPos})
		Me.lvQSO.FullRowSelect = True
		Me.lvQSO.GridLines = True
		Me.lvQSO.Location = New System.Drawing.Point(12, 24)
		Me.lvQSO.MultiSelect = False
		Me.lvQSO.Name = "lvQSO"
		Me.lvQSO.ShowGroups = False
		Me.lvQSO.Size = New System.Drawing.Size(268, 252)
		Me.lvQSO.TabIndex = 1
		Me.lvQSO.UseCompatibleStateImageBehavior = False
		Me.lvQSO.View = System.Windows.Forms.View.Details
		'
		'lvColFieldName
		'
		Me.lvColFieldName.Text = "Field Name"
		Me.lvColFieldName.Width = 120
		'
		'lvColStartPos
		'
		Me.lvColStartPos.Text = "Start Pos."
		'
		'btnQSODel
		'
		Me.btnQSODel.Location = New System.Drawing.Point(488, 144)
		Me.btnQSODel.Name = "btnQSODel"
		Me.btnQSODel.Size = New System.Drawing.Size(75, 23)
		Me.btnQSODel.TabIndex = 6
		Me.btnQSODel.Text = "Delete"
		Me.btnQSODel.UseVisualStyleBackColor = True
		'
		'btnQSOAdd
		'
		Me.btnQSOAdd.Location = New System.Drawing.Point(488, 116)
		Me.btnQSOAdd.Name = "btnQSOAdd"
		Me.btnQSOAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnQSOAdd.TabIndex = 5
		Me.btnQSOAdd.Text = "Add"
		Me.btnQSOAdd.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(640, 328)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 23)
		Me.btnClose.TabIndex = 9
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'lblInUse
		'
		Me.lblInUse.AutoSize = True
		Me.lblInUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInUse.ForeColor = System.Drawing.Color.Red
		Me.lblInUse.Location = New System.Drawing.Point(440, 80)
		Me.lblInUse.Name = "lblInUse"
		Me.lblInUse.Size = New System.Drawing.Size(100, 13)
		Me.lblInUse.TabIndex = 42
		Me.lblInUse.Text = "Start Pos In Use"
		Me.lblInUse.Visible = False
		'
		'lvColEndPos
		'
		Me.lvColEndPos.Text = "End Pos."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(296, 100)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 13)
		Me.Label3.TabIndex = 40
		Me.Label3.Text = "End Column"
		'
		'nudEndCol
		'
		Me.nudEndCol.Location = New System.Drawing.Point(380, 100)
		Me.nudEndCol.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me.nudEndCol.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudEndCol.Name = "nudEndCol"
		Me.nudEndCol.Size = New System.Drawing.Size(52, 20)
		Me.nudEndCol.TabIndex = 41
		Me.nudEndCol.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'frmQSOFieldLayout
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(732, 360)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.GBoxQSOInfo)
		Me.Name = "frmQSOFieldLayout"
		Me.Text = "QSO Field Layout"
		Me.GBoxQSOInfo.ResumeLayout(False)
		Me.GBoxQSOInfo.PerformLayout()
		CType(Me.nudStartCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudEndCol, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GBoxQSOInfo As System.Windows.Forms.GroupBox
	Friend WithEvents btnQSODel As System.Windows.Forms.Button
	Friend WithEvents btnQSOAdd As System.Windows.Forms.Button
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtbFieldName As System.Windows.Forms.TextBox
	Friend WithEvents lvQSO As System.Windows.Forms.ListView
	Friend WithEvents lvColFieldName As System.Windows.Forms.ColumnHeader
	Friend WithEvents lvColStartPos As System.Windows.Forms.ColumnHeader
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents nudStartCol As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblInUse As System.Windows.Forms.Label
	Friend WithEvents lvColEndPos As System.Windows.Forms.ColumnHeader
	Friend WithEvents nudEndCol As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
