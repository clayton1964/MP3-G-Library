Public Class frmAppSettings

	Dim RegKeyActive As String = glbstrRegKeyFormAppSettings

	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

		Me.Close()

	End Sub

	Private Sub frmAppSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		FormPositionSet(Me, RegKeyActive)

	End Sub

	Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameAppSettingsAutoOpen, sender.checked)

	End Sub

	Private Sub frmAppSettings_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged

		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionX, Me.Location.X)
		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionY, Me.Location.Y)

	End Sub

End Class