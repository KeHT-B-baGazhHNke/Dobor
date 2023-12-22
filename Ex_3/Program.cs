using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = [1,2,3,4,5,6,7,8,9];
            Console.WriteLine(string.Join(" ", example));
            Console.WriteLine(string.Join(" ", example.Square()));
            Console.WriteLine(string.Join(" ", example.Cube()));
            Console.WriteLine(string.Join(" ", example.Average()));
            Console.WriteLine(string.Join(" ", example.Sum()));
            Console.WriteLine(string.Join(" ", example.Even()));
            Console.WriteLine(string.Join(" ", example.Odd()));
            Console.WriteLine(string.Join(" ", example));
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
