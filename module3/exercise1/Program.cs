//Todo:
/*
Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos.
 */

Console.WriteLine("Escreva o primeiro número: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
int secondNumber = int.Parse(Console.ReadLine());

int total = firstNumber + secondNumber;

Console.WriteLine($"O resultado de {firstNumber} + {secondNumber} = {total} ");