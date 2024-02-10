using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace D_OOP
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shaep Greated");
        }
        public abstract void Draw();
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab,double bc,double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
        }
        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Shape
    {
        private readonly double widht;
        private readonly double heght;

        public Rectangle(double widht,double heght)
        {
            this.widht = widht;
            this.heght = heght;

            Console.WriteLine("Rectangle Greated");
        }

        public override double Area()
        {
            return widht * heght;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimeter()
        {
            return 2 * (widht + heght);
        }
    }
}
