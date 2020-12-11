using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using MultMap.Auxiliar;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MultMap.Modelo
{
    public class ErroLog
    {
        private const string TAG = "ErroLog";
        private static FirebaseClient firebase = GetFirebase.GetServer;
        private static FirebaseStorage firebaseS = GetFirebase.GetStorageServer;
        private static Random random = new Random();

        public ErroLog(string mac, string tag, string titulo, string mensagem = null, string dados = null)
        {
            this.endereco_mac = mac;
            this.tag = tag;
            this.titulo = titulo;
            this.mensagem = mensagem;
            this.dados = dados;
        }

        public async Task Enviar()
        {
            var path = "Log\\" + Import.Get.RandomString(random.Next(10)) + ".txt";
            try
            {
                var enviar = await firebase
                    .Child(GetFirebase.Child.APPS)
                    .Child(GetApplication.AppName)
                    .Child(GetFirebase.Child.LOGS)
                    .OnceSingleAsync<bool>();

                if (enviar)
                {
                    if (!Directory.Exists("Log"))
                        Directory.CreateDirectory("Log");
                    var texto = new string[4];
                    if(tag != null) texto[0] = tag;
                    if (titulo != null) texto[1] = titulo;
                    if (mensagem != null) texto[2] = mensagem;
                    if (dados != null) texto[3] = dados;

                    File.WriteAllLines(@path, texto);
                    var file = File.Open(path, FileMode.Open);
                    await firebaseS
                    .Child(GetFirebase.Child.APPS)
                        .Child(GetApplication.AppName)
                        .Child(GetFirebase.Child.LOGS)
                        .Child(endereco_mac)
                        .Child(tag)
                        .Child(Import.Get.DataHora + ".txt")
                        .PutAsync(file);
                    file.Close();
                    file.Dispose();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex, enviarErro: false);
            }
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex, enviarErro: false);
            }
        }

        public string endereco_mac { get; private set; }
        public string tag { get; private set; }
        public string titulo { get; private set; }
        public string mensagem { get; private set; }
        public string dados { get; private set; }

    }
}
