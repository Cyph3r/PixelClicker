Imports System.Timers
Imports PixelClickerGUI.Controller.Actions
Imports PixelClickerGUI.Model
Imports PixelClickerGUI.Types
Imports PixelClickerGUI.View

Namespace Controller
    Public Class ProgramStateHandler
        Private Shared _instance As ProgramStateHandler
        Private WithEvents  _timer As Timer

        Private Sub New()
            _timer = New Timer()
            _timer.Interval = 100
            _timer.Enabled = true
            _timer.Start()
       End Sub

		Public Shared Function Instance() As ProgramStateHandler
			If _instance Is Nothing Then
				_instance = New ProgramStateHandler
			End If

			Return _instance
		End Function
        public Shared sub blah(sender As Object, e As EventArgs) handles _timer.Elapsed
            Dim capTxt As String = WindowsApi.GetCaption()
            State.IsProgramActiveWindow = capTxt.ToLower().Contains(GlobalSettings.Settings.GameName.ToLower())
            'If State.IsProgramActiveWindow Then CopyScreen.AutoResetEvent?.Set()
        End sub

        Public Shared Sub ChangeSelectedTask(selectedTask As Model.Task)
            License.CheckLicense()
           
            If State.SelectedTask Is Nothing Then 
                State.SelectedTask = selectedTask
                Exit Sub
            End If

            State.SelectedTask = selectedTask
        End Sub

        Public Shared Function StartTasks() As Boolean
            For Each task As Model.Task In Profile.GetCurrentProfile.TaskList
                If task.Controller Is Nothing Then Continue For
                If Not task.Controller.IsBusy() Then task.Controller.Start()
            Next

            State.Started = True
            License.CheckLicense()
            DrawForm.Show()
            Return True
        End Function

        Public Shared Function StopTasks() As Boolean
             For Each task As Model.Task In Profile.GetCurrentProfile.TaskList
                 If task.Controller Is Nothing Then Continue For
                 task.Controller.Cancel()
             Next

             License.CheckLicense()
             State.Started = False
             DrawForm.Hide()
             Return True
        End Function

        Public Shared Sub AddTask(ParamArray tasks() As Model.Task)
            Profile.GetCurrentProfile.TaskList.AddRange(tasks)

            License.CheckLicense()
            Profile.GetCurrentProfile.SaveProfile()
        End Sub
        Public Shared Sub ProcessTask(ParamArray tasks() As Model.Task)
            For Each task As Model.Task In tasks
                task.Controller = PixelClicker.Factory(task)
                UpdateTaskSize()
                If State.Started Then task.Controller.Start()
            Next

            License.CheckLicense()
        End Sub
        Public Shared Sub RemoveTask(ParamArray tasks() As Model.Task)
            For Each task As Model.Task In tasks
                Profile.GetCurrentProfile.TaskList.Remove(task)
                If Not IsNothing(task.Controller) Then
                    task.Controller.Cancel()
                End If

                UpdateTaskSize()
            Next

            Profile.GetCurrentProfile.SaveProfile()
            License.CheckLicense()
        End Sub

        Public Shared Sub UpdateTaskSize()
            If Profile.GetCurrentProfile.TaskList.Count = 0 Then Exit Sub
            Dim mostTopLeftPoint As Point = Nothing
            Dim mostBottomRightPoint As Point = Nothing
            Dim cursorPosition As Point = Cursor.Position

            For Each task As Model.Task In Profile.GetCurrentProfile.TaskList
                If task.SearchMethod = SearchMethod.CursorPosition Then task.SearchPos = cursorPosition

                If  mostTopLeftPoint = Nothing And mostBottomRightPoint = Nothing Then
                     mostTopLeftPoint = New Point(task.SearchPos)
                     mostBottomRightPoint = New Point(task.SearchPos.X + task.SearchArea.Width,
                                                               task.SearchPos.Y + task.SearchArea.Height)
                End IF

                If task.SearchPos.X <  mostTopLeftPoint.X Then
                     mostTopLeftPoint.X = task.SearchPos.X
                End If

                If task.SearchPos.Y <  mostTopLeftPoint.Y Then
                     mostTopLeftPoint.Y = task.SearchPos.Y
                End If

                If task.SearchPos.X + task.SearchArea.Width > mostBottomRightPoint.X Then
                    mostBottomRightPoint.X = task.SearchPos.X + task.SearchArea.Width
                End If

                If task.SearchPos.Y + task.SearchArea.Height > mostBottomRightPoint.Y Then
                    mostBottomRightPoint.Y = task.SearchPos.Y + task.SearchArea.Height
                End If
            Next

            State.MaxSize = New Size(State.MostBottomRightPoint.X - State.MostTopLeftPoint.X,
                                         State.MostBottomRightPoint.Y - State.MostTopLeftPoint.Y)
            State.MostTopLeftPoint = mostTopLeftPoint
            State.MostBottomRightPoint = mostBottomRightPoint

            CopyScreen.MaxSize = State.MaxSize
            CopyScreen.SearchPos = State.MostTopLeftPoint
        End Sub

         Public Class State
            Protected ReadOnly Shared Friend Version As String = "1.0.2.1"
            Protected Shared Friend MostTopLeftPoint As Point = Nothing
            Protected Shared Friend MostBottomRightPoint As Point = Nothing
            Protected Shared Friend MaxSize As Size = Nothing
            Protected Shared Friend IsProgramActiveWindow As Boolean = Nothing
            Protected Shared Friend SelectedTask As Model.Task = Nothing
            Protected Shared Friend Started As Boolean = Nothing
            Protected Shared Friend LicenseType As Integer = 0
  

            Protected Friend Sub New()
            End Sub
        End Class
    End Class
End NameSpace