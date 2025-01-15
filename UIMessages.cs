using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace mathGame
{
    public class UIMessages
    {
        public static void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome warrior, have you come to accept the challenge?");
            Console.WriteLine();
            Console.Write("Respond \"yes\" to accept the challenge or \"no\" to go back home: ");
            string? challengeAccepted = Console.ReadLine();

            bool isChallengeAccepted = false;

            do
            {
                if (challengeAccepted != null && challengeAccepted.ToLower() == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("You have our respect, enter!");
                    Console.WriteLine();
                    isChallengeAccepted = true; // Exit the loop
                }
                else if (challengeAccepted != null && challengeAccepted.ToLower() == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Go home commoner, only warriors are welcome here!");
                    Console.WriteLine();
                    isChallengeAccepted = true; // Exit the loop
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Unacceptable response!");
                    Console.WriteLine();
                    Console.Write("Respond \"yes\" to accept the challenge or \"no\" to go back home: ");
                    challengeAccepted = Console.ReadLine();
                }
            } while (!isChallengeAccepted); // Loop continues until a valid response is given
        }




        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine("YOU HAVE ENTERED THE MATH GAUNTLET");
            Console.WriteLine("***********************************");
            Console.WriteLine();
            Console.WriteLine("ENTER A NUMBER TO CHOOSE YOUR CHALLENGER");
            Console.WriteLine();
            Console.WriteLine("1: THE SUMMONER (+) ");
            Console.WriteLine("2: THE ELIMINATOR (-)");
            Console.WriteLine("3: THE AMPLIFIER (*)");
            Console.WriteLine("4: THE DIVIDER (/)");
            Console.WriteLine();
            Console.WriteLine("7: Game History");
            Console.WriteLine("8: Exit Game");
            Console.WriteLine();
        }
    }
}