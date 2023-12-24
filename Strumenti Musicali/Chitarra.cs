using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Strumenti_Musicali
{
    internal class Chitarra : Corda, ISuona
    {
        [JsonConstructorAttribute]
        public Chitarra(string nome, List<Spartito> spartiti)
        {
            Nome = nome;
            Spartiti = spartiti;

        }

        public Chitarra(string nome) : this(nome, new List<Spartito>()) { }


        public Chitarra() : this("Chitarra") { }

        public void Suona(int indice)
        // La chitarra può suonare solo uno spartito
        {

            var str = $"{ToString()} : {Spartiti[indice]}";
            // La Microsoft dice che va bene usare var in questi casi
            Console.WriteLine(str);
        }
    }
}
