﻿using System;

namespace Svar_6c
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultPhrase = "Did you know that ";
            Console.WriteLine("Welcome to animal facts");
            Console.WriteLine("What animal would you like to know about?");
            string userChoice = Console.ReadLine();
            if (userChoice.ToLower() == "fish")
            {
                Console.WriteLine("Fish are the best");
                Console.WriteLine(defaultPhrase + "fish can breathe underwater?");
            }
            else if (userChoice.ToLower() == "hedgehog")
            {
                Console.WriteLine(defaultPhrase + "hedgehogs fear balloons?");
            }
        }
    }
}
