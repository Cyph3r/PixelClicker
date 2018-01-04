Imports PixelClickerGUI.Model

Namespace Controller
    Public Class FirstPixelClicker
        Inherits PixelClicker
        Public Sub New(ByRef task As Task)
            MyBase.New(task)
        End Sub
        Protected Overrides Function ProcessImage(ByRef lockBitmap As LockBitmap) As ActionModel
            Dim actionP As New ActionModel
            Return actionP
        End Function

        Protected Overrides Function Draw(ByRef b As Bitmap) As Bitmap
            'g.DrawLine(Pens.Black, New Point(0, 27), New Point(99, 27))
		    'g.DrawLine(Pens.Black, New Point(0, 73), New Point(99, 73))
		    'g.DrawLine(Pens.Black, New Point(52, 0), New Point(52, 99))
		    'g.DrawLine(Pens.Black, New Point(14, 0), New Point(14, 99))
		    'g.DrawLine(Pens.Black, New Point(85, 0), New Point(85, 99))
            return b
        End Function
    End Class
End NameSpace