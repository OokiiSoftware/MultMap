using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Terminal.Auxiliar
{
    public class Validacao
    {
        private readonly FirebaseClient firebase = Import.GetFirebaseClient();

        public Validacao(Delegate @delegate)
        {
            Certificado c = firebase
                     .Child(Import.FIREBASE_CERTIFICADO)
                     .OnceAsync<Certificado>().Result.First().Object;
            
        }

    }
}
