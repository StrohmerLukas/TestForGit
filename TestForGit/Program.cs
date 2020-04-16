using System;

namespace TestForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lukas Strohmer
            Console.WriteLine("Bitte geben sie die Erste Zahl ein:");
            int Zahl1= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Bitte geben sie die Zweite Zahl ein:");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Welche der folgenden Operationen möchten sie ausführen: +, -, /, *");
            string Operation = Console.ReadLine();
            switch (Operation)
            {
                case "+":
                    Addition(Zahl1, Zahl2);
                    break;
                case "-":
                    Subtraktion(Zahl1, Zahl2);
                    break;
                case "/":
                    Division(Zahl1, Zahl2);
                    break;
                case "*":
                    Multiplikation(Zahl1, Zahl2);
                    break;
            }

            //Klotz Stefan
            Console.WriteLine("Stefan");


        }

        /// <summary>
        /// Adds two numbers together
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns></returns>
        public static int Addition (int number1, int number2)
        {
            var result = number1 + number2;
            return  result;
        }

        public static int Subtraktion (int number1, int number2)
        {
            int result = 0;

            return result;
        }

        public static int Multiplikation (int number1, int number2)
        {
            int result = 0;

            return result;
        }

        public static double Division (int number1, int number2)
        {
            double result = 0;

            return result;
        }


    }
}
