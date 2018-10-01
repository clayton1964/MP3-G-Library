Imports Microsoft.VisualBasic
Imports System
Imports System.Security.Permissions
Imports Microsoft.Win32

Module mdlRegistry

	Public Function RegExist(ByVal strRegKeyIn As String) As Boolean
		Dim rkTempRegAppKey As RegistryKey

		RegExist = False
		rkTempRegAppKey = Registry.CurrentUser.OpenSubKey(strRegKeyIn, True)

		If Not rkTempRegAppKey Is Nothing Then
			RegExist = True
		Else
			RegExist = False
		End If

	End Function



	Public Function AddValueToRegistry(ByVal MainRegKey As String, ByVal strRegKeyToUse As String, ByVal ValueName As String, ByVal Value As Object) As Boolean

		Dim regkeyToSet As RegistryKey
		Dim vartype As Type

		On Error GoTo AVTRError

		AddValueToRegistry = False

		regkeyToSet = Nothing

		Select Case MainRegKey
			Case glbRegKeyHKCU
				regkeyToSet = Registry.CurrentUser.OpenSubKey(strRegKeyToUse, True)
				If regkeyToSet Is Nothing Then
					regkeyToSet = Registry.CurrentUser.CreateSubKey(strRegKeyToUse)
				End If

			Case glbRegKeyHKLM
				regkeyToSet = Registry.LocalMachine.OpenSubKey(strRegKeyToUse, True)
				If regkeyToSet Is Nothing Then
					regkeyToSet = Registry.LocalMachine.CreateSubKey(strRegKeyToUse)
				End If

		End Select

		vartype = Value.GetType
		Select Case vartype.Name
			Case "Int32"
				regkeyToSet.SetValue(ValueName, Value, RegistryValueKind.DWord)
			Case "String", "Char"
				regkeyToSet.SetValue(ValueName, Value, RegistryValueKind.String)
			Case "Boolean"
				regkeyToSet.SetValue(ValueName, Value, RegistryValueKind.DWord)
			Case "Double", "Decimal", "Single", "Byte"
				regkeyToSet.SetValue(ValueName, Value, RegistryValueKind.Unknown)

		End Select

		GoTo AVTREnd
AVTRError:
		Select Case Err()
			Case Else
                'Debug.Print(Err.Description)
				Resume AVTREnd
		End Select

AVTREnd:

		regkeyToSet.Close()

		AddValueToRegistry = True

	End Function

	Public Function GetValueFromRegistry(ByVal RegistryHiveIn As String, ByVal strRegKeyToUse As String, ByVal ValueName As String) As Object

		Dim regkeyToReadFrom As RegistryKey
		Dim ReadValue As Object
		Dim regValKind As RegistryValueKind
		Dim vartype As String

		regValKind = RegistryValueKind.None
		GetValueFromRegistry = vbNull
		regkeyToReadFrom = Nothing

		Select Case RegistryHiveIn
			Case glbRegKeyHKCU
				regkeyToReadFrom = Registry.CurrentUser.OpenSubKey(strRegKeyToUse)
			Case glbRegKeyHKLM
				regkeyToReadFrom = Registry.LocalMachine.OpenSubKey(strRegKeyToUse)
		End Select

		If regkeyToReadFrom Is Nothing Then
			GetValueFromRegistry = vbNull
			Exit Function
		End If

		ReadValue = regkeyToReadFrom.GetValue(ValueName, vbNull)
		'If ReadValue <> vbNull Then
		vartype = ReadValue.GetType.Name
		Select Case vartype
			Case "VariantType"
				GetValueFromRegistry = vbNull
				regkeyToReadFrom.Close()

				Exit Function

			Case Else

		End Select
		regValKind = regkeyToReadFrom.GetValueKind(ValueName)

		'End If

		Select Case regValKind
			Case RegistryValueKind.DWord
				GetValueFromRegistry = CInt(ReadValue)
			Case RegistryValueKind.String
				GetValueFromRegistry = CStr(ReadValue)
			Case RegistryValueKind.Binary
				GetValueFromRegistry = CInt(ReadValue)
			Case RegistryValueKind.QWord
				GetValueFromRegistry = CLng(ReadValue)
			Case RegistryValueKind.None
				GetValueFromRegistry = vbNull

		End Select

		regkeyToReadFrom.Close()

	End Function



End Module
