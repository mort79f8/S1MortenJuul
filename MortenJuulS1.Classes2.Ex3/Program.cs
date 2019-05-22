using System;

namespace MortenJuulS1.Classes2.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Track track = new Track("The Beatles", "Yesterday", 2, 5);

            Console.WriteLine(track.LenghtInSeconds());
            Console.WriteLine(track.ToString());

        }
    }
}
