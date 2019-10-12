using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj jak wysoką chcesz choinkę: ");
            double y = double.Parse(Console.ReadLine());
            for (int i = 1; i <= y; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
            }






            Console.ReadKey();
        }
    }
}
