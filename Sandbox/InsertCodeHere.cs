using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Insert your tests here...
            var allEmployees = new List<Employee>();
            Worker worker1 = new Worker("Bill");
            allEmployees.Add(worker1);
            JuniorManager JM = new JuniorManager("Rodney", 185);
            JuniorManager JM2 = new JuniorManager("Troy", 175);
            allEmployees.Add(JM);
            allEmployees.Add(JM2);
            SeniorManager SM = new SeniorManager("James", 7);
            SeniorManager SM2 = new SeniorManager("Carlos", 5);
            allEmployees.Add(SM);
            allEmployees.Add(SM2);
            foreach (Employee e in allEmployees)
            {
                Console.WriteLine("{0} has a salary of {1} plus a bonus of {2} if they are a manager {3}", e.GetName(), e.GetSalaryPerMonth(), e.GetBonusPerMonth(), e.IsBonusPaidOut());
            }
            // The LAST line of code should be ABOVE this line
        }
    }
}
