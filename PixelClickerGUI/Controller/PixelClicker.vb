Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Management
Imports System.Web.UI.WebControls.Expressions
Imports PixelClickerGUI.Controller.Actions
Imports PixelClickerGUI.Model
Imports PixelClickerGUI.NEW_VIEW
Imports PixelClickerGUI.Types
Imports PixelClickerGUI.View

Namespace Controller
    Public MustInherit Class PixelClicker
        Protected  Task As Model.Task
        Private Shared WithEvents _screenCapture As New CopyScreen
        Protected WithEvents Bgworker As New BackgroundWorker
        Public Property ReportProgress As Boolean = False
        Private ReadOnly _fpsStopWatch As New Stopwatch
        Private ReadOnly _mouse As New Mouse
        Private _fps As Integer = 0
        Private Shared _isProgramClicking As Boolean = False
        Private Shared _isManualClicking As Boolean = False
        Protected MustOverride Function Draw(ByRef b As Bitmap) As Bitmap
        Protected MustOverride Function ProcessImage(ByRef lockBitmap As LockBitmap) As ActionModel
        Public Sub New(ByVal task As Model.Task)
            Me.Task = task
            AddHandler Bgworker.ProgressChanged, AddressOf PixelClickerFormRedesign.DebugControl.ProgressChanged
            Bgworker.WorkerReportsProgress = True
            Bgworker.WorkerSupportsCancellation = True
        End Sub

        Private Sub Notify(b As Bitmap)
            If Not Bgworker.IsBusy Then
                Try
                    Bgworker.RunWorkerAsync(New Bitmap(b))
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                End Try
            Else 
               ' Console.WriteLine("busy")
            End If
        End Sub
        Private Sub PreProcess(sender As Object, e As DoWorkEventArgs) Handles Bgworker.DoWork
            Dim message = ""
            Dim actionModel As ActionModel
         '   Try
                Using lockBitmapModel = New LockBitmap(SnipImage(CType(e.Argument, Bitmap)))
                    lockBitmapModel.LockBits()

                    actionModel = ProcessImage(lockBitmapModel)

                    'Dim predictedActionModel As ActionModel = PredictionEngine.PredictFuture(actionP)
                    Task.CurrentAimPos = actionModel.PixelPoint
                    DoAction(actionModel)
                    
                    lockBitmapModel.UnlockBits()

                    _fps += 1
                    If _fpsStopWatch.ElapsedMilliseconds >= 1000 Then
                        Task.LastFps = _fps
                        _fps = 0
                        _fpsStopWatch.Restart()
                    End If

                    If ReportProgress Then
                        If actionModel.Pct > 0.0 Then
                            message = "Chance: " & (actionModel.Pct*100).ToString("F0") & "%"
                        End If
                    
                        Bgworker.ReportProgress(0,
                                               {Draw(new bitmap(lockBitmapModel.Source)), message,
                                                Task.SearchArea.Width*.07})
                    
                    End If
                End Using
           ' Catch ex As Exception
           '     Debug.WriteLine(ex.Message)
           ' End Try
        End Sub


        Private Sub DoAction(actionP As ActionModel)
                If actionP.DoAction AndAlso (WindowsApi.GetAsyncKeyState(Task.Hotkey) OrElse Task.Hotkey = 0) Then
                    If Task.MoveMouse Then
                        DoMouseMove(actionP)
                    End If

                    If Task.Click <> Click.NoClick Then
                        DoClick()
                    End If
                Else
                    If Task.Click = Click.HoldClick AndAlso _isProgramClicking Then
                        _mouse.LeftClickUp()
                        _isProgramClicking = False
                    End If

                    _lastAction = Nothing
                End If
        End Sub
        Private _actuallyMovedTrue As Integer
        Private _actuallyMovedFalse As Integer
        Private _lastAction As ActionModel
        Private Sub DoMouseMove(actionP As ActionModel)
           
            'Dim movingAmount As New Point(actionP.PixelPoint.X - Task.WidthOffset, actionP.PixelPoint.Y - Task.HeightOffset*1.75 )
            _mouse.Move((actionP.PixelPoint.X - Task.WidthOffset)*Task.AntiShake,
                        (actionP.pixelPoint.Y - Task.HeightOffset*1.75)*Task.AntiShake,
                        Task.AimBotMoveSpeed)
           'Dim afterMouseMove As Point = Cursor.Position
           'Dim actuallyMoved As New Point(actionP.RelativeToScreenPoint.X - afterMouseMove.X, actionP.RelativeToScreenPoint.Y - afterMouseMove.Y)
           'Dim sameX As Integer = Math.Abs(Math.Abs(movingAmount.X) - Math.Abs(actuallyMoved.X))
           'Dim sameY As Integer = Math.Abs(Math.Abs(movingAmount.Y) - Math.Abs(actuallyMoved.Y))
           'Dim same As Boolean = movingAmount.Equals(actuallyMoved) OrElse (sameX <= 5  AndAlso sameY <= 5)
           '
           'Debug.WriteLine($"beforeMovePos: {actionP.RelativeToScreenPoint} Moving Amount: {movingAmount}, Moved Point: {afterMouseMove} Actually Moved: {actuallyMoved} SAme: {same}")
           '
           '
           ' If _lastAction IsNot Nothing Then
           '    Debug.WriteLine($"Diff X {actionP.RelativeToScreenPoint.X - _lastAction.RelativeToScreenPoint.X} Diff Y {actionP.RelativeToScreenPoint.Y - _lastAction.RelativeToScreenPoint.Y}")
           '    If Math.Abs(actionP.RelativeToScreenPoint.X - _lastAction.RelativeToScreenPoint.X) <= 2 OrElse Math.Abs(actionP.RelativeToScreenPoint.Y - _lastAction.RelativeToScreenPoint.Y) <= 2 Then
           '        Task.AntiShake += .02
           '        Debug.WriteLine("add")
           '    ElseIf  Task.AntiShake - .02 > 0 Then
           '        Task.AntiShake -= .02
           '        Debug.WriteLine("subtract")
           '    End If
           'End If
           '
           '
           '_lastAction = actionP
           'Debug.WriteLine($"true: {_actuallyMovedTrue} false: {_actuallyMovedFalse}")
        End Sub

        Private Sub DoClick()
            _isManualClicking = WindowsApi.GetAsyncKeyState(Keys.LButton) AndAlso Not _isProgramClicking
            If Not _isManualClicking  Then
                If Task.Click = Click.HoldClick Then
                    If Not _isProgramClicking Then
                        _mouse.LeftClickDown()
                        _isProgramClicking = True
                    End If
                ElseIf Task.Click = Click.SingleClick Then
                    _mouse.LeftClickDown()
                    _mouse.LeftClickUp()
                End If
            Else
                If Task.Click = Click.HoldClick Then
                    If _isProgramClicking Then
                        _mouse.LeftClickUp()
                        _isProgramClicking = False
                    End If
                End If
            End If
        End Sub

        Public Shared Function LeftMouseIsDown() As Boolean
            Return WindowsApi.GetAsyncKeyState(Keys.LButton) > 0 And &H8000
        End Function

        Public Function SnipImage(bitmap As Bitmap) As Bitmap
            If Task.SearchPos = ProgramStateHandler.State.MostTopLeftPoint AndAlso
               Task.SearchArea = ProgramStateHandler.State.MaxSize Then
                Return bitmap
            End If

            Dim b As New Bitmap(Task.SearchArea.Width, Task.SearchArea.Height)
            Dim fromRectangle As New Rectangle(Task.SearchPos.X - ProgramStateHandler.State.MostTopLeftPoint.X,
                                               Task.SearchPos.Y - ProgramStateHandler.State.MostTopLeftPoint.Y,
                                               Task.SearchArea.Width, Task.SearchArea.Height)

            Dim toRectangle As New Rectangle(0, 0, Task.SearchArea.Width, Task.SearchArea.Height)
            Using g As Graphics = Graphics.FromImage(b)
                g.DrawImage(bitmap, toRectangle, fromRectangle, GraphicsUnit.Pixel)
            End Using

            bitmap.Dispose()
            Return New Bitmap(b)
        End Function

        Public Sub Start()
            AddHandler _screenCapture.NewImage, AddressOf Notify
            _fpsStopWatch.Start()
            _screenCapture.Start()
        End Sub

        Public Sub Cancel()
            RemoveHandler _screenCapture.NewImage, AddressOf Notify
            _fpsStopWatch.Stop()
           _screenCapture.Cancel()
        End Sub

        Public Function IsBusy() As Boolean
            Return Bgworker.IsBusy
        End Function
        Public Function IsShadeOfRed(compColor As Integer()) As Boolean
                If compColor(0) = 0 Then Return False
	            If  Task.RedStrength * compColor(0) < Task.GreenStrength * compColor(1) Then
		            Return False
	            End If
	            ' Red not strong enough in respect to green
	            If Task.RedStrength * compColor(0) < Task.BlueStrength * compColor(2) Then
		            Return False
	            End If
                
	            ' Red not strong enough in respect to blue
	            Return True
	            ' Red is stronger enough than green and blue to be called "shade of red"
        End Function
        Protected Function ColorIsInRange(compColor As Integer()) As Boolean
            Try

            For Each col As ColorModel in Task.SearchColors
                If compColor(0) >= col.R - col.ShadeVariation AndAlso
                    compColor(0) <= col.R + col.ShadeVariation AndAlso
                    compColor(1) >= col.G - col.ShadeVariation AndAlso
                    compColor(1) <= col.G + col.ShadeVariation AndAlso
                    compColor(2) >= col.B - col.ShadeVariation AndAlso
                    compColor(2) <= col.B + col.ShadeVariation Then
                        Return true
                   End If
                    
            Next

            Catch
            End Try

            Return False
        End Function
        Public Shared Function DistanceBetween(point1 As Point, point2 As Point) As Integer
            ' Calculate the distance between two points, given their X/Y coordinates.
            return (point2.x - point1.x) * (point2.x - point1.x) + (point2.y - point1.y) * (point2.y - point1.y)
            ' The short version...
            Return Math.Sqrt((Math.Abs(point2.X - point1.x)^2) + (Math.Abs(point2.y - point1.y)^2))
        End Function
        Public Shared Function Factory(ByRef task As Model.Task) As PixelClicker
            If task.Bot = Bot.First Then
                Return New FirstPixelClicker(task)
            ElseIf task.Bot = Bot.Middle Then
                Return New MiddlePixelClicker(task)
            ElseIf task.Bot = Bot.Radar Then
                Return New RadarPixelClicker(task)
            End If

            Throw New Exception("Bad Task was passed, tasks must have a search type!")
        End Function
    End Class
End NameSpace