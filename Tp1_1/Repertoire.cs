using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_1
{
    public class Repertoire
    {
        public string Nom { get; set; }
        public int NbrFichiers { get; private set; }
        private Fichier[] fichiers;

        public Repertoire(string nom)
        {
            Nom = nom;
            fichiers = new Fichier[30]; // Tableau de 30 fichiers max
            NbrFichiers = 0;
        }

        // Afficher le contenu du répertoire
        public void Afficher()
        {
            Console.WriteLine($"Répertoire: {Nom}");
            if (NbrFichiers == 0)
            {
                Console.WriteLine("Aucun fichier dans ce répertoire.");
                return;
            }
            for (int i = 0; i < NbrFichiers; i++)
            {
                Console.WriteLine($" - {fichiers[i]}");
            }
        }

        // Rechercher un fichier par son nom
        public int Rechercher(string nom)
        {
            for (int i = 0; i < NbrFichiers; i++)
            {
                if (fichiers[i].Nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        // Ajouter un fichier
        public bool Ajouter(Fichier fichier)
        {
            if (NbrFichiers >= 30)
            {
                Console.WriteLine("Répertoire plein, impossible d'ajouter plus de fichiers.");
                return false;
            }
            fichiers[NbrFichiers] = fichier;
            NbrFichiers++;
            return true;
        }

        // Afficher les fichiers PDF
        public void AfficherPDFs()
        {
            Console.WriteLine($"Fichiers PDF dans {Nom}:");
            bool found = false;
            for (int i = 0; i < NbrFichiers; i++)
            {
                if (fichiers[i].Extension.Equals("pdf", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($" - {fichiers[i]}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Aucun fichier PDF trouvé.");
            }
        }

        // Supprimer un fichier
        public bool Supprimer(string nom)
        {
            int index = Rechercher(nom);
            if (index == -1)
            {
                Console.WriteLine("Fichier non trouvé.");
                return false;
            }
            // Décaler les fichiers pour combler le vide
            for (int i = index; i < NbrFichiers - 1; i++)
            {
                fichiers[i] = fichiers[i + 1];
            }
            fichiers[NbrFichiers - 1] = null;
            NbrFichiers--;
            Console.WriteLine($"Fichier {nom} supprimé.");
            return true;
        }

        // Renommer un fichier
        public bool Renommer(string ancienNom, string nouveauNom)
        {
            int index = Rechercher(ancienNom);
            if (index == -1)
            {
                Console.WriteLine("Fichier non trouvé.");
                return false;
            }
            fichiers[index].Nom = nouveauNom;
            Console.WriteLine($"Fichier {ancienNom} renommé en {nouveauNom}.");
            return true;
        }

        // Modifier la taille d’un fichier
        public bool Modifier(string nom, float nouvelleTaille)
        {
            int index = Rechercher(nom);
            if (index == -1)
            {
                Console.WriteLine("Fichier non trouvé.");
                return false;
            }
            fichiers[index].Taille = nouvelleTaille;
            Console.WriteLine($"Taille de {nom} modifiée à {nouvelleTaille} KO.");
            return true;
        }

        // Obtenir la taille totale du répertoire en MO
        public float GetTaille()
        {
            float tailleTotale = 0;
            for (int i = 0; i < NbrFichiers; i++)
            {
                tailleTotale += fichiers[i].Taille;
            }
            return tailleTotale / 1024; // Conversion KO → MO
        }
    }
}
