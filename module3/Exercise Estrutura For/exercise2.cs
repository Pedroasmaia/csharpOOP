//Todo
/*
Leia um valor inteiro N. 
Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/
Console.WriteLine("Quantas repetições vão acontecer: ");
int quantityNumbers = int.Parse(Console.ReadLine());
int inInterval = 0;
int outInterval = 0;
for (int i = 0; i < quantityNumbers; i++)
{
   Console.WriteLine("Entre com o número");
   int number = int.Parse(Console.ReadLine());
   if(number >= 10 && number <=20){
      inInterval++;
   }
   else{
      outInterval++;
   }

}
Console.WriteLine($"{inInterval} In");
Console.WriteLine($"{outInterval} Out");

//or 

int inRange = 0;
int outRange = 0;

int number =  int.Parse(Console.ReadLine());
for(int i=1; i <= number; i++){
        Console.Write($"Insira o valor da posição {i}°:");
        int temp = int.Parse(Console.ReadLine());
        if(temp >=10 && temp <=20){
                inRange++ ;
        }
        else{
                outRange++ ;
        }
 }
Console.WriteLine($" {inRange} in Range \n {outRange} Out Range");
