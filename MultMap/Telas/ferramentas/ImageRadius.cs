using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultMap.Telas.Ferramentas
{
    public class ImageRadius : PictureBox
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (
                int LeftRect, int TopRect, int RightRect,
                int BottonRect, int widthRect, int heightRect
            );

        public int Radio { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radio, Radio));
            base.OnPaint(e);
        }
    }
}
