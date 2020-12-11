using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using MultMap.Modelo;
using MultMap.Auxiliar;

namespace MultMap.Data
{
    class SQLite_Mensagem
    {
        private const string TAG = "SQLite_Mensagem";

        private static string NOME_BANCO = GetFirebase.usuario.id + ".db";
        private const int VERSAO_BANCO = Const.SQLITE_BANCO_DE_DADOS_VERSAO;
        private const string TABELA = "mensagens";

        private const string ID = "id";
        private const string ID_CONVERSA = "id_conversa";
        private const string ID_REMETENTE = "id_remetente";
        private const string MENSAGEM = "mensagem";
        private const string DATA = "data";
        private const string STATUS = "status";
        private const string ARQUIVO = "arquivo";

        private static SQLiteConnection conn = new SQLiteConnection("Data Source=files/" + NOME_BANCO + "; Version=" + VERSAO_BANCO);
        private static bool CriarTabela()
        {
            try
            {
                //SQLiteConnection.CreateFile(@"db_local.db");
                using (var cmd = conn.CreateCommand())
                {
                    string sql = "CREATE TABLE IF NOT EXISTS " + TABELA + " ("
                          + ID + " text,"
                          + ID_CONVERSA + " text,"
                          + ID_REMETENTE + " text,"
                          + MENSAGEM + " text,"
                          + DATA + " text,"
                          + STATUS + " integer,"
                          + ARQUIVO + " integer"
                          + ")";

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                Log.Msg(TAG, "Tabela Criada", TABELA);
                return true;
            }
            catch(Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }

        public static bool Add(Mensagem m)
        {
            try
            {
                conn.Open();
                using(var cmd = conn.CreateCommand())
                {
                    string sql = String.Format("INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}, {7}) VALUES (@id, @id_c, @id_r, @msg, @data, @s, @a)",
                    TABELA, ID, ID_CONVERSA, ID_REMETENTE, MENSAGEM, DATA, STATUS, ARQUIVO);

                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", m.GetId());
                    cmd.Parameters.AddWithValue("@id_c", m.Getid_conversa());
                    cmd.Parameters.AddWithValue("@id_r", m.Getid_remetente());
                    cmd.Parameters.AddWithValue("@msg", m.Getmensagem());
                    cmd.Parameters.AddWithValue("@data", m.Getdata_de_envio());
                    cmd.Parameters.AddWithValue("@s", m.Getstatus());
                    cmd.Parameters.AddWithValue("@a", m.Getarquivo());
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                conn.Close();
                return false;
            }
        }

        public static List<Mensagem> GetAll(string id)
        {
            List<Mensagem> ms = new List<Mensagem>();
            try
            {
                conn.Open();
                CriarTabela();
                string sql = "SELECT * FROM " + TABELA + " WHERE id_conversa='" + id + "'";
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Mensagem m = new Mensagem();
                    m.Setid_conversa(dt.Rows[i][ID_CONVERSA].ToString());
                    m.Setid_remetente(dt.Rows[i][ID_REMETENTE].ToString());
                    m.Setmensagem(dt.Rows[i][MENSAGEM].ToString());
                    m.Setdata_de_envio(dt.Rows[i][DATA].ToString());
                    m.Setstatus(Convert.ToInt32(dt.Rows[i][STATUS]));
                    m.Setarquivo(Convert.ToInt32(dt.Rows[i][ARQUIVO]));
                    Descriptografar(m);
                    ms.Add(m);
                }
                adapter.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                conn.Close();
            }
            return ms;
        }

        public static bool Update(Mensagem m)
        {
            try
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(conn))
                {
                    string sql = String.Format("UPDATE {0} SET {1}=@id_c, {2}=@id_r, {3}=@msg, {4}=@data, {5}=@s, {6}=@a WHERE {7}=@id",
                    TABELA, ID_CONVERSA, ID_REMETENTE, MENSAGEM, DATA, STATUS, ARQUIVO, ID);

                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", m.GetId());
                    cmd.Parameters.AddWithValue("@id_c", m.Getid_conversa());
                    cmd.Parameters.AddWithValue("@id_r", m.Getid_remetente());
                    cmd.Parameters.AddWithValue("@msg", m.Getmensagem());
                    cmd.Parameters.AddWithValue("@data", m.Getdata_de_envio());
                    cmd.Parameters.AddWithValue("@s", m.Getstatus());
                    cmd.Parameters.AddWithValue("@a", m.Getarquivo());
                    cmd.ExecuteNonQuery();
                };
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                conn.Close();
                return false;
            }
        }
        public static bool Remove(string data)
        {
            try
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(conn)) 
                {
                    cmd.CommandText = "DELETE FROM Clientes Where " + DATA + "=@data";
                    cmd.Parameters.AddWithValue("@data", data);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                conn.Close();
                return false;
            }
        }

        public static void Criptografar(Mensagem m)
        {
            m.Setdata_de_envio(Cript.EncriptBase64(m.Getdata_de_envio()));
            m.Setmensagem(Cript.EncriptBase64(m.Getmensagem()));
            m.Setarquivo(1);
        }
        public static void Descriptografar(Mensagem m)
        {
            m.Setdata_de_envio(Cript.DescriptBase64(m.Getdata_de_envio()));
            m.Setmensagem(Cript.DescriptBase64(m.Getmensagem()));
            m.Setarquivo(0);
        }
    }
}
