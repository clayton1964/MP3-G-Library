<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContestManagement
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
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GBoxContestHeader = New System.Windows.Forms.GroupBox()
		Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
		Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
		Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
		Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtboxContestName = New System.Windows.Forms.TextBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.GBoxCategories = New System.Windows.Forms.GroupBox()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.btnCatOptDelete = New System.Windows.Forms.Button()
		Me.btnCatDelete = New System.Windows.Forms.Button()
		Me.btnCatOptAdd = New System.Windows.Forms.Button()
		Me.btnCatAdd = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.lboxCatOptions = New System.Windows.Forms.ListBox()
		Me.lboxCategories = New System.Windows.Forms.ListBox()
		Me.GBoxContestHeader.SuspendLayout()
		Me.GBoxCategories.SuspendLayout()
		Me.SuspendLayout()
		'
		'StatusStrip1
		'
		Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 382)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(420, 22)
		Me.StatusStrip1.TabIndex = 0
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(8, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(128, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Contest Specification"
		'
		'GBoxContestHeader
		'
		Me.GBoxContestHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.GBoxContestHeader.Controls.Add(Me.dtpEndTime)
		Me.GBoxContestHeader.Controls.Add(Me.dtpStartTime)
		Me.GBoxContestHeader.Controls.Add(Me.dtpEndDate)
		Me.GBoxContestHeader.Controls.Add(Me.dtpStartDate)
		Me.GBoxContestHeader.Controls.Add(Me.Label6)
		Me.GBoxContestHeader.Controls.Add(Me.Label5)
		Me.GBoxContestHeader.Controls.Add(Me.Label4)
		Me.GBoxContestHeader.Controls.Add(Me.Label3)
		Me.GBoxContestHeader.Controls.Add(Me.Label2)
		Me.GBoxContestHeader.Controls.Add(Me.txtboxContestName)
		Me.GBoxContestHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.GBoxContestHeader.Location = New System.Drawing.Point(12, 36)
		Me.GBoxContestHeader.Name = "GBoxContestHeader"
		Me.GBoxContestHeader.Size = New System.Drawing.Size(396, 104)
		Me.GBoxContestHeader.TabIndex = 14
		Me.GBoxContestHeader.TabStop = False
		Me.GBoxContestHeader.Text = "Contest Info"
		'
		'dtpEndTime
		'
		Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpEndTime.Location = New System.Drawing.Point(268, 72)
		Me.dtpEndTime.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
		Me.dtpEndTime.Name = "dtpEndTime"
		Me.dtpEndTime.ShowUpDown = True
		Me.dtpEndTime.Size = New System.Drawing.Size(115, 20)
		Me.dtpEndTime.TabIndex = 5
		Me.dtpEndTime.Value = New Date(2011, 11, 1, 0, 0, 0, 0)
		'
		'dtpStartTime
		'
		Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpStartTime.Location = New System.Drawing.Point(268, 48)
		Me.dtpStartTime.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
		Me.dtpStartTime.Name = "dtpStartTime"
		Me.dtpStartTime.ShowUpDown = True
		Me.dtpStartTime.Size = New System.Drawing.Size(115, 20)
		Me.dtpStartTime.TabIndex = 3
		Me.dtpStartTime.Value = New Date(2011, 11, 1, 0, 0, 0, 0)
		'
		'dtpEndDate
		'
		Me.dtpEndDate.Location = New System.Drawing.Point(72, 72)
		Me.dtpEndDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
		Me.dtpEndDate.Name = "dtpEndDate"
		Me.dtpEndDate.Size = New System.Drawing.Size(115, 20)
		Me.dtpEndDate.TabIndex = 4
		'
		'dtpStartDate
		'
		Me.dtpStartDate.Location = New System.Drawing.Point(72, 48)
		Me.dtpStartDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
		Me.dtpStartDate.Name = "dtpStartDate"
		Me.dtpStartDate.Size = New System.Drawing.Size(115, 20)
		Me.dtpStartDate.TabIndex = 2
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(12, 76)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(52, 13)
		Me.Label6.TabIndex = 20
		Me.Label6.Text = "End Date"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(208, 76)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(52, 13)
		Me.Label5.TabIndex = 23
		Me.Label5.Text = "End Time"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(208, 52)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 13)
		Me.Label4.TabIndex = 22
		Me.Label4.Text = "Start Time"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 52)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(55, 13)
		Me.Label3.TabIndex = 21
		Me.Label3.Text = "Start Date"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 28)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 19
		Me.Label2.Text = "Name"
		'
		'txtboxContestName
		'
		Me.txtboxContestName.Location = New System.Drawing.Point(52, 24)
		Me.txtboxContestName.Name = "txtboxContestName"
		Me.txtboxContestName.Size = New System.Drawing.Size(332, 20)
		Me.txtboxContestName.TabIndex = 1
		Me.txtboxContestName.WordWrap = False
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(332, 352)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 23)
		Me.btnClose.TabIndex = 19
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(256, 352)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 23)
		Me.btnSave.TabIndex = 18
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'GBoxCategories
		'
		Me.GBoxCategories.Controls.Add(Me.btnCreate)
		Me.GBoxCategories.Controls.Add(Me.btnCatOptDelete)
		Me.GBoxCategories.Controls.Add(Me.btnCatDelete)
		Me.GBoxCategories.Controls.Add(Me.btnCatOptAdd)
		Me.GBoxCategories.Controls.Add(Me.btnCatAdd)
		Me.GBoxCategories.Controls.Add(Me.Label7)
		Me.GBoxCategories.Controls.Add(Me.Label10)
		Me.GBoxCategories.Controls.Add(Me.lboxCatOptions)
		Me.GBoxCategories.Controls.Add(Me.lboxCategories)
		Me.GBoxCategories.Location = New System.Drawing.Point(12, 152)
		Me.GBoxCategories.Name = "GBoxCategories"
		Me.GBoxCategories.Size = New System.Drawing.Size(396, 196)
		Me.GBoxCategories.TabIndex = 31
		Me.GBoxCategories.TabStop = False
		Me.GBoxCategories.Text = "Category Info"
		'
		'btnCreate
		'
		Me.btnCreate.Location = New System.Drawing.Point(320, -4)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(75, 23)
		Me.btnCreate.TabIndex = 6
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = True
		'
		'btnCatOptDelete
		'
		Me.btnCatOptDelete.Location = New System.Drawing.Point(308, 164)
		Me.btnCatOptDelete.Name = "btnCatOptDelete"
		Me.btnCatOptDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnCatOptDelete.TabIndex = 12
		Me.btnCatOptDelete.Text = "Delete"
		Me.btnCatOptDelete.UseVisualStyleBackColor = True
		'
		'btnCatDelete
		'
		Me.btnCatDelete.Location = New System.Drawing.Point(112, 164)
		Me.btnCatDelete.Name = "btnCatDelete"
		Me.btnCatDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnCatDelete.TabIndex = 9
		Me.btnCatDelete.Text = "Delete"
		Me.btnCatDelete.UseVisualStyleBackColor = True
		'
		'btnCatOptAdd
		'
		Me.btnCatOptAdd.Location = New System.Drawing.Point(220, 164)
		Me.btnCatOptAdd.Name = "btnCatOptAdd"
		Me.btnCatOptAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnCatOptAdd.TabIndex = 11
		Me.btnCatOptAdd.Text = "Add"
		Me.btnCatOptAdd.UseVisualStyleBackColor = True
		'
		'btnCatAdd
		'
		Me.btnCatAdd.Location = New System.Drawing.Point(24, 164)
		Me.btnCatAdd.Name = "btnCatAdd"
		Me.btnCatAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnCatAdd.TabIndex = 8
		Me.btnCatAdd.Text = "Add"
		Me.btnCatAdd.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(208, 24)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(88, 13)
		Me.Label7.TabIndex = 42
		Me.Label7.Text = "Category Options"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(12, 24)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(57, 13)
		Me.Label10.TabIndex = 41
		Me.Label10.Text = "Categories"
		'
		'lboxCatOptions
		'
		Me.lboxCatOptions.FormattingEnabled = True
		Me.lboxCatOptions.Location = New System.Drawing.Point(220, 40)
		Me.lboxCatOptions.Name = "lboxCatOptions"
		Me.lboxCatOptions.Size = New System.Drawing.Size(164, 121)
		Me.lboxCatOptions.TabIndex = 10
		'
		'lboxCategories
		'
		Me.lboxCategories.FormattingEnabled = True
		Me.lboxCategories.Location = New System.Drawing.Point(24, 40)
		Me.lboxCategories.Name = "lboxCategories"
		Me.lboxCategories.Size = New System.Drawing.Size(164, 121)
		Me.lboxCategories.TabIndex = 7
		'
		'frmContestManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(420, 404)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.GBoxCategories)
		Me.Controls.Add(Me.GBoxContestHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "frmContestManagement"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Contest Specifications"
		Me.GBoxContestHeader.ResumeLayout(False)
		Me.GBoxContestHeader.PerformLayout()
		Me.GBoxCategories.ResumeLayout(False)
		Me.GBoxCategories.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GBoxContestHeader As System.Windows.Forms.GroupBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtboxContestName As System.Windows.Forms.TextBox
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents dtpEndTime As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents GBoxCategories As System.Windows.Forms.GroupBox
	Friend WithEvents btnCatOptDelete As System.Windows.Forms.Button
	Friend WithEvents btnCatDelete As System.Windows.Forms.Button
	Friend WithEvents btnCatOptAdd As System.Windows.Forms.Button
	Friend WithEvents btnCatAdd As System.Windows.Forms.Button
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents lboxCatOptions As System.Windows.Forms.ListBox
	Friend WithEvents lboxCategories As System.Windows.Forms.ListBox
	Friend WithEvents btnCreate As System.Windows.Forms.Button
End Class
