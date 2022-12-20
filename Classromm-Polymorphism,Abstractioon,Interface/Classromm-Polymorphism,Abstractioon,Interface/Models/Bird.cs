using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classromm_Polymorphism_Abstractioon_Interface.Models
{
    internal class Bird : Animal
    {
        public string Type { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
    }
}
