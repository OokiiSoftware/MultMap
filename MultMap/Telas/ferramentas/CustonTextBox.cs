using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultMap.Telas.Ferramentas
{
    public partial class CustonTextBox : TextBox
    {
        public string Hint { get; set; }
        public ContentAlignment HintAlign { get; set; }
        public Image ButtonIcon { get; set; }
        public Color ButtonColor { get; set; }
        public int ButtonWidth { get; set; }
        public bool ButtonVisivel { get; set; }

        public CustonTextBox()
        {
            InitializeComponent();
            HintAlign = ContentAlignment.MiddleLeft;
            ButtonWidth = Botao.Width;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _Hint.Text = Hint;
            _Hint.Font = Font;
            _Hint.Visible = Text == "";
            _Hint.Height = Height;
            _Hint.TextAlign = HintAlign;

            Botao.Visible = ButtonVisivel;
            Botao.Width = ButtonWidth;
            Botao.BackColor = ButtonColor;
            if (ButtonIcon != null)
                Botao.BackgroundImage = ButtonIcon;
            base.OnPaint(e);
        }

        private void CustonTextBox_TextChanged(object sender, EventArgs e)
        {
            _Hint.Visible = Text == "";
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
