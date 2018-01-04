Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Model
    Public Class Translation
        Private Shared _instance As Translation
        Private Shared ReadOnly LanguageCode As String =  CultureInfo.CurrentCulture.TwoLetterISOLanguageName
        Private Sub New()
        End Sub

        Public Shared Function Instance() As Translation
            If _instance IsNot Nothing Then
                Return _instance
            Else
                If File.Exists($".\Translations\translation.{languageCode}.json") Then
                    Try
                        _instance = LoadSetting()
                    Catch
                        MessageBox.Show(TranslateGoogle($"Invalid translation file '\Translations\translation.{languageCode}.json' creating a new one.", "en", LanguageCode))
                        NewInstance()
                    End Try
                Else
                    NewInstance()
                End If

                Return _instance
            End If
        End Function

        Private Shared Sub NewInstance()
            _instance = New Translation()
            If Not languageCode.Equals("en") Then
                MessageBox.Show(TranslateGoogle($"No translation file found '\Translations\translation.{languageCode}.json' Auto translating!" +
                $"Edit translation file named translation.{languageCode}.json to use your native language", "en", LanguageCode))
                _instance.TryTranslateForEach()
            End If

            System.IO.Directory.CreateDirectory(".\Translations")
            _instance.SaveSetting()
        End Sub
        Private Sub TryTranslateForEach()
            Me.ColumnBotName = TranslateGoogle(Me.ColumnBotName, "en", LanguageCode)
            Me.ColumnHotkey = TranslateGoogle(Me.ColumnHotkey, "en", LanguageCode)
            Me.ColumnFps = TranslateGoogle(Me.ColumnFps, "en", LanguageCode)
            Me.ColumnSearchArea = TranslateGoogle(Me.ColumnSearchArea, "en", LanguageCode)
            Me.ColumnDebug = TranslateGoogle(Me.ColumnDebug, "en", LanguageCode)
            Me.LabelExpiration = TranslateGoogle(Me.LabelExpiration, "en", LanguageCode)
            Me.LabelStart = TranslateGoogle(Me.LabelStart, "en", LanguageCode)
            Me.LabelStop = TranslateGoogle(Me.LabelStop, "en", LanguageCode)
            Me.FormTaskWizard = TranslateGoogle(Me.FormTaskWizard, "en", LanguageCode)
            Me.CheckBoxDrawOnGame = TranslateGoogle(Me.CheckBoxDrawOnGame, "en", LanguageCode)
            Me.CheckBoxDebugMode = TranslateGoogle(Me.CheckBoxDebugMode, "en", LanguageCode)
            Me.GroupBoxBotType = TranslateGoogle(Me.GroupBoxBotType, "en", LanguageCode)
            Me.RadioButtonAim = TranslateGoogle(Me.RadioButtonAim, "en", LanguageCode)
            Me.RadioButtonTrigger = TranslateGoogle(Me.RadioButtonTrigger, "en", LanguageCode)
            Me.GroupBoxSearchSettings = TranslateGoogle(Me.GroupBoxSearchSettings, "en", LanguageCode)
            Me.LabelHotkey = TranslateGoogle(Me.LabelHotkey, "en", LanguageCode)
            Me.LabelSearchAreaWidth = TranslateGoogle(Me.LabelSearchAreaWidth, "en", LanguageCode)
            Me.LabelSearchAreaHeight = TranslateGoogle(Me.LabelSearchAreaHeight, "en", LanguageCode)
            Me.LabelAimXOffset = TranslateGoogle(Me.LabelAimXOffset, "en", LanguageCode)
            Me.LabelAimYOffset = TranslateGoogle(Me.LabelAimYOffset, "en", LanguageCode)
            Me.LabelAimBotMoveSpeed = TranslateGoogle(Me.LabelAimBotMoveSpeed, "en", LanguageCode)
            Me.LabelAntiShake = TranslateGoogle(Me.LabelAntiShake, "en", LanguageCode)
            Me.LabelLineChecks = TranslateGoogle(Me.LabelLineChecks, "en", LanguageCode)
            Me.LabelHitChance = TranslateGoogle(Me.LabelHitChance, "en", LanguageCode)
            Me.RadioButtonNoClick = TranslateGoogle(Me.RadioButtonNoClick, "en", LanguageCode)
            Me.RadioButtonHoldClick = TranslateGoogle(Me.RadioButtonHoldClick, "en", LanguageCode)
            Me.RadioButtonSingleClick = TranslateGoogle(Me.RadioButtonSingleClick, "en", LanguageCode)
            Me.GroupBoxColors = TranslateGoogle(Me.GroupBoxColors, "en", LanguageCode)
            Me.LabelDragMe = TranslateGoogle(Me.LabelDragMe, "en", LanguageCode)
            Me.CheckBoxUsePremadeShades = TranslateGoogle(Me.CheckBoxUsePremadeShades, "en", LanguageCode)
            Me.ButtonDeleteSelected = TranslateGoogle(Me.ButtonDeleteSelected, "en", LanguageCode)
            Me.ColumnColor = TranslateGoogle(Me.ColumnColor, "en", LanguageCode)
            Me.ColumnShadeVariation = TranslateGoogle(Me.ColumnShadeVariation, "en", LanguageCode)
            Me.ButtonOk = TranslateGoogle(Me.ButtonOk, "en", LanguageCode)
            Me.ButtonCancel = TranslateGoogle(Me.ButtonCancel, "en", LanguageCode)
            Me.GameName = TranslateGoogle(Me.GameName, "en", LanguageCode)
        End Sub
        Private Sub SaveSetting()
            Dim settings As String = JsonConvert.SerializeObject(Me, Formatting.Indented)

            Using sw As New StreamWriter($".\Translations\translation.{languageCode}.json", False)
                sw.WriteLine(settings)
            End Using
        End Sub

        Private Shared Function LoadSetting() As Translation
            Using _
                sr As _
                    New StreamReader(
                        $".\Translations\translation.{languageCode}.json")
                Return JsonConvert.DeserializeObject (Of Translation)(sr.ReadToEnd())
            End Using
        End Function
        
        Public Shared Function TranslateGoogle(text As String, fromCulture As String, toCulture As String) As String

			Try
				' Create an url.
				Dim url As [String] = "https://translate.googleapis.com/translate_a/single?client=gtx" + "&sl=" + fromCulture + "&tl=" + toCulture + "&dt=t&q=" + HttpUtility.UrlEncode(text)

				' Create a request that looks like it came from a normal Google Translate session.
				Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
				request.Proxy = Nothing
				' Disable proxy lookup. Saves us around 7 seconds of waiting for one (which might not even exist).
				request.Host = "translate.google.com"
				request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0"
				' Mozilla Firefox 19.0. Windows 7 64-bit. Updated 23/2 - 2013.
				' Get the response.
				Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

				' Read the data.
				Dim stream As Stream = response.GetResponseStream()
				Dim result As String = ""
				Dim buf As Byte() = New Byte(8191) {}
				Dim count As Integer = 0
				While (InlineAssignHelper(count, stream.Read(buf, 0, buf.Length))) > 0
					result += Encoding.UTF8.GetString(buf, 0, count)
				End While

				' Parse the received data as a JSON array.
				Dim arr As JArray = DirectCast(JsonConvert.DeserializeObject(result), JArray)
				Dim translatedObject As JValue = DirectCast(DirectCast(DirectCast(arr(0), JArray)(0), JArray)(0), JValue)
				'Them casts.
				Dim translatedMessage As String = DirectCast(translatedObject.Value, String)

				Return translatedMessage
			Catch
				' An invalid message, non-existant translation language or network error could cause the main application to crash.
				' Return the original message if any of these erros occurred.

				Return text
			End Try
		End Function
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

        Public ColumnBotName As String = "Bot Name"
        Public ColumnHotkey As String = "Hotkey"
        Public ColumnFps As String = "FPS"
        Public ColumnSearchArea As String = "Search Area"
        Public ColumnDebug As String = "Debug?"

        Public LabelExpiration As String = "Expiration: "
        Public LabelStart As String = "START"
        Public LabelStop As String = "STOP"

        Public FormTaskWizard As String = "Task Wizard"
        Public CheckBoxDrawOnGame As String = "Draw On Game"
        Public CheckBoxDebugMode As String = "Debug Mode"

        Public GroupBoxBotType As String = "Bot Type"
        Public RadioButtonAim As String = "Aim"
        Public RadioButtonTrigger As String = "Trigger"

        Public GroupBoxSearchSettings As String = "Search Settings"
        Public LabelHotkey As String = "Hotkey:"
        Public LabelSearchAreaWidth As String = "Search Area Width:"
        Public LabelSearchAreaHeight As String = "Search Area Height:"
        Public LabelAimXOffset As String = "Aim X Offset:"
        Public LabelAimYOffset As String = "Aim Y Offset:"
        Public LabelAimBotMoveSpeed As String = "Aim Bot Move Speed:"
        Public LabelAntiShake As String = "Anti-Shake:"
        Public LabelLineChecks As String = "Line Checks:"
        Public LabelHitChance As String = "Hit Chance %:"
        Public RadioButtonNoClick As String = "No Click"
        Public RadioButtonHoldClick As String = "Hold Click"
        Public RadioButtonSingleClick As String = "Singe Click"

        Public GroupBoxColors As String = "Colors"
        Public LabelDragMe As String = "Drag me!"
        Public CheckBoxUsePremadeShades As String = "Use Premade Shades"
        Public ButtonDeleteSelected As String = "Delete Selected"
        Public ColumnColor As String = "Color"
        Public ColumnShadeVariation As String = "Shade Variation"
        Public ButtonOk As String = "OK"
        Public ButtonCancel As String = "Cancel"

        Public GameName As String = "Overwatch"
    End Class
End NameSpace