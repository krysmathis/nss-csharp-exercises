using System;
using System.Collections.Generic;

namespace classes
{
    class Program {

         static void Main(string[] args) {
             
             Company KrysCo = new Company("KrysCo", DateTime.Now);
             
             Employee Krys = new Employee("Krys","CEO", DateTime.Now);
             Employee Todd = new Employee("Todd","CFO", DateTime.Now);
             Employee Korey = new Employee("Korey","COO", DateTime.Now);

            KrysCo.AddEmployee(Krys);
            KrysCo.AddEmployee(Todd);
            KrysCo.AddEmployee(Korey);

            KrysCo.ListEmployees();

         }  

    }

   public class Company {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        private List<Employee> CurrentEmployees;
        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee employee) {
            CurrentEmployees.Add(employee);
        }
        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee employee) {
            CurrentEmployees.Remove(employee);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn) {
            this.Name = name;
            this.CreatedOn  = CreatedOn;
            this.CurrentEmployees = new List<Employee>();
        }

        public void ListEmployees() => CurrentEmployees.ForEach(e => Console.WriteLine($"{e.Name} - {e.JobTitle}"));
    }

    public class Employee {
        public string Name {get; }
        public string JobTitle {get; set;}
        public DateTime StartDate {get;}

        public Employee(string name, string jobTitle, DateTime startDate) {
            this.Name = name;
            this.JobTitle = jobTitle;
            this.StartDate = startDate;
        }
    }
}
