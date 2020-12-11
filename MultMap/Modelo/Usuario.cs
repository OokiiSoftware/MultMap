using Firebase.Database;
using Firebase.Database.Query;
using FirebaseAdmin.Auth;
using MultMap.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultMap.Modelo
{
    public class Usuario
    {
        private const string TAG = "Usuario";

        #region variáveis
        //Somente as variáveis publicas são salvar no firebaseDatabase
        private string Id { get; set; }
        private string _usuario { get; set; }
        private string Nome { get; set; }
        private string Senha { get; set; }
        private string Telefone { get; set; }
        private string Foto { get; set; }
        private string Data { get; set; }
        private bool IsOnline { get; set; }
        private string PerfilId { get; set; }
        private bool IsExcluido { get; set; }
        private bool IsNovo { get; set; }
        private bool IsEditado { get; set; }
        private PerfilDeAcesso Perfil { get; set; }
        #endregion
        
        public Usuario() {}
        public Usuario(dynamic map)
        {
            if (map.ContainsKey("nome"))
                nome = map["nome"].Object;

            if (map.ContainsKey("telefone"))
                telefone = map["telefone"].Object;

            if (map.ContainsKey("foto"))
                foto = map["foto"].Object;

            if (map.ContainsKey("data"))
                data = map["data"].Object;

            if (map.ContainsKey("senha"))
                senha = map["senha"].Object;

            if (map.ContainsKey("online"))
                isOnline = map["online"].Object;

            if (map.ContainsKey("perfilId"))
                perfilId = map["perfilId"].Object;

            if (map.ContainsKey("excluido"))
                isExcluido = map["excluido"].Object;
        }

        /// <summary>
        /// Somente esses dados serão salvos no firebase
        /// </summary>
        private Dictionary<string, dynamic> toJson() => new Dictionary<string, dynamic>
            {
                { "id", Id },
                { "nome", Nome },
                { "telefone", Telefone },
                { "foto", Foto },
                { "isOnline", IsOnline },
                { "perfilId", PerfilId },
                { "isExcluido", IsExcluido },
                { "data", Data },
                { "senha", EncriptSenha },
            };

        #region metodos

        public async Task<bool> Salvar()
        {
            try
            {
                await GetFirebase.GetClient
                    .Child(GetFirebase.Child.USUARIOS)
                    .Child(id)
                    .Child(GetFirebase.Child.USUARIO_DADOS)
                    .PutAsync(toJson());

                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }
        public async Task<bool> Delete()
        {
            try
            {
                isExcluido = true;
                await Salvar();

                var auth = FirebaseAuth.GetAuth(GetFirebase.GetApp);
                await auth.DeleteUserAsync(id);

                await GetFirebase.GetClient
                    .Child(GetFirebase.Child.USUARIOS)
                    .Child(id)
                    .DeleteAsync();
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }
        public string EncriptSenha { get => Cript.Encript(senha); }
        public string DecriptSenha { get => Cript.Decript(senha); }

        public static async Task<Usuario> Baixar(string idUsuario)
        {
            Usuario u = new Usuario();
            try
            {
                var du = GetFirebase.GetClient
                     .Child(GetFirebase.Child.USUARIOS)
                     .Child(idUsuario)
                     .Child(GetFirebase.Child.DADOS)
                     .OnceAsync<dynamic>().Result.ToDictionary(x => x.Key);

                u = new Usuario(du);
                u.id = idUsuario;
                u.usuario = Cript.DescriptBase64(idUsuario);

                var perfil = GetPerfils.Get(u.perfilId);
                if (perfil == null)
                    perfil = await PerfilDeAcesso.Baixar(u.perfilId);
                if (perfil == null)
                    return null;

                u.perfil = perfil;
            }
            catch (FirebaseException ex)
            {
                Log.Erro(TAG, ex, dadoAux: "2 UID: " + idUsuario);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex, dadoAux: "2 UID: " + idUsuario);
            }
            return u;
        }
        public static async Task<List<Usuario>> BaixarLista()
        {
            var items = new List<Usuario>();

            try
            {
                var data = await GetFirebase.GetClient
                     .Child(GetFirebase.Child.USUARIOS)
                     .OnceAsync<dynamic>();

                var itemsAux = data.ToDictionary(x => x.Key);

                foreach (var key in itemsAux.Keys)
                {
                    if (!itemsAux[key].Object.ContainsKey(GetFirebase.Child.DADOS))
                    {
                        continue;
                    }
                    var map = itemsAux[key].Object[GetFirebase.Child.DADOS];
                    Usuario u = Newtonsoft.Json.JsonConvert.DeserializeObject<Usuario>(map.ToString());

                    u.id = key;
                    u.usuario = Cript.DescriptBase64(key);

                    items.Add(u);
                }
                Log.Msg(TAG, "BaixarLista", "OK", items.Count);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }
        public static Usuario newItem(Usuario item)
        {
            if (item == null) return null;

            return new Usuario
            {
                id = item.id,
                perfilId = item.perfilId,
                nome = item.nome,
                data = item.data,
                foto = item.foto,
                isEditado = item.isEditado,
                IsExcluido = item.IsExcluido,
                isNovo = item.isNovo,
                isOnline = item.isOnline,
                perfil = item.perfil,
                senha = item.senha,
                telefone = item.telefone,
                usuario = item.usuario
            };
        }
        #endregion

        #region get set

        public string id { get => Id; set => Id = value; }
        public string usuario { get => _usuario ?? ""; set => _usuario = value; }
        public string nome { get => Nome ?? ""; set => Nome = value; }
        public string senha { get => Senha ?? ""; set => Senha = value; }
        public string telefone { get => Telefone ?? ""; set => Telefone = value; }
        public string foto { get => Foto ?? ""; set => Foto = value; }
        public string data { get => Data ?? ""; set => Data = value; }
        public bool isOnline { get => IsOnline; set => IsOnline = value; }
        public string perfilId { get => PerfilId ?? ""; set => PerfilId = value; }
        public bool isExcluido { get => IsExcluido; set => IsExcluido = value; }
        public bool isNovo { get => IsNovo; set => IsNovo = value; }
        public bool isEditado { get => IsEditado; set => IsEditado = value; }
        public PerfilDeAcesso perfil { get => Perfil; set => Perfil = value; }

        #endregion
    }
}
