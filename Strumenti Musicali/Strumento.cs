using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Strumenti_Musicali
{
    internal class Strumento : ISalvataggio
    {
        public string Nome { get; protected set; }
        public List<Spartito> Spartiti { get; protected set; } 
        // tecnicamente questo è un attributo; vale lo stesso?

        public void Carica()
        // un po sporco ma spero vada bene(?)
        {
            string text = File.ReadAllText($"{Nome}.json");
            Strumento temp = (Strumento) JsonSerializer.Deserialize(text,GetType());
            this.Spartiti = temp.Spartiti;
            return;
        }
        
        
        public void Salva()
        // spero di non aver completamente frainteso la consegna
        { 
            string text = JsonSerializer.Serialize(this);
            File.WriteAllText($"{Nome}.json", text);
        }

        public override string ToString()
        {
            string s = Spartiti.Count == 1 ? "brano" : "brani";
            // mi da fastidio quando non viene gestito

            return $"{Nome} ({Spartiti.Count} {s})";
        }

        
    }
}
