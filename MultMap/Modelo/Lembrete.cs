using Firebase.Database.Query;
using MultMap.Auxiliar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultMap.Modelo
{
    public class Lembrete
    {
        private const string TAG = "Lembrete";

        #region variaveis

        private string Id { get; set; }
        private string Titulo { get; set; }
        private string Texto { get; set; }
        private bool IsFixado { get; set; }
        private bool IsAlarme { get; set; }
        private string IdUsuario { get; set; }
        private DateTime DataAlarme { get; set; }

        #endregion

        /// <summary>
        /// Somente esses dados serão salvos no firebase
        /// </summary>
        private Dictionary<string, dynamic> toJson() => new Dictionary<string, dynamic>
            {
                { "titulo", Titulo },
                { "texto", Texto },
                { "isFixado", IsFixado },
                { "isAlarme", IsAlarme },
                { "idUsuario", IdUsuario },
                { "dataAlarme", DataAlarme },
            };

        #region metodos

        public async Task<bool> Salvar()
        {
            try
            {
                //lembretes/id_usuario/id_lembrete
                await GetFirebase.GetClient
                    .Child(GetFirebase.Child.USUARIO_LEMBRETES)
                    .Child(idUsuario)
                    .Child(id)
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
                await GetFirebase.GetClient
                    .Child(GetFirebase.Child.USUARIO_LEMBRETES)
                    .Child(idUsuario)
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

        public static async Task<List<Lembrete>> BaixarLista(string id_usuario)
        {
            var items = new List<Lembrete>();
            try
            {
                //lembretes/id_usuario
                string path = GetFirebase.Child.USUARIO_LEMBRETES;
                var data = await GetFirebase.GetClient.Child(path).Child(id_usuario).OnceAsync<Lembrete>();

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

        #endregion

        #region get set

        public string id { get => Id ?? ""; set => Id = value; }
        public string titulo { get => Titulo ?? ""; set => Titulo = value; }
        public string texto { get => Texto ?? ""; set => Texto = value; }
        public bool isFixado { get => IsFixado; set => IsFixado = value; }
        public bool isAlarme { get => IsAlarme; set => IsAlarme = value; }
        public string idUsuario { get => IdUsuario ?? ""; set => IdUsuario = value; }
        public DateTime dataAlarme { get => DataAlarme; set => DataAlarme = value; }

/*
        public DateTime GetData_Alarme()
        {
            return dataAlarme;
        }

        public void SetData_Alarme(DateTime value)
        {
            dataAlarme = value;
        }

        public bool GetAlarme()
        {
            return isAlarme;
        }

        public void SetAlarme(bool value)
        {
            isAlarme = value;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string value)
        {
            titulo = value;
        }

        public string GetTexto()
        {
            return texto;
        }

        public void SetTexto(string value)
        {
            texto = value;
        }

        public bool GetFixado()
        {
            return isFixado;
        }

        public void SetFixado(bool value)
        {
            isFixado = value;
        }

        public string GetId_usuario()
        {
            return idUsuario;
        }

        public void SetId_usuario(string value)
        {
            idUsuario = value;
        }
*/
        #endregion

    }
}
