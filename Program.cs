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
            Mathe();
            Cast();
            aleatorio();

        }

        public static void Mathe()
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

        public static void Cast ()
        {
            // Casting : If no magnitude is lost casting happens automatically, but otherwise it must be done
            // like this

            double pi = 3.14;
            float intPi = (float)pi; // put the data type to convert to between braces

            // Math Functions
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;

            Console.Write(pi);
            Console.WriteLine("Valor real de pi " + intPi);
            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));
        }

        public static void aleatorio()
        {
            Random rnd = new Random();
            Console.WriteLine("Numero aleatorio entre 1 y 100 : ( " + (rnd.Next(1, 100)) + " )");
        }
    }
}
