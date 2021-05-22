using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Task2_1() //C -> F (Celsius to Fahrenheit)
        {
            double temp;
            string input;
            Console.WriteLine("Enter the temperature [°C]: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out temp))
            {
                Console.WriteLine("Temperature in Fahrenheit: {0} °F", 32 + (9.0 / 5) * temp);
            }
            else
            {
                Console.WriteLine("Wrong value!");
            }
            Console.ReadKey();
        }

        static double Task2_2help(out string input, out double param, string name)
        {
            Console.WriteLine("Enter '{0}' value: ", name);
            input = Console.ReadLine();
            while (!double.TryParse(input, out param))
            {
                Console.WriteLine("Enter the correct '{0}' value", name);
                input = Console.ReadLine();
            }
            return param;
        }

        static void Task2_2() //delta = b^2 - 4ac
        {
            double a, b, c;
            string input;
            a = Task2_2help(out input, out a, "a");
            b = Task2_2help(out input, out b, "b");
            c = Task2_2help(out input, out c, "c");
            //Console.WriteLine($"{a} {b} {c}");
            double delta = b * b - 4 * a * c;
            Console.WriteLine($"delta = {delta}");
            Console.ReadKey();           
        }

        static void Task2_3() //BMI = kg/m^2
        {
            double BMI, kg, m;
            string input;
            Console.WriteLine("Enter your weight [kg]: ");
            input = Console.ReadLine();
            while (!double.TryParse(input, out kg))
            {
                Console.WriteLine("Wrong value!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Enter your height [m]: ");
            input = Console.ReadLine();
            while (!double.TryParse(input, out m))
            {
                Console.WriteLine("Wrong value!");
                input = Console.ReadLine();
            }
            BMI = kg / (m * m); //Math.Pow(m, 2);
            Console.WriteLine($"Your BMI: {BMI}");
            Console.ReadKey();
        }

        static void Task3_1() //check if given year is a leap year
        {
            int year;
            string input;
            Console.WriteLine("Enter a year: ");
            input = Console.ReadLine();
            while (!int.TryParse(input, out year))
            {
                Console.WriteLine("Wrong value!");
                input = Console.ReadLine();
            }

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("It's a leap year!");
            }
            else
            {
                Console.WriteLine("It isn't a leap year, just a common year.");
            }
            Console.ReadKey();
        }

        static void isCorrect(out string input, out double param)
        {
            input = Console.ReadLine();
            while (!double.TryParse(input, out param))
            {
                Console.WriteLine("Wrong value!");
                input = Console.ReadLine();
            }
        }
        static void isCorrect(out string input, out int param)
        {
            input = Console.ReadLine();
            while (!int.TryParse(input, out param))
            {
                Console.WriteLine("Wrong value!");
                input = Console.ReadLine();
            }
        }

        static void Task3_2() //is second number divider of the first one?
        {
            int x, y;
            string input;
            Console.WriteLine("Enter first integer: ");
            isCorrect(out input, out x);
            Console.WriteLine("Enter second integer: ");
            isCorrect(out input, out y);

            if (x % y == 0)
            {
                Console.WriteLine("Second number is a divider!");
            }
            else
            {
                Console.WriteLine("Second number is not a divider.");
            }
            Console.ReadKey();
        }

        static void Task3_3() //find maximum number of 3 given
        {
            double x, y, z;
            string input;
            Console.WriteLine("Enter first number: ");
            isCorrect(out input, out x);
            Console.WriteLine("Enter second number: ");
            isCorrect(out input, out y);
            Console.WriteLine("Enter third number: ");
            isCorrect(out input, out z);

            if (x >= y && x >= z)
            {
                Console.WriteLine($"Maximum number is {x}");
            }
            else if (y >= x && y >= z)
            {
                Console.WriteLine($"Maximum number is {y}");
            }
            else
            {
                Console.WriteLine($"Maximum number is {z}");
            }
            Console.ReadKey();
        }

        static void Task3_4() //simple calculator (2 numbers, +, -, /, *)
        {
            double x, y;
            string input, operation;
            Console.WriteLine("Enter first number: ");
            isCorrect(out input, out x);
            Console.WriteLine("Enter second number: ");
            isCorrect(out input, out y);
            Console.WriteLine("Enter operation sign (+,-,*,/): ");
            operation = Console.ReadLine();
            while (!(operation == "+" || operation == "-" || operation == "*" || operation == "/"))
            {
                Console.WriteLine("Wrong sign!");
                operation = Console.ReadLine();
            }

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{x} + {y} = {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"{x} - {y} = {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"{x} * {y} = {x * y}");
                    break;
                case "/":
                    Console.WriteLine($"{x} / {y} = {x / y}");
                    break;
            }
            Console.ReadKey();
        }

        static void Task3_5() //number of roots of a quadratic equation
        {
            double a, b, c;
            string input;
            a = Task2_2help(out input, out a, "a");
            b = Task2_2help(out input, out b, "b");
            c = Task2_2help(out input, out c, "c");
            double delta = b * b - 4 * a * c;

            if (delta > 0)
                Console.WriteLine("There are 2 roots.");
            else if (delta == 0)
                Console.WriteLine("There is 1 root.");
            else
                Console.WriteLine("No roots.");
            Console.ReadKey();
        }

        static void Task3_6()
        {

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Task2_1();
            //Task2_2();
            //Task2_3();
            //Task3_1();
            //Task3_2();
            //Task3_3();
            //Task3_4();
            Task3_5();
            //Task3_6();

            //Console.ReadKey();

        }
    }
}
