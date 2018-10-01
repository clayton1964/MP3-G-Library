<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppSettings
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
		Me.btnOk = New System.Windows.Forms.Button()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'btnOk
		'
		Me.btnOk.Location = New System.Drawing.Point(296, 184)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 3
		Me.btnOk.Text = "Ok"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(24, 24)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(149, 17)
		Me.CheckBox1.TabIndex = 4
		Me.CheckBox1.Text = "Auto Open Last Database"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'frmAppSettings
		'
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(375, 209)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.btnOk)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAppSettings"
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Program Settings"
		Me.TopMost = True
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnOk As System.Windows.Forms.Button
	Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
