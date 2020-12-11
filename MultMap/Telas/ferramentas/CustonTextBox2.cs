using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultMap.Telas.Ferramentas
{
    public partial class CustonTextBox2 : UserControl
    {
        //public string Hint { get; set; }
        //public ContentAlignment HintAlign { get; set; }
        public Image ButtonRightIcon { get; set; }
        public Color ButtonRightColor { get; set; }
        public Color ButtonLeftColor { get; set; }
        public int ButtonRightWidth { get; set; }
        //public int ButtonLeftWidth { get; set; }
        public bool ButtonRightVisivel { get; set; }

        public CustonTextBox2()
        {
            InitializeComponent();
            //HintAlign = ContentAlignment.MiddleLeft;
            ButtonRightWidth = Btn_Right.Width;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Btn_Right.Visible = ButtonRightVisivel;

            Btn_Right.Width = ButtonRightWidth;

            Btn_Right.BackColor = ButtonRightColor;
            Btn_Left.BackColor = ButtonLeftColor;

            if (ButtonRightIcon != null)
                Btn_Right.BackgroundImage = ButtonRightIcon;

            base.OnPaint(e);
        }

        private void CustonTextBox_TextChanged(object sender, EventArgs e)
        {
            //_Hint.Visible = Box.Text == "";
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
