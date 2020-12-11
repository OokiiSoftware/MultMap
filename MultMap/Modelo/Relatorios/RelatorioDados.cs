using System;
using MultMap.Auxiliar;

namespace MultMap.Modelo.Relatorios
{
    public class RelatorioDados
    {
        public RelatorioDados(string classeName)
        {
            SetTitulo(classeName);
        }
        public RelatorioDados(string classeName, DateTime inicio, DateTime fim)
        {
            SetTitulo(classeName);

            DataInicio = inicio.ToString("dd/MM/yyyy");
            DataFim = fim.ToString("dd/MM/yyyy");
        }

        private void SetTitulo(string s)
        {
            switch (s)
            {
                case "Tela_Relatorio_Caixas":
                    TituloR = Const.RELATORIO_CAIXAS;
                    break;
                case "Tela_Historico_Exclusao":
                    TituloR = Const.RELATORIO_CAIXAS_EXCLUIDAS;
                    break;
                case "Tela_Historico_Alteracao":
                default:
                    TituloR = Const.RELATORIO_CAIXAS_ALTERADAS;
                    break;
            }
        }

        public string TituloR { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
    }
}
