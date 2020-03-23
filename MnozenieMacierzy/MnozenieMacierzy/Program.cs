using System;

namespace MnozenieMacierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n=3, m=3, k=2;

            double[,] macierzA = new double[n, k];
            double[,] macierzB = new double[k, m];
            double[,] macierzC = new double[n, m];

            Console.WriteLine("Podaj elementy macierzy A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("A[{0},{1}] = ", i + 1, j + 1);
                    macierzA[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("Podaj elementy macierzy B:");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("B[{0},{1}] = ", i+1,j+1);
                    macierzB[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        macierzC[i, j] = 0;
                        for (int l = 0; l < k; l++)
                        {
                            macierzC[i, j] += macierzA[i, l] * macierzB[l, j];
                        }
                    }
                }
                Console.WriteLine("Wynikiem mnożenia podanych macierzy jest macierz: ");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(macierzC[i, j] + "\t");
                    }
                Console.WriteLine();
                Console.ReadKey();
        }
    }
    }
}
