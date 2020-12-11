using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json.Linq;
using MetroFramework.Controls;
using System.ComponentModel;
using MultMap.Auxiliar;
using MultMap.Modelo;
using MultMap.Data;
using MultMap.exemplos;
using MultMap.Telas.Exemplos;

namespace MultMap.Telas
{
    public partial class Tela_Ferramentas_Chat : Form
    {
        #region Variáveis

        private static string TAG = "Tela_Ferramentas_Chat";

        //=============================================== Meus dados
        private string id_UsuarioLogado = GetFirebase.usuario.id;
        //================================== Firebase
        // Variável que 'recebe notificação' quando tem alteração no banco de dados
        private IDisposable fb_Ref_Mensagens;
        private readonly FirebaseClient firebase = GetFirebase.GetClient;
        //===============================================
        private const string hint_tb = "  Digite aqui";
        private FlowLayoutPanel flow_Conversa;
        private Usuario CurrentUsuario;
        private List<Mensagem> mensagems = new List<Mensagem>();
        //===============================================
        #endregion

        public Tela_Ferramentas_Chat()
        {
            InitializeComponent();
            Inicializar();
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

        private void Btn_Enviar_MouseClick(object sender, MouseEventArgs e)
        {
            EnviarMensagem();
        }

        private void Cb_Enviar_Msg_Enter_OnChange(object sender, EventArgs e)
        {
            try
            {
                if (Cb_Enviar_Msg_Enter.Selecionado)
                    Import.Alert(Txt_Log, "Ctrl+Enter para quebra de linha");
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region TextBox

        private void Tb_mensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            On_KeyPress(e);
        }
        
        private void On_KeyPress(KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (Cb_Enviar_Msg_Enter.Selecionado)
                        EnviarMensagem();
                    else
                    {
                        tb_mensagem.Text += Environment.NewLine;
                        // Mover o cursor do textBox pro ultimo digito
                        // pq o visual studio não sabe fazer isso sozinho
                        {
                            tb_mensagem.Select(tb_mensagem.Text.Length, 0);
                            SendKeys.Send("{END}");
                        }
                    }
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        private void AbrirConversa(object sender, EventArgs e)
        {
            try
            {
                var b = sender as Contato;
                CurrentUsuario = ((Contato)sender).Tag as Usuario;

                mensagems.Clear();
                mensagems.AddRange(SQLite_Mensagem.GetAll(CurrentUsuario.id));
            
                panel_Conversa.Controls.Remove(flow_Conversa);
                flow_Conversa = GetNewFlowLayoutPanel();
                panel_Conversa.Controls.Add(flow_Conversa);

                Txt_Nome_Conversa.Text = CurrentUsuario.nome;
                Txt_Nome_Conversa.Visible = true;
                Img_Foto_Conversa.Visible = true;
                Img_Foto_Conversa.Image = b.Foto.Image;

                foreach (var m in mensagems)
                    AddMensagemNaLista(m);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Time_Verificar_Conversas_Tick(object sender, EventArgs e)
        {
            try
            {
                if (fb_Ref_Mensagens == null)
                    fb_Ref_Mensagens = GetRefMinhasConversas();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Flow_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                flow_Conversa.HorizontalScroll.Visible = false;
                flow_Conversa.HorizontalScroll.Enabled = false;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region Métodos

        private void Inicializar()
        {
            ListarUsuarios();
            try
            {
                fb_Ref_Mensagens = GetRefMinhasConversas();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void ListarUsuarios()
        {
            try
            {
                List<Contato> botoes = new List<Contato>();
                //int letrasLenght = btn_Exemplo.Text.Length;
                foreach(var u in GetUsuarios.data)
            {
                if (u.id != GetFirebase.usuario.id)
                {
                    Contato botao = new Contato();//Max Length 17 letras
                    botao.Name = u.id;
                    botao.Nome.Text = u.nome;
                    botao.Tag = u;

                    var bw = new BackgroundWorker();
                    bw.RunWorkerCompleted += (o, args) => SetarFoto(botao, u);
                    bw.RunWorkerAsync();
                    bw.Dispose();

                    botao.Click += new EventHandler(AbrirConversa);
                    botoes.Add(botao);
                    fl_Contatos.Controls.Add(botao);
                }
            }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        // Aqui coloca a foto do usuário no botão
        private async void SetarFoto(Contato b, Usuario u)
        {
            try
            {
                b.Foto.Image = await Import.Get.Foto(u.foto);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void EnviarMensagem()
        {
            RemoverEspacoNull(tb_mensagem);

            try
            {
                string texto = tb_mensagem.Text;
                if (texto.Trim().Length == 0 || CurrentUsuario == null)
                    return;
                tb_mensagem.Text = "";

                Mensagem m = new Mensagem();
                m.Setid_conversa(CurrentUsuario.id);
                m.Setid_remetente(id_UsuarioLogado);
                m.Setmensagem(texto);
                m.Setdata_de_envio(Import.Get.DataHora);
                m.Setstatus(Const.CONVERSA_MSG_NAO_ENVIADA);
                Random random = new Random();
                int size = random.Next(10, 50);
                string id = Import.Get.RandomString(size);
                m.SetId(id);

                AddMensagemNaLista(m);
                SQLite_Mensagem.Criptografar(m);
                if (SQLite_Mensagem.Add(m))// salva no meu banco local
                {
                    m.Setid_conversa(id_UsuarioLogado);
                    if (CN_Mensagem.Add(m, CurrentUsuario.id))// salva no firebase
                    {
                        m.Setstatus(Const.CONVERSA_MSG_ENVIADA);
                        m.Setid_conversa(CurrentUsuario.id);
                        SQLite_Mensagem.Update(m);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private FlowLayoutPanel GetNewFlowLayoutPanel()
        {
            FlowLayoutPanel f = null;
            try
            {
                f = new FlowLayoutPanel
                {
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    Dock = DockStyle.Fill
                };
                f.SizeChanged += new EventHandler(Flow_SizeChanged);
                f.HorizontalScroll.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return f;
        }

        private void AddMensagemNaLista(Mensagem m)
        {
            try
            {
                if (m == null)
                    return;

                var layout = new Layout_Mensagem(m);
                Import.InvokeChatAddMsg(flow_Conversa, layout);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void RemoverEspacoNull(MetroTextBox tb)
        {
            try
            {
                //tb.Text = tb.Text.TrimEnd('\n');
                tb.Text = tb.Text.TrimStart('\n', '\t', ' ');
                //while (true)
                //{
                //    int i = tb.Lines.Length - 1;
                //    if (tb.Lines[i].Trim().Length == 0)
                //    {
                //        Import.ConsoleLog(TAG, "Removido", i.ToString());
                //    }
                //    else
                //        break;
                //}
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private IDisposable GetRefMinhasConversas()
        {
            try
            {
                return firebase
                 .Child(GetFirebase.Child.USUARIOS)
                 .Child(id_UsuarioLogado)
                 .Child(GetFirebase.Child.USUARIO_CONVERSA)
                 .AsObservable<JObject>()
                 .Subscribe(d => PegarMsg(d.Key));
            }catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return null;
            }
        }

        private async void PegarMsg(string key)
        {
            try
            {
                List<Mensagem> mensagems = await CN_Mensagem.GetAll(key);
                bool conversaAberta = CurrentUsuario.id.Equals(key);
                foreach (var m in mensagems)
                {
                    SQLite_Mensagem.Add(m);
                    CN_Mensagem.Remove(m);// remove do firebase
                    if (conversaAberta)
                    {
                        SQLite_Mensagem.Descriptografar(m);
                        AddMensagemNaLista(m);
                        Log.Msg(TAG, "PegarMsg 0", "Conversa aberta");
                    }
                }
                Log.Msg(TAG, "PegarMsg 1", key);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private Mensagem NewMensagem(Mensagem m)
        {
            Mensagem n = new Mensagem();
            try
            {
                n.Setarquivo(m.Getarquivo());
                n.Setdata_de_envio(m.Getdata_de_envio());
                n.SetId(m.GetId());
                n.Setid_conversa(m.Getid_conversa());
                n.Setid_remetente(m.Getid_remetente());
                n.Setmensagem(m.Getmensagem());
                n.Setstatus(m.Getstatus());
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return n;
        }

        #endregion
    }
}
