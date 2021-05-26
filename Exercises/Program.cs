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
            string input;
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

                Console.WriteLine();
                Console.WriteLine("Fig. B");
                int tmp = n;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = tmp; j > 0; j--)
                        Console.Write("*");
                    tmp--;
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Fig. C");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = n; j > 0; j--)
                    {
                        if (j <= i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }     
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Fig. D");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == 1 || i == n)
                            Console.Write("*");
                        else
                        {
                            if (j == 1 || j == n)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
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

        static void Task3_11() //Number of integers (count from 1) whose sum is greater than 100
        {
            int sum = 0,  x = 1;
            while (sum < 100)
            {
                sum += x++;
            }
            Console.WriteLine($"{sum} > 100 \nNumber of integers: {--x}");
            Console.ReadKey();
        }

        static void Task3_12() //Sum of integers given by user
        {
            int sum = 0, x;
            string input;
            Console.WriteLine("Enter an integers [0 to stop]: ");
            do
            {
                //int.TryParse(Console.ReadLine(), out x);
                isCorrect(out input, out x);
                sum += x;
            } while (x != 0);
            Console.WriteLine($"Sum: {sum}");
            Console.ReadKey();
        }

        static void Task3_13() //Calculate the sum of the series
        {
            int sum = 0, n;
            string input;
            Console.WriteLine("Enter a natural number: ");
            isCorrect(out input, out n);
            if (n <= 0)
            {
                Console.WriteLine("Wrong value!");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    sum -= i;
                else
                    sum += i;
            }
            Console.WriteLine($"The sum of the series [W(n)] = {sum}");
            Console.ReadKey();
        }

        static void Task3_14() //find perfect numbers in the range <1,n>
        {
            int n;
            string input;
            Console.WriteLine("Enter a natural number: ");
            isCorrect(out input, out n);
            if (n <= 0)
            {
                Console.WriteLine("Wrong value!");
                return;
            }

            int sum;
            Console.WriteLine($"Perfect numbers in the range <1,{n}>");
            for (int i = 1; i <= n; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (i == sum)
                    Console.Write($"{i} ");
            }
            Console.ReadKey();
        }

        static void Task3_15() //check how many different ways you can withdraw 10zl (having only 1zl, 2zl, 5zl coins)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 5; j++)
                    for (int k = 0; k <= 2; k++)
                        if (i * 1 + j * 2 + k * 5 == 10)
                            Console.WriteLine($"1zl: {i}\t2zl: {j}\t5zl: {k}");

            Console.ReadKey();
        }

        static void Task4_1() //make array with n-elements given by user
        {
            int n;
            string input;
            Console.WriteLine("Enter number of elements in array [int]: ");
            isCorrect(out input, out n);
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                int x;
                Console.Write($"Enter {i+1} value: ");
                isCorrect(out input, out x);
                tab[i] = x;
            }
            Console.WriteLine("Your array contains:");
            foreach (int num in tab)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }

        static void Task4_2() //copy only positive values from one array to another
        {
            int[] tab1 = new int[10] { 1, -2, 3, 4, -5, 6, -7, 8, 9, 0 };
            int[] tab2 = new int[10];
            for(int i = 0; i < tab1.Length; i++)
                if (tab1[i] > 0)
                    tab2[i] = tab1[i];

            Console.WriteLine("Second array contains:");
            foreach (int num in tab2)
                Console.Write($"{num} ");
            Console.ReadKey();
        }

        static void Task4_3() //display information about array (min, max, average, number of positives)
        {
            int n;
            string input;
            Console.WriteLine("Enter number of elements in array [int]: ");
            isCorrect(out input, out n);
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                int x;
                Console.Write($"Enter {i + 1} value: ");
                isCorrect(out input, out x);
                tab[i] = x;
            }
            int count = 0;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] > 0)
                    count++;
            Console.WriteLine($"Max element: {tab.Max()}\t index: {Array.IndexOf(tab, tab.Max())}");
            Console.WriteLine($"Min element: {tab.Min()}\t index: {Array.IndexOf(tab, tab.Min())}");
            Console.WriteLine($"Average value in array: {tab.Average()}");
            Console.WriteLine($"Number of positive values: {count}");
            Console.ReadKey();
        }

        static void Task4_4() //how many prime numbers are in an array with 100 elements?
        {
            int[] tab = new int[100];
            Random rand = new Random();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = rand.Next(1, 1000);

            int count = 0; bool isPrime;
            for (int i = 0; i < tab.Length; i++)
            {
                isPrime = true;
                for (int j = 2; j < tab[i]; j++)
                    if (tab[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                if (isPrime && tab[i] != 1)
                {
                    count++;
                    Console.Write($"{tab[i]} ");
                }
            }
            Console.WriteLine($"\nPrime numbers: {count}");    
            Console.ReadKey();
        }

        static void Task4_5() //copying from one array to another with a shift of 1 position
        {
            int[] tab1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] tab2 = new int[10];
            Array.Copy(tab1, tab1.Length - 1, tab2, 0, 1);
            Array.Copy(tab1, 0, tab2, 1, tab1.Length - 1);

            Console.WriteLine("Seond array contains:");
            foreach (int num in tab2)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            Task4_5();

        }
    }
}
