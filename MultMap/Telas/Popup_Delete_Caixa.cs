using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Telas
{
    public partial class Popup_Delete_Caixa : MetroForm
    {
        #region Variáveis

        private const string TAG = "Popup_Delete_Caixa";

        private readonly Caixa caixa;

        public int result;

        #endregion

        public Popup_Delete_Caixa(Caixa _caixa)
        {
            InitializeComponent();
            caixa = _caixa;
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

        #region Botões

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            OnExcluir();
        }

        private async void OnExcluir()
        {
            try
            {
                string motivo = tb_motivo.Text;
                if (motivo.Trim().Length == 0)
                {
                    Import.Alert(txt_Log, "Escreva o motivo da exclusão");
                    return;
                }
                Import.Alert(txt_Log, "Aguarde..");
                caixa.motivo = motivo;
                caixa.isExcluido = true;
                caixa.id_usuario = GetFirebase.usuario.id;
                caixa.data = Import.Get.DataHora;
                // Cria uma cópia da caixa em outra tabela
                // o parametro 'true' informa ao software que deve add na tabela 'caixa_excluidas' do banco
                if (await caixa.Salvar(excluidas: true))
                    result = await caixa.Delete() ? Const.CONSULTA_DB_SUCESS : Const.CONSULTA_DB_FAIL;
                Close();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #endregion

    }
}
