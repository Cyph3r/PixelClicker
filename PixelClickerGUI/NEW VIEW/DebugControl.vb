Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Namespace NEW_VIEW
    Public Class DebugControl
       Friend Sub ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
            try
                Dim oldImage As Image = DebugPictureBox.Image
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

                If DebugPictureBox.InvokeRequired Then
                    DebugPictureBox.Invoke(Sub() 'lambda sub
                        Try
                            If Not bitmap Is Nothing Then
                                If Not oldImage Is Nothing Then oldImage.Dispose()
                                DebugPictureBox.Image = bitmap
                                         end If
                        Catch ex As Exception
                                         End Try
                                         End Sub)
                Else
                    If Not oldImage Is Nothing Then oldImage.Dispose()
                    DebugPictureBox.Image = bitmap
                End If
            Catch ex As Exception
            End Try
        End Sub
    End Class
End NameSpace