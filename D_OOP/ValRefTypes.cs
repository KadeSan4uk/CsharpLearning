using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace D_OOP
{
    public struct EvilStruct
    {
        public int X;
        public int Y;
        public readonly PointRef PointRef;

        public EvilStruct(int x, int y)
        {//данный конструктор в структуре можно создать только с получением аргументов
            X = x;
            Y = y;
            PointRef = new PointRef();
        }
        public void Do()
        {
            //PointRef= new PointRef();// в структуре нельзя создавать образец в методе.Только в конструкторе
        }
    }
    public struct PointVal
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X={X} Y={Y}");
        }
    }
    public class PointRef
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X={X} Y={Y}");
        }
    }
}
