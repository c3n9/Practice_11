using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double sum =0;
            int i = 0;
            //int[] array = { -4, -3, 0, 6, -4, 3, 5, 8, 7 };
            double[] array = { 10, -4, 6, 3.3, 5, -3.6 };
            for (; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    break;  
                }
            }
            for (++i; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > 0)
                {
                    break;
                }
            }
            Console.WriteLine("Суммы элементов массива, расположенных между первым и вторым положительными элементами " + sum);

        }
    }
}
