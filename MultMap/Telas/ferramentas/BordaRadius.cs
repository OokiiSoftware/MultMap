using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultMap.Telas.Ferramentas
{
    class BordaRadius : Control
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
        
        public Form Target { get; set; }
        public int Radio { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Target.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Target.Width, Target.Height, Radio, Radio));
            }
            catch
            {

            }
            base.OnPaint(e);
        }
    }
}
