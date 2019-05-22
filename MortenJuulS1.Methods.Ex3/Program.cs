using System;

namespace MortenJuulS1.Methods.Ex3
{
    class Program
    {
        enum MainMenuEnum
        {
            calculate = 1,
            numbers = 2,
            finish = 3
        }

        enum CalculateMenuEnum
        {
            squareRoot = 1,
            frontPage = 2
        }

        enum NumberMenuEnum
        {
            positiv = 1,
            even = 2,
            frontPage = 3
        }


        static void Main(string[] args)
        {
            FrontPage();
        }

        private static void PrintMenuHeader(string header)
        {
            Console.WriteLine($"*** {header} ***");
        }

        private static void PrintMenuItems(params string[] menuItems)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i+1}) {menuItems[i]}");
            }
        }

        //private static void PrintMenuItems(string menu1, string menu2)
        //{
        //    Console.WriteLine($"1) {menu1}");
        //    Console.WriteLine($"2) {menu2}");
        //}

        //private static void PrintMenuItems(string menu1, string menu2, string menu3)
        //{
        //    Console.WriteLine($"1) {menu1}");
        //    Console.WriteLine($"2) {menu2}");
        //    Console.WriteLine($"3) {menu3}");
        //}

        private static bool IsPositive(int wholenumber)
        {
            return wholenumber >= 0;
        }

        private static bool IsEven(int wholeNumber)
        {
            int getModulo = wholeNumber % 2;
            return getModulo == 0;
        }

        private static void CalculateAndPrint(int number)
        {
            if (IsPositive(number) == true)
            {
                double notAWholeNumber = number;
                Console.WriteLine($"Kvadratroden af {notAWholeNumber}: {Math.Sqrt(notAWholeNumber)}");
            }
        }

        private static void FrontPage()
        {
            while (true)
            {


                PrintMenuHeader("Hovedmenu");
                PrintMenuItems("Gå til udregninger", "Gå til tal", "Afslut programmet");
                string mainMenuSelector = Console.ReadLine();

                Enum.TryParse(mainMenuSelector, true, out MainMenuEnum mainMenu);

                switch (mainMenu)
                {
                    case MainMenuEnum.calculate:
                        CalculateMenu();
                        break;
                    case MainMenuEnum.numbers:
                        NumbersMenu();
                        break;
                    case MainMenuEnum.finish:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("vælg 1, 2 eller 3");
                        break;
                }
            }

        }

        private static void CalculateMenu()
        {
            bool calcMenu = true;

            while (calcMenu)
            {

                PrintMenuHeader("Udregninger");
                PrintMenuItems("Kvadrat og rod.", "Tilbage til hovedmenu");
                string calcMenuSelector = Console.ReadLine();

                Enum.TryParse(calcMenuSelector, true, out CalculateMenuEnum calculateMenuEnum);

                switch (calculateMenuEnum)
                {
                    case CalculateMenuEnum.squareRoot:
                        SquareRoot();
                        break;
                    case CalculateMenuEnum.frontPage:
                        calcMenu = false;
                        break;
                    default:
                        Console.WriteLine("vælg 1 eller 2");
                        break;
                }
            }
        }

        private static void NumbersMenu()
        {
            bool numberMenu = true;
            while (numberMenu)
            {
                PrintMenuHeader("Tal");
                PrintMenuItems("Er tallet positivt?", "Er tallet lige?", "Tilbage til hovedmenu");
                string numberMenuSelector = Console.ReadLine();

                Enum.TryParse(numberMenuSelector, true, out NumberMenuEnum numberMenuEnum);

                switch (numberMenuEnum)
                {
                    case NumberMenuEnum.positiv:
                        SelectedPositiv();
                        break;
                    case NumberMenuEnum.even:
                        SelectedEven();
                        break;
                    case NumberMenuEnum.frontPage:
                        numberMenu = false;
                        break;
                    default:
                        Console.WriteLine("vælg 1, 2 eller 3");
                        break;
                }
            }

        }

        private static void SquareRoot()
        {
            Console.WriteLine("indtaste det heltal du vil havde kvadratroden af: ");
            int sqrnumber = int.Parse(Console.ReadLine());
            CalculateAndPrint(sqrnumber);
        }

        private static void SelectedPositiv()
        {
            Console.WriteLine("indtast det heltal du gerne vil se om det er positiv: ");
            int number = int.Parse(Console.ReadLine());
            if(IsPositive(number))
            {
                Console.WriteLine("Ja dit tal er positiv!");
            }
            else
            {
                Console.WriteLine("Nej det ser ikke ud til dit tal er positivt");
            }
        }

        private static void SelectedEven()
        {
            Console.WriteLine("indtast det heltal du gerne vil se om det er lige: ");
            int number = int.Parse(Console.ReadLine());
            if (IsEven(number))
            {
                Console.WriteLine("Ja dit tal er lige!");
            }
            else
            {
                Console.WriteLine("Nej det ser ikke ud til dit tal er lige");
            }
        }
    }
}
