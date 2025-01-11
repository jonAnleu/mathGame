namespace mathGame
{
    public class MathGameLogic
    {
        public List<string> GameHistory { get; set; } = new List<string>();
        public static void ShowMenu()
        {   
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("Welcome to Math Game!");
            Console.WriteLine("*********************");
            Console.WriteLine();
            Console.WriteLine("Enter a number to choose your operation");
            Console.WriteLine();
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Random Mode");
            Console.WriteLine("6: Difficulty Settings");
            Console.WriteLine("7: Game History");
            Console.WriteLine("8: Exit Game");
            Console.WriteLine();
        }

        public int MathOperation(int num1, int num2, char operation)
        {
            switch (operation)
            {
                case '+':
                GameHistory.Add($"{num1} + {num2} = {num1 + num2}");
                return num1 + num2;
                case '-':
                GameHistory.Add($"{num1} - {num2} = {num1 - num2}");
                return num1 - num2;
                case '*':
                GameHistory.Add($"{num1} * {num2} = {num1 * num2}");
                return num1 * num2;
                case '/':
                GameHistory.Add($"{num1} / {num2} = {num1 / num2}");
                return num1 / num2;
            }
        }

    }


}