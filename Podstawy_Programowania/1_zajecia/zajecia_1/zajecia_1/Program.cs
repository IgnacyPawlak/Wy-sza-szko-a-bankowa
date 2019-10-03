using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.WriteLine("janusz");

            //zmienne i typy danych
            int x = 10;
            Console.WriteLine(x);

            int x1, y = 10, z = 15;
            x1 = 2;
            Console.Write("Zmienna x1 wynosi: ");
            Console.WriteLine(x1);
            //konkatenacja
            // \n nowa linia
            Console.WriteLine("y = " + y + "\nz = " + z);

            int a = 10;
            int b = a;
            b = 15;

            Console.WriteLine(a + " " + b);


            //alternatywny sposób deklaracji zmiennej
            //int c = 0

            int c = new int(); // wartość domyślna ==> null (brak referencji)

            Console.WriteLine("wartość zmiennej c " + c);
            //################################################################################
            Console.Write("Podaj swoje imię ");
            string name = Console.ReadLine() ;
            Console.WriteLine("Twoje imię podane z klawiatury: " + name);

            int z1 = 12;
            uint z2 = 20;

            float y1 = 10.55F;
            Console.WriteLine("Zmienna y1 = " + y1);

            double y2 = 10.95;
            Console.WriteLine("Zmienna y2 wynosi " + y2);

            /*
             * Oblicz pole prostokąta , dane użytkownik podajez klawiatury
             */

            Console.WriteLine("Program do obliczania pola prostokąta");
            Console.WriteLine("Podaj bok a");
            double bokA = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b");
            double bokB = double.Parse(Console.ReadLine());

            // double result = bokA * bokB;
            //Console.WriteLine("Pole wynosi: " + result);

            // bokA *= bokB;
            // Console.WriteLine("pole wynosi: ");

            Console.WriteLine("pole wynosi: " + bokA * bokB);







            Console.ReadKey();
        }
    }
}
