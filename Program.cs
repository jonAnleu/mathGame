/*using MathGame;

GameController.StartGame();




1.d 
2.d 
3.b 
4.1
5.c */

Console.Write("Enter your name: ");
string? userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");

Console.Write("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine());
int sum = num1 + num2;
Console.WriteLine($"The sum is: {sum}");

for(int i = 0; i <= sum; i++)
{
  Console.WriteLine(i);
}

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
  Console.WriteLine($"{num} is even.");
}else
{
  Console.WriteLine($"{num} is odd.");
}

int x = 5;
int y = 10;
int result = x + y;
Console.WriteLine($"The sum of x and y is: {sum}");

int a = 5;
int b = 10;
int c = 15;
int average = (a + b + c) / 3;
Console.WriteLine("The average is: " + average);