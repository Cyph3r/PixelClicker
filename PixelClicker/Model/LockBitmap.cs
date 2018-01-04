using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PixelClicker.Model
{
    public class LockBitmap : IDisposable
    {
        private IntPtr _iptr = IntPtr.Zero;
        private BitmapData _bitmapData = null;
        private int _cCount;
        private bool _locked = false;

        private byte[] _pixels;

        public BitmapData BitmapData
        {
            get { return _bitmapData; }
        }

        public byte[] Pixels
        {
            get { return _pixels; }
        }
        public int cCount
        {
            get { return _cCount; }
        }
        private Bitmap _source;
        public Bitmap Source
        {
            get { return _source; }
        }


        private int _depth;
        public int Depth
        {
            get { return _depth; }
        }

        private int _width;
        public int Width
        {
            get { return _width; }
        }

        private int _height;
        public int Height
        {
            get { return _height; }
        }
        public LockBitmap(Bitmap source)
        {
            try
            {
                _source = source;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Lock bitmap data
        /// </summary>
        public void LockBits()
        {
            if (_locked)
                return;
            try
            {
                // Get width and height of bitmap
                _width = Source.Width;
                _height = Source.Height;

                // get total locked pixels count
                int pixelCount = _width * _height;

                // Create rectangle to lock
                Rectangle rect = new Rectangle(0, 0, _width, _height);

                // get source bitmap pixel format size
                _depth = Bitmap.GetPixelFormatSize(Source.PixelFormat);
                _cCount = _depth / 8;
                // Check if bpp (Bits Per Pixel) is 8, 24, or 32
                if (_depth != 8 && _depth != 24 && _depth != 32)
                {
                    throw new ArgumentException("Only 8, 24 and 32 bpp images are supported.");
                }

                // Lock bitmap and return bitmap data
                _bitmapData = Source.LockBits(rect, ImageLockMode.ReadWrite, Source.PixelFormat);

                // create byte array to copy pixel values
                int stp = _depth / 8;
                _pixels = new byte[pixelCount * stp];
                _iptr = _bitmapData.Scan0;

                // Copy data from pointer to array
                Marshal.Copy(_iptr, _pixels, 0, _pixels.Length);
                _locked = true;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Unlock bitmap data
        /// </summary>
        public void UnlockBits()
        {
            if (!_locked)
                return;
            try
            {
                // Copy data from byte array to pointer
                Marshal.Copy(_pixels, 0, _iptr, _pixels.Length);

                // Unlock bitmap data
                Source.UnlockBits(_bitmapData);
                _locked = false;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Get the color of the specified pixel
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public System.Drawing.Color GetPixel(int x, int y)
        {
            // Get start index of the specified pixel
            int i = ((y * _width) + x) * _cCount;

            if (i > _pixels.Length - _cCount)
            {
                throw new IndexOutOfRangeException();
            }

            if (_depth == 32)
            {
                // For 32 bpp get Red, Green, Blue and Alpha
                byte b = _pixels[i];
                byte g = _pixels[i + 1];
                byte r = _pixels[i + 2];
                byte a = _pixels[i + 3];
                // a
                return System.Drawing.Color.FromArgb(a, r, g, b);
            }
            if (_depth == 24)
            {
                // For 24 bpp get Red, Green and Blue
                byte b = _pixels[i];
                byte g = _pixels[i + 1];
                byte r = _pixels[i + 2];
                return System.Drawing.Color.FromArgb(r, g, b);
            }
            if (_depth == 8)
            {
                // For 8 bpp get color value (Red, Green and Blue values are the same)
                byte c = _pixels[i];
                return System.Drawing.Color.FromArgb(c, c, c);
            }

            return System.Drawing.Color.Empty;
        }

        /// <summary>
        /// Set the color of the specified pixel
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        public void SetPixel(int x, int y, System.Drawing.Color color)
        {
            // Get start index of the specified pixel
            int i = ((y * _width) + x) * _cCount;

            if (_depth == 32)
            {
                // For 32 bpp set Red, Green, Blue and Alpha
                _pixels[i] = color.B;
                _pixels[i + 1] = color.G;
                _pixels[i + 2] = color.R;
                _pixels[i + 3] = color.A;
                return;
            }
            if (_depth == 24)
            {
                // For 24 bpp set Red, Green and Blue
                _pixels[i] = color.B;
                _pixels[i + 1] = color.G;
                _pixels[i + 2] = color.R;
                return;
            }
            if (_depth == 8)
            {
                // For 8 bpp set color value (Red, Green and Blue values are the same)
                _pixels[i] = color.B;
                return;
            }
        }

        public void Dispose()
        {
            try
            {
                UnlockBits();
                _source.Dispose();
                _bitmapData = null;
                _pixels = null;
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }

}
