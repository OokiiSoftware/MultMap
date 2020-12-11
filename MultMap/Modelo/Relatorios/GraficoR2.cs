using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultMap.Modelo.Relatorios
{
    class GraficoR2
    {
        public GraficoR2(Grafico grafico)
        {
            Data = DateTime.Parse(grafico.data).ToString("dd/MM/yy");
            valor = grafico.valor;
        }
        public string Data { get; set; }
        public int valor { get; set; }
    }
}
