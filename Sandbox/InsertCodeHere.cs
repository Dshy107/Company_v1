using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            var allEmployees = new List<Employee>();
            Worker worker1 = new Worker("Bob", 2000, "TruckDriver");
           
            allEmployees.Add(worker1);
            Manager manager1 = new Manager("Troy", 2000, 100, 180);
            allEmployees.Add(manager1);
            foreach (Employee e in allEmployees)
            {
                Console.WriteLine("{0} has a salary of {1}", e.GetName(), e.GetSalaryPerMonth());
            }
            // Add you test of the Employee class and derived classes here



            // The LAST line of code should be ABOVE this line
        }
    }
}
