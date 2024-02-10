using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace D_OOP
{
    public class Poit2D
    {
        private int x;
        private int y;

        public Poit2D(int x, int y)
        {
            this.x = x;
        }
    }

    public class Character
    {

       // public static int speed = 10;
        //public const int speed = 10;//неизменяемый тип значения
        public readonly int speed;//можно инициализировать как =10; или потом в конструкторе

        public int Health { get; set; } = 100;

        public string Race { get; private set; }

        public int Armor{get; private set;}

        
        public Character(string race, int armor, int speed)
        {//конструктор класса (ctor) можно задать требуемые аргументы для защиты класса из вне
            Race = race;
            Armor = 30;
            this.speed = speed;
        }


        public int PrintSpeed()
        {
            return speed;
        }
        public void IncreaseSpeed()
        {
           // speed += 10;
        }

        


        //protected || член класса недоступен из вне, доступен в классах Наследниках
        //internal  || используется только в той сборке в которой обьявлены
        //private   || доступен только в классе 
        //public    || доступен везде




        //public int Health { get; private set; } = 100;
        //// упрощенный способ сделать метод(экономит место для кода)
        //public void Hit(int damage)
        //{
        //    if (damage > Health)
        //    {
        //        damage = Health;
        //    }
        //    //health -= damage; работает и со свойством
        //    Health -= damage;
        //    //var health = GetHealth() - damage;
        //    //SetHealth(health);
        //}

        //public int Health
        //{//инкапсуляция значения health, защита от внешнего пользования, доступно только для чтения
        //    get//обеспечивает доступ на чтение
        //    {
        //        return health;
        //    }
        //    private set// для изминения htalth с внешнего кода(в привате нельзя)
        //    {// set может быть internal и protected так же
        //        health = value;
        //    }
        //}
        ////свойство при компиляции превращается в 2 метода ниже
        //public int GetHealth()
        //{
        //    return health;
        //}
        //private void SetHealth(int value)
        //{
        //    health = value;
        //}

    }
}
