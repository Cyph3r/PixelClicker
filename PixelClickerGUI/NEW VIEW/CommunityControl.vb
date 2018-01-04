Imports System.IO
Imports System.Text
Imports MaterialSkin
Imports Newtonsoft.Json
Imports PixelClickerGUI.Controller
Imports PixelClickerGUI.Model

Namespace NEW_VIEW
    Public Class CommunityControl
        Private Sub CommunityControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadProfiles()
        End Sub

        Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
             If ProfileList.SelectedObjects.Count > 1 Then Exit Sub
             Profile.SetCurrentProfile(DirectCast(ProfileList.SelectedObjects(0), Profile))
             If Profile.GetCurrentProfile.TaskList.Count > 0 Then ProgramStateHandler.ChangeSelectedTask(Profile.GetCurrentProfile.TaskList(0))
        End Sub

        Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
            If ProfileList.SelectedObjects.Count = 0 Then Exit Sub
            For Each selected As Profile In ProfileList.SelectedObjects
                If File.Exists(selected.Source) Then File.Delete(selected.Source)
            Next

            ProfileList.RemoveObjects(ProfileList.SelectedObjects)
        End Sub

        Public Sub LoadProfiles()
             If Not Directory.Exists(".\Profiles") Then Exit Sub
             ProfileList.Items.Clear()
            Dim str As String 
             For Each fileName In Directory.GetFiles(".\Profiles")
                str = ""
                Using sr As New StreamReader(fileName)
                    str = sr.ReadToEnd()
			    End Using

                Dim profile = JsonConvert.DeserializeObject(Of Profile)(str)
                profile.Source = fileName
				ProfileList.AddObject(profile)
             Next
        End Sub

        Private Sub ButtonSaveAsProfile_Click(sender As Object, e As EventArgs) Handles ButtonSaveAsProfile.Click
            If SaveAsProfile.ShowDialog(PixelClickerFormRedesign) = DialogResult.OK Then
                 LoadProfiles()
            End If
        End Sub

        Private Sub ProfileList_KeyUp(sender As Object, e As KeyEventArgs) Handles ProfileList.KeyUp
            If e.Control AndAlso e.KeyCode = keys.C AndAlso ProfileList.SelectedObjects.Count > 0 Then
                Dim stringBuilder As New StringBuilder
                stringBuilder.Append(JsonConvert.SerializeObject(ProfileList.SelectedObjects, Formatting.Indented))
                Clipboard.SetText(stringBuilder.ToString())
            ElseIf e.Control AndAlso e.KeyCode = keys.V Then
                Try
                    Dim settings As New JsonSerializerSettings()
                    settings.MissingMemberHandling = MissingMemberHandling.Error
                    Dim taskArray = JsonConvert.DeserializeObject(Of List(Of Profile))(Clipboard.GetText(), settings)

                    For Each profile As Profile In taskArray
                        profile.SaveProfile()
                    Next

                    ProfileList.AddObjects(taskArray.ToArray())
                Catch
                End Try
            End If
        End Sub
    End Class
End NameSpace