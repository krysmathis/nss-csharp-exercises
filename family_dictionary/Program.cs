using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Carrie"},
                {"age", "43"}
            });

            myFamily.Add("son", new Dictionary<string, string>(){
                {"name", "Jack"},
                {"age", "8"}
            });
            
            myFamily.Add("daughter", new Dictionary<string, string>(){
                {"name", "Elsah Mae"},
                {"age", "3"}
            });

            // Iterate over the family and produce the output
            foreach (KeyValuePair<string,Dictionary<string,string>> familyMember in myFamily) {
                string relationship = familyMember.Key;
                Dictionary<string,string> details = familyMember.Value;
                // output
                Console.WriteLine($"{details["name"]} is my {relationship} and is {details["age"]} years old");
            }
        }
    }
}
