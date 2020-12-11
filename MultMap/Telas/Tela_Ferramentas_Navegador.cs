using System;
using System.Windows.Forms;
using CefSharp;
using MultMap.Auxiliar;

namespace MultMap.Telas
{
    public partial class Tela_Ferramentas_Navegador : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Ferramentas_Navegador";

        #endregion

        public Tela_Ferramentas_Navegador()
        {
            InitializeComponent();
            Init();
        }

        #region Eventos

        private void Tela_Ferramentas_Navegador_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Browser.CloseDevTools(); 
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

        #region Botões de Navegação

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            try
            {
                Browser.Load("https://google.com.br");
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Browser.Refresh();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_ir_Click(object sender, EventArgs e)
        {
            try
            {
                Browser.Load(Tb_url.Text);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_prox_Click(object sender, EventArgs e)
        {
            try
            {
                if (Browser.CanGoForward)
                    Browser.Forward();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_ant_Click(object sender, EventArgs e)
        {
            try
            {
                if (Browser.CanGoBack)
                    Browser.Back();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region TextBox

        private void Tb_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    Browser.Load("http://www.google.com/#q=" + Tb_pesquisa.Text);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Tb_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    Browser.Load(Tb_url.Text);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            try
            {
                Invoke(new MethodInvoker(() =>
                {
                    Tb_url.Text = e.Address;
                }));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region Métodos

        private void Init()
        {
            CarregarTema();

            try
            {
                Tb_url.Text = "www.google.com.br";
                Browser.Load(Tb_url.Text);
                Browser.AddressChanged += Browser_AddressChanged;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void CarregarTema()
        {
            try
            {
                #region BackColor

                Painel_Superior.BackColor = TemaConfig.ColorPrimary;
                Painel_Navegador.BackColor = TemaConfig.ColorPrimary;
                Tb_url.BackColor = TemaConfig.ColorPrimaryDark;
                Tb_pesquisa.BackColor = TemaConfig.ColorPrimaryDark;

                #endregion

                #region ForeColor

                Painel_Superior.ForeColor = TemaConfig.TextColorPrimary;
                Painel_Navegador.ForeColor = TemaConfig.TextColorPrimary;
                Tb_url.ForeColor = TemaConfig.TextColorPrimary;
                Tb_pesquisa.ForeColor = TemaConfig.TextColorPrimary;

                #endregion
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion
    }
}
