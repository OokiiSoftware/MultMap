using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Telas
{
    public partial class Tela_Ferramentas_Lembrete : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Ferramentas_Lembrete";

        private int indiceItemExcluido;

        private Lembrete currentLembrete;

        private DataTable dataTable = new DataTable();

        #endregion

        private static class Textos
        {
            #region Geral

            public static string VAZIO { get => ""; }
            public static string NOVO { get => "Novo"; }

            #endregion

            public static class Tabela
            {
                public static string ID { get => "id"; }
                public static string TITULO { get => "titulo"; }
                public static string TEXTO { get => "texto"; }
                public static string ALARME { get => "alarme"; }
                public static string FIXADO { get => "fixado"; }
            }

        }

        public Tela_Ferramentas_Lembrete()
        {
            InitializeComponent();

            GetLembretes.OnAdd += OnAddLembrete;
            GetLembretes.OnRemove += OnRemoveLembrete;

            this.FormClosing += (sender, e) =>
            {
                GetLembretes.OnAdd -= OnAddLembrete;
                GetLembretes.OnRemove -= OnRemoveLembrete;
            };

            CriarTabela(dataTable);
            Init();
        }

        #region Evantos

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

        private void OnAddLembrete(Lembrete item)
        {
            AtualizarTabela(item);
        }
        
        private void OnRemoveLembrete(Lembrete item)
        {
            try
            {
                var linha = dataTable.Rows.Find(item.id);
                if (linha == null) return;

                indiceItemExcluido = dataTable.Rows.IndexOf(linha);

                if (indiceItemExcluido >= 0)
                    dataTable.Rows.Remove(linha);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #region Botões

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            OnAdicionar();
        }
        
        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            OnExcluir();
        }
        
        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            OnAtualizar();
        }
        
        private async void OnAdicionar()
        {
            try
            {
                if (currentLembrete == null)
                {
                    if (tb_titulo.Text.Trim().Length == 0 || tb_texto.Text.Trim().Length == 0)
                        return;

                    Lembrete item = new Lembrete
                    {
                        id = Import.Get.RandomString(10),
                        titulo = tb_titulo.Text,
                        texto = tb_texto.Text
                    };
                    if (TB_Destino.Text.Trim().Length == 0)
                        item.idUsuario = GetFirebase.usuario.id;
                    else
                    {
                        var user = GetUsuarios.Get(Cript.EncriptBase64(TB_Destino.Text));
                        if(user == null)
                        {
                            Import.Alert(Txt_Log, "Usuário destino não encontrado", isErro: true);
                            return;
                        }
                        item.idUsuario = user.id;
                    }
                    item.isFixado = cb_fixar.Checked;
                    item.isAlarme = cb_alarme.Checked;
                    item.dataAlarme = (cb_alarme.Checked ? time_Alarme.Value : DateTime.Now);

                    GetLembretes.Add(item);

                    if (!await item.Salvar())
                        MessageBox.Show("Não foi possivel salvar no banco de dados");
                    else
                        ResetarDados();
                }
                else
                {
                    ResetarDados();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private async void OnAtualizar()
        {
            if (tb_titulo.Text.Trim().Length == 0 || tb_texto.Text.Trim().Length == 0) return;

            try
            {
                Lembrete item = currentLembrete;
                if (item == null)
                    item = new Lembrete();
                item.titulo = tb_titulo.Text;
                item.texto = tb_texto.Text;
                item.isFixado = cb_fixar.Checked;
                item.isAlarme = cb_alarme.Checked;
                if (TB_Destino.Text.Trim().Length == 0)
                    item.idUsuario = GetFirebase.usuario.id;
                else
                {
                    var user = GetUsuarios.Get(Cript.EncriptBase64(TB_Destino.Text));
                    if (user == null)
                    {
                        Import.Alert(Txt_Log, "Usuário destino não encontrado", true);
                        return;
                    }
                    item.idUsuario = user.id;
                }
                if (cb_alarme.Checked)
                    item.dataAlarme = time_Alarme.Value;

                GetLembretes.Add(item);
                ResetarDados();
                await item.Salvar();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private async void OnExcluir()
        {
            try
            {
                if (currentLembrete == null)
                {
                    MessageBox.Show("Nenhum item selecione");
                    return;
                }
                if (await currentLembrete.Delete())
                {
                    GetLembretes.Remove(currentLembrete);
                    ResetarDados();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region CheckBox

        private void Cb_fixar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cb_fixar.BackColor = cb_fixar.Checked ? Color.GreenYellow : Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Cb_alarme_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                time_Alarme.Visible = cb_alarme.Checked;
                if (currentLembrete == null)
                    time_Alarme.Value = DateTime.Now;
                else if (currentLembrete.dataAlarme == null)
                    time_Alarme.Value = DateTime.Now;
                else if (currentLembrete.dataAlarme < DateTime.Now)
                    time_Alarme.Value = DateTime.Now;
                else
                    time_Alarme.Value = currentLembrete.dataAlarme;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region Tabela

        private void Tabela_lembretes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CelulaSingleClick(e.RowIndex);
        }

        private void Tabela_lembretes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CelulaDoubleClick(e.RowIndex);
        }

        private void CelulaSingleClick(int indice)
        {
            if (indice < 0) return;

            try
            {
                Tabela.Rows[indice].Selected = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void CelulaDoubleClick(int indice)
        {
            if (indice < 0) return;

            try
            {
                var rowClicked = Tabela.Rows[indice];
                var itemID = rowClicked.Cells[Textos.Tabela.ID].Value.ToString();

                currentLembrete = GetLembretes.Get(itemID);

                tb_titulo.Text = currentLembrete.titulo;
                tb_texto.Text = currentLembrete.texto;

                cb_fixar.Checked = currentLembrete.isFixado;
                cb_alarme.Checked = currentLembrete.isAlarme;

                btn_excluir.Visible = true;
                btn_atualizar.Visible = true;
                btn_adicionar.Text = "Limpar";
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        //=====
        private void On_Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (e.Action == DataRowAction.Delete)
                    TabelaLayout.InvokeRemoveLinha(Tabela, indiceItemExcluido);
                if (e.Action == DataRowAction.Add)
                    TabelaLayout.InvokeAddLinha(Tabela, e);
                else if (e.Action == DataRowAction.Change)
                    TabelaLayout.InvokeAlterarLinha(Tabela, e.Row.Table.Rows.IndexOf(e.Row), e);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void On_Table_Cleared(object sender, DataTableClearEventArgs e)
        {
            try
            {
                TabelaLayout.InvokeClear(Tabela);
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
            CarregarTema();
            Listar();
        }

        private void CarregarTema()
        {
            try
            {
                TabelaLayout.SetTema(Tabela);

                #region BackColor

                BackColor = TemaConfig.ColorPrimary;
                tb_texto.BackColor = TemaConfig.ColorPrimaryDark;
                tb_titulo.BackColor = TemaConfig.ColorPrimaryDark;
                TB_Destino.BackColor = TemaConfig.ColorPrimaryDark;

                #endregion

                #region ForeColor

                ForeColor = TemaConfig.TextColorPrimary;
                tb_texto.ForeColor = TemaConfig.TextColorPrimary;
                tb_titulo.ForeColor = TemaConfig.TextColorPrimary;
                TB_Destino.ForeColor = TemaConfig.TextColorPrimary;

                #endregion
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Listar()
        {
            try
            {
                dataTable.Rows.Clear();
                for (int i = 0; i < GetLembretes.data.Count; i++)
                    AddLinhaTabela(i +1, GetLembretes.data[i]);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void AddLinhaTabela(int indice, Lembrete item)
        {
            try
            {
                dataTable.Rows.Add(TabelaLayout.GetNewLinha(indice, item));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void ResetarDados()
        {
            try
            {
                tb_titulo.Text =
                tb_texto.Text = Textos.VAZIO;
                btn_adicionar.Text = Textos.NOVO;

                cb_fixar.Checked =
                cb_alarme.Checked =
                btn_excluir.Visible =
                btn_atualizar.Visible = false;

                currentLembrete = null;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        public void AtualizarTabela(Lembrete item)
        {
            try
            {
                int indice = dataTable.Rows.IndexOf(dataTable.Rows.Find(item.id));
                if (indice >= 0)
                    dataTable.Rows[indice].ItemArray = TabelaLayout.GetNewLinha(indice, item);
                else
                    AddLinhaTabela(Tabela.Rows.Count, item);
            }
            catch  (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Cria todas as colunas necessárias da tabela e adiciona os eventos
        /// </summary>
        private void CriarTabela(DataTable table)
        {
            try
            {
                DataColumn[] c = { TabelaLayout.GetNewColuna(Textos.Tabela.ID) };
                table.Columns.Add(TabelaLayout.GetNewColuna("*", Type.GetType("System.Int32")));
                table.Columns.Add(c[0]);
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.TITULO));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.TEXTO));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.ALARME, Type.GetType("System.Boolean")));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.FIXADO, Type.GetType("System.Boolean")));
                table.PrimaryKey = c;

                table.TableCleared += new DataTableClearEventHandler(On_Table_Cleared);
                table.RowChanged += new DataRowChangeEventHandler(On_Row_Changed);
                table.RowDeleted += new DataRowChangeEventHandler(On_Row_Changed);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion
    }
}
