using System;

namespace MortenJuulS1.Classes2.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("fish", "Del Toro", "Mina", 124);
            Console.WriteLine(movie.GetLenghtInHoursAndMinutes());
            Console.WriteLine(movie.ToString());
        }
    }
}
