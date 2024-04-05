using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask04._04.Models
{
    internal class Duck : Bird,Iswim
    {
        public Duck(string v)
        {
        }

        public int MaxSwimTime { get; set; } = 1;
        

        public override void Eat()
        {
            
        }

        public void Swim()
        {
            Console.WriteLine("dog swim");
        }
    }
}
