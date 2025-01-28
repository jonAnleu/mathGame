namespace MathGame
{
    public class UIMessages
    {
        private const string AcceptChallengePrompt = "Respond \"yes\" to accept the challenge or \"no\" to go back home: ";
        private const string InvalidResponseMessage = "Unacceptable response, try again.";
        private const string WarriorAcceptedMessage = "You have our respect, proceed warrior!";
        private const string WarriorDeclinedMessage = "Go home commoner, only warriors are welcome here!";
        
        // Handles player input for yes/no responses
        public static bool GetResponse(string prompt)
        {
            string? playerChoice;
            do
            {
                Console.Write(prompt);
                playerChoice = Console.ReadLine()?.ToLower();
                Console.Clear();

                if (playerChoice == "yes")
                {
                    Console.WriteLine($"\n{WarriorAcceptedMessage}\n");
                    return true;
                }
                else if (playerChoice == "no")
                {
                    Console.WriteLine($"\n{WarriorDeclinedMessage}\n");
                    return false;
                }
                else
                {
                    Console.WriteLine($"\n{InvalidResponseMessage}\n");
                }
            } while (true);
        }

        public static bool Greeting()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome warrior, are you here to accept the challenge of the Math Gauntlet?\n");
            return GetResponse(AcceptChallengePrompt);
        }

        public static bool RulesOfBattle()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine(" RULES OF BATTLE");
            Console.WriteLine("*****************");
            Console.WriteLine("1. Two warriors will enter the arena with 100HP.");
            Console.WriteLine("2. Each match will be in rounds until one combatant leaves the arena.");
            Console.WriteLine("3. You will be given a \"TARGET NUMBER\" and a \"SET\" of random numbers.");
            Console.WriteLine("4. Use the numbers provided to build equations equaling the TARGET NUMBER.");
            Console.WriteLine("5. Numbers in the SET may only be used once per round.");
            Console.WriteLine("6. Allowed operators: +, -, *, /, ().");
            Console.WriteLine();
            return GetResponse("Knowing the rules, do you wish to continue (yes/no): ");
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine(" YOU HAVE ENTERED THE MATH GAUNTLET");
            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("ENTER A NUMBER TO CHOOSE YOUR CHALLENGER:");
            Console.WriteLine("1: THE SUMMONER (EASY)");
            Console.WriteLine("2: THE DIVIDER (NORMAL)");
            Console.WriteLine("3: THE ELIMINATOR (HARD)");
            Console.WriteLine("4: Rules");
            Console.WriteLine("5: Game History");
            Console.WriteLine("6: Exit Game");
            Console.WriteLine();
        }
    }

    public class GameController
    {
        public static void StartGame()
        {
            if (!UIMessages.Greeting())
            {
                Console.WriteLine("GAME OVER \n");
                return; 
            }

            if (!UIMessages.RulesOfBattle())
            {
                Console.WriteLine("GAME OVER \n");
                return; 
            }

            UIMessages.ShowMenu();
        }
    }
}
