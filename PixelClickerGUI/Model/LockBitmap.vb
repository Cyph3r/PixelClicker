
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Namespace Model
    Public Class LockBitmap
        Implements IDisposable
        Private _iptr As IntPtr = IntPtr.Zero
        Private _bitmapData As BitmapData = Nothing
        Private _cCount As Integer
        Private _locked As Boolean = False
        private _pixels As Byte()


                public ReadOnly Property BitmapData() As BitmapData
            Get
                return _bitmapData
            End Get
        end property

        public ReadOnly Property Pixels() As Byte()
            Get
                return _pixels
            End Get
        end property
                public ReadOnly Property cCount() As Integer
            Get
                return _cCount
            End Get
        end property
        Private _source As Bitmap
       public ReadOnly Property Source() As Bitmap
            Get
                return _source
            End Get
        end property

        Private  _depth As Integer

       public ReadOnly Property Depth() As Integer
            Get
                return _depth
            End Get
        end property
        Private _width As Integer  

        public ReadOnly Property Width() As Integer
            Get
                return _width
            End Get
        end property
        Private _height As Integer  

        public ReadOnly Property Height() As Integer
            Get
                return _height
            End Get
        end property
        Public Sub New(source As Bitmap)
            Try
            _source = source
                            Catch ex As Exception
            End Try
        End Sub

        ''' <summary>
        ''' Lock bitmap data
        ''' </summary>
        Public Sub LockBits()
            If  _locked Then Return
            Try
                ' Get width and height of bitmap
                _width = Source.Width
                _height = Source.Height

                ' get total locked pixels count
                Dim pixelCount As Integer = _width * _height

                ' Create rectangle to lock
                Dim rect As New Rectangle(0, 0, _width, _height)

                ' get source bitmap pixel format size
                _depth = Bitmap.GetPixelFormatSize(Source.PixelFormat)
                _cCount  = _depth / 8
                ' Check if bpp (Bits Per Pixel) is 8, 24, or 32
                If _depth <> 8 AndAlso _depth <> 24 AndAlso _depth <> 32 Then
                    Throw New ArgumentException("Only 8, 24 and 32 bpp images are supported.")
                End If

                ' Lock bitmap and return bitmap data
                _bitmapData = Source.LockBits(rect, ImageLockMode.ReadWrite, Source.PixelFormat)

                ' create byte array to copy pixel values
                Dim stp As Integer = _depth / 8
                _pixels = New Byte(pixelCount * stp - 1) {}
                _iptr = _bitmapData.Scan0

                ' Copy data from pointer to array
                Marshal.Copy(_iptr, _pixels, 0, _pixels.Length)
                _locked = true
            Catch ex As Exception
            End Try
        End Sub

        ''' <summary>
        ''' Unlock bitmap data
        ''' </summary>
        Public Sub UnlockBits()
            If Not _locked Then Return
            Try
                ' Copy data from byte array to pointer
                Marshal.Copy(_pixels, 0, _iptr, _pixels.Length)

                ' Unlock bitmap data
                Source.UnlockBits(_bitmapData)
                _locked = False
            Catch ex As Exception
            End Try
        End Sub

        ''' <summary>
        ''' Get the color of the specified pixel
        ''' </summary>
        ''' <param name="x"></param>
        ''' <param name="y"></param>
        ''' <returns></returns>
        Public Function GetPixel(x As Integer, y As Integer) As Color
            ' Get start index of the specified pixel
            Dim i As Integer = ((y * _width) + x) * _cCount

            If i > _pixels.Length - _cCount Then
                Throw New IndexOutOfRangeException()
            End If

            If _depth = 32 Then
                ' For 32 bpp get Red, Green, Blue and Alpha
                Dim b As Byte = _pixels(i)
                Dim g As Byte = _pixels(i + 1)
                Dim r As Byte = _pixels(i + 2)
                Dim a As Byte = _pixels(i + 3)
                ' a
                Return Color.FromArgb(a, r, g, b)
            End If
            If _depth = 24 Then
                ' For 24 bpp get Red, Green and Blue
                Dim b As Byte = _pixels(i)
                Dim g As Byte = _pixels(i + 1)
                Dim r As Byte = _pixels(i + 2)
               Return Color.FromArgb(r, g, b)
            End If
            If _depth = 8 Then
                ' For 8 bpp get color value (Red, Green and Blue values are the same)
                Dim c As Byte = _pixels(i)
               Return Color.FromArgb(c, c, c)
            End If

            Return Color.Empty
        End Function

        ''' <summary>
        ''' Set the color of the specified pixel
        ''' </summary>
        ''' <param name="x"></param>
        ''' <param name="y"></param>
        ''' <param name="color"></param>
        Public Sub SetPixel(x As Integer, y As Integer, color As Color)
            ' Get start index of the specified pixel
            Dim i As Integer = ((y * _width) + x) * _cCount

            If _depth = 32 Then
                ' For 32 bpp set Red, Green, Blue and Alpha
                _pixels(i) = color.B
                _pixels(i + 1) = color.G
                _pixels(i + 2) = color.R
                _pixels(i + 3) = color.A
                Exit Sub
            End If
            If _depth = 24 Then
                ' For 24 bpp set Red, Green and Blue
                _pixels(i) = color.B
                _pixels(i + 1) = color.G
                _pixels(i + 2) = color.R
                Exit Sub
            End If
            If _depth = 8 Then
                ' For 8 bpp set color value (Red, Green and Blue values are the same)
                _pixels(i) = color.B
                Exit Sub
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            try
            UnlockBits()
            _source.Dispose()
            _iptr = Nothing
            _bitmapData  = Nothing
            _pixels  = Nothing
            _Depth  = Nothing
            _Width  = Nothing
            _Height  = Nothing
            _cCount = Nothing
                Catch ex As Exception

                end Try
        End Sub
    End Class
End NameSpace