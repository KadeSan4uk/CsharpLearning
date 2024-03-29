﻿using System;

namespace C_ArraysCollection
{
     class ProgramC
    {
        static void Main(string[] args)
        {
            C_MethodRim.Parse("XIV");

            Console.WriteLine();
            
        }


        static void OldArrayNotUsing()
        {
            // Никогда так не делать, только для знания старого кода
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            Console.WriteLine($"Starting Index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending Index: {myArray.GetUpperBound(0)}");
            Console.WriteLine();

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {

                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
            Console.WriteLine();
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");

            }

        }
        static void jaggedArrays()
        {
            int[][] jaggetArray = new int[4][];
            jaggetArray[0] = new int[1];
            jaggetArray[1] = new int[3];
            jaggetArray[2] = new int[2];
            jaggetArray[3] = new int[4];

            Console.WriteLine("Enter the number for a jagged array");

            for (int i = 0; i < jaggetArray.Length; i++)
            {
                for (int j = 0; j < jaggetArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggetArray[i][j] = int.Parse(st);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Printing the Elements");
            for (int i = 0; i < jaggetArray.Length; i++)
            {
                for (int j = 0; j < jaggetArray[i].Length; j++)
                {
                    Console.Write(jaggetArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MultidimArrays()
        {
            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };// двумерный массив
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };// двумерный массив

            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void SteckQueue()
        {
            var queue = new Queue<int>();//очередь, первый приходит и первый уходит.
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out 1: {queue.Peek()}");

            queue.Dequeue();

            Console.WriteLine($"Should print out 2: {queue.Peek()}");

            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();


            var stack = new Stack<int>();// стек, последний заходит и первый выъодит.
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Should print out 3: {stack.Peek()}");

            Console.WriteLine("Iterate over the steck.");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
        static void Dictionary()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            people = new Dictionary<int, string>()
            {
                {1,"John" },
                {2,"Bob" },
                {3,"Alice" },
            };

            string name = people[1];
            Console.WriteLine(name);

            var keys = people.Keys; //Dictionary<int,string>.KeyCollection keys=people.Keys; (тоже самое)
            Console.WriteLine("Iterating over keys");
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Iterating over values");
            var values = people.Values;// Dictionary<int, string>.ValueCollection values = people.Values;(тоже самое)

            foreach (var key in values)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Iterating over key-value pairs");
            foreach (var pair in people)//(KeyValuePair<int, string> pair in people)
            {
                Console.WriteLine($"Key: {pair.Key}. Value: {pair.Value}.");// вывод Ключ Значение пара.
            }
            Console.WriteLine();

            Console.WriteLine($"Count = {people.Count}");

            bool containsKey = people.ContainsKey(2);//поиск ключа. Оооочень быстро
            bool containsValue = people.ContainsValue("John");

            Console.WriteLine($"Contains key: {containsKey}. Contains Value: {containsValue}.");

            people.Remove(1);

            if (people.TryAdd(2, "Elias"))
            {
                Console.WriteLine("Added successfuly");
            }
            else
            {
                Console.WriteLine("Failed to add using key 2");
            }

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val={val}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }

            people.Clear();

        }
        static void ListDemo()
        {
            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            if (intList.Remove(1))// удаляет только первое попадание
            {
                //Do
            }
            else { }

            intList.RemoveAt(0);

            intList.Reverse();

            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min={min} Max={max}");

            int indexOf = intList.IndexOf(2);
            int lastIndex = intList.LastIndexOf(2);
            Console.WriteLine(indexOf);
            Console.WriteLine(lastIndex);

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();

            foreach (int i in intList)
            {
                Console.Write($"{i} ");
            }
        }
        static void ArraysType()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);//Бинарный поиск по массиву(каждую итерацию сужает область поиска в 2 раза.
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] copy2 = new int[10];
            copy.CopyTo(copy2, 0);

            Array.Reverse(copy);
            foreach (var i in copy)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Array.Sort(copy);
            foreach (var i in copy)
            {
                Console.WriteLine(i);
            }

            Array.Clear(copy, 0, copy.Length);


            //int[] a1;

            //a1 = new int[10];

            //int[] a2= new int[5];

            //int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            //int[] a4 = { 1, 2, 3, 4, 5 };

            //Array myArray= new int[5];
            //Array myArray2 = Array.CreateInstance(typeof(int), 5);
            //myArray2.SetValue(12, 0);

            //Console.WriteLine(myArray2.GetValue(0));
        }
    }
}