using System;
using System.Collections.Generic;
using System.Linq;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            
            // Create a list
            Enumerable.Range(1,20).ToList().ForEach(r => {
                randomNumbers.Add(random.Next(1,50));
            });

            //With the resulting List, populate a new List that contains each number squared. For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.
            List<int> squaredRandoms = randomNumbers.Select(r => r * r).ToList();
            
            // Remove the odd values from the list
            squaredRandoms.RemoveAll(s => s % 2 != 0);

            // Populate the list with the squared values
            randomNumbers.ForEach(r => Console.WriteLine("random: {0}, squared: {1}",r, r * r));
            
            // Populate the list of squared but without the odd values
            squaredRandoms.ForEach(r => Console.WriteLine(r));
            


        }
    }
}
