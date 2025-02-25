using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    public class Livre : Document
    {
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        public Livre(string titre, string auteur, int nombrePages) : base(titre)
        {
            Auteur = auteur;
            NombrePages = nombrePages;
        }

        public override string Description()
        {
            return $"Livre: {Titre}, Auteur: {Auteur}, Pages: {NombrePages}";
        }
    }
}
