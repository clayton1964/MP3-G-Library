Imports Microsoft.Office.Interop.Access.Dao
Module mdlVariables

	Public glbbolApplicationToQuit As Boolean = False
	Public glbbolCancel As Boolean = False

	Public glbstrRegKeyFormMain As String
	Public glbstrRegKeyFormDBOptions As String
	Public glbstrRegKeyFormContestManage As String
	Public glbstrRegKeyFormAppSettings As String
	Public glbstrRegKeyFormQSOSpecs As String
	Public glbstrRegKeyFormPreferences As String

	Public glbstrCurrentDBName As String = ""
	Public glbstrCurrentDBType As String = ""
	Public glbbolLoadLastDB As Boolean = False

	Public glbstrCMDBLocation As String = ""

	Public glbDBDaoDBE As New DBEngine
	Public glbDBDaoDB As Database

	Public glbDBConn As New Object

	Public glbstrDBConnectionString As String = glbstrEmptyString

	Public glbAryTableValidateStrings() As String = {glbstrSQLCommandSelectAllFrom & glbstrStrDBTableNameDBSettings,
	 glbstrSQLCommandSelectAllFrom & glbstrStrDBTableNameContestSpecs,
	 glbstrSQLCommandSelectAllFrom & glbstrStrDBTableNameCategory,
	 glbstrSQLCommandSelectAllFrom & glbstrStrDBTableNameCategoryOptions}

	Public glbAryTableNames() As String = {glbstrStrDBTableNameDBSettings,
		   glbstrStrDBTableNameContestSpecs,
		   glbstrStrDBTableNameCategory,
		   glbstrStrDBTableNameCategoryOptions}

	Public glbintContestSpecEntryID As Integer = 0
	Public glbboolContestRecordFound As Boolean = False
	Public glbintHighestColNumber As Integer = 0


End Module
