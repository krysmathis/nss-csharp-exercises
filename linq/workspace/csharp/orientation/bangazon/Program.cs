using System;
using System.Collections.Generic;

namespace bangazon
{
    partial class Program
    {
        static void Main(string[] args)
        {
             List<Department> departments = new List<Department>();

            // Create some instances
            HumanResources hr = new HumanResources("HR", "Amy Schumer", 2);
            IT it = new IT("IT", "Lance Carrington", 2,5);
            Sales sales = new Sales("Sales","Carly Fiorini", 25, 5);
            hr.AddPolicy("Vacaction", "Unlimited vacation for all!");
            it.Backup();
            sales.ThrowDart();

            // Add derived departments to the list
            departments.Add(hr);
            departments.Add(it);
            departments.Add(sales);
            
            double baseBudget = 75000.00;
            // Some departments get the base $75,000.00 budget, but others
            // will be adjusted up or down depending on the logic you wrote
            // in each class.

            // Iterate over all items in the list and output a string 
            // representation of the class
            foreach(Department d in departments)
            {   
                d.SetBudget(baseBudget);
                Console.WriteLine($"{d.ToString()}");
                d.Meet();
            }

            

            System.Console.WriteLine(@"
***********************************************
The eating employee..."); 

            List<Employee> companions = new List<Employee>() {
                new Employee("Jeff", "Lebowski"),
                new Employee("Walter", "Socheck"),
                new Employee("Dude", "Duderino if you are not into the brevity thing")
            };

            Employee krys = new Employee("Krys", "Mathis");
            krys.eat();
            krys.eat("Bananas");
            krys.eat(companions);
            krys.eat("BBQ", companions);


            // Final Output
            System.Console.WriteLine(@"
***********************************************
Employed employees..."); 
            hr.minAccessLevelToEnter = 5;
            hr.AddEmployee(new HumanResourceEmployees("Andri", "Alexandrou"));
            hr.AddEmployee(new HumanResourceEmployees("Wayne", "Hutchinson"));
            hr.AddEmployee(new HumanResourceEmployees("Sephora", "Rodriguez"));
            HumanResourceEmployees Matt = new HumanResourceEmployees("Matt", "Qualls");
            Matt.AddHandicap("Chronic Migraines");
            hr.AddEmployee(Matt);


            Console.WriteLine($"\nDepartment: {hr.Name} Access Level: {hr.minAccessLevelToEnter} Required");
            
            foreach (HumanResourceEmployees emp in hr.Employees) {
                Console.WriteLine($"{emp} {String.Join(',',emp.Handicaps)}");
            }
            
            it.minAccessLevelToEnter = 8;
            Console.WriteLine($"{Environment.NewLine}Department: {it.Name} Access Level: {it.minAccessLevelToEnter} Required");
            it.AddEmployee(new ITEmployee("Caitlin", "Stein", "Day", 8));
            it.AddEmployee(new ITEmployee(
                firstName:"Ray", 
                lastName: "Tenay", 
                shift:"Night", 
                accessLevel: 7
            ));

            foreach (ITEmployee emp in it.Employees) {
                Console.WriteLine($"{emp} Shift: {emp.Shift} ValidAccess: {it.validAccess(emp.AccessLevel)}");
            }

        }
    }
}

