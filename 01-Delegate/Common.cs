using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Common
{
    class Common
    {

        public delegate bool IntFilter(int i);
        public static void Init(int[] arr, Random rand)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-200, 100);
        }

        public static int[] FilterArrayOfInts(int[] ints, IntFilter filter)
        {
            ArrayList aList = new ArrayList();
            foreach (int i in ints)
            {            
                if (filter(i))
                {
                    aList.Add(i);
                }
            }
            return ((int[])aList.ToArray(typeof(int)));
        }
        public static void Show(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"{Environment.NewLine}----------------------------------------------");
        }
    }
}
