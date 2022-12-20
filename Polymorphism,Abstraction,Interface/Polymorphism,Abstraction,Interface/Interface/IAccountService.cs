using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction_Interface.Interface
{
    internal interface IAccountService
    {
        void Login(string v1, string v2);

        internal interface IAccountService
        {
            void Login(string username, string password);
        }
    }
}
