//todo
/*
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159
 */

Console.WriteLine("Entre com o valor do raio de um circulo que quer saber o valor:");
double raioDoCirculo = double.Parse(Console.ReadLine());
double areaDoCirculo = 3.14159 * Math.Pow(raioDoCirculo,2);
Console.WriteLine($"A={areaDoCirculo.ToString("F4")}");


