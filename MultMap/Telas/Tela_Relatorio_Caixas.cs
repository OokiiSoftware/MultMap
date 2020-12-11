using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Telas
{
    public partial class Tela_Relatorio_Caixas : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Relatorio_Caixas";
        private readonly int telaID;

        private int indiceItemExcluido;
        private bool IsAtualizando = false;
        private bool Tabela_Alterada_Localmente;

        private readonly List<Caixa> caixas_Busca = new List<Caixa>();
        private readonly List<Caixa> caixas_Editadas = new List<Caixa>();
        private readonly List<Caixa> caixas_Selecionadas = new List<Caixa>();

        // Elementos da tabela
        private readonly DataTable dataTable = new DataTable();

        // Elementos pro controle de paginação
        private static int quant_item_por_pagina = 25;
        private int inicio = 0;
        private int pagina_indice_atual = 1;
        private int fim = quant_item_por_pagina;
        private float pagina_indice_max;

        #endregion

        private static class Textos
        {
            #region Geral

            public static string VAZIO { get => ""; }

            public static string OK { get => "OK"; }
            public static string FILTRO { get => "Filtro"; }
            public static string AGUARDE { get => "Aguarde"; } 
            public static string ATUALIZAR { get => "Atualizar"; }
            public static string SALVAR { get => "Salvar Alterações"; }
            public static string CANCELADO { get => "Operação cancelada"; }
            public static string EXCLUIR { get => "Excluir item Selecionado"; }
            public static string IMPRIMIR { get => "Imprimir Relatório"; }
            public static string GRAFICO { get => "Relatório Gráfico"; }

            public static string AJUDA_PESQUISA { get => "Digite o nome da caixa,\n funcionário, endereço ou cliente"; }
            public static string AJUDA_SELECAO_ITENS { get => "Marcas/Desmarcar todos os itens mostrados na tabela"; }
            public static string AJUDA_VIABILIDADE { get => "Duplo click para verificar a viabilidade"; }

            public static string ITENS_SELECIONADOS_NENHUM { get => "Nenhum item selecionado"; }
            public static string ITENS_SELECIONADOS_MAIS_DE_UM { get => "Selecione apenas 1 (UMA) caixa para excluir"; }
            public static string CAIXA_EXCLUIR_ERRO { get => "Ocorreu um erro ao excluir esta caixa. Tente novamente"; }

            public static string CAIXA_EXCLUIR_OK { get => "Caixa excluida"; }

            public static string DADOS_SALVOS { get => "Dados Salvos"; }
            public static string DADOS_SALVOS_ERRO { get => "Não foi possível salvar esses dados"; }

            #endregion

            public static class Tabela
            {
                public static string ID { get => "id"; }
                public static string NOME { get => "Nome"; }
                public static string STATUS { get => "Status"; }
                public static string SELECAO { get => "Selecionado"; }
                public static string PORTA { get => "Portas"; }
                public static string PORTA_DISP { get => "Disponivel"; }

                public static string GEOLOC { get => "geolocalizacao"; }
                public static string BAIRRO { get => "Bairro"; }
                public static string RUA { get => "Rua"; }
            }

        }

        public Tela_Relatorio_Caixas(int telaID)
        {
            InitializeComponent();
            this.telaID = telaID;

            GetCaixas.OnAdd += OnAddCaixa;
            GetCaixas.OnRemove += OnRemoveCaixa;
            GetCaixas.OnAddAll += OnAddAllCaixas;

            CriarTabela(dataTable);

            Init();
        }

        #region Eventos

        private void Tela_Relatorio_Caixas_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                GetCaixas.OnAdd -= OnAddCaixa;
                GetCaixas.OnRemove -= OnRemoveCaixa;
                GetCaixas.OnAddAll -= OnAddAllCaixas;
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

        /// <summary>
        /// Adiciona ou substitui o item na tabela.
        /// </summary>
        private void OnAddCaixa(Caixa item)
        {
            try
            {
                // Só quero atualizar se a caixa tiver informações novas
                if (!item.isNovo) return;

                // Se estiver editada aqui atualiza somente a linha da caixa
                // Se for nova mas não for editada só adiciona na tabela se o número de itens na tabela for menor que o total de itens por página
                if (item.isEditado)
                {
                    DataRow dataRow = dataTable.Rows.Find(item.id);
                    if (dataRow != null)
                    {
                        int indice = dataTable.Rows.IndexOf(dataRow) + 1;
                        bool caixa_Selecionada = caixas_Selecionadas.Contains(item);
                        dataRow.ItemArray = TabelaLayout.GetNewLinha(indice, item, Name, caixa_Selecionada);
                    }
                }
                else if (dataTable.Rows.Count < quant_item_por_pagina)
                {
                    AddLinhaTabela(Tabela.Rows.Count + 1, item);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            SomarQuantPortasDisponiveis();
        }

        /// <summary>
        /// Remove o item da tabela.
        /// </summary>
        private void OnRemoveCaixa(Caixa item)
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

        /// <summary>
        /// Lista todos os items
        /// </summary>
        private void OnAddAllCaixas(List<Caixa> items)
        {
            Listar();
        }

        #region Botões

        private void Btn_Filtro_Click(object sender, EventArgs e)
        {
            OnFiltro();
        }

        //============== 5 Botões do menu Superior
        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            OnSalvar();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            OnAtualizar();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            OnExcluir();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            OnImprimir();
        }

        private void Btn_Relatorio_Click(object sender, EventArgs e)
        {
            OnRelatorio();
        }

        //============== 2 Botões da barra Inferior
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
        /// Salva todos os items modificados
        /// </summary>
        private async void OnSalvar()
        {
            if (caixas_Editadas.Count == 0)
                return;
            Alert(Textos.AGUARDE, mostrar: true);

            btn_salvar.Visible = false;
            IsAtualizando = true;
            Timer timer = NewTimerOnUpdate(mostrarProgressBar: true);
            timer.Start();

            try
            {
                Random random = new Random();
                foreach (Caixa item in caixas_Editadas)
                {
                    item.data =(Import.Get.DataHora);
                    if (!await item.Salvar())
                    {
                        Import.Alert(txt_Log, Textos.DADOS_SALVOS_ERRO, true);
                        break;
                    }
                    var caixa_Alterada = await Task.Run(() => Caixa_Alterada.Baixar(item.id));
                    var caixa_original = GetCaixas.Get(item.id);
                    if (caixa_Alterada == null)
                    {
                        caixa_Alterada = new Caixa_Alterada
                        {
                            id = item.id
                        };
                    }
                    item.data =(Import.Get.DataHora);
                    caixa_original.novo_id = (Import.Get.RandomString(random.Next(5, 20)));
                    caixa_original.data = (item.data);
                    caixa_Alterada.caixas.Add(caixa_original);

                    await caixa_Alterada.Salvar();

                    DataRow dataRow = dataTable.Rows.Find(item.id);
                    if (dataRow != null)
                    {
                        int indice = dataTable.Rows.IndexOf(dataRow) + 1;
                        bool caixa_Selecionada = caixas_Selecionadas.Contains(item);// GetCaixas.VerifyListContemItem(caixa_original, caixas_Selecionadas);
                        dataRow.ItemArray = TabelaLayout.GetNewLinha(indice, item, Name, caixa_Selecionada);
                    }
                    Log.Msg(TAG, "Salvar", "Caixa Salva", caixa_Alterada.id);
                }
                caixas_Editadas.Clear();
                caixas_Selecionadas.Clear();
                Txt_Cont_Selecao.Text = Textos.VAZIO;
                btn_imprimir.Visible = true;
                Btn_Relatorio.Visible = true;
                txt_Ajuda_Cancelar.Visible = false;

                Import.Alert(txt_Log, Textos.DADOS_SALVOS);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                Import.Alert(txt_Log, Textos.DADOS_SALVOS_ERRO, isErro: true);
            }
            timer.Dispose();
            btn_salvar.Visible = true;
            IsAtualizando = false;
            Alert(mostrar: false);
        }

        /// <summary>
        /// Exclui somente se a quantidade de caixas selecionadas for igual a 1
        /// </summary>
        private void OnExcluir()
        {
            try
            {
                var caixas_Excluir = TabelaLayout.GetCaixasSelecionadas(Tabela, GetItemsNoFiltro(), Textos.Tabela.ID, Textos.Tabela.SELECAO);
                if (caixas_Excluir.Count == 0)
                {
                    Import.Alert(txt_Log, Textos.ITENS_SELECIONADOS_NENHUM);
                    return;
                }
                else if (caixas_Excluir.Count > 1)
                {
                    Import.Alert(txt_Log, Textos.ITENS_SELECIONADOS_MAIS_DE_UM);
                    return;
                }
                var item = caixas_Excluir[0];
                if (item == null)
                    return;

                Popup_Delete_Caixa popup = new Popup_Delete_Caixa(item);
                popup.ShowDialog();
                if (popup.result == Const.CONSULTA_DB_FAIL)
                    Import.Alert(txt_Log, Textos.CAIXA_EXCLUIR_ERRO, isErro: true);
                else if (popup.result == Const.CONSULTA_DB_SUCESS)
                {
                    string itemID = item.id;
                    GetCaixas.Remove(item);// remove da lista
                    caixas_Editadas.Remove(caixas_Editadas.Find(x => x.id.Equals(itemID)));// Remove da lista de editadas, se estiver nela

                    txt_Ajuda_Cancelar.Visible = caixas_Editadas.Count != 0;
                    Import.Alert(txt_Log, Textos.CAIXA_EXCLUIR_OK);
                }
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Baixa a lista de caixas do database e atualiza a tabela.
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

                var items = await Caixa.BaixarLista();
                //dataTable.Clear();
                GetCaixas.AddAll(items);
                timer.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            SomarQuantPortasDisponiveis();
            //Listar();

            IsAtualizando = false;
            btn_atualizar.Visible = true;
            Alert(mostrar: false);
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

        private void OnImprimir()
        {
            try
            {
                var items = caixas_Selecionadas.Count == 0 ? GetCaixas.data : caixas_Selecionadas;
                GetRelatorio.CriarRelatorio(items, Name);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        private void OnRelatorio()
        {
            try
            {
                var items = caixas_Selecionadas.Count == 0 ? GetCaixas.data : caixas_Selecionadas;
                GetRelatorio.CriarRelatorio(items, Name, isGrafico: true);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void OnFiltro()
        {
            try
            {
                filtro.Visible = !filtro.Visible;
                Btn_Filtro.Text = filtro.Visible ? Textos.OK : Textos.FILTRO;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
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
                caixas_Busca.Clear();
                if (Tb_Pesquisa.Text.Trim().Length > 0)
                {
                    caixas_Busca.AddRange(FindCaixas(Tb_Pesquisa.Text));
                    Comum();
                }
                // O primeiroDigito serve pra não atualizar a lista antes de ser teclado o promeiro digito da pesquisa
                if (Tb_Pesquisa.Text.Length == 0 && primeiroDigito)
                {
                    Comum();
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

        private void Selecionatudo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var items = caixas_Busca.Count > 0 ? caixas_Busca : GetCaixas.data;
                TabelaLayout.MultiSelectCheckbox(Tabela, Cb_SelecionarTudo.Checked, Textos.Tabela.SELECAO, items, caixas_Selecionadas, Txt_Cont_Selecao);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region Tabela

        private void Tabela_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CelulaSingleClick(e.RowIndex);
        }

        private void Tabela_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CelulaDoubleClick(e.RowIndex);
        }

        private void Tabela_KeyPress(object sender, KeyPressEventArgs e)
        {
            TabelaOn_KeyPress(e);
        }

        private void TabelaOn_KeyPress(KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (caixas_Editadas.Count > 0 || caixas_Selecionadas.Count > 0)
                    {
                        Import.Alert(txt_Log, Textos.CANCELADO);
                        caixas_Editadas.Clear();
                        caixas_Selecionadas.Clear();
                        Txt_Cont_Selecao.Text = Textos.VAZIO;
                        txt_Ajuda_Cancelar.Visible = false;
                        Listar();
                    }
                    btn_imprimir.Visible = Btn_Relatorio.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void CelulaSingleClick(int indice)
        {
            if (IsAtualizando || indice < 0 || ModifierKeys != Keys.Control) return;

            try
            {
                var linha = Tabela.Rows[indice];
                var itemID = linha.Cells[Textos.Tabela.ID].Value.ToString();
                var item = GetItemsNoFiltro().Find(x => x.id.Equals(itemID));

                if (caixas_Selecionadas.Contains(item))
                {
                    caixas_Selecionadas.Remove(caixas_Selecionadas.Find(x => x.id.Equals(item.id)));
                    linha.Cells[Textos.Tabela.SELECAO].Value = false;
                }
                else
                {
                    caixas_Selecionadas.Add(item);
                    linha.Cells[Textos.Tabela.SELECAO].Value = true;
                }

                Txt_Cont_Selecao.Text = caixas_Selecionadas.Count == 0 ? Textos.VAZIO : Textos.Tabela.SELECAO + "s: " + caixas_Selecionadas.Count.ToString();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void CelulaDoubleClick(int indice)
        {
            if (IsAtualizando || indice < 0) return;

            try
            {
                caixas_Selecionadas.Clear();
                var caixaEditada = true;
                var rowClicked = Tabela.Rows[indice];

                // Verifica primeiro se essa caixa já foi editada
                var itemID = rowClicked.Cells[Textos.Tabela.ID].Value.ToString();
                var item = caixas_Editadas.Find(x => x.id.Equals(itemID));
                if (item == null)
                {
                    // Uso GetNewCaixa para não alterar o item da lista original
                    item = Caixa.NewItem(GetItemsNoFiltro().Find(x => x.id.Equals(itemID)));
                    caixaEditada = false;
                }

                var popup = new Popup_Caixa(item, telaID);
                popup.Btn_Restaurar.Visible = caixaEditada;

                switch (popup.ShowDialog())
                {
                    case DialogResult.OK:// Abrir Mapa
                        {
                            Import.tela_Inicio.AbrirMapa(item.latitude, item.longitude);
                            break;
                        }
                    case DialogResult.Yes:// Viabilidade
                    case DialogResult.No:// Cancelamento
                        {
                            Popup_Viabilidade popup_2 = new Popup_Viabilidade(item, popup.DialogResult);
                            int portasUsadasTemp = item.clientes.Count;
                            popup_2.ShowDialog();
                            if (popup_2.DialogResult == DialogResult.OK)
                            {
                                portasUsadasTemp -= item.clientes.Count;

                                if (portasUsadasTemp < 0)// Viabilidade
                                {
                                    Grafico g = new Grafico
                                    {
                                        data = Import.Get.Data,
                                        valor = Math.Abs(portasUsadasTemp)
                                    };
                                    item.AddViabilidade(g);
                                    item.hasViabilidade = true;
                                }
                                else if (portasUsadasTemp > 0)// Cancelamento
                                {
                                    Grafico g = new Grafico
                                    {
                                        data = Import.Get.Data,
                                        valor = portasUsadasTemp
                                    };
                                    item.AddCancelamento(g);
                                    item.hasCancelamento = true;
                                }

                                AddItemNaListaTemporaria(item);

                                txt_Ajuda_Cancelar.Visible = true;
                                Txt_Cont_Selecao.Visible = false;
                                btn_imprimir.Visible = Btn_Relatorio.Visible = false;
                            }
                            popup_2.Dispose();
                        }
                        break;
                    case DialogResult.Abort:// Restaurar dados 
                        {
                            caixas_Editadas.Remove(caixas_Editadas.Find(x => x.id.Equals(item.id)));
                            txt_Ajuda_Cancelar.Visible = caixas_Editadas.Count != 0;
                            btn_imprimir.Visible = caixas_Editadas.Count == 0;
                            Btn_Relatorio.Visible = caixas_Editadas.Count == 0;
                            Listar();
                        }
                        break;
                }
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        //====================================================
        private void On_Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (e.Action == DataRowAction.Delete)
                    TabelaLayout.InvokeRemoveLinha(Tabela, indice: indiceItemExcluido);
                else if (e.Action == DataRowAction.Add)
                    TabelaLayout.InvokeAddLinha(Tabela, e);
                else if (e.Action == DataRowAction.Change)
                {
                    int indice = e.Row.Table.Rows.IndexOf(e.Row);
                    TabelaLayout.InvokeAlterarLinha(Tabela, indice: indice, e);

                    var linha = Tabela.Rows.SharedRow(indice);
                    TabelaLayout.ColorirLinha(linha, cor: Tabela_Alterada_Localmente ? 1 : 2);
                    Tabela_Alterada_Localmente = false;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void On_Table_Cleared(object sender, DataTableClearEventArgs e)
        {
            TabelaLayout.InvokeClear(Tabela);
        }

        #endregion

        #endregion

        #region Métodos

        private void Init()
        {
            CarregarTema();
            RestringirAcesso();

            try
            {
                #region Tooltips

                ToolTip tip = new ToolTip();

                tip.SetToolTip(btn_atualizar, Textos.ATUALIZAR);
                tip.SetToolTip(btn_salvar, Textos.SALVAR);
                tip.SetToolTip(btn_excluir, Textos.EXCLUIR);
                tip.SetToolTip(btn_imprimir, Textos.IMPRIMIR);
                tip.SetToolTip(Btn_Relatorio, Textos.GRAFICO);
                tip.SetToolTip(Tb_Pesquisa, Textos.AJUDA_PESQUISA);
                tip.SetToolTip(Cb_SelecionarTudo, Textos.AJUDA_SELECAO_ITENS);
                tip.Dispose();

                #endregion

                quant_item_por_pagina = Convert.ToInt32(tb_Quant_Itens_Por_Pagina.Text);
                btn_ant.Enabled = false;
                btn_prox.Enabled = false;
                DT_Fim.Value = DateTime.Now;

                SomarQuantPortasDisponiveis();
                Listar();

                Import.Alert(txt_Log, Textos.AJUDA_VIABILIDADE);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);

            }
        }

        private void CarregarTema()
        {
            TabelaLayout.SetTema(Tabela);

            try
            {
                #region BackColor

                Barra_menu_top.BackColor = TemaConfig.ColorPrimary;
                Barra_inferior.BackColor = TemaConfig.ColorPrimary;

                filtro.BackColor = TemaConfig.ColorPrimaryDark;

                #endregion

                #region ForeColor

                Barra_menu_top.ForeColor = TemaConfig.TextColorPrimary;
                Barra_inferior.ForeColor = TemaConfig.TextColorPrimary;

                filtro.ForeColor = TemaConfig.TextColorPrimary;

                #endregion
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);

            }
        }

        /// <summary>
        /// Soma a quantidade de postas dispiníveis de todas as Caixas.
        /// Soma a quantidade de Clientes de todas as Caixas.
        /// </summary>
        private void SomarQuantPortasDisponiveis()
        {
            try
            {
                int disponivel = 0;
                int clientes = 0;

                foreach (var c in GetCaixas.data)
                {
                    disponivel += c.portas - c.clientes.Count;
                    clientes += c.clientes.Count;
                }

                Import.InvokeSomarQuantPortasDisponiveis(Tb_TotalCaixas, TB_TotalPortasDisponiveis, Tb_TotalClientes, GetCaixas.data.Count, disponivel, clientes);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);

            }
        }

        /// <summary>
        /// Restringe o acesso ao usuário de acordo com o seu PerfilDeAcesso
        /// </summary>
        private void RestringirAcesso()
        {
            try
            {
                btn_salvar.Visible = GetMeuPerfil.caixaAlterar;
                btn_excluir.Visible = GetMeuPerfil.caixaExcluir;
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
                Log.Msg(TAG, "Listar", "Listando");
                List<Caixa> items = Tb_Pesquisa.Text.Trim().Length == 0 ? GetItemsNoFiltro() : caixas_Busca;

                if (items == null) return;

                dataTable.Rows.Clear();

                if (inicio < 0)
                {
                    inicio = 0;
                    TabelaLayout.InvokeButtonVisible(btn_ant, false);
                }
                // Fica tipo -> condição ? se for true : se for false
                fim = inicio + quant_item_por_pagina > items.Count ? items.Count : inicio + quant_item_por_pagina;
                TabelaLayout.InvokeButtonVisible(btn_prox, fim < items.Count);

                for (int i = inicio; i < fim; i++)
                    AddLinhaTabela(i + 1, items[i]);
                
                pagina_indice_max = items.Count / quant_item_por_pagina + 1;
                string paginacao = pagina_indice_atual + "/" + pagina_indice_max;
                TabelaLayout.InvokePaginacao(txt_pg, paginacao);
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
        /// Adiciona o item no indice especificado
        /// </summary>
        /// <param name="indice">Posição onde o item será adicionado</param>
        private void AddLinhaTabela(int indice, Caixa item)
        {
            // se o usuário fechar a janela antes de chegar nesse método o app da erro por conta do método async que continua trabalhando
            // por esse motivo coloquei esse try
            try
            {
                if (item == null) return;

                bool caixa_Editada = false;

                // Se eu alterei um dado, ao listar novamente quero ver os dados ainda alterados
                // esse método faz isso sem modificar a lista de caixas original
                Caixa itemAux = caixas_Editadas.Find(x => x.id.Equals(item.id));
                if (itemAux == null)
                    itemAux = Caixa.NewItem(item);
                else
                    caixa_Editada = true;

                bool caixa_Selecionada = caixas_Selecionadas.Contains(item);// GetCaixas.VerifyListContemItem(itemAux, caixas_Selecionadas);
                dataTable.Rows.Add(TabelaLayout.GetNewLinha(indice, itemAux, Name, caixa_Selecionada));

                // Só pinta a linha com uma cor diferente
                if (caixa_Editada) TabelaLayout.ColorirLinha(Tabela.Rows[Tabela.Rows.Count - 1], 1);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Add Item na lista temporaria.
        /// </summary>
        private void AddItemNaListaTemporaria(Caixa item)
        {
            try
            {
                // Se já tiver este item na lista, sobrescreve o item, se não, adiciona
                Caixa itemAux = caixas_Editadas.Find(x => x.id.Equals(item.id));
                if (itemAux == null)
                    caixas_Editadas.Add(item);
                else
                    caixas_Editadas.Insert(caixas_Editadas.IndexOf(itemAux), item);

                DestacarLinhaTabela(item);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        /// <summary>
        ///  Destaca a linha do item na tabela com uma cor diferenciada.
        /// </summary>
        /// <param name="item"></param>
        private void DestacarLinhaTabela(Caixa item)
        {
            try
            {
                var linha = dataTable.Rows.Find(item.id);
                if (linha == null) return;

                int indice = dataTable.Rows.IndexOf(linha) + 1;
                Tabela_Alterada_Localmente = true;
                bool caixa_Selecionada = caixas_Selecionadas.Contains(item);// GetCaixas.VerifyListContemItem(item, caixas_Selecionadas);
                linha.ItemArray = TabelaLayout.GetNewLinha(indice, item, Name, caixa_Selecionada);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Usado pra fazer pesquisas
        /// </summary>
        private List<Caixa> FindCaixas(string busca)
        {
            List<Caixa> item_Encontrados = new List<Caixa>();
            try
            {
                foreach (var c in GetItemsNoFiltro())
                    if ((c.nome.Contains(busca) && filtro.Cb_NomeCaixa.Checked) ||
                        (c.endereco.estado.Contains(busca) && filtro.Cb_Estado.Checked) ||
                        (c.endereco.cidade.Contains(busca) && filtro.Cb_Cidade.Checked) ||
                        (c.endereco.bairro.Contains(busca) && filtro.Cb_Bairro.Checked) ||
                        (c.endereco.rua.Contains(busca) && filtro.Cb_Rua.Checked))
                    {
                        if (!item_Encontrados.Contains(c))
                            item_Encontrados.Add(c);
                    }
                    else
                        foreach (var cl in c.clientes)
                            if (cl.Contains(busca) && filtro.Cb_NomeCliente.Checked)
                                if (!item_Encontrados.Contains(c))
                                    item_Encontrados.Add(c);// só isso aqui
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return item_Encontrados;
        }

        /// <summary>
        /// Retorna uma lista com os items dentro do filtro especificado.
        /// TempoInicio | TempoFim
        /// </summary>
        private List<Caixa> GetItemsNoFiltro()
        {
            List<Caixa> item_Encontrados = new List<Caixa>();
            try
            {
                foreach (Caixa caixa in GetCaixas.data)
                {
                    DateTime dateTime = DateTime.Parse(caixa.data);
                    if (dateTime.Date >= DT_Inicio.Value.Date && dateTime.Date <= DT_Fim.Value.Date)
                        item_Encontrados.Add(caixa);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return item_Encontrados;
        }

        /// <summary>
        /// Retorna o perfil do usuário logado
        /// </summary>
        private PerfilDeAcesso GetMeuPerfil => GetFirebase.usuario.perfil;

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
        private void CriarTabela(DataTable table)
        {
            try
            {
                DataColumn[] c = { TabelaLayout.GetNewColuna(Textos.Tabela.ID) };
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.SELECAO, Type.GetType("System.Boolean")));
                table.Columns.Add(TabelaLayout.GetNewColuna("*", Type.GetType("System.Int32")));
                table.Columns.Add(c[0]);
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.NOME));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.STATUS));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.PORTA));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.PORTA_DISP));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.GEOLOC));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.BAIRRO));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.RUA));
                table.PrimaryKey = c;

                table.TableCleared += On_Table_Cleared;
                table.RowChanged += On_Row_Changed;
                table.RowDeleted += On_Row_Changed;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
    }

    #endregion
}