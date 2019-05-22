using System;

namespace mortenJuulS1.Arithmetic.ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string merch1Name;
            string merch2Name;
            string merch3Name;
            string merch4Name;
            string merch5Name;
            string merch6Name;
            int merch1Price;
            int merch2Price;
            int merch3Price;
            int merch4Price;
            int merch5Price;
            int merch6Price;


            Console.Write("Indtaste vare nummer 1's navn: ");
            merch1Name = Console.ReadLine();
            Console.Write("Indtaste vare nummer 1's pris: ");
            merch1Price = int.Parse(Console.ReadLine());
            Console.Write("Indtaste vare nummer 2's navn: ");
            merch2Name = Console.ReadLine();
            Console.Write("Indtaste vare nummer 2's pris: ");
            merch2Price = int.Parse(Console.ReadLine());
            Console.Write("Indtaste vare nummer 3's navn: ");
            merch3Name = Console.ReadLine();
            Console.Write("Indtaste vare nummer 3's pris: ");
            merch3Price = int.Parse(Console.ReadLine());
            Console.Write("Indtaste vare nummer 4's navn: ");
            merch4Name = Console.ReadLine();
            Console.Write("Indtaste vare nummer 4's pris: ");
            merch4Price = int.Parse(Console.ReadLine());
            Console.Write("Indtaste vare nummer 5's navn: ");
            merch5Name = Console.ReadLine();
            Console.Write("Indtaste vare nummer 5's pris: ");
            merch5Price = int.Parse(Console.ReadLine());
            Console.Write("Indtaste vare nummer 6's navn: ");
            merch6Name = Console.ReadLine();
            Console.Write("Indtaste vare nummer 6's pris: ");
            merch6Price = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Vare:\t{merch1Name}\tPris:\t{merch1Price}");
            Console.WriteLine($"Vare:\t{merch2Name}\tPris:\t{merch2Price}");
            Console.WriteLine($"Vare:\t{merch3Name}\tPris:\t{merch3Price}");
            Console.WriteLine($"Vare:\t{merch4Name}\tPris:\t{merch4Price}");
            Console.WriteLine($"Vare:\t{merch5Name}\tPris:\t{merch5Price}");
            Console.WriteLine($"Vare:\t{merch6Name}\tPris:\t{merch6Price}");
            Console.WriteLine();

            int total = merch1Price + merch2Price + merch3Price + merch4Price + merch5Price + merch6Price;

            double moms = total * 0.25;
            double totalWithMoms = total + moms;

            Console.WriteLine($"Total uden moms:\t{total}");
            Console.WriteLine($"Moms:\t{moms}");
            Console.WriteLine($"Total med moms:\t{totalWithMoms}");
            Console.WriteLine();

            Console.Write("Hvor meget har du betalt? ");
            double payment = double.Parse(Console.ReadLine());
            double returnPayment = payment - totalWithMoms;
            Console.WriteLine($"Du får {returnPayment} kr. tilbage");

        }
    }
}
