using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask04._04.Models
{
    internal abstract class Fish:Animal,Iswim
    {
        public int MaxSwimTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Swim() { Console.WriteLine("can swim"); }

      
        
    }
}
