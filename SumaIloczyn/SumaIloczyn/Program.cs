using System;

namespace SumaIloczyn
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort n, k, a;
            ulong iloczyn = 1, suma = 0;

            Console.Write("Podaj wartość zmiennej n: ");
            n = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej k: ");
            k = Convert.ToUInt16(Console.ReadLine());

            a = k;

            for (int i = 1; i <= n; i++)
            {
                suma += a;
                try
                {
                    iloczyn *= a;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                a += k;
            }
                Console.WriteLine("Suma = {0}" , suma);
                Console.WriteLine("Iloczyn = {0}", iloczyn);
                Console.ReadKey();
        }
    }
}
