using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MultMap.Telas.Ferramentas
{
    public partial class CustomCheckBox : Control
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

        public bool Selecionado { get; set; }

        public Color SelecionadoTrue { get; set; }
        public Color SelecionadoFalse { get; set; }

        public CustomCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Switch();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radio, Radio));
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            Selecionado = !Selecionado;
            Switch();
            base.OnClick(e);
        }

        private void Switch()
        {
            BackColor = Selecionado ? SelecionadoTrue : SelecionadoFalse;
        }
    }
}
