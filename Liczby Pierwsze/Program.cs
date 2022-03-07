using System;

namespace Liczby_Pierwsze
{
    class Math 
    {
         public static bool czyPierwsza(int liczbaPierwsza)
        {
            if (liczbaPierwsza < 2)
                return false;
            for (int i = 2; i < liczbaPierwsza; i++)
                if (liczbaPierwsza % i == 0)
                    return false;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int testy = int.Parse(Console.ReadLine());
            for(int i=0;i<testy;i++)
            {
                int liczbaPierwsza = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.czyPierwsza(liczbaPierwsza)?"TAK":"NIE");
            }
        }
    }
}
