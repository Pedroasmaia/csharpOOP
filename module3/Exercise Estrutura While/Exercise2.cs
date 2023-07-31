//Todo
/*
Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
*/

string[] cordenadas = Console.ReadLine().Split(' ');
int axisX = int.Parse(cordenadas[0]);
int axisY = int.Parse(cordenadas[1]);

while(axisX != 0 || axisY != 0){
   if(axisX > 0 && axisY > 0){
      Console.WriteLine("Primeiro");
   }
   else if(axisX > 0 && axisY <0){
      Console.WriteLine("Quarto");
   }
   else if(axisX < 0 && axisY < 0) {
      Console.WriteLine("Terceiro");
   }
   else if(axisX < 0 && axisY > 0){
      Console.WriteLine("Segundo");
   }
   cordenadas = Console.ReadLine().Split(' ');
   axisX = int.Parse(cordenadas[0]);
   axisY = int.Parse(cordenadas[1]);
}

//or 

Console.WriteLine("Entre com a cordenada X Y");
string[] cordenadas = Console.ReadLine().Split(' ');
int cordenadaX = int.Parse(cordenadas[0]);
int cordenadaY = int.Parse(cordenadas[1]);

Console.WriteLine(cordenadaX > 0 && cordenadaY > 0 ? "Primeiro" : cordenadaX > 0 && cordenadaY < 0 ? "Quarto" : cordenadaX < 0 && cordenadaY < 0 ? "Terceiro" : cordenadaX < 0 && cordenadaY > 0 ? "Segundo" : "Null");