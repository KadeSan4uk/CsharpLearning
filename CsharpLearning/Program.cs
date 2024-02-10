using D_OOP;
using System;
using System.Text;
using System.Threading.Channels;
using System.Reflection.Metadata.Ecma335;

namespace CsharpLearning
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            

            
        }
        static void SomeTasks()
        {
            //Home task
            Console.WriteLine("What's your surname?");
            string surName = Console.ReadLine();
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your weight in kg?");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your hight in cm?");
            double height = double.Parse(Console.ReadLine());
            height = height / 100;

            double BMI = weight / (height * height);
            Console.WriteLine("Your profile:");
            Console.WriteLine($"Full Name: {surName}, {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Body Mass Index: {BMI}");
            // some tasks
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(square);



            //Console.WriteLine("Enter an integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number.ToString().Length); 


            //Console.WriteLine("Enter an integer");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an integer");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"a={a}, b={b} ");
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine($"a={a}, b={b} ");

            //Console.WriteLine("what's your name?");
            //string name=Console.ReadLine();
            //Console.WriteLine( $"Hello {name}!" );
        }
        static void CoupleOfTasks()
        {
            // Пару тасок=)
            string str = Console.ReadLine();
            Console.WriteLine(str.Length);


            //string input=Console.ReadLine();
            //int a1 = int.Parse(input);
            //string input1=Console.ReadLine();
            //int a2 = int.Parse(input1);
            //Console.WriteLine($"{a1} {a2}") ;
            //int temp;
            //temp = a1;
            //a1 = a2; 
            //a2=temp;
            //Console.WriteLine($"{a1} {a2}");


            //string str=Console.ReadLine();
            //Console.WriteLine($"Hello {str}");

        }
        static void DateTimePractic()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);// по умолчанию выведет полночь 00 00 00 время
            Console.WriteLine(dt.ToString());

            DateTime newDT = dt.AddDays(1);  // добавить 1 день
            Console.WriteLine(newDT.ToString());

            TimeSpan ts = now - dt;
            //ts=now.Subtract(dt);// работает так же как строка выше

            Console.WriteLine(ts.Days);
        }
        static void IntroToArrays()
        {
            int[] a1;
            a1 = new int[10];// выделение памяти для массива

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);
            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length - 1]);

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine($"First: {first} and Last {last}");
        }
        static void MathDemo()
        {

            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));// округляет к ближайшему числу от нуля
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));// по умолчанию используеться, округляет к ближайшему четному числу

        }
        static void CastingAndParsing()
        {
            byte b = 3;// 0000 0011
            int i = b;// 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i;// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i;//3.0

            Console.WriteLine(f);

            b = (byte) i;// явное приведение инт в байт
            Console.WriteLine(b);

            i = (int) f;
            Console.WriteLine(i);

            f = 3.1f;
            i = (int) f;
            Console.WriteLine(i);

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine($"Parsed i={i}");

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            double result2 = (double) x / 2;
            Console.WriteLine(result2);

        }
        static void ConsoleAndBasics()
        {
            Console.Clear();
            //Console.WriteLine("Hi, please tell me your name");

            //string name=Console.ReadLine();
            //string sentence = $"Your name is {name}";
            //Console.WriteLine(sentence);

            //Console.WriteLine("Hi, please tell me your age");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);//перевод строки в число

            //string sentence = $"Your age is {age}";
            //Console.WriteLine(sentence);
            //Console.Clear();//чистка консоли
            //Console.BackgroundColor = ConsoleColor.Black;// изминение цвета фона текста консоли
            //Console.ForegroundColor = ConsoleColor.Yellow;// изминение цвета текста  консоли

            //Console.Write("New Style ");
            //Console.Write("New Style\n");
        }
        static void ComparingStrings()
        {
            //string str1 = "abcde";
            //string str2 = "abcde";

            //bool areEqual = str1 == str2;
            //Console.WriteLine(areEqual);

            //areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            //Console.WriteLine(areEqual);

            string str1 = "Strasse";
            string str2 = "Straße";
            bool areEqual = string.Equals(str1, str2, StringComparison.Ordinal);//по умолчанию, сравнение по байтово
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str1, str2, StringComparison.InvariantCulture);//(избегать)сравнение с расширением(учитывает некую специфику алфавитов)
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str1, str2, StringComparison.CurrentCulture);// если нужно учитывать специфику обпределенного языка и культуры
            Console.WriteLine(areEqual);
        }
        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            Console.WriteLine(str1);

            string str2 = $"My name is {name} and I'm {age}";
            //string str2="My name is " + name + "and I'm" + age;            
            Console.WriteLine(str2);

            string str3 = "My name is \nJohn";
            Console.WriteLine(str3);

            string str4 = "I'm \t30";
            Console.WriteLine(str4);

            string str5 = $"My name is {Environment.NewLine}John";// перевод на новую строку кроссплатформа
            Console.WriteLine(str5);

            //string str6 = "I'm John and I'm a "good" programmer";
            string str6 = "I'm John and I'm a \"good\" programmer";
            Console.WriteLine(str6);

            //string str7 = "C:\tmp\test_file.txt";
            string str7 = @"C:\tmp\test_file.txt";// @ для вывода слешей
            Console.WriteLine(str7);

            int answer = 42;
            double value = 42.32658;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            result = string.Format("{0:f}", value);
            result2 = string.Format("{0:f4}", value);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.OutputEncoding = Encoding.UTF8;//для добавления валютного знака к числу

            double money = 12.8;
            result = string.Format("{0:C}", money);// {С} для вывода знака(рублей) и работает как 2 числа после запятой
            result2 = string.Format("{0:C2}", money);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.WriteLine(money.ToString("C2"));
            result = $"{money:C2}";
            Console.WriteLine(result);
        }
        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();//конкатенация строк(складывает строку из строк)
            sb.Append("My "); //этот метод работает быстрее подобных методов строк
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");// конкатенация строк с переводом на следующую строку
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringModifications()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");// соединение строк
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");//соединение строк с добавлением разделителя .
            Console.WriteLine(nameConcat);
            nameConcat = "My " + "name " + "is " + "John";// можно складывать строку операторами сложения
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "By the way. ");//вставка подстроки в строку начиная с выбранного индекса
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);//(1параметр) удаляет строку начиная с индекса//(2параметра) удаляет количество символов начиная с индекса
            Console.WriteLine(nameConcat);

            string replased = nameConcat.Replace('n', 'z');// заменяет симфолы строки по заданным параметрам
            Console.WriteLine(replased);

            string data = "12;24;34;25;64";
            string[] splitData = data.Split(';');// разделяет на индексы массива строку по выбраным разделителям
            string first = splitData[0];// присвоение полученной строки индексу 0 в массив строк
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();//разобрать строку по символам
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());// убирает пробелы в начале и конце строки
        }
        static void StringEmptiness()
        {
            string str = string.Empty;// same as ""

            string empty = "";
            string whiteSpase = " ";
            string notEmpty = " b";
            string nullString = null;// обьект пуст.

            Console.WriteLine("IsnullorEmpty");
            bool IsnullorEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(IsnullorEmpty);

            IsnullorEmpty = string.IsNullOrEmpty(whiteSpase);
            Console.WriteLine(IsnullorEmpty);


            IsnullorEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(IsnullorEmpty);

            IsnullorEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(IsnullorEmpty);

            Console.WriteLine();
            Console.WriteLine("IsnullorWhiteSpace");

            bool IsnullorWhiteSpase = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(IsnullorWhiteSpase);

            IsnullorWhiteSpase = string.IsNullOrWhiteSpace(whiteSpase);
            Console.WriteLine(IsnullorWhiteSpase);


            IsnullorWhiteSpase = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(IsnullorWhiteSpase);

            IsnullorWhiteSpase = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsnullorWhiteSpase);
        }

        static void OueryingStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains("E");
            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWishAbra = name.EndsWith("abra");
            Console.WriteLine(endsWishAbra);

            bool startsWishAbra = name.StartsWith("abra");
            Console.WriteLine(startsWishAbra);

            int index0fA = name.IndexOf('a', 1);// можно задать стартовый индекс с которого начинаем поиск индекса символа
            Console.WriteLine(index0fA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);//с какого символа начинать чтение
            string substrFrom2 = name.Substring(0, 3);// 0 с какого символа начинать||3 сколько символов прочитать

            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFrom2);

        }

        static void StaticAndInstanseMembers()
        {
            // string name = new string( "abrakadabra");//создать новый экземпляр строки
            string name = "abrakadabra";// экземпляр строки

            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xstr = x.ToString();
            Console.WriteLine(xstr);
            Console.WriteLine(x);

        }

        static void ComparisonOperators()
        {
            int x = 1;
            int y = 2;
            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);
            result = x >= y;
            Console.WriteLine(result);
            result = x < y;
            Console.WriteLine(result);
            result = x <= y;
            Console.WriteLine(result);
            result = x != y;
            Console.WriteLine(result);
        }

        static void Overflow()
        {
            // Cheked overflow.//использовать только для проверки переполнения арифметических операций
            //потому что этот блок очень тормозит программу!

            //checked
            // {
            uint x = uint.MaxValue;
            Console.WriteLine(uint.MaxValue);
            x = x + 1;
            Console.WriteLine(x); //Overflow!!!
            x = x - 1;
            Console.WriteLine(x);

            // }
        }

        static void VariablesScoup()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }
            Console.WriteLine(a);
            // Console.WriteLine(b);
            //Console.WriteLine(c);
        }

        static void Variables()
        {
            int x = 1;
            int y;
            y = 2;
            float f = 1.1f;
            double d = 2.2;
            int x2 = 0;
            int x3 = new int();

            var a = 12;
            var b = 1.2;

            var dict = new Dictionary<int, string>();

            decimal money = 3.0m;

            char @char = 'A';
            string str = "Hello";
            bool CanDrive = true;
            bool CanDraw = false;

            object obj1 = 1;
            object obj2 = "obj2";

            Console.WriteLine(obj2);
            Console.WriteLine(str);
        }
    }

}
