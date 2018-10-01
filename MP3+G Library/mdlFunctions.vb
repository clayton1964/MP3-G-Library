Imports System.Environment

Module mdlFunctions

	Public Function Initialize() As Boolean

		'Initialize variables
		glbstrRegKeyFormMain = glbRegKeyAppMain & glbstrBackSlash & glbRegKeyNameMain
		glbstrRegKeyFormDBOptions = glbRegKeyAppMain & glbstrBackSlash & glbRegKeyNameDBOptions
		glbstrRegKeyFormAppSettings = glbRegKeyAppMain & glbstrBackSlash & glbRegKeyNameAppSettings

		'Initialize Main Menu if open

		If frmMainMenu.Created = True Then
			frmMainMenu.lblProgName.Text = glbstrAppName
			frmMainMenu.lblCopyright.Text = glbstrCopyright
			frmMainMenu.lblVersion.Text = Application.ProductVersion

		End If

		Initialize = True

	End Function

	Public Function AppendBSlashToFolderName(ByVal folderin As String) As String

		Dim strTemp As String

		If folderin <> glbstrEmptyString Then
			If Right(folderin, 1) <> glbstrBackSlash Then
				strTemp = folderin & glbstrBackSlash
			Else
				strTemp = folderin
			End If
		Else
			strTemp = folderin
		End If

		AppendBSlashToFolderName = strTemp

	End Function

	Public Function OpenDatabaseConnection(ByVal DBTypeIn As String, ByVal DBConnectStringIn As String, ByVal ToolStripLabelIn As ToolStripStatusLabel, ByVal CurrentDBToolStripLabel As ToolStripStatusLabel, ByVal DBNameIn As String) As Boolean

		ToolStripLabelIn.Text = glbstrStrOpeningDB
		OpenDatabaseConnection = False

		glbDBDaoDB = glbDBDaoDBE.OpenDatabase(DBNameIn)

		OpenDatabaseConnection = True

		glbstrCurrentDBName = DBNameIn
		glbstrCurrentDBType = DBTypeIn

		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormMain, glbRegKeyNameMainMenuFolderDBLocation, DBNameIn)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameDBOptionsLUDBName, DBNameIn)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameDBOptionsLUF, IO.Path.GetDirectoryName(DBNameIn))

		CurrentDBToolStripLabel.Text = DBNameIn
		frmMainMenu.OpenCreateToolStripMenuItem.Enabled = False
		frmMainMenu.CloseToolStripMenuItem.Enabled = True

		ToolStripLabelIn.Text = glbstrEmptyString

	End Function

	Public Function CloseDatabaseConnection(ByRef odConnectionIncoming As Object) As Boolean

		CloseDatabaseConnection = False

		If Not glbbolNetworkVersion Then
			Try
				glbDBDaoDB.Close()
			Catch ex As Exception

			End Try

		Else
			Try
				odConnectionIncoming.Close()
			Catch ex As Exception

			End Try

		End If


		CloseDatabaseConnection = True

	End Function

	Public Function CreateConnectionString(ByVal DatabaseTypeIn As String, ByVal DatabaseNameIn As String, Optional ByVal SQLInstanceIn As String = glbstrEmptyString) As String

		CreateConnectionString = glbstrEmptyString

		CreateConnectionString = glbstrAccessConnectionStrPart1 & Chr(34) & DatabaseNameIn & Chr(34) & glbstrAccessConnectionStrPart2

	End Function

	Public Function OpenCMDBFile() As Boolean

		Dim strFullPathFileName As String
		Dim boolresult As Boolean
		Dim strLastUsedFolder As String
		Dim resultMsgBoxResult As MsgBoxResult
		Dim boolCancel As Boolean = False

		OpenCMDBFile = False

		strLastUsedFolder = GetValueFromRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameDBOptionsLUF)
		strFullPathFileName = GetValueFromRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameDBOptionsLUDBName)

		With frmMainMenu

TestForFile:
			boolresult = FileIO.FileSystem.FileExists(strFullPathFileName)

			Select Case boolresult
				Case True
					OpenCMDBFile = True

				Case False
					.OpenFileDialog1.InitialDirectory = strLastUsedFolder
					.OpenFileDialog1.Title = glbstrAppName & " - " & glbstrStrPleaseLocateDatabaseFile
					.OpenFileDialog1.Multiselect = False
					.OpenFileDialog1.DefaultExt = glbstrMDBExtension
					.OpenFileDialog1.Filter = glbstrCMDBOpenFileFilter
					.OpenFileDialog1.FileName = glbstrEmptyString
					.OpenFileDialog1.CheckFileExists = True
					.OpenFileDialog1.ShowDialog()
					strFullPathFileName = Trim(.OpenFileDialog1.FileName)
					If strFullPathFileName <> glbstrEmptyString Then
						strLastUsedFolder = IO.Path.GetDirectoryName(strFullPathFileName)
					End If

					Select Case strFullPathFileName
						Case glbstrEmptyString
							resultMsgBoxResult = MsgBox(glbstrStrPleaseFindDBFileMsgBoxPrompt, MsgBoxStyle.OkCancel + MsgBoxStyle.Information, glbstrStrPleaseLocateDatabaseFile)
							Select Case resultMsgBoxResult
								Case MsgBoxResult.Ok
									GoTo TestForFile
								Case Else
									boolCancel = True

							End Select
						Case Else
							GoTo TestForFile

					End Select

					If Not boolCancel Then
						GoTo TestForFile
					Else
						glbbolCancel = boolCancel
						Exit Function
					End If

			End Select

			glbstrDBConnectionString = CreateConnectionString(glbstrStrAccess, strFullPathFileName)
			OpenDatabaseConnection(glbstrStrAccess, glbstrDBConnectionString, .TSStatusLabStatus, .TSStatusLabCurrentDB, strFullPathFileName)

		End With


		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormMain, glbRegKeyNameMainMenuFolderDBLocation, strFullPathFileName)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameDBOptionsLUDBName, strFullPathFileName)
		AddValueToRegistry(glbRegKeyHKCU, glbstrRegKeyFormDBOptions, glbRegKeyNameDBOptionsLUF, strLastUsedFolder)

	End Function

	Public Function getOSVersion() As String

		Dim osinfo As System.OperatingSystem
		Dim platID As PlatformID

		osinfo = OSVersion
		getOSVersion = glbstrOSNotSupported

		With osinfo
			platID = .Platform

			Select Case platID

				Case PlatformID.Win32Windows
					Select Case (.Version.Minor)
						Case 0
							getOSVersion = "95"
						Case 10
							If .Version.Revision.ToString() = "2222A" Then
								getOSVersion = "98SE"
							Else
								getOSVersion = "98"
							End If
						Case 90
							getOSVersion = "Me"
					End Select

				Case PlatformID.Win32NT
					Select Case (.Version.Major)
						Case 3
							getOSVersion = "NT3.51"
						Case 4
							getOSVersion = "NT4.0"
						Case 5
							Select Case (.Version.Minor)
								Case 0
									getOSVersion = "2000"
								Case 1
									getOSVersion = glbstrOSVerXP
								Case 2
									getOSVersion = "Server2003"
							End Select
						Case 6
							Select Case (.Version.Minor)
								Case 0
									getOSVersion = glbstrOSVerVista
								Case 1
									getOSVersion = glbstrOSVer7
							End Select
					End Select
			End Select
		End With

	End Function

	Public Function IsContestManagerDBFound(ByVal strDBLocation As String) As Boolean

		If FileIO.FileSystem.FileExists(strDBLocation & glbstrBackSlash & glbstrCMDBName) Then
			IsContestManagerDBFound = True
		Else
			IsContestManagerDBFound = False
		End If

	End Function

	Public Function MouseEnterMenuItem(ByVal ControlIn As Label) As Boolean

		MouseEnterMenuItem = False

		If ControlIn.ForeColor <> Color.Red Then

			ControlIn.ForeColor = Color.Red

		End If

		MouseEnterMenuItem = True

	End Function

	Public Function MouseLeaveMenuItem(ByVal ControlIn As Label) As Boolean

		MouseLeaveMenuItem = False

		If ControlIn.ForeColor <> Color.Black Then

			ControlIn.ForeColor = Color.Black

		End If

		MouseLeaveMenuItem = True

	End Function

	Public Function FormPositionSet(ByVal frmIn As Form, ByVal RegKeyIn As String) As Boolean

		Dim dptemp As System.Drawing.Point

		FormPositionSet = False

		dptemp.X = GetValueFromRegistry(glbRegKeyHKCU, RegKeyIn, glbRegKeyPositionX)
		dptemp.Y = GetValueFromRegistry(glbRegKeyHKCU, RegKeyIn, glbRegKeyPositionY)

		If (dptemp.X = 1) And (dptemp.Y = 1) Then
			dptemp.X = glbintDefaultFormPosition
			dptemp.Y = glbintDefaultFormPosition
		Else
			frmIn.Location = dptemp

		End If

		FormPositionSet = True

	End Function

	Public Function ValidateDB(ByVal odConnectionIncoming As OleDb.OleDbConnection) As Boolean

		Dim sqlcmd As New OleDb.OleDbCommand

		ValidateDB = True

		frmMainMenu.TSStatusLabStatus.Text = glbstrStrValidatingDB

		sqlcmd.Connection = odConnectionIncoming

		For X As Integer = 1 To UBound(glbAryTableValidateStrings)
			sqlcmd.CommandText = glbAryTableValidateStrings(X)

			Try
				sqlcmd.ExecuteNonQuery()

			Catch ex As OleDb.OleDbException
				If ex.ErrorCode = glblngErrorCodeOLETableNotFound Then
					ValidateDB = False
				End If

				MessageBox.Show(ex.Message, glbstrStrOLEErrorDBException)
				'Exit Function

			Catch ex As Exception
				MessageBox.Show(ex.Message, glbstrStrOLEErrorGeneralException)
				'Exit Function

			End Try

		Next


		frmMainMenu.TSStatusLabStatus.Text = glbstrEmptyString

	End Function

	Public Function ValidateDBdao(ByVal inDaoDB As DAO.Database) As Boolean

		Dim tdf As DAO.TableDef
		Dim RST As DAO.Recordset
		Dim intTablesFound As Integer
		Dim intMaxTablesToFind As Integer
		Dim strSqL As String
		Dim props As Microsoft.Office.Interop.Access.Dao.Properties
		Dim prop As Microsoft.Office.Interop.Access.Dao.Property


		On Error GoTo VDBDErr

		ValidateDBdao = True

		frmMainMenu.TSStatusLabStatus.Text = glbstrStrValidatingDB


		intTablesFound = 0
		intMaxTablesToFind = UBound(glbAryTableNames)
		For Each tdf In glbDBDaoDB.TableDefs
			For x As Integer = 0 To intMaxTablesToFind
				If LCase(tdf.Name) = LCase(glbAryTableNames(x)) Then
					intTablesFound = intTablesFound + 1
				End If

			Next
		Next

		If intTablesFound = (intMaxTablesToFind + 1) Then
			ValidateDBdao = True
		Else
			ValidateDBdao = False
		End If

		GoTo VDBDDone
VDBDErr:
		Select Case Err()
			Case Else

		End Select
		Stop

VDBDDone:

		frmMainMenu.TSStatusLabStatus.Text = glbstrEmptyString

	End Function

	Public Function CheckForContestRecord() As Boolean

		If Not glbbolNetworkVersion Then
			Dim rst As DAO.Recordset

			rst = glbDBDaoDB.OpenRecordset(glbAryTableValidateStrings(glbintValidateTablePosContestSpecs))
			If rst.RecordCount <> 0 Then
				CheckForContestRecord = True
				glbintContestSpecEntryID = rst.Fields(glbstrStrDBTableFieldsDBContestSpecsEntryID).Value
			Else
				CheckForContestRecord = False
				glbintContestSpecEntryID = 0
			End If
		Else
			Dim sqlcmd As New OleDb.OleDbCommand
			Dim myDataReader As OleDb.OleDbDataReader

			sqlcmd.Connection = glbDBConn
			sqlcmd.CommandText = glbAryTableValidateStrings(glbintValidateTablePosContestSpecs)
			sqlcmd.CommandType = CommandType.Text

			myDataReader = sqlcmd.ExecuteReader
			If myDataReader.HasRows Then
				CheckForContestRecord = True
			Else
				CheckForContestRecord = False
			End If

			myDataReader.Close()
		End If

	End Function

	Public Function ReadContestRecord(frmCallingForm As Form) As Boolean

		ReadContestRecord = False

		If Not glbbolNetworkVersion Then

			Dim rst As DAO.Recordset

			rst = glbDBDaoDB.OpenRecordset(glbAryTableValidateStrings(glbintValidateTablePosContestSpecs))

			If rst.RecordCount <> 0 Then
				With rst
					glbintContestSpecEntryID = .Fields(glbstrStrDBTableFieldsDBContestSpecsEntryID).Value
					Select Case frmCallingForm.Name
						Case glbstrFormNameContestManagement
							frmContestManagement.txtboxContestName.Text = .Fields(glbstrStrDBTableFieldsDBContestSpecsContestName).Value
							frmContestManagement.dtpStartDate.Value = .Fields(glbstrStrDBTableFieldsDBContestSpecsStartDate).Value
							frmContestManagement.dtpEndDate.Value = .Fields(glbstrStrDBTableFieldsDBContestSpecsEndDate).Value
							frmContestManagement.dtpStartTime.Value = .Fields(glbstrStrDBTableFieldsDBContestSpecsStartTime).Value
							frmContestManagement.dtpEndTime.Value = .Fields(glbstrStrDBTableFieldsDBContestSpecsEndTime).Value
					End Select

				End With
				glbboolContestRecordFound = True
			Else
				glbboolContestRecordFound = False
				Stop
				' Place code to handle disappearing Contest Record

			End If
		Else

		End If

		ReadContestRecord = True


	End Function

End Module
