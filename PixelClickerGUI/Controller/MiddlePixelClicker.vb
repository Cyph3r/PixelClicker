Imports System.Web.UI.WebControls.Expressions
Imports System.Windows.Media
Imports PixelClickerGUI.Model

Namespace Controller
    Public Class MiddlePixelClicker
        Inherits PixelClicker

        Public Sub New(ByRef task As Task)
            MyBase.New(task)
        End Sub

        Protected Overrides Function ProcessImage(ByRef lockBitmap As LockBitmap) As ActionModel
            Dim actionModel As ActionModel = HealthBar(lockBitmap)
            If (Not Task.UsePremadeShades AndAlso Task.SearchColors.Count = 0) OrElse actionModel.DoAction Then _
                Return actionModel
            Dim lowestX As Integer = 0
            Dim lowestY As Integer = 0
            Dim highestX As Integer = Int32.MaxValue
            Dim highestY As Integer = Int32.MaxValue

            Dim pixelXSum = 0
            Dim pixelYSum = 0
            Dim x As Integer
            Dim y As Integer
            Dim count As Integer = 0
            Dim width As Integer = lockBitmap.Width
            Dim nMultiplied = 0
            Dim isGoodColor As Boolean = False
            Dim skipInt = Task.SkipPixel
            Dim debug = GlobalSettings.Settings.Debug
            Try
                Dim pixels As Byte() = lockBitmap.Pixels
                For n = pixels.Length - 1 to 0 Step skipInt
                    nMultiplied = n*4
                    If nMultiplied >= pixels.Length Then Continue For
                    isGoodColor = False

                    If Task.SearchColors.Count > 0 Then
                        isGoodColor =
                            ColorIsInRange({pixels(nMultiplied + 2), pixels(nMultiplied + 1), pixels(nMultiplied)})
                    End If

                    If Task.UsePremadeShades Then
                        isGoodColor =
                            IsShadeOfRed({pixels(nMultiplied + 2), pixels(nMultiplied + 1), pixels(nMultiplied)}) OrElse
                            isGoodColor
                    End If

                    If Not isGoodColor Then
                        If debug Then
                            pixels(nMultiplied + 2) = 0
                            pixels(nMultiplied + 1) = 0
                            pixels(nMultiplied) = 0
                        End If

                        Continue For
                    End If


                    x = GetXFromByte(n, width)
                    y = GetYFromByte(n, x, width)


                    If x < highestX Then highestX = x
                    If y < highestY Then highestY = y

                    If x > lowestX Then lowestX = x
                    If y > lowestY Then lowestY = y

                    pixelXSum += x
                    pixelYSum += y
                    count += 1
                Next

                If count > 0 Then
                    pixelXSum /= count
                    pixelYSum /= count

                    actionModel.RelativeToScreenPoint =
                        New Point(Task.SearchPos.X + pixelXSum,
                                  Task.SearchPos.Y + pixelYSum)
                    actionModel.PixelPoint =
                        New Point(actionModel.RelativeToScreenPoint.X - Task.SearchPos.X,
                                  actionModel.RelativeToScreenPoint.Y - Task.SearchPos.Y)

                    actionModel.DoAction = True
                    actionModel.Time = Now()
                End If
            CAtch
            End Try
            Return actionModel
        End Function

        Function GetYFromByte(n As Integer, x As Integer, width As Integer) As Integer
            Return (n - x)/width
        End Function

        Function GetXFromByte(n As Integer, width As Integer) As Integer
            Return n Mod width
        End Function

        Private _lowestOffsetY As Integer = Int32.MaxValue
        Private _highestOffsetY As Integer = 0

        Private _lowestOffsetX As Integer = Int32.MaxValue
        Private _highestOffsetX As Integer = 0

        Private ReadOnly _colors As System.Drawing.Color() = {
            System.Drawing.Color.Red,
            System.Drawing.Color.Green,
            System.Drawing.Color.Yellow,
            System.Drawing.Color.Blue,
            System.Drawing.Color.Purple,
            System.Drawing.Color.DeepPink,
            System.Drawing.Color.Cyan,
            System.Drawing.Color.Orange,
            System.Drawing.Color.Aqua,
            System.Drawing.Color.Brown,
            System.Drawing.Color.DarkSalmon,
            System.Drawing.Color.Gold,
            System.Drawing.Color.Olive,
            System.Drawing.Color.Navy,
            System.Drawing.Color.Lime}

        Protected Function HealthBar(ByRef lockBitmap As LockBitmap) As ActionModel
            Dim actionModel As New ActionModel
            Dim nMultiplied = 0
            Dim pixels As Byte() = lockBitmap.Pixels
            Dim x As Integer
            Dim y As Integer
            Dim width As Integer = lockBitmap.Width
            Dim skipInt = Task.SkipPixel
            Dim points As New List(Of DbscanPoint)()
            Dim clusterCount = 0
            For n = pixels.Length - 1 to 0 Step skipInt
                nMultiplied = n*4
                If nMultiplied >= pixels.Length Then Continue For

                If Not (pixels(nMultiplied + 2) >= 250 AndAlso
                        pixels(nMultiplied + 1) <= 20 AndAlso
                        pixels(nMultiplied) <= 20) Then
                    Continue For
                End If

                x = GetXFromByte(n, width)
                y = GetYFromByte(n, x, width)

                points.Add(New DbscanPoint(x, y))
            Next

            If points.Count > 0 Then
                Dim highestLowestList As New List(Of HighestLowest)
                clusterCount = DbscanAlgorithm.Dbscan(points.ToArray(), 45, 2)
                If clusterCount = 0 Then Return actionModel

                For i = 0 To clusterCount - 1
                    highestLowestList.Add(New HighestLowest())
                Next

               ' Diagnostics.Debug.WriteLine(clusterCount)
                Dim clusterIdClosestToMiddle As Integer
                Dim clusterClosestToMiddleDistance As Integer = Integer.MaxValue
                Dim cCount = lockBitmap.cCount

                For Each point In points
                    If point.ClusterId Is Nothing OrElse point.IsNoise Then Continue For
                    Dim i As Integer = ((point.y * width) + point.x) * cCount 

                    pixels(i + 2) = System.Drawing.Color.Green.R
                    pixels(i + 1) = System.Drawing.Color.Green.G
                    pixels(i) = System.Drawing.Color.Green.B

                    If point.X < highestLowestList(point.ClusterId-1).HighestPoint.X Then highestLowestList(point.ClusterId-1).HighestPoint.X = point.X 
                    If point.Y < highestLowestList(point.ClusterId-1).HighestPoint.Y Then highestLowestList(point.ClusterId-1).HighestPoint.Y = point.Y

                    If point.X > highestLowestList(point.ClusterId-1).LowestPoint.X Then highestLowestList(point.ClusterId-1).LowestPoint.X = point.X
                    If point.Y > highestLowestList(point.ClusterId-1).LowestPoint.Y Then highestLowestList(point.ClusterId-1).LowestPoint.Y = point.Y

                    Dim dis As Integer = DistanceBetween(New Point(Task.WidthOffset,Task.HeightOffset), New Point(point.X,point.Y))
                    If dis < clusterClosestToMiddleDistance Then 
                        clusterClosestToMiddleDistance = dis
                        clusterIdClosestToMiddle = point.ClusterId-1
                    End If
                Next

                Dim offSetHeight As Integer = Math.Abs(highestLowestList(clusterIdClosestToMiddle).HighestPoint.Y - highestLowestList(clusterIdClosestToMiddle).LowestPoint.Y)
               ' Dim offSetWidth As Integer = Math.Abs(highestLowestList(clusterIdClosestToMiddle).HighestPoint.X - highestLowestList(clusterIdClosestToMiddle).LowestPoint.X)
                Task.LastHealthBarHeight = offSetHeight
               ' If offSetWidth < _lowestOffsetX Then _lowestOffsetX = If(offSetWidth <= 1, 2, offSetWidth)
               ' If offSetWidth > _highestOffsetX Then _highestOffsetX = offSetWidth
                offSetHeight = If(offSetHeight >= Task.MaximumHealthBarHeight, Task.MaximumHealthBarHeight, offSetHeight)

                If offSetHeight < _lowestOffsetY Then _lowestOffsetY = If(offSetHeight = 0, 1, offSetHeight)
                'If offSetHeight > _highestOffsetY Then _highestOffsetY = offSetHeight

                'Dim offsetPerY As Double = CDbl(offSetHeight)/CDbl(_highestOffsetY)
                'Dim offsetPerX As Double = CDbl(offSetWidth)/CDbl(_highestOffsetX)

                Dim offset As Integer = (Task.MaximumHealthBarHeight - offSetHeight)*4

                actionModel.RelativeToScreenPoint = New Point(Task.SearchPos.X + highestLowestList(clusterIdClosestToMiddle).HighestPoint.X + (Task.XOffset-offset),
                                                              Task.SearchPos.Y + highestLowestList(clusterIdClosestToMiddle).HighestPoint.Y + (Task.YOffset-offset))                                      
                actionModel.PixelPoint = New Point(actionModel.RelativeToScreenPoint.X - Task.SearchPos.X,
                                                   actionModel.RelativeToScreenPoint.Y - Task.SearchPos.Y)

                actionModel.DoAction = True
                actionModel.Time = Now

            End If
            Return actionModel
        End Function
        Public Shared Function Lerp(A As Double, B As Double, T As Double) As Double
	        If T > 1.0 Then
		        Return B
	        End If
	        If T < 0.0 Then
		        Return A
	        End If
	        Return (A + ((B - A) * T))
        End Function
        Protected Overrides Function Draw(ByRef b As Bitmap) As Bitmap
            return b
        End Function
    End Class
    Public Class HighestLowest
        Public HighestPoint As New Point(Integer.MaxValue,Integer.MaxValue)
        Public LowestPoint As New Point(0,0)
    End Class
    ''' <summary>
    ''' Contains an implementation of the DBSCAN algorithm. This class cannot be inherited.
    ''' </summary>
    Public Class DbscanAlgorithm

#Region "constructors"

        Private Sub New()
        End Sub

#End Region

#Region "methods"

        ''' <summary>
        ''' Clusters the specified points using the specified value and minimum points to form a cluster.
        ''' </summary>
        ''' <param name="points">The points to cluster.</param>
        ''' <param name="eps">The value to use to find neighoring points.</param>
        ''' <param name="minimumClusterCount">The minimum number of points to form a cluster.</param>
        ''' <returns>The number of clusters created from the collection.</returns>
        Public Shared Function Dbscan (Of XType, YType)(points As IDbscanPoint(Of XType, YType)(), eps As Integer,
                                                        minimumClusterCount As Integer) As Integer
            Dim cid As Integer = 0

            For Each p As IDbscanPoint(Of XType, YType) In points
                If Not p.IsVisited Then
                    p.IsVisited = True

                    Dim neighbors As IDbscanPoint(Of XType, YType)() = DbscanAlgorithm.GetNeighors(points, p, eps)

                    If neighbors.Length < minimumClusterCount Then
                        p.IsNoise = True
                    Else
                        cid += 1
                        DbscanAlgorithm.ExpandCluster(points, p, neighbors, cid, eps, minimumClusterCount)
                    End If
                End If
            Next

            Return cid
        End Function

        Private Shared Sub ExpandCluster (Of XType, YType)(points As IDbscanPoint(Of XType, YType)(),
                                                           p As IDbscanPoint(Of XType, YType),
                                                           neighbors As IDbscanPoint(Of XType, YType)(), cid As Integer,
                                                           eps As Integer, minimumClusterCount As Integer)
            p.ClusterId = cid

            Dim q As New Queue(Of IDbscanPoint(Of XType, YType))(neighbors)

            While q.Count > 0
                Dim n As IDbscanPoint(Of XType, YType) = q.Dequeue()
                If Not n.IsVisited Then
                    n.IsVisited = True

                    Dim ns As IDbscanPoint(Of XType, YType)() = DbscanAlgorithm.GetNeighors(points, n, eps)
                    If ns.Length >= minimumClusterCount Then
                        For Each item As IDbscanPoint(Of XType, YType) In ns
                            q.Enqueue(item)

                        Next
                    End If
                ElseIf Not n.ClusterId.HasValue Then
                    n.ClusterId = cid
                End If
            End While
        End Sub

        Private Shared Function GetNeighors (Of XType, YType)(points As IDbscanPoint(Of XType, YType)(),
                                                              point As IDbscanPoint(Of XType, YType), eps As Integer) _
            As IDbscanPoint(Of XType, YType)()
            Dim neighbors As New List(Of IDbscanPoint(Of XType, YType))()
            neighbors.Add(point)

            For Each p As IDbscanPoint(Of XType, YType) In points
                If point.IsNeighbor(p, eps) Then
                    neighbors.Add(p)
                End If
            Next

            Return neighbors.ToArray()
        End Function

#End Region
    End Class

    ''' <summary>
    ''' Contains an implementation of the <see cref="IDbscanPoint"/> interface 
    ''' using <see cref="double"/> types for the X and Y components.
    ''' </summary>
    <System.Diagnostics.DebuggerDisplay("\{X={X}, Y={Y}\}")>
    Public Class DbscanPoint
        Implements IDbscanPoint(Of Integer, Integer)

#Region "properties"

        ''' <summary>
        ''' Gets or sets the X component of the point.
        ''' </summary>
        Public Property X() As Integer Implements IDbscanPoint(Of Integer, Integer).X

        ''' <summary>
        ''' Gets or sets the Y component of the point.
        ''' </summary>
        Public Property Y() As Integer Implements IDbscanPoint(Of Integer, Integer).Y

        ''' <summary>
        ''' Gets or sets a value indicating whether the point is noise.
        ''' </summary>
        Public Property IsNoise() As Boolean Implements IDbscanPoint(Of Integer, Integer).IsNoise

        ''' <summary>
        ''' Gets or sets a value indicating whether the point was visited.
        ''' </summary>
        Public Property IsVisited() As Boolean Implements IDbscanPoint(Of Integer, Integer).IsVisited

        ''' <summary>
        ''' Gets or sets a value indicating the cluster id.
        ''' </summary>
        Public Property ClusterId() As Integer? Implements IDbscanPoint(Of Integer, Integer).ClusterId

#End Region

#Region "constructors"

        ''' <summary>
        ''' Initializes a new instance of the <see cref="DbscanPoint"/> class.
        ''' </summary>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the <see cref="DbscanPoint"/> class with the specified values.
        ''' </summary>
        ''' <param name="x">The X component of the point.</param>
        ''' <param name="y">The Y component of the point.</param>
        Public Sub New(x As Integer, y As Integer)
            Me.X = x
            Me.Y = y
        End Sub

#End Region

#Region "methods"

        ''' <summary>
        ''' Determines whether the specified point neighbors the current instance using the specified value.
        ''' </summary>
        ''' <param name="point">The point to test as a neighor.</param>
        ''' <param name="eps">The value to use to find neighoring points.</param>
        ''' <returns>True if the point is a neighbor; otherwise, false.</returns>
        Public Function IsNeighbor(point As IDbscanPoint(Of Integer, Integer), eps As Double) As Boolean _
            Implements IDbscanPoint(Of Integer, Integer).IsNeighbor
            Dim dis As Integer = PixelClicker.DistanceBetween(New Point(point.X, point.Y), new Point(Me.X,me.Y))

            Return dis < eps
        End Function

#End Region
    End Class

    ''' <summary>
    ''' Contains the functionality an object requires to perform a DBSCAN.
    ''' </summary>
    Public Interface IDbscanPoint (Of XType, YType)

#Region "properties"

        ''' <summary>
        ''' Gets or sets the X component of the point.
        ''' </summary>
        Property X() As XType

        ''' <summary>
        ''' Gets or sets the Y component of the point.
        ''' </summary>
        Property Y() As YType

        ''' <summary>
        ''' Gets or sets a value indicating whether the point is noise.
        ''' </summary>
        Property IsNoise() As Boolean

        ''' <summary>
        ''' Gets or sets a value indicating whether the point was visited.
        ''' </summary>
        Property IsVisited() As Boolean

        ''' <summary>
        ''' Gets or sets a value indicating the cluster id.
        ''' </summary>
        Property ClusterId() As Integer?

#End Region

#Region "methods"

        ''' <summary>
        ''' Determines whether the specified point neighbors the current instance using the specified value.
        ''' </summary>
        ''' <param name="point">The point to test as a neighor.</param>
        ''' <param name="eps">The value to use to find neighoring points.</param>
        ''' <returns>True if the point is a neighbor; otherwise, false.</returns>
        Function IsNeighbor(point As IDbscanPoint(Of XType, YType), eps As Double) As Boolean

#End Region
    End Interface
End NameSpace