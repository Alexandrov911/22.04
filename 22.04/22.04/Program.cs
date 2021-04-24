using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<10; i++ )
            {
                Console.Write(k + " ");
            }
            Console.WriteLine("введите число");
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

        }
    }
}
