using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace D_OOP
{// обычно название класса и есть название файла класса. Но этот файл учебный=)
    public class BankTerminal
    {
        protected string id;
        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine("General Connecting Protocol...");
        }
    }
    public class ModelXTerminal:BankTerminal
    {
        public ModelXTerminal(string id):base(id) 
        {
        }
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("Additional actions for Model X");
        }
    }
    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id)
        {
        }
        public override void Connect()
        {
            
            Console.WriteLine("Actions for Model Y");
        }
    }

}
