string[] cordenadas = Console.ReadLine().Split(' ');
double y = double.Parse(cordenadas[0]);
double x = double.Parse(cordenadas[1]);
Console.WriteLine(x == 0 && y == 0 ? "Origem" : y > 0 && x > 0 ? "Q1" : y < 0 && x > 0 ? "Q2" : y < 0 && x < 0 ? "Q3" : y > 0 && x < 0 ? "Q4" : "" );