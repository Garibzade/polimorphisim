using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask04._04.Models
{
    internal abstract class Bird:Animal
    {
        //public abstract void Fly();

        public virtual void Fly()
        {
            Console.WriteLine("ucular");
        }

       
    }
}
