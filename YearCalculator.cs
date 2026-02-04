// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your name?");
string Name = Console.ReadLine();

Console.WriteLine("When are you born?");
int Year = int.Parse(Console.ReadLine());

Console.WriteLine(2026 - Year);