/*
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
   mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
|          Renda            | Taxa de Imposto |
| de R$0.00 a R$ 2000.00    |     isento      |
| de R$2000.01 a R$ 3000.00 |         8%      |
| de R$3000.01 a R$ 4500.00 |        18%      |
| acima de R$ 4500.00       |        28%      |
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
   salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é 
   de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com 
   duas casas decimais.
*/

Console.WriteLine("Informe seu salario:");
decimal salary = decimal.Parse(Console.ReadLine());
decimal tax = 0.00m;
if (salary < 2000.01m)
{
    Console.WriteLine("Isento de imposto");
}
else if (salary > 2000 && salary < 3000)
{
    salary -= 2000;
    tax = salary * 0.08m;
    Console.WriteLine($"O imposto a ser cobrado será {tax}");
}
else if (salary > 3000 && salary < 4500)
{
    salary -= 3000;
    tax = 1000 * 0.08m;
    tax += salary * 0.18m;
    Console.WriteLine($"O imposto a ser cobrado será {tax}");
}
else if (salary > 4500)
{
    salary -= 4500;
    tax = 1000 * 0.08m;
    tax += 1500 * 0.18m;
    tax += salary * 0.28m;
    Console.WriteLine($"O imposto a ser cobrado será {tax}");
}