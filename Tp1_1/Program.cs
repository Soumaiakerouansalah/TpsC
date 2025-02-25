using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_1
{
    class Program
    {
        static void Main()
        {
            Repertoire monRepertoire = new Repertoire("Documents");

            // Ajout de fichiers
            monRepertoire.Ajouter(new Fichier("rapport", "pdf", 500));
            monRepertoire.Ajouter(new Fichier("presentation", "ppt", 1200));
            monRepertoire.Ajouter(new Fichier("notes", "txt", 300));
            monRepertoire.Ajouter(new Fichier("manuel", "pdf", 800));

            // Affichage du contenu du répertoire
            monRepertoire.Afficher();

            // Recherche d'un fichier
            int index = monRepertoire.Rechercher("rapport");
            Console.WriteLine(index != -1 ? "Fichier trouvé à l'index " + index : "Fichier non trouvé.");

            // Affichage des fichiers PDF
            monRepertoire.AfficherPDFs();

            // Suppression d'un fichier
            monRepertoire.Supprimer("notes");

            // Renommage d'un fichier
            monRepertoire.Renommer("presentation", "slides");

            // Modification de la taille d'un fichier
            monRepertoire.Modifier("manuel", 900);

            // Affichage final
            monRepertoire.Afficher();

            // Taille totale du répertoire
            Console.WriteLine($"Taille totale du répertoire: {monRepertoire.GetTaille()} MO");
        }
    }
}
