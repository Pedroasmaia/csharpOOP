namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastre seus livros:");
            Products Book1 = new Products();
            Console.Write("Nome do Livro: ");
            Book1.Name = Console.ReadLine();
            Console.Write("Nome do Autor: ");
            Book1.Author = Console.ReadLine();
            Console.Write("1° Tamanho: ");
            Book1.dimensionsA = double.Parse(Console.ReadLine());
            Console.Write("2° Tamanho: ");
            Book1.dimensionsB = double.Parse(Console.ReadLine());
            Console.Write("3° Tamanho: ");
            Book1.dimensionsC = double.Parse(Console.ReadLine());
            Console.WriteLine($"O Nome do Livro é {Book1.Name}");
            Console.WriteLine($"Foi escrito por {Book1.Author}");
            Console.WriteLine($"Sua area total é {Book1.dimensionsA * Book1.dimensionsB * Book1.dimensionsC} cm");
        }
    }
}