using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    public class Dictionnaire : Document
    {
        public string Langue { get; set; }
        public int NombreDefinitions { get; set; }

        public Dictionnaire(string titre, string langue, int nombreDefinitions) : base(titre)
        {
            Langue = langue;
            NombreDefinitions = nombreDefinitions;
        }

        public override string Description()
        {
            return $"Dictionnaire: {Titre}, Langue: {Langue}, Définitions: {NombreDefinitions}";
        }
    }
}
