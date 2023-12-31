﻿using System.Security.Cryptography.X509Certificates;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Bob's Big Giveaway");
             Console.Write("Choose a door: 1, 2, or 3:");
             string message;
             string userValue = Console.ReadLine();

             if (userValue == "1") message = "You won a new car!";
             else if (userValue == "2") message = "You won a new boat!";
             else if (userValue == "3") message = "You won a new cat;";
             else message = "I'm sorry that's not an option...";

             Console.WriteLine(message);
             Console.ReadLine();
             */
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3:");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();

        }
    }
}