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
            int[] myArray = { -10, -1, 0, 3, 10, 11, 30, 40, 100 };
            int n = myArray.Length;
            Console.WriteLine("Fixed point is " + linearSearch(myArray, n));
            Console.ReadLine();
            return;

        }
        public static int linearSearch(int[] myArray, int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if (myArray[i] == i)
                    return i;
            }
            return -1;
        }
    }
}
