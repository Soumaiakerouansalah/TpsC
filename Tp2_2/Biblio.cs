using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    public class Biblio
    {
        private List<Document> documents;

        public Biblio()
        {
            documents = new List<Document>();
        }

        // Ajouter un document (livre ou dictionnaire)
        public void AjouterDocument(Document document)
        {
            documents.Add(document);
        }

        // Calculer le nombre de livres
        public int NombreDeLivres()
        {
            int count = 0;
            foreach (var doc in documents)
            {
                if (doc is Livre)
                {
                    count++;
                }
            }
            return count;
        }

        // Afficher tous les dictionnaires
        public void AfficherDictionnaires()
        {
            foreach (var doc in documents)
            {
                if (doc is Dictionnaire)
                {
                    Console.WriteLine(doc.Description());
                }
            }
        }

        // Afficher tous les auteurs
        public void TousLesAuteurs()
        {
            foreach (var doc in documents)
            {
                if (doc is Livre livre)
                {
                    Console.WriteLine($"Numéro: {doc.Numero}, Auteur: {livre.Auteur}");
                }
                else
                {
                    Console.WriteLine($"Numéro: {doc.Numero}, Pas d'auteur.");
                }
            }
        }

        // Afficher les descriptions de tous les documents
        public void ToutesLesDescriptions()
        {
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.Description());
            }
        }
    }
}
