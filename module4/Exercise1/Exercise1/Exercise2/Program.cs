namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1, f2;
            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Escreva o nome do 1° funcionario");
            f1.Name = Console.ReadLine();
            Console.WriteLine($"Escreva o salario do {f1.Name}");
            f1.Salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o nome do 2° funcionario");
            f2.Name = Console.ReadLine();
            Console.WriteLine($"Escreva o salario do {f2.Name}");
            f2.Salary = decimal.Parse(Console.ReadLine());
        
            Console.WriteLine($"A média dos salarios é {(f1.Salary + f2.Salary)/2}");
        
        }


    }
}