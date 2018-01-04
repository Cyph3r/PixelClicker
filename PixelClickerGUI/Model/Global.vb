Imports System.IO
Imports Newtonsoft.Json
Imports PixelClicker.Controller


Namespace Model
    Public Class GlobalSettings 
		Private Shared _instance As GlobalSettings

		Public Sub New()
		End Sub

		Public Shared Function Settings() As GlobalSettings
			If _instance IsNot Nothing Then
				Return _instance
			Else
				If File.Exists("GlobalSettings.json") Then
					_instance = LoadSetting()
				Else
					_instance = New GlobalSettings()
					_instance.SaveSetting()
				End If

				Return _instance
			End If
		End Function


		Public Sub SaveSetting()
			Dim settings As String = JsonConvert.SerializeObject(Me, Formatting.Indented)

			Using sw As New StreamWriter("GlobalSettings.json", False)
				sw.WriteLine(settings)
			End Using
		End Sub
		Private Shared Function LoadSetting() As GlobalSettings
            Dim str As String
			Using sr As New StreamReader("GlobalSettings.json")
                str = sr.ReadToEnd()
			End Using

			Return JsonConvert.DeserializeObject(Of GlobalSettings)(str)
		End Function

        Public Debug As Boolean = False
        Public DrawOnGame As Boolean = True
        Public GameName As String = "Overwatch"
        Public TopMost As Boolean = False
        Public LastProfilePath As String = ".\Profiles\Default.json"
    End Class
End NameSpace