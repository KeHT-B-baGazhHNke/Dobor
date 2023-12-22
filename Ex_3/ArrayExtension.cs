using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    public static class ArrayExtension
    {
        public static int[] Square(this int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * array[i];
            }
            return result;
        }
        public static int[] Cube(this int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i]*array[i]*array[i];
            }
            return result;
        }
        public static double Average(this int[] array)
        {
            int summ= 0;
            for (int i = 0; i < array.Length; i++)
                summ += array[i];
            return (double)summ / array.Length;
            //возвращает NaN автоматически т.к при пустом массиве будет 0/0
        }
        public static int Sum(this int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
                summ += array[i];
            return summ;
        }
        public static int[] Even(this int[] array)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result.Add(array[i]);
                }
            }
            
            return result.ToArray();
        }
        public static int[] Odd(this int[] array)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result.Add(array[i]);
                }
            }

            return result.ToArray();
        }
    }
}
