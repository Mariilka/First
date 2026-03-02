

using System;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите трёхзначное число");

                int c = Convert.ToInt32(Console.ReadLine());
                if (c > 99 && c < 1000)
                {
                    int a = c / 100;
                    c %= 100;
                    int b = c / 10;
                    c %= 10;
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

                    Console.WriteLine($"Максимальное число: {max}");


                }
                else Console.WriteLine("Неверный ввод. Введите трёхзначное число");
            
        }
    }
}
