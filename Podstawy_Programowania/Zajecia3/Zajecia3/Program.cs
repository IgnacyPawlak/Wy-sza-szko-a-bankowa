using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Program zawiera ćwiczenia, które robiliśmy na trzecich labolatoriach\nProszę wpisać numer programu, który chcesz uruchomić, a następnie wcisnąć enter\n" +
                "1 - Program liczący funkcję x = 4y dla zakresu podanego przez użytkownika\n" +
                "2 - Program liczący sumę elementów z podanego przez użytkownika przedziału\n" +
                "3 - Program pokazujący tabliczkę mnożenia od 1 do 10\n" +
                "4 - Program, który wyświetla duże litery alfabetu od A do Z i od Z do A\n" +
                "5 - Zasady działania break\n" +
                "6 - Zasady działania break\n" +
                "7 - Program, który umieszcza w tablicy dziesięcio elementowej, jednowymiarowej umieszcza liczby całkowite z przedziału od 1 do 10. Jak budować tablice.\n" +
                "8 - Program, który w pięcio elementowej tablicy jednowymiarowej o nazwie colors umieszcza nazwy kolorów podane z klawiatury przez użytkownika.");
            string inputChoice = Console.ReadLine();
            double choice;
            double.TryParse(inputChoice, out choice);
            switch (choice)
            {
                case 1:
                    startProgram1:
            Console.WriteLine("Program obliczający fukcję x=4y dla liczb w przedziale podanym przez użytkownika.\nProszę podać dolny zakres przedziału i wcisnąc enter" +
                "a następnie górny zakres i wcisnąć enter.");
            string inputDolnyZakres = Console.ReadLine();
            string inputGornyZakres = Console.ReadLine();
            double DolnyZakres, GornyZakres, y;
            if (double.TryParse(inputDolnyZakres, out DolnyZakres) && double.TryParse(inputGornyZakres, out GornyZakres))
            {
                if (DolnyZakres > GornyZakres)
                {
                    Console.Clear();
                    Console.WriteLine("{0} jest większe niż {1} więc dane są niepoprawne", DolnyZakres, GornyZakres);
                    goto startProgram1;
                }
                else
                {
                    Console.Clear();
                    do
                    {
                        y = DolnyZakres * 4;
                        Console.WriteLine("x = {0}\ty = {1}", DolnyZakres, y);
                        DolnyZakres++;
                    }
                    while (DolnyZakres <= GornyZakres);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0}; {1} - złe dane. Po wciśnięciu dowolnego przycisku wrócisz do początku programu", inputDolnyZakres, inputGornyZakres);
                Console.ReadKey();
                goto Start;
            }
            Console.ReadKey();
                    break;
                case 2:
                startProgram2:
                    Console.Clear();
                    double sumaForProgram2 = 0;
                    Console.WriteLine("Program liczący sumę elementów z podanego przez użytkownika przedziału\n" +
                        "Proszę podać dolną granicę przedziału, wcisnąć enter, a następnie podać górną granice przedziału i wcisnąć enter.");
                    string inputDolnaGranicaForProgram2 = Console.ReadLine();
                    string inputGornaGranicaForProgram2 = Console.ReadLine();
                    double DolnaGranicaForProgram2, GornaGranicaForProgram2;
                    if (double.TryParse(inputDolnaGranicaForProgram2, out DolnaGranicaForProgram2) && double.TryParse(inputGornaGranicaForProgram2, out GornaGranicaForProgram2))
                    {
                        if (DolnaGranicaForProgram2 > GornaGranicaForProgram2)
                        {
                            Console.WriteLine("{0} jest większe niż {1}. Złe wprowadzenie danych. Po kliknięciu jakiegokolwiek przycisku wrócisz do początku programu.");
                            goto startProgram2;
                        }
                        else
                        {
                            do
                            {
                                sumaForProgram2 += DolnaGranicaForProgram2;
                                DolnaGranicaForProgram2++;
                            }
                            while (DolnaGranicaForProgram2 <= GornaGranicaForProgram2);
                            Console.WriteLine("Suma wynosi: {0}", sumaForProgram2);
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podane dane nie mogą być granicami przedziałów. Po kliknięciu jakiegokolwiek przycisku wrócisz do początku programu.");
                        Console.ReadKey();
                        goto startProgram2;
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        double wiersz, kolumna, wynik;
                        wiersz = 1;
                        Console.Clear();
                        do
                        {
                            kolumna = 1;
                            do
                            {
                                wynik = wiersz * kolumna;
                                Console.Write("{0}\t", wynik);
                                kolumna++;
                            } while (kolumna <= 10);
                            Console.Write("\n");
                            wiersz++;
                        } while (wiersz <= 10);
                        Console.ReadKey();
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Program, który wyświetla duże litery alfabetu od A do Z i od Z do A.\nKliknij dowolny przycisk aby uruchomić program.");
                        Console.ReadKey();
                        char litera = 'A';
                        for (; litera <= 'Z'; litera++)
                            if (litera < 'Z')
                                Console.Write(litera + ", ");
                            else
                                Console.Write(litera+".");
                        Console.Write("\n");
                        for (char litera2 = 'Z'; litera2 >= 'A'; litera2--)
                            if (litera2 > 'A')
                                Console.Write(litera2 + ", ");
                            else
                                Console.Write(litera2 + ".");
                        Console.ReadKey();
                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine("Program pokazuje zasady działania komendy continue.");
                        Console.WriteLine("for (int i = 1; i <=10; i++)\n{\n\tif (i == 2 || i == 4 || i == 9)\n\tcontinue;\n\telse\n\tConsole.WriteLine(i);\n}");
                        for (int i = 1; i <=10; i++)
                        {
                            if (i == 2 || i == 4 || i == 9)
                                continue;
                            else
                                Console.WriteLine(i);
                        }
                        Console.ReadKey();
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("Program pokazuje zasady działania komendy break.");
                        Console.WriteLine("for (int i = 1; i <=10; i++)\n{\n\tif (i == 6 || i == 8 || i == 10)\n\tbreak;\n\telse\n\tConsole.WriteLine(i);\n}");
                        for (int i = 1; i <= 10; i++)
                        {
                            if (i == 6 || i == 8 || i == 10)
                                break;
                            else
                                Console.WriteLine(i);
                        }
                        Console.ReadKey();
                    }
                    break;
                case 7:
                    {
                        Console.Clear();
                        Console.WriteLine("Program, który umieszcza w tablicy dziesięcio elementowej, jednowymiarowej umieszcza liczby całkowite z przedziału od 0 do 9. Jak budować tablice.");
                        int n = 10, i;
                        int[] tablica = new int[n];
                        for (i = 0; i < tablica.Length; i++)
                            tablica[i] = i;
                        for (i = 0; i < tablica.Length; i++)
                            Console.WriteLine(tablica[i]);
                        Console.ReadKey();
                    }
                    break;
                case 8:
                    {
                        Console.Clear();
                        Console.WriteLine("Program, który w pięcio elementowej tablicy jednowymiarowej o nazwie colors umieszcza nazwy kolorów podane z klawiatury przez użytkownika.");
                        int n = 5, i;
                        string kolor;
                        string[] colors = new string[n];
                        for (i = 0; i < colors.Length; i++)
                        {
                            Console.WriteLine("Wprowadź kolor:");
                            kolor = Console.ReadLine();
                            colors[i] = kolor;
                        }
                        for (i = 0; i < colors.Length; i++)
                        Console.WriteLine(colors[i] + " ");
                        Console.ReadKey();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Wpisane znaki nie odpowiadają możliwym wyborom. Po kliknięciu jakiegokolwiek przycisku wrócisz do początku programu.");
                        Console.ReadKey();
                        goto Start;
                    }
            }
        }
    }
}
