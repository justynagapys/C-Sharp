using System;

namespace TotoLotek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[6]; //zdefiniowanie tablicy jednowymiarowej, sześcioelementowej
            Random generator = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.Next(1, 49); //wygnerowanie randomowej tablicy dla indeksu i
                for (int j = 1; j <= i; j++) //sprawdzenie powtórzeń dla indeksów od 1 do 5
                {
                    if (tablica[j] == tablica[j-1])
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Wylosowane liczby to:");
                foreach (int i in tablica)
                {
                    Console.Write("{0}, ", i);
                }
                Console.ReadKey();
        }
    }
}
