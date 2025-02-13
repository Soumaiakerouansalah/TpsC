using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tps
{
     class Employee
    {
        String nom;
        double salaire;
        String Poste;
        DateTime dateEmbauche;

        public Employee(string nom, double salaire, string poste, DateTime dateEmbauche)
        {
            this.nom = nom;
            this.salaire = salaire;
            Poste = poste;
            this.dateEmbauche = dateEmbauche;
        }
        public String getNom() { return nom; }
    public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public String getPoste() { return Poste; }
        public DateTime getDateEmbauche() { return dateEmbauche; }

        public override string ToString()
        {
            return $"Nom: {nom}, Salaire: {Salaire}, Poste: {Poste}, Date d'embauche: {dateEmbauche.ToShortDateString()}";
        }
    }
}
