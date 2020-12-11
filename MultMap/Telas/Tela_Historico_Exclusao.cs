using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Telas
{
    public partial class Tela_Historico_Exclusao : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Historico_Exclusao";
        private readonly int telaID;

        private int indiceItemExcluido;
        private bool IsAtualizando;

        private readonly List<Caixa> caixas_Busca = new List<Caixa>();
        private readonly List<Caixa> caixas_Selecionadas = new List<Caixa>();

        // Elementos da tabela
        private readonly DataTable dataTable = new DataTable();

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

            public static string CAIXA_RESTAURAR_ERRO { get => "Não foi possível restaurar esta caixa"; }
            public static string CAIXA_RESTAURAR_OK { get => "Caixa Restaurada"; }

            #endregion

            public static class Tabela
            {
                public static string ID { get => "id"; }
                public static string NOME { get => "Nome"; }
                public static string STATUS { get => "Status"; }
                public static string SELECAO { get => "Selecionado"; }
                public static string DATA { get => "Data"; }
                public static string FUNCIONARIO { get => "Funcionário"; }
                public static string MOTIVO { get => "Motivo"; }
            }

        }

        public Tela_Historico_Exclusao(int telaID)
        {
            InitializeComponent();
            this.telaID = telaID;

            GetCaixasExcluidas.OnAdd += OnAddCaixa;
            GetCaixasExcluidas.OnRemove += OnRemoveCaixa;

            CriarTabela(dataTable);
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

        private void Tela_Historico_Exclusao_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (FirebaseObservable != null)
                    FirebaseObservable.Dispose();

                GetCaixasExcluidas.OnAdd -= OnAddCaixa;
                GetCaixasExcluidas.OnRemove -= OnRemoveCaixa;

            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Adiciona ou substitui o item na tabela
        /// </summary>
        private void OnAddCaixa(Caixa item)
        {
            try
            {
                //Atualizar minha tabela
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
        }

        /// <summary>
        /// Remove o item da tabela
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

        #region Botões

        //============== 2 Botões do menu Superior
        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            OnAtualizar();
        }
        
        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            OnImprimir();
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
        /// Baixa a lista de caixas excluidas do database e atualiza a tabela.
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
                var items = await Caixa.BaixarLista(excluidas: true);
                dataTable.Clear();
                GetCaixasExcluidas.AddAll(items);
                timer.Dispose();
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
                var items = caixas_Selecionadas.Count == 0 ? GetCaixasExcluidas.data : caixas_Selecionadas;
                GetRelatorio.CriarRelatorio(items, Name);
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
                var items = caixas_Busca.Count > 0 ? caixas_Busca : GetCaixasExcluidas.data;
                TabelaLayout.MultiSelectCheckbox(Tabela, Cb_SelecionarTudo.Checked, Textos.Tabela.SELECAO, items, caixas_Selecionadas, Txt_Cont_Selecao);
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

        private void Tabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    caixas_Selecionadas.Remove(item);
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
                var rowClicked = Tabela.Rows[indice];
                var itemID = rowClicked.Cells[Textos.Tabela.ID].Value.ToString();
                var item = Caixa.NewItem(GetItemsNoFiltro().Find(x => x.id.Equals(itemID)));

                if (item == null) return;

                var popup = new Popup_Caixa(item, telaID);
                popup.ShowDialog();
                if (popup.result == Const.CONSULTA_DB_FAIL)
                    Import.Alert(txt_Log, Textos.CAIXA_RESTAURAR_ERRO, isErro: true);
                else if (popup.result == Const.CONSULTA_DB_SUCESS)
                {
                    GetCaixasExcluidas.Remove(item);
                    rowClicked = null;
                    Import.Alert(txt_Log, Textos.CAIXA_RESTAURAR_OK);
                }
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        //================
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
            TabelaLayout.SetTema(Tabela);

            try
            {
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

        /// <summary>
        /// Método responsável por Obsertar mudanças no database
        /// </summary>
        private IDisposable GetFirebaseOrservable()
        {
            try
            {
                return GetFirebase.GetClient
                     .Child(GetFirebase.Child.CAIXAS_EXCLUIDAS)
                     .AsObservable<Caixa>()
                     .Subscribe(obj => AtualizarListaDeCaixas(obj.Object, obj.Key));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return null;
            }
        }

        private void AtualizarListaDeCaixas(Caixa item, string key)
        {
            if (item == null) return;

            try
            {
                // Se não usar o 'GetNewCaixa' o VS fica sempre usando o objeto 'caixa' como se fosse uma variável global
                // Não sei o motivo...
                item.id = key;
                item = Caixa.NewItem(item);
                if (!item.isExcluido)
                {
                    Log.Msg(TAG, "AtualizarListaDeCaixas", "Restaurada", item.id);
                    GetCaixasExcluidas.Remove(item);
                    return;
                }

                var itemAux = GetCaixasExcluidas.Get(item.id);
                item.isEditado = false;

                // Se estiver na lista só quero sobrescrever se a data de alteração desta caixa for mais recente
                if (itemAux != null)
                    item.isEditado = (DateTime.Parse(item.data) > DateTime.Parse(itemAux.data));
                item.isNovo = (itemAux == null || item.isEditado);

                if (item.isNovo)
                {
                    item.Preparar();
                    GetCaixasExcluidas.Add(item);
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
        private List<Caixa> FindCaixas(string busca)
        {
            List<Caixa> item_Encontrados = new List<Caixa>();
            try
            {
                foreach (Caixa caixa in GetItemsNoFiltro())
                    if (caixa.nome.Contains(busca) || caixa.usuario.nome.Contains(busca))
                        item_Encontrados.Add(caixa);
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
                foreach (Caixa caixa in GetCaixasExcluidas.data)
                {
                    DateTime dateTime = DateTime.Parse(caixa.data);
                    if(dateTime.Date >= DT_Inicio.Value.Date && dateTime.Date <= DT_Fim.Value.Date)
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
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.DATA));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.FUNCIONARIO));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.MOTIVO));
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
