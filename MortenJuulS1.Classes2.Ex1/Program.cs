using System;

namespace MortenJuulS1.Classes2.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Willam Gibson", "Neromancer", 450, "Aner det ikke");
            Console.WriteLine(book1.ToString());
        }
    }
}
