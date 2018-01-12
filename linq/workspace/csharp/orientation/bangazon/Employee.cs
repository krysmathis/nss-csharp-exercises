using System;
using System.Collections.Generic;

namespace bangazon
{
    partial class Program
    {

        public class Employee {

            public string FirstName {get; set;}
            public string LastName {get; private set;}
            public List<string> Restaurants = new List<string>() {
                "Arbys",
                "McDonalds",
                "Taco Bell",
                "Krystals"
            };

            public Employee(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;

            }

            public override string ToString() {
                return $"{FirstName} {LastName}";
            }

            private string getRestaurant() {
                Random rand = new Random();
                string restaurant = Restaurants[rand.Next(0,Restaurants.Count-1)];
                return restaurant;
            }

            public string eat() {   
                string restaurant = getRestaurant();
                System.Console.WriteLine($"{FirstName} is eating at: {restaurant}");
                return restaurant;
            }

            public void eat(string food) {
                Console.WriteLine($"{FirstName} {LastName} is eating: {food}");
            }
       
            public void eat(List<Employee> companions) {
                
                string restaurant = getRestaurant();
                Console.WriteLine($"{FirstName}  is eating at: {restaurant}");
                
                foreach(Employee c in companions) {
                    Console.WriteLine($"{c.FirstName} is there too");
                }
            }

            public void eat(string food, List<Employee> companions) {
                string restaurant = getRestaurant();
                Console.WriteLine($"{FirstName} is at: {restaurant} eating: {food}");
                foreach(Employee c in companions) {
                    Console.WriteLine($"{c.FirstName} is there too");
                }

            }

        }

    }
}

