Imports PixelClickerGUI.Model

Namespace Controller
    Public Class RadarPixelClicker
        Inherits Controller.PixelClicker
        Private ReadOnly _radarTable As New UnitTable

        Public Sub New(ByRef task As Task)
            MyBase.New(task)
        End Sub

        Private ReadOnly _drawPoints As New List(Of Point())

        Protected Overrides Function ProcessImage(ByRef lockBitmap As LockBitmap) As ActionModel
            Dim actionP As New ActionModel
            _drawPoints.Clear()
            Dim open = 0
            Dim closed = 0
            _radarTable.Items.Clear()

            Dim radarLength As Integer =
                    If((lockBitmap.Width/2 < lockBitmap.Height/2), lockBitmap.Width/2, lockBitmap.Height/2)
            _radarTable.GenerateTable(Task.LineChecks, radarLength, lockBitmap.Width/2, lockBitmap.Height/2)

            For i = 0 To _radarTable.Items.Count - 1
                Dim unit As Unit = _radarTable.Items(i)
                Dim foundPoint As Point = LineTest(unit.FromPoint, unit.ToPoint, lockBitmap)

                IF foundPoint = unit.ToPoint Then
                    open += 1
                Else
                    Dim dis = DistanceBetween(unit.FromPoint, foundPoint)
                    If dis >= 0 AndAlso dis <= 9 Then
                        open += 1
                        Continue For
                    End If
                    closed += 1
                    _drawPoints.Add({unit.FromPoint, foundPoint})
                End If
            Next

            actionP.Pct = closed/(Task.LineChecks-1)
            actionP.DoAction = actionP.Pct >= Task.HitChance

            Return actionP
        End Function


        Private Function LineTest(fromPoint As Point, toPoint As Point, ByRef lockBitmap As LockBitmap) As Point
            Dim dx As Integer = Math.Abs(toPoint.X - fromPoint.X)
            Dim dy As Integer = Math.Abs(toPoint.Y - fromPoint.Y)
            Dim sx As Integer = If((fromPoint.X < toPoint.X), 1, - 1)
            Dim sy As Integer = If((fromPoint.Y < toPoint.Y), 1, - 1)
            Dim err As Integer = dx - dy
            Dim e2 As Integer
            Dim color As Color
            Dim isGoodColor As Boolean

            While (Not (fromPoint.X = toPoint.X And fromPoint.Y = toPoint.Y))
                color = lockBitmap.GetPixel(fromPoint.X, fromPoint.Y)
                isGoodColor = False

                If Task.SearchColors.Count > 0 Then
                    isGoodColor = ColorIsInRange({color.R, color.G, color.b})
                End If

                If Task.UsePremadeShades Then
                    isGoodColor = IsShadeOfRed({color.R, color.G, color.b}) OrElse isGoodColor
                End If

                If isGoodColor Then
                    Return New Point(fromPoint.X, fromPoint.Y)
                End If

                e2 = 2*err

                If e2 > - dy Then

                    err -= dy
                    fromPoint.X += sx
                End If

                If e2 < dx Then
                    err += dx
                    fromPoint.Y += sy
                End If
            End While

            Return toPoint
        End Function

        Protected Overrides Function Draw(ByRef b As Bitmap) As Bitmap
            If Not GlobalSettings.Settings.Debug Then Return b
            For Each drawPoint As Point() In _drawPoints
                Using g As Graphics = Graphics.FromImage(b)
                    g.DrawLine(New Pen(Color.FromArgb(100, 255, 255, 0), 1), drawPoint(0), drawPoint(1))
                End Using
            Next

            Return b
        End Function

        Protected Class UnitTable
            Public ReadOnly Items As New List(Of Unit)

            Public Sub GenerateTable(lineCount As Integer, lineLength As Integer, middleX As Integer, middleY As Integer)
                Items.Clear()

                Const rad As Double = Math.PI/180
                Dim offset = 0
                Dim increment As Integer = 360/lineCount
                Dim angle As Double

                For i = 0 To lineCount
                    angle = rad*offset
                    Items.Add(New Unit(middleX, middleY, angle, lineLength))
                    offset += increment
                Next
            End Sub
        End Class

        Public Class Unit
            Public ReadOnly ToPoint As Point
            Public ReadOnly FromPoint As Point

            Public Sub New(middleX As Integer, middleY As Integer, angle As Double, lineLength As Integer)
                Dim toX As Integer = Math.Round(middleX + Math.Cos(angle)*lineLength)
                Dim toY As Integer = Math.Round(middleY + Math.Sin(angle)*lineLength)
                Me.ToPoint = New Point(toX, ToY)
                Me.FromPoint = new Point(middleX, middleY)
            End Sub
        End Class
    End Class
End NameSpace