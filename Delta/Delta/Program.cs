using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            try
            {
                Console.WriteLine("Podaj wartość parametru a:");
                a = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    throw new System.Exception("Parametr a nie może być równy 0.");
                }

                Console.WriteLine("Podaj wartość parametru b:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wartość parametru c:");
                c = Convert.ToDouble(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    x1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                    x2= ((-b) + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste: x1={0} i x2={1}.",x1,x2);
                }
                else if (delta == 0)
                {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty: x={0}.",x1);
                }
                else
                {
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Program nie może obliczyć delty. {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
