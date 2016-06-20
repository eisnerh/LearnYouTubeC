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

            string pvoid = Console.ReadLine();
            switch(pvoid)
                { 
                case "0":
                            Mathe();
                break;
            case "1":
                            Cast();
                break;
                case "2":
                    aleatorio();
                    break;
                case "3":

                    operadoresRelacionales();
                    break;
                case "4":
                              looping();
                    break;

                case "5":
                    hilerasPalabras();
                    break;


            }
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

        public static void operadoresRelacionales()
        {
            // ---------- CONDITIONALS ----------

            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || ^ !

            // If Statement
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            bool canDrive = age >= 16 ? true : false;

            switch(age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                    Console.WriteLine("Adult");
                    break;
                case 2:
                    Console.WriteLine("Toddler");
                    goto Cute;
                default:
                    Console.WriteLine("Dead");
                    break;
            }
        Cute:
            Console.WriteLine("Toddler are cute.");
        }
        public static void looping ()
        {
            int i = 0;

            while (i < 10)
            {
                // If i = 7 then skip the rest of the code and start with i = 8
                if (i == 7)
                {
                    i++;
                    continue;
                }

                // Jump completely out of the loop if i = 9
                if (i == 9)
                {
                    break;
                }

                // You can't convert an int into a bool : Print out only odds
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            // The do while loop will go through the loop at least once
            string guess;
            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();
            } while (!guess.Equals("15")); // How to check String equality

            // Puts all changes to the iterator in one place
            for (int j = 0; j < 10; j++)
            {
                if ((j % 2) > 0)
                {
                    Console.WriteLine(j);
                }
            }

            // foreach cycles through every item in an array or collection
            string randStr = "Here are some random characters";

            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }

        }

        public static void hilerasPalabras()
        {
            // Escape Sequences : \' \" \\ \b \n \t

            string sampString = "A bunch of random words";

            // Check if empty
            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("String Length " + sampString.Length);

            // Find a string index (Starts with 0)
            Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));

            // Get a substring
            Console.WriteLine("2nd Word " + sampString.Substring(2, 6));

            string sampString2 = "More random words";

            // Are strings equal
            Console.WriteLine("Strings equal " + sampString.Equals(sampString2));

            // Compare strings
            Console.WriteLine("Starts with A bunch " + sampString.StartsWith("A bunch"));
            Console.WriteLine("Ends with words " + sampString.EndsWith("words"));

            // Trim white space at beginning and end or (TrimEnd / TrimStart)
            sampString = sampString.Trim();

            // Replace words or characters
            sampString = sampString.Replace("words", "characters");
            Console.WriteLine(sampString);

            // Remove starting at a defined index up to the second index
            sampString = sampString.Remove(0, 2);
            Console.WriteLine(sampString);

            // Join values in array and save to string
            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Name List " + String.Join(", ", names));

            // Formatting : Currency, Decimal Places, Before Decimals, Thousands Separator
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr.ToString());
        }
    }
}
