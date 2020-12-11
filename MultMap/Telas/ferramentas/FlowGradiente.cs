using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultMap.Telas.Ferramentas
{
    public class FlowGradiente : FlowLayoutPanel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int LeftRect,
                int TopRect,
                int RightRect,
                int BottonRect,
                int widthRect,
                int heightRect
            );

        public int Radio { get; set; }

        public Color colorTop { get; set; }
        public Color colorBoton { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, colorTop, colorBoton, 90F);
                Graphics g = e.Graphics;
                g.FillRectangle(brush, ClientRectangle);
            }
            catch
            {

            }

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radio, Radio));
            base.OnPaint(e);
        }
    }
}
