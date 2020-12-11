using System.Windows.Forms;
using System.Threading.Tasks;
using MultMap.Auxiliar;
using MultMap.Modelo;
using MultMap.Data;
using System;

namespace MultMap.Telas
{
    public partial class Popup_Lembrete : Form
    {
        #region Variáveis

        private const string TAG = "Popup_Lembrete";
        public readonly string popupID;

        private readonly Lembrete lembrete;

        #endregion

        public Popup_Lembrete(Lembrete item)
        {
            InitializeComponent();
            lembrete = item;

            popupID = item.id;
            txt_Titulo.Text = item.titulo;
            txt_Texto.Text = item.texto;
        }

        #region eventos

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

        private async void Popup_Lembrete_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                lembrete.texto = txt_Texto.Text;
                lembrete.isFixado = false;
                txt_Log.Visible = true;

                GetLembretes.Add(lembrete);
                await lembrete.Salvar();
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

        #endregion


        /// <summary>
        /// Metodo publico usado pra atualizar os dados do PopupLembrete
        /// </summary>
        public void Atualizar(Lembrete item)
        {
            try
            {
                txt_Titulo.Text = item.titulo;
                txt_Texto.Text = item.texto;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

    }
}
