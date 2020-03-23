using System;

namespace Maksimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, max1, max2, max;

            Console.Write("Podaj pierwszą wartość: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj drugą wartość: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj trzecią wartość: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj czwartą wartość: ");
            d = Convert.ToInt32(Console.ReadLine());

            max1 = a > b ? a : b;
            max2 = c > d ? c : d;

            if (max1 > max2) {
                max = max1;
            }
            else
            {
                max = max2;
            }

            Console.WriteLine("Wartość maksymalna wynosi: {0}.", max);
            Console.ReadKey();
        }
    }
}
