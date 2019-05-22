using System;

namespace MortenJuulS1.Methods.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuHeader("Animals");
            PrintMenuItem("Cow");
            Console.WriteLine();
            PrintMenuHeader("Countries");
            PrintMenuItems("Tuvalu", "Maura");
            Console.WriteLine();
            PrintMenuHeader("Great Leaders");
            PrintMenuItems("Donald Trump", "Vladimir Putin", "Kim Jung-un");


        }

        private static void PrintMenuHeader(string header)
        {
            Console.WriteLine($"*** {header} ***");
        }

        private static  void PrintMenuItem(string menuItem)
        {
            Console.WriteLine($"1) {menuItem}");
        }

        private static void PrintMenuItems(string menu1, string menu2)
        {
            Console.WriteLine($"1) {menu1}");
            Console.WriteLine($"2) {menu2}");
        }

        private static void PrintMenuItems(string menu1, string menu2, string menu3)
        {
            Console.WriteLine($"1) {menu1}");
            Console.WriteLine($"2) {menu2}");
            Console.WriteLine($"3) {menu3}");
        }

    }
}
