using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawa
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Ten program pokazuje czego się do tej pory nauczyłem");
            Console.WriteLine("Wybierz jedną z poniższych opcji");
            Console.WriteLine("1 - program do obliczania pola figur.\n2 - program , w którym decydujesz o losach bohatera.\n3 - program który odlicza np od 20 do 0");
            string choice = Console.ReadLine();
            switch (choice)
            {

                case "1":
                    start1:
                    Console.Clear();
                    Console.WriteLine("Wybrałeś program do obliczania pola figur. Pole której figury chcesz obliczyć?\n1 - kwadrat\n2 - prostokąt\n3 - trójkąt\n4 - koło");
                    switch (choice)
                    {

                        case "1":
                            Console.Clear();
                            Console.Write("Wybrałeś program do obliczania pola kwadratu.\n Podaj długość boku i wciśnij enter: ");
                            double a;
                            double.TryParse(Console.ReadLine(), out a);
                            double result = a * a;
                            Console.WriteLine("Pole kwadratu o boku {0} wynosi {1}", a, result);
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Wybrałeś program do obliczania pola prostokąta.\nPodaj długośś 1 boku i wciśnij enter, a następnie podaj długość drugiego boku i wciśnij enter");
                            double.TryParse(Console.ReadLine(), out a);
                            double b;
                            double.TryParse(Console.ReadLine(), out b);
                            result = a * b;
                            Console.WriteLine("Pole prostokąta o bokach " + a + " i " + b + " wynosi: " + result + ".");
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Wybrałeś program do obliczania pola trójkąta.\nPodaj długość podstawy i wciśnij enter, a następnie podaj wysokość trójkąta i wciśnij enter.");
                            double.TryParse(Console.ReadLine(), out a);
                            double.TryParse(Console.ReadLine(), out b);
                            result = (a * b) / 2;
                            Console.WriteLine("Pole trójkąta o podstawie {0} i wysokości {1} wynosi: {2}", a, b, result);
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Wybrałeś program do obliczania pola koła.\nPodaj długość promienia i wciśnij enter.");
                            double.TryParse(Console.ReadLine(), out a);
                            result = a * a * Math.PI;
                            Console.WriteLine("Koło o promieniu {0} ma pole równe {1}", a, result);
                            Console.ReadKey();
                            break;
                        default:
                    goto start1;
                    }
                    break;
                case "2":
                    start2:
                    Console.Clear();
                    Console.WriteLine("Wybrałeś program, w którym decydujesz o losach bohatera.\nJak chciałbyś/chciałabyś nazwać swojego bohatera?(wpisz i wciśnij enter)");
                    string name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Budzisz się w miejscowej tawernie po zapitej nocy. Nie pamiętasz jak się nazywa owa mieścina ani dlaczego wogóle spałeś/aś sam/a." +
                                        " Jedyne co wiesz to to, że nazywasz się " + name + ".");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Wybrałeś program, który odliczna w różne sposoby.\nWybierz w jaki sposób chcesz odliczać.(wpisz numer i wciśnij enter)\n1 - program liczący od 0 do 10\n2 - program pokazujący liczbt z przedziału od 100 do 0");
                    string choice3 = Console.ReadLine();
                    switch (choice3)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Wybrałeś program, który odlicza od 0 do 10. Wciśnij dowolny klawisz aby uruchomic program");
                            Console.ReadKey();
                            double a = 10;
                                for(int i = 0; a>=i; ++i)
                                Console.Write(i + " ");
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("wybrałeś program, który pokazuje parzyste liczby z przedziału od 100 do 0.\nWciśnij dowolny przycisk aby uruchomić program.");
                            Console.ReadKey();
                            double x = 0;
                            for (int i = 100; i>=x ;i--)
                                if (i%2==0)
                                    Console.Write(i + " ");
                            Console.ReadKey();
                            break;
                        default:
                            goto start2;
                    }
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Wybrałeś program, który narysuje \"drzewko\" z gwiazdek ,gdzie podasz ile ma mieć poziomów i jednocześnie na każdym poziomie będzie adekwatna do niego ilość " +
                        "gwiazdek");
                    Console.WriteLine("wprowadź ilu piętrowe drzewko byś chciał i wciśnij enter(tylko liczby dodatnie całkowite)");
                    string choice1 = Console.ReadLine();
                    double y;
                    double.TryParse(choice1,out y);
                    for (int i = 1; i <= y; i++)
                    {
                        Console.Write("\n");
                        for (int j = 1; j <= i; j++)
                            Console.Write("*");
                    }

                    Console.ReadKey();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Zły format. spróbuj ponownie.");
                    goto start;

            }


        }

    }
}
