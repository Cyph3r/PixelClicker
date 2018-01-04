Imports MaterialSkin
Imports PixelClicker.Interfaces
Imports PixelClickerGUI.Controller
Imports PixelClickerGUI.Model


Namespace NEW_VIEW
    Public Class PixelClickerFormRedesign
        Friend Shared ReadOnly TaskEditControl As New TaskEditControl
        Friend Shared ReadOnly SettingsControl As New SettingsControl
        Friend Shared ReadOnly TaskListControl As New TaskListControl
        Friend Shared ReadOnly DebugControl As New DebugControl
        Friend Shared ReadOnly CommunityControl As New CommunityControl
        Friend Shared ReadOnly ContactUsControl As New ContactUsControl
        Friend Shared ReadOnly EventControl As New EventControl

        Friend MaterialSkinManager As MaterialSkinManager
       ' Private ReadOnly _translation As Translation = Translation.Instance()
        Private _programStateHandler As ProgramStateHandler = ProgramStateHandler.Instance()

        Private Sub PixelClickerFormRedesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Controller.License.CheckLicense()
            ' Initialize MaterialSkinManager
            MaterialSkinManager = MaterialSkinManager.Instance
            MaterialSkinManager.AddFormToManage(Me)
            SettingsControl.SwitchTheme(MaterialSkinManager.Themes.DARK)
            MaterialSkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

            TaskEditControl.PanelEditBotClickType.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditBotClickTypeDescription.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditBotType.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditBotTypeDescription.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditBotSettings.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditBotSettingsDescription.BackColor = Color.FromArgb(38,50,56)

            TaskEditControl.PanelEditSearchMethod.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditSearchMethodDescription.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditSearchArea.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditSearchAreaDescription.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditSearchAdvanced.BackColor = Color.FromArgb(38,50,56)
            TaskEditControl.PanelEditSearchAdvancedDescription.BackColor = Color.FromArgb(38,50,56)

            SettingsControl.PanelGlobalSettings.BackColor = Color.FromArgb(38,50,56)
            SettingsControl.PanelGlobalSettingsDescription.BackColor = Color.FromArgb(38,50,56)

            SaveAsProfile.PanelProfileDescription.BackColor = Color.FromArgb(38,50,56)
            SaveAsProfile.PanelProfileName.BackColor = Color.FromArgb(38,50,56)

             ' Initialize MaterialSkinManager

            SettingsControl.Dock = DockStyle.Fill
            TaskEditControl.Dock = DockStyle.Fill
            TaskListControl.Dock = DockStyle.Fill
            DebugControl.Dock = DockStyle.Fill
            CommunityControl.Dock = DockStyle.Fill
            EventControl.Dock = DockStyle.Fill
            ContactUsControl.Dock = DockStyle.Fill

            LabelVersion.Text = "Version: " & ProgramStateHandler.State.Version

            Controller.License.CheckLicense()
            TaskListControl.TaskListView.AddObjects(Profile.GetCurrentProfile.TaskList)
            ProgramStateHandler.ProcessTask(Profile.GetCurrentProfile.TaskList.ToArray())
            If Profile.GetCurrentProfile.TaskList.Count > 0 Then ProgramStateHandler.ChangeSelectedTask(Profile.GetCurrentProfile.TaskList(0))
             Me.TopMost = GlobalSettings.Settings.TopMost
             Me.MaterialDivider2.Controls.Add(TaskListControl)
        End Sub
        Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
            IF Not ProgramStateHandler.State.SelectedTask Is Nothing Then ProgramStateHandler.State.SelectedTask.Controller.ReportProgress = False
             Me.MaterialDivider2.Controls.Clear()
             SettingsControl.SetSettings()
             Me.MaterialDivider2.Controls.Add(SettingsControl)
             PanelMainSelector.Location = New Point(PanelMainSelector.Location.X,sender.Location.Y)
        End Sub
        Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
            IF Not ProgramStateHandler.State.SelectedTask Is Nothing Then ProgramStateHandler.State.SelectedTask.Controller.ReportProgress = False
            Me.MaterialDivider2.Controls.Clear()
            Me.MaterialDivider2.Controls.Add(TaskListControl)
            PanelMainSelector.Location = New Point(PanelMainSelector.Location.X,sender.Location.Y)
        End Sub

        Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
            IF Not ProgramStateHandler.State.SelectedTask Is Nothing Then ProgramStateHandler.State.SelectedTask.Controller.ReportProgress = True
            Me.MaterialDivider2.Controls.Clear()
            Me.MaterialDivider2.Controls.Add(DebugControl)
            PanelMainSelector.Location = New Point(PanelMainSelector.Location.X,sender.Location.Y)
        End Sub

        Private Sub ButtonEvent_Click(sender As Object, e As EventArgs) 
            IF Not ProgramStateHandler.State.SelectedTask Is Nothing Then ProgramStateHandler.State.SelectedTask.Controller.ReportProgress = False
            Me.MaterialDivider2.Controls.Clear()
            Me.MaterialDivider2.Controls.Add(EventControl)
            PanelMainSelector.Location = New Point(PanelMainSelector.Location.X,sender.Location.Y)
        End Sub

        Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
            IF Not ProgramStateHandler.State.SelectedTask Is Nothing Then ProgramStateHandler.State.SelectedTask.Controller.ReportProgress = False
            Me.MaterialDivider2.Controls.Clear()
           ' Me.MaterialDivider2.Controls.Add(ContactUsControl)
            PanelMainSelector.Location = New Point(PanelMainSelector.Location.X,sender.Location.Y)
        End Sub
        Private Sub ButtonCommunity_Click(sender As Object, e As EventArgs) Handles ButtonCommunity.Click
            IF Not ProgramStateHandler.State.SelectedTask Is Nothing Then ProgramStateHandler.State.SelectedTask.Controller.ReportProgress = False
            Me.MaterialDivider2.Controls.Clear()
            Me.MaterialDivider2.Controls.Add(CommunityControl)
            PanelMainSelector.Location = New Point(PanelMainSelector.Location.X,sender.Location.Y)
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
            mStartStop.Icon = My.Resources.StartTask
            TaskListControl.ButtonDelete.Enabled = True
        End Sub
        Private Sub StartTask()
            If Not ProgramStateHandler.StartTasks() Then Exit Sub
            mStartStop.Text = My.Resources.PixelClickerForm_IsStarted__Stop
            mStartStop.Icon = My.Resources.StopTask
            TaskListControl.ButtonDelete.Enabled = False
        End Sub
        Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
            TaskListControl.TaskListView.RefreshObjects(Profile.GetCurrentProfile.TaskList.ToArray())

           If ProgramStateHandler.State.SelectedTask Is Nothing Then
               LabelSelectedTask.Text = String.Format(LabelSelectedTask.Tag, "None")
           Else
               LabelSelectedTask.Text = String.Format(LabelSelectedTask.Tag, ProgramStateHandler.State.SelectedTask.BotName)
           End If
           
           
           LabelSelectedProfile.Text = String.Format(LabelSelectedProfile.Tag, Profile.GetCurrentProfile.Name)
        End Sub

        Private Sub stopStartTaskTimer_Tick(sender As Object, e As EventArgs) Handles stopStartTaskTimer.Tick
            If WindowsApi.GetAsyncKeyState(Keys.F12) Then
                StartStopTask()
            End If

            If ProgramStateHandler.State.SelectedTask Is Nothing Then Return 

            If WindowsApi.GetAsyncKeyState(Keys.Up)
                ProgramStateHandler.State.SelectedTask.YOffset -= 2
                Profile.GetCurrentProfile.SaveProfile()
            ElseIf WindowsApi.GetAsyncKeyState(Keys.Down)
                ProgramStateHandler.State.SelectedTask.YOffset += 2
                Profile.GetCurrentProfile.SaveProfile()
            ElseIf WindowsApi.GetAsyncKeyState(Keys.Right)
                ProgramStateHandler.State.SelectedTask.XOffset += 2
                Profile.GetCurrentProfile.SaveProfile()
            ElseIf WindowsApi.GetAsyncKeyState(Keys.Left)
                ProgramStateHandler.State.SelectedTask.XOffset -= 2
                Profile.GetCurrentProfile.SaveProfile()
            End If
        End Sub
    End Class
End NameSpace