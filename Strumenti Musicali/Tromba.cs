using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Strumenti_Musicali
{
    internal class Tromba : Fiato, ISuona
    {
        [JsonConstructorAttribute]
        public Tromba(string nome, List<Spartito> spartiti)
        {
            Nome = nome;
            Spartiti = spartiti;
        }

        public Tromba(string nome) : this(nome, new List<Spartito>()) { }


        //public Tromba() : this("Tromba") { }

        public void Suona()
        // La tromba può suonare tutti gli spartiti
        {
            StringBuilder str = new StringBuilder($"{ToString()} :\n");
            foreach (Spartito i in Spartiti)
            {
                str.Append($"{i};\n");
            }
            Console.WriteLine(str.ToString()); 
        }
    }
}
