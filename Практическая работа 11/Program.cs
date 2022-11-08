using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mul1 = 1;
            double mul2 = 1;
            int[] array = { 2,5,6,-3,5,7,8,2,5,9 };
            double[]arrayTwo = {10, -4, 6, 3.3, 5, -3.6};
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2 == 0)
                {
                    mul1 *= array[i];
                }
            }
       
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    mul2 *= arrayTwo[i];
                }
            }
            Console.WriteLine("Произведение элементов 1 массива с четными номерами: " + mul1);
            Console.WriteLine("Произведение элементов 2 массива с четными номерами: " + mul2);
        }
    }
}
