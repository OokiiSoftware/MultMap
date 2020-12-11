using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MultMap.Telas.Ferramentas;
using MultMap.Auxiliar;
using MultMap.Modelo;
using MultMap.Telas.exemplos;

namespace MultMap.Telas
{
    public partial class Popup_Viabilidade : Form
    {
        #region Variáveis

        private static string TAG = "Popup_Viabilidade";
        private readonly Caixa caixa;
        private readonly bool isCancelamento;

        private List<CustonTextBox2> textboxClientes = new List<CustonTextBox2>();

        #endregion

        public Popup_Viabilidade(Caixa _Caixa, DialogResult result)
        {
            InitializeComponent();
            isCancelamento = result == DialogResult.No;
            caixa = _Caixa;
            Init();
        }

        #region Eventos

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Import.ArredondarBordas(this);
                base.OnPaint(e);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void On_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                BringToFront();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            OnSalvar();
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            OnRemover(sender);
        }

        private void Btn_SelecionarPorta_Click(object sender, EventArgs e)
        {
            OnSelecionarPorta(sender);
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar == ';'))
                    e.Handled = false;
                else if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    e.Handled = true;
                else
                    btn_Salvar.Visible = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #region Ação dos Eventos

        private void OnSelecionarPorta(object sender)
        {
            try
            {
                var sp = new SeletorDePorta(textboxClientes);
                sp.ShowDialog();
                if (sp.DialogResult == DialogResult.OK)
                {
                    var textbox = ((Button)sender).Tag as CustonTextBox2;
                    textbox.Btn_Left.Text = sp.result.ToString();
                }
                sp.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void OnSalvar()
        {
            try
            {
                caixa.clientes.Clear();
                foreach(var t in textboxClientes)
                    if (t.Box.Text.Trim().Length != 0)
                    {
                        if (t.Btn_Left.Text == "0")
                        {
                            t.Btn_Left.BackColor = Color.Red;
                            t.Box.Focus();
                            DialogResult = DialogResult.None;
                            break;
                        }
                        caixa.clientes.Add(t.Btn_Left.Text + ";" + t.Box.Text);
                    }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void OnRemover(object sender)
        {
            try
            {
                if (((Button)sender).Tag is CustonTextBox2 textbox)
                {
                    Log.Msg(TAG, "Remover", textbox.Box.Text);
                    btn_Salvar.Visible = true;
                    textbox.Box.Text = "";
                    textbox.Btn_Left.Text = "0";
                    textbox.Box.BackColor = Color.White;
                    textbox.Box.Focus();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void Init()
        {
            try
            {
                CriarTextBox();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void CriarTextBox()
        {
            try
            {
                int cont = isCancelamento ? caixa.clientes.Count : caixa.portas;
            
                for (int i = 0; i < cont; i++)
                {
                    var t = new CustonTextBox2
                    {
                        TabIndex = i + 1,
                        Name = i.ToString(),
                        Parent = flow_Clientes,
                        Margin = new Padding(0, 2, 0, 0)
                    };

                    if (i < caixa.clientes.Count)
                    {
                        var text = caixa.clientes[i].Split(';');
                        if (text.Length > 1)
                        {
                            t.Btn_Left.Text = text[0];
                            t.Box.Text = text[1];
                        }
                        else
                        {
                            t.Btn_Left.Text = "0";
                            t.Box.Text = text[0];
                        }
                    }

                    t.Size = new Size(Width - flow_Clientes.Padding.Left * 2, 25);
                    t.ButtonRightColor = Color.Red;
                    t.Btn_Right.Tag = t;
                    t.Btn_Right.Click += new EventHandler(Btn_Remover_Click);
                    t.Btn_Right.Visible = t.ButtonRightVisivel = t.Box.ReadOnly = isCancelamento;


                    t.Btn_Left.Tag = t;
                    t.Btn_Left.Enabled = !isCancelamento;
                    t.Btn_Left.Click += new EventHandler (Btn_SelecionarPorta_Click);
                    t.Box.KeyPress += new KeyPressEventHandler(Tb_KeyPress);

                    t.Box.CharacterCasing = CharacterCasing.Upper;
                    if (t.Box.Text.Trim().Length > 0)
                    {
                        t.Box.BackColor = Color.Gainsboro;
                        //t.Box.ForeColor = Color.White;
                    }

                    textboxClientes.Add(t);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion
    }
}
