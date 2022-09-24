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
            int[] baratunkSzamai = new int[5];
            int[] sajatSzamaim = new int[5];
            sajatSzamaim[4] = 0;
            for (int i = 0; i < 5; i++)
            {
                string stringSzam = Console.ReadLine();
                int szam;
                while (!int.TryParse(stringSzam, out szam))
                {
                    Console.WriteLine("Nem számot adtál meg, add meg újra");
                    stringSzam = Console.ReadLine();
                }
                baratunkSzamai[i] = szam;
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
                    }
                }
                else
                {
                    int baratunkSzamainakOsszege = baratunkSzamai.Sum();
                    int sajatSzamaimOsszege = sajatSzamaim.Sum();
                    sajatSzamaim[4] = baratunkSzamainakOsszege - sajatSzamaimOsszege;
                }
            }
            for (int i = 0; i < sajatSzamaim.Length-1; i++)
            {
                Console.Write(sajatSzamaim[i] + ", ");
            }
            Console.Write(sajatSzamaim[4]);
        }
    }
}
