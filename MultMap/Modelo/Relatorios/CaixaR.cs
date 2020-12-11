using MultMap.Auxiliar;
using System;
using System.Collections.Generic;

namespace MultMap.Modelo.Relatorios
{
    public class CaixaR
    {
        #region variaveis
        private const string TAG = "CaixaR";

        public string Nome { get; set; }
        public string Status { get; set; }
        public int Portas { get; set; }
        public int Disponivel { get; set; }
        public string Clientes { get; set; }
        public string Endereco { get; set; }
        public string GeoLocalizacao { get; set; }

        #endregion

        public CaixaR(Caixa item)
        {
            Nome = item.nome;
            Status = item.portas == item.clientes.Count ? "CHEIO" : "LIVRE";
            Portas = item.portas;
            Disponivel = item.portas - item.clientes.Count;
            for (int i = 0; i < item.clientes.Count; i++)
            {
                var numeroCaixa = Convert.ToInt32(Nome.Replace("CAIXA NAP ", ""));
                var valorLinha = item.clientes[i].Split(';');
                if(valorLinha.Length > 1)
                    Clientes += numeroCaixa +"-"+ valorLinha[0] + " - " + valorLinha[1];

                if (i < item.clientes.Count - 1)
                    Clientes += "\n";
            }

            SetEndereco(item.endereco);
            SetGeoLocalizacao(item.latitude, item.longitude);
        }

        public CaixaR(Caixa_Alterada item)
        {
            Nome = item.GetCaixa(0).nome;
            Portas = item.GetCaixa(0).portas;
            Disponivel = item.caixas.Count;

            SetEndereco(item.GetCaixa(0).endereco);
            SetGeoLocalizacao(item.GetCaixa(0).latitude, item.GetCaixa(0).longitude);
        }

        #region metodos

        private void SetGeoLocalizacao(double lat, double lng)
        {
            GeoLocalizacao = string.Format("{0}, {1}", lat, lng);
        }

        private void SetEndereco(Endereco e)
        {
            Endereco = string.Format("{0}, {1}, {2}", e.rua, e.bairro, e.cidade);

        }

        public static List<CaixaR> ConverteParaRelatorio(List<Caixa> items)
        {
            List<CaixaR> itemsAux = new List<CaixaR>();
            foreach (var item in items)
                try
                {
                    itemsAux.Add(new CaixaR(item));
                }
                catch (Exception ex)
                {
                    Log.Erro(TAG, ex);
                    continue;
                }
            return itemsAux;
        }
        public static List<CaixaR> ConverteParaRelatorio(List<Caixa_Alterada> items)
        {
            var itemsAux = new List<CaixaR>();
            foreach (var item in items)
                try
                {
                    itemsAux.Add(new CaixaR(item));
                }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return itemsAux;
        }

        #endregion
    }
}
