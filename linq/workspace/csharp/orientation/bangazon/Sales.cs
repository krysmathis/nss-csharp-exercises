using System;

namespace bangazon
{
    partial class Program
    {
        public class Sales : Department
        {
            private int _dartboards;
            public int Dartboards { get => _dartboards; }

            public Sales(string name, string supervisor, int employees, int dartboards) : base(name, supervisor, employees)
            {
                _dartboards = dartboards;
            }
            public override void Meet() => Console.WriteLine("Meet in the T1");
            public void ThrowDart() {

                // randomly check if the dart was a hit
                Random rand = new Random();

                // not going to store the random value because of it's limited scope
                if (rand.Next(1,10)>5) {
                    Console.WriteLine("Sales got a bullseye!");
                } else {
                    Console.WriteLine("Sales hit the wall - run!!!");
                }
            }

            public override string ToString() 
            {
                return $"{Name} {Supervisor} {EmployeeCount} with {Dartboards} dartboards with sales targets";
            }

            public override void SetBudget(double budget) {
                this.Budget += budget + 100000.00;
                Console.WriteLine($"The Sales budget is {this.Budget}");
            }
        }

    }
}

