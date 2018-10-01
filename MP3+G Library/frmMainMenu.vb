Imports Microsoft.Office.Interop.Access.Dao

Public Class frmMainMenu

	Dim RegKeyActive As String = glbRegKeyAppMain & glbstrBackSlash & glbRegKeyNameMain

	Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Dim boolOpenLastUsedDB As Boolean = False
		Dim boolResult As Boolean = False
		Dim boolDBOpened As Boolean = False

		Initialize()

		If Not RegExist(glbRegKeyAppMain) Then
			CreateInitialRegistrySettings()
		End If

		If glbbolApplicationToQuit Then
			MsgBox("OS Not Supported", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Operating System Not supported")
			Application.Exit()
		End If

		FormPositionSet(Me, RegKeyActive)
		' LoadFormValuesFromRegistry()

		Me.Text = glbstrAppName ' & glbstrHyphen & glbstrCurrentDBName
		TSStatusLabCurrentDB.Text = glbstrEmptyString

		boolOpenLastUsedDB = GetValueFromRegistry(glbRegKeyHKCU, glbstrRegKeyFormAppSettings, glbRegKeyNameAppSettingsAutoOpen)

		If boolOpenLastUsedDB Then




		Else
			' setup menu items
			SetupMenuItems(glbintMenuItemSetupDatabaseClosed)

		End If
		If glbbolCancel Then
			txtbWorkingDirectory.Enabled = False
			btnBrowse.Enabled = False
			CloseToolStripMenuItem.BackColor = Color.LightGray
			CloseToolStripMenuItem.Enabled = False
		End If
	End Sub

	Private Sub frmMainMenu_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged

		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionX, Me.Location.X)
		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionY, Me.Location.Y)

	End Sub

	Private Sub frmMainMenu_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

		CloseDatabaseConnection(glbDBDaoDB)

	End Sub

	Public Sub LoadFormValuesFromRegistry()
		'Dim objTemp As Object

		'objTemp = GetValueFromRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameMainMenuFolderDBLocation)
		'If objTemp.Equals(vbNull) Then

		'Else
		'	' cboxBands.Text = objTemp.ToString
		'End If

		'objTemp = GetValueFromRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameMainMode)
		'If objTemp.Equals(vbNull) Then

		'Else
		'	' cboxModes.Text = objTemp.ToString
		'End If


	End Sub

	Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

		Me.Close()

	End Sub


	Private Sub CreateContestTable()

		Dim dbToOpen As String
		Dim dbase As Database
		Dim MyDBEngine As New DBEngine
		Dim tdef As TableDef

		dbToOpen = glbstrCurrentDBName

		dbase = MyDBEngine.OpenDatabase(dbToOpen)

		For Each tdef In dbase.TableDefs


		Next

		dbase.Close()
		MyDBEngine = Nothing

	End Sub

	Private Sub ManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

		frmContestManagement.ShowDialog()

	End Sub

	Private Sub frmMainMenu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter

		If glbDBConn.GetType.Name = "Object" Then


		End If

	End Sub

	Private Sub OpenCreateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenCreateToolStripMenuItem.Click

		frmDBOptions.ShowDialog()

	End Sub

	Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

		CloseDatabaseConnection(glbDBConn)

	End Sub

	Private Sub PreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferencesToolStripMenuItem.Click

		frmAppSettings.ShowDialog()

	End Sub

	Private Sub QSOLayoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

		frmQSOFieldLayout.ShowDialog()

	End Sub

	Private Function SetupMenuItems(SetupCondition As Integer) As Boolean
		SetupMenuItems = False

		Select Case SetupCondition
			Case glbintMenuItemSetupDatabaseOpened
				DatabaseToolStripMenuItem.Enabled = True
				OpenCreateToolStripMenuItem.Enabled = False
				CloseToolStripMenuItem.Enabled = True

			Case glbintMenuItemSetupDatabaseClosed
				DatabaseToolStripMenuItem.Enabled = True
				OpenCreateToolStripMenuItem.Enabled = True
				CloseToolStripMenuItem.Enabled = False

		End Select


		SetupMenuItems = True
	End Function

	Private Sub CreateInitialRegistrySettings()


		' Create entries for MAIN subkey.
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormMain, glbRegKeyPositionX, 60)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormMain, glbRegKeyPositionY, 60)
		'AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormMain, glbRegKeyNameMainLLDB, False)

		'Create App Settings DBOptions subkkey
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyPositionX, 60)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyPositionY, 60)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameMainMenuFolderDBLocation, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameAppSettingsAutoOpen, True)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameDBOptionsLUDBName, glbstrCMDBName)


	End Sub

	Private Sub FindLibraryFile()
		Dim boolDBOpened As Boolean = False
		Dim boolResult As Boolean = False

		boolDBOpened = OpenCMDBFile()
		If boolDBOpened Then
			boolResult = ValidateDBdao(glbDBDaoDB)
			If boolResult Then
				ReadContestRecord(Me)

				' setup menu items
				SetupMenuItems(glbintMenuItemSetupDatabaseOpened)

			Else
				' setup menu items
				SetupMenuItems(glbintMenuItemSetupDatabaseClosed)

				CloseDatabaseConnection(glbDBDaoDB)
			End If
		Else
			'failed to open last used DB

			' setup menu items
			SetupMenuItems(glbintMenuItemSetupDatabaseClosed)

			CloseDatabaseConnection(glbDBDaoDB)

		End If
	End Sub

End Class