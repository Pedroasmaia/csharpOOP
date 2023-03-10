//todo
/*
Fazer um programa para ler o código de uma 1° peça , o número de peças 1°, o valor unitário de cada 1° peça, o
código de uma 2° peça, o número de peças 2° e o valor unitário de cada peça 2°. Calcule e mostre o valor a ser pago.
 */

string[] piece1 = Console.ReadLine().Split(' ');
string[] piece2 = Console.ReadLine().Split(' ');

int quantityPiece1 = int.Parse(piece1[1]);
int quantityPiece2 = int.Parse(piece2[1]);
decimal valuePiece1 = decimal.Parse(piece1[2]);
decimal valuePiece2 = decimal.Parse(piece2[2]);
decimal valueTotal = quantityPiece1 * valuePiece1+ quantityPiece2 * valuePiece2;
Console.WriteLine($"Valor total {valueTotal.ToString("F2")}");