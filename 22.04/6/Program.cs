using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            double n = Convert.ToDouble(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s +1.0/i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
