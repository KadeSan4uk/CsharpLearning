namespace D_OOP
{
    class Program
    {
         static void Main(string[] args)
        {
            Character c1 = new Character();
            Character c2 = new Character();

            Console.WriteLine($"c1Speed={c1.PrintSpeed()} c2Speed={c2.PrintSpeed()}");
            c1.IncreaseSpeed();
            Console.WriteLine($"c1Speed={c1.PrintSpeed()} c2Speed={c2.PrintSpeed()}");

            double result =Calculator.Average2(1,2,3);
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