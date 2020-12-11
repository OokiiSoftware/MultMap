using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.IO;
using FirebaseAdmin.Auth;
using Firebase.Storage;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Telas
{
    public partial class Tela_User : Form
    {
        #region Variáveis

        private static string TAG = "Tela_User";

        private int indiceItemExcluido;
        private bool IsAtualizando = false;
        /// <summary>
        /// Indica se o usuário está criando um novo Usuario ou Editando um Usuario existente
        /// </summary>
        private bool IsEditandoUsuario = false;

        private List<Usuario> usuarios_Busca = new List<Usuario>();
        
        /// <summary>
        /// Armazena o Usuario que recebeu Duplo Click na Tabela
        /// </summary>
        private Usuario currentUser;
        /// <summary>
        /// Armazena o Perfil do Usuario que recebeu Duplo Click na Tabela
        /// </summary>
        private PerfilDeAcesso currentPerfil;

        // Elementos da tabela
        private DataTable dataTable = new DataTable();

        // Hint dos TextBox
        private string hint_telefone;

        // IDs pra pesquisa
        private const int BuscaPorNome = 56;
        private const int BuscaPorLogin = 564;

        /// <summary>
        /// Firebase.
        /// Observa alterações no database
        /// </summary>
        private IDisposable fb_Ref_Usuarios;

        private class Textos
        {
            #region Geral

            public const string VAZIO = "";

            public const string ATUALIZAR = "Atualizar";
            public const string ADICIONAR = "Adicionar";
            public const string AGUARDE = "Aguarde";

            public const string UIDAdmin = "YWRtaW4=";
            public const string UIDPerfilAdmin = "ADMINISTRADOR";

            public const string SEM_PERMISSAO = "Você não tem permissão";
            public const string FILTRO_IMAGENS = "Imagens|*.jpg;*.png;*.bmp";

            public const string USUARIO_EXCLUIR = "Deseja Excluir este usuário?";
            public const string USUARIO_EXCLUIR_ALERTA = "Este usuário não pode ser removido";
            public const string USUARIO_EXCLUIR_ERRO = "Ocorreu um erro ao remover este usuário";
            public const string USUARIO_EXCLUIDO = "Usuário Excluido!";

            public const string ALERTA_TITULO = "Oops!";
            public const string AVISO_EXCLUIR_PERMANENTE = "Após excluir não será possível restaurá-lo.\n\nDeseja prosseguir?";
            
            public const string DADOS_SALVOS = "Dados Salvos";
            public const string DADOS_SALVOS_ERRO = "Não foi possível salvar esses dados.";
            
            #endregion

            public class Perfil
            {
                public const string ADD = "Adicionar Novo Perfil";
                public const string EDITAR = "Editar Perfil Selecionado";
                public const string EXCLUIR_ALERTA = "Este perfil não pode ser removido";
                public const string SELECIONE = "Selecione um perfil";
                public const string EXCLUIR = "Excluir este perfil";
                public const string EXCLUIR_AVISO = "Remova este perfil de todos os\nfuncionários antes de exclui-lo.";
            }

            public class Cadastro
            {
                public static string PathFotoUser;

                public const string PREENCHA_TUDO = "Preencha todos os campos";
                public const string SENHAS_DIREFENTES = "As senhas estão diferentes";

                public const string NUMERO_JA_EXISTE = "Este número de telefone já está cadastrado";
                public const string NUMERO_INSIRA = "Insira um número de telefone";
                public const string USUARIO_JA_EXISTE = "Este nome de usuário já existe";
                public const string TELEFONE_INVALIDO = "Número de telefone inválido";
                public const string SENHA_FRACA = "A senha está muito fraca. Insira uma mais forte";
                public const string SENHA_ANTIGA_ERRO = "A senha antiga está incorreta";

                public const string EMAIL_TERMINACAO = "@gmail.com";
                public const string NUMERO_CODIGO_PAIS = "+55";
            }

            public class Tabela
            {
                public const string ID = "id";
                public const string NOME = "nome";
                public const string USUARIO = "usuario";
                public const string PERFIL = "categoria";
            }

        }

        #endregion

        public Tela_User()
        {
            InitializeComponent();

            GetUsuarios.OnAdd += OnAddUsuario;
            GetUsuarios.OnRemove += OnRemoveUsuario;

            CriarTabela(dataTable);
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

        private void Tela_User_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (fb_Ref_Usuarios != null)
                    fb_Ref_Usuarios.Dispose();

                GetUsuarios.OnAdd -= OnAddUsuario;
                GetUsuarios.OnRemove -= OnRemoveUsuario;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Adiciona ou substitui o item na tabela
        /// </summary>
        private void OnAddUsuario(Usuario item)
        {
            try
            {
                if (!item.isNovo) return;

                if (item.isEditado)
                {
                    DataRow dataRow = dataTable.Rows.Find(item.id);
                    if (dataRow != null)
                    {
                        int indice = dataTable.Rows.IndexOf(dataRow) + 1;
                        dataRow.ItemArray = TabelaLayout.GetNewLinha(indice, item);
                        Log.Msg(TAG, "AtualizarTabela", "Atualizado: Indice", indice);
                    }
                }
                else
                {
                    Log.Msg(TAG, "AtualizarTabela", "Novo", item.id);
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
        private void OnRemoveUsuario(Usuario item)
        {
            try
            {
                var rowTemp = dataTable.Rows.Find(item.id);
                if (rowTemp == null) return;
                indiceItemExcluido = dataTable.Rows.IndexOf(rowTemp);
                if (indiceItemExcluido > 0)
                    dataTable.Rows.RemoveAt(indiceItemExcluido);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        //===== PictureBox
        private void Img_Foto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = Textos.FILTRO_IMAGENS;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Textos.Cadastro.PathFotoUser = dialog.FileName;
                    img_Foto.BackgroundImage = Image.FromFile(dialog.FileName);
                }
                dialog.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #region Botões

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            UserSaveManager();
        }
        
        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirUsuario();
        }

        private void Btn_limpar_campos_Click(object sender, EventArgs e)
        {
            Limpar_TextBox();
            ResetarVariaveis();
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            OnAtualizar();
        }

        private void Btn_PerfilRemover_Click(object sender, EventArgs e)
        {
            OnPerfilRemove();
        }

        private void Btn_PerfilAdd_Click(object sender, EventArgs e)
        {
            OnPerfilAdd();
        }

        private void Btn_PerfilAlterar_Click(object sender, EventArgs e)
        {
            OnPerfilAlterar();
        }

        private void Btn_VerPerfil_Click(object sender, EventArgs e)
        {
            OnPerfilAbrir();
        }

        #region Ações dos botões

        /// <summary>
        /// Gerenciador dos processos de criação ou alteração dos usuários
        /// </summary>
        private void UserSaveManager()
        {
            if (CB_Perfil.SelectedIndex < 0)
            {
                Import.Alert(txt_Log, Textos.Perfil.SELECIONE);
                return;
            }

            Usuario item = CriarUsuario();
            if (!VerificarDadosOK(item))
                return;

            Import.Alert(txt_Log, Textos.AGUARDE);

            if (currentUser == null)// Cadastrar
                CadastrarUsuario(item);
            else// Atualizar
                AtualizarUsuario(item);
        }

        /// <summary>
        /// Cria um objeto do tipo Usuario
        /// </summary>
        /// <returns></returns>
        private Usuario CriarUsuario()
        {
            string senha = null;
            string telefone = tb_Telefone.Text;

            #region Organizar o telefone

            telefone = telefone.Replace("(", "");
            telefone = telefone.Replace(")", "");
            telefone = telefone.Replace("-", "");
            telefone = telefone.Replace(" ", "");

            #endregion

            if (IsEditandoUsuario && cb_AlterarSenha.Checked)
                senha = tb_confirmar_senha.Text;
            else if (!IsEditandoUsuario) senha = tb_senha.Text;

            Usuario item = IsEditandoUsuario ? Usuario.newItem(currentUser) : new Usuario();

            item.nome = tb_nome.Text;
            item.usuario = tb_usuario.Text;
            item.perfilId = CB_Perfil.SelectedItem.ToString();
            item.telefone = telefone;
            item.data = Import.Get.DataHora;

            if (senha != null)
                item.senha = senha;

            return item;
        }

        /// <summary>
        /// Verifica se há problemas nos dados do item.
        /// </summary>
        private bool VerificarDadosOK(Usuario item)
        {
            bool dadoOK = true;
            bool dadoVazio = false;
            if (item.nome.Trim().Length == 0)
            {
                tb_nome.Focus();
                dadoOK = false;
                dadoVazio = true;
            }
            else if (item.usuario.Trim().Length == 0)
            {
                tb_usuario.Focus();
                dadoOK = false;
                dadoVazio = true;
            }
            else if (item.telefone.Equals(hint_telefone))
            {
                tb_Telefone.Focus();
                dadoOK = false;
                dadoVazio = true;
            }
            else
            {
                string senha = tb_senha.Text;
                string senhaConfirm = tb_confirmar_senha.Text;
                if (IsEditandoUsuario)
                {
                    if (cb_AlterarSenha.Checked)
                    {
                        if (item.senha.Trim().Length == 0)
                        {
                            tb_senha.Focus();
                            dadoOK = false;
                            dadoVazio = true;
                        }
                        else if (senhaConfirm.Trim().Length == 0)
                        {
                            tb_confirmar_senha.Focus();
                            dadoOK = false;
                            dadoVazio = true;
                        }
                        else if (!senha.Equals(currentUser.DecriptSenha))
                        {
                            Import.Alert(txt_Log, Textos.Cadastro.SENHA_ANTIGA_ERRO, isErro: true);
                            tb_senha.Text = Textos.VAZIO;
                            tb_senha.Focus();
                            dadoOK = false;
                        }
                    }
                }
                else {
                    if (item.senha.Trim().Length == 0)
                    {
                        tb_senha.Focus();
                        dadoOK = false;
                        dadoVazio = true;
                    }
                    else if (senhaConfirm.Trim().Length == 0)
                    {
                        tb_confirmar_senha.Focus();
                        dadoOK = false;
                        dadoVazio = true;
                    }
                    else if (!item.DecriptSenha.Equals(senhaConfirm))
                    {
                        Import.Alert(txt_Log, Textos.Cadastro.SENHAS_DIREFENTES);
                        tb_confirmar_senha.Focus();
                        dadoOK = false;
                    }
                }    
            }

            if (dadoVazio) Import.Alert(txt_Log, Textos.Cadastro.PREENCHA_TUDO, isErro: true);

            return dadoOK;
        }

        /// <summary>
        /// Método removido tempotariamente
        /// </summary>
        private async Task<string> PegarFoto(string foto = null)
        {
            FirebaseStorageTask task = null;
            try
            {
                MemoryStream fileStream;
                string id = Cript.EncriptBase64(tb_usuario.Text);
                if (Textos.Cadastro.PathFotoUser != null)
                {
                    byte[] b = File.ReadAllBytes(Textos.Cadastro.PathFotoUser);
                    fileStream = new MemoryStream(b);
                }
                else if (foto != null)
                    return foto;
                else
                    fileStream = new MemoryStream(Properties.Resources.ic_user);
                
                task = GetFirebase.GetStorage
                    .Child(GetFirebase.Child.USUARIOS)
                    .Child(GetFirebase.Child.USUARIO_PERFIL)
                    .Child(id)
                    .PutAsync(fileStream);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            return task == null? "" : await task;
        }

        /// <summary>
        /// Registra o item no database e cria os dados de autenticação
        /// </summary>
        private async void CadastrarUsuario(Usuario item)
        {
            bool hasError = false;
            try
            {
                FirebaseAuth auth = FirebaseAuth.GetAuth(GetFirebase.GetApp);
                UserRecord user = await auth.CreateUserAsync(CriarFirebaseUser(item));

                item.id = user.Uid;
                if (await item.Salvar())
                {
                    Import.Alert(txt_Log, Textos.DADOS_SALVOS);
                    Limpar_TextBox();
                    ResetarVariaveis();
                }
                else hasError = true;
            }
            catch (FirebaseAuthException ex)
            {
                switch (ex.ErrorCode.ToString())
                {
                    case "AlreadyExists":
                        Import.Alert(txt_Log, Textos.Cadastro.NUMERO_JA_EXISTE, isErro: true);
                        break;
                    case "InvalidArgument":
                        if (ex.Message.Contains("INVALID_PHONE_NUMBER"))
                            Import.Alert(txt_Log, Textos.Cadastro.TELEFONE_INVALIDO, isErro: true);
                        else
                            Import.Alert(txt_Log, Textos.Cadastro.USUARIO_JA_EXISTE, isErro: true);
                        break;
                }
                Log.Erro(TAG, ex, 22);
                hasError = true;
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Phone number must not be empty.":
                        Import.Alert(txt_Log, Textos.Cadastro.NUMERO_INSIRA, true);
                        break;
                    case "Password must be at least 6 characters long.":
                        Import.Alert(txt_Log, Textos.Cadastro.SENHA_FRACA, true);
                        break;
                    default:
                        Import.Alert(txt_Log, Textos.DADOS_SALVOS_ERRO, true);
                        break;
                }
                Log.Erro(TAG, ex, 6);
                hasError = true;
            }

            if (hasError)
                Import.Alert(txt_Log, Textos.DADOS_SALVOS_ERRO, isErro: true);
        }

        /// <summary>
        /// Atualiza os dados do item que não estiverem vazios
        /// </summary>
        private async void AtualizarUsuario(Usuario item)
        {
            bool hasError = false;
            try
            {
                item.id = currentUser.id;

                FirebaseAuth auth = FirebaseAuth.GetAuth(GetFirebase.GetApp);
                await auth.UpdateUserAsync(CriarFirebaseUser(item));
                if (await item.Salvar())
                {
                    Import.Alert(txt_Log, Textos.DADOS_SALVOS);
                    Limpar_TextBox();
                    ResetarVariaveis();
                }
                else hasError = true;
            }
            catch (FirebaseAuthException ex)
            {
                switch (ex.ErrorCode.ToString())
                {
                    case "AlreadyExists":
                        Import.Alert(txt_Log, Textos.Cadastro.NUMERO_JA_EXISTE, isErro: true);
                        break;
                    case "InvalidArgument":
                        if (ex.Message.Contains("INVALID_PHONE_NUMBER"))
                            Import.Alert(txt_Log, Textos.Cadastro.TELEFONE_INVALIDO, isErro: true);
                        else
                            Import.Alert(txt_Log, Textos.Cadastro.USUARIO_JA_EXISTE, isErro: true);
                        break;
                }
                Log.Erro(TAG, ex, 1);
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Phone number must not be empty.":
                        Import.Alert(txt_Log, Textos.Cadastro.NUMERO_INSIRA, isErro: true);
                        break;
                    case "Password must be at least 6 characters long.":
                        Import.Alert(txt_Log, Textos.Cadastro.SENHA_FRACA, isErro: true);
                        break;
                    default:
                        Import.Alert(txt_Log, Textos.DADOS_SALVOS_ERRO, isErro: true);
                        break;
                }
                Log.Erro(TAG, ex, 5);
            }

            if (hasError)
                Import.Alert(txt_Log, Textos.DADOS_SALVOS_ERRO, isErro: true);
        }

        /// <summary>
        /// Remove o item do database e do registro de autenticação
        /// </summary>
        private async void ExcluirUsuario()
        {
            string titulo = Textos.USUARIO_EXCLUIR;
            string msg = Textos.AVISO_EXCLUIR_PERMANENTE;

            try
            {
                //string id = currentRow.Cells[Textos.Tabela.ID].Value.ToString();
                Usuario item = currentUser;// GetUsuarios.Get(id);
                if (item.id.Equals(Textos.UIDAdmin))
                {
                    Import.Alert(txt_Log, Textos.USUARIO_EXCLUIR_ALERTA, isErro: true);
                    return;
                }
                var result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;

                Alert(Textos.AGUARDE);

                if (await item.Delete())
                    Import.Alert(txt_Log, Textos.USUARIO_EXCLUIDO);
                else
                    Import.Alert(txt_Log, Textos.USUARIO_EXCLUIR_ERRO, isErro: true);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Baixa a lista de usuários do database e atualiza a tabela.
        /// </summary>
        private async void OnAtualizar()
        {
            try
            {
                Alert(Textos.AGUARDE);
                IsAtualizando =
                Btn_Atualizar.Visible = false;
                Btn_limpar_campos_Click(null, null);
                GetUsuarios.data.Clear();
                GetUsuarios.AddAll(await Usuario.BaixarLista());
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            Listar();
            Alert(mostrar: false);
            IsAtualizando = false;
            Btn_Atualizar.Visible = true;
        }

        /// <summary>
        /// Abre uma Popup com os dados do Perfil selecionado.
        /// </summary>
        private void OnPerfilAbrir()
        {
            try
            {
                if (currentPerfil == null)
                    return;

                var popup = new Popup_PerfilDeUsuario(currentPerfil);
                if (popup.ShowDialog() == DialogResult.OK)
                    CB_Perfil.Items.Add(popup.perfilNome);

                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        /// <summary>
        /// Abre uma Popup pra adicionar um novo perfil.
        /// </summary>
        private void OnPerfilAdd()
        {
            try
            {
                if (!GetFirebase.usuario.perfil.perfilAdicionar)
                {
                    Import.Alert(txt_Log, Textos.SEM_PERMISSAO);
                    return;
                }
                var popup = new Popup_PerfilDeUsuario();
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    CB_Perfil.Items.Add(popup.perfilNome);
                    GetPerfils.Add(popup.perfil);
                }
                popup.Dispose();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        /// <summary>
        /// Abre uma Popup pra editar os dados do Perfil selecionado.
        /// </summary>
        private void OnPerfilAlterar()
        {
            try
            {
                if (!GetFirebase.usuario.perfil.perfilAlterar)
                {
                    Import.Alert(txt_Log, Textos.SEM_PERMISSAO);
                    return;
                }
                var perfil = GetPerfils.Get(CB_Perfil.SelectedItem.ToString());

                if (perfil != null)
                {
                    bool habilitarEdicao = perfil.id != Textos.UIDPerfilAdmin;

                    var popup = new Popup_PerfilDeUsuario(perfil, GetMeuPerfil().perfilAlterar && habilitarEdicao);
                    popup.ShowDialog();
                    popup.Dispose();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        /// <summary>
        /// Verifica se algum usuario está com o perfil selecionado.
        /// Caso não tenha ninguem com este perfil, então é deletado.
        /// </summary>
        private async void OnPerfilRemove()
        {
            try
            {
                if (!GetFirebase.usuario.perfil.perfilExcluir)
                {
                    Import.Alert(txt_Log, Textos.SEM_PERMISSAO);
                    return;
                }

                var perfil = GetPerfils.Get(CB_Perfil.SelectedItem.ToString());

                if (perfil != null)
                {
                    if (perfil.id == Textos.UIDPerfilAdmin)
                    {
                        Import.Alert(txt_Log, Textos.Perfil.EXCLUIR_ALERTA);
                        return;
                    }

                    // Verifica se este perfil está associado a algum funcionário
                    foreach (var user in GetUsuarios.data)
                    {
                        if (user.perfilId.Equals(perfil.id))
                        {
                            var msg0 = Textos.Perfil.EXCLUIR_AVISO;
                            var titulo0 = Textos.ALERTA_TITULO;
                            MessageBox.Show(msg0, titulo0, MessageBoxButtons.OK);
                            return;
                        }
                    }

                    var msg = Textos.AVISO_EXCLUIR_PERMANENTE;
                    var titulo = Textos.Perfil.EXCLUIR;
                    if (MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (await perfil.Delete())
                        {
                            CB_Perfil.Items.Remove(perfil.id);
                            GetPerfils.Remove(perfil);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #region CheckBox

        private void Cb_AlterarSenha_CheckedChanged(object sender, EventArgs e)
        {
            SwithAlterarSenha(cb_AlterarSenha.Checked);
        }
        
        private void Cb_Pesquisa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cb_Pesquisa.Checked)
                {
                    usuarios_Busca.Clear();
                    Listar();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Ativa ou desativa os campos de texto de Senha e ConfirmarSenha
        /// </summary>
        private void SwithAlterarSenha(bool mostrar)
        {
            try
            {
                tb_senha.Enabled =
                tb_confirmar_senha.Enabled = mostrar;
                tb_senha.Hint = mostrar ? "Senha Antiga" : "Senha";
                tb_confirmar_senha.Hint = mostrar ? "Nova Senha" : "Confirmar Senha";
                tb_senha.Text = "";
                tb_confirmar_senha.Text = "";
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #endregion

        #region TextBox

        private void Tb_telefone_Enter(object sender, EventArgs e)
        {
            try
            {
                tb_Telefone.ForeColor = TemaConfig.TextColorPrimary;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Tb_telefone_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tb_Telefone.Text == hint_telefone)
                    tb_Telefone.ForeColor = Color.Silver;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        //================== Value Changed
        private void Tb_nome_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_Pesquisa.Checked)
                {
                    usuarios_Busca.AddRange(FindUsuarios(BuscaPorNome, tb_nome.Text));
                    Listar();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Tb_usuario_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_Pesquisa.Checked)
                {
                    usuarios_Busca.AddRange(FindUsuarios(BuscaPorLogin, tb_usuario.Text));
                    Listar();
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

        private void Tabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CelulaDoubleClick(e.RowIndex);
        }

        private void CelulaSingleClick(int indice)
        {
            if (IsAtualizando || indice < 0) return;

            try
            {
                var row = Tabela.Rows[indice];
                row.Selected = true;
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
                CelulaSingleClick(indice);

                var currentRow = Tabela.Rows[indice];
                string userID = currentRow.Cells[Textos.Tabela.ID].Value.ToString();

                Usuario item = GetUsuarios.Get(userID);

                if (item == null) return;

                img_Foto.BackgroundImage = Properties.Resources.ic_branco_user;

                tb_nome.Text = item.nome;
                tb_usuario.Text = item.usuario;
                tb_Telefone.Text = item.telefone;
                tb_usuario.ReadOnly = true;

                tb_Telefone.ForeColor = TemaConfig.TextColorPrimary;

                tb_senha.Text = Textos.VAZIO;
                tb_confirmar_senha.Text = Textos.VAZIO;

                CB_Perfil.SelectedItem = item.perfilId;
                CB_Perfil.Enabled = GetMeuPerfil().usuarioAlterar && !item.id.Equals(Textos.UIDAdmin);

                SwithAlterarSenha(false);

                var userLogadoID = GetFirebase.usuario.id;
                bool acessoNivel0 = item.id.Equals(userLogadoID);

                cb_AlterarSenha.Visible =
                btn_cadastrar.Visible =
                Btn_VerPerfil.Visible =
                img_Foto.Enabled = GetMeuPerfil().usuarioAlterar || acessoNivel0;

                btn_excluir.Visible = GetMeuPerfil().usuarioExcluir;
                btn_cadastrar.Text = Textos.ATUALIZAR;
                btn_cadastrar.BackColor = Color.Peru;
                btn_limpar_campos.Visible = true;

                if (Btn_VerPerfil.Visible)
                {
                    currentPerfil = GetPerfils.Get(item.perfilId);
                    Btn_VerPerfil.Enabled = currentPerfil != null;
                }

                currentUser = item;
                IsEditandoUsuario = true;


                // Isso abaixo é pra carregar a foto do usuário (não usado no momento)
                //
                /*var time = new Timer();
                //essa variável impede que a foto seja baixada varias vezes em vários ticks
                var pararTick = false;
                time.Interval = 100;
                time.Tick += async (s, e) =>
                {
                    if (!pararTick)
                    {
                        pararTick = true;
                        img_Foto.BackgroundImage = await Import.Get.Foto(usuario.GetFoto());
                        foto_atualizar = usuario.GetFoto();
                        time.Stop();
                        time.Dispose();
                    }
                };
                time.Start();*/
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        //===========
        private void On_Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (e.Action == DataRowAction.Delete)
                    TabelaLayout.InvokeRemoveLinha(Tabela, indice: indiceItemExcluido);
                else if (e.Action == DataRowAction.Add)
                    TabelaLayout.InvokeAddLinha(Tabela, e);
                else if (e.Action == DataRowAction.Change)
                    TabelaLayout.InvokeAlterarLinha(Tabela, indice: e.Row.Table.Rows.IndexOf(e.Row), e);
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
            try
            {
                ToolTip tip = new ToolTip();
                tip.SetToolTip(Btn_Atualizar, Textos.ATUALIZAR);
                tip.SetToolTip(Btn_PerfilAdd, Textos.Perfil.ADD);
                tip.SetToolTip(Btn_PerfilAlterar, Textos.Perfil.EDITAR);
                tip.SetToolTip(Btn_PerfilRemover, Textos.Perfil.EXCLUIR);
                tip.Dispose();

                hint_telefone = tb_Telefone.Text;

                CarregarTema();

                Listar();

                foreach (var p in GetPerfils.data)
                    CB_Perfil.Items.Add(p.id);
                if(CB_Perfil.Items.Count > 0)
                    CB_Perfil.SelectedIndex = 0;

                fb_Ref_Usuarios = GetFirebaseRef();

                txt_Log.Visible = false;
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
                TabelaLayout.SetTema(Tabela);

                #region BackColor

                Painel_Geral.BackColor = TemaConfig.ColorPrimary;

                Linha_1.BackColor =
                Linha_2.BackColor =
                Linha_3.BackColor =
                Linha_4.BackColor =
                Linha_5.BackColor =
                img_Foto.BorderColor = TemaConfig.TextColorPrimary;

                tb_nome.BackColor =
                tb_senha.BackColor =
                tb_usuario.BackColor =
                tb_Telefone.BackColor =
                tb_confirmar_senha.BackColor =

                Btn_VerPerfil.BackColor =
                Btn_PerfilAdd.BackColor =
                Btn_PerfilRemover.BackColor =
                Btn_PerfilAlterar.BackColor = TemaConfig.ColorPrimaryDark;

                #endregion

                #region ForeColor

                Painel_Geral.ForeColor = TemaConfig.TextColorPrimary;
                tb_nome.ForeColor = TemaConfig.TextColorSecundary;
                tb_usuario.ForeColor = TemaConfig.TextColorPrimary;
                tb_Telefone.ForeColor = Color.Silver;
                tb_senha.ForeColor = TemaConfig.TextColorPrimary;
                tb_confirmar_senha.ForeColor = TemaConfig.TextColorPrimary;

                Btn_VerPerfil.ForeColor = TemaConfig.TextColorPrimary;
                Btn_PerfilAdd.ForeColor = TemaConfig.TextColorPrimary;
                Btn_PerfilRemover.ForeColor = TemaConfig.TextColorPrimary;
                Btn_PerfilAlterar.ForeColor = TemaConfig.TextColorPrimary;

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
                List<Usuario> items = usuarios_Busca.Count == 0 ? GetUsuarios.data : usuarios_Busca;
                if (items == null) return;

                dataTable.Rows.Clear();

                for (int i = 0; i < items.Count; i++)
                    AddLinhaTabela(i+1, items[i]);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        /// <summary>
        /// Adiciona o item no indice especificado
        /// </summary>
        /// <param name="indice">Posição onde o item será adicionado</param>
        private void AddLinhaTabela(int indice, Usuario item)
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
        
        /// <summary>
        /// Método responsável por Obsertar mudanças no database
        /// </summary>
        private IDisposable GetFirebaseRef()
        {
            try
            {
                return GetFirebase.GetClient
                    .Child(GetFirebase.Child.USUARIOS)
                    .AsObservable<List_Usuario>()
                    .Subscribe(obj => AtualizarListaUsuarios(obj.Object.usuario, obj.Key));
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return null;
            }
        }
        
        /// <summary>
        /// Ao receber um usuário modificado do database este método analiza os dados
        /// e adiciona na lista de Usuários caso necessário
        /// </summary>
        /// <param name="key">Este item é o ID do usuário e tbm o nó que identifica ele no database</param>
        private void AtualizarListaUsuarios(Usuario item, string key)
        {
            try
            {
                if (item == null) return;

                item.id = key;
                if (item.isExcluido)
                {
                    GetUsuarios.Remove(item);
                    Log.Msg(TAG, "AtualizarListaUsuarios", "Excluido", item.id);
                    return;
                }
                item.usuario = Cript.DescriptBase64(key);

                var itemAux = GetUsuarios.Get(item.id);

                if (itemAux != null)
                    item.isEditado = (DateTime.Parse(item.data) > DateTime.Parse(itemAux.data));
                item.isNovo = (itemAux == null || item.isEditado);

                if (item.isNovo)
                    GetUsuarios.Add(item);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        /// <summary>
        /// Reseta todas as variáveis desta tela
        /// </summary>
        private void ResetarVariaveis()
        {
            try
            {
                if(CB_Perfil.Items.Count > 0)
                    CB_Perfil.SelectedIndex = 0;

                tb_Telefone.ForeColor = Color.Silver;
                btn_cadastrar.Text = Textos.ADICIONAR;
                btn_cadastrar.BackColor = Color.Lime;
                btn_cadastrar.Visible = GetMeuPerfil().usuarioCadastro;

                IsEditandoUsuario =
                Btn_VerPerfil.Visible =
                btn_limpar_campos.Visible =
                btn_excluir.Visible =
                cb_AlterarSenha.Visible =
                cb_AlterarSenha.Checked =
                tb_usuario.ReadOnly =
                tb_nome.ReadOnly = false;


                CB_Perfil.Enabled = true;
                img_Foto.Enabled = true;
                img_Foto.BackgroundImage = Properties.Resources.ic_branco_user;

                currentUser = null;
                currentPerfil = null;
                Textos.Cadastro.PathFotoUser = null;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            //CarregarTema();
            SwithAlterarSenha(true);
        }

        /// <summary>
        /// Limpa todos os TextBox da tela
        /// </summary>
        private void Limpar_TextBox()
        {
            try
            {
                tb_nome.Text =
                tb_usuario.Text =
                tb_senha.Text =
                tb_confirmar_senha.Text =
                tb_Telefone.Text = Textos.VAZIO;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        /// <summary>
        /// Cria um Usuário que o Firebase reconhece pra criar ou alterar um usuário.
        /// Este é o dado usado pra fazer login
        /// </summary>
        private UserRecordArgs CriarFirebaseUser(Usuario item)
        {
            UserRecordArgs user = null;
            try
            {
                user = new UserRecordArgs
                {
                    Uid = Cript.EncriptBase64(item.usuario),
                    DisplayName = item.nome,
                    Email = item.usuario + Textos.Cadastro.EMAIL_TERMINACAO
                };
                if (item.senha.Trim().Length > 0)
                    user.Password = item.senha;
                if (item.foto.Trim().Length > 0)
                    user.PhotoUrl = item.foto;
                if (item.telefone.Trim().Length > 0)
                    user.PhoneNumber = Textos.Cadastro.NUMERO_CODIGO_PAIS + item.telefone;

            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return user;
        }
        
        /// <summary>
        /// Usado pra fazer pesquisas
        /// </summary>
        /// <param name="buscaType">Identificador do tipo de busca. Ex: BuscaPorNome, BuscaPorLogin</param>
        private List<Usuario> FindUsuarios(int buscaType, string busca)
        {
            List<Usuario> item_Encontrados = new List<Usuario>();
            try
            {
                usuarios_Busca.Clear();
                foreach (Usuario usuario in GetUsuarios.data)
                {
                    try
                    {
                        switch (buscaType)
                        {
                            case BuscaPorNome:
                                if (usuario.nome.Contains(busca))
                                    item_Encontrados.Add(usuario);
                                break;
                            case BuscaPorLogin:
                                if (usuario.usuario.Contains(busca))
                                    item_Encontrados.Add(usuario);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Erro(TAG, ex, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex, 2);
            }
            return item_Encontrados;
        }

        /// <summary>
        /// Retorna o perfil do usuário logado
        /// </summary>
        private PerfilDeAcesso GetMeuPerfil()
        {
            return GetFirebase.usuario.perfil;
        }

        /// <summary>
        /// Mostrar ou ocultar o texto de Log na tela do usuário
        /// </summary>
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
                table.Columns.Add(TabelaLayout.GetNewColuna("*", Type.GetType("System.Int32")));
                DataColumn[] c = { TabelaLayout.GetNewColuna(Textos.Tabela.ID) };
                table.Columns.Add(c[0]);
                table.PrimaryKey = c;
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.NOME));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.USUARIO));
                table.Columns.Add(TabelaLayout.GetNewColuna(Textos.Tabela.PERFIL));

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