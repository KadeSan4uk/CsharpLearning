using System;
using System.Threading.Channels;

namespace B_ControlFlow
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            
        }
        
        static void LoginPassword()
        {
            string password = "qwerty";
            string login = "johnsilver";

            int tries = 0;
            while (tries < 3)
            {
                Console.WriteLine("Enter login");
                string userLogin = Console.ReadLine();
                Console.WriteLine("Enter password");
                string userPassword = Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("Enter the system.");
                    break;
                }
                tries++;
            }
            if (tries == 3)
            {
                Console.WriteLine("You exceeded the number of available tries.");
            }
        }
        static void Factorial()
        {
            Console.WriteLine("Enter n>=0");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
        static void AverageNumbers()
        {

            int[] numbers = new int[10];

            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;
                inputCount++;
                if (number == 0)
                    break;
            }
            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }
            double average = (double) sum / count;
            Console.WriteLine(average);

        }
        static void FibonacciLoop()
        {
            Console.WriteLine("Enter the number of Fibonacci numbers you want to generate");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[n];

            int a0 = 0;
            int a1 = 1;
            fibonacci[0] = a0;
            fibonacci[1] = a1;

            for (int i = 2; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;
                a0 = a1;
                a1 = a;
            }
            foreach (int i in fibonacci)
            {
                Console.WriteLine(i);
            }
        }
        static void MathSquareTriangle()
        {
            Console.WriteLine("Let's calculate the square of a triangle ");
            Console.WriteLine("Enter the lenght of size AB");
            double ab = GetDouble();

            Console.WriteLine("Enter the lenght of size BC");
            double bc = GetDouble();

            Console.WriteLine("Enter the lenght of size AC");
            double ac = GetDouble();

            double p = (ab + bc + ac) / 2;

            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            Console.WriteLine($"Square of the triangle equals: {square}");
        }
        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }
        static void SwithCase()
        {
            int moth = int.Parse(Console.ReadLine());

            string season = string.Empty;

            switch (moth)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);

            Console.ReadLine();

            int wddingYears = int.Parse(Console.ReadLine());
            string name = string.Empty;

            switch (wddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебряная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаем такого юбилея";
                    break;
            }
            Console.WriteLine(name);
        }
        static void BreakContinue()
        {
            int[] numbers1 = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };

            foreach (int i in numbers1)
            {
                //if(i%2 == 0)
                //{
                //    Console.WriteLine($"{i}");
                //}
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i);
            }

            Console.ReadLine();
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine($"Number={numbers1[i]} ");
                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers1[i] == j)
                    {
                        break;
                    }
                    Console.Write($"{letters[j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                    break;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j}). ");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }
            }
        }
        static void WhileDoWhile()
        {
            int age = 30;

            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("how old are you?");
                age = int.Parse(Console.ReadLine());

            }


            do
            {
                Console.WriteLine("Do\\while loop");
                Console.WriteLine("how old are you?");
                age = int.Parse(Console.ReadLine());

            } while (age < 18);
            Console.WriteLine("Good you are 18 or more older!");

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
        }
        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j}). ");
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];
                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{atK}) ");
                        }
                    }

                }
            }
        }
        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }

            }
            Console.WriteLine();
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 1)
                {
                    Console.Write(numbers[j] + " ");
                }

            }
            Console.WriteLine();
            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
        }
        static void HomeWorkMaxVelue()
        {
            Console.WriteLine("Write one integer number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write two integer number");
            int number2 = int.Parse(Console.ReadLine());
            int bigNumbers = number1 < number2 ? number2 : number1;
            Console.WriteLine($"This's a highter number {bigNumbers}");
        }
        static void BodyMassIndexIfElse()
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your weight in kg?");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your hight in cm?");
            double height = double.Parse(Console.ReadLine());
            height = height / 100;
            double BodyMassIndex = weight / (height * height);

            bool isTooLow = BodyMassIndex <= 18.5;
            bool isNoral = BodyMassIndex > 18.5 && BodyMassIndex < 25;
            bool isAboveNormal = BodyMassIndex >= 25 && BodyMassIndex <= 30;
            bool isTooFat = BodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");
            }
            else
            {
                Console.WriteLine("Oh, you're in a good shape");
            }

            if (!isFat)
            {
                Console.WriteLine("You're definitely not fat!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNoral)
            {
                Console.WriteLine("You're OK!");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight!");
            }

            if (isTooFat || isFat)
            {
                Console.WriteLine("Anyway it's time to get on diet.");
            }

            string description = age > 18 ? "You can drink alkohol" : "You should get a bit older";
            Console.WriteLine(description);
        }
    }


}
