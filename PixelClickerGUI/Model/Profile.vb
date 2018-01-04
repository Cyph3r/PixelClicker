Imports System.IO
Imports Newtonsoft.Json
Imports PixelClickerGUI.Controller
Imports PixelClickerGUI.NEW_VIEW

Namespace Model
    Public Class Profile
        Private Shared _instance As Profile

        Private _name As String
        Public Property Name As String
            Get
                return _name
            End Get
            Set
                Dim oldName As String = _name
                _name = value

                Try
                    SaveProfile()
                    If String.IsNullOrEmpty(oldName) Then Return
                    If Not oldName.Equals(_name) Then
                        DeleteMe(oldName)
                    End If
                Catch
                End Try
            End Set
        End Property

        Private _description As String = "This is a new profile description"

        Private Sub DeleteMe(name As String)
            Try
                File.Delete( $".\Profiles\{name}.json")
            Catch
            End Try
        End Sub
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set
                _description = value
                SaveProfile()
            End Set
        End Property

        Public TaskList As TaskListy = New TaskListy()
        Public Source As String = "Local"

        Public Function Clone() As Profile
            Dim clonedProfile As New Profile
            clonedProfile.Name = me.Name
            clonedProfile.Description = me.Description
            clonedProfile.TaskList = me.TaskList

            Return clonedProfile
        End Function
        Public Shared Sub SetCurrentProfile(profile As Profile)
            Dim started As Boolean = ProgramStateHandler.State.Started
            PixelClickerFormRedesign.TaskListControl.TaskListView.RemoveObjects(_instance.TaskList.ToArray())
            ProgramStateHandler.StopTasks()
            _instance = profile

            PixelClickerFormRedesign.TaskListControl.TaskListView.AddObjects(_instance.TaskList.ToArray())
            ProgramStateHandler.ProcessTask(_instance.TaskList.ToArray())
            GlobalSettings.Settings.LastProfilePath = $".\Profiles\{_instance.Name}.json"
            GlobalSettings.Settings.SaveSetting()

            If started Then ProgramStateHandler.StartTasks()
		End Sub

        Public Shared Function GetCurrentProfile() As Profile
			If _instance IsNot Nothing Then
				Return _instance
			Else
				If File.Exists(GlobalSettings.Settings.LastProfilePath) Then
					_instance = LoadProfile(GlobalSettings.Settings.LastProfilePath)
				Else
					_instance = New Profile()
                    _instance.Name = "Default"
					_instance.SaveProfile()
				End If

				Return _instance
			End If
		End Function
		Public Sub SaveProfile()
            If String.IsNullOrEmpty(_name) Then Exit Sub
            System.IO.Directory.CreateDirectory(".\Profiles")
			Dim settings As String = JsonConvert.SerializeObject(Me, Formatting.Indented)
			Using sw As New StreamWriter($".\Profiles\{_name}.json", False)
				sw.WriteLine(settings)
			End Using
		End Sub
        Private LoadingMe As Boolean = False
		Private Shared Function LoadProfile(path As String) As Profile
            Dim str As String
			Using sr As New StreamReader(path)
                str = sr.ReadToEnd()
			End Using

            Return JsonConvert.DeserializeObject(Of Profile)(str)
		End Function


     Public Class TaskListy 
        Inherits  List(Of Task)
    End Class
    End Class
End NameSpace