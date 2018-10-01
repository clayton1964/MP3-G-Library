Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Access.Dao

Public Class frmContestManagement

	Dim RegKeyActive As String = glbstrRegKeyFormContestManage
	Dim localboolCreateContestRecord As Boolean = False
	'Dim localboolContestRecordFound As Boolean
	Dim localintContestHeaderEntryID As Integer


	Private Sub frmContestManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Dim intMsgBoxResult As MsgBoxResult

		FormPositionSet(Me, RegKeyActive)
		DisableCtrls()
		btnClose.Enabled = True

		Me.Show()

		If Not CheckForContestRecord() Then
			intMsgBoxResult = MsgBox(glbstrStrCreateNewContestRecord, MsgBoxStyle.Question + MsgBoxStyle.YesNo, glbstrAppName)
			Select Case intMsgBoxResult
				Case MsgBoxResult.Yes
					localboolCreateContestRecord = True
					btnCreate.Enabled = False
					txtboxContestName.Text = glbstrEmptyString
					dtpStartDate.Value = Today
					dtpEndDate.Value = DateAdd(DateInterval.Day, 1, dtpStartDate.Value)
					dtpStartTime.Value = DateValue(Today)
					dtpEndTime.Value = DateAdd(DateInterval.Hour, 12, dtpStartTime.Value)
					txtboxContestName.Focus()

				Case MsgBoxResult.No
					Me.Close()

			End Select
		Else
			If ReadContestRecord(Me) Then
				btnCreate.Visible = False
				EnableCtrls()
				txtboxContestName.SelectionStart = txtboxContestName.MaxLength
				txtboxContestName.SelectionLength = 0
				btnSave.Focus()
			End If

		End If

	End Sub

	Private Sub frmContestManagement_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged

		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionX, Me.Location.X)
		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionY, Me.Location.Y)

	End Sub


	Private Sub DisableCtrls()


		GBoxContestHeader.Visible = True

		txtboxContestName.Enabled = True
		dtpStartDate.Enabled = True
		dtpEndDate.Enabled = True
		dtpStartTime.Enabled = True
		dtpEndTime.Enabled = True

		GBoxCategories.Visible = False

		btnCatAdd.Enabled = False
		btnCatDelete.Enabled = False
		btnCatOptAdd.Enabled = False
		btnCatOptDelete.Enabled = False
		lboxCategories.Enabled = False
		lboxCatOptions.Enabled = False


		'GBoxQSOInfo.Visible = False

		'DGVColumnSpecs.Enabled = False
		'btnQSOAdd.Visible = False
		'btnQSODel.Visible = False
		'btnQSODown.Visible = False
		'btnQSOUp.Visible = False

		btnSave.Enabled = False
		btnClose.Enabled = False


	End Sub

	Private Sub EnableCtrls()

		GBoxContestHeader.Visible = True

		txtboxContestName.Enabled = True
		txtboxContestName.Visible = True
		dtpStartDate.Enabled = True
		dtpStartDate.Visible = True
		dtpEndDate.Enabled = True
		dtpEndDate.Visible = True
		dtpStartTime.Enabled = True
		dtpStartTime.Visible = True
		dtpEndTime.Enabled = True
		dtpEndTime.Visible = True

		GBoxCategories.Visible = True

		btnCatAdd.Enabled = True
		btnCatAdd.Visible = True
		btnCatDelete.Enabled = False
		btnCatDelete.Visible = True
		btnCatOptAdd.Enabled = True
		btnCatOptAdd.Visible = True
		btnCatOptDelete.Enabled = False
		btnCatOptDelete.Visible = True

		lboxCategories.Enabled = True
		lboxCategories.Visible = True
		lboxCatOptions.Enabled = True
		lboxCatOptions.Visible = True

		'GBoxQSOInfo.Visible = True

		'DGVColumnSpecs.Enabled = True
		'btnQSOAdd.Enabled = True
		'btnQSOAdd.Visible = True
		'btnQSODel.Enabled = True
		'btnQSODel.Visible = True
		'btnQSODown.Enabled = False
		'btnQSODown.Visible = True
		'btnQSOUp.Enabled = False
		'btnQSOUp.Visible = True

		btnSave.Enabled = True
		btnSave.Visible = True
		btnClose.Enabled = True
		btnClose.Visible = True

	End Sub

	Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub


	Private Sub txtboxContestName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtboxContestName.TextChanged

		If txtboxContestName.TextLength = 0 Then
			If Not glbboolContestRecordFound Then
				btnCreate.Enabled = False
				btnCreate.Visible = True
				btnSave.Visible = False
				btnSave.Enabled = False
			Else
				btnCreate.Enabled = False
				btnCreate.Visible = False
				btnSave.Visible = True
				btnSave.Enabled = False
			End If

		Else

			If Not glbboolContestRecordFound Then
				btnCreate.Visible = True
				btnCreate.Enabled = True
				btnSave.Visible = False
				btnSave.Enabled = False
			Else
				btnCreate.Visible = False
				btnCreate.Visible = False
				btnSave.Visible = True
				btnSave.Enabled = True
			End If

		End If

	End Sub

	Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click


		Dim rst As Recordset

			rst = glbDBDaoDB.OpenRecordset(glbAryTableValidateStrings(glbintValidateTablePosContestSpecs))
			If rst.RecordCount <> 0 Then
				With rst
					SetFieldValues(rst)
					.Update()
					.Bookmark = .LastModified
				End With
			Else
				With rst
					.AddNew()
					SetFieldValues(rst)
					.Update()
					.Bookmark = .LastModified
				End With

			End If

			EnableCtrls()
		btnCreate.Visible = False
		btnCreate.Enabled = False

	End Sub

	Public Function CreateDataAdapter(ByVal selectCommand As String, ByVal connection As OleDbConnection) As OleDbDataAdapter

		Dim adapter As OleDbDataAdapter = _
		    New OleDbDataAdapter(selectCommand, connection)

		adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey

		' Create the commands.
		adapter.InsertCommand = New OleDbCommand( _
		    "INSERT INTO ContestSpecs (ContestName, StartDate, EndDate. StartTime, EndTime) VALUES (?, ?, ?, ?)")

		adapter.UpdateCommand = New OleDbCommand( _
		    "UPDATE ContestSpecs SET ContestName = ?, StartDate = ?, EndDate = ?, StartTime = ?, StartTime = ? " & _
		    "WHERE CustomerID = ?")

		adapter.DeleteCommand = New OleDbCommand( _
		    "DELETE FROM ContestSpecs WHERE CustomerID = ?")

		' Create the parameters.
		adapter.InsertCommand.Parameters.Add("@ContestName", OleDbType.Char, 50, "ContestName")
		adapter.InsertCommand.Parameters.Add("@StartDate", OleDbType.DBDate, 40, "StartDate")
		adapter.InsertCommand.Parameters.Add("@EndDate", OleDbType.DBDate, 40, "EndDate")
		adapter.InsertCommand.Parameters.Add("@StartTime", OleDbType.DBDate, 40, "StartTime")
		adapter.InsertCommand.Parameters.Add("@EndTime", OleDbType.DBDate, 40, "EndTime")

		adapter.UpdateCommand.Parameters.Add("@ContestName", OleDbType.Char, 50, "ContestName")
		adapter.UpdateCommand.Parameters.Add("@StartDate", OleDbType.DBDate, 40, "StartDate")
		adapter.UpdateCommand.Parameters.Add("@EndDate", OleDbType.DBDate, 40, "EndDate")
		adapter.UpdateCommand.Parameters.Add("@StartTime", OleDbType.DBDate, 40, "StartTime")
		adapter.UpdateCommand.Parameters.Add("@EndTime", OleDbType.DBDate, 40, "EndTime")
		adapter.UpdateCommand.Parameters.Add("@oldEntryID", OleDbType.Integer, 5, "EntryID").SourceVersion = DataRowVersion.Original

		adapter.DeleteCommand.Parameters.Add("@EntryID", OleDbType.Integer, 5, "EntryID").SourceVersion = DataRowVersion.Original

		CreateDataAdapter = adapter

	End Function


    Private Function SetFieldValues(rstIn As Recordset) As Boolean

        SetFieldValues = False
        With rstIn
            .Fields(glbstrStrDBTableFieldsDBContestSpecsContestName).Value = txtboxContestName.Text
            .Fields(glbstrStrDBTableFieldsDBContestSpecsStartDate).Value = dtpStartDate.Value
            .Fields(glbstrStrDBTableFieldsDBContestSpecsEndDate).Value = dtpEndDate.Value
            .Fields(glbstrStrDBTableFieldsDBContestSpecsStartTime).Value = dtpStartTime.Value
            .Fields(glbstrStrDBTableFieldsDBContestSpecsEndTime).Value = dtpEndTime.Value

        End With
        SetFieldValues = True

    End Function






End Class