using System.Configuration;

namespace Meu_Terminal
{
    public static class CN_ConexaoDinamica
    {
        public static bool Criarconexao(string server, string database, string usuario, string senha, bool salvar)
        {
            string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", server, database, usuario, senha);
            /*
            if (CDConexao.AbrirConexao(connectionString))
            {
                //if (salvar)
                  //  SalvarConexao("bd", connectionString);
                return true;
            }
            else//*/
                return false;
        }
        /*
        private static void SalvarConexao(string sconexao, string valor)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
             
            config.ConnectionStrings.ConnectionStrings[sconexao].ConnectionString = valor;
            config.ConnectionStrings.ConnectionStrings[sconexao].ProviderName = "MySql.Data.MySqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }//*/
    }
}
