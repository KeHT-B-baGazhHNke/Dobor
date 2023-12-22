using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//:) :D :-) :-D :~) :~D ;) ;D ;-) ;-D ;~) ;~D

namespace Ex_4
{
    internal class Program
    {
        private static int countSmileys(string[] array)
        {
            int i = 0;
            foreach(string item in array)
            {
                if (item.Equals(":)") || item.Equals(":D") || item.Equals(":-)") || item.Equals(":-D") || item.Equals(":~)") || item.Equals(":~D") || item.Equals(";)") || item.Equals(";D") || item.Equals(";-)") || item.Equals(";-D") || item.Equals(";~)") || item.Equals(";~D"))
                    {
                    i++;
                    }
            }
            return i;
        }
        static void Main(string[] args)
        {
            string[] example = {":)",":D",";-D",":~)",";(", ":>", ":}", ":]" };
            Console.WriteLine(countSmileys(example));
            Console.ReadKey();
        }
    }
}
