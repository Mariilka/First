

using System;

namespace First
{
    public static class Logic
    {
        public static bool IsThreeDigitNumber(int number)
        {
            return number > 99 && number < 1000;
        }

        public static int FindMaxDigit(int number)
        {
            int a = number / 100;
            number %= 100;
            int b = number / 10;
            number %= 10;
            int c = number;
            int max;

            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (b >= a && b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            return max;
        }

        public static void Result(int max)
        {
            Console.WriteLine($"Максимальное число: {max}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число");

            int c = Convert.ToInt32(Console.ReadLine());

            if (Logic.IsThreeDigitNumber(c))
            {
                int maxDigit = Logic.FindMaxDigit(c);
                Logic.Result(maxDigit);
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите трёхзначное число");
            }
        }
    }
}
