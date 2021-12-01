using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picking_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numArray = new List<int>() { 4, 6, 5, 3, 3, 1 };
            List<int> numArray = new List<int>() { 1, 2, 2, 3, 1, 2 };

            int maxCount = 0;
            int count = 0;

            for(int i = 0; i< numArray.Count(); i++)
            {
                var currentValue = numArray[i];
                count = numArray.Where(val => (val <= currentValue + 1) && (val >= currentValue)).Count();
                if(count > maxCount)
                {
                    maxCount = count;
                }
            }
            Console.WriteLine(maxCount);
            Console.ReadKey();
        }
    }
}
