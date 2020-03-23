using System;

namespace OdwrocenieZdania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź zdanie:");
            string [] text = Console.ReadLine().Split(' ');
            string [] zdanie = new string [text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                zdanie[i] = text[i];
            }
            Array.Reverse(zdanie);

            Console.WriteLine("Odwrócone zdanie:");
            foreach (string i in zdanie)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

        }
    }
}
