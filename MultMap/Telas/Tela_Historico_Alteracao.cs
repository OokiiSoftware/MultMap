using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Telas
{
    public partial class Tela_Historico_Alteracao : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Historico_Alteracao";
        private readonly int telaID;

        private int indiceItemExcluido;
        private bool IsAtualizando;

        /// <summary>
        /// Armazena temporariamente a pesquisa.
        /// (Quando o usuário da Duplo Click em uma Caixa => [<see cref="Tb_Pesquisa"/> = ""]
        /// e quando o usuário volta => [<see cref="Tb_Pesquisa"/> = <see cref="cachePesquisa"/>])
        /// </summary>
        private string cachePesquisa;

        /// <summary>
        /// Armazena a Caixa que o usuário deu Duplo Click na Tabela
        /// </summary>
        private Caixa_Alterada currentCaixa;

        private List<Caixa_Alterada> caixas_Alteradas_Busca = new List<Caixa_Alterada>();
        private List<Caixa_Alterada> caixas_Alteradas_Selecionadas = new List<Caixa_Alterada>();
        
        private List<Caixa> caixas_Busca = new List<Caixa>();
        private List<Caixa> caixas_Selecionadas = new List<Caixa>();

        // Elementos da tabela
        private DataTable dataTable_Alteradas = new DataTable();
        private DataTable dataTable = new DataTable();

        // Elementos pro controle de paginação
        private static int quant_item_por_pagina = 25;
        private int inicio = 0;
        private int pagina_indice_atual = 1;
        private int fim = quant_item_por_pagina;
        private float pagina_indice_max;

        /// <summary>
        /// Firebase.
        /// Observa alterações no database
        /// </summary>
        private IDisposable FirebaseObservable;

        #endregion

        private static class Textos
        {
            #region Geral

            public static string VAZIO { get => ""; }

            public static string AGUARDE { get => "Aguarde"; }
            public static string CANCELADO { get => "Operação cancelada"; }

            #endregion

            public static class Tabela
            {
                public static string ID { get => "id"; }
                public static string ID_2 { get => "id_2"; }
                public static string NOME { get => "Nome"; }
                public static string CONT { get => "Quantidade"; }
                public static string STATUS { get => "Status"; }
                public static string SELECAO { get => "Selecionado"; }
                public static string SELECAO_2 { get => "Selecionado_2"; }
                public static string PORTA { get => "Portas"; }
                public static string PORTA_DISP { get => "Disponivel"; }
                public static string DATA { get => "Data"; }
                public static string FUNCIONARIO { get => "Funcionário"; }
            }

        }

        public Tela_Historico_Alteracao(int telaID)
        {
            InitializeComponent();
            this.telaID = telaID;

            GetCaixasAlteraradas.OnAdd += OnAddCaixa;
            GetCaixasAlteraradas.OnRemove += OnRemoveCaixa;

            CriarTabela_Caixas_Alteradas(dataTable_Alteradas);
            CriarTabela_Caixas(dataTable);
            Init();
        }

        #region Eventos

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

        private void Tela_Historico_Alteracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (FirebaseObservable != null)
                    FirebaseObservable.Dispose();

                GetCaixasAlteraradas.OnAdd -= OnAddCaixa;
                GetCaixasAlteraradas.OnRemove -= OnRemoveCaixa;

            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Adiciona ou substitui o item na tabela
        /// </summary>
        private void OnAddCaixa(Caixa_Alterada item)
        {
            try
            {
                // Só quero atualizar se a caixa tiver informações novas
                if (!item.isNovo) return;

                if (item.isEditado)
                {
                    DataRow dataRow = dataTable_Alteradas.Rows.Find(item.id);
                    if (dataRow != null)
                    {
                        int indice = dataTable_Alteradas.Rows.IndexOf(dataRow) + 1;
                        bool caixa_Selecionada = caixas_Alteradas_Selecionadas.Contains(item);
                        dataRow.ItemArray = TabelaLayout.GetNewLinha(indice, item, caixa_Selecionada);
                    }

                    if (currentCaixa != null)
                    {
                        currentCaixa = item;
                        if (dataTable.Rows.Count < quant_item_por_pagina)
                            AddLinhaTabela(dataTable.Rows.Count + 1, item.GetCaixa(item.caixas.Count - 1));
                    }
                }
                else if (dataTable_Alteradas.Rows.Count < quant_item_por_pagina)
                {
                    AddLinhaTabela(Tabela_Alterada.Rows.Count + 1, item);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Remove o item da tabela
        /// </summary>
        private void OnRemoveCaixa(Caixa_Alterada item)
        {
            try
            {
                var linha = dataTable_Alteradas.Rows.Find(item.id);
                if (linha == null) return;

                indiceItemExcluido = dataTable_Alteradas.Rows.IndexOf(linha);

                if (indiceItemExcluido >= 0)
                    dataTable_Alteradas.Rows.Remove(linha);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #region Botões

        //============== Botões do menu Superior
        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            OnVoltarCaixas();
        }
        
        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            OnAtualizar();
        }
        
        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            OnImprimir();
        }

        //============== Botões da barra Inferior
        private void Btn_prox_Click(object sender, EventArgs e)
        {
            OnProximo();
        }
        
        private void Btn_ant_Click(object sender, EventArgs e)
        {
            OnVoltar();
        }

        #region Ações dos botões

        /// <summary>
        /// Baixa a lista de caixas alteradas do database e atualiza a tabela.
        /// </summary>
        private async void OnAtualizar()
        {
            try
            {
                IsAtualizando = true;
                Alert(Textos.AGUARDE);
                btn_atualizar.Visible = false;

                Timer timer = NewTimerOnUpdate(mostrarProgressBar: true);
                timer.Start();
                var items = await Caixa_Alterada.BaixarLista();
                GetCaixasAlteraradas.AddAll(items);
                timer.Dispose();

                if(currentCaixa != null)
                {
                    dataTable.Clear();
                    currentCaixa = GetCaixasAlteraradas.Get(currentCaixa.id);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            //Listar();

            IsAtualizando = false;
            btn_atualizar.Visible = true;
            Alert(mostrar: false);
        }

        private void OnImprimir()
        {
            try
            {
                if (currentCaixa == null)
                {
                    var items = caixas_Alteradas_Selecionadas.Count == 0 ? GetCaixasAlteraradas.data : caixas_Alteradas_Selecionadas;
                    GetRelatorio.CriarRelatorio(items);
                }
                else
                {
                    var items = caixas_Selecionadas.Count == 0 ? currentCaixa.caixas : caixas_Selecionadas;
                    GetRelatorio.CriarRelatorio(items, Name);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Proxima página dos items mostrados na tela
        /// </summary>
        private void OnProximo()
        {
            try
            {
                pagina_indice_atual++;
                if (pagina_indice_atual > pagina_indice_max)
                {
                    pagina_indice_atual = (int)pagina_indice_max;
                    btn_prox.Enabled = false;
                }
                else
                {
                    inicio += quant_item_por_pagina;
                    btn_ant.Enabled = true;
                    Listar();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Página anterior dos items mostrados na tela
        /// </summary>
        private void OnVoltar()
        {
            try
            {
                pagina_indice_atual--;
                if (pagina_indice_atual < 1)
                    pagina_indice_atual = 1;
                else
                {
                    inicio -= quant_item_por_pagina;
                    btn_prox.Enabled = true;
                    Listar();
                }
                if (pagina_indice_atual == 1)
                    btn_ant.Enabled = false;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Oculta a Tabela normal e mostra a Tabela de caixas Alteradas
        /// </summary>
        private void OnVoltarCaixas()
        {
            try
            {
                currentCaixa = null;
                Tabela.Visible = false;
                btn_voltar.Visible = false;
                Tb_Pesquisa.Text = cachePesquisa;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            Listar();
        }

        #endregion

        #endregion

        #region TextBox

        private bool primeiroDigito;

        private void Tb_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Tb_Quant_Itens_Por_Pagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Tb_Quant_Itens_Por_Pagina_TextChanged(object sender, EventArgs e)
        {
            AjustarTabela();
        }

        private void Pesquisar()
        {
            try
            {
                if (Tb_Pesquisa.Text.Trim().Length > 0)
                {
                    //Comum(); // <- tava aqui e eu coloquei abaixo do (if)
                    if (currentCaixa == null)
                    {
                        caixas_Alteradas_Busca.Clear();
                        caixas_Alteradas_Busca.AddRange(FindCaixas_Alteradas(Tb_Pesquisa.Text));
                    }
                    else
                    {
                        caixas_Busca.Clear();
                        caixas_Busca.AddRange(FindCaixas(Tb_Pesquisa.Text));
                    }
                    Comum();
                    //Listar();
                }
                // O primeiroDigito serve pra não atualizar a lista antes de ser inserido o promeiro digito da pesquisa
                if (Tb_Pesquisa.Text.Trim().Length == 0 && primeiroDigito)
                {
                    Comum();
                    //Listar();
                    primeiroDigito = false;
                }
                primeiroDigito = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void AjustarTabela()
        {
            try
            {
                if (tb_Quant_Itens_Por_Pagina.Text != "" && Convert.ToInt32(tb_Quant_Itens_Por_Pagina.Text) > 0 &&
                    Convert.ToInt32(tb_Quant_Itens_Por_Pagina.Text) < 1001)
                {
                    quant_item_por_pagina = Convert.ToInt32(tb_Quant_Itens_Por_Pagina.Text);
                    Comum();
                    //Listar();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Comum()
        {
            try
            {
                pagina_indice_atual = 1;
                inicio = 0;
                Listar();
                //fim = inicio + quant_item_por_pagina;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region DateTimePicker

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void Cb_SelecionarTudo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (currentCaixa == null)
                {
                    var cs = caixas_Alteradas_Busca.Count > 0 ? caixas_Alteradas_Busca : GetCaixasAlteraradas.data;
                    TabelaLayout.MultiSelectCheckbox(Tabela_Alterada, Cb_SelecionarTudo.Checked, Textos.Tabela.SELECAO, cs, caixas_Alteradas_Selecionadas, Txt_Cont_Selecao);
                }
                else
                {
                    var cs = caixas_Busca.Count > 0 ? caixas_Busca : currentCaixa.caixas;
                    TabelaLayout.MultiSelectCheckbox(Tabela, Cb_SelecionarTudo.Checked, Textos.Tabela.SELECAO_2, cs, caixas_Selecionadas, Txt_Cont_Selecao);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region Tabela

        private void Tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CelulaSingleClick(e.RowIndex);
        }

        private void Tabela_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CelulaSingleClick_2(e.RowIndex);
        }

        private void Tabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CelulaDoubleClick(e.RowIndex);
        }
        
        private void Tabela_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CelulaDoubleClick_2(e.RowIndex);
        }

        private void Tabela_KeyPress(object sender, KeyPressEventArgs e)
        {
            TabelaOn_KeyPress(e);
        }

        private void Tabela_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tabela_2_On_KeyPress(e);
        }

        private void TabelaOn_KeyPress(KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (caixas_Alteradas_Selecionadas.Count > 0)
                    {
                        Import.Alert(txt_Log, Textos.CANCELADO);
                        caixas_Alteradas_Selecionadas.Clear();
                        Txt_Cont_Selecao.Text = Textos.VAZIO;
                        Listar();
                    }
                    btn_imprimir.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Tabela_2_On_KeyPress(KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (caixas_Selecionadas.Count > 0)
                    {
                        Import.Alert(txt_Log, Textos.CANCELADO);
                        caixas_Selecionadas.Clear();
                        Txt_Cont_Selecao.Text = Textos.VAZIO;
                        Listar();
                    }
                    btn_imprimir.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Click simples na Tabela Caixas Alteradas
        /// </summary>
        /// <param name="indice">Posição do item clicado</param>
        private void CelulaSingleClick(int indice)
        {
            if (IsAtualizando || indice < 0 || ModifierKeys != Keys.Control) return;

            try
            {
                var linha = Tabela_Alterada.Rows[indice];
                var itemID = linha.Cells[Textos.Tabela.ID].Value.ToString();
                var item = GetItemsNoFiltro_Alteradas().Find(x => x.id.Equals(itemID));

                if (caixas_Alteradas_Selecionadas.Contains(item))
                {
                    caixas_Alteradas_Selecionadas.Remove(item);
                    linha.Cells[Textos.Tabela.SELECAO].Value = false;
                }
                else
                {
                    caixas_Alteradas_Selecionadas.Add(item);
                    linha.Cells[Textos.Tabela.SELECAO].Value = true;
                }

                Txt_Cont_Selecao.Text = caixas_Alteradas_Selecionadas.Count == 0 ? Textos.VAZIO : Textos.Tabela.SELECAO + "s: " + caixas_Alteradas_Selecionadas.Count.ToString();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Click simples na Tabela Caixas
        /// </summary>
        /// <param name="indice">Posição do item clicado</param>
        private void CelulaSingleClick_2(int indice)
        {
            if (IsAtualizando || indice < 0 || ModifierKeys != Keys.Control) return;

            try
            {
                var linha = Tabela.Rows[indice];
                var itemID = linha.Cells[Textos.Tabela.ID_2].Value.ToString();
                var item = GetItemsNoFiltro().Find(x => x.id.Equals(itemID));

                if (caixas_Selecionadas.Contains(item))
                {
                    caixas_Selecionadas.Remove(item);
                    linha.Cells[Textos.Tabela.SELECAO_2].Value = false;
                }
                else
                {
                    caixas_Selecionadas.Add(item);
                    linha.Cells[Textos.Tabela.SELECAO_2].Value = true;
                }

                Txt_Cont_Selecao.Text = caixas_Selecionadas.Count == 0 ? Textos.VAZIO : Textos.Tabela.SELECAO + "s: " + caixas_Selecionadas.Count.ToString();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Duplo click na Tabela Caixas Alteradas
        /// </summary>
        /// <param name="indice">Posição do item clicado</param>
        private void CelulaDoubleClick(int indice)
        {
            if (IsAtualizando || indice < 0) return;

            try
            {
                dataTable.Rows.Clear();
                var rowClicked = Tabela_Alterada.Rows[indice];
                var itemID = rowClicked.Cells[Textos.Tabela.ID].Value.ToString();
                currentCaixa = GetCaixasAlteraradas.Get(itemID);

                Listar();
                Tabela.Visible = true;
                btn_voltar.Visible = true;
                cachePesquisa = Tb_Pesquisa.Text;
                Tb_Pesquisa.Text = "";
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Duplo click na Tabela Caixas
        /// </summary>
        /// <param name="indice">Posição do item clicado</param>
        private void CelulaDoubleClick_2(int indice)
        {
            if (IsAtualizando || indice < 0) return;

            try
            {
                var rowClicked = Tabela.Rows[indice];
                var itemID = rowClicked.Cells[Textos.Tabela.ID_2].Value.ToString();
                var item = Caixa.NewItem(GetItemsNoFiltro().Find(x => x.id.Equals(itemID)));

                if (item == null) return;

                // Cada caixa de Caixa_Alterada recebe um novo ID, está linha abaixo atribui o ID original
                // ao item (necessário em caso de restauração do item)
                item.id = currentCaixa.id;
                Popup_Caixa popup = new Popup_Caixa(item, telaID);
                popup.ShowDialog();

                if (popup.result == Const.CONSULTA_DB_SUCESS)
                    Import.Alert(txt_Log, "Caixa restaurada");
                else
                    Import.Alert(txt_Log, "Erro ao restaurar caixa. Tente novamente", true);
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        //===============
        private void On_Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (e.Action == DataRowAction.Delete)
                    TabelaLayout.InvokeRemoveLinha(Tabela_Alterada, indiceItemExcluido);
                else if (e.Action == DataRowAction.Add)
                    TabelaLayout.InvokeAddLinha(Tabela_Alterada, e);
                else if (e.Action == DataRowAction.Change)
                    TabelaLayout.InvokeAlterarLinha(Tabela_Alterada, e.Row.Table.Rows.IndexOf(e.Row), e);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void On_Row_Changed_2(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (e.Action == DataRowAction.Delete)
                    TabelaLayout.InvokeRemoveLinha(Tabela, indiceItemExcluido);
                else if (e.Action == DataRowAction.Add)
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
            TabelaLayout.InvokeClear(Tabela_Alterada);
        }
        
        private void On_Table_Cleared_2(object sender, DataTableClearEventArgs e)
        {
            TabelaLayout.InvokeClear(Tabela);
        }
        
        #endregion

        #endregion

        #region Métodos

        private void Init()
        {
            CarregarTema();

            try
            {
                btn_ant.Enabled = false;
                btn_prox.Enabled = false;
                DT_Fim.Value = DateTime.Now;

                Listar();
                FirebaseObservable = GetFirebaseOrservable();
                Import.Alert(txt_Log, "Duplo click para mais detalhes");
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
                TabelaLayout.SetTema(Tabela_Alterada);
                TabelaLayout.SetTema(Tabela);

                #region BackColor

                Barra_menu_top.BackColor = TemaConfig.ColorPrimary;
                Barra_inferior.BackColor = TemaConfig.ColorPrimary;

                //filtro.BackColor = TemaConfig.ColorPrimaryDark(tema);

                #endregion

                #region ForeColor

                Barra_menu_top.ForeColor = TemaConfig.TextColorPrimary;
                Barra_inferior.ForeColor = TemaConfig.TextColorPrimary;

                //filtro.ForeColor = TemaConfig.TextColorPrimary(tema);

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
                if (currentCaixa == null)
                    Listar_Caixas_Alteradas();
                else
                    Listar_Caixas();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Listar_Caixas()
        {
            try
            {
                var items = Tb_Pesquisa.Text.Trim().Length == 0 ? GetItemsNoFiltro() : caixas_Busca;

                dataTable.Rows.Clear();
                Listar_Comum_1(items.Count);
                for (int i = inicio; i < fim; i++)
                    AddLinhaTabela(i + 1, items[i]);
                Listar_Comum_2(items.Count);

            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Listar_Caixas_Alteradas()
        {
            try
            {
                var items = Tb_Pesquisa.Text.Trim().Length == 0 ? GetItemsNoFiltro_Alteradas() : caixas_Alteradas_Busca;
                if (items == null)
                    return;

                dataTable_Alteradas.Rows.Clear();
                Listar_Comum_1(items.Count);
                for (int i = inicio; i < fim; i++)
                    AddLinhaTabela(i + 1, items[i]);
                Listar_Comum_2(items.Count);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Timer pra mostrar uma barra de progresso ao atualizar os dados
        /// </summary>
        /// <returns></returns>
        Timer NewTimerOnUpdate(bool mostrarProgressBar = false)
        {
            progressBarUpdate.Visible = mostrarProgressBar;

            Timer timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += (s, e) => {
                if (progressBarUpdate.Value < 91)
                    progressBarUpdate.Value += 10;
                if (progressBarUpdate.Value == 100)
                    progressBarUpdate.Value = 0;
            };
            timer.Disposed += (s, e) =>
            {
                progressBarUpdate.Visible = false;
            };
            return timer;
        }

        /// <summary>
        /// Métodos que realizam atividades comuns nos 2 métodos de Listar.
        /// Atualiza o Layout (Botões Anterior e Proximo)
        /// </summary>
        private void Listar_Comum_1(int quant)
        {
            try
            {
                if (inicio < 0)
                {
                    inicio = 0;
                    TabelaLayout.InvokeButtonVisible(btn_ant, false);
                }
                // Fica tipo -> condição ? se for true : se for false
                fim = (inicio + quant_item_por_pagina > quant) ? quant : (inicio + quant_item_por_pagina);
                TabelaLayout.InvokeButtonVisible(btn_prox, fim < quant);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Métodos que realizam atividades comuns nos 2 métodos de Listar.
        /// Atualiza o Layout (número de páginas)
        /// </summary>
        private void Listar_Comum_2(int quant)
        {
            try
            {
                pagina_indice_max = quant / quant_item_por_pagina + 1;
                string paginacao = pagina_indice_atual + "/" + pagina_indice_max;
                TabelaLayout.InvokePaginacao(txt_pg, paginacao);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        /// <summary>
        /// Adiciona o item no indice especificado na Tabela CaixasAlteradas
        /// </summary>
        /// <param name="indice">Posição onde o item será adicionado</param>
        private void AddLinhaTabela(int indice, Caixa_Alterada item)
        {
            try
            {
                bool caixa_Selecionada = caixas_Alteradas_Selecionadas.Contains(item);// GetCaixasAlteraradas.VerifyListContemItem(item, caixas_Alteradas_Selecionadas);
                dataTable_Alteradas.Rows.Add(TabelaLayout.GetNewLinha(indice, item, caixa_Selecionada));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Adiciona o item no indice especificado da Tabela Caixa
        /// </summary>
        /// <param name="indice">Posição onde o item será adicionado</param>
        private void AddLinhaTabela(int indice, Caixa item)
        {
            try
            {
                bool caixa_Selecionada = caixas_Selecionadas.Contains(item);// GetCaixas.VerifyListContemItem(item, caixas_Selecionadas);
                dataTable.Rows.Add(TabelaLayout.GetNewLinha(indice, item, Name, caixa_Selecionada));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private IDisposable GetFirebaseOrservable()
        {
            try
            {
                return GetFirebase.GetClient
                     .Child(GetFirebase.Child.CAIXAS_ALTERADAS)
                     .AsObservable<Caixa_Alterada>()
                     .Subscribe(obj => AtualizarListaDeCaixas(obj.Object, obj.Key));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return null;
            }
        }
        
        private void AtualizarListaDeCaixas(Caixa_Alterada item, string key)
        {
            if (item == null) return;

            try
            {
                item.id = key;

                item = Caixa_Alterada.NewItem(item);
                if (item.caixas.Count == 0)
                {
                    Log.Msg(TAG, "AtualizarListaDeCaixas", "Excluida", item.id);
                    GetCaixasAlteraradas.Remove(item);
                    return;
                }

                try
                {
                    var itemAux = GetCaixasAlteraradas.Get(item.id);
                    item.isEditado = false;

                    // Se estiver na lista só quero sobrescrever se a data de alteração desta caixa for mais recente
                    if (itemAux != null)
                        item.isEditado = (DateTime.Parse(item.data) > DateTime.Parse(itemAux.data));
                    item.isNovo = (itemAux == null || item.isEditado);

                    item.Preparar();
                    if (item.isNovo)
                        GetCaixasAlteraradas.Add(item);
                }
                catch (Exception ex)
                {
                    Log.Erro(TAG, ex);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Usado pra fazer pesquisas
        /// </summary>
        private List<Caixa_Alterada> FindCaixas_Alteradas(string busca)
        {
            List<Caixa_Alterada> items = new List<Caixa_Alterada>();
            try
            {
                foreach (Caixa_Alterada item in GetCaixasAlteraradas.data)
                    if (item.nome.Contains(busca))
                    {
                        if (!items.Contains(item))
                            items.Add(item);
                    }
                    else
                        foreach (Caixa item2 in item.caixas)
                            if (item2.usuario.nome.Contains(busca))
                                if (!items.Contains(item))
                                    items.Add(item);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }

        /// <summary>
        /// Usado pra fazer pesquisas
        /// </summary>
        private List<Caixa> FindCaixas(string busca)
        {
            List<Caixa> items = new List<Caixa>();
            try
            {
                foreach (var item in currentCaixa.caixas)
                    if (item.usuario.nome.Contains(busca))
                        if (!items.Contains(item))
                            items.Add(item);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }

        /// <summary>
        /// Retorna uma lista com os items dentro do filtro especificado.
        /// TempoInicio | TempoFim
        /// </summary>
        private List<Caixa_Alterada> GetItemsNoFiltro_Alteradas()
        {
            List<Caixa_Alterada> items = new List<Caixa_Alterada>();

            try
            {
                foreach (var item in GetCaixasAlteraradas.data)
                {
                    DateTime dateTime = DateTime.Parse(item.data);
                    if (dateTime.Date >= DT_Inicio.Value.Date && dateTime.Date <= DT_Fim.Value.Date)
                        items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }
        
        private List<Caixa> GetItemsNoFiltro()
        {
            List<Caixa> items = new List<Caixa>();

            try
            {
                foreach (var item in currentCaixa.caixas)
                {
                    DateTime dateTime = DateTime.Parse(item.data);
                    if (dateTime.Date >= DT_Inicio.Value.Date && dateTime.Date <= DT_Fim.Value.Date)
                        items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }

        /// <summary>
        /// Mostra um texto de Log na tela pro usuário
        /// </summary>
        /// <param name="texto"> Texto a ser exibido</param>
        private void Alert(string texto = "", bool mostrar = true)
        {
            txt_Log.Text = texto;
            txt_Log.Visible = mostrar;
        }

        /// <summary>
        /// Cria todas as colunas necessárias da tabela e adiciona os eventos
        /// </summary>
        private void CriarTabela_Caixas_Alteradas(DataTable table)
        {
            try
            {
                DataColumn[] c = { TabelaLayout.GetNewColuna(Textos.Tabela.ID) };
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.SELECAO, Type.GetType("System.Boolean")));
                table.Columns.Add(TabelaLayout.GetNewColuna("*", Type.GetType("System.Int32")));
                table.Columns.Add(c[0]);
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.NOME));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.CONT));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.DATA));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.FUNCIONARIO));
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

        /// <summary>
        /// Cria todas as colunas necessárias da tabela e adiciona os eventos
        /// </summary>
        private void CriarTabela_Caixas(DataTable table)
        {
            try
            {
                DataColumn[] c = { TabelaLayout.GetNewColuna(Textos.Tabela.ID_2) };
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.SELECAO_2, Type.GetType("System.Boolean")));
                table.Columns.Add(TabelaLayout.GetNewColuna("*", Type.GetType("System.Int32")));
                table.Columns.Add(c[0]);
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.NOME));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.STATUS));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.PORTA));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.PORTA_DISP));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.DATA));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.FUNCIONARIO));
                table.PrimaryKey = c;

                table.TableCleared += new DataTableClearEventHandler(On_Table_Cleared_2);
                table.RowChanged += new DataRowChangeEventHandler(On_Row_Changed_2);
                table.RowDeleted += new DataRowChangeEventHandler(On_Row_Changed_2);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

    }
}