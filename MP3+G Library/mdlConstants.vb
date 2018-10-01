Imports Microsoft.Win32

Module mdlConstants

	Public Const glbstrAppName As String = "Karaoke Library"
	Public Const glbstrCopyright As String = "©2018 Clayton Mattatall"
	Public Const glbstrAppVersion As String = "0.1.0"
	Public Const glbbolNetworkVersion As Boolean = False
	Public Const glbbolUseDAO As Boolean = True

	'General System Constants

	Public Const glbstrOSVerXP As String = "XP"
	Public Const glbstrOSVerVista As String = "Vista"
	Public Const glbstrOSVer7 As String = "7"
	Public Const glbstrOSNotSupported As String = "OS Not Supported"
	Public Const glbintDefaultFormPosition As Integer = 60

	' General Registry Keys
	Public Const glbRegKeyHKCU As String = "HKCU"
	Public Const glbRegKeyHKLM As String = "HKLM"

	' App Registry Data
	Public Const glbRegKeyAppMain As String = "Software\SDP\Karaoke Library"
	Public Const glbRegKeyNameMain As String = "Main"
	Public Const glbRegKeyNameMainMenuFolderDBLocation As String = "DBLocation"
	Public Const glbRegKeyNameDBOptions As String = "DBOptions"
	Public Const glbRegKeyNameDBOptionsLUDBName As String = "LUDBName"
	Public Const glbRegKeyNameDBOptionsLUF As String = "LUF"
	Public Const glbRegKeyNameAppSettings As String = "Settings"
	Public Const glbRegKeyNameAppSettingsAutoOpen As String = "AutoOpenDB"

	' Form Names
	Public Const glbstrFormNameContestManagement As String = "frmContestManagement"

	Public Const glbRegKeyPositionX As String = "PositionX"
	Public Const glbRegKeyPositionY As String = "PositionY"

	' Menu Item Setup Conditions

	Public Const glbintMenuItemSetupDatabaseOpened As Integer = 1
	Public Const glbintMenuItemSetupDatabaseClosed As Integer = 2

	' Form Sizes
	Public Const glbintfrmDBOptionsSizeWidth = 447
	Public Const glbintfrmDBOptionsSizeHeight = 372

	' Database 
	Public Const glbstrAccessConnectionStrPart1 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
	Public Const glbstrAccessConnectionStrPart2Orig As String = ";Persist Security Info=True;Jet OLEDB:Database Password=fc3sgtr"
	Public Const glbstrAccessConnectionStrPart2 As String = ";User Id=admin;Password=;"
	Public Const glbstrBackSlash As String = "\"
	Public Const glbstrCMDBName As String = "Karaoke_Library.mdb"
	Public Const glbstrCMDBOpenFileFilter As String = "Database Files|*.mdb"
	Public Const glbstrEmptyString As String = ""
	Public Const glbstrForwardSlash As String = "/"
	Public Const glbstrHyphen As String = " - "
	Public Const glbstrMDBExtension As String = ".mdb"
	Public Const glbstrMRU As String = "mru"
	Public Const glbstrSemiColon As String = ";"
	Public Const glbstrSQL As String = "sql"
	Public Const glbstrSQLConnectionStrPart1 As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source="

	Public Const glbstrStrAccess As String = "Access"
	Public Const glbstrStrAlreadyExists As String = "already exists."
	Public Const glbstrStrBrowse As String = "Browse..."
	Public Const glbstrStrCreateNewContestRecord As String = "Create new Entry?"
	Public Const glbstrStrDatabaseName As String = "Database"
	Public Const glbstrStrDBNotExist As String = "Database does not exist!"
	Public Const glbstrStrFileMissing As String = "File missing..."
	Public Const glbstrStrFileName As String = "Filename"
	Public Const glbstrStrFolder As String = "Folder"
	Public Const glbstrStrOLEErrorDBException As String = "OleDbException"
	Public Const glbstrStrOLEErrorGeneralException As String = "GeneralException"
	Public Const glbstrStrPleaseFindDBFileMsgBoxPrompt As String = "Please locate the library DB file.  Otherwise, press 'Cancel' to create a new one."
	Public Const glbstrStrPleaseLocateDatabaseFile As String = "Please locate the library database file..."
	Public Const glbstrStrPrimaryKey As String = "PrimaryKey"
	Public Const glbstrStrRefresh As String = "Refresh"
	Public Const glbstrStrServers As String = "Servers"

	' Data validation Error Messages
	Public Const glbstrStrPleaseCorrectTheseErrors As String = "Please correct these Errors:"
	Public Const glbstrStrContestNameCanNotBeBlank As String = "Track Name can not be blank"


	'ToolStrip Status Messages
	Public Const glbstrStrClosingDB As String = "Closing Database..."
	Public Const glbstrStrCreatingNewDB As String = "Creating new Database..."
	Public Const glbstrStrCreatingNewTables As String = "Creating new tables..."
	Public Const glbstrStrFindingSQLServers As String = "Finding SqL Servers..."
	Public Const glbstrStrLoadingMRU As String = "Loading MRU table..."
	Public Const glbstrStrOpeningDB As String = "Opening Database..."
	Public Const glbstrStrValidatingDB As String = "Validating Database File..."

	'Error Codes
	Public Const glblngErrorCodeOLETableNotFound As Long = -2147217865

	Public Const glbintMaxMRU As Integer = 10

	'DB Table Constants
	Public Const glbstrStrFormat As String = "Format"
	Public Const glbstrStrShortDate As String = "Short Date"

	Public Const glbstrStrDBTableNameDBSettings As String = "DBSettings"
	Public Const glbstrStrDBTableNameContestSpecs As String = "ContestSpecs"
	Public Const glbstrStrDBTableNameCategory As String = "Category"
	Public Const glbstrStrDBTableNameCategoryOptions As String = "CategoryOptions"
	Public Const glbstrStrDBTableNameQSOSpecs As String = "QSOSpecs"

	Public Const glbstrStrDBTableFieldsDBSettingsEntryID As String = "EntryID"
	Public Const glbstrStrDBTableFieldsDBSettingsEntryDateTime As String = "EntryDateTime"

	Public Const glbstrStrDBTableFieldsDBContestSpecsEntryID As String = "EntryID"
	Public Const glbstrStrDBTableFieldsDBContestSpecsContestName As String = "ContestName"
	Public Const glbstrStrDBTableFieldsDBContestSpecsStartDate As String = "StartDate"
	Public Const glbstrStrDBTableFieldsDBContestSpecsEndDate As String = "EndDate"
	Public Const glbstrStrDBTableFieldsDBContestSpecsStartTime As String = "StartTime"
	Public Const glbstrStrDBTableFieldsDBContestSpecsEndTime As String = "EndTime"

	Public Const glbstrStrDBTableFieldsDBCategoryEntryID As String = "EntryID"
	Public Const glbstrStrDBTableFieldsDBCategoryName As String = "CategoryName"

	Public Const glbstrStrDBTableFieldsCategoryOptionsEntryID As String = "EntryID"
	Public Const glbstrStrDBTableFieldsCategoryOptionsCategoryID As String = "CategoryID"
	Public Const glbstrStrDBTableFieldsCategoryOptionsOptionName As String = "OptionName"
	Public Const glbstrStrDBTableFieldsCategoryOptionsOptionValue As String = "OptionValue"


	Public Const glbstrStrDBTableFieldsQSOSpecsEntryID As String = "EntryID"
	Public Const glbstrStrDBTableFieldsQSOSpecsContestID As String = "ContestID"
	Public Const glbstrStrDBTableFieldsQSOSpecsFieldName As String = "FieldName"
	Public Const glbstrStrDBTableFieldsQSOSpecsColStart As String = "ColStart"
	Public Const glbstrStrDBTableFieldsQSOSpecsColEnd As String = "ColEnd"

	Public Const glbintValidateTablePosDBSettings As Integer = 0
	Public Const glbintValidateTablePosContestSpecs As Integer = 1
	Public Const glbintValidateTablePosCategory As Integer = 2
	Public Const glbintValidateTablePosCategoryOptions As Integer = 3

	'General SQL Statments
	Public Const glbstrSQLCommandSelectAllFrom As String = "SELECT * FROM "
	Public Const glbstrSQLCommandUpdate As String = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID"


End Module

