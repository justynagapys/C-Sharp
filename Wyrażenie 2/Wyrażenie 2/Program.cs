using System;

namespace Wyrażenie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.Write("Podaj wartość zmiennej x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej y: ");
            y = Convert.ToDouble(Console.ReadLine());

            if (x <0 && y < 0)
            {
                z = x * y;
            }
            else if (x==0 || y==0)
            {
                z = 10;
            }
            else
            {
                z = x + y;
            }

            Console.WriteLine("Wartość z wynosi: {0}.", z);
            Console.ReadKey();
        }
    }
}
