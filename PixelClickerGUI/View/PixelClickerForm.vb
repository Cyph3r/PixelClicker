Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports PixelClickerGUI.Controller
Imports PixelClickerGUI.Model

Namespace View
    Public Class PixelClickerForm

        Private ReadOnly _translation As Translation = Translation.Instance()
        Private _programStateHandler As ProgramStateHandler = ProgramStateHandler.Instance()
        Private Sub PixelClickerForm_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
            StopTask()
        End Sub
        Private Sub MainListView_SelectedIndexChanged(sender As Object, e As EventArgs) _
            Handles MainListView.SelectedIndexChanged
            mDelete.Enabled = MainListView.SelectedObjects.Count >= 1 And Not ProgramStateHandler.State.Started
            mEdit.Enabled = MainListView.SelectedObjects.Count = 1
            If MainListView.SelectedObject Is Nothing Then Exit Sub
            Dim task = CType(MainListView.SelectedObject, Task)
            ProgramStateHandler.ChangeSelectedTask(task)
        End Sub
        Private Sub mNew_Click(sender As Object, e As EventArgs) Handles mNew.Click
            Dim task As New Task
            Dim taskWizad As New TaskWizardForm(task, Types.Task.NewTask)
            Select Case taskWizad.ShowDialog()
                Case DialogResult.OK
                    ProgramStateHandler.AddTask(task)
                    ProgramStateHandler.ProcessTask(task)
                    MainListView.AddObject(task)
            End Select
            taskWizad.Dispose()
        End Sub
        Private Sub mEdit_Click(sender As Object, e As EventArgs) Handles mEdit.Click
            Dim task = CType(MainListView.SelectedObject, Task)
            Dim taskWizad As New TaskWizardForm(task, Types.Task.EditTask)
            Select Case taskWizad.ShowDialog()
                Case DialogResult.OK
                    ProgramStateHandler.UpdateTaskSize()
            End Select
             Profile.GetCurrentProfile.SaveProfile()
            taskWizad.Dispose()
        End Sub
        Private Sub mDelete_Click(sender As Object, e As EventArgs) Handles mDelete.Click
            ProgramStateHandler.RemoveTask(MainListView.SelectedObjects.Cast (Of Task).ToArray())
            MainListView.RemoveObjects(MainListView.SelectedObjects)
        End Sub
        Private Sub mStartStop_Click(sender As Object, e As EventArgs) Handles mStartStop.Click
            StartStopTask()
        End Sub
        Private Sub StartStopTask()
            If ProgramStateHandler.State.Started Then
                StopTask()
            Else
                StartTask()
            End If
        End Sub
        Private Sub StopTask()
            If Not ProgramStateHandler.StopTasks() Then Exit Sub
            mStartStop.Text = My.Resources.PixelClickerForm_StopTask_Start
            mStartStop.Image = My.Resources.StartTask
            mDelete.Enabled = True
        End Sub
        Private Sub StartTask()
            If Not ProgramStateHandler.StartTasks() Then Exit Sub
            mStartStop.Text = My.Resources.PixelClickerForm_IsStarted__Stop
            mStartStop.Image = My.Resources.StopTask
            mDelete.Enabled = False
        End Sub
        Friend Sub ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
            try
                Dim oldImage As Image = pbProgress.Image
                Dim bitmap = DirectCast(e.UserState(0), Bitmap)
                Dim taskName As String = e.UserState(1)

                If Not String.IsNullOrEmpty(taskName) Then
                    Dim fontSize As Integer = e.UserState(2)
                    Dim tehFont As New Font("Arial", fontSize, FontStyle.Regular)
                    Using g As Graphics = Graphics.FromImage(bitmap)
                        g.SmoothingMode = SmoothingMode.HighQuality
                        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
                        g.CompositingQuality = CompositingQuality.HighQuality
                        g.TranslateTransform(0.0F, 0.0F)
                        g.DrawString(taskName, tehFont, Brushes.Green, New PointF(0, 0))
                    End Using
                End If

                If pbProgress.InvokeRequired Then
                    pbProgress.Invoke(Sub() 'lambda sub
                        Try
                            If Not bitmap Is Nothing Then
                                If Not oldImage Is Nothing Then oldImage.Dispose()
                                pbProgress.Image = bitmap
                                         end If
                        Catch ex As Exception
                                         End Try
                                         End Sub)
                Else
                    If Not oldImage Is Nothing Then oldImage.Dispose()
                    pbProgress.Image = bitmap
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub JoinDiscordToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles JoinDiscordToolStripMenuItem.Click
            Dim webAddress As String = "https://discord.gg/UebUkHc"
            Process.Start(webAddress)
        End Sub
        Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
            Dim webAddress As String = "http://botoverwatch.com"
            Process.Start(webAddress)
        End Sub
        Private Sub PixelClickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            My.Forms.PixelClickerForm.Text &= " v" & ProgramStateHandler.State.Version
            ColumnBotName.Text = _translation.ColumnBotName
            ColumnDebug.Text = _translation.ColumnDebug
            ColumnFps.Text = _translation.ColumnFps
            ColumnHotkey.Text = _translation.ColumnHotkey
            ColumnSearchArea.Text = _translation.ColumnSearchArea

            LabelStartStop.Text = "[F12] " & _translation.LabelStart & " \ " & _translation.LabelStop
            Controller.License.CheckLicense()
            MainListView.AddObjects(Profile.GetCurrentProfile.TaskList)
            ProgramStateHandler.ProcessTask(Profile.GetCurrentProfile.TaskList.ToArray())
        End Sub
        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
            MainListView.RefreshObjects(Profile.GetCurrentProfile.TaskList.ToArray())
        End Sub
        Private Sub stopStartTaskTimer_Tick(sender As Object, e As EventArgs) Handles stopStartTaskTimer.Tick
            If WindowsApi.GetAsyncKeyState(Keys.F12) Then
                StartStopTask()
            End If
            If ProgramStateHandler.State.SelectedTask Is Nothing Then Return 
            If WindowsApi.GetAsyncKeyState(Keys.Up)
                ProgramStateHandler.State.SelectedTask.YOffset -= 2
            ElseIf WindowsApi.GetAsyncKeyState(Keys.Down)
                ProgramStateHandler.State.SelectedTask.YOffset += 2
            ElseIf WindowsApi.GetAsyncKeyState(Keys.Right)
                ProgramStateHandler.State.SelectedTask.XOffset += 2
            ElseIf WindowsApi.GetAsyncKeyState(Keys.Left)
                ProgramStateHandler.State.SelectedTask.XOffset -= 2
            End If
        End Sub
    End Class
End NameSpace