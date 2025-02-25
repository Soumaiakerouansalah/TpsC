using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_1
{
    public class Fichier
    {
        public string Nom { get; set; }
        public string Extension { get; set; }
        public float Taille { get; set; } // Taille en KO

        public Fichier(string nom, string extension, float taille)
        {
            Nom = nom;
            Extension = extension;
            Taille = taille;
        }

        public override string ToString()
        {
            return $"{Nom}.{Extension} - {Taille} KO";
        }
    }
}
