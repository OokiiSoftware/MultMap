using System;

namespace MultMap.Modelo.Relatorios
{
    public class GraficoR
    {
        public GraficoR(Caixa c, DateTime inicio, DateTime fim)
        {
            foreach (var v in c.viabilidades)
                if (DateTime.Parse(v.data) >= inicio && DateTime.Parse(v.data) <= fim)
                {
                    Data = DateTime.Parse(v.data).ToString("dd/MM/yy");
                    Viabilidades += v.valor;
                }
            foreach (var v in c.cancelamentos)
                if (DateTime.Parse(v.data) >= inicio && DateTime.Parse(v.data) <= fim)
                {
                    Data = DateTime.Parse(v.data).ToString("dd/MM/yy");
                    Cancelamentos += v.valor;
                }

            Bairro = c.endereco.bairro;
            Endereco = string.Format("{0}, {1}, {2}", c.endereco.rua, c.endereco.bairro, c.endereco.cidade);
            Caixa = c.nome;
        }

        public int Viabilidades { get; set; }
        public int Cancelamentos { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Caixa { get; set; }
        public string Data { get; set; }
    }

}
