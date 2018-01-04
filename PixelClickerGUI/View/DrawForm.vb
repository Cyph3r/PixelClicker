Imports System.Runtime.InteropServices
Imports PixelClickerGUI.Controller
Imports PixelClickerGUI.Model

Namespace View
    Public Class DrawForm
        Private InitialStyle As Integer

        Private Sub DrawForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.TopMost = True
            InitialStyle = WindowsApi.GetWindowLong(Me.Handle, - 20)

            WindowsApi.SetWindowLong(Me.Handle, - 20, InitialStyle Or &H80000 Or &H20)

            Me.WindowState = FormWindowState.Normal
            Timer1.Enabled = True
            Timer1.Start()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If ProgramStateHandler.State.SelectedTask Is Nothing Then Exit Sub
            Me.Location = ProgramStateHandler.State.SelectedTask.SearchPos
            Me.Size = ProgramStateHandler.State.SelectedTask.SearchArea
            me.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            If Not GlobalSettings.Settings.DrawOnGame OrElse Not ProgramStateHandler.State.Started OrElse Not ProgramStateHandler.State.IsProgramActiveWindow OrElse ProgramStateHandler.State.SelectedTask Is Nothing Then
                MyBase.OnPaint(e)
                Exit Sub
            End If

            Dim linePenYellow As New Pen(System.Drawing.Color.Yellow)
            Dim linePenBlue As New Pen(System.Drawing.Color.Blue)
            Dim grphx As Graphics = Me.CreateGraphics()

            If (Not ProgramStateHandler.State.IsProgramActiveWindow) Then
                Return
            End If

            grphx.Clear(Me.BackColor)

            If _
                (ProgramStateHandler.State.SelectedTask.CurrentAimPos.X > 0 OrElse
                 ProgramStateHandler.State.SelectedTask.CurrentAimPos.Y > 0) Then
                'Draw verticle line
                grphx.DrawLine(linePenYellow, ProgramStateHandler.State.SelectedTask.CurrentAimPos.X, 0,
                               ProgramStateHandler.State.SelectedTask.CurrentAimPos.X, Me.ClientSize.Height - 1)

                'Draw horizontal line
                grphx.DrawLine(linePenYellow, 0, ProgramStateHandler.State.SelectedTask.CurrentAimPos.Y,
                               Me.ClientSize.Width - 1, ProgramStateHandler.State.SelectedTask.CurrentAimPos.Y)
            End If
            'Draw border

            grphx.DrawRectangle(linePenBlue, 0, 0, ProgramStateHandler.State.SelectedTask.SearchArea.Width - 1,
                                ProgramStateHandler.State.SelectedTask.SearchArea.Height - 1)

            linePenBlue.Dispose()
            linePenYellow.Dispose()
            grphx.Dispose()
            'Continues the paint of other elements and controls
            MyBase.OnPaint(e)
        End Sub
    End Class
End NameSpace