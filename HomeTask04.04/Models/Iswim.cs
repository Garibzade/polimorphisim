using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask04._04.Models
{
    internal interface Iswim
    {
        public int MaxSwimTime { get; set; } 
        void Swim();
    }
}
