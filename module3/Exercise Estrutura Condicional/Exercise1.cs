//todo:
/*
Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
 */
int number = int.Parse(Console.ReadLine());
if (number >= 0) { Console.WriteLine("Não Negativo"); } else { Console.WriteLine("Negativo"); }

//or

if(int.Parse(Console.ReadLine()) < 0){Console.WriteLine("negativo");}else{Console.WriteLine("Não negativo");}