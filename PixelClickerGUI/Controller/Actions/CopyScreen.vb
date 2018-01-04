Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Threading
Imports PixelClickerGUI.View

Namespace Controller.Actions
    Public Class CopyScreen
        Public Event NewImage(Byval b as Bitmap)
        Private Shared _b As Bitmap
        Private Shared _maxSize As Size
        Private _cancel As Boolean = True
        Public Shared AutoResetEvent As AutoResetEvent
        Public Shared Property MaxSize As Size
            Get
                Return _maxSize
            End Get
            Set
                _maxSize = value
                If Value.Width > 0 OrElse Value.Height > 0 Then _b = New Bitmap(Value.Width,Value.Height)
            End Set
        End Property
        Public Shared Property SearchPos As Point
        Private WithEvents _captureBgWorker As BackgroundWorker
        Public Sub New()
            _captureBgWorker = New BackgroundWorker
            _captureBgWorker.WorkerSupportsCancellation = true
            AutoResetEvent = New AutoResetEvent(False)
        End Sub
        Public Sub Start()
            If Not _captureBgWorker.IsBusy Then 
                _cancel = False
                _captureBgWorker.RunWorkerAsync()
            End If
        End Sub
        Public Sub Cancel()
           _cancel = True
        End Sub
        Private Sub DoWork(sender As Object, e As DoWorkEventArgs) Handles _captureBgWorker.DoWork
            While (Not _cancel)
                ProgramStateHandler.UpdateTaskSize()
                Capture()
            End While
        End Sub
        Private  Sub Capture()
            Using g As Graphics = Graphics.FromImage(_b)
                g.CopyFromScreen(SearchPos.x, SearchPos.Y, 0, 0,
                                 _maxSize)
            End Using
            RaiseEvent NewImage(_b)
        End Sub
    End Class
End NameSpace