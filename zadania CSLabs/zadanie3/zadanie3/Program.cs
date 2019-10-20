using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 3.\nProgram oblicza największy dzielnik dwóch liczb dodatnich całkowitych.\nPodaj Pierwszą liczbę: ");
            string inputa = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę: ");
            string inputb = Console.ReadLine();
            int a = int.Parse(inputa);
            int b = int.Parse(inputb);
            int LowerNumber;
            if (a <= b)
            {
                LowerNumber = a;
            }
            else
            {
                LowerNumber = b;
            }
            for (int i = 0; i <= LowerNumber; i++)

        }
    }
}
