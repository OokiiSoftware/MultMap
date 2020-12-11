using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultMap.Telas.Ferramentas
{
    public class CustomLabel : Label
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

        public CustomLabel()
        {
            this.SetStyle(ControlStyles.UserPaint, true); //Call in constructor, Use UserPaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!Enabled)
            {
                SolidBrush drawBrush = new SolidBrush(ForeColor); //Choose colour
                e.Graphics.DrawString(Text, Font, drawBrush, Padding.Left, Padding.Top); //Dra whatever text was on the label
            }
            else
            {
                base.OnPaint(e); //Default Forecolours
            }
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radio, Radio));
        }
    }
}
