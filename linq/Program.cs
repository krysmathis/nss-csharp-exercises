using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        
        // Build a collection of customers who are millionaires
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        // Define a bank
        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }


        static void Main(string[] args)
        {
            // void printer(string header, IEnumerable col) {
            // Console.WriteLine(header.ToUpper());
                
            //     int c = 0;
            //     foreach (var v in col) {
            //         c++;
            //         if (c==1) {
            //             Console.Write(v);
            //         }
            //         else {
            //             Console.Write(",{0}",v);
            //         }
            //     }
            // Console.WriteLine();
            // }
            
            // // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            // var LFruits = from fruit in fruits
            //             where fruit.StartsWith("L")
            //             select fruit;
            
            // printer("Fruits That Start With L", LFruits);


            // // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // var fourSixMultiples = numbers.Where(x => x%4==0 || x%6==0);
            // printer("Multiples of 4 and 6", fourSixMultiples);

            // // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre" 
            // };

            // var descend = names.OrderByDescending(name => name);
            // printer("Desceding names", descend);


            // // Build a collection of these numbers sorted in ascending order
            // List<int> numbers2 = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // var sortedNumbers = numbers2.OrderBy(num => num);
            // printer("Sorted numbers", sortedNumbers);

            // // Aggregate Operations
            // // Output how many numbers are in this list
            // List<int> numbers3 = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // var numbersInList = numbers.Count;
            // Console.WriteLine("Numbers In List: {0}", numbersInList);

            // // How much money have we made?
            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };

            // var howMuchMoney = purchases.Sum();
            // Console.WriteLine("How Much Money {0:C}", howMuchMoney);


            // // What is our most expensive product?
            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };

            // var mostExpensive = prices.Max();
            // Console.WriteLine("Most Expensive: {0}", mostExpensive);


            // /*
            //     Store each number in the following List until a perfect square
            //     is detected.

            //     Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            // */
            // List<int> wheresSquaredo = new List<int>()
            // {
            //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            // };

            // var squareQuery = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) != Math.Floor(Math.Sqrt(num)));
            // printer("Store until square", squareQuery);
            
            
            List<Customer> customers1 = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            /* 
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */
          
            var millionairesPerBank = from c in customers1
                            where c.Balance >= 1000000.00
                            group c by c.Bank into b
                            select new {Bank = b.Key, Count = b.Count()};
            
            Console.WriteLine("Millionaires Per Bank");
            millionairesPerBank.ToList().ForEach(bank => Console.WriteLine($"{bank.Bank} {bank.Count}"));

            // printer("Millionaires", millionairesPerBank);
                

        //     // Create some banks and store in a List
        // List<Bank> banks = new List<Bank>() {
        //     new Bank(){ Name="First Tennessee", Symbol="FTB"},
        //     new Bank(){ Name="Wells Fargo", Symbol="WF"},
        //     new Bank(){ Name="Bank of America", Symbol="BOA"},
        //     new Bank(){ Name="Citibank", Symbol="CITI"},
        // };

        // // Create some customers and store in a List
        // List<Customer> customers = new List<Customer>() {
        //     new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
        //     new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
        //     new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
        //     new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
        //     new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
        //     new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
        //     new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
        //     new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
        //     new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
        //     new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        // };

        //     /*
        //         TASK:
        //         As in the previous exercise, you're going to output the millionaires,
        //         but you will also display the full name of the bank. You also need
        //         to sort the millionaires' names, ascending by their LAST name.

        //         Example output:
        //             Tina Fey at Citibank
        //             Joe Landy at Wells Fargo
        //             Sarah Ng at First Tennessee
        //             Les Paul at Wells Fargo
        //             Peg Vale at Bank of America
        //     */    


        //     var millionaireReport = from c in customers
        //                             where c.Balance >= 1000000
        //                             join b in banks
        //                                 on c.Bank equals b.Symbol
        //                             select new {
        //                                 Name = c.Name,
        //                                 firstName = c.Name.Split(" ")[0], 
        //                                 lastName = c.Name.Split(" ")[1], 
        //                                 Bank = b.Name
        //                             };


            
        //     Console.WriteLine("Millionaire Report: ");
        //     foreach (var customer in millionaireReport.OrderBy(x=> x.lastName).ThenBy(y=> y.firstName))
        //     {
        //         Console.WriteLine($"{customer.Name} at {customer.Bank}");
        //     }
        
        // *** END OF MAIN ***
        }
    }

}    
