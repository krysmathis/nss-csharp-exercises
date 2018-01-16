using System;


namespace bagoloot
{
    class Program
    {
        static void Main(string[] args)
        {
            
           ConsoleKeyInfo enteredKey;

                Console.WriteLine(@"WELCOME TO THE BAG O' LOOT SYSTEM
*********************************
1. Register a child
2. Assign toy to a child
3. Revoke toy from child
4. Review child's toy list
5. Child toy delivery complete
6. Yuletime Delivery Report");

                do
                {
                    enteredKey = Console.ReadKey();
                    Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");
                    
                    if (enteredKey.Key.ToString().Equals("D1")) {
                        IMenu childRegistry = new MenuChildRegistry();
                        childRegistry.Init();
                    }

                } while (enteredKey.Key != ConsoleKey.Escape);
                        
        }


        public class MenuChildRegistry : IMenu
        {
            string sentence;

            public void Init()
            {
                Console.WriteLine("Enter the name of a child");
                do
                {
                    Console.WriteLine("Type in a sentence. Press enter when done.");
                    sentence = Console.ReadLine();
                    Console.WriteLine($"You entered the sentence: {sentence}");

                } while (sentence != "quit");
                
                
            }
        }


    }
}
