using System;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Telas
{
    partial class Popup_Caixa : Form
    {
        #region Variáveis

        private const string TAG = "Popup_Caixa";
        private readonly int popupID;

        public int result;

        private readonly Caixa caixa;

        #endregion

        public Popup_Caixa(Caixa item, int popupID)
        {
            InitializeComponent();
            this.popupID = popupID;
            this.caixa = item;
            Init(item);
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

        private void Btn_Restaurar_Click(object sender, EventArgs e)
        {
            OnRestaurar();
        }

        private void Btn_VerNoMapa_Click(object sender, EventArgs e)
        {
            OnAbrirMapa();
        }

        #region Ações dos Botões

        private async void OnRestaurar()
        {
            try
            {
                if (popupID == Import.tela_Inicio.indice_relatorio_caixas) return;

                result = Const.CONSULTA_DB_FAIL;
                txt_Log.Visible = true;
                caixa.isExcluido = false;
                caixa.motivo = null;
                caixa.data = Import.Get.DataHora;

                Log.Msg(TAG, "OnRestaurar", caixa.id);
                if (await caixa.Salvar())
                    if (popupID == Import.tela_Inicio.indice_historico_alteracao)
                        result = Const.CONSULTA_DB_SUCESS;
                    else
                        result = await caixa.Delete(excluidas: true) ? Const.CONSULTA_DB_SUCESS : Const.CONSULTA_DB_FAIL;
                Close();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private  void OnAbrirMapa()
        {
            try
            {
                Import.tela_Inicio.AbrirMapa(caixa.latitude, caixa.longitude);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void Init(Caixa item)
        {
            try
            {
                CarregarTema();

                txt_Nome.Text = item.nome;
                txt_Status.Text = item.status;
                txt_Portas.Text = item.clientes.Count + " usadas de " + item.portas.ToString();
                txt_Estado.Text = item.endereco.estado;
                txt_Bairro.Text = item.endereco.bairro;
                txt_Rua.Text = item.endereco.rua;
                txt_Data.Text = item.data.ToString();
                txt_Funcionario.Text = item.usuario.nome;
                txt_Cidade.Text = item.endereco.cidade;
                txt_Tipo.Text = item.pon.ToString();

                if (popupID == Import.tela_Inicio.indice_relatorio_caixas)
                {
                    Btn_Viabilidade.Visible = GetMeuPerfil.caixaViabilidade;
                    Btn_Cancelamento.Visible = GetMeuPerfil.caixaCancelamento;
                    Log.Msg(TAG, "Indice Tela", "RELATORIO_CAIXAS");
                }
                else if (popupID == Import.tela_Inicio.indice_historico_alteracao)
                {
                    Btn_Viabilidade.Visible = false;
                    Btn_Cancelamento.Visible = false;
                    Btn_Restaurar.Visible = GetMeuPerfil.caixaRestaurar;
                    Btn_Restaurar.DialogResult = DialogResult.None;
                    Log.Msg(TAG, "Indice Tela", "HISTORICO_ALTERACAO");
                }
                else if (popupID == Import.tela_Inicio.indice_historico_exclusao)
                {
                    txt_Cidade.Text = item.motivo;
                    _txt_cidade.Text = "Motivo";
                    Btn_Viabilidade.Visible = false;
                    Btn_Cancelamento.Visible = false;
                    Btn_Restaurar.Visible = GetMeuPerfil.caixaRestaurar;
                    Btn_Restaurar.DialogResult = DialogResult.None;
                    Log.Msg(TAG, "Indice Tela", "HISTORICO_EXCLUSAO");
                }
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

                BackColor = TemaConfig.ColorPrimary;

                #endregion

                #region ForeColor

                ForeColor = TemaConfig.TextColorPrimary;

                #endregion
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Retorna o Perfil do usuario logado
        /// </summary>
        /// <returns></returns>
        private PerfilDeAcesso GetMeuPerfil => GetFirebase.usuario.perfil;

        #endregion
    }
}
