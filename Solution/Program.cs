using System;
using System.Text;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace Solution
{
    public class SolutionProgram
    {
        public static void Main(string[] args)
        {
            string str = "";


            
            


        }
        
        static void stringWithOut0_9()
        {
            List<string> myArray = new List<string>();
            string input;
            string сontainStr = "";
            int i = 0;

            while (true)
            {
                input = Console.ReadLine();
                myArray.Add(input);

                if (input.Contains('0'))
                {
                    сontainStr = input.Replace("0", "");

                    break;
                }

                i++;
            }

            foreach (string str in myArray)
            {
                if (str.IndexOf(сontainStr, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    Console.WriteLine(str);
                }
            }
        }
        static void overFlowInArray8()
        {
            string[] input = Console.ReadLine().Split(',');
            int sum = 0;
            int number = 0;
            foreach (string line in input)
            {

                if (int.TryParse(line, out number))
                {
                    checked
                    {
                        sum += number;
                    }

                }
            }
            Console.WriteLine(sum);
        }
        static void lightCalculator7()
        {
            Console.WriteLine("Enter the 2 numbers in the format:+" +
                " \n\tSum(9,9) or Sub(9,9) or Mult(9,9) or Div(9,9)\nWhat means:" +
                "  +\t         -            *           /");

            string input = Console.ReadLine();
            string numbers = "1234567890-";
            string letters = "SsUuMmBbLlTtDdIiVvGgOo";
            string notation = "";
            string firstValue = "";
            string lastValue = "";

            for (int i = 0; i < (input.Length); i++)
            {
                if (letters.Contains(input[i]))
                {
                    notation += input[i];
                }
                if (input[i] == ',')
                {
                    break;
                }
                if (numbers.Contains(input[i]))
                {
                    firstValue += input[i];
                }
            }
            for (int i = 0; i < (input.Length); i++)
            {
                if (input[i] == ',')
                {
                    lastValue = "";
                }
                if (numbers.Contains(input[i]))
                {
                    lastValue += input[i];
                }
            }
            notation = notation.ToLower();
            int result = 0;

            int firstInt = int.Parse(firstValue);
            int lastInt = int.Parse(lastValue);

            if (notation == "sum")
            {
                result = firstInt + lastInt;
                Console.WriteLine($"{result}");
                if (firstInt > 0 && lastInt > 0 && result < 0 || firstInt < 0 && lastInt < 0 && result > 0)
                {
                    Console.WriteLine("Exception overflow!");
                }
            }
            else if (notation == "sub")
            {
                result = (lastInt - firstInt);
                if (result == 0)
                {
                    Console.WriteLine($"{result}");
                }
                if (firstInt > 0 && lastInt < 0 && result > 0 || firstInt < 0 && lastInt > 0 && result > 0)
                {
                    Console.WriteLine("Exception overflow!");
                    Console.WriteLine($"{result}");
                }
            }
            else if (notation == "mult")
            {
                result = firstInt * lastInt;

                Console.WriteLine($"{result}");
            }
            else if (notation == "div")
            {
                result = (firstInt / lastInt);

                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine("Incorrect input format, try again.");
            }
        }
        static void stringContainsNumbers6()
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();

            string numbers = "1234567890";
            string result = "";

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (numbers.Contains(input[i]))
                {
                    result += input[i] + ",";
                    if (i == input.Length - 1)
                    {
                        result = result.Remove(i);
                    }
                }
            }

            Console.Write($"{{{result}}}");
        }
        static void stringContains5()
        {
            Console.Write("Enter the word 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the word 2: ");
            string input2 = Console.ReadLine();

            bool contains1 = input1.Contains(input2);
            Console.WriteLine(contains1);
        }
        static void vowelsCharecters4()
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();

            string vowels = "aeiou";
            string result = "";
            foreach (char i in input.ToLower())
            {
                if (vowels.Contains(i))
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
        static void howIndexSuchOutput3()
        {
            Console.WriteLine("Enter the word: ");
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int repeatCount = i;

                for (int j = 0; j < repeatCount; j++)
                {
                    result += currentChar;
                }
            }

            Console.WriteLine(result);

        }
        static void evrySecondCharReverse2()
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();


            int count = 1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                count++;
                if (count % 2 == 0)
                {
                    continue;
                }

                Console.Write(input[i]);


            }

        }
        static void evrySecondCharOutput1()
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                count++;
                if (count % 2 == 0)
                {
                    continue;
                }

                Console.Write(input[i]);

            }
        }

    }


}   



