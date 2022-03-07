using System;

namespace Prędkość_Średnia
{
    class Program
    {
        static void Main(string[] args)
        {
            int testy = int.Parse(Console.ReadLine());
            for(int i=0;i<testy;i++)
            {
                string[] liczbytab = Console.ReadLine().Split(' ');
                int v1 = int.Parse(liczbytab[0]);
                int v2 = int.Parse(liczbytab[1]);
                int wynik = 0;
                wynik = 2 * v1 * v2 / (v1 + v2);
                Console.WriteLine(wynik);

            }
        }
    }
}
