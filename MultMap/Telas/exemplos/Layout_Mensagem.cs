using System;
using System.Drawing;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.exemplos
{
    public partial class Layout_Mensagem : UserControl
    {
        private bool MinhaMsg;

        public Layout_Mensagem(Mensagem m)
        {
            InitializeComponent();
            MinhaMsg = m.Getid_remetente() == GetFirebase.usuario.id;

            Texto.Text = m.Getmensagem();
            string hora = m.Getdata_de_envio();
            Horario.Text = Import.SplitData(hora);

            Color color;

            if (MinhaMsg)
            {
                color = Color.DeepSkyBlue;
                //Nome.Visible = false;
            }
            else
            {
                color = Color.Gainsboro;
                //Nome.Text = Import.GetNomeUsuario(m.Getid_remetente());
            }
            Container_2.BackColor = color;
        }

        private void On_SizeChanged(object sender, EventArgs e)
        {
            AjustarVariaveis();
        }

        private void Layout_Mensagem_ParentChanged(object sender, EventArgs e)
        {
            AjustarVariaveis();
            if(Parent != null)
                Parent.SizeChanged += new EventHandler(On_SizeChanged);
        }

        private void AjustarVariaveis()
        {
            Width = Parent.Width - 20 - Margin.Left * 2;

            if (MinhaMsg)
                Container_2.Dock = DockStyle.Right;
            else
                Container_2.Dock = DockStyle.Left;

            Container_2.Width = Texto.Width + Horario.Width;
            Container_Texto.Width = Texto.Width;
            Container_Texto.Height = Texto.Height;

            //Nome.Width = Container_Geral.Width;

            //int mais = Nome.Visible ? Nome.Height : 0;
            Height = Texto.Height;
        }
    }
}
