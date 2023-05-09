using Classes;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();


Console.WriteLine("Entre com as medidas do triangulo X");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double hX = x.Area();
Console.WriteLine("Entre com as medidas do triangulo Y");
 y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double hY = y.Area();
Console.WriteLine($"Área de X = {hX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área de Y = {hY.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine(hX > hY ? $"Maior area: X " : $"Maior area: Y");
