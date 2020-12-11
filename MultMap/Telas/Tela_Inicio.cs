using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Modelo;
using MultMap.Data;
using System.IO;

namespace MultMap.Telas
{
    public partial class Tela_Inicio : Form
    {
        #region Variáveis

        private static string TAG = "Tela_Inicio";

        #region Listas de Itens para as janelas
        private List<Button> buttons = new List<Button>();
        private List<Popup_Lembrete> lembretesPopup = new List<Popup_Lembrete>();
        private Lembrete lembrete_AlarmeAtual;
        private Form[] forms;
        private bool[] tela_Aberta;
        #endregion

        // Animação abrir e fechar menu
        private readonly int menuAberto;
        private readonly int menuFechado = 70;

        #region Indice de cada Janela
        private int indice_user_add;
        public int indice_relatorio_caixas;
        public int indice_historico_alteracao;
        public int indice_historico_exclusao;
        private int indice_mapa;
        //private int indice_chat;
        private int indice_navegador;
        private int indice_lembrete;
        private int indice_email;
        #endregion

        #region Todas as Telas
        private Tela_User tela_User_Add;

        private Tela_Relatorio_Caixas tela_Relatorio_Caixas;

        private Tela_Historico_Alteracao tela_Historico_Alteracao;
        private Tela_Historico_Exclusao tela_Historico_Exclusao;

        private Tela_Ferramentas_Map tela_Mapa;
        //private Tela_Ferramentas_Chat tela_Chat;
        private Tela_Ferramentas_Navegador tela_Navegador;

        private Tela_Ferramentas_Lembrete tela_Lembrete;
        private Tela_Ferramentas_Email tela_Email;
        #endregion

        private Tela_Login tela_Login = new Tela_Login();
        private static int tamanho_painelTelas;
        private bool isIniciado;

        #endregion

        public Tela_Inicio()
        {
            InitializeComponent();
            menuAberto = Painel_Lateral.Width;

            GetLembretes.OnAdd += OnAddLembrete;
            GetLembretes.OnRemove += OnRemoveLembrete;

            this.FormClosing += (sender, e) =>
            {
                GetLembretes.OnAdd -= OnAddLembrete;
                GetLembretes.OnRemove -= OnRemoveLembrete;
            };

            Init();
        }

        #region Eventos

        private void OnAddLembrete(Lembrete item)
        {
            if (item.isFixado)
                AddNote(item);
            else
                RemoveNote(item);
        }

        private void OnRemoveLembrete(Lembrete item)
        {
            RemoveNote(item);
        }

        #region  2 Botões (Minimizar, e Fechar)

        private void Btn_close_app_Click(object sender, EventArgs e)
        {
            try
            {
                // Fecha todas as janelas abertas
                foreach (var f in forms)
                    if (f != null)
                        if (painel_telas.Controls.Contains(f))
                        {
                            painel_telas.Controls.Remove(f);
                            f.Close();
                            f.Dispose();
                        }
                Hide();
                GetFirebase.usuario.isOnline = false;
                GetFirebase.usuario.Salvar();

                Application.Exit();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region  Menu Superior

        private void Btn_menu_lateral_Click(object sender, EventArgs e)
        {
            try
            {
                var bw = new BackgroundWorker();
                bw.RunWorkerCompleted += (o, args) => Animacao();
                bw.RunWorkerAsync();
                bw.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Animacao()
        {
            try
            {
                Timer t = new Timer();
                t.Interval = 1;
                t.Tick += new EventHandler(Animacao_Tick);
                t.Start();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Animacao_Tick(object sender, EventArgs e)
        {
            try
            {
                var t = sender as Timer;

                if (Painel_Lateral.Width >= menuAberto)// fechar
                    while (Painel_Lateral.Width > menuFechado)
                    {
                        Painel_Lateral.Width -= t.Interval;
                        menu_lateral.Width -= t.Interval;
                    }
                else// abrir
                {
                    Painel_Lateral.Width = menuAberto;
                    menu_lateral.Visible = false;
                    menu_lateral.Width = menuAberto - 10;
                    menu_lateral.Visible = true;
                }
                t.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private async void Btn_PararAlarme_Click(object sender, EventArgs e)
        {
            try
            {
                MediaPlayer.Ctlcontrols.stop();
                btn_PararAlarme.Visible = false;
                if (lembrete_AlarmeAtual != null)
                {
                    await lembrete_AlarmeAtual.Salvar();
                    Log.Msg(TAG, "Entroi aqui");
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region 4 Botões principais do menu lateral

        private void Btn_user_add_Click(object sender, EventArgs e)
        {
            try
            {
                int i = indice_user_add;
                if (forms[i] == null)
                {
                    tela_User_Add = new Tela_User()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        StartPosition = FormStartPosition.CenterScreen
                    };

                    painel_telas.Controls.Add(tela_User_Add);
                    tela_User_Add.Show();
                }

                Sincronizar_Form_Com_Button(i, tela_User_Add, btn_menu_top_user_add);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_relatorio_caixas_Click(object sender, EventArgs e)
        {
            try
            {
                int i = indice_relatorio_caixas;
                if (forms[i] == null)
                {
                    tela_Relatorio_Caixas = new Tela_Relatorio_Caixas(i)
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    painel_telas.Controls.Add(tela_Relatorio_Caixas);
                    tela_Relatorio_Caixas.Show();
                }
                Sincronizar_Form_Com_Button(i, tela_Relatorio_Caixas, btn_menu_top_relatorio_caixas);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_historicos_Click(object sender, EventArgs e)
        {
            try
            {
                btn_historico_exclusao.Visible = btn_historicos.Selecionado;
                btn_historico_alteracao.Visible = btn_historicos.Selecionado;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_ferramentas_Click(object sender, EventArgs e)
        {
            try
            {
                btn_ferramenta_mapa.Visible = btn_ferramentas.Selecionado;
                //btn_ferramenta_chat.Visible = btn_ferramentas.Selecionado;
                btn_ferramenta_lembretes.Visible = btn_ferramentas.Selecionado;
                btn_ferramenta_navegador.Visible = btn_ferramentas.Selecionado;
                Btn_ferramenta_Email.Visible = btn_ferramentas.Selecionado;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region 2 Botões do menu Histórico

        private void Btn_historico_alteracao_Click(object sender, EventArgs e)
        {
            try
            {
                int i = indice_historico_alteracao;
                if (forms[i] == null)
                {
                    tela_Historico_Alteracao = new Tela_Historico_Alteracao(i)
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                    };
                    painel_telas.Controls.Add(tela_Historico_Alteracao);
                    tela_Historico_Alteracao.Show();
                }

                Sincronizar_Form_Com_Button(i, tela_Historico_Alteracao, btn_menu_top_alteracao);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_historico_exclusao_Click(object sender, EventArgs e)
        {
            try
            {
                int i = indice_historico_exclusao;
                if (forms[i] == null)
                {
                    tela_Historico_Exclusao = new Tela_Historico_Exclusao(i)
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                    };
                    painel_telas.Controls.Add(tela_Historico_Exclusao);
                    tela_Historico_Exclusao.Show();
                }

                Sincronizar_Form_Com_Button(i, tela_Historico_Exclusao, btn_menu_top_exclusao);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region 5 Botões do menu Ferramentas

        private void Btn_ferramenta_lembretes_Click(object sender, EventArgs e)
        {
            try
                {
                int i = indice_lembrete;
                if (forms[i] == null)
                {
                    tela_Lembrete = new Tela_Ferramentas_Lembrete()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                    };
                    painel_telas.Controls.Add(tela_Lembrete);
                    tela_Lembrete.Show();
                }

                Sincronizar_Form_Com_Button(i, tela_Lembrete, btn_menu_top_lembretes);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_ferramenta_chat_Click(object sender, EventArgs e)
        {
            /*try
                {
                int i = indice_chat;
                if (forms[i] == null)
                {
                    tela_Chat = new Tela_Ferramentas_Chat()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    painel_telas.Controls.Add(tela_Chat);
                    tela_Chat.Show();
                }

                Sincronizar_Form_Com_Button(i, tela_Chat, btn_menu_top_chat);
            }
            catch (Exception ex)
            {
                Log(TAG, "Btn_ferramenta_chat_Click", ex.Message);
            }*/
        }
        
        private void Btn_ferramenta_navegador_Click(object sender, EventArgs e)
        {
            try
            {
                int i = indice_navegador;
                if (forms[i] == null)
                {
                    tela_Navegador = new Tela_Ferramentas_Navegador()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    painel_telas.Controls.Add(tela_Navegador);
                    tela_Navegador.Show();
                }

                Sincronizar_Form_Com_Button(i, tela_Navegador, btn_menu_top_navegador);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_ferramenta_mapa_Click(object sender, EventArgs e)
        {
            AbrirMapa();
        }
        
        private void Btn_ferramenta_Email_Click(object sender, EventArgs e)
        {
            try
            {
                int i = indice_email;
                if (forms[i] == null)
                {
                    tela_Email = new Tela_Ferramentas_Email()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    painel_telas.Controls.Add(tela_Email);
                    tela_Email.Show();
                }

                Sincronizar_Form_Com_Button(i, tela_Email, Btn_Menu_Top_Email);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region 2 Botões (Ajuda, Sobre)

        private void Btn_ajuda_Click(object sender, EventArgs e)
        {
            try
            {
                var popup = new Tela_Ajuda();
                popup.Show();
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Btn_sobre_Click(object sender, EventArgs e)
        {
            try
            {
                Popup_InfirmacoesDoSoftware popup = new Popup_InfirmacoesDoSoftware();
                popup.ShowDialog();
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                GetFirebase.usuario.isOnline = false;
                GetFirebase.usuario.Salvar();
                Hide();
                tela_Login.Show();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Cb_Tema_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Tema = Cb_Tema.Selecionado ? 1 : 0;
                TemaConfig.Tema = Cb_Tema.Selecionado ? 1 : 0;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Nesse método são tocados os alarmes programados pelo usuário
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (isIniciado)
                {
                    data_hora.Text = DateTime.Now.ToString();
                    // Metodo pra repetir se o usuário não clicar no botão DesligarAlarme
                    if (MediaPlayer.status.Equals("Parado") && btn_PararAlarme.Visible)
                        MediaPlayer.Ctlcontrols.play();

                    var lembrete = GetLembretes.data.Find(x => x.isAlarme);
                    if (lembrete != null)
                    {
                        // Quando o usuário fizer login, tem a possibilidade de o horario do alarme já ter passado
                        // usando o operador <= o alarme vai tocar na hora que o usuário fizer login
                        if (lembrete.dataAlarme <= DateTime.Now)
                        {
                            lembrete_AlarmeAtual = lembrete;
                            MediaPlayer.URL = Const.PATH_SOM_ALARME;
                            MediaPlayer.Ctlcontrols.play();
                            btn_PararAlarme.Visible = true;
                            lembrete.isAlarme = false;
                            lembrete.isFixado = true;
                            GetLembretes.Add(lembrete);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #region Ações relacionadas às telas

        private void Btn_Dock_Click(object sender, EventArgs e)
        {
            try
            {
                var b = sender as Button;
                string tagB = b.Text;
                var form = ((Button)sender).Tag as Form;

                if (form.Visible)
                {
                    if(tagB == "Frente")
                        form.Visible = false;
                    else
                    {
                        form.BringToFront();
                        form.Focus();
                    }
                }
                else
                {
                    form.Visible = true;
                    form.BringToFront();
                    form.Focus();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void FormMinimizando(object sender, EventArgs e)
        {
            try
            {
                var f = sender as Form;
                int indice = Convert.ToInt32(f.Tag.ToString());

                buttons[indice].BackColor = !f.Visible ? Color.GreenYellow : Color.Gainsboro;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void FormFechando(object sender, FormClosingEventArgs e)
        {
            try
            {
                var f = sender as Form;
                int indice = Convert.ToInt32(f.Tag.ToString());

                buttons[indice].Visible = false;
                buttons[indice].Click -= new EventHandler(Btn_Dock_Click);
                forms[indice] = null;
                painel_telas.Controls.Remove(f);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void FormFocusEnter(object sender, EventArgs e)
        {
            try
            {
                var f = sender as Form;
                int indice = Convert.ToInt32(f.Tag.ToString());

                buttons[indice].Text = "Frente";
                buttons[indice].BackColor =  Color.DodgerBlue;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        private void FormFocusLeave(object sender, EventArgs e)
        {
            try
            {
                var f = sender as Form;
                int indice = Convert.ToInt32(f.Tag.ToString());

                if(!buttons[indice].ContainsFocus)
                    buttons[indice].Text = "Atras";
                buttons[indice].BackColor = Color.Gainsboro;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #endregion

        #region Métodos

        private async void Init()
        {
            CriarPastaDeArquivos();
            try
            {
                Import.tela_Inicio = this;
                menu_lateral.Visible = false;

                #region progressBar

                progressBar.Visible = true;
                Timer timer = new Timer
                {
                    Interval = 2000
                };
                timer.Tick += (sender, e) => {
                    if (progressBar.Value < 91)
                        progressBar.Value += 10;
                    if (progressBar.Value == 100)
                        progressBar.Value = 0;
                };
                timer.Start();

                #endregion

                await GetFirebase.Init();

                txt_UsuarioLogado_Nome.Text = GetFirebase.usuario.nome;

                Preparar_Lista_de_Telas();

                tamanho_painelTelas = painel_telas.Width;

                isIniciado = true;
                progressBar.Visible = false;
                menu_lateral.Visible = true;
                btn_menu_lateral.Visible = true;

                timer.Dispose();

                ToolTip tip = new ToolTip();
                tip.SetToolTip(Cb_Tema, "Clique para mudar o Tema");
                tip.SetToolTip(btn_logout, "Fazer Logout");
                tip.Dispose();

                Cb_Tema.Selecionado = TemaConfig.Tema == 1;

                GetLembretes.AddAll(await Lembrete.BaixarLista(GetFirebase.usuario.id));
                //img_Foto_User.BackgroundImage = await Import.Get.Foto(GetFirebase.usuario.foto);
            }
            catch (Exception ex)
            {
                txt_UsuarioLogado_Nome.Text = ex.Message;
                Log.Erro(TAG, ex);
            }
        }

        private void CriarPastaDeArquivos()
        {
            try
            {
                if (!Directory.Exists("files"))
                    Directory.CreateDirectory("files");
                if (!File.Exists(Const.PATH_SOM_ALARME))
                    File.WriteAllBytes(Const.PATH_SOM_ALARME, Properties.Resources.Alarm_1);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void FixarLembretes()
        {
            try
            {
                foreach (Lembrete item in GetLembretes.data)
                    if (item.isFixado) AddNote(item);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Preparar_Lista_de_Telas()
        {
            try
            {
                buttons.Add(btn_menu_top_user_add);
                indice_user_add = buttons.Count - 1;

                buttons.Add(btn_menu_top_relatorio_caixas);
                indice_relatorio_caixas = buttons.Count - 1;

                buttons.Add(btn_menu_top_alteracao);
                indice_historico_alteracao = buttons.Count - 1;

                buttons.Add(btn_menu_top_exclusao);
                indice_historico_exclusao = buttons.Count - 1;

                buttons.Add(btn_menu_top_map);
                indice_mapa = buttons.Count - 1;

                //buttons.Add(btn_menu_top_chat);
                //indice_chat = buttons.Count - 1;

                buttons.Add(btn_menu_top_navegador);
                indice_navegador = buttons.Count - 1;

                buttons.Add(btn_menu_top_lembretes);
                indice_lembrete = buttons.Count - 1;

                buttons.Add(Btn_Menu_Top_Email);
                indice_email = buttons.Count - 1;

                tela_Aberta = new bool[buttons.Count];
                forms = new Form[buttons.Count];
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void AddNote(Lembrete item)
        {
            try
            {
                var popupAux = lembretesPopup.Find(x => x.popupID.Equals(item.id));
                if (popupAux == null)
                {
                    Log.Msg(TAG, "OnAddLembrete", item.titulo);
                    var popup = new Popup_Lembrete(item)
                    {
                        TopLevel = false,
                        Location = new Point(tamanho_painelTelas - 300, 0)
                    };

                    painel_telas.Controls.Add(popup);
                    popup.Show();
                    popup.BringToFront();
                    lembretesPopup.Add(popup);
                }
                else
                {
                    popupAux.Atualizar(item);
                    popupAux.BringToFront();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void RemoveNote(Lembrete item)
        {
            try
            {
                var popup = lembretesPopup.Find(x => x.popupID.Equals(item.id));
                if (popup == null) return;

                lembretesPopup.Remove(popup);
                painel_telas.Controls.Remove(popup);
                if (tela_Aberta[indice_lembrete])
                {
                    tela_Lembrete.AtualizarTabela(item);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Sincronizar_Form_Com_Button(int indice, Form form, Button btn_icon)
        {
            try
            {
                if (forms[indice] == null)
                {
                    forms[indice] = form;
                    forms[indice].BringToFront();
                    forms[indice].Tag = indice;

                    buttons[indice].Tag = forms[indice];
                    buttons[indice].Click += new EventHandler(Btn_Dock_Click);
                    forms[indice].FormClosing += new FormClosingEventHandler(FormFechando);
                    forms[indice].VisibleChanged += new EventHandler(FormMinimizando);
                    forms[indice].Enter += new EventHandler(FormFocusEnter);
                    forms[indice].Leave += new EventHandler(FormFocusLeave);
                }
                else
                {
                    forms[indice].Visible = true;
                    forms[indice].BringToFront();
                }

                btn_icon.BackColor = Color.Gainsboro;
                btn_icon.Visible = true;
                tela_Aberta[indice] = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        public void AbrirMapa(double lat = 0, double lng = 0)
        {
            try
            {
                int i = indice_mapa;
                if (forms[i] == null)
                {
                    tela_Mapa = new Tela_Ferramentas_Map(lat, lng)
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    painel_telas.Controls.Add(tela_Mapa);
                    tela_Mapa.Show();
                }
                else if (lat != 0 && lng != 0)
                    tela_Mapa.Pesquisar(lat, lng, true);

                Sincronizar_Form_Com_Button(i, tela_Mapa, btn_menu_top_map);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

    }
}
