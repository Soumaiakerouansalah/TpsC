using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    internal class Program
    {
        static void Main()
        {
            Biblio maBibliotheque = new Biblio();

            Livre livre1 = new Livre("Le C# Moderne", "John Doe", 300);
            Dictionnaire dictionnaire1 = new Dictionnaire("Dictionnaire Français", "Français", 10000);

            maBibliotheque.AjouterDocument(livre1);
            maBibliotheque.AjouterDocument(dictionnaire1);

         
            Console.WriteLine($"Nombre de livres: {maBibliotheque.NombreDeLivres()}");
            maBibliotheque.AfficherDictionnaires();
            maBibliotheque.TousLesAuteurs();
            maBibliotheque.ToutesLesDescriptions();
        }
    }
}
