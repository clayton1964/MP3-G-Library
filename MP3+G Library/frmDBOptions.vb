Imports Microsoft.Office.Interop.Access
Imports Microsoft.Win32
Imports Microsoft.SqlServer
Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Windows.Forms

Public Class frmDBOptions

	Dim RegKeyActive As String = glbstrRegKeyFormDBOptions

	Private Sub frmDBOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Dim objTemp As Object
		Dim dsTemp As System.Drawing.Size

		dsTemp.Height = glbintfrmDBOptionsSizeHeight
		dsTemp.Width = glbintfrmDBOptionsSizeWidth
		Me.Size = dsTemp

		FormPositionSet(Me, RegKeyActive)

		TSStatusLabStatus.Text = glbstrEmptyString

		txtBoxFilename.Text = glbstrEmptyString
		txtBoxFolder.Text = glbstrEmptyString
		btnOpen.Enabled = False

		'Enable Controls on Form
		TabControl1.Enabled = True
		txtBoxFolder.Enabled = True
		btnBrowse.Enabled = True
		btnClose.Enabled = True
		txtBoxFilename.Enabled = True
		chkboxSelectAfterCreate.Enabled = True
		lvDBList.Enabled = True
		btnCreateDB.Enabled = False
		btnOpen.Enabled = False
		btnBrowse.Text = glbstrStrBrowse
		txtBoxFolder.Visible = True
		lblFldrServer.Text = glbstrStrFolder
		lblFNorDBN.Text = glbstrStrFileName

		objTemp = GetValueFromRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameDBOptionsLUF)
		If objTemp.Equals(vbNull) Then
			txtBoxFolder.Text = FileIO.SpecialDirectories.MyDocuments
		Else
			txtBoxFolder.Text = objTemp.ToString
		End If

		txtBoxSelectedDB.Text = glbstrCurrentDBName
		txtBoxSelectedDBType.Text = glbstrCurrentDBType


	End Sub

	Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

		Dim strFilenameTempStr As String = glbstrEmptyString
		Dim strDBTempStr As String = glbstrEmptyString
		Dim bolOKToProceed As Boolean

		bolOKToProceed = False

		strFilenameTempStr = txtBoxSelectedDB.Text
		strDBTempStr = txtBoxSelectedDBType.Text


		If Not FileIO.FileSystem.FileExists(strFilenameTempStr) Then
					bolOKToProceed = False
					MsgBox(glbstrStrDBNotExist, MsgBoxStyle.Question And MsgBoxStyle.Critical, glbstrStrFileMissing)
					txtBoxSelectedDB.Text = glbstrEmptyString
					txtBoxSelectedDBType.Text = glbstrEmptyString
				Else
					bolOKToProceed = True

				End If



				If bolOKToProceed Then

			glbstrDBConnectionString = CreateConnectionString(glbstrStrAccess, strFilenameTempStr)
					OpenDatabaseConnection(glbstrStrAccess, glbstrDBConnectionString, TSStatusLabStatus, frmMainMenu.TSStatusLabCurrentDB, strFilenameTempStr)
					ValidateDBdao(glbDBDaoDB)



					AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameDBOptionsLUDBName, glbstrCurrentDBName)

			Me.Close()

		End If



	End Sub

	Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub

	Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

		Dim strTempOrigFolder As String
		Dim strTempNewFolder As String


		strTempOrigFolder = txtBoxFolder.Text

				FolderBrowserDialog1.ShowDialog()
				strTempNewFolder = AppendBSlashToFolderName(FolderBrowserDialog1.SelectedPath)

				Select Case strTempNewFolder
					Case glbstrEmptyString
						txtBoxFolder.Text = strTempOrigFolder
					Case Else
						txtBoxFolder.Text = strTempNewFolder

				End Select

		TSStatusLabStatus.Text = glbstrEmptyString

	End Sub

	Private Sub btnCreateDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateDB.Click

		Dim strNewDBName As String = glbstrEmptyString
		Dim strNewDBType As String = glbstrEmptyString
		Dim strDBConnectionStrTemp As String = glbstrEmptyString

		Cursor = Cursors.WaitCursor
		TSStatusLabStatus.Text = glbstrStrCreatingNewDB

		'Disable Other Controls on Form
		TabControl1.Enabled = False
		txtBoxFolder.Enabled = False
		btnBrowse.Enabled = False
		btnClose.Enabled = False
		btnOpen.Enabled = False
		txtBoxFilename.Enabled = False
		chkboxSelectAfterCreate.Enabled = False
		lvDBList.Enabled = False
		btnCreateDB.Enabled = False


PickFileName:

				strNewDBName = txtBoxFolder.Text & txtBoxFilename.Text & glbstrMDBExtension
				strNewDBType = glbstrStrAccess

				If FileIO.FileSystem.FileExists(strNewDBName) Then
					Dim result As MsgBoxResult
					result = MsgBox("File Exists!" & vbCrLf & "Overwrite existing file?", MsgBoxStyle.YesNo, "File Exists...")
					Select Case result
						Case MsgBoxResult.Yes
							FileIO.FileSystem.DeleteFile(strNewDBName)
						Case MsgBoxResult.No
							GoTo PickFileName
					End Select
				End If

				strDBConnectionStrTemp = CreateConnectionString(glbstrStrAccess, strNewDBName)

                CreateNewDatabase(strDBConnectionStrTemp, glbstrStrAccess, strNewDBName)



		OpenDatabaseConnection(strNewDBType, strDBConnectionStrTemp, TSStatusLabStatus, frmMainMenu.TSStatusLabCurrentDB, strNewDBName)

        CreateDefaultTables(strNewDBType)

		CloseDatabaseConnection(glbDBConn)

		txtBoxFolder.Text = GetValueFromRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameDBOptionsLUF)
		txtBoxFilename.Text = glbstrEmptyString

		Select Case chkboxSelectAfterCreate.Checked
			Case True
				txtBoxSelectedDB.Text = strNewDBName
				glbstrDBConnectionString = strDBConnectionStrTemp
				glbstrCurrentDBName = txtBoxSelectedDB.Text
				glbstrCurrentDBType = strNewDBType

			Case False
				txtBoxSelectedDB.Text = glbstrEmptyString
				txtBoxSelectedDBType.Text = glbstrEmptyString

		End Select

		chkboxSelectAfterCreate.Checked = False

		're-Enable Other Controls on Form
		TabControl1.Enabled = True
		txtBoxFolder.Enabled = True
		btnBrowse.Enabled = True
		btnClose.Enabled = True
		txtBoxFilename.Enabled = True
		chkboxSelectAfterCreate.Enabled = True
		lvDBList.Enabled = True
		btnCreateDB.Enabled = False

		TSStatusLabStatus.Text = glbstrEmptyString
		Cursor = Cursors.Arrow

	End Sub

	Private Sub frmDBOptions_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged

		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionX, Me.Location.X)
		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionY, Me.Location.Y)

	End Sub

	Private Sub txtBoxFolder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxFolder.TextChanged

		txtBoxFolder.Text = AppendBSlashToFolderName(txtBoxFolder.Text)
		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameDBOptionsLUF, txtBoxFolder.Text)

	End Sub



	Private Function CreateNewDatabase(ByVal ConnectionStrIn As String, ByVal DBTypeIn As String, strDBFileNameIn As String) As Boolean

		CreateNewDatabase = False

		' Create blank database
		Try
			If glbbolUseDAO Then
				glbDBDaoDB = glbDBDaoDBE.CreateDatabase(strDBFileNameIn, ";LANGID=0x0409;CP=1252")
				glbDBDaoDB.Close()

			Else
				Dim newDB As New ADOX.Catalog
				newDB.Create(ConnectionStrIn)
				newDB.ActiveConnection = Nothing
				CreateNewDatabase = True

			End If

		Catch ex As Exception
			CreateNewDatabase = False

		End Try

	End Function

	Private Function CreateDefaultTables(ByVal DBTypeIn As String) As Boolean

        CreateDefaultTables = False

        TSStatusLabStatus.Text = glbstrStrCreatingNewTables

		Dim tdfnew As DAO.TableDef
		Dim fldnew As Dao.Field
                Dim indexNew As Dao.Index
                Dim prpNew As Dao.Property


                'Create DBSettings Table
                tdfnew = glbDBDaoDB.CreateTableDef(glbstrStrDBTableNameDBSettings)
                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBSettingsEntryID)
                fldnew.Required = True
                fldnew.Type = 4
                fldnew.Attributes = 17
                tdfnew.Fields.Append(fldnew)

                indexNew = tdfnew.CreateIndex(glbstrStrPrimaryKey)
                indexNew.Unique = True
                indexNew.Primary = True
                indexNew.IgnoreNulls = False

                fldnew = indexNew.CreateField(glbstrStrDBTableFieldsDBSettingsEntryID)
                indexNew.Fields.append(fldnew)

                tdfnew.Indexes.Append(indexNew)

                indexNew = Nothing
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBSettingsEntryDateTime)
                fldnew.Required = True
                fldnew.Type = 8
                tdfnew.Fields.Append(fldnew)

                glbDBDaoDB.TableDefs.Append(tdfnew)
                tdfnew = Nothing

                'Create Contest Specs Table
                tdfnew = glbDBDaoDB.CreateTableDef(glbstrStrDBTableNameContestSpecs)

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBContestSpecsEntryID)
                fldnew.Required = True
                fldnew.Type = 4
                fldnew.Attributes = 17
                tdfnew.Fields.Append(fldnew)

                indexNew = tdfnew.CreateIndex(glbstrStrPrimaryKey)
                indexNew.Unique = True
                indexNew.Primary = True
                indexNew.IgnoreNulls = False

                fldnew = indexNew.CreateField(glbstrStrDBTableFieldsDBContestSpecsEntryID)
                indexNew.Fields.append(fldnew)

                tdfnew.Indexes.Append(indexNew)

                indexNew = Nothing
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBContestSpecsContestName)
                fldnew.Required = True
                fldnew.Type = 10
                fldnew.Size = 50
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBContestSpecsStartDate)
                fldnew.Required = True
                fldnew.Type = 8
                'prpNew = fldnew.CreateProperty(glbstrStrFormat, , glbstrStrShortDate)
                'prpNew.Value = glbstrStrShortDate
                'fldnew.Properties.Append(prpNew)
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing
                prpNew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBContestSpecsStartTime)
                fldnew.Required = True
                fldnew.Type = 8
                'prpNew = fldnew.CreateProperty(glbstrStrFormat, 10, glbstrStrShortDate, False)
                'fldnew.Properties.Append(prpNew)
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing
                prpNew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBContestSpecsEndDate)
                fldnew.Required = True
                fldnew.Type = 8
                'prpNew = fldnew.CreateProperty(glbstrStrFormat, , glbstrStrShortDate)
                'prpNew.Value = glbstrStrShortDate
                'fldnew.Properties.Append(prpNew)
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing
                prpNew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBContestSpecsEndTime)
                fldnew.Required = True
                fldnew.Type = 8
                'prpNew = fldnew.CreateProperty(glbstrStrFormat, 10, glbstrStrShortDate, False)
                'fldnew.Properties.Append(prpNew)
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing
                prpNew = Nothing

                glbDBDaoDB.TableDefs.Append(tdfnew)
                tdfnew = Nothing

                'Create Category Table
                tdfnew = glbDBDaoDB.CreateTableDef(glbstrStrDBTableNameCategory)

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBCategoryEntryID)
                fldnew.Required = True
                fldnew.Type = 4
                fldnew.Attributes = 17
                tdfnew.Fields.Append(fldnew)

                indexNew = tdfnew.CreateIndex(glbstrStrPrimaryKey)
                indexNew.Unique = True
                indexNew.Primary = True
                indexNew.IgnoreNulls = False

                fldnew = indexNew.CreateField(glbstrStrDBTableFieldsDBCategoryEntryID)
                indexNew.Fields.append(fldnew)

                tdfnew.Indexes.Append(indexNew)

                indexNew = Nothing
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsDBCategoryName)
                fldnew.Required = True
                fldnew.Type = 10
                fldnew.Size = 30
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing

                glbDBDaoDB.TableDefs.Append(tdfnew)
                tdfnew = Nothing

                'Create Category Options
                tdfnew = glbDBDaoDB.CreateTableDef(glbstrStrDBTableNameCategoryOptions)

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsCategoryOptionsEntryID)
                fldnew.Required = True
                fldnew.Type = 4
                fldnew.Attributes = 17
                tdfnew.Fields.Append(fldnew)

                indexNew = tdfnew.CreateIndex(glbstrStrPrimaryKey)
                indexNew.Unique = True
                indexNew.Primary = True
                indexNew.IgnoreNulls = False

                fldnew = indexNew.CreateField(glbstrStrDBTableFieldsCategoryOptionsEntryID)
                indexNew.Fields.append(fldnew)

                tdfnew.Indexes.Append(indexNew)

                indexNew = Nothing
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsCategoryOptionsCategoryID)
                fldnew.Required = True
                fldnew.Type = 4
                tdfnew.Fields.Append(fldnew)

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsCategoryOptionsOptionName)
                fldnew.Required = True
                fldnew.Type = 10
                fldnew.Size = 128
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsCategoryOptionsOptionValue)
                fldnew.Required = True
                fldnew.Type = 10
                fldnew.Size = 30
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing

                'Create QSO Specs
                tdfnew = glbDBDaoDB.CreateTableDef(glbstrStrDBTableNameQSOSpecs)

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsQSOSpecsEntryID)
                fldnew.Required = True
                fldnew.Type = 4
                fldnew.Attributes = 17
                tdfnew.Fields.Append(fldnew)

                indexNew = tdfnew.CreateIndex(glbstrStrPrimaryKey)
                indexNew.Unique = True
                indexNew.Primary = True
                indexNew.IgnoreNulls = False

                fldnew = indexNew.CreateField(glbstrStrDBTableFieldsQSOSpecsEntryID)
                indexNew.Fields.append(fldnew)

                tdfnew.Indexes.Append(indexNew)

                indexNew = Nothing
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsQSOSpecsFieldName)
                fldnew.Required = True
                fldnew.Type = 10
                fldnew.Size = 50
                tdfnew.Fields.Append(fldnew)
                fldnew = Nothing

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsQSOSpecsColStart)
                fldnew.Required = True
                fldnew.Type = 4
                tdfnew.Fields.Append(fldnew)

                fldnew = tdfnew.CreateField(glbstrStrDBTableFieldsQSOSpecsColEnd)
                fldnew.Required = True
                fldnew.Type = 4
                tdfnew.Fields.Append(fldnew)

				' here()

				glbDBDaoDB.TableDefs.Append(tdfnew)
                tdfnew = Nothing





		TSStatusLabStatus.Text = glbstrEmptyString

        CreateDefaultTables = True

    End Function

	Private Sub txtBoxFilename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxFilename.TextChanged

		If txtBoxFilename.Text <> glbstrEmptyString Then
			btnCreateDB.Enabled = True

		Else
			btnCreateDB.Enabled = False

		End If

	End Sub

    Private Sub FindSQLServers(ByVal cmbBoxIn As System.Windows.Forms.ComboBox)

        Dim strServerName As String = glbstrEmptyString
        Dim strServerInstance As String = glbstrEmptyString

        TSStatusLabStatus.Text = glbstrStrFindingSQLServers
        Cursor = Cursors.WaitCursor
        TabControl1.Enabled = False
        btnBrowse.Enabled = False
        btnClose.Enabled = False
        chkboxSelectAfterCreate.Enabled = False

        ' Retrieve the enumerator instance and then the data.
        Dim instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
        Dim table As System.Data.DataTable = instance.GetDataSources()
        cmbBoxIn.Items.Clear()

        For Each row As DataRow In table.Rows
            For Each col As DataColumn In table.Columns
                Select Case col.ColumnName
                    Case "ServerName"
                        strServerName = row(col)

                    Case "InstanceName"
                        If IsDBNull(row(col)) Then
                            strServerInstance = glbstrEmptyString
                        Else
                            strServerInstance = row(col)
                        End If
                End Select
            Next
            cmbBoxIn.Items.Add(strServerName & glbstrBackSlash & strServerInstance)

        Next

        TabControl1.Enabled = True
        btnBrowse.Enabled = True
        btnClose.Enabled = True
        chkboxSelectAfterCreate.Enabled = True
        cmbBoxIn.DroppedDown = True
        Cursor = Cursors.Arrow
        TSStatusLabStatus.Text = glbstrEmptyString

    End Sub


	Private Sub lvDBList_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDBList.ItemActivate

		Dim strItem1 As String
		Dim strItem2 As String
		Dim strItem3 As String

		strItem1 = lvDBList.SelectedItems.Item(0).SubItems.Item(0).Text
		strItem2 = lvDBList.SelectedItems.Item(0).SubItems.Item(1).Text
		strItem3 = lvDBList.SelectedItems.Item(0).SubItems.Item(2).Text

		txtBoxSelectedDB.Text = AppendBSlashToFolderName(strItem3) & strItem1
		txtBoxSelectedDBType.Text = strItem2

	End Sub

	Private Sub txtBoxSelectedDB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxSelectedDB.TextChanged

		If Len(txtBoxSelectedDB.Text) <> 0 Then
			btnOpen.Enabled = True

		Else
			btnOpen.Enabled = False

		End If
	End Sub

	Private Sub TStripStatusLabel1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSStatusLabStatus.TextChanged

		Me.Refresh()

	End Sub

End Class