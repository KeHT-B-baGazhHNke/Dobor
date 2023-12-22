using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool success = int.TryParse(Console.ReadLine(), out n);
            //добавил еще возможность напечатать ромб нулевого размера,
            //потому что не было в условии задачи его не печатать,
            //но как будто смысла это не имеет
            if (success && n % 2 != 0 && n >= 0 || n == 0)
            {
                for (int i = 1; i < n; i += 2)
                {
                    string stars1 = string.Concat(Enumerable.Repeat("*", i));
                    string spaces = string.Concat(Enumerable.Repeat(" ", (n - i)/2));
                    Console.Write($"{spaces}{stars1}\n");
                }
                for (int i = n; i >= 1; i -= 2)
                {
                    string stars2 = string.Concat(Enumerable.Repeat("*", i));
                    string spaces = string.Concat(Enumerable.Repeat(" ", (n - i) / 2));
                    Console.Write($"{spaces}{stars2}\n");
                }
            }
            else
            {
                Console.WriteLine("None\nНевозможно напечатать ромб заданного размера");
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
