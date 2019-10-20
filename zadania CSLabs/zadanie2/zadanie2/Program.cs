using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 2.\nProgram obliczający wartości wyrażeń.");
            Console.Write("Podaj a: ");
            string inputa = Console.ReadLine();
            Console.Write("Podaj b: ");
            string inputb = Console.ReadLine();
            Console.Write("Podaj c: ");
            string inputc = Console.ReadLine();
            double a = double.Parse(inputa);
            double b = double.Parse(inputb);
            double c = double.Parse(inputc);
            double wynik1, wynik2, wynik3;
            wynik1 = a * a + b;
            wynik2 = a - b * b;
            wynik3 = 1 / (a - b);
            if (c > 0)
                Console.WriteLine(wynik1);
            if (c<0)
                Console.WriteLine(wynik2);
            if (c == 0)
            {
                if (a == b)
                    Console.WriteLine("Próba dzielenia przez 0");
                else
                Console.WriteLine(wynik3);
            }
            Console.ReadLine();
        }
    }
}
