using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strumenti_Musicali
{
    internal interface ISalvataggio
    // ho pensato che l'istruzione: "metodi per caricare e salvare la lista" intendesse di salvare in un file le istanze
    {
        void Salva();
        void Carica();
    }
}
