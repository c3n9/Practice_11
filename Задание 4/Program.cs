using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] {3,4,6,9,12,8,7,4,12,100 };
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        n = array[i];
                        array[i] = array[j];
                        array[j] = n;
                    }
                }
       
            }
            Console.WriteLine("Группировка элементов массива методом пузырька(по убыванию)");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
