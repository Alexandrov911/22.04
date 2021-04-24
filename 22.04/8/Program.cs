using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= 1000; i++)
            {
                f = (n * i)/2;
            }
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
