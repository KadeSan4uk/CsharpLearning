namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void PassByRefDemo()
        {
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);
            Console.WriteLine($" a={a} b={b}");



            Console.ReadLine();

            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        static void Swap(ref int  a,ref int b)
        {
            Console.WriteLine($"Original a={a} b={b}");
            int temp = a; a=b; b=temp;
            Console.WriteLine($"Swapped a={a} b={b}");

        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        
        static void ValueRefTypes()
        {
            EvilStruct es1 = new EvilStruct();
            es1.PointRef = new PointRef() { X = 1, Y = 2 };
            //es1.PointRef.X = 1;
            //es1.PointRef.Y = 2;
            EvilStruct es2 = es1;
            Console.WriteLine($"es1.PointRef.X= {es1.PointRef.X} es1.PoitRef.Y= {es1.PointRef.Y}");
            Console.WriteLine($"es1.PointRef.X= {es2.PointRef.X} es1.PoitRef.Y= {es2.PointRef.Y}");

            es2.PointRef.X = 42;
            es2.PointRef.Y = 45;
            Console.WriteLine($"es1.PointRef.X= {es1.PointRef.X} es1.PoitRef.Y= {es1.PointRef.Y}");
            Console.WriteLine($"es1.PointRef.X= {es2.PointRef.X} es1.PoitRef.Y= {es2.PointRef.Y}");


            Console.ReadLine();
            PointVal a; //тоже самое PointVal a = new PointVal();
            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();
            Console.WriteLine("After strucs");

            PointRef c = new PointRef(); //с сылочными типами только так 
            c.X = 3;
            c.Y = 5;

            PointRef d = c;
            d.X = 7;
            d.Y = 10;

            c.LogValues();
            d.LogValues();
        }
        static void SpeedControl()
        {
            Character c1 = new Character();
            Character c2 = new Character();

            Console.WriteLine($"c1Speed={c1.PrintSpeed()} c2Speed={c2.PrintSpeed()}");
            c1.IncreaseSpeed();
            Console.WriteLine($"c1Speed={c1.PrintSpeed()} c2Speed={c2.PrintSpeed()}");

            double result = Calculator.Average2(1, 2, 3);
            Console.WriteLine(result);

        }
        static void TryParseMethod()
        {
            //Calculator calc = new Calculator();
            //if (calc.TryDivide(10, 2, out double result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to divide");
            //}



            //Console.WriteLine("Enter a number");

            //string line = Console.ReadLine();

            //bool wasParsed = int.TryParse(line, out int number);//  out выходной аргумент 
            //if (wasParsed)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to parse");
            //}
        }

        static void CallClassTry()
        {// 8 video 8:30 вопрос про статик и паблик классы и методы и их вызов использование
         // Calculator.CalcTriangleSquare(ab: 10, ac: 20, alpha: 30);
        }
        static void CalcCallMethodTry()
        {
            //Calculator calc = new Calculator();
            ////double avg= calc.Average(new int[] { 1, 2, 3, 4 });
            //double avg = calc.Average2(1, 2, 3, 4);
            //Console.WriteLine(avg);
        }

        static void CalcMyMethodTry()
        {
            //Calculator calc = new Calculator();
            //double square1 = calc.CalcTriangleSquare(10, 20);
            //double square2 = calc.CalcTriangleSquare(40, 20, 30);
            //double square3 = calc.CalcTriangleSquare(10, 20, 30);
            //Console.WriteLine($"Square1={square1} Square2={square2} Square3={square3}");

        }
    }

}