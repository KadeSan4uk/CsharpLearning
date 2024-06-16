using System;
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;

public class Program
{
    private static void Main(string[] args)
    {




    }

    public void Collections()
    {
        //Массивы в C# представляют собой фиксированное количество элементов одного типа данных

        int[] numbers = new int[5]; // массив из 5 элементов типа int

        int[] numbers1 = { 1, 2, 3, 4, 5 };// инициализация при обьявлении

        Console.WriteLine(numbers[0]); // выводит первый элемент массива (1)

        numbers[2] = 10; // изменяет третий элемент на 10

        Console.WriteLine(numbers.Length); // выводит длину массива (5)

        //Списки List<T> в C# представляют собой динамический массив,
        //который может изменять свой размер во время выполнения.

        List<int> numbersList = new List<int>(); // пустой список типа int

        numbersList.Add(1);//Добавление в значения в список
        numbersList.Add(2);
        numbersList.Add(3);

        Console.WriteLine(numbersList[0]); // выводит первый элемент списка (1)

        numbersList[2] = 10; // изменяет третий элемент списка на 10

        Console.WriteLine(numbersList.Count); // выводит количество элементов в списке (3)

        //Dictionary <TKey, TValue> представляет коллекцию пар ключ-значение, где каждый ключ уникален.

        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Alice", 30);
        ages.Add("Bob", 25);
        ages.Add("Charlie", 35);

        Console.WriteLine(ages["Alice"]); // выводит значение по ключу "Alice" (30)

        if (ages.ContainsKey("Bob"))
        {
            Console.WriteLine("Bob's age is " + ages["Bob"]);
        }

        //Queue<T> представляет коллекцию элементов по принципу "первый пришел, первый вышел" (FIFO).

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Alice");
        queue.Enqueue("Bob");

        string firstPerson = queue.Dequeue(); // извлекаем первый элемент ("Alice")
        Console.WriteLine("First person: " + firstPerson); // выводит "First person: Alice"

        //Stack<T> представляет коллекцию элементов по принципу "последний пришел, первый вышел" (LIFO).

        Stack<string> stack = new Stack<string>();
        stack.Push("Alice");
        stack.Push("Bob");

        string topPerson = stack.Pop(); // извлекаем верхний элемент ("Bob")
        Console.WriteLine("Top person: " + topPerson); // выводит "Top person: Bob"





    }

    public void InheritenceAndPolimorfism()
    {
        //Наследование позволяет одному классу (производному) унаследовать поля,
        //свойства и методы другого класса (базового).

        //    public class Animal
        // {
        //    public string Name { get; set; }

        //    public void Eat()
        //    {
        //        Console.WriteLine($"{Name} is eating.");
        //    }
        // }
        //    public class Dog : Animal
        // {
        //    public void Bark()
        //    {
        //        Console.WriteLine($"{Name} is barking.");
        //    }
        //  }
        //Dog dog = new Dog();
        //dog.Name = "Buddy";
        //dog.Eat(); // выводит "Buddy is eating."
        //dog.Bark(); // выводит "Buddy is barking."

        //Переопределение позволяет производному классу предоставлять специфическую реализацию метода,
        //который уже определен в базовом классе.Для этого используются ключевые слова virtual и override.

        //    public class Animal
        // {
        //    public string Name { get; set; }

        //    public virtual void MakeSound()
        //    {
        //        Console.WriteLine($"{Name} makes a sound.");
        //    }
        // }

        //    public class Dog : Animal
        // {
        //    public override void MakeSound()
        //    {
        //        Console.WriteLine($"{Name} barks.");
        //    }
        // }
        //Animal animal = new Animal();
        //animal.Name = "Generic Animal";
        //animal.MakeSound(); // выводит "Generic Animal makes a sound."

        //Dog dog = new Dog();
        //dog.Name = "Buddy";
        //dog.MakeSound(); // выводит "Buddy barks."

        // Виртуальные методы могут быть переопределены в производных классах,
        // но имеют реализацию по умолчанию в базовом классе.
        // Абстрактные методы не имеют реализации в базовом классе и должны быть
        // реализованы в производных классах.Абстрактный метод может быть объявлен только в абстрактном классе.

        //    public abstract class Animal
        //  {
        //    public string Name { get; set; }

        //    public abstract void MakeSound();

        //    public virtual void Eat()
        //    {
        //        Console.WriteLine($"{Name} is eating.");
        //    }
        //  }

        //    public class Dog : Animal
        //  {
        //    public override void MakeSound()
        //    {
        //        Console.WriteLine($"{Name} barks.");
        //    }

        //    public override void Eat()
        //    {
        //        Console.WriteLine($"{Name} eats dog food.");
        //    }
        //  }
        //Dog dog = new Dog();
        //dog.Name = "Buddy";
        //dog.MakeSound(); // выводит "Buddy barks."
        //dog.Eat(); // выводит "Buddy eats dog food."

        //Интерфейсы определяют набор методов и свойств, которые класс должен реализовать,
        //но не содержат реализаций. Класс может реализовывать несколько интерфейсов,
        //что обеспечивает гибкость и поддержку множественного наследования поведения.

        //    public interface IMovable
        //  {
        //    void Move();
        //  }

        //    public class Car : IMovable
        //  {
        //    public void Move()
        //    {
        //        Console.WriteLine("The car is moving.");
        //    }
        //  }
        //IMovable movable = new Car();
        //movable.Move(); // выводит "The car is moving."

        // Пример с наследованием, полиморфизмом и интерфейсами

        // Базовый класс

        //    public abstract class Animal
        //  {
        //    public string Name { get; set; }

        //    public abstract void MakeSound();

        //    public virtual void Eat()
        //    {
        //        Console.WriteLine($"{Name} is eating.");
        //    }
        //  }

        //Производные классы

        //    public class Dog : Animal
        //  {
        //    public override void MakeSound()
        //    {
        //        Console.WriteLine($"{Name} barks.");
        //    }

        //    public override void Eat()
        //    {
        //        Console.WriteLine($"{Name} eats dog food.");
        //    }
        //  }

        //public class Cat : Animal
        //  {
        //    public override void MakeSound()
        //    {
        //        Console.WriteLine($"{Name} meows.");
        //    }

        //    public override void Eat()
        //    {
        //        Console.WriteLine($"{Name} eats cat food.");
        //    }
        //  }

        //Интерфейс

        //    public interface IMovable
        //  {
        //    void Move();
        //  }

        //класс реализующий интерфейс

        //    public class Car : IMovable
        //  {
        //    public void Move()
        //    {
        //        Console.WriteLine("The car is moving.");
        //    }
        //  }

        //Использование полиморфизма и интерфейсов

        //   List<Animal> animals = new List<Animal>
        //  {
        //    new Dog { Name = "Buddy" },
        //    new Cat { Name = "Whiskers" }
        //  };

        //    foreach (var animal in animals)
        //   {
        //      animal.MakeSound();
        //      animal.Eat();
        //   }

        //    IMovable movable = new Car();
        //    movable.Move();



















    }
    public void ClassesAndObjects()
    {
        //Создание и использование классов
        //Класс — это шаблон или чертеж для создания объектов.Объект — это экземпляр класса,
        //который содержит конкретные значения свойств и может выполнять определенные действия(методы).

        //    public class Person
        //  {
        //    // Поля
        //    private string name;
        //    private int age;

        //    // Свойства
        //    public string Name
        //    {
        //        get { return name; }
        //        set { name = value; }
        //    }

        //    public int Age
        //    {
        //        get { return age; }
        //        set { age = value; }
        //    }

        //    // Конструктор
        //    public Person(string name, int age)
        //    {
        //        this.name = name;
        //        this.age = age;
        //    }

        //    // Метод
        //    public void Greet()
        //    {
        //        Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
        //    }
        //  }

        //использование класса
        //Person person = new Person("Alice", 30);
        //Console.WriteLine(person.Name); // выводит "Alice"
        //Console.WriteLine(person.Age);  // выводит "30"
        //person.Greet(); // выводит "Hello, my name is Alice and I am 30 years old."

        //Конструкторы — это специальные методы, которые вызываются при создании объекта.
        //Они инициализируют объекты класса.

        //    public class Car
        //  {
        //   public string Model { get; set; }
        //    public int Year { get; set; }

        //    // Конструктор
        //    public Car(string model, int year)
        //    {
        //        Model = model;
        //        Year = year;
        //    }

        //    public void DisplayInfo()
        //    {
        //        Console.WriteLine($"Model: {Model}, Year: {Year}");
        //    }
        //   }

        //Car car = new Car("Toyota", 2020);
        //car.DisplayInfo(); // выводит "Model: Toyota, Year: 2020"

        //Поля — это переменные, объявленные внутри класса, которые хранят данные.
        // Свойства — это методы доступа к полям, которые позволяют контролировать доступ к ним.
        //Методы — это функции, которые выполняют действия над данными класса.

        //    public class Rectangle
        //    {
        //  private double length;
        //  private double width;

        //   public double Length
        //  {
        //    get { return length; }
        //    set { length = value; }
        //  }

        //   public double Width
        //  {
        //    get { return width; }
        //    set { width = value; }
        //  }

        //  public double GetArea()
        //  {
        //    return length * width;
        //  }
        //Rectangle rect = new Rectangle();
        //rect.Length = 10.0;
        //rect.Width = 5.0;
        //Console.WriteLine(rect.GetArea()); // выводит 50.0

        //Инкапсуляция — это механизм, который позволяет скрывать внутренние детали реализации
        //и предоставлять только необходимые методы для работы с объектом.
        //Это достигается с помощью модификаторов доступа.

        //        public class BankAccount
        //    {
        //        private decimal balance;

        //        public decimal Balance
        //        {
        //            get { return balance; }
        //            private set { balance = value; }
        //        }

        //        public BankAccount(decimal initialBalance)
        //        {
        //            balance = initialBalance;
        //        }

        //        public void Deposit(decimal amount)
        //        {
        //            if (amount > 0)
        //            {
        //                balance += amount;
        //            }
        //        }

        //        public bool Withdraw(decimal amount)
        //        {
        //            if (amount > 0 && balance >= amount)
        //            {
        //                balance -= amount;
        //                return true;
        //            }
        //            return false;
        //        }
        //    }

        //    BankAccount account = new BankAccount(1000m);
        //    account.Deposit(500m);
        //Console.WriteLine(account.Balance); // выводит 1500
        //bool success = account.Withdraw(200m);
        //    Console.WriteLine(success); // выводит True
        //Console.WriteLine(account.Balance); // выводит 1300

    }

    public void Methods()
    {

        //модификатор_доступа возвращаемый_тип ИмяМетода(параметры)
        //{
        //    // тело метода
        //}

        ////Модификатор доступа (например, public, private, protected, internal) определяет видимость метода.
        ////Возвращаемый тип указывает тип данных, которые метод возвращает.Если метод не возвращает значение,
        ////используется void.
        ////Имя метода должно быть описательным и отражать выполняемое действие.
        ////Параметры(опционально) указывают входные данные для метода.

        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //int result = Add(5, 3);
        //Console.WriteLine(result); // выводит 8

        ////передача параметров по назначению
        //public void PrintNumber(int number)
        //{
        //    Console.WriteLine(number);
        //}

        //int num = 5;
        //PrintNumber(num); // выводит 5

        ////передача параметров по ссылке
        //public void Increment(ref int number)
        //{
        //    number++;
        //}

        //int num = 5;
        //Increment(ref num);
        //Console.WriteLine(num); // выводит 6

        //public void GetValues(out int a, out int b)
        //{
        //    a = 10;
        //    b = 20;
        //}

        //int x, y;
        //GetValues(out x, out y);
        //Console.WriteLine($"x: {x}, y: {y}"); // выводит "x: 10, y: 20"

        ////параметры по умолчанию
        //public void PrintMessage(string message = "Hello, world!")
        //{
        //    Console.WriteLine(message);
        //}

        //PrintMessage(); // выводит "Hello, world!"
        //PrintMessage("Custom message"); // выводит "Custom message"

        ////Возвращаемые значения
        //public int Multiply(int a, int b)
        //{
        //    return a * b;
        //}

        //int result = Multiply(4, 5);
        //Console.WriteLine(result); // выводит 20

        //// Пример комплексного использования методов
        ////public class Calculator
        //{
        //    // Метод сложения
        //    public int Add(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    // Метод вычитания
        //    public int Subtract(int a, int b)
        //    {
        //        return a - b;
        //    }

        //    // Метод умножения
        //    public int Multiply(int a, int b)
        //    {
        //        return a * b;
        //    }

        //    // Метод деления
        //    public double Divide(int a, int b)
        //    {
        //        if (b == 0)
        //        {
        //            throw new DivideByZeroException("Деление на ноль невозможно.");
        //        }
        //        return (double) a / b;
        //    }
        //}

        //Использование методов класса Calculator
        //Calculator calculator = new Calculator();

        //int sum = calculator.Add(10, 5);
        //int difference = calculator.Subtract(10, 5);
        //int product = calculator.Multiply(10, 5);
        //double quotient = calculator.Divide(10, 5);

        //Console.WriteLine($"Сумма: {sum}"); // выводит "Сумма: 15"
        //Console.WriteLine($"Разница: {difference}"); // выводит "Разница: 5"
        //Console.WriteLine($"Произведение: {product}"); // выводит "Произведение: 50"
        //Console.WriteLine($"Частное: {quotient}"); // выводит "Частное: 2"

    }

    public void ConditionalsAndLoops()
    {
        //Используктся if-else if-else, когда нужно проверить условия, которые могут включать
        //в себя более сложные логические выражения.
        //Используется switch, когда нужно сравнить одно значение со множеством возможных значений.
        //Это особенно удобно для значений, которые имеют небольшое количество возможных вариантов,
        //таких как перечисления (enum) или целочисленные значения.
        if (условие)
        {
            // код, выполняемый если условие истинно
        }

        int number = 10;
        if (number > 5)
        {
            Console.WriteLine("Число больше 5");
        }

        if (условие)
        {
            // код, выполняемый если условие истинно
        }
        else
        {
            // код, выполняемый если условие ложно
        }

        int number = 3;
        if (number > 5)
        {
            Console.WriteLine("Число больше 5");
        }
        else
        {
            Console.WriteLine("Число меньше или равно 5");
        }

        if (условие1)
        {
            // код, выполняемый если условие1 истинно
        }
        else if (условие2)
        {
            // код, выполняемый если условие2 истинно
        }
        else
        {
            // код, выполняемый если ни одно из условий не истинно
        }

        int number = 7;
        if (number > 10)
        {
            Console.WriteLine("Число больше 10");
        }
        else if (number > 5)
        {
            Console.WriteLine("Число больше 5, но меньше или равно 10");
        }
        else
        {
            Console.WriteLine("Число меньше или равно 5");
        }

        switch (выражение)
        {
            case значение1:
                // код, выполняемый если выражение равно значению1
                break;
            case значение2:
                // код, выполняемый если выражение равно значению2
                break;
            // дополнительные case
            default:
                // код, выполняемый если выражение не совпадает ни с одним значением
                break;
        }

        int dayOfWeek = 3;
        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Неверный день недели");
                break;
        }

        //for: Используктся, когда известно количество итераций, или нужно выполнить цикл с шагом
        //     (например, перебор элементов массива).
        // while: Используктся, когда количество итераций заранее неизвестно и нужно повторять действия
        //        до выполнения определенного условия.
        //do -while: Используктся, когда нужно гарантированно выполнить тело цикла хотя бы один раз,
        //           а затем повторять до тех пор, пока условие истинно.

        for (инициализация; условие; итерация)
        {
            // тело цикла
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Итерация: " + i);
        }

        while (условие)
        {
            // тело цикла
        }

        int i = 0;
        while (i < 5)
        {
            Console.WriteLine("Итерация: " + i);
            i++;
        }

        do
        {
            // тело цикла
        } while (условие);

        int i = 0;
        do
        {
            Console.WriteLine("Итерация: " + i);
            i++;
        } while (i < 5);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " squared is " + (i * i));
        }

        int counter = 10;
        while (counter > 0)
        {
            Console.WriteLine("Counter: " + counter);
            counter--;
        }

        int j = 1;
        do
        {
            Console.WriteLine("Number is: " + j);
            j++;
        } while (j <= 5);


    }

    public void Operators()
    {
        int a = 5;
        int b = 3;
        int sum = a + b; // sum = 8

        int difference = a - b; // difference = 2

        int product = a * b; // product = 15

        int quotient = a / b; // quotient = 1 (целочисленное деление)

        int remainder = a % b; // remainder = 2

        a++; // a становится 6

        b--; // b становится 2

        bool result = (a > 0) && (b > 0); // result = true, если оба условия истинны

        result = (a > 0) || (b < 0); // result = true, если хотя бы одно из условий истинно

        result = !(a > 0); // result = false, если a больше 0

        if (a > b)
        {
            Console.WriteLine("a больше b");
        }
        else if (a == b)
        {
            Console.WriteLine("a равно b");
        }
        else
        {
            Console.WriteLine("a меньше b");
        }

        string result = (a > b) ? "a больше b" : "a меньше или равно b";

        switch (a)
        {
            case 1:
                Console.WriteLine("a равно 1");
                break;
            case 2:
                Console.WriteLine("a равно 2");
                break;
            default:
                Console.WriteLine("a не равно ни 1, ни 2");
                break;
        }

        int x = 10;
        int y = 3;

        int addition = x + y; // 13
        int subtraction = x - y; // 7
        int multiplication = x * y; // 30
        int division = x / y; // 3
        int modulus = x % y; // 1

        bool isTrue = true;
        bool isFalse = false;

        bool andResult = isTrue && isFalse; // false
        bool orResult = isTrue || isFalse; // true
        bool notResult = !isTrue; // false

        int number = 5;

        if (number > 0)
        {
            Console.WriteLine("Число положительное");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное");
        }
        else
        {
            Console.WriteLine("Число равно нулю");
        }

        string result = (number % 2 == 0) ? "Четное" : "Нечетное";
        Console.WriteLine(result);

        switch (number)
        {
            case 1:
                Console.WriteLine("Один");
                break;
            case 2:
                Console.WriteLine("Два");
                break;
            case 3:
                Console.WriteLine("Три");
                break;
            default:
                Console.WriteLine("Не один, не два, не три");
                break;
        }

        int A = 10;
        int B = 3;

        A %= B; // эквивалентно A = A % B
        Console.WriteLine(A); // результат будет 1, потому что 10 % 3 равно 1

        int num1 = 20;
        int num2 = 6;

        num1 %= num2; // эквивалентно num1 = num1 % num2
        Console.WriteLine(num1); // результат будет 2, потому что 20 % 6 равно 2

        int A = 10;
        int B = 5;

        bool result = A >= B; // result будет true, потому что 10 больше 5
        Console.WriteLine(result); // выводит True

        int C = 5;
        result = A >= C; // result будет true, потому что 10 равно 5
        Console.WriteLine(result); // выводит True

        int D = 15;
        result = A >= D; // result будет false, потому что 10 меньше 15
        Console.WriteLine(result); // выводит False

        double A = 7.5;
        double B = 3.2;

        bool result = A >= B; // result будет true, потому что 7.5 больше 3.2
        Console.WriteLine(result); // выводит True

        double C = 7.5;
        result = A >= C; // result будет true, потому что 7.5 равно 7.5
        Console.WriteLine(result); // выводит True

        double D = 10.0;
        result = A >= D; // result будет false, потому что 7.5 меньше 10.0
        Console.WriteLine(result); // выводит False

        string A = "apple";
        string B = "banana";

        bool result = A.CompareTo(B) >= 0; // result будет false, потому что "apple" меньше "banana"
        Console.WriteLine(result); // выводит False

        string C = "apple";
        result = A.CompareTo(C) >= 0; // result будет true, потому что "apple" равно "apple"
        Console.WriteLine(result); // выводит True

        string D = "aardvark";
        result = A.CompareTo(D) >= 0; // result будет true, потому что "apple" больше "aardvark"
        Console.WriteLine(result); // выводит True

        int age = 18;

        if (age >= 18)
        {
            Console.WriteLine("Вы совершеннолетний.");
        }
        else
        {
            Console.WriteLine("Вы несовершеннолетний.");
        }
    }

    public void DataTypes()
    {
        //типы данных
        sbyte g = 127;
        byte r = 255;
        short w = 256;
        ushort e = 300;
        int i = 10;
        uint y = 345345;
        float p = 10.7f;
        double o = 0.3245234523;
        long q = 12345345345;
        ulong t = 234523;
        decimal s = 12343.123m;
        bool f = true;
        char a = 'a';
        string d = "Draw";
        object h = "dfs";//может хранить любой тип данных
        var j = "hello";//при компиляции присваеваеться тип данных автоматически в зависимости от инициации.
        var k = 12;//например var k;
        var l = 'F';//        k= 12; не правильно!
    }


}


