using System;

namespace Dwie_cyfry_silni
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for(int i=0;i<test;i++)
            {
                int ile = int.Parse(Console.ReadLine());
                int silnia = 1;
                int LiczbaJednosci = 0;
                int LiczbaDziesiatek = 0;
                if (ile < 10)
                {
                    for (int j = 1; j <= ile; j++)
                    {
                        silnia = silnia * j;
                    }
                    LiczbaJednosci = silnia % 10;
                    LiczbaDziesiatek = (silnia % 100) / 10;
                    Console.WriteLine(LiczbaDziesiatek + " " + LiczbaJednosci);
                }
                else
                {
                    Console.WriteLine(LiczbaDziesiatek + " " + LiczbaJednosci);
                }
            }
            
        }
    }
}
