using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultMap.Telas.Exemplos
{
    public partial class ButtonPersonalizado : Control
    {
        #region Variáveis

        public Image L_Icon_Normal { get; set; }
        public Image R_Icon_Normal { get; set; }

        public Image L_Icon_Selecionado { get; set; }
        public Image R_Icon_Selecionado { get; set; }

        public int L_Tamanho { get; set; }
        public int R_Tamanho { get; set; }

        public bool Selecionado { get; set; }

        private Color On_Leave;
        private Color Back_Color;
        public Color On_Hover { get; set; }

        public int TextoMargem { get; set; }

        #endregion

        public ButtonPersonalizado()
        {
            InitializeComponent();

            Click += new EventHandler(clique);
            MouseEnter += new EventHandler(mouseEnter);
            MouseLeave += new EventHandler(mouseLeave);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            On_Leave = ForeColor;
            Back_Color = BackColor;
            Texto.Text = Text;
            Texto.Font = Font;
            Texto.Padding = new Padding(TextoMargem, 10, 0, 0);
            SwitchIcones();
            base.OnPaint(e);
        }

        #region Eventos

        private void mouseLeave(object sender, EventArgs e)
        {
            BackColor = Back_Color;
            Texto.ForeColor = On_Leave;
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            BackColor = Back_Color;
            Texto.ForeColor = On_Hover;
        }

        private void clique(object sender, EventArgs e)
        {
            Selecionado = !Selecionado;
            SwitchIcones();
        }

        #endregion

        #region Icone

        private void SwitchIcones()
        {
            if (Selecionado)
            {
                if (L_Icon_Selecionado == null)
                    if (L_Icon_Normal == null)
                        Icone_L.Width = 0;
                    else
                        L_N();
                else
                    L_S();

                if (R_Icon_Selecionado == null)
                    if (R_Icon_Normal == null)
                        Icone_R.Width = 0;
                    else
                        R_N();
                else
                    R_S();
            }
            else
            {
                if (L_Icon_Normal == null)
                    if (L_Icon_Selecionado == null)
                        Icone_L.Width = 0;
                    else
                        L_S();
                else
                    L_N();

                if (R_Icon_Normal == null)
                    if (R_Icon_Selecionado == null)
                        Icone_R.Width = 0;
                    else
                        R_S();
                else
                    R_N();
            }
        }
        private void L_T()
        {
            if (L_Tamanho > Height)
                L_Tamanho = Height;
            else if (L_Tamanho < 0)
                Icone_L.Width = 0;
            Icone_L.Width = L_Tamanho;
        }
        private void R_T()
        {
            if (R_Tamanho > Height)
                R_Tamanho = Height;
            if (R_Tamanho < 0)
                Icone_R.Width = 0;
            Icone_R.Width = R_Tamanho;
        }

        private void L_S()
        {
            Icone_L.BackgroundImage = L_Icon_Selecionado;
            L_T();
        }
        private void L_N()
        {
            Icone_L.BackgroundImage = L_Icon_Normal;
            L_T();
        }

        private void R_S()
        {
            Icone_R.BackgroundImage = R_Icon_Selecionado;
            R_T();
        }
        private void R_N()
        {
            Icone_R.BackgroundImage = R_Icon_Normal;
            R_T();
        }

        #endregion
    }
}
