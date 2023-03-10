//Todo
/*
    Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
    mostre:
    a) a área do triângulo retângulo que tem A por base e C por altura.
    b) a área do círculo de raio C. (pi = 3.14159)
    c) a área do trapézio que tem A e B por bases e C por altura.
    d) a área do quadrado que tem lado B.
    e) a área do retângulo que tem lados A e B.
 */

string[] sides = Console.ReadLine().Split(' ');
double sideA = double.Parse(sides[0]);
double sideB = double.Parse(sides[1]);
double sideC = double.Parse(sides[2]);

double triangle = sideA * sideC / 2.0;
double circle = Math.Pow(sideC,2) * 3.14159;
double trapeze = (sideA + sideB) / 2.0 * sideC;
double square = Math.Pow(sideB, 2);
double rectangle = sideA * sideB;
Console.WriteLine($"Triangulo: {triangle.ToString("F3")}");
Console.WriteLine($"Circulo: {circle.ToString("F3")}");
Console.WriteLine($"Trapezio: {trapeze.ToString("F3")}");
Console.WriteLine($"Quadrado: {square.ToString("F3")}");
Console.WriteLine($"Retangulo: {rectangle.ToString("F3")}");