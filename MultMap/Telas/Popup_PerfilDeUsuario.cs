using System;
using System.Windows.Forms;
using MultMap.Modelo;
using MultMap.Auxiliar;

namespace MultMap.Telas
{
    public partial class Popup_PerfilDeUsuario : Form
    {
        private const string TAG = "Popup_PerfilDeUsuario";
        public PerfilDeAcesso perfil;
        public string perfilNome;

        public Popup_PerfilDeUsuario(PerfilDeAcesso perfil = null, bool editavel = false)
        {
            InitializeComponent();
            CarregarTema();
            if (perfil != null)
            {
                LerDados(perfil, editavel);
                this.perfil = perfil;
            }
        }
       
        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            OnSalvar();
        }

        private void TB_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
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
                if (TB_Nome.Text.Trim().Length == 0)
                {
                    TB_Nome.Focus();
                    DialogResult = DialogResult.None;
                    return;
                }
                perfilNome = TB_Nome.Text;

                var MultMap = CB_MultMap.Checked;
                var MapNap = CB_MapNap.Checked;

                var UCadastro = CB_UsuarioCadastro.Checked;
                var UAlterar = CB_UsuarioAlterar.Checked;
                var UExcluir = CB_UsuarioExcluir.Checked;
                var UEmail = CB_UsuarioEmail.Checked;

                var CViabilidade = CB_CaixaViabilidade.Checked;
                var CCancelamento = CB_CaixaCancelamento.Checked;
                var CAdicionar = CB_CaixaAdicionar.Checked;
                var CAlterar = CB_CaixaAlterar.Checked;
                var CExcluir = CB_CaixaExcluir.Checked;
                var CRestaurar = CB_CaixaRestaurar.Checked;

                var PAdicionar = CB_PerfilAdicionar.Checked;
                var PAlterar = CB_PerfilAlterar.Checked;
                var PExcluir = CB_PerfilExcluir.Checked;

                var perfil = new PerfilDeAcesso(perfilNome,
                    MultMap, MapNap,
                    UCadastro, UAlterar, UExcluir, UEmail,
                    CViabilidade, CCancelamento, CAdicionar, CAlterar, CExcluir, CRestaurar,
                    PAdicionar, PAlterar, PExcluir);

                Salvar(perfil);
                perfil.Salvar();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Salvar(PerfilDeAcesso p)
        {
            if (this.perfil == null)
            {
                this.perfil = p;
                return;
            }

            perfil.multmap = p.multmap;
            perfil.mapnap = p.mapnap;

            perfil.usuarioAlterar = p.usuarioAlterar;
            perfil.usuarioCadastro = p.usuarioCadastro;
            perfil.usuarioEnviarEmail = p.usuarioEnviarEmail;
            perfil.usuarioExcluir = p.usuarioExcluir;

            perfil.caixaAdicionar = p.caixaAdicionar;
            perfil.caixaAlterar = p.caixaAlterar;
            perfil.caixaCancelamento = p.caixaCancelamento;
            perfil.caixaExcluir = p.caixaExcluir;
            perfil.caixaRestaurar = p.caixaRestaurar;
            perfil.caixaViabilidade = p.caixaViabilidade;

            perfil.perfilAdicionar = p.perfilAdicionar;
            perfil.perfilAlterar = p.perfilAlterar;
            perfil.perfilExcluir = p.perfilExcluir;
        }

        private void LerDados(PerfilDeAcesso perfil, bool editavel)
        {
            CB_MultMap.Checked = perfil.multmap;
            CB_MapNap.Checked = perfil.mapnap;

            CB_UsuarioCadastro.Checked = perfil.usuarioCadastro;
            CB_UsuarioAlterar.Checked = perfil.usuarioAlterar;
            CB_UsuarioExcluir.Checked = perfil.usuarioExcluir;
            CB_UsuarioEmail.Checked = perfil.usuarioEnviarEmail;

            CB_CaixaViabilidade.Checked = perfil.caixaViabilidade;
            CB_CaixaCancelamento.Checked = perfil.caixaCancelamento;
            CB_CaixaAdicionar.Checked = perfil.caixaAdicionar;
            CB_CaixaAlterar.Checked = perfil.caixaAlterar;
            CB_CaixaExcluir.Checked = perfil.caixaExcluir;
            CB_CaixaRestaurar.Checked = perfil.caixaRestaurar;

            CB_PerfilAdicionar.Checked = perfil.perfilAdicionar;
            CB_PerfilAlterar.Checked = perfil.perfilAlterar;
            CB_PerfilExcluir.Checked = perfil.perfilExcluir;

            TB_Nome.Text = perfil.id;

            CB_MultMap.Enabled =
            CB_MapNap.Enabled =

            CB_UsuarioCadastro.Enabled =
            CB_UsuarioAlterar.Enabled =
            CB_UsuarioExcluir.Enabled =
            CB_UsuarioEmail.Enabled =

            CB_CaixaViabilidade.Enabled =
            CB_CaixaCancelamento.Enabled =
            CB_CaixaAdicionar.Enabled =
            CB_CaixaAlterar.Enabled =
            CB_CaixaExcluir.Enabled =
            CB_CaixaRestaurar.Enabled = 

            CB_PerfilAdicionar.Enabled = 
            CB_PerfilAlterar.Enabled =
            CB_PerfilExcluir.Enabled =

            BTN_Salvar.Visible = editavel;

            TB_Nome.ReadOnly = true;

            BTN_Cancelar.Text = editavel ? "Cancelar" : "Fechar";
        }


        private void CarregarTema()
        {
            BTN_Cancelar.BackColor = TemaConfig.ColorPrimaryDark;
            BTN_Salvar.BackColor = TemaConfig.ColorPrimaryDark;

            BackColor =
            groupBox1.BackColor =
            groupBox2.BackColor =
            groupBox3.BackColor =
            groupBox4.BackColor =
            TB_Nome.BackColor = TemaConfig.ColorPrimary;

            ForeColor =
            groupBox1.ForeColor =
            groupBox2.ForeColor =
            groupBox3.ForeColor =
            groupBox4.ForeColor =
            TB_Nome.ForeColor = TemaConfig.TextColorPrimary;  
        }
    }
}
