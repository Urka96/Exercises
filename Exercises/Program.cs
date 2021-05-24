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

        static void Task3_6() // BMI with comments
        {
            double BMI, kg, m;
            string input;
            Console.WriteLine("Enter your weight [kg]: ");
            isCorrect(out input, out kg);
            Console.WriteLine("Enter your height [m]: ");
            isCorrect(out input, out m);
            BMI = kg / (m * m);

            if (BMI < 18.5)
                Console.WriteLine($"Your BMI: {BMI} (< 18,5 - underweight)");
            else if (BMI >= 25)
                Console.WriteLine($"Your BMI: {BMI} (>= 25,0 - overweight)");
            else
                Console.WriteLine($"Your BMI: {BMI} (18,5-24,99 - normal)");
            Console.ReadKey();
        }

        static void Task3_7() //writing out the day of the week depending on the number
        {
            Console.WriteLine("Enter the number of the day of the week ");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("There is no such day of the week ");
                    break;
            }
            Console.ReadKey();
        }

        static void Task3_8() //the amount of the scholarship based on the grade point average 
        {
            double grades;
            string input;
            Console.WriteLine("Enter your average grades [2,00-5,00]: ");
            isCorrect(out input, out grades);
            if (grades >= 2 && grades <= 3.99)
                Console.WriteLine($"Average grades: {grades} \t Scholarship amount: 0zl");
            else if (grades >= 4 && grades <= 4.79)
                Console.WriteLine($"Average grades: {grades} \t Scholarship amount: 350zl");
            else if (grades >= 4.8 && grades <= 5)
                Console.WriteLine($"Average grades: {grades} \t Scholarship amount: 550zl");
            else
                Console.WriteLine("Wrong value!");
            Console.ReadKey();
        }

        static void Task3_9() //printing figures
        {
            int n;
            string input, fig;
            Console.WriteLine("Enter number of rows:");
            isCorrect(out input, out n);
            if (n < 0)
                Console.WriteLine("Wrong value.");
            else
            {
                Console.WriteLine("Fig. A");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                Console.WriteLine("Fig. B");
                int tmp = n;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = tmp; j > 0; j--)
                        Console.Write("*");
                    tmp--;
                    Console.WriteLine();
                }

                /*Console.WriteLine("Fig. C");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                Console.WriteLine("Fig. D");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }*/
            }
            Console.ReadKey();
        }

        static void Task3_10() // calculate n! (factorial)
        {
            int n;
            double result = 1;
            string input;
            Console.WriteLine("Enter n value [integer]: ");
            isCorrect(out input, out n);
            if (n == 0)
                Console.WriteLine($"{n}! = 1");
            else if (n < 0)
                Console.WriteLine("Wrong value! Try again and enter a non-negative integer");
            else
            {
                for (int i = n; i > 0; i--)
                {
                    result *= i;
                }
                Console.WriteLine($"{n}! = {result}");
            }
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
            //Task3_5();
            //Task3_6();
            //Task3_7();
            //Task3_8();
            Task3_9();
            //Task3_10();

            //Console.ReadKey();

        }
    }
}
