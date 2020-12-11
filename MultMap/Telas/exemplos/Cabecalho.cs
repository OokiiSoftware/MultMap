using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultMap.Telas.Exemplos
{
    public partial class Cabecalho : Control
    {

        #region Variáveis

        private bool clicando;

        private Point pCursor;
        private Point pForm;

        public bool Maximizar { get; set; }
        public bool Minimizar { get; set; }
        public Form formPai { get; set; }

        private Size MaxLocation;

        public enum _Tema
        {
            Light,
            Dark
        }
        public _Tema Tema { get; set; }

        #endregion

        public Cabecalho()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _Titulo.Text = Text;
            _Titulo.Font = Font;
            _Titulo.ForeColor = ForeColor;

            _Maximizar.Visible = Maximizar;
            _Minimizar.Visible = Minimizar;

            int tamanho = 0;
            tamanho += Maximizar ? _Maximizar.Width : 0;
            tamanho += Minimizar ? _Minimizar.Width : 0;
            tamanho += Fechar.Width;

            Flow.Width = tamanho;

            if (formPai != null)
            {
                bool b = formPai.WindowState == FormWindowState.Maximized;
                if (Tema == _Tema.Light)
                {
                    _Maximizar.BackgroundImage = b ? Properties.Resources.appbar_app_light : Properties.Resources.appbar_window_restore_light;
                    Fechar.BackgroundImage = Properties.Resources.appbar_close_light;
                    _Minimizar.BackgroundImage = Properties.Resources.appbar_minus_light;
                }
                else
                {
                    _Maximizar.BackgroundImage = b ? Properties.Resources.appbar_app_dark : Properties.Resources.appbar_window_restore_dark;
                    Fechar.BackgroundImage = Properties.Resources.appbar_close_dark;
                    _Minimizar.BackgroundImage = Properties.Resources.appbar_minus_dark;
                }
            }
            base.OnPaint(e);
        }

        private void Cabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            clicando = true;
            pCursor = Cursor.Position;
            pForm = formPai.Location;
            formPai.BringToFront();
            formPai.Focus();
        }

        private void Cabecalho_MouseUp(object sender, MouseEventArgs e)
        {
            clicando = false;
            if (MaxLocation.Width == 0)
                if (formPai != null)
                    if (formPai.Parent != null)
                        MaxLocation = formPai.Parent.Size;

            if (formPai.Location.Y < 0)
                if (Maximizar)
                    formPai.WindowState = FormWindowState.Maximized;
                else
                    formPai.Location = new Point(formPai.Location.X, 0);
            
            if(formPai.Location.X < -(formPai.Width - 90))
                formPai.Location = new Point(-(formPai.Width - 90), formPai.Location.Y);
            
            if(MaxLocation.Width > 0)
                if(formPai.Location.X > MaxLocation.Width - 50)
                    formPai.Location = new Point(MaxLocation.Width - 50, formPai.Location.Y);
        }

        private void Cabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicando)
            {
                if (formPai.WindowState == FormWindowState.Maximized)
                    formPai.WindowState = FormWindowState.Normal;

                Point dif = Point.Subtract(Cursor.Position, new Size(pCursor));
                formPai.Location = Point.Add(pForm, new Size(dif));
            }
        }

        private void Cabecalho_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(Maximizar)
                _Maximizar_Click(sender, e);
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            formPai.Close();
            formPai.Dispose();
        }

        private void _Maximizar_Click(object sender, EventArgs e)
        {
            bool b = formPai.WindowState == FormWindowState.Maximized;
            formPai.WindowState = b ? FormWindowState.Normal : FormWindowState.Maximized;

            b = formPai.WindowState == FormWindowState.Maximized;

            if (Tema == _Tema.Light)
                _Maximizar.BackgroundImage = b ? Properties.Resources.appbar_app_light : Properties.Resources.appbar_window_restore_light;
            else
                _Maximizar.BackgroundImage = b ? Properties.Resources.appbar_app_dark : Properties.Resources.appbar_window_restore_dark;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            formPai.Visible = false;
        }
    }
}
