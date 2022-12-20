using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classromm_Polymorphism_Abstractioon_Interface.Models
{
    internal class Car
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public void Test()
        {
            Console.WriteLine("Seald class");
        }
    }
}
