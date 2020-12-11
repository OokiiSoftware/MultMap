using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MultMap.Auxiliar
{
    class Cript
    {
        private static Dictionary<char, Dictionary<int, string>> criptografia;
        /// <summary>
        /// Lista de digitos criptografados.
        /// </summary>
        private static Dictionary<char, Dictionary<int, string>> GetCriptografia
        {
            get
            {
                if (criptografia == null)
                {
                    string json = Encoding.UTF8.GetString(Properties.Resources.criptografia);
                    criptografia = JsonConvert.DeserializeObject<Dictionary<char, Dictionary<int, string>>>(json);
                }
                return criptografia;
            }
        }

        public static string Encript(string value = "")
        {
            if (value.Equals("")) return value;

            var digitos = GetCriptografia;
            string result = "";
            int second = DateTime.Now.Second;
            foreach (char digito in value)
            {
                if (digitos.ContainsKey(digito))
                    result += digitos[digito][second];

                // Se o usuário digitar por ex: 'aaaa' esta linha abaixo impede
                // que o mesmo valor criptografado seja usado em todos os digitos.
                second++;
                if (second == 60) second = 0;
            }
            return result;
        }
        public static string Decript(string value = "")
        {
            if (value.Equals("")) return value;

            string result = value;

            foreach (var letra in GetCriptografia)// letra contém uma coleção de 59 dados criptografados
                foreach (var numero in letra.Value)// numero (0 a 59) cada item representa 1 segundo literal do Relógio
                    if (result.Contains(numero.Value))
                        result = result.Replace(numero.Value, letra.Key.ToString());
            return result;
        }


        public static string EncriptBase64(string texto)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(texto);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string DescriptBase64(string textoCriptografado)
        {
            var base64EncodedBytes = Convert.FromBase64String(textoCriptografado);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
