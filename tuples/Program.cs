using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Ham", 2.50, 1));
            transactions.Add(("Cheese", 5.00, 1));
            transactions.Add(("Bread", 1.50, 2));
            transactions.Add(("Lettuce", 0.25, 1));
            transactions.Add(("Pickles", 0.10, 2));

            int totalQuantity = 0;
            double totalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                totalQuantity += t.quantity;
                totalRevenue+= t.amount;
            }

            Console.WriteLine($@"
            Items Sold Today: {totalQuantity}
            Total Revenue: {totalRevenue:C}");
        }
    }
}
