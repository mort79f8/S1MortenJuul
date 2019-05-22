using System;

namespace MortenJuulS1.Methods.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Print(5);
            PrintResult(9, 5);
            Console.WriteLine(IsPositive(4));
            Console.WriteLine(IsEven(5));
            CalculateAndPrint(8);
            Console.WriteLine(Max(2.5,5.7));
            Console.WriteLine(Max(43,12));
        }

        private static void Print()
        {
            Console.WriteLine("Hello World from a method!");
        }

        private static void Print(int wholeNumber)
        {
            Console.WriteLine($"Tallet er: {wholeNumber}");
        }

        private static void PrintResult(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            double firstDivision = firstNumber;
            double secondDivision = secondNumber;
            double division = firstDivision / secondDivision;
            Console.WriteLine($"{firstNumber} / {secondNumber} = {division}");
        }

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

        private static double Max(double firstNumber, double secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        private static int  Max(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

    }
}
