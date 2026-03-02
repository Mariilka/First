using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //НАЧАЛО работы с данными
            int[] sequence = { 10, -4, 12, 56, -4 };

            int signChanges = 0;
            //КОНЕЦ работы с данными

            //НАЧАЛО логики
            for (int i = 1; i < sequence.Length; i++)
            {
                // Проверяем, поменялся ли знак между текущим и предыдущим элементом
                if ((sequence[i - 1] > 0 && sequence[i] < 0) ||
                    (sequence[i - 1] < 0 && sequence[i] > 0))
                {
                    signChanges++;
                }
            }//КОНЕЦ логики

            //НАЧАЛО работы с консолью
            Console.WriteLine($"В последовательности [{string.Join(", ", sequence)}]");
            Console.WriteLine($"Знак меняется {signChanges} раз(а)");
            //КОНЕЦ работы с консолью
        }
    }
}
