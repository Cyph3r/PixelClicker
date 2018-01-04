using System.ComponentModel;
using System.Drawing;
using System.Threading;
using PixelClicker.Extensions;
using PixelClicker.Model;

namespace PixelClicker.Core
{
    internal class Capture
    {
        public event NewImageEventHandler NewImage;
        public delegate void NewImageEventHandler(Bitmap b);
        private readonly BackgroundWorker _captureBgWorker;
        public Capture()
        {
            _captureBgWorker = new BackgroundWorker {WorkerSupportsCancellation = true};
            _captureBgWorker.DoWork += DoWork;
        }
        public void Start()
        {
            if (_captureBgWorker.IsBusy) return;
            _captureBgWorker.RunWorkerAsync();
        }
        public void Cancel()
        {
            _captureBgWorker.CancelAsync();
        }
        private void DoWork(object sender, DoWorkEventArgs e)
        {
            while (!_captureBgWorker.CancellationPending)
            {
               // Thread.Sleep(1);
                Tasks.Items.UpdateTaskSize();
                CopyScreen();
            }
        }
        private void CopyScreen()
        {
            Bitmap b = new Bitmap(Tasks.MaxSearchArea.Width, Tasks.MaxSearchArea.Height);
            using (var g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(Tasks.HeightestSearchPosition.X, Tasks.HeightestSearchPosition.Y, 0, 0, Tasks.MaxSearchArea);
            }
            NewImage?.Invoke(b);
        }
    }
}
