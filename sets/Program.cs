using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
       

        static void Main(string[] args)
        {

            void printSet(string header, HashSet<string> set) {
                Console.WriteLine("\n" + header);
                int c = 0;
                foreach (string v in set) {
                    c++;
                    Console.WriteLine($"{c}. {v}");
                }       
            }

            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Nissan Maxima");
            Showroom.Add("Volkswagen Thing");
            Showroom.Add("Honda Accord");
            Showroom.Add("Mercedes Benz G-Class");

            Showroom.Add("Mercedes Benz G-Class");
            
            Console.WriteLine("Showroom Count: {0}\n", Showroom.Count);
            printSet("Initial Showroom: ", Showroom);

            // create a used car lot
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Nissan Altima");
            UsedLot.Add("Honda CRV");

            printSet("UsedLot: ", UsedLot);
            // combine the showroom and the used lot
            Showroom.UnionWith(UsedLot);

            // you sold a car
            Showroom.Remove("Mercedes Benz G-Class");
            printSet("Sold the Mercedes And Combined Used Lot with Showroom: ", Showroom);

            // Aquiring More Cars
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Volkswagen Thing");
            Junkyard.Add("Honda Accord");
            Junkyard.Add("Chevrolet Camaro");
            Junkyard.Add("Honda Civic");
            printSet("Junkyard: ", Junkyard);

            Showroom.IntersectWith(Junkyard);
            printSet("Junkyard IntersectWith Showroom: ", Junkyard);

            printSet("Showroom before Aquisition", Showroom);

            Showroom.UnionWith(Junkyard);
            printSet("Showroom Union With Junkyard: ", Showroom);

            Junkyard.Remove("Nissan Maxima");
            printSet("Inventory After Aquisition: ", Showroom);

        }
    }
}
