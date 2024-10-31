namespace ParametersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input, TextInput = "";
            bool correctFormat = true;
            bool booleanInput;
            int IntInput;
            decimal DecimalInput;
            char CharInput;
            DateOnly DateInput;

            do
            {
                Console.WriteLine("Introduce true or false: ");
                input = Console.ReadLine();
                if (!bool.TryParse(input, out booleanInput))
                {
                    correctFormat = false;
                    Console.WriteLine("Input not valid. Intrduce true or false");
                }
                else
                {
                    correctFormat = true;
                }
            } while (!correctFormat);

            do
            {
                Console.WriteLine("Introduce a whole number: ");
                input = Console.ReadLine();
                if (!int.TryParse(input, out IntInput))
                {
                    correctFormat = false;
                    Console.WriteLine("Input not valid. Introduce a whole number");
                }
                else
                {
                    correctFormat = true;
                }
            } while (!correctFormat);

            do
            {
                Console.WriteLine("Introduce a decimal number: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out DecimalInput))
                {
                    correctFormat = false;
                    Console.WriteLine("Input not valid. Introduce a decimal number");
                }
                else
                {
                    correctFormat = true;
                }
            } while (!correctFormat);


            do
            {
                Console.WriteLine("Introduce a character: ");
                input = Console.ReadLine();
                if (!char.TryParse(input, out CharInput))
                {
                    correctFormat = false;
                    Console.WriteLine("Input not valid. Introduce a character");
                }
                else
                {
                    correctFormat = true;
                }
            } while (!correctFormat);


            do
            {
                Console.WriteLine("Introduce a text: ");
                input = Console.ReadLine();
                if (input == null)
                {
                    correctFormat = false;
                    Console.WriteLine("Input not valid. Introduce a text");
                }
                else
                {
                    TextInput = input;
                    correctFormat = true;
                }
            } while (!correctFormat);

            do
            {
                Console.WriteLine("Introduce a date with format dd/mm/yyyy: ");
                input = Console.ReadLine();
                if (!DateOnly.TryParse(input, out DateInput))
                {
                    correctFormat = false;
                    Console.WriteLine("Input not valid. Introduce a date with format dd/mm/yyyy");
                }
                else
                {
                    correctFormat = true;
                }

            } while (!correctFormat);


            Console.WriteLine("================Transformation================");

            Console.WriteLine("Boolean: You introduced " + booleanInput
                + " I return you: " + !booleanInput);

            Console.WriteLine("Result of division of " + IntInput
                + " divided by " + DecimalInput + " is: " +
                IntInput / DecimalInput);

            Console.WriteLine("Text transformation: ");
            Console.WriteLine("==================");

            Console.WriteLine($"{CharInput}({TextInput}){CharInput}");


            DateTime FirstDayMonth = new DateTime(DateInput.Year, DateInput.Month, 1);
            int lastDay = DateTime.DaysInMonth(DateInput.Year, DateInput.Month);
            DateTime LastSecond = new DateTime(DateInput.Year, DateInput.Month, lastDay, 23, 59, 59);

            TimeSpan SecondsDifference = LastSecond - FirstDayMonth;
            double TotalSeconds = SecondsDifference.TotalSeconds + 1;

            Console.WriteLine("Last second of the date introduced: "
                + DateInput + " is: " + TotalSeconds);

        }
    }
}
