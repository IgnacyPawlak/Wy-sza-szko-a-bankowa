using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program pokazuje liczby parzyste z przedziału od 20 do 0");
            int x = 0;
            for (int i = 20;  i >=x ;i--)
            {
                if (i%2==0)
                    Console.Write(i + " " );
            }


            Console.ReadKey();
        }

    }

}
