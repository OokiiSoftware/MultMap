using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using Firebase.Database;
using System.Collections.Generic;
using System.Threading;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.Text;
using System.Data;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using MultMap.Modelo.Relatorios;
using MultMap.Telas;
using MultMap.Modelo;
using MultMap.exemplos;
using MultMap.Data;
using System.Net.NetworkInformation;
using MultMap.Telas.Ferramentas;
using Firebase.Storage;
using System.Net.Sockets;
using System.Collections.ObjectModel;
using Firebase.Database.Query;

namespace MultMap.Auxiliar
{
    public static class Const
    {
        public const string RELATORIO_CAIXAS = "Relatório de Caixas";
        public const string RELATORIO_CAIXAS_ALTERADAS = "Relatório de Caixas Alteradas";
        public const string RELATORIO_CAIXAS_EXCLUIDAS = "Relatório de Caixas Excluidas";

        public const string SISTEMA_ATIVADO = "ativado";
        public const string EMAIL_COMPANY = "ookiisoftware@gmail.com";

        public const string NOME = "nome";
        public const string EMAIL = "email";
        public const string EMAIL_SENHA = "email_senha";
        public const string API_KEY = "api_key";
        public const string DATABASE = "databaseURL";
        public const string STORAGE = "storageURL";

        public const string SMTP_CLIENT = "smtp.gmail.com";

        public const int SQLITE_BANCO_DE_DADOS_VERSAO = 3;

        public const int CONVERSA_MSG_NAO_ENVIADA = 0;
        public const int CONVERSA_MSG_ENVIADA = 1;
        public const int CONVERSA_MSG_RECEBIDA = 1;
        public const int CONVERSA_MSG_LIDA = 2;

        public const int CONSULTA_DB_SUCESS = 22423;
        public const int CONSULTA_DB_FAIL = 2330;

        public const int FORM_ACAO_MINIMIZAR = 27653;
        public const int FORM_ACAO_FECHAR = 52456;

        public const int ATIVACAO_MAQUINA = 34432;
        public const int ATIVACAO_CERTIFICADO = 643;

        public static Brush BrushRelatorioTabelaText = new SolidBrush(Color.Orange);
        public static Brush BrushRelatorioTabelaHeaderFundo = new SolidBrush(Color.Yellow);
        public static Brush BrushRelatorioTabelaHeaderText = new SolidBrush(Color.Green);

        public static Brush BrushRelatorioHeaderText = new SolidBrush(Color.Blue);
        public static Brush BrushRelatorioText = new SolidBrush(Color.Bisque);

        #region Diretórios de arquivos

        public const string PATH_SOM_ALARME = "files/Alarm_1.mp3";
        public const string APP_ID_FILE = "files/app_id.multmap";

        #endregion

    }

    public static partial class Import
    {
        #region Variáveis

        private const string TAG = "Import";

        // Usado no método Alert (gerencia os alertas chamados nas telas)
        private static List<int> idAlert = new List<int>();
        public static Tela_Inicio tela_Inicio { get; set; }

        #endregion

        #region METODOS

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (int LeftRect, int TopRect, int RightRect, int BottonRect, int widthRect, int heightRect);

        public static void ArredondarBordas(Form f)
        {
            try
            {
                f.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, f.Width, f.Height, 10, 10));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Emile um Alerta por 5 segundos
        /// </summary>
        public static async void Alert(Label txt_Log, string texto, bool isErro = false)
        {
            try
            {
                idAlert.Add(idAlert.Count);
                txt_Log.ForeColor = isErro ? TemaConfig.TextColorAlertErro : TemaConfig.TextColorAlert;
                txt_Log.Text = texto;

                txt_Log.Visible = true;
                await Task.Delay(5000);
                if (idAlert.Count > 0)
                    idAlert.RemoveAt(0);
                if (idAlert.Count == 0)
                    txt_Log.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        /// <summary>
        /// Retorna o Horario da Internet
        /// </summary>
        private static DateTime DataTime()
        {
            const string ntpServer = "br.pool.ntp.org";
            var ntpData = new byte[48];
            ntpData[0] = 0x1B; //LeapIndicator = 0 (no warning), VersionNum = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.Connect(ipEndPoint);
            socket.Send(ntpData);
            socket.Receive(ntpData);
            socket.Close();

            ulong intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | (ulong)ntpData[43];
            ulong fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | (ulong)ntpData[47];

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
            var networkDateTime = (new DateTime(1900, 1, 1)).AddMilliseconds((long)milliseconds);

            return networkDateTime;
        }

        #region Métodos Invoke (Serve pra atualizar elementos gráficos dentro de um 'Thread' (processos em background))

        public static void InvokeSomarQuantPortasDisponiveis(CustonTextBox Tb_Total, CustonTextBox TB_Disponiveis, CustonTextBox Tb_Clientes, int caixasCount, int disponivel, int clientes)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    Tb_Total.Invoke(new Action(() => { Tb_Total.Text = caixasCount.ToString(); }));
                    TB_Disponiveis.Invoke(new Action(() => { TB_Disponiveis.Text = disponivel.ToString(); }));
                    Tb_Clientes.Invoke(new Action(() => { Tb_Clientes.Text = clientes.ToString(); }));
                }
                else
                {
                    Tb_Total.Text = caixasCount.ToString();
                    TB_Disponiveis.Text = disponivel.ToString();
                    Tb_Clientes.Text = clientes.ToString();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        public static void InvokeAtualizarDateTimePicker(DateTimePicker picker)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    picker.Invoke(new Action(() => { picker.Value = DateTime.Now; }));
                }
                else
                    picker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        public static void InvokeChatAddMsg(FlowLayoutPanel flow, Layout_Mensagem mensagemPainel)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    flow.Invoke(new Action(() => { InvokeChatAddMsgAux(flow, mensagemPainel); }));
                }
                else
                    InvokeChatAddMsgAux(flow, mensagemPainel);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        private static void InvokeChatAddMsgAux(FlowLayoutPanel flow, Layout_Mensagem mensagemPainel)
        {
            try
            {
                flow.Controls.Add(mensagemPainel);
                int y = flow.VerticalScroll.Value + flow.VerticalScroll.SmallChange * 10;
                flow.AutoScrollPosition = new Point(0, y);// Ao add nova msg rola o scroll pra baixo
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        /// <summary>
        /// Recebe um valor no format [yyyy-MM-dd HH:mm:ss] e retorna [HH:mm]
        /// </summary>
        public static string SplitData(string data)
        {   //2019-11-29 06:25:01
            string t = data.Substring(data.IndexOf(" "));// data = yyyy-MM-dd HH:mm:ss
            t = t.Substring(0, t.Length - 3);// t = HH:mm:ss
            return t;// t = HH:mm
        }

        #endregion

        public static class Get
        {
            public static string NomeEmpresa => GetFirebase.firebaseProjectData[Const.NOME];
            public static string EmailEmpresa => GetFirebase.firebaseProjectData[Const.EMAIL];
            public static string SenhaEmailEmpresa => GetFirebase.firebaseProjectData[Const.EMAIL_SENHA];
            public static string EnderecoMac()
            {
                var net = NetworkInterface.GetAllNetworkInterfaces();
                return net[1].GetPhysicalAddress().ToString();
            }

            /// <summary>
            /// "yyyy-MM-dd"
            /// </summary>
            public static string Data => DataTime().ToString("yyyy-MM-dd");
            /// <summary>
            /// yyyy-MM-dd HH:mm:ss
            /// </summary>
            public static string DataHora => DataTime().ToString("yyyy-MM-dd HH:mm:ss");
            /// <summary>
            /// dd/MM/yyyy HH:mm:ss
            /// </summary>
            public static string DataHoraRelatorio => DataTime().ToString("dd/MM/yyyy HH:mm:ss");

            public static string SmtpClient => Const.SMTP_CLIENT;

            public static async Task<Image> Foto(string url)
            {
                try
                {
                    WebClient w = new WebClient();
                    byte[] imageByte = await Task.Run(() => w.DownloadData(url));
                    MemoryStream stream = new MemoryStream(imageByte);
                    w.Dispose();
                    return Image.FromStream(stream);
                }
                catch
                {
                    var imageByte = Properties.Resources.ic_user;
                    var stream = new MemoryStream(imageByte);
                    return Image.FromStream(stream);
                }
            }

            /// <summary>
            /// Gera IDs aleatórios
            /// </summary>
            /// <param name="size">Númeno de caracteres</param>
            public static string RandomString(int size)
            {
                StringBuilder builder = new StringBuilder();
                try
                {
                    Random random = new Random();
                    char ch;
                    for (int i = 0; i < size; i++)
                    {
                        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                        builder.Append(ch);
                    }
                }
                catch (Exception ex)
                {
                    Log.Erro(TAG, ex);
                }
                return builder.ToString();
            }

        }

    }

    public static class GetApplication
    {
        private const string TAG = "GetApplication";

        private const string FileExt = ".exe";
        private static string FileName => AppName + "_Instalador_";
        private static string PathUpdateTemp => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Documents", AppName);

        public static string AppName => Assembly.GetExecutingAssembly().GetName().Name;
        public static float AppVersao => Convert.ToSingle(Assembly.GetExecutingAssembly().GetName().Version.ToString());
        public static string AppVersaoString => ConvertParaString(AppVersao);

        /// <summary>
        /// Retorna TRUE se o app tiver no Modo DEBUG
        /// </summary>
        public static bool IsDebugMode()
        {
            #if DEBUG
                return true;
            #else
                return false;
            #endif
        }

        public static string ConvertParaString(float value)
        {
            var s = value.ToString().Replace(',', '.');
            var e = "";
            for (int i = 0; i < s.Length; i++)
            {
                e += s[i];
                if (i < s.Length - 1)
                    e += ".";
            }

            return e;
        }


        public static async Task<float> GetVersaoDoAppNoServidor()
        {
            var list = await GetFirebase.GetServer
                .Child(GetFirebase.Child.APPS)
                .Child(AppName)
                .Child(GetFirebase.Child.VERSAO)
                .OnceAsync<float>();
            var versoes = new List<float>();
            foreach (var v in list)
                versoes.Add(v.Object);
            float ultimaVersao = 0;
            if (versoes.Count > 0)
                ultimaVersao = versoes[versoes.Count - 1];

            return ultimaVersao;
        }

        public static async Task<bool> VerificarAtivacao()
        {
            //var result1 = await CN_Ativacao.VerificarCertificado();
            bool tudoCerto = false;
            try
            {
                var dataString = await CN_Ativacao.VerificarCertificado();
                var data = DateTime.Parse(dataString);
                if (data < DateTime.Parse(Import.Get.Data))
                {
                    var popup = new PopupAtivarSistema(Const.ATIVACAO_CERTIFICADO);
                    popup.ShowDialog();
                    return false;
                }
                tudoCerto = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            //var result2 = await CN_Ativacao.VerificarMaquina();
            //var ativado = result2 == "ativado";

            //if(!ativado)
            //{
            //    Import.Alert(txt_Log, "Sistema Desativado");
            //    var popup = new PopupAtivarSistema(Import.ATIVACAO_MAQUINA);
            //    popup.ShowDialog();
            //    return false;
            //}

            //Log(TAG, "VerificarAtivacao", result2);
            //return ativado;
            return tudoCerto;
        }

        public static async Task<int> BaixarAtualizacao(float versao)
        {
            try
            {
                var arquivo = FileName + GetApplication.ConvertParaString(versao) + FileExt;
                var url = await GetFirebase.GetStorageServer
                    .Child(GetFirebase.Child.APPS)
                    .Child(GetApplication.AppName)
                    .Child(arquivo)
                    .GetDownloadUrlAsync();

                Log.Msg(TAG, arquivo, url);

                var w = new WebClient();
                var fileByte = await Task.Run(() => w.DownloadData(url));
                w.Dispose();
                if (!Directory.Exists(PathUpdateTemp))
                    Directory.CreateDirectory(PathUpdateTemp);
                File.WriteAllBytes(GetPathCompleto(versao), fileByte);
                File.WriteAllText("update_version", versao.ToString());

                InstalarAtualizacao(versao);
                return 0;
            }
            catch (DirectoryNotFoundException ex)
            {
                Log.Erro(TAG, ex);
                return GetFirebase.CodError.DIRETORIO_FILE_TEMP_NAO_ENCONTRADO;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return GetFirebase.CodError.COD_ERRO_DB_STORAGE;
            }
        }

        public static void InstalarAtualizacao(float versao)
        {
            var path = GetPathCompleto(versao);
            if (!File.Exists(path))
                return;
            try
            {
                var sys = new System.Diagnostics.Process();
                sys.StartInfo.FileName = path;
                sys.Start();
                sys.Dispose();
                Application.Exit();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                var result = MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    InstalarAtualizacao(versao);
                    return;
                }
                Application.Exit();
            }
        }

        public static string GetPathCompleto(float versao)
        {
            return Path.Combine(PathUpdateTemp, FileName + ConvertParaString(versao) + FileExt);
        }

        public static void DeleteTempFile(string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

    }

    public static class TabelaLayout
    {
        private const string TAG = "TabelaLayout";

        #region GetNewLinha

        public static object[] GetNewLinha(int indice, Caixa item, string classeName, bool isSelecionado)
        {
            try
            {
                switch (classeName)
                {
                    case "Tela_Relatorio_Caixas":
                        var geoloc = string.Format("{0}, {1}", item.latitude, item.longitude);
                        return new object[] { isSelecionado, indice, item.id, item.nome, item.status, item.portas, (item.portas - item.clientes.Count), geoloc, item.endereco.bairro, item.endereco.rua };
                    case "Tela_Historico_Alteracao":
                        return new object[] { isSelecionado, indice, item.id, item.nome, item.status, item.portas, (item.portas - item.clientes.Count), item.data, item.usuario.nome };
                    default:// exclusão
                        return new object[] { isSelecionado, indice, item.id, item.nome, item.status, item.data, item.usuario.nome, item.motivo };
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return null;
            }
        }
        public static object[] GetNewLinha(int indice, Caixa_Alterada item, bool selecionado) => new object[] {
            selecionado, indice, item.id, item.GetCaixa(0).nome, item.caixas.Count, item.data
        };
        public static object[] GetNewLinha(int indice, Lembrete item) => new object[] {
            indice, item.id, item.titulo, item.texto, item.isAlarme, item.isFixado
        };
        public static object[] GetNewLinha(int indice, Usuario item) => new object[] {
            indice, item.id, item.nome, item.usuario, item.perfilId
        };

        public static DataColumn GetNewColuna(string nome, Type type = null) => new DataColumn
        {
            ColumnName = nome,
            DataType = type ?? Type.GetType("System.String")
        };

        #endregion

        #region Métodos Invoke

        public static void InvokeClear(DataGridView Tabela)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    Tabela.Invoke(new Action(() => { Tabela.Rows.Clear(); }));
                }
                else
                    Tabela.Rows.Clear();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        public static void InvokeButtonVisible(Button button, bool visible)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    button.Invoke(new Action(() => { button.Enabled = visible; }));
                }
                else
                    button.Enabled = visible;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        public static void InvokePaginacao(Label txt_pg, string paginacao)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    txt_pg.Invoke(new Action(() => { txt_pg.Text = paginacao; }));
                }
                else
                    txt_pg.Text = paginacao;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        public static void InvokeAddLinha(DataGridView Tabela, DataRowChangeEventArgs linha)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    Tabela.Invoke(new Action(() => { Tabela.Rows.Add(linha.Row.ItemArray); }));
                }
                else
                    Tabela.Rows.Add(linha.Row.ItemArray);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        public static void InvokeRemoveLinha(DataGridView Tabela, int indice)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    Tabela.Invoke(new Action(() => {
                        InvokeTabelaRemoveLinhaAux(Tabela, indice);
                    }));
                }
                else
                {
                    InvokeTabelaRemoveLinhaAux(Tabela, indice);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        public static void InvokeAlterarLinha(DataGridView Tabela, int indice, DataRowChangeEventArgs linha)
        {
            try
            {
                if (Thread.CurrentThread.IsBackground)
                {
                    Tabela.Invoke(new Action(() => {
                        InvokeTabelaAlterarLinhaAux(Tabela, indice, linha);
                    }));
                }
                else
                {
                    InvokeTabelaAlterarLinhaAux(Tabela, indice, linha);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private static void InvokeTabelaRemoveLinhaAux(DataGridView Tabela, int indice)
        {
            try
            {
                Tabela.Rows.RemoveAt(indice);
                for (int i = indice; i < Tabela.Rows.Count; i++)
                {
                    // Ao remover um elemento este método atualiza o indice de todas as linhas abaixo da linha removida
                    Tabela.Rows[i].Cells["_indice"].Value = i + 1;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        public static void InvokeTabelaAlterarLinhaAux(DataGridView Tabela, int indice, DataRowChangeEventArgs linha)
        {
            try
            {
                // A columa que guarda o indice da linha não pode ser repetido.
                //então preciso remover a linha e recolocar a nova linha na posição que foi removido
                Tabela.Rows.RemoveAt(indice);
                Tabela.Rows.Insert(indice, linha.Row.ItemArray);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="cor">1 = Orange | 2 = Violet | 3 = Blue</param>
        public static async void ColorirLinha(DataGridViewRow linha, int cor = 0)
        {
            try
            {
                bool indicePar = IndiceIsPar(linha.Index);

                switch (cor)
                {
                    case 1:
                        linha.DefaultCellStyle.BackColor = indicePar ? Color.Orange : Color.DarkOrange;
                        break;
                    case 2:
                        linha.DefaultCellStyle.BackColor = indicePar ? Color.Violet : Color.Plum;

                        await Task.Delay(5000);
                        ColorirLinha(linha);
                        break;
                    case 3:
                        linha.DefaultCellStyle.BackColor = indicePar ? Color.SkyBlue : Color.LightSkyBlue;
                        break;
                    default:
                        linha.DefaultCellStyle.BackColor = indicePar ? TemaConfig.ColorPrimary : TemaConfig.ColorPrimaryDark;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        internal static DataColumn GetNewColuna(object mOTIVO)
        {
            throw new NotImplementedException();
        }

        private static bool IndiceIsPar(int indide)
        {
            if (indide % 2 == 0)
                return true;
            else
                return false;
        }

        #endregion

        //========SELECIONAR TODAS CAIXAS DO RELATORIO LIST CAIXA
        public static void MultiSelectCheckbox(
            DataGridView Tabela, bool check, string colunaseleciona, List<Caixa> caixas, List<Caixa> selecionado, Label Cont)
        {
            try
            {
                selecionado.Clear();
                int i = 0;
                foreach (DataGridViewRow r in Tabela.Rows)
                {
                    r.Cells[colunaseleciona].Value = check;
                    if (check)
                        selecionado.Add(caixas[i]);
                    i++;
                }
                Cont.Visible = selecionado.Count > 0;
                Cont.Text = selecionado.Count == 0 ? "" : "Selecionados: " + selecionado.Count.ToString();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        //========SELECIONAR TODAS CAIXAS DO RELATORIO LIST CAIXA_Alterada
        public static void MultiSelectCheckbox(
            DataGridView Tabela, bool check, string colunaseleciona, List<Caixa_Alterada> caixas, List<Caixa_Alterada> selecionado, Label Cont)
        {
            try
            {
                selecionado.Clear();
                int i = 0;
                foreach (DataGridViewRow r in Tabela.Rows)
                {
                    r.Cells[colunaseleciona].Value = check;
                    if (check)
                        selecionado.Add(caixas[i]);
                    i++;
                }
                Cont.Text = selecionado.Count == 0 ? "" : selecionado.Count.ToString();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        public static void SetTema(DataGridView Tabela)
        {
            try
            {
                Tabela.BackgroundColor = TemaConfig.ColorPrimary;
                Tabela.RowsDefaultCellStyle.BackColor = TemaConfig.ColorPrimary;
                Tabela.AlternatingRowsDefaultCellStyle.BackColor = TemaConfig.ColorPrimaryDark;

                Tabela.ForeColor = TemaConfig.TextColorPrimary;
                Tabela.AlternatingRowsDefaultCellStyle.ForeColor = TemaConfig.TextColorPrimary;
                Tabela.RowsDefaultCellStyle.ForeColor = TemaConfig.TextColorPrimary;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private static List<DataGridViewRow> GetLinhasSelecionadas(DataGridView Tabela, string celula_selecao)
        {
            var linhas = new List<DataGridViewRow>();
            try
            {
                foreach (DataGridViewRow r in Tabela.Rows)
                    if (Convert.ToBoolean(r.Cells[celula_selecao].Value.ToString()))
                        linhas.Add(r);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return linhas;
        }

        public static List<Caixa> GetCaixasSelecionadas(DataGridView Tabela, List<Caixa> caixas, string celula_id, string celula_selecao)
        {

            var caixasSelecionadas = new List<Caixa>();
            try
            {
                var linhas = GetLinhasSelecionadas(Tabela, celula_selecao);
                foreach (var l in linhas)
                {
                    string id = l.Cells[celula_id].Value.ToString();
                    caixasSelecionadas.Add(caixas.Find(x => x.id.Equals(id)));
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return caixasSelecionadas;
        }
        public static List<Caixa_Alterada> GetCaixasSelecionadas(DataGridView Tabela, List<Caixa_Alterada> caixas, string celula_id, string celula_selecao)
        {
            var caixasSelecionadas = new List<Caixa_Alterada>();
            try
            {
                var linhas = GetLinhasSelecionadas(Tabela, celula_selecao);
                foreach (var l in linhas)
                {
                    string id = l.Cells[celula_id].Value.ToString();
                    caixasSelecionadas.Add(caixas.Find(x => x.id.Equals(id)));
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return caixasSelecionadas;
        }

    }

    public static class GetFirebase
    {
        #region Variaveis
        private const string TAG = "GetFirebase";

        private const string STORAGE_URL_SERVER = "okisoftware-34ac9.appspot.com";
        private const string DATABASE_URL_SERVER = "https://okisoftware-34ac9.firebaseio.com";

        private static Dictionary<string, string> _firebaseProjectData;

        private static FirebaseClient firebaseClient;
        private static FirebaseApp firebaseApp;

        private static Usuario _usuario;

        #endregion

        public static class Child
        {
            public const string CAIXAS = "caixas";
            public const string CLIENTES = "clientes";
            public const string CAIXAS_ALTERADAS = "caixas_alteradas";
            public const string CAIXAS_EXCLUIDAS = "caixas_excluidas";
            public const string USUARIOS = "usuarios";
            public const string DADOS = "_dados";
            public const string PERFIL_ACESSO = "perfil_acesso";
            public const string USUARIO_DADOS = "_dados";
            public const string USUARIO_PERFIL = "perfil";
            public const string USUARIO_CONVERSA = "conversas";
            public const string USUARIO_LEMBRETES = "lembretes";
            public const string GRAFICOS = "graficos";
            public const string VIABILIDADE = "viabilidades";
            public const string CANCELAMENTO = "cancelamentos";

            public const string APPS = "apps";
            public const string VERSAO = "versao";

            public const string LOGS = "logs";
        }

        public static class CodError
        {
            /// <summary>
            /// "UnknownEmailAddress" Endereço de email (login) não encontrado
            /// </summary>
            public const int COD_EMAIL_NAO_ENCONTRADO = 54620;
            public const string EMAIL_NAO_ENCONTRADO = "UnknownEmailAddress";
            /// <summary>
            /// "Undefined" Erro na conexão com o banco de dados
            /// </summary>
            public const int COD_ERRO_DE_CONEXAO = 435451;
            public const string ERRO_DE_CONEXAO = "Undefined";
            /// <summary>
            /// "WrongPassword" Senha incorreta
            /// </summary>
            public const int COD_SENHA_INCORRETA = 12786;
            public const string SENHA_INCORRETA = "WrongPassword";

            /// <summary>
            /// "WrongPassword" Senha incorreta
            /// </summary>
            public const int COD_PERMISSAO_NEGADA = 78463;
            public const string PERMISSAO_NEGADA = "Permissão negada";

            /// <summary>
            /// Ultima versão do sistema no banco de dados diferente da ultima versão do sistema no Storage
            /// </summary>
            public const int COD_ERRO_DB_STORAGE = 3454;
            /// <summary>
            /// Ocorre quando o sistema não consegue criar uma pasta temporaria no diretório do usuário "user\Documents"
            /// </summary>
            public const int DIRETORIO_FILE_TEMP_NAO_ENCONTRADO = 6573;
        }

        public static async Task Init()
        {
            Log.Msg(TAG, "Init", "Iniciando");
            GetPerfils.AddAll(await PerfilDeAcesso.BaixarLista());
            GetUsuarios.AddAll(await Usuario.BaixarLista());
            GetCaixas.AddAll(await Caixa.BaixarLista());
            GetCaixasExcluidas.AddAll(await Caixa.BaixarLista(excluidas: true));
            GetCaixasAlteraradas.AddAll(await Caixa_Alterada.BaixarLista());

            GetCaixas.InitFirebaseOrservable();
            Log.Msg(TAG, "Init", "OK");
        }

        #region usuário logado

        public static Usuario usuario { get => _usuario; set => _usuario = value; }

        #endregion

        /// <summary>
        /// Empresa: nome, email, email_senha |
        /// Firebase: api_key, databaseURL, storageURL
        /// </summary>
        public static Dictionary<string, string> firebaseProjectData 
        {
            get
            {
                if (_firebaseProjectData == null)
                {
                    string result = Encoding.UTF8.GetString(Properties.Resources.firebase_empresa_dados);
                    _firebaseProjectData = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                }
                return _firebaseProjectData;
            }
        }

        public static FirebaseApp GetApp
        {
            get
            {
                if (firebaseApp == null)
                {
                    MemoryStream stream = new MemoryStream(Properties.Resources.firebase_adminsdk);
                    firebaseApp = FirebaseApp.Create(new AppOptions() { Credential = GoogleCredential.FromStream(stream)/*.FromFile(path_sdkAdmin)*/ });
                    stream.Close();
                }
                return firebaseApp;
            }
            
        }
        public static FirebaseClient GetClient => firebaseClient;
        public static FirebaseClient GetServer => new FirebaseClient(DATABASE_URL_SERVER);
        public static FirebaseStorage GetStorage => new FirebaseStorage(firebaseProjectData[Const.STORAGE]);
        public static FirebaseStorage GetStorageServer => new FirebaseStorage(STORAGE_URL_SERVER);

        public static string GetApiKey => firebaseProjectData[Const.API_KEY];
        public static string GetDatabaseURL => firebaseProjectData[Const.DATABASE];
        public static string GetCompanhiaNome => firebaseProjectData[Const.NOME];

        public static void SetFirebaseClient(FirebaseClient client)
        {
            firebaseClient = client;
        }

        public static bool VerificarUID(string valor)
        {
            //if (valor.Equals(APP_ID_RELEASE) || valor.Equals(APP_ID_DEBUG))
            //    return true;
            return false;
        }

    }

    public static class GetCaixas
    {
        private const string TAG = "GetCaixas";

        public delegate void OnDataChange(Caixa item);
        public delegate void OnDataChangeAll(List<Caixa> items);
        public static event OnDataChange OnAdd;
        public static event OnDataChangeAll OnAddAll;
        public static event OnDataChange OnRemove;

        private static readonly List<Caixa> _data = new List<Caixa>();

        public static List<Caixa> data { get => _data; }
        public static Caixa Get(string itemID) => _data.Find(x => x.id.Equals(itemID));
        /// <summary>
        /// Adiciona ou substitui um Item na lista
        /// </summary>
        /// <param name="acionarEvento">indica se o Evento <see cref="OnAdd"/> será acionado</param>
        public static void Add(Caixa item, bool acionarEvento = true)
        {
            if (item == null) return;

            var aux = Get(item.id);
            if (aux != null)
                _data.Remove(aux);
            _data.Add(item);

            if (acionarEvento)
                OnAdd?.Invoke(item);
        }
        public static void AddAll(List<Caixa> items)
        {
            foreach (var item in items)
                Add(item, acionarEvento: false);
            OnAddAll?.Invoke(items);
        }
        public static void Remove(Caixa item)
        {
            _data.Remove(item);
            OnRemove?.Invoke(item);
        }
        public static void Remove(string itemID)
        {
            var item = Get(itemID);
            _data.Remove(item);
            
            if (item != null)
                OnRemove?.Invoke(item);
        }


        /// <summary>
        /// Método responsável por Obsertar mudanças no database.
        /// Somente do nó "caixas" pras telas [RelatorioCaixas, Mapa]
        /// </summary>
        public static void InitFirebaseOrservable()
        {
            try
            {
                 GetFirebase.GetClient
                     .Child(GetFirebase.Child.CAIXAS)
                     .AsObservable<Caixa>()
                     .Subscribe(obj => AtualizarListaDeCaixas(obj.Object, obj.Key));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private static void AtualizarListaDeCaixas(Caixa item, string key)
        {
            if (item == null) return;

            try
            {
                // Se não usar o 'GetNewCaixa' o VS fica sempre usando o objeto 'caixa' como se fosse uma variável global
                // Não sei o motivo...
                item.id = key;
                item = Caixa.NewItem(item);
                if (item.isExcluido)
                {
                    Log.Msg(TAG, "AtualizarListaDeCaixas", "Excluido", item.id);
                    GetCaixas.Remove(item);
                    return;
                }

                var itemAux = GetCaixas.Get(item.id);
                item.isEditado = false;

                // Se estiver na lista só quero sobrescrever se a data de alteração desta caixa for mais recente
                if (itemAux != null)
                    item.isEditado = (DateTime.Parse(item.data) > DateTime.Parse(itemAux.data));
                item.isNovo = (itemAux == null || item.isEditado);

                if (item.isNovo)
                {
                    Log.Msg(TAG, "AtualizarListaDeCaixas", "Novo", item.id);
                    item.Preparar();
                    GetCaixas.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }


        /// <summary>
        /// Retorna TRUE se o item faz parte de items.
        /// Acho que não precisa mais usar isso
        /// </summary>
        public static bool Teste(Caixa item, List<Caixa> items)
        {
            try
            {
                return items.Contains(item);
                //return items.Find(x => x.id.Equals(item.id)) != null;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            return false;
        }

    }

    public static class GetCaixasAlteraradas
    {
        private const string TAG = "GetCaixasAlteraradas";

        public delegate void OnDataChange(Caixa_Alterada item);
        public static event OnDataChange OnAdd;
        public static event OnDataChange OnRemove;

        private static List<Caixa_Alterada> _data = new List<Caixa_Alterada>();

        public static List<Caixa_Alterada> data { get => _data; }
        public static Caixa_Alterada Get(string itemID) => _data.Find(x => x.id.Equals(itemID));
        /// <summary>
        /// Adiciona ou substitui um Item na lista
        /// </summary>
        public static void Add(Caixa_Alterada item)
        {
            if (item == null) return;

            var aux = Get(item.id);
            if (aux != null)
                _data.Remove(aux);
            _data.Add(item);

            OnAdd?.Invoke(item);
        }
        public static void AddAll(List<Caixa_Alterada> items)
        {
            foreach (var item in items)
                Add(item);
        }
        public static void Remove(Caixa_Alterada item)
        {
            _data.Remove(item);
            OnRemove?.Invoke(item);
        }
        public static void Remove(string itemID)
        {
            var item = Get(itemID);
            _data.Remove(item);

            if (item != null)
                OnRemove?.Invoke(item);
        }

        /// <summary>
        /// Acho que não precisa mais usar isso
        /// </summary>
        /// <param name="item">Item para verificar</param>
        /// <param name="items">Lista dos items selecionados</param>
        public static bool Teste(Caixa_Alterada caixa, List<Caixa_Alterada> selecionadas)
        {
            try
            {
                foreach (var cs in selecionadas)
                    if (cs.id.Equals(caixa.id))
                        return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            return false;
        }
    }

    public static class GetCaixasExcluidas
    {
        public delegate void OnDataChange(Caixa item);
        public static event OnDataChange OnAdd;
        public static event OnDataChange OnRemove;

        private static List<Caixa> _data = new List<Caixa>();

        public static List<Caixa> data { get => _data; }
        public static Caixa Get(string itemID) => _data.Find(x => x.id.Equals(itemID));
        /// <summary>
        /// Adiciona ou substitui um Item na lista
        /// </summary>
        public static void Add(Caixa item)
        {
            if (item == null) return;

            var aux = Get(item.id);
            if (aux != null)
                _data.Remove(aux);
            _data.Add(item);

            OnAdd?.Invoke(item);
        }
        public static void AddAll(List<Caixa> items)
        {
            foreach (var item in items)
                Add(item);
        }
        public static void Remove(Caixa item)
        {
            _data.Remove(item);
            OnRemove?.Invoke(item);
        }
        public static void Remove(string itemID)
        {
            var item = Get(itemID);
            _data.Remove(item);

            if (item != null)
                OnRemove?.Invoke(item);
        }
    }

    public static class GetRelatorio
    {
        private const string TAG = "GetRelatorio";

        public static void CriarRelatorio(List<Caixa> items, string classeName, bool isGrafico = false)
        {
            try
            {
                if (items.Count == 0) return;

                var popup = new Popup_Filtro_Relatorio(isGrafico);

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    if (isGrafico)
                    {
                        var inicio = popup.DT_Inicio.Value;
                        var fim = popup.DT_Fim.Value;

                        var relatorio = new Tela_Relatorio(items, popup.viabilidades, popup.cancelamentos, inicio, fim);
                        relatorio.ShowDialog();
                        relatorio.Dispose();
                    }
                    else
                    {
                        var relatorio = new Tela_Relatorio(items, popup.incluirClientes, classeName);
                        relatorio.ShowDialog();
                        relatorio.Dispose();
                    }
                }
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        public static void CriarRelatorio(List<Caixa_Alterada> caixas)
        {
            try
            {
                if (caixas.Count == 0) return;
                var relatorio = new Tela_Relatorio(caixas);
                relatorio.ShowDialog();
                relatorio.Dispose();

                //var popup = new Popup_Filtro_Relatorio();
                //popup.Cb_1.Visible = false;
                //if (popup.ShowDialog() == DialogResult.OK)
                //{

                //}
                //popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
    }

    public static class GetLembretes
    {
        public delegate void OnDataChange(Lembrete item);
        public static event OnDataChange OnAdd;
        public static event OnDataChange OnRemove;

        private static List<Lembrete> _data = new List<Lembrete>();

        public static List<Lembrete> data { get => _data; }
        public static Lembrete Get(string itemID) => _data.Find(x => x.id.Equals(itemID));
        /// <summary>
        /// Adiciona ou substitui um Item na lista
        /// </summary>
        public static void Add(Lembrete item)
        {
            if (item == null) return;

            var aux = Get(item.id);
            if (aux != null)
                _data.Remove(aux);
            _data.Add(item);

            OnAdd?.Invoke(item);
        }
        public static void AddAll(List<Lembrete> items)
        {
            foreach (var item in items)
                Add(item);
        }
        public static void Remove(Lembrete item)
        {
            _data.Remove(item);
            OnRemove?.Invoke(item);
        }
        public static void Remove(string itemID)
        {
            var item = Get(itemID);
            _data.Remove(item);
            if (item != null)
                OnRemove?.Invoke(item);
        }
    }

    public static class GetUsuarios
    {
        public delegate void OnDataChange(Usuario item);
        public static event OnDataChange OnAdd;
        public static event OnDataChange OnRemove;

        private static readonly List<Usuario> _data = new List<Usuario>();

        public static List<Usuario> data { get => _data; }
        public static Usuario Get(string itemID) => _data.Find(x => x.id.Equals(itemID));

        /// <summary>
        /// Adiciona ou substitui um Item na lista
        /// </summary>
        public static void Add(Usuario item)
        {
            if (item == null) return;

            var aux = Get(item.id);
            if (aux != null)
                _data.Remove(aux);
            _data.Add(item);

            OnAdd?.Invoke(item);
        }
        public static void AddAll(List<Usuario> items)
        {
            foreach (var item in items)
                Add(item);
        }
        public static void Remove(Usuario item)
        {
            _data.Remove(item);
            OnRemove?.Invoke(item);
        }
        public static void Remove(string itemID)
        {
            Usuario item = Get(itemID);
            _data.Remove(item);

            if (item != null)
                OnRemove?.Invoke(item);
        }

    }

    public static class GetPerfils
    {
        private static List<PerfilDeAcesso> _data = new List<PerfilDeAcesso>();

        public static List<PerfilDeAcesso> data { get => _data; }
        public static PerfilDeAcesso Get(string itemID) => _data.Find(x => x.id.Equals(itemID));
        /// <summary>
        /// Adiciona ou substitui um Item na lista
        /// </summary>
        public static void Add(PerfilDeAcesso item)
        {
            if (item == null) return;

            var aux = Get(item.id);
            if (aux != null)
                _data.Remove(aux);
            _data.Add(item);
        }
        public static void AddAll(List<PerfilDeAcesso> items)
        {
            foreach (var item in items)
                Add(item);
        }
        public static void Remove(PerfilDeAcesso item)
        {
            _data.Remove(item);
        }
        public static void Remove(string itemID)
        {
            _data.Remove(Get(itemID));
        }
    }

    public static class Log
    {
        private const string TAG = "Log";
        public static bool ENVIAR_DADOS = true;

        public static void Erro_(string tag, string titulo, string mensagem = null, string dados = null, bool enviarErro = true)
        {
            Console.WriteLine(string.Format("LOG | {0}: {1}: {2}: {3}", tag, titulo, mensagem == null ? "" : mensagem, dados == null ? "" : dados));
        }

        /// <summary>
        /// Antes de usar o 'dadoAux' veja antes como deve ser usado.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="exeption"></param>
        /// <param name="dadoAux">Deve ser usado em métodos com mais de um (1) tratamento de erro pra indicar em qual tratamento o erro ocorreu.</param>
        /// <param name="enviarErro"></param>
        public static async void Erro(string tag, Exception exeption, dynamic dadoAux = null, bool enviarErro = true)
        {
            string msg = "";
            string titulo = "";
            string mensagem = "";
            string dados = "";
            string dadosAux = "";
            if (exeption != null)
            {
                titulo = "Método: " + exeption.TargetSite.Name;
                mensagem = "Message: " + exeption.Message;

                if (exeption.HelpLink != null) dados = "\nHelpLink: " + exeption.HelpLink;
                if (exeption.Source != null) dados += "\nSource: " + exeption.Source;
                if (exeption.StackTrace != null) dados += "\nStackTrace: " + exeption.StackTrace;

                msg = "\nClasse: " + tag;
                msg += "\n" + titulo;
                msg += "\n" + mensagem;
                msg += dados;
            }
            if (dadoAux != null)
            {
                dadosAux = dadoAux.ToString();
                msg += "\nDadoAuxiliar: " + dadosAux;
            }
            Console.WriteLine(string.Format("ERRO | {0}", msg));

            if (ENVIAR_DADOS && enviarErro)
            {
                var mac = Import.Get.EnderecoMac();
                if (mac == null) mac = "123456789";

                ErroLog log = new ErroLog(mac, tag, titulo, mensagem, dados);
                await log.Enviar();

                Msg(TAG, "Erro", "Log Enviado");
            }
        }

        public static void Msg(string tag, string titulo, dynamic mensagem = null, dynamic dados = null)
        {
            Console.WriteLine(string.Format("LOG | {0}: {1}: {2}: {3}", tag, titulo, mensagem == null ? "" : mensagem, dados == null ? "" : dados));
        }
    }

}