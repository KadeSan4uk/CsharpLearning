using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace D_OOP
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);
    }
    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int count = 0;
        public BaseList(int initialCapacity)
        {
           items= new object[initialCapacity];   
        }
        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
