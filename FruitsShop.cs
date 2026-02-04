// See https://aka.ms/new-console-template for more information

double PriceKg = 1.4;

Console.WriteLine("How much do you want to buy?");
double Kg = double.Parse(Console.ReadLine());

Console.WriteLine($"The total sum is: {PriceKg*Kg}");