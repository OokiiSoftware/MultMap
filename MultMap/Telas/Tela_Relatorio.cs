using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MultMap.Auxiliar;
using MultMap.Modelo;
using MultMap.Modelo.Relatorios;

namespace MultMap.Telas
{
    public partial class Tela_Relatorio : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Relatorio";

        private readonly List<Caixa> caixas;
        private readonly List<Caixa_Alterada> caixas_Alteradas;

        private readonly string classeName;

        enum GraficType { Viabilidades, Cancelamentos, Tudo }

        #endregion

        /// <summary>
        /// Caixas Normais
        /// </summary>
        public Tela_Relatorio(List<Caixa> caixas, bool incluirClientes, string classeName)
        {
            InitializeComponent();
            this.caixas = caixas;
            this.classeName = classeName;
            RelatorioCaixas(incluirClientes);
        }

        /// <summary>
        /// Caixas Alteradas
        /// </summary>
        public Tela_Relatorio(List<Caixa_Alterada> caixas)
        {
            InitializeComponent();
            this.caixas_Alteradas = caixas;
            RelatorioCaixasAlteradas();
        }

        /// <summary>
        /// Graficos (Viabilidades e Cancelamentos)
        /// </summary>
        /// <param name="via">Incluir Viabilidades?</param>
        /// <param name="can">Incluir Cancelamentos?</param>
        /// <param name="inicio">Data de Inicio</param>
        /// <param name="fim">Data do Fim</param>
        public Tela_Relatorio(List<Caixa> caixas, bool via, bool can, DateTime inicio, DateTime fim)
        {
            InitializeComponent();
            this.caixas = caixas;
            GraficType graficType = GraficType.Tudo;
            if (via && can)//viabilidade e cancelamento
                graficType = GraficType.Tudo;
            else
            {
                if (via) graficType = GraficType.Viabilidades;
                else if (can) graficType = GraficType.Cancelamentos;
            }
            CriarGrafico(graficType, inicio, fim);
        }

        #region

        private void RelatorioCaixas(bool incluirClientes)
        {
            try
            {
                var relatorioFile = string.Format("{0}.Auxiliar.RelatorioImprimir1.{1}.rdlc", GetApplication.AppName, (incluirClientes ? "1" : "2"));

                RV_Relatorio.LocalReport.ReportEmbeddedResource = relatorioFile;

                PrepararDadosRelatorio();

                var caixasR = CaixaR.ConverteParaRelatorio(caixas);
                var ds = new ReportDataSource("CaixaDS", caixasR);
                RV_Relatorio.LocalReport.DataSources.Add(ds);
                ds.Value = caixasR;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            ConcluirPreparo();
        }

        private void RelatorioCaixasAlteradas()
        {
            try
            {
                RV_Relatorio.LocalReport.ReportEmbeddedResource = GetApplication.AppName + ".Auxiliar.RelatorioImprimir2.rdlc";

                PrepararDadosRelatorio();

                var caixasR = CaixaR.ConverteParaRelatorio(caixas_Alteradas);
                var ds = new ReportDataSource("CaixaDS", caixasR);
                RV_Relatorio.LocalReport.DataSources.Add(ds);
                ds.Value = caixasR;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            ConcluirPreparo();
        }

        private void PrepararDadosRelatorio()
        {
            try
            {
                RV_Relatorio.LocalReport.DataSources.Clear();
                RV_Relatorio.PageCountMode = PageCountMode.Actual;

                // Preciso de um obj do tipo List pra add no dataSource do relatorio
                var listDados = new List<RelatorioDados>
                {
                    // Contém o titulo do relatorio e etc..
                    new RelatorioDados(classeName)
                };
                var dsDados = new ReportDataSource("Dados", listDados);
                RV_Relatorio.LocalReport.DataSources.Add(dsDados);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }


        private void CriarGrafico(GraficType graficType, DateTime inicio, DateTime fim)
        {
            PrepararDadosGrafico(graficType, inicio, fim);

            try
            {
                var caixasR2 = new List<GraficoR2>();
                ReportDataSource ds;
                switch (graficType)
                {
                    case GraficType.Tudo:
                        {
                            var caixasR = new List<GraficoR>();
                            RV_Relatorio.LocalReport.ReportEmbeddedResource = GetApplication.AppName + ".Auxiliar.RelatorioGrafico1.1.rdlc";

                            foreach (var item in caixas)
                            {
                                if (item.viabilidades.Count > 0 || item.cancelamentos.Count > 0)
                                    caixasR.Add(new GraficoR(item, inicio, fim));
                            }
                            ds = new ReportDataSource("CaixaDS", caixasR);
                            RV_Relatorio.LocalReport.DataSources.Add(ds);
                            ds.Value = caixasR;
                        }
                        break;
                    case GraficType.Viabilidades:
                        {
                            RV_Relatorio.LocalReport.ReportEmbeddedResource = GetApplication.AppName + ".Auxiliar.RelatorioGrafico1.2.rdlc";
                            caixasR2 = new List<GraficoR2>();
                            foreach (var item in caixas)
                            {
                                if (item.viabilidades.Count > 0)
                                    foreach (var grafico in item.viabilidades)
                                        if (DateTime.Parse(grafico.data) >= inicio && DateTime.Parse(grafico.data) <= fim)
                                            caixasR2.Add(new GraficoR2(grafico));
                            }
                            ds = new ReportDataSource("CaixaDS", caixasR2);
                            RV_Relatorio.LocalReport.DataSources.Add(ds);
                            ds.Value = caixasR2;
                        }
                        break;
                    case GraficType.Cancelamentos:
                        {
                            RV_Relatorio.LocalReport.ReportEmbeddedResource = GetApplication.AppName + ".Auxiliar.RelatorioGrafico1.3.rdlc";
                            caixasR2 = new List<GraficoR2>();
                            foreach (var item in caixas)
                            {
                                if (item.cancelamentos.Count > 0)
                                    foreach (var grafico in item.cancelamentos)
                                        if (DateTime.Parse(grafico.data) >= inicio && DateTime.Parse(grafico.data) <= fim)
                                            caixasR2.Add(new GraficoR2(grafico));
                            }
                            ds = new ReportDataSource("CaixaDS", caixasR2);
                            RV_Relatorio.LocalReport.DataSources.Add(ds);
                            ds.Value = caixasR2;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            ConcluirPreparo();
        }

        private void PrepararDadosGrafico(GraficType graficType, DateTime inicio, DateTime fim)
        {
            try
            {
                RV_Relatorio.LocalReport.DataSources.Clear();
                RV_Relatorio.PageCountMode = PageCountMode.Actual;

                // Preciso de um obj do tipo List pra add no dataSource do relatorio
                var listDados = new List<RelatorioDados>
                {
                    // Contém o titulo do relatorio e etc..
                    new RelatorioDados("", inicio, fim)
                };
                string titulo = "";

                switch (graficType)
                {
                    case GraficType.Tudo:
                        titulo = "Relatório Gráfico de Viabilidades e Cancelamentos";
                        break;
                    case GraficType.Viabilidades:
                        titulo = "Relatório Gráfico de Viabilidades";
                        break;
                    case GraficType.Cancelamentos:
                        titulo = "Relatório Gráfico de Cancelamentos";
                        break;
                }

                listDados[0].TituloR = titulo;
                var dsDados = new ReportDataSource("Dados", listDados);
                RV_Relatorio.LocalReport.DataSources.Add(dsDados);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }


        private void ConcluirPreparo()
        {
            try
            {
                RV_Relatorio.SetDisplayMode(DisplayMode.PrintLayout);
                RV_Relatorio.LocalReport.Refresh();
                RV_Relatorio.RefreshReport();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

    }

}

