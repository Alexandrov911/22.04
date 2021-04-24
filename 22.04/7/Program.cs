using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        { 
            //5.28 а
            Console.WriteLine("введите число");
            int k = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 8; i <=15; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
           

            //5.28 б
            Console.WriteLine("введите число");
            int b = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for (int i = a; i <= 20; i++)
            {
                a = b*i;
            }
            Console.WriteLine(a);

            //5.28 в
            Console.WriteLine("введите число");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = 1;
            for (int i = 1; i <= d; i++)
            {
                d = c * i;
            }
            Console.WriteLine(d);
          

            //5.28 г
            Console.WriteLine("введите число a");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число b");
            int aa = Convert.ToInt32(Console.ReadLine());
            int oo = 1;
            for (int i = kk; i <=aa ; i++)
            {
                oo = kk*aa * i;
            }
            Console.WriteLine(oo);




            Console.ReadKey();
        }
        
    }
}
