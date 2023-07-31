//Todo
/*
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
seguir, calcule e mostre o valor da conta a pagar
 */

decimal[] price = { 4.00m , 4.50m , 5m ,2m, 1.5m };
string[] order = Console.ReadLine().Split(" ");

int idItem = int.Parse(order[0]);
int quantityItem = int.Parse(order[1]);

Console.WriteLine($"Total: R${price[idItem-1]*quantityItem}");


//or

string[] orders = Console.ReadLine().Split(' ');
decimal[] price = {4.00m,4.50m,5.00m,2.00m,1.50m};

Console.WriteLine($"Total: R$ {(price[int.Parse(orders[0])-1]) * decimal.Parse(orders[1])}");