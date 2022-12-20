using Polymorphism_Abstraction_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction_Interface
{
    internal class AccountService: IAccountService

    {
        public void Login(string username, string password)
        {
            if (username == "Ceyhun123" && password == "Ceyhun2000")
            {
                Console.WriteLine("Girish ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehvdir");
            }
        }
    }
}
