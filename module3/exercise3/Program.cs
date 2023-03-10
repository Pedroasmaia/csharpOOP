//Todo
/*
 Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
 */
int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());
int numberFour = int.Parse(Console.ReadLine());

Console.WriteLine($"A Diferença é {(numberOne * numberTwo) - (numberThree * numberFour)}");
