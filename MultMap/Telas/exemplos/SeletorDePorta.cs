using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultMap.Telas.Ferramentas;

namespace MultMap.Telas.exemplos
{
    public partial class SeletorDePorta : Form
    {
        public int result;
        public SeletorDePorta(List<CustonTextBox2> textBox)
        {
            InitializeComponent();
            int i = 1;
            var numeros = new List<Button>();
            foreach (var t in textBox)
            {
                var b = new Button();
                b.Text = i.ToString();
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.DialogResult = DialogResult.OK;
                b.Click += new EventHandler(Btn_Click);
                b.Size = new Size(30, 30);

                numeros.Add(b);
                i++;
                Flow.Controls.Add(b);
            }

            foreach(var n in numeros)
            {
                foreach (var t in textBox)
                {
                    int porta = Convert.ToInt32(n.Text);
                    int selecionado = Convert.ToInt32(t.Btn_Left.Text);
                    if (selecionado == 0)
                        continue;
                    if(porta == selecionado)
                    {
                        n.Enabled = false;
                        n.BackColor = Color.Red;
                        n.ForeColor = Color.White;
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            result = Convert.ToInt32(b.Text);
        }
    }
}
