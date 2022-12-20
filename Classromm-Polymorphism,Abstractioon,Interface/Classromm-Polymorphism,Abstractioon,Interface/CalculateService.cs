using Classromm_Polymorphism_Abstractioon_Interface.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classromm_Polymorphism_Abstractioon_Interface
{
    internal class CalculateService : ICalculateService, ICommonService
    {

        public string FullData()
        {
            throw new NotImplementedException();
        }

        public int GetSumNumbersFromArray(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public void SumNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }



    }
}
