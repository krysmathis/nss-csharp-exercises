using System;
using System.Collections.Generic;

namespace bangazon
{
    partial class Program
    {
        public class Department {

            // Fields
            private string _name;
            private string _supervisor;
            private int _employee_count;
            private List<Employee> _employees;

            public List<Employee> Employees {get => _employees;}
            
            private double _budget;

            // Properties
            public string Name { get=> _name; }
            public string Supervisor { get => _supervisor; }
            public int EmployeeCount { get => _employee_count; }
            public double Budget { 
                get => _budget; 
                set {_budget = value;} 
            }


            // Constructor
            public Department(string name, string supervisor, int employees) {
                    _name = name;
                    _supervisor = supervisor;
                    _employee_count = employees;
                    _employees = new List<Employee>();
                }
            public virtual void Meet() => Console.WriteLine("Meet in the atrium.");
           

            public void AddEmployee(Employee employee) {
                _employees.Add(employee);
            }

            public void RemoveEmployee(Employee employee) {
                _employees.Remove(employee);
            }

            public virtual void SetBudget(double budget) {
                this.Budget = budget;
                System.Console.WriteLine($"Our budget is {Budget}");
            }

        }

    }
}

