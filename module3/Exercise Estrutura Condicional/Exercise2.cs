//Todo
/*
 Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
 */
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) { Console.WriteLine("Par"); }else{ Console.WriteLine("Impar"); }

//Or
Console.WriteLine(int.Parse(Console.ReadLine())% 2 == 0 ? "PAR" : "IMPAR");