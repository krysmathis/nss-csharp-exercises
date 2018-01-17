﻿using System;

namespace BankTeller
{
    public class MainMenu
    {
        public static int Show()
        {
            Console.Clear();
            Console.WriteLine ("WELCOME TO NASHVILLE SAFE & SOUND BANK");
            Console.WriteLine ("**************************************");
            Console.WriteLine ("1. Create customer account");
            Console.WriteLine ("2. Deposit money");
            Console.WriteLine ("3. Withdraw money");
            Console.WriteLine ("4. Show account balance");
            Console.WriteLine ("5. Exit");

            Console.Write ("> ");
            ConsoleKeyInfo enteredKey = Console.ReadKey();
            Console.WriteLine("");
            int output = 0;
            int.TryParse(enteredKey.KeyChar.ToString(), out output);
            return output;
        }
    }
}