//Todo
/*
Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
 */

string[] hours = Console.ReadLine().Split(" ");
int initialHour = int.Parse(hours[0]);
int endHour = int.Parse(hours[1]) ;
if( initialHour >= 24 || endHour >= 24)
{
    Console.WriteLine("As horas vão de 0 a 23");
}
else
{
    if ( initialHour < endHour)
    {
        int duration =  endHour - initialHour;
        Console.WriteLine($"O Jogo durou {duration} horas(s)");
    }
    else
    {
        int duration = 24 - initialHour + endHour ;
        Console.WriteLine($"O Jogo durou {duration} horas(s)") ;
    }
}