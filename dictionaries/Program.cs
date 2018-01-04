using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("DG", "Dollar General");
            stocks.Add("TSCO", "Tractor Supply");
            stocks.Add("DLTR", "Dollar Tree");
            // Add a few more of your favorite stocks

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 200, price: 25.24));
            purchases.Add((ticker: "DG", shares: 1, price: 76.13));
            purchases.Add((ticker: "TSCO", shares: 63, price: 64.27));
            purchases.Add((ticker: "DLTR", shares: 71, price: 81.45));


            /* 
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */
            Dictionary<string,double> aggregatePurchases = new Dictionary<string,double>(){};

            string companyName = "";
            double amount;

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                companyName = stocks[purchase.ticker];
                amount = purchase.price * purchase.shares;
                // Does the company name key already exist in the report dictionary?
                if (aggregatePurchases.ContainsKey(companyName)) {
                // If it does, update the total valuation
                    aggregatePurchases[companyName] += amount;
                } else {
                // If not, add the new key and set its value
                    aggregatePurchases.Add(companyName, amount);
                }

            }

            foreach (KeyValuePair<string,double> kvp in aggregatePurchases) {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
