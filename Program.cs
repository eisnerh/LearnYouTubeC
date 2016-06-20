using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYouTubeC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Escribe Tu Nombre: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hola " + name);

            bool canVote = false;

            char grade = 'A';

            int maxInt = int.MaxValue;

            long maxLong = long.MaxValue;

            decimal maxDecimal = decimal.MaxValue;

            float maxFloat = float.MaxValue;

            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int = " + maxInt);

            var anotherName = "Eisner";

            anotherName = "Phillippe";

            Console.WriteLine("Another Name " + anotherName);
            Math();

        }

        public static void Math()
        {
            // ---------- MATH ----------

            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));
        }
    }
}
