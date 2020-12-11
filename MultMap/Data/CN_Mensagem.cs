using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using MultMap.Auxiliar;
using MultMap.Modelo;

namespace MultMap.Data
{
    public static class CN_Mensagem
    {
        private const string TAG = "CN_Mensagem";
        private static readonly FirebaseClient firebase = GetFirebase.GetClient;

        public static bool Add(Mensagem m, string id_Destino)
        {
            try
            {
                firebase
                .Child(GetFirebase.Child.USUARIOS)
                .Child(id_Destino)
                .Child(GetFirebase.Child.USUARIO_CONVERSA)
                .Child(m.Getid_conversa())
                .Child(m.Getdata_de_envio())
                .PutAsync(m);
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }
        public static async Task<List<Mensagem>> GetAll(string id)
        {
            List<Mensagem> ms = new List<Mensagem>();
            try
            {
                var list = await firebase
                    .Child(GetFirebase.Child.USUARIOS)
                    .Child(GetFirebase.usuario.id)
                    .Child(GetFirebase.Child.USUARIO_CONVERSA)
                    .Child(id)
                    .OnceAsync<Mensagem>();
                foreach (var ls in list)
                {
                    ms.Add(ls.Object);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return ms;
        }
        public static bool Remove(Mensagem m)
        {
            try
            {
                string path = GetFirebase.Child.USUARIOS;

                firebase.Child(path)
                    .Child(GetFirebase.usuario.id)
                    .Child(GetFirebase.Child.USUARIO_CONVERSA)
                    .Child(m.Getid_remetente())
                    .Child(m.Getdata_de_envio()).DeleteAsync();
                Log.Msg(TAG, "Remove", m.Getdata_de_envio());
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }
        public static bool Update(Mensagem m)
        {
            try
            {
                string path = GetFirebase.Child.USUARIOS;

                firebase
                    .Child(path)
                    .Child(m.Getid_conversa())
                    .Child(m.Getdata_de_envio())
                    .PutAsync(m);
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }

    }
}
