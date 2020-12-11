using System;
using System.Drawing;
using System.Windows.Forms;
using MultMap.Auxiliar;

namespace MultMap.Telas
{
    public partial class Popup_Filtro_Relatorio : Form
    {
        #region Variáveis

        private readonly bool isGrafico;
        private const string TAG = "Popup_Filtro_Relatorio";

        public bool incluirClientes;
        public bool viabilidades;
        public bool cancelamentos;

        #endregion

        public Popup_Filtro_Relatorio(bool isGrafico = false)
        {
            InitializeComponent();
            this.isGrafico = isGrafico;
            Init();
        }

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

        #region Eventos

        private void On_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (isGrafico)
                {
                    Properties.Settings.Default.Filtro_Grafico.Clear();
                    if (Cb_1.Checked)
                        Properties.Settings.Default.Filtro_Grafico.Add(Cb_1.Text);
                    if (Cb_2.Checked)
                        Properties.Settings.Default.Filtro_Grafico.Add(Cb_2.Text);

                    Properties.Settings.Default.Filtro_Grafico_Inicio = DT_Inicio.Value;
                    Properties.Settings.Default.Filtro_Grafico_Fim = DT_Fim.Value;
                    Properties.Settings.Default.Save();

                    viabilidades = Cb_1.Checked;
                    cancelamentos = Cb_2.Checked;

                    if (!viabilidades && !cancelamentos)
                        DialogResult = DialogResult.Cancel;
                }
                else
                {
                    Properties.Settings.Default.Filtro_Imprimir.Clear();
                    if (Cb_1.Checked)
                        Properties.Settings.Default.Filtro_Imprimir.Add(Cb_1.Text);
                    //if (Cb_2.Checked)
                    //    Properties.Settings.Default.Filtro_Imprimir.Add(Cb_2.Text);
                    Properties.Settings.Default.Save();
                }
                incluirClientes = Cb_1.Checked;
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
            try
            {
                Btn_OK.Click += new EventHandler(On_Ok_Click);

                CarregarTema();

                Cb_2.Visible = isGrafico;
                Painel_1.Visible = isGrafico;

                if (isGrafico)
                {
                    Size = new Size(219, 205);

                    cabecalho1.Text = "O que deseja ver?";
                    Cb_1.Text = "Viabilidades";
                    Cb_2.Text = "Cancelamentos";

                    if (Properties.Settings.Default.Filtro_Grafico == null)
                        Properties.Settings.Default.Filtro_Grafico = new System.Collections.Specialized.StringCollection();

                    Cb_1.Checked = Properties.Settings.Default.Filtro_Grafico.Contains(Cb_1.Text);
                    Cb_2.Checked = Properties.Settings.Default.Filtro_Grafico.Contains(Cb_2.Text);

                    DT_Inicio.Value = Properties.Settings.Default.Filtro_Grafico_Inicio;
                    DT_Fim.Value = Properties.Settings.Default.Filtro_Grafico_Fim;
                }
                else
                {
                    Size = new Size(209, 95);

                    cabecalho1.Text = "O que deseja imprimir?";
                    Cb_1.Text = "Incluir Clientes";
                    Cb_2.Text = "Imprimir somente o\nitem selecionado";

                    if (Properties.Settings.Default.Filtro_Imprimir == null)
                        Properties.Settings.Default.Filtro_Imprimir = new System.Collections.Specialized.StringCollection();

                    incluirClientes = Properties.Settings.Default.Filtro_Imprimir.Contains(Cb_1.Text);
                    Cb_1.Checked = incluirClientes;
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
                BackColor = TemaConfig.ColorPrimary;
                Painel_1.BackColor = TemaConfig.ColorPrimaryDark;
                Btn_Cancel.BackColor = TemaConfig.ColorPrimaryDark;
                Btn_OK.BackColor = TemaConfig.ColorPrimaryDark;

                ForeColor = TemaConfig.TextColorPrimary;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion
    }
}
