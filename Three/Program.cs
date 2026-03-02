using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            double letterPercentage = CalculateLetterPercentage(sentence);

            Console.WriteLine($"Доля букв в предложении: {letterPercentage:F2}%");
        }

        static double CalculateLetterPercentage(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            int letterCount = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }

            return (double)letterCount / text.Length * 100;
        }
    }
}
