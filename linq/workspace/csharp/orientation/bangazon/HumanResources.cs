using System;
using System.Collections.Generic;

namespace bangazon
{
    partial class Program
    {

        public class HumanResources: Department, ISecurityRequired
        {
                /*
                    Now this syntax looks very strange! What's going on here?
                    To relate back to your JavaScript knowledge, this code
                    is creating an array that holds objects.

                    The keywords are telling the compiler that each item in 
                    the List will have a key of type string, and a value of 
                    type string.

                    For example, it would look like this in JavaScript.
                    [{'vacation':'Unlimited vacation for everyone!!'}]
                */
            private Dictionary<string, string> _policies = new Dictionary<string, string>();

            public int minAccessLevelToEnter { get; set; }

            /*
                Since the parent class defined a constructor with three
                arguments, the derived class must also define a constructor
                with the same signature, or arity, as the parent.

                Then, we can just pass those argument value directly to the
                parent class with the `base` keyword.
            */
            public HumanResources(string dept_name, string supervisor, int employees): base(dept_name, supervisor, employees)
                {
                }// Publicly accessible method to add an HR policy


                public override void Meet() => Console.WriteLine("Meet in the HR-T3");
                public void AddPolicy(string title, string text)
                {
                    /*
                        Talk about verbose! Every time you want to create, or
                        reference a KeyValuePair, you have to use the angle
                        brackets, and type keywords.
                    */
                    _policies.Add(title, text);

                    foreach(KeyValuePair<string, string> policy in _policies)
                    {
                        Console.WriteLine($"{policy.Value}");
                    }
                }

                // Overriding the default toString() method for each object instance
                public override string ToString() 
                {
                    return $"{Name} {Supervisor} {EmployeeCount}";
                }

            public bool validAccess(int accessLevel)
            {
                throw new NotImplementedException();
            }
        }
    }
}
