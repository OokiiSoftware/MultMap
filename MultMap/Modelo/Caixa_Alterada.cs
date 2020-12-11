using Firebase.Database.Query;
using MultMap.Auxiliar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultMap.Modelo
{
    public class Caixa_Alterada
    {
        private const string TAG = "Caixa_Alterada";

        #region variaveis

        private string Id { get; set; }
        private string Data { get; set; }

        private bool IsNovo { get; set; }
        private bool IsEditado { get; set; }

        private List<Caixa> Caixas { get; set; }

        #endregion

        /// <summary>
        /// Somente esses dados serão salvos no firebase
        /// </summary>
        private Dictionary<string, dynamic> toJson() => new Dictionary<string, dynamic>
            {
                //{ "data", Data },
                { "caixas", Caixas }
            };

        #region metodos

        public async Task<bool> Salvar()
        {
            try
            {
                await GetFirebase.GetClient
                    .Child(GetFirebase.Child.CAIXAS_ALTERADAS)
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
                        .Child(GetFirebase.Child.CAIXAS_ALTERADAS)
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


        public static Caixa_Alterada NewItem(Caixa_Alterada item)
        {
            Caixa_Alterada newItem = new Caixa_Alterada();
            try
            {
                newItem.id = item.id;
                newItem.isNovo = item.isNovo;
                newItem.isEditado = item.isEditado;

                foreach (Caixa itemAux in item.caixas)
                {
                    itemAux.id = itemAux.novo_id;
                    newItem.caixas.Add(itemAux);
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return newItem;
        }

        public static async Task<Caixa_Alterada> Baixar(string itemID)
        {
            try
            {
                var item = new Caixa_Alterada();
                var items = await BaixarLista();
                item = items.Find(x => x.id.Equals(itemID));
                Log.Msg(TAG, "Baixar OK", item.id);
                return item;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return null;
            }
        }
        public static async Task<List<Caixa_Alterada>> BaixarLista()
        {
            var items = new List<Caixa_Alterada>();

            try
            {
                var data = await GetFirebase.GetClient
                     .Child(GetFirebase.Child.CAIXAS_ALTERADAS)
                     .OnceAsync<Caixa_Alterada>();

                foreach (var obj in data)
                {
                    obj.Object.id = obj.Key;

                    foreach (Caixa item in obj.Object.caixas)
                    {
                        item.id = item.novo_id;
                        item.Preparar();
                    }
                    items.Add(obj.Object);
                }
                Log.Msg(TAG, "BaixarLista", "OK", items.Count);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }

        /// <summary>
        /// Insere o STATUS e o USUÁRIO que alterou cada item da List caixas
        /// </summary>
        public void Preparar()
        {
            foreach (Caixa item in caixas)
                item.Preparar();
        }

        #endregion

        #region get set

        public string id { get => Id ?? ""; set => Id = value; }
        public bool isNovo { get => IsNovo; set => IsNovo = value; }
        public bool isEditado { get => IsEditado; set => IsEditado = value; }

        public string nome
        {
            get
            {
                if (caixas.Count == 0) return "Nome Indisponível";

                return GetCaixa(caixas.Count - 1).nome;
            }
        }
        public string data
        {
            get 
            {
                if (caixas.Count == 0) return "Data Indisponível";

                return GetCaixa(caixas.Count - 1).data;
            }
        }
        public List<Caixa> caixas
        {
            get
            {
                if (Caixas == null)
                    Caixas = new List<Caixa>();
                return Caixas;
            }
            set => Caixas = value;
        }

        public Caixa GetCaixa(string itemID)
        {
            return caixas.Find(x => x.id.Equals(itemID));
        }
        public Caixa GetCaixa(int position)
        {
            if (position >= caixas.Count) return null;
            return caixas[position];
        }

        /*
        public string GetId()
        {
            return id;
        }
        public void SetId(string value)
        {
            id = value;
        }

        //public string data { get => data; set => data = value; }
        
        public bool IsNova()
        {
            return IsNova;
        }
        public void SetNova(bool value)
        {
            IsNova = value;
        }

        public bool IsEditada()
        {
            return editada;
        }
        public void SetEditada(bool value)
        {
            editada = value;
        }

        public List<Caixa> Getcaixas()
        {
            if (caixas == null)
                caixas = new List<Caixa>();
            return caixas;
        }
        public void Setcaixas(List<Caixa> value)
        {
            caixas = value;
        }
*/
        #endregion

    }
}
