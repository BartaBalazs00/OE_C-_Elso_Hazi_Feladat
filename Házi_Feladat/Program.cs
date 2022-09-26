using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] baratunkSzamai = new long[5];
            long[] sajatSzamaim = new long[5];
            long baratunkSzamainakOsszege = 0;
            long sajatSzamaimOsszege = 0;
            sajatSzamaim[4] = 0;
            for (int i = 0; i < 5; i++)
            {
                long szam = Convert.ToInt64(Console.ReadLine());
                
                while (szam > 10000000000 || szam < -10000000000)
                {
                    Console.WriteLine("Nem a megengedett intervallumon adtad meg add meg mégegyszer");
                    szam = Convert.ToInt64(Console.ReadLine());
                }
                //string stringSzam = Console.ReadLine();
                //int szam;
                //while (!int.TryParse(stringSzam, out szam))
                //{
                //    Console.WriteLine("Nem számot adtál meg, add meg újra");
                //    stringSzam = Console.ReadLine();
                //}
                baratunkSzamai[i] = szam;
                baratunkSzamainakOsszege += szam;
            }
            for (int i = 0; i < baratunkSzamai.Length; i++)
            {
                if (i < 4)
                {
                    if (baratunkSzamai[i] == 0)
                    {
                        sajatSzamaim[i] = i+1;
                    }
                    else if (baratunkSzamai[i] % 2 == 0)
                    {
                        //mi + 2 ∗ (i + 1)
                        sajatSzamaim[i] = baratunkSzamai[i] + 2 * (i + 1);
                    }
                    else if (baratunkSzamai[i] % 2 == 1 || baratunkSzamai[i] % 2 == -1)
                    {
                        //mi + ((i + 1)/2)
                        double osztas = (double)(i + 1) / 2;
                        sajatSzamaim[i] = baratunkSzamai[i] + (int)Math.Round(osztas, MidpointRounding.AwayFromZero);
                        sajatSzamaimOsszege += sajatSzamaim[i];
                    }
                }
                else
                {
                    sajatSzamaim[4] = baratunkSzamainakOsszege - sajatSzamaimOsszege;
                }
            }
            for (int i = 0; i < sajatSzamaim.Length-1; i++)
            {
                Console.Write(sajatSzamaim[i] + ",");
            }
            Console.Write(sajatSzamaim[4]);
            Console.ReadKey();
        }
    }
}
