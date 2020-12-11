using System;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using MultMap.Auxiliar;

namespace MultMap.Data
{
    class CN_Ativacao
    {
        #region Variáveis

        private const string TAG = "CN_Ativacao";

        private const string SOLICITADO = "solicitado";
        private const string CLIENTES = "clientes";
        private const string PCS = "maquinas";
        private const string CERTIFICADO = "certificado";

        private static FirebaseClient firebase = GetFirebase.GetServer;

        #endregion

        public static async Task<string> VerificarCertificado()
        {
            try
            {
                return await firebase
                     .Child(CLIENTES)
                     .Child(Import.Get.NomeEmpresa)
                     .Child(CERTIFICADO)
                     .OnceSingleAsync<string>();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return "";
            }
        }

        public static async Task<string> VerificarMaquina()
        {
            try
            {
                return await firebase
                     .Child(CLIENTES)
                     .Child(Import.Get.NomeEmpresa)
                     .Child(PCS)
                     .Child(Import.Get.EnderecoMac())
                     .OnceSingleAsync<string>();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return "";
            }
        }

        public static bool SolicitarAtivacao(string MAC)
        {
            try
            {
                var result = firebase
                    .Child(CLIENTES)
                    .Child(Import.Get.NomeEmpresa)
                    .Child(PCS)
                    .Child(MAC)
                    .PutAsync(SOLICITADO);

                return result != null;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }
    }
}
