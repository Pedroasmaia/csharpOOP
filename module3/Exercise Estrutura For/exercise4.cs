//Todo
/*
Fazer um programa para ler um número N. 
Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. 
Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
*/
Console.WriteLine("Quantas divisões vão acontecer: ");
int quantitydivisons = int.Parse(Console.ReadLine());

for(int i = 0; i < quantitydivisons;i++){
   string[] values = Console.ReadLine().Split(' ');
   decimal value1 = decimal.Parse(values[0]);
   decimal value2 = decimal.Parse(values[1]);
   if(value2 == 0){
      Console.WriteLine("A Divisão é impossivel");
   }
   else{
      Console.WriteLine(value1/value2);
   }
}