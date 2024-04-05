using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask04._04.Models
{
    internal  class Baykush:Bird
    {
        static void TurnHead180dgr()
        {
            Console.WriteLine("bayqus ki bayqus");
        }

        public override void Eat()
        {
            Console.WriteLine("Eli yeyir");
        }

        //public override Fly()
        //{
        //    Console.WriteLine("bayqus ucur");
        //}
    }
}
