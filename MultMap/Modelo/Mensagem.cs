namespace MultMap.Modelo
{
    public class Mensagem
    {
        //Somente as variáveis publicas são salvar no firebaseDatabase
        private string id;
        public string id_conversa { get; set; }
        public string id_remetente { get; set; }
        public string mensagem { get; set; }
        public string data_de_envio { get; set; }
        public int status { get; set; }
        public int arquivo { get; set; }

        public string GetId()
        {
            return id;
        }
        public void SetId(string v)
        {
            id = v;
        }

        public string Getid_conversa()
        {
            return id_conversa;
        }
        public void Setid_conversa(string value)
        {
            id_conversa = value;
        }

        public string Getid_remetente()
        {
            return id_remetente;
        }
        public void Setid_remetente(string value)
        {
            id_remetente = value;
        }

        public string Getmensagem()
        {
            return mensagem;
        }
        public void Setmensagem(string value)
        {
            mensagem = value;
        }

        public string Getdata_de_envio()
        {
            return data_de_envio;
        }
        public void Setdata_de_envio(string value)
        {
            data_de_envio = value;
        }

        public int Getstatus()
        {
            return status;
        }
        public void Setstatus(int value)
        {
            status = value;
        }

        public int Getarquivo()
        {
            return arquivo;
        }
        public void Setarquivo(int value)
        {
            arquivo = value;
        }
    }
}
