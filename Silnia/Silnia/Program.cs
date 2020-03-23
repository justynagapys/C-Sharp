using System;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            int liczba = int.Parse(Console.ReadLine());

            int x = wyliczSilnie(liczba);
            Console.WriteLine("Silnia dla {0} wynosi {1}.", liczba, x);

        }

        static int wyliczSilnie (int liczba)
        {
            
            int x = 1;
            if (liczba == 0)
            {
                return x;
            }
            else if (liczba < 0)
            {
                Console.WriteLine("BŁĄD! Nie możesz podać liczby ujemnej. Silnia zostanie źle obliczona.");
                x = 0;
                return x;
            }
            else
            {
                for (int i = 1; i <= liczba; i = i + 1)
                {
                    x *= i;
                }
                return x;
            }
        }
    }
}
