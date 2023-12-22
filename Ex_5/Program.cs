using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> example = new List<int>() { 13, 1, -6};
            List<int> result = new List<int>();
            result = example.OrderBy(x => Math.Abs(x)).ToList();
            int n = result.ElementAt(0);
            int i = 1;
            if (Math.Abs(result[1]) == Math.Abs(n))
            {
                while (Math.Abs(result[i]) == Math.Abs(n))
                {
                    if (result[i] == n * (-1))
                    {
                        Console.WriteLine("None");
                        break;
                    }
                    i++;
                    if ((Math.Abs(result[i]) >= Math.Abs(n)))
                    {
                        Console.WriteLine(n);
                    }
                }
            }
            else
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
