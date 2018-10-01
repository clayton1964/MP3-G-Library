Imports Microsoft.Office.Interop.Access.Dao


Public Class frmQSOFieldLayout
	Dim RegKeyActive As String = glbstrRegKeyFormQSOSpecs


	Private Sub frmQSOFieldLayout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

		FormPositionSet(Me, RegKeyActive)
		LoadFormValuesFromRegistry()
		btnClose.Enabled = True

		Me.Show()

		txtbFieldName.Focus()

		If LoadLV() Then
			btnQSOAdd.Enabled = False
			btnQSODel.Enabled = False
		Else
			btnQSOAdd.Enabled = False
			btnQSODel.Enabled = False
		End If

	End Sub

	Private Sub frmQSOFieldLayout_LocationChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.LocationChanged

		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionX, Me.Location.X)
		AddValueToRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyPositionY, Me.Location.Y)

	End Sub

	Public Sub LoadFormValuesFromRegistry()

		Dim objTemp As Object

		GoTo EndOfLoadFormValuesFromRegistry

		objTemp = GetValueFromRegistry(glbRegKeyHKCU, RegKeyActive, glbRegKeyNameMainMenuFolderDBLocation)
		If objTemp.Equals(vbNull) Then

		Else
			' cboxBands.Text = objTemp.ToString
		End If


EndOfLoadFormValuesFromRegistry:

	End Sub

	Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub

	Private Function LoadLV() As Boolean

		Dim rst As Recordset
		Dim strtemp As String

		LoadLV = False

		If glbboolContestRecordFound Then

			lvQSO.Items.Clear()

			If Not glbbolNetworkVersion Then
				rst = glbDBDaoDB.OpenRecordset("SELECT QSOSpecs.* FROM QSOSpecs ORDER BY QSOSpecs.ColStart")
			Else
				' Change this to the version for a SQL Connection
				rst = glbDBDaoDB.OpenRecordset("SELECT QSOSpecs.* FROM QSOSpecs ORDER BY QSOSpecs.ColStart")

			End If

			With rst
				If rst.RecordCount <> 0 Then
					rst.MoveFirst()
				End If

				While ((Not .BOF) And (Not .EOF))
					strtemp = rst.Fields(glbstrStrDBTableFieldsQSOSpecsFieldName).Value
					Dim lvi As New ListViewItem(strtemp, 0)

					lvi.Name = (rst.Fields(glbstrStrDBTableFieldsQSOSpecsFieldName).Value)
					lvi.SubItems.Add(rst.Fields(glbstrStrDBTableFieldsQSOSpecsColStart).Value)
					lvi.SubItems.Add(rst.Fields(glbstrStrDBTableFieldsQSOSpecsColEnd).Value)

					lvQSO.Items.Add(lvi)

					lvi = Nothing

					.MoveNext()
				End While
				LoadLV = True
			End With

		End If

		FindHighestColNumber(glbintHighestColNumber)

	End Function



	Private Sub btnQSOAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnQSOAdd.Click

		Dim lvi As New ListViewItem(txtbFieldName.Text, 0)

		lvi.Name = txtbFieldName.Text
		lvi.SubItems.Add(nudStartCol.Value)
		lvi.SubItems.Add(nudEndCol.value)

		lvQSO.Items.Add(lvi)

		lvi = Nothing

		FindHighestColNumber(glbintHighestColNumber)

	End Sub

	Private Sub txtbFieldName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbFieldName.TextChanged

		If txtbFieldName.TextLength = 0 Then
			btnQSOAdd.Enabled = False
		Else
			btnQSOAdd.Enabled = True
		End If

	End Sub



	Private Sub lvQSO_ItemSelectionChanged(sender As System.Object, e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvQSO.ItemSelectionChanged

		If e.Item.Selected Then
			btnQSODel.Enabled = True
		Else
			btnQSODel.Enabled = False
		End If

	End Sub

	Private Sub btnQSODel_Click(sender As System.Object, e As System.EventArgs) Handles btnQSODel.Click

		lvQSO.SelectedItems.Item(0).Remove()

		btnQSODel.Enabled = False

		FindHighestColNumber(glbintHighestColNumber)

	End Sub

	Private Sub lvQSO_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvQSO.SelectedIndexChanged

		If lvQSO.Items.Count = 0 Then
			btnQSODel.Enabled = False
		End If

	End Sub

	Private Sub nudStartCol_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudStartCol.ValueChanged, nudEndCol.ValueChanged

		Dim intTemp As Integer = 0
		Dim lvi As ListViewItem

		If nudStartCol.Value = 0 Then
			btnQSOAdd.Enabled = False
			txtbFieldName.Enabled = False
		Else
			btnQSOAdd.Enabled = True
			txtbFieldName.Enabled = True
		End If

		For Each lvi In lvQSO.Items
			intTemp = CInt(lvi.SubItems(1).Text)
			If intTemp = nudStartCol.Value Then
				lblInUse.Visible = True
				Exit For
			Else
				lblInUse.Visible = False
			End If
		Next

		txtbFieldName.Enabled = Not (lblInUse.Visible)
		btnQSOAdd.Enabled = Not (lblInUse.Visible)

		lvi = Nothing

		If nudStartCol.Value > nudEndCol.Value Then
			nudEndCol.Value = nudStartCol.Value + 1
		End If

	End Sub

	Private Function FindHighestColNumber(intHighestCol As Integer) As Boolean

		Dim intTemp As Integer = 0
		Dim lvi As ListViewItem

		FindHighestColNumber = False

		For Each lvi In lvQSO.Items
			intTemp = CInt(lvi.SubItems(1).Text)
			If intTemp <> intHighestCol Then
				intHighestCol = intTemp
			End If
		Next

		FindHighestColNumber = True

		lvi = Nothing

		nudStartCol.Value = intHighestCol + 1

	End Function

End Class