//todo
/*
    Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
      hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
      decimais
 */
Console.WriteLine("Qual o Id do funcionario?");
int idFuncionario = int.Parse(Console.ReadLine());
Console.WriteLine("Informe as quantas horas ele trabalhou:");
double horasTrabalhadas = double.Parse(Console.ReadLine());
Console.WriteLine("Quanto vale uma hora de trabalho dele?");
double salarioPorHora = double.Parse(Console.ReadLine());
double salarioTotal = salarioPorHora * horasTrabalhadas;

Console.WriteLine($"O Funcionário com id: {idFuncionario} vai receber {salarioTotal.ToString("F2")}");