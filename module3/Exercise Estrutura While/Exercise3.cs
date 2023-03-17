//Todo
/*
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
exemplo

*/

int diesel = 0;
int alcohol = 0;
int petrol = 0;
Console.WriteLine("Qual combustivel o cliente pediu? 1- Álcool 2-Gasolina 3-Diesel. Escolha 4 para encerrar o programa");
int fuel = int.Parse(Console.ReadLine());
while (fuel != 4)
{
   if (fuel == 1)
   {
      alcohol++;
   }
   else if (fuel == 2)
   {
      petrol++;
   }
   else if(fuel == 3){
      diesel++;
   }
   fuel = int.Parse(Console.ReadLine());
}
Console.WriteLine("Muito Obrigado");
Console.WriteLine($" Alcool: {alcohol}");
Console.WriteLine($" Gasolina: {petrol}");
Console.WriteLine($" Diesel: {diesel}");