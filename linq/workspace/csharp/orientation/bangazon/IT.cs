using System;

namespace bangazon
{
    partial class Program
    {
        public class IT : Department, ISecurityRequired
        {
            private int _computer_count;

            public int ComputerCount {get {
                return _computer_count;
            }}

            public int minAccessLevelToEnter { get; set; }

            public IT(string name, string supervisor, int employees, int computerCount) : base(name, supervisor, employees)
            {
                _computer_count = computerCount;
            }
            
            public void Backup() {
                Random rand = new Random();
                int computersBackedUp = rand.Next(1, _computer_count);
                Console.WriteLine($"{computersBackedUp} computers backed up");
            }

            public override void Meet() => Console.WriteLine("Meet in the IT-T2");
        
            public override string ToString() 
            {
                return $"{Name} {Supervisor} {EmployeeCount} with {ComputerCount} computers";
            }

            public bool validAccess(int accessLevel)
            {
                return accessLevel >= minAccessLevelToEnter;
            }

        }

    }
}

