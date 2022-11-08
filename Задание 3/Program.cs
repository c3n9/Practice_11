using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[] array = { -4, -3, 0, 6, -4, 3, 5, 8, 7 };
            double [] array = {10,-4,6,3.3,5,-3.6,17};
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] *= array[i];
                }
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
