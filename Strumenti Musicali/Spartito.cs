using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Strumenti_Musicali
{
    internal class Spartito
    {
        [JsonConstructorAttribute]
        public Spartito(string nome, string note, int durataMinuti) 
        {
            Nome = nome;
            Note = note;
            DurataMinuti = durataMinuti;
        }
        public string Nome {get;  private set;}
        public string Note { get; private set;}
        public int DurataMinuti { get; private set;}

        public override string ToString()
        {
            return $"{Nome}, Durata {DurataMinuti} minuti : {Note}";
        }
    }
}
