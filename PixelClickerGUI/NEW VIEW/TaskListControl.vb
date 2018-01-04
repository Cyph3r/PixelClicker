Imports System.Text
Imports Newtonsoft.Json
Imports PixelClickerGUI.Controller
Imports PixelClickerGUI.Model

Namespace NEW_VIEW
    Public Class TaskListControl
        Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
            PixelClickerFormRedesign.TaskEditControl.SetTask(New Model.Task(), True)
            PixelClickerFormRedesign.MaterialDivider2.Controls.Clear()
            PixelClickerFormRedesign.MaterialDivider2.Controls.Add(PixelClickerFormRedesign.TaskEditControl)
        End Sub

        Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
            If (TaskListView.SelectedObjects.Count = 0) Then Exit Sub
            Dim task = CType(TaskListView.SelectedObject, Task)
            PixelClickerFormRedesign.TaskEditControl.SetTask(task, False)
            PixelClickerFormRedesign.MaterialDivider2.Controls.Clear()
            PixelClickerFormRedesign.MaterialDivider2.Controls.Add(PixelClickerFormRedesign.TaskEditControl)
        End Sub
        Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
            ProgramStateHandler.RemoveTask(TaskListView.SelectedObjects.Cast (Of Task).ToArray())
            TaskListView.RemoveObjects(TaskListView.SelectedObjects)
            Profile.GetCurrentProfile.SaveProfile()
            PixelClickerFormRedesign.CommunityControl.LoadProfiles()
        End Sub

        Private Sub MainListView_SelectedIndexChanged(sender As Object, e As EventArgs) _
            Handles TaskListView.SelectedIndexChanged
            ButtonDelete.Enabled = TaskListView.SelectedObjects.Count >= 1 And Not ProgramStateHandler.State.Started
            ButtonEdit.Enabled = TaskListView.SelectedObjects.Count = 1
            If TaskListView.SelectedObject Is Nothing Then Exit Sub
            Dim task = CType(TaskListView.SelectedObject, Task)
            ProgramStateHandler.ChangeSelectedTask(task)
        End Sub

        Private Sub MainListView_DoubleClick(sender As Object, e As EventArgs) Handles TaskListView.DoubleClick
            If ProgramStateHandler.State.SelectedTask Is Nothing Then Exit Sub
            PixelClickerFormRedesign.TaskEditControl.SetTask(ProgramStateHandler.State.SelectedTask, False)
            PixelClickerFormRedesign.MaterialDivider2.Controls.Clear()
            PixelClickerFormRedesign.MaterialDivider2.Controls.Add(PixelClickerFormRedesign.TaskEditControl)
        End Sub

        Private Sub TaskListView_MouseDown(sender As Object, e As KeyEventArgs) Handles TaskListView.KeyUp
            If e.Control AndAlso e.KeyCode = keys.C AndAlso TaskListView.SelectedObjects.Count > 0 Then
                Dim stringBuilder As New StringBuilder
                stringBuilder.Append(JsonConvert.SerializeObject(TaskListView.SelectedObjects, Formatting.Indented))
                Clipboard.SetText(stringBuilder.ToString())
            ElseIf e.Control AndAlso e.KeyCode = keys.V Then
                Try
                    Dim settings As New JsonSerializerSettings()
                    settings.MissingMemberHandling = MissingMemberHandling.Error
                    Dim taskArray = JsonConvert.DeserializeObject(Of List(Of Task))(Clipboard.GetText(), settings)
                    ProgramStateHandler.AddTask(taskArray.ToArray())
                    ProgramStateHandler.ProcessTask(taskArray.ToArray())
                    TaskListView.AddObjects(taskArray.ToArray())

                    Profile.GetCurrentProfile.SaveProfile()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End Sub
    End Class
End NameSpace