using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tps
{
     class GestionEmployes
    {
        List<Employee> employees;
        public GestionEmployes()
        {
           employees = new List<Employee>();
        }

        public void ajouterEmp(Employee employee) {
            employees.Add(employee);
            Console.WriteLine("employe ajouté avec succes");
                }
        public void SupprimerEmp(Employee employe)
        {
            employees.Remove(employe);
            Console.WriteLine("employe est  suprimmé avec succes");
        }
         
        public double CalculerSalaireTotal()
        {
            if (employees.Count > 0) 
            return employees.Sum(e => e.Salaire);
            return 0;
        }

        public double CalculerSalaireMoyenne()
        {    
         
           return employees.Count > 0 ? employees.Average(e => e.Salaire) :0 ;
         

        }

        public void AfficherEmployes()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Aucun employé enregistré.");
                return;
            }

            Console.WriteLine("Liste des employés :");
            foreach (var employe in employees)
            {
                Console.WriteLine(employe);
            }
        }


    }
}
