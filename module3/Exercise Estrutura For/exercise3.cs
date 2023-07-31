//Todo
/*
Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste  de 3 valores reais, cada um deles com uma casa decimal. 
Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5
*/
Console.WriteLine("Quantos testes vão acontecer: ");
int quantityTests = int.Parse(Console.ReadLine());

for(int i = 0; i < quantityTests;i++){
   string[] values = Console.ReadLine().Split(' ');
   decimal value1 = decimal.Parse(values[0]);
   decimal value2 = decimal.Parse(values[1]);
   decimal value3 = decimal.Parse(values[2]);
   decimal media = (value1 * 2.0m +  value2 * 3.0m + value3 * 5.0m)/ 10.0m; 
   Console.WriteLine(media.ToString("F1"));
}

//OR
int quantityTest =  int.Parse(Console.ReadLine());

for(int i = 1; i <= quantityTest; i++){
        string[] temp = Console.ReadLine().Split(' ');
        double media =
        ((double.Parse(temp[0]) * 2)+
        (double.Parse(temp[1]) * 3)+
        (double.Parse(temp[2]) * 5))/(2+3+5);
        Console.WriteLine(media.ToString("F1"));
}

