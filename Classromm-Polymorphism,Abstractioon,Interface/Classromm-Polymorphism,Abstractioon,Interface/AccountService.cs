using Classromm_Polymorphism_Abstractioon_Interface.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classromm_Polymorphism_Abstractioon_Interface
{
    internal class AccountService : IAccountService, ICommonService
    {
        public string FullData()
        {
            throw new NotImplementedException();
        }
    }
}
