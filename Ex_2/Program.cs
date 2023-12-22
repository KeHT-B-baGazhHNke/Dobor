using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        private static string[] Sort(string[] lines)
        {
            return lines.OrderBy(x => x.Length).ToArray();
        }
            static void Main(string[] args)
        {
            string[] example = ["Telescopes", "Glasses", "Eyes", "Monocles"];
            Console.WriteLine(string.Join(" ", Sort(example)));
            Console.ReadKey();
        }
    }
}
