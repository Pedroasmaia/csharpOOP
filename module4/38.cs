using System.Globalization;

//! Resolvendo um problema sem orientação a objetoss:
/*
* Fazer um programa para ler as medidas dos lados de 2 triângulos (X e Y), suponha medidas válidas. Em seguida mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
*/
Console.WriteLine("Entre com as medidas do triangulo X");
double aX = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double bX = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double cX = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double pX = (aX + bX + cX)/2.0;
double hX = Math.Sqrt(pX*(pX-aX)*(pX-bX)*(pX-cX));
Console.WriteLine("Entre com as medidas do triangulo Y");
double aY = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double bY = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double cY = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double pY = (aY + bY + cY)/2.0;
double hY = Math.Sqrt(pY*(pY-aY)*(pY-bY)*(pY-cY));
Console.WriteLine($"Área de X = {hX.ToString("F4",CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área de Y = {hY.ToString("F4",CultureInfo.InvariantCulture)}");
Console.WriteLine(hX > hY ? $"Maior area: X ": $"Maior area: Y");
