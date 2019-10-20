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
            Console.Write("Podaj c:: ");
            string inputc = Console.ReadLine();
            double a = double.Parse(inputa);
            double b = double.Parse(inputb);
            double c = double.Parse(inputc);
            double wynik1, wynik2, wynik3;
            wynik1 = a * a + b;

        }
    }
}
