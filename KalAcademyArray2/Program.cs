using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalAcademyArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { -10, -4, 1, 3, 4, 11, 30, 40, 100 };
            int n = myArray.Length;
            Console.WriteLine("Fixed point is " + BinarySearch(myArray, 0, n-1));
            Console.ReadLine();
            return;

        }
        /*public static int linearSearch(int[] myArray, int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if (myArray[i] == i)
                    return i;
            }
            return -1;
        }*/
        public static int BinarySearch(int[] myArray, int low, int high)
        {
            if (high >= low)
            {
                int mid = (low + high) / 2;
                if (mid == myArray[mid])
                    return mid;
                if (myArray[mid] < mid)
                    return BinarySearch(myArray, (mid + 1), high);
                else
                    return BinarySearch(myArray, low, (mid - 1));
                        }
            return -1;
        }
    }
}
