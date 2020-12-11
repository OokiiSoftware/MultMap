namespace MultMap.Modelo
{
    public class Grafico
    {
        private int Valor { get; set; }
        private string Data { get; set; }

        public int valor { get => Valor; set => Valor = value; }
        public string data { get => Data ?? ""; set => Data = value; }
    }
}
