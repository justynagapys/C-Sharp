using System;

namespace ZamianaZnakow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz słowo");
            string text = Console.ReadLine();
            char[] słowo = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                słowo[i] = text[i];
            }
            słowo[text.Length-1] = text[0];
            słowo[0] = text[text.Length-1];

            foreach (char i in słowo)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
