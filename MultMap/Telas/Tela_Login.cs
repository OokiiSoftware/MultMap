using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using Firebase.Database.Query;
using Firebase.Database;
using Firebase.Auth;
using Firebase.Storage;
using MultMap.Auxiliar;
using MultMap.Modelo;
using MultMap.Data;
using System.ComponentModel;

namespace MultMap.Telas
{
    partial class Tela_Login : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Login";
        private Timer Tempo;
        private int progressBarValor = 0;

        private static bool debugModeIniciado = false;

        #endregion

        public Tela_Login()
        {
            InitializeComponent();
            Init();
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

        #region Botões

        private void Btn_close_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
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

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            VerificarDados();
        }

        private void Img_Logo_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Btn_Sobre_Click(object sender, EventArgs e)
        {
            var popup = new Popup_InfirmacoesDoSoftware();
            popup.ShowDialog();
            popup.Dispose();
        }

        #endregion

        #region TextBox

        private void Tb_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (tb_senha.Text.Trim().Length == 0)
                        ProcessTabKey(true);
                    else if (btn_confirmar.Enabled)
                        Btn_confirmar_Click(sender, e);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Tb_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (btn_confirmar.Enabled)
                        Btn_confirmar_Click(sender, e);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Tb_UID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (GetFirebase.VerificarUID(Tb_UID.Text))
                {
                    if (MessageBox.Show(GetFirebase.GetCompanhiaNome,
                        "Está correto?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            string UID = Tb_UID.Text;
                            File.WriteAllText(Const.APP_ID_FILE, UID);
                            Tb_UID.Visible =
                            Bar_UID.Visible = false;
                            Init();
                        }
                        catch (Exception ex)
                        {
                            Alert("Ocorreu um erro. Tente fechar e abrir novamente", true, true);
                            Log.Erro(TAG, ex);
                        }
                    }
                }
                else
                    Alert("UID Inválido", true, true);
            }
        }

        private void Tb_UID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = true;
        }

        #endregion

        /// <summary>
        /// Cria uma animação na barra de progresso
        /// </summary>
        private void AnimarProgressBar(object sender, EventArgs e)
        {
            if (progressBarValor <= progressBar.Maximum)
               progressBar.Value = progressBarValor;
            progressBarValor++;
            if (progressBarValor == progressBar.Maximum + 7)
                progressBarValor = progressBar.Minimum;
        }

        #endregion

        #region Métodos

        private async void Init()
        {
            btn_confirmar.Enabled = false;

            Lbl_Versao.Text = GetApplication.AppVersaoString;

            try
            {
                Tempo = new Timer
                {
                    Interval = 100
                };
                Tempo.Tick += new EventHandler(AnimarProgressBar);

                Alert("Verificando Atualizações");

                var versao = await GetApplication.GetVersaoDoAppNoServidor();

                if (versao > GetApplication.AppVersao)
                {
                    GetApplication.DeleteTempFile(GetApplication.GetPathCompleto(GetApplication.AppVersao));
                    GetApplication.InstalarAtualizacao(versao);
                    var titulo = "Atualização obrigatória disponivel";
                    var msg = "Você deve atualizar o sistema para a versão mais recente";
                    var pergunta = "\nDeseja atualizar agora?";
                    var versaoAtual = "\nVersão Atual: " + GetApplication.AppVersaoString;
                    var versaoNova = "\nNova Versão: "+ GetApplication.ConvertParaString(versao);
                    var tudoJuntoEMisturado = msg + versaoAtual + versaoNova + pergunta;
                    if (MessageBox.Show(tudoJuntoEMisturado, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        Application.Exit();
                    else
                    {
                        progressBar.Visible = true;
                        Tempo.Start();
                    }
                    var result = await GetApplication.BaixarAtualizacao(versao);
                    Tempo.Stop();
                    progressBar.Visible = false;
                    if (result > 0)
                    {
                        txt_Log.Text = "Erro ID: " + result;
                        txt_Log.Visible = true;
                        txt_Log.ForeColor = TemaConfig.TextColorAlertErro;
                    }
                    return;
                }

                Alert(mostrar: false);
                Tempo.Dispose();
                btn_confirmar.Enabled = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            // Faz login automatico se o App tiver no Modo DEBUG
            if (GetApplication.IsDebugMode() && !debugModeIniciado)
            {
                debugModeIniciado = true;
                tb_usuario.Text = "admin";
                tb_senha.Text = "admin1234";
                VerificarDados();
            }
        }

        private void Alert(string texto = null, bool mostrar = true, bool erro = false)
        {
            try
            {
                txt_Log.Visible = mostrar;
                if(texto != null)
                    txt_Log.Text = texto;
                txt_Log.ForeColor = erro ? TemaConfig.TextColorAlertErro : TemaConfig.TextColorAlert;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private async void VerificarDados()
        {
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

            try
            {
                btn_confirmar.Enabled = false;
                Alert("Verificando credenciais");

                int result = await VerificarCredenciais(tb_usuario.Text, tb_senha.Text);
                if (result == 0)
                {
                    Import.Alert(txt_Log, "Entrando");
                    Tela_Inicio tela_Inicio = new Tela_Inicio();
                    tela_Inicio.Show();
                    Hide();
                }
                else
                {
                    switch (result)
                    {
                        case GetFirebase.CodError.COD_EMAIL_NAO_ENCONTRADO:
                            Import.Alert(txt_Log, "Usuário incorreto", true);
                            break;
                        case GetFirebase.CodError.COD_ERRO_DE_CONEXAO:
                            Import.Alert(txt_Log, "Erro na conexão", true);
                            break;
                        case GetFirebase.CodError.COD_SENHA_INCORRETA:
                            Import.Alert(txt_Log, "Senha incorreta", true);
                            break;
                        case GetFirebase.CodError.COD_PERMISSAO_NEGADA:
                            Import.Alert(txt_Log, GetFirebase.CodError.PERMISSAO_NEGADA, true);
                            break;
                        case 1:
                            Alert(mostrar: false);
                            break;
                        case 2:
                            Import.Alert(txt_Log, "Erro. Tente novamente", true);
                            break;
                    }
                    btn_confirmar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            progressBar.Visible = false;
            timer.Dispose();
        }

        private async Task<int> VerificarCredenciais(string login, string senha)
        {
            if (login.Trim().Length == 0 || senha.Trim().Length == 0)
                return 1;

            login += "@gmail.com";

            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(GetFirebase.GetApiKey));
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(login, senha);

                var firebase = new FirebaseClient(GetFirebase.GetDatabaseURL,
                  new FirebaseOptions { AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken) });

                GetFirebase.SetFirebaseClient(firebase);
                var user = auth.User;

                Usuario u = await Usuario.Baixar(user.LocalId);

                if (!u.perfil.multmap)
                    throw new Exception(GetFirebase.CodError.PERMISSAO_NEGADA);

                u.isOnline = true;
                u.data = Import.Get.DataHora;
                await u.Salvar();
                GetFirebase.usuario = u;
                authProvider.Dispose();

                return 0;
            }
            catch (FirebaseAuthException ex)
            {
                switch (ex.Reason.ToString())
                {
                    case GetFirebase.CodError.EMAIL_NAO_ENCONTRADO:
                        return GetFirebase.CodError.COD_EMAIL_NAO_ENCONTRADO;
                    case GetFirebase.CodError.ERRO_DE_CONEXAO:
                        return GetFirebase.CodError.COD_ERRO_DE_CONEXAO;
                    case GetFirebase.CodError.SENHA_INCORRETA:
                        return GetFirebase.CodError.COD_SENHA_INCORRETA;
                }

                Log.Erro(TAG, ex);
                //Log.Erro(TAG, "VerificarCredenciais 1", e.Reason.ToString());
                return 2;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals(GetFirebase.CodError.PERMISSAO_NEGADA))
                    return GetFirebase.CodError.COD_PERMISSAO_NEGADA;
                Log.Erro(TAG, ex);
                return 2;
            }
        }

        #endregion

    }
}
