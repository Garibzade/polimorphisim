using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask04._04.Models
{
    internal class shark : Fish
    {
        public shark(string v)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Samir yeyir");
        }

        public void Shark() { Console.WriteLine("smeel"); }
    }
}
