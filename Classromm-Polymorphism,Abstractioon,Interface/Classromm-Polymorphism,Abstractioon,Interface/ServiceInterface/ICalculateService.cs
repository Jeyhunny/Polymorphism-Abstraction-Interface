using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classromm_Polymorphism_Abstractioon_Interface.ServiceInterface
{
    internal interface ICalculateService
    {
        void SumNumbers(int v1, int v2);

        internal interface ICalculateService
        {
            void SumNumbers(int num1, int num2);
            int GetSumNumbersFromArray(int[] numbers);

        }
    }
}
