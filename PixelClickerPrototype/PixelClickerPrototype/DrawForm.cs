using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace PixelClickerPrototype
{
    public partial class DrawForm : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private int InitialStyle;
        public DrawForm()
        {
            InitializeComponent();
            Load += DrawForm_Load;
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {
            InitialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, InitialStyle | 0x80000 | 0x20);
            this.TopMost = true;
            this.ShowInTaskbar = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Program.Settings.Draw && (Program.Settings.CurrentAimPos.X > 0 || Program.Settings.CurrentAimPos.Y > 0))
            {
                Pen linePenYellow = new Pen(Color.Yellow);
               
                Graphics grphx = this.CreateGraphics();

                grphx.Clear(this.BackColor);
                //Draw verticle line
                grphx.DrawLine(linePenYellow, Program.Settings.CurrentAimPos.X, 0, Program.Settings.CurrentAimPos.X, this.ClientSize.Height - 1);

                //Draw horizontal line
                grphx.DrawLine(linePenYellow, 0, Program.Settings.CurrentAimPos.Y, this.ClientSize.Width - 1, Program.Settings.CurrentAimPos.Y);


                if (Program.Settings.PointsInfo != null)
                {
                    Size size = new Size(Program.Settings.PointsInfo.LowestPoint.X+12 - Program.Settings.PointsInfo.HighestPoint.X,
                        Program.Settings.PointsInfo.LowestPoint.Y+12 - Program.Settings.PointsInfo.HighestPoint.Y);

                    grphx.DrawRectangle(linePenYellow, Program.Settings.PointsInfo.HighestPoint.X-6, Program.Settings.PointsInfo.HighestPoint.Y-6, size.Width, size.Height);

                }

                linePenYellow.Dispose();
                grphx.Dispose();
            }

            base.OnPaint(e);
        }
    }
}
