using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Common
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[50];
            Common.Init(arr, rand);
            int[] arr1 = Common.FilterArrayOfInts(arr, a => a < 0 && a % 2 != 0);
            int[] arr2 = Common.FilterArrayOfInts(arr, a => a > 0 && a % 2 == 0);
            int[] arr3 = Common.FilterArrayOfInts(arr, (a) =>
            {
                for (int i = 2; i < Math.Abs(a); i++)
                {
                    if (a % i == 0 || a > 0)
                        return false;
                }
                return true;
            });
            Common.Show(arr);
            Common.Show(arr1);
            Common.Show(arr2);
            Common.Show(arr3);
        }
    }
}
