using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_1
{
 
   
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee employee1 = new Employee("MALAK", 3000, "manager", new DateTime(2023, 04, 24));

                GestionEmployes Emps = new GestionEmployes();

                Emps.ajouterEmp(new Employee("soumaia", 3000, "manager", new DateTime(2023, 04, 24)));
                Emps.ajouterEmp(new Employee("safae", 4000, "manager", new DateTime(2023, 04, 24)));
                Emps.ajouterEmp(employee1);

            }
        }

    
}
