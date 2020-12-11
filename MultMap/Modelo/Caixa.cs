using System;
using System.Collections.Generic;
using MultMap.Auxiliar;
using Firebase.Database.Query;
using System.Threading.Tasks;

namespace MultMap.Modelo
{
    public class Caixa
    {
        private const string TAG = "Caixa";

        public Caixa()
        {
            viabilidades = new List<Grafico>();
            cancelamentos = new List<Grafico>();
            clientes = new List<string>();
        }

        public enum PonType
        {
            GPon,
            PacPon
        }

        #region variaveis

        private bool IsNova { get; set; }
        private bool IsEditado { get; set; }
        private bool IsExcluido { get; set; }
        private bool IsEmManutencao { get; set; }
        private bool HasViabilidade { get; set; }
        private bool HasCancelamento { get; set; }

        private string Id { get; set; }
        private string Status { get; set; }
        private string Novo_id { get; set; }
        private string Nome { get; set; }
        private int Portas { get; set; }
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        private string Data { get; set; }
        private string Id_usuario { get; set; }
        private string Motivo { get; set; }

        private List<Grafico> Viabilidades { get; set; }
        private List<Grafico> Cancelamentos { get; set; }
        private List<string> Clientes { get; set; }
        private Endereco Endereco { get; set; }
        private Usuario _usuario { get; set; }
        private PonType Pon { get; set; }

        #endregion

        /// <summary>
        /// Somente esses dados serão salvos no firebase
        /// </summary>
        private Dictionary<string, dynamic> toJson() => new Dictionary<string, dynamic>
            {
                { "nome", Nome },
                { "pon", Pon },
                { "novo_id", Novo_id },
                { "portas", Portas },
                { "latitude", Latitude },
                { "longitude", Longitude },
                { "data", Data },
                { "id_usuario", Id_usuario },
                { "motivo", Motivo },
                { "isExcluido", IsExcluido },
                { "viabilidades", Viabilidades },
                { "cancelamentos", Cancelamentos },
                { "clientes", Clientes },
                { "endereco", Endereco },
                { "isEmManutencao", IsEmManutencao }
            };

        #region metodos

        public async Task<bool> Salvar(bool excluidas = false)
        {
            try
            {
                string path = excluidas ? GetFirebase.Child.CAIXAS_EXCLUIDAS : GetFirebase.Child.CAIXAS;
                await GetFirebase.GetClient.Child(path).Child(id).PutAsync(toJson());
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }
        public async Task<bool> Delete(bool excluidas = false)
        {
            try
            {
                isExcluido = !excluidas;
                await Salvar(excluidas);

                string path = excluidas ? GetFirebase.Child.CAIXAS_EXCLUIDAS : GetFirebase.Child.CAIXAS;
                await GetFirebase.GetClient.Child(path).Child(id).DeleteAsync();
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }


        public static async Task<List<Caixa>> BaixarLista(bool excluidas = false)
        {
            var items = new List<Caixa>();

            string path = GetFirebase.Child.CAIXAS;
            if (excluidas)
                path = GetFirebase.Child.CAIXAS_EXCLUIDAS;

            try
            {
                var data = await GetFirebase.GetClient
                     .Child(path).OnceAsync<Caixa>();

                // Atribuir o ID na caixa
                foreach (var item in data)
                {
                    if (item.Object.endereco == null) continue;

                    item.Object.id = item.Key;
                    item.Object.Preparar();
                    items.Add(item.Object);
                }
                Log.Msg(TAG, "BaixarLista", "OK: IsExcluidos(" + excluidas.ToString() + ")", items.Count);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return items;
        }


        public static Caixa NewItem(Caixa c)
        {
            Caixa c2 = new Caixa();
            try
            {
                c2.id = c.id;
                c2.pon = c.pon;
                c2.nome = c.nome;
                c2.data = c.data;
                c2.status = c.status;
                c2.portas = c.portas;
                c2.motivo = c.motivo;
                c2.novo_id = c.novo_id;
                c2.endereco = c.endereco;
                c2.latitude = c.latitude;
                c2.longitude = c.longitude;
                c2.usuario = c.usuario;
                c2.id_usuario = c.id_usuario;

                c2.isExcluido = c.isExcluido;
                c2.isEditado = c.isEditado;
                c2.isEmManutencao = c.isEmManutencao;
                c2.isNovo = c.isNovo;

                c2.hasViabilidade = c.hasViabilidade;
                c2.hasCancelamento = c.hasCancelamento;

                c2.cancelamentos.AddRange(c.cancelamentos);
                c2.viabilidades.AddRange(c.viabilidades);
                c2.clientes.AddRange(c.clientes);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return c2;
        }

        /// <summary>
        /// Insere o STATUS e o USUÁRIO que alterou este item
        /// </summary>
        public void Preparar()
        {
            try
            {
                isNovo = true;

                bool cheio = clientes.Count == portas;
                status = (cheio ? "CHEIO" : "LIVRE");
                Usuario aux = GetUsuarios.Get(id_usuario);
                //if (aux == null)
                //    aux = await Usuario.Baixar(GetId_usuario());
                if (aux == null)
                    aux = new Usuario();
                usuario = aux;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        public void AddViabilidade(Grafico value)
        {
            var s = viabilidades.Find(x => x.data == value.data);
            if (s == null)
            {
                Log.Msg("Caixa", "Novo");
                viabilidades.Add(value);
            }
            else
            {
                Log.Msg("Caixa", "Atualizar");
                value.valor += s.valor;
                viabilidades[viabilidades.IndexOf(s)] = value;
            }
        }
        public void AddCancelamento(Grafico value)
        {
            cancelamentos.Add(value);
        }

        #endregion

        #region get set

        public string id { get => Id; set => Id = value; }
        public string status { get => Status ?? ""; set => Status = value; }
        public Usuario usuario { get => _usuario; set => _usuario = value; }

        public PonType pon { get => Pon; set => Pon = value; }
        public string novo_id { get => Novo_id ?? ""; set => Novo_id = value; }
        public string nome { get => Nome ?? ""; set => Nome = value; }
        public int portas { get => Portas; set => Portas = value; }
        public double latitude { get => Latitude; set => Latitude = value; }
        public double longitude { get => Longitude; set => Longitude = value; }
        public string data { get => Data ?? ""; set => Data = value; }
        public string id_usuario { get => Id_usuario ?? ""; set => Id_usuario = value; }
        public string motivo { get => Motivo ?? ""; set => Motivo = value; }

        public bool isExcluido { get => IsExcluido; set => IsExcluido = value; }
        public bool hasCancelamento { get => HasCancelamento; set => HasCancelamento = value; }
        public bool hasViabilidade { get => HasViabilidade; set => HasViabilidade = value; }
        public bool isNovo { get => IsNova; set => IsNova = value; }
        public bool isEditado { get => IsEditado; set => IsEditado = value; }
        public bool isEmManutencao { get => IsEmManutencao; set => IsEmManutencao = value; }

        public List<Grafico> viabilidades
        {
            get
            { 
                if (Viabilidades == null)
                    Viabilidades = new List<Grafico>(); 
                return Viabilidades;
            }
            set => Viabilidades = value;
        }
        public List<Grafico> cancelamentos
        {
            get
            {
                if (Cancelamentos == null)
                    Cancelamentos = new List<Grafico>();
                return Cancelamentos;
            }
            set => Cancelamentos = value;
        }
        public List<string> clientes
        {
            get
            {
                if (Clientes == null)
                    Clientes = new List<string>();
                return Clientes;
            }
            set => Clientes = value;
        }
        public Endereco endereco { get => Endereco; set => Endereco = value; }

        #endregion

    }
}
