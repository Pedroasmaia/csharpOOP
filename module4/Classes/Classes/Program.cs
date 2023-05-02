using Classes;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();


Console.WriteLine("Entre com as medidas do triangulo X");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pX = (x.A + x.B + x.C) / 2.0;
double hX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));
Console.WriteLine("Entre com as medidas do triangulo Y");
 y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pY = (y.A + y.B + y.C) / 2.0;
double hY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));
Console.WriteLine($"Área de X = {hX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área de Y = {hY.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine(hX > hY ? $"Maior area: X " : $"Maior area: Y");
