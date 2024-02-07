using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace D_OOP
{
   public  class Character
    {
        //protected || член класса недоступен из вне, доступен в классах Наследниках
        //internal  || используется только в той сборке в которой обьявлены
        //private   || доступен только в классе 
        //public    || доступен везде
        public static int speed = 10;

        public int PrintSpeed()
        {
            return speed;
        }
        public void IncreaseSpeed()
        {
            speed += 10;
        }







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
