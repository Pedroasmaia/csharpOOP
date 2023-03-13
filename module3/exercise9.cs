//Todo
/*
 Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
    Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
    ordem crescente ou decrescente.
 */
string[] numbers = Console.ReadLine().Split(' ');
int numberOne = int.Parse(numbers[0]);
int numberTwo = int.Parse(numbers[1]);

if (numberOne % numberTwo == 0 || numberTwo % numberOne == 0)
{
    Console.WriteLine("Multiplo");
}
else
{
    Console.WriteLine("Não é multpilo");
}