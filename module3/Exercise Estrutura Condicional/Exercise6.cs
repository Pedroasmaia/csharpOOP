//Todo
/*
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”
 */

double value = double.Parse(Console.ReadLine());
if(value < 0 || value > 100)
{
    Console.WriteLine("Esse número esta fora dos intervalos");
}
else if (value <= 25)
{
    Console.WriteLine("Esse número esta entre 0 e 25");                     
}
else if (value <= 50)
{
    Console.WriteLine("Esse número esta entre 25 e 50");
}
else if(value <= 75)
{
    Console.WriteLine("Esse número esta entre 50 e 75");
}
else if(value <= 100)
{
    Console.WriteLine("Esse número esta entre 75 e 100");
}


//or

double number = double.Parse(Console.ReadLine());
Console.WriteLine(

   number > 0 && number <= 25 ?
"Intervalo (0,25)" :  number > 25 && number <= 50 ?
"Intervalo (25,50)" : number > 50 && number <= 75 ?
"Intervalo (50,75)" : number > 75 && number <= 100 ?
"Intervalo (75,100)" : "Fora de intervalo"
);