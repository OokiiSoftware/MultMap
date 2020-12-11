using Firebase.Database.Query;
using MultMap.Auxiliar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultMap.Modelo
{
    public class PerfilDeAcesso
    {
        private const string TAG = "PerfilDeAcesso";

        #region variaveis

        public string id { get; set; }

        public bool multmap { get; set; }
        public bool mapnap { get; set; }

        public bool usuarioCadastro { get; set; }
        public bool usuarioAlterar { get; set; }
        public bool usuarioExcluir { get; set; }
        public bool usuarioEnviarEmail { get; set; }

        public bool perfilAdicionar { get; set; }
        public bool perfilAlterar { get; set; }
        public bool perfilExcluir { get; set; }

        public bool caixaViabilidade { get; set; }
        public bool caixaCancelamento { get; set; }
        public bool caixaAdicionar { get; set; }
        public bool caixaAlterar { get; set; }
        public bool caixaExcluir { get; set; }
        public bool caixaRestaurar { get; set; }

        #endregion

        public PerfilDeAcesso() {}
        public PerfilDeAcesso(string Id, bool MultMap, bool MapNap, bool UsuarioCadastro, bool UsuarioAlterar, bool UsuarioExcluir, bool UsuarioEnviarEmail,
            bool CaixaViabilidade, bool CaixaCancelamento, bool CaixaAdicionar, bool CaixaAlterar, bool CaixaExcluir, bool CaixaRestaurar,
            bool PerfilAdd, bool PerfilAlterar, bool PerfilExcluir)
        {
            this.id = Id;

            this.multmap = MultMap;
            this.mapnap = MapNap;

            this.usuarioCadastro = UsuarioCadastro;
            this.usuarioAlterar = UsuarioAlterar;
            this.usuarioExcluir = UsuarioExcluir;
            this.usuarioEnviarEmail = UsuarioEnviarEmail;

            this.caixaViabilidade = CaixaViabilidade;
            this.caixaCancelamento = CaixaCancelamento;
            this.caixaAdicionar = CaixaAdicionar;
            this.caixaAlterar = CaixaAlterar;
            this.caixaExcluir = CaixaExcluir;
            this.caixaRestaurar = CaixaRestaurar;

            this.perfilAdicionar = PerfilAdd;
            this.perfilAlterar = PerfilAlterar;
            this.perfilExcluir = PerfilExcluir;
        }

        #region metodos

        public async Task<bool> Salvar()
        {
            try
            {
                await GetFirebase.GetClient
                    .Child(GetFirebase.Child.PERFIL_ACESSO)
                    .Child(id)
                    .PutAsync(this);

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
                await GetFirebase.GetClient
                    .Child(GetFirebase.Child.PERFIL_ACESSO)
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

        public async static Task<List<PerfilDeAcesso>> BaixarLista()
        {
            var items = new List<PerfilDeAcesso>();
            try
            {
                var data = await GetFirebase.GetClient
                     .Child(GetFirebase.Child.PERFIL_ACESSO)
                     .OnceAsync<PerfilDeAcesso>();

                foreach (var item in data)
                {
                    item.Object.id = item.Key;
                    items.Add(item.Object);
                }
                Log.Msg(TAG, "BaixarLista", "OK", items.Count);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }
        public async static Task<PerfilDeAcesso> Baixar(string id)
        {
            try
            {
                var perfil = await GetFirebase.GetClient
                     .Child(GetFirebase.Child.PERFIL_ACESSO)
                     .Child(id)
                     .OnceSingleAsync<PerfilDeAcesso>();

                return perfil;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return null;
            }
        }

        #endregion
    }
}
