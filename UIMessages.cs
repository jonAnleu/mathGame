namespace MathGame

{
    public class UIMessages
    {
        public static void PlayerChoice()
        {
            string? playerChoice = Console.ReadLine();
            bool isChallengeAccepted = false;

            do
            {
                if (playerChoice != null && playerChoice.ToLower() == "yes")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You have our respect, please proceed warrior!");
                    Console.WriteLine();
                    isChallengeAccepted = true;
                }
                else if (playerChoice != null && playerChoice.ToLower() == "no")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Go home commoner, only warriors are welcome here!");
                    Console.WriteLine();
                    isChallengeAccepted = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Unacceptable response!");
                    Console.WriteLine();
                    Console.Write("Respond \"yes\" to accept the challenge or \"no\" to go back home: ");
                    playerChoice = Console.ReadLine();
                }
            } while (!isChallengeAccepted);
        }
        public static void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome warrior, have you come to accept the challenge?");
            Console.WriteLine();
            Console.Write("Respond \"yes\" to accept the challenge or \"no\" to go back home: ");
            PlayerChoice();


        }

        public static void RulesOfBattle()
        {
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" RULES OF BATTLE");
            Console.WriteLine("*****************");
            Console.WriteLine("Both combatants will enter the arena with 100hp");
            Console.WriteLine("Each match will be in rounds until one combatant leave the arena");
            Console.WriteLine("You will be given a \"TARGET NUMBER\" and supplied with a \"SET\" of random numbers");
            Console.WriteLine("Your challenge is to use the numbers provided to build equations that equal the TARGET NUMBER");
            Console.WriteLine("Numbers in the SET may only be cast once");
            Console.WriteLine("You can use ( +, -, *, /, ()) to build equations");
            Console.WriteLine();
            Console.Write("Knowing the rules do you wish to continue(yes/no): ");
            PlayerChoice();
        }



        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine(" YOU HAVE ENTERED THE MATH GAUNTLET");
            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("ENTER A NUMBER TO CHOOSE YOUR CHALLENGER");
            Console.WriteLine();
            Console.WriteLine("1: THE SUMMONER (EASY) ");
            Console.WriteLine("2: THE DIVIDER (NORMAL)");
            Console.WriteLine("3: THE ELIMINATOR (HARD)");
            Console.WriteLine();
            Console.WriteLine("4: Rules");
            Console.WriteLine("5: Game History");
            Console.WriteLine("6: Exit Game");
            Console.WriteLine();
        }
    }
}

