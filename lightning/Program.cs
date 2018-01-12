using System;
using System.Collections.Generic;
using System.Linq;

namespace lightning
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Numbers from 1 to 20
            // List<int> numbers = Enumerable.Range(1,20).ToList();
            
            // numbers.Add(21);
            // numbers.Add(22);
            // numbers.Add(23);
            // numbers.Add(24);
            // numbers.Add(25);

            // List<int> moreNumbers = new List<int>() {26,27,28,29,30};
            // numbers.AddRange(moreNumbers);

            // // add range using enumerable range
            // numbers.AddRange(Enumerable.Range(31,5));

            // foreach(int num in numbers.Where(x=> x % 2 != 0)) {
            //     Console.Write(" {0} ", num);
            // }


            // //Given the following dictionary:
            // Dictionary<string, int> transports = new Dictionary<string, int>(){{"bicycle", 2}};
            // // Add some more items to the dictionary.
            // transports.Add("car", 4);
            // transports.Add("boat", 0);
            // transports.Add("train", 444);
            // // Iterate over the dictionary and write 'A ____ has ____ wheels' to the console.
            // // Each transport should be on a new line.
            // Console.WriteLine();
            // foreach(KeyValuePair<string,int> t in transports) {
            //     Console.WriteLine($"A {t.Key} has {t.Value} wheels");
            // }


            // Dictionary lightning exercise: Create 3 dictionaries
            // 1. Dictionary with a key of type string and value type of double
            Dictionary<string, double> dict1 = new Dictionary<string,double>();
            // 2. Dictionary with key of type string and value of type List<int[]>
            Dictionary<string,List<int[]>> dict2 = new Dictionary<string,List<int[]>>();
            // 3. List of dictionaries with a key of type string and a value of type dictionary with a key of type int and value of type string
            List<Dictionary<string,Dictionary<int,string>>> dict3 = new List<Dictionary<string,Dictionary<int,string>>>();

            List<int> numbers = new List<int>(){ 23, 45, 36, 39, 102, 493, 474, 34, 11, 35, 99 };

            // Using Linq...
            // 1. Find the sum of numbers
            Console.WriteLine(numbers.Sum());

            // 2. Find the average of the numbers
            Console.WriteLine(numbers.Average());

            // 3. Create a new List of numbers greater than 30
            List<int> newNumbers = numbers.Where(x => x > 30).ToList();
            Console.WriteLine(String.Join("; ", newNumbers));
        }
    }
}
