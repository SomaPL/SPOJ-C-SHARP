using System;

namespace Proste_dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for(int i=0;i<test;i++)
            {
                int ile = int.Parse(Console.ReadLine());
                string liczby = Console.ReadLine();
                string[] liczbyTab = liczby.Split(' ');
                int wynik = 0;
                for(int j=0;j<liczbyTab.Length;j++)
                {
                    wynik += int.Parse(liczbyTab[j]);
                }
                Console.WriteLine(wynik);
                
            }
        }
    }
}
