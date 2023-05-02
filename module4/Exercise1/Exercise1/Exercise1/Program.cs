// See https://aka.ms/new-console-template for more information
using Exercise1;

People First, Second;

First = new People();
Second = new People();

Console.WriteLine("Escreva o 1° nome:");
First.name = Console.ReadLine();
Console.WriteLine($"Quantos anos tem {First.name} :");
First.age = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o 2° nome:");
Second.name = Console.ReadLine();
Console.WriteLine($"Quantos anos tem {Second.name} :");
Second.age = int.Parse(Console.ReadLine());

Console.WriteLine(Second.age > First.age? $"A Pessoa mais velha é {Second.name}" : $"A Pessoa mais velha é {First.name}");