namespace MultMap.Modelo
{
    public class Endereco
    {
        private string Estado { get; set; }
        private string Cidade { get; set; }
        private string Bairro { get; set; }
        private string Rua { get; set; }

        public string estado { get => Estado ?? ""; set => Estado = value; }
        public string cidade { get => Cidade ?? ""; set => Cidade = value; }
        public string bairro { get => Bairro ?? ""; set => Bairro = value; }
        public string rua { get => Rua ?? ""; set => Rua = value; }
    }
}
