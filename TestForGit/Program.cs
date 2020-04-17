using System;

namespace TestForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lukas Strohmer
            while (true)
            {
                try
                {
                    double Erg=0;

                    Console.WriteLine("Bitte geben sie die Erste Zahl ein:");
                    double Zahl1 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Bitte geben sie die Zweite Zahl ein:");
                    double Zahl2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Welche der folgenden Operationen möchten sie ausführen: +, -, /, *");
                    string Operation = Console.ReadLine();
                    switch (Operation)
                    {
                        case "+":
                            Erg= Addition(Zahl1, Zahl2);
                            Console.WriteLine("Ergebnis:" + Erg);
                            break;
                        case "-":
                            Erg=Subtraktion(Zahl1, Zahl2);
                            Console.WriteLine("Ergebnis:" + Erg);
                            break;
                        case "/":
                            Erg=Division(Zahl1, Zahl2);
                            Console.WriteLine("Ergebnis:"+ Erg);
                            break;
                        case "*":
                            Erg=Multiplikation(Zahl1, Zahl2);
                            Console.WriteLine("Ergebnis:" + Erg);
                            break;
                        default:
                            Console.WriteLine("Diese Operation ist nicht vorhanden!");
                            break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
            }
        }
        //Klotz Stefan
        /// <summary>
        /// Adds two numbers together
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns></returns>
        public static double Addition (double number1, double number2)
        {
            double result = number1 + number2;
            return  result;
        }

        /// <summary>
        /// Calculates the first number minus the second
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns></returns>
        public static double Subtraktion (double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }

        /// <summary>
        /// Multiplies two number
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns></returns>
        public static double Multiplikation (double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }

        /// <summary>
        /// Divides one value by another
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns></returns>
        public static double Division (double number1, double number2)
        {
            double result = number1 / number2;
            return Math.Round(result,3);
        }


    }
}
