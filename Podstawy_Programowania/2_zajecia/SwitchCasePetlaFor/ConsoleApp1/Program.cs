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
            Console.WriteLine("1 - program do obliczania pola prostokąta\n2 - program do obliczania pola koła\nWybierz który program chcesz użyć. Wprowadź liczbę");
            string choice = Console.ReadLine();
            double choice1;
            switch (choice)
            {
                case "1":
                    {
                        if (double.TryParse(choice, out choice1))
                        {
                            Console.Clear();
                            Console.WriteLine("Wybrałeś program do obliczania pola prostokąta.\nPodaj długości boków");
                            double a = double.Parse(Console.ReadLine());
                            double b = double.Parse(Console.ReadLine());
                            double wynik = a * b;
                            Console.WriteLine("Pole prostokąta wynosi: " + wynik);


                        }
                        break;
                    }
                case "2":
                    {
                        if (double.TryParse(choice, out choice1))
                        {
                            Console.Clear();
                            Console.WriteLine("Wybrałeś program do obliczenia pola koła.\nPodaj długość promienia: ");
                            double a = double.Parse(Console.ReadLine());
                            double wynik = a * a * Math.PI;
                            Console.WriteLine("Pole tego koła wyni: {0}", wynik);

                        }
                        break;
                    }
                default:
                    Console.WriteLine("zły format liczby");
                    break;
            }
            Console.ReadKey();


        }
    }
}
