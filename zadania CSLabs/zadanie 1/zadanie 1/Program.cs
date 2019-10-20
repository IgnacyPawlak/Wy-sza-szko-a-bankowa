using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1.\nProgram oblicza wartość wyrażenia (a * a + b)/((a + b) * (a + b)).\nPodaj zmienną a, wciśnij enter, a następnie podaj zmienną b i wciśnij enter.");
            string inputa = Console.ReadLine();
            string inputb = Console.ReadLine();            
            float a = float.Parse(inputa);
            float b = float.Parse(inputb);
            float wynik;
            wynik = (a * a + b) / ((a + b) * (a + b));
            Console.WriteLine("Twój wynik to {0}", wynik);
            Console.ReadKey();
        }
    }
}
