using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szerelos2
{
    internal class adat
    {
        public string szerelo;
        public List<string> gepek = new List<string>();
        public bool[] munka = new bool[7];
        public int minosites;
        public adat(string sor)
        {
            string[] szet = sor.Split(',');
            this.szerelo = szet[0];
            int utso = szet.Length-1;
            this.minosites = int.Parse(szet[utso]);
            for (int i = 1; i < szet.Length-8; i++)
            {
                gepek.Add(szet[i]);

            }
            int f = 6;
            for (int i = szet.Length-2; i > szet.Length-9; i--)
            {
                if (szet[i] == "X")
                {
                    munka[f] = true;                    
                }
                f--;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<adat> szerelok = new List<adat>();

            try
            {
                StreamReader reader = new StreamReader("pest.csv", Encoding.UTF8);


                while (!reader.EndOfStream)
                {
                    szerelok.Add(new adat(reader.ReadLine()));
                }
                Console.WriteLine("1. feladat: A fájl beolvasása sikeres!");
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException)

                    Console.WriteLine("Valami nem jó");
                else
                {
                    Console.WriteLine($"Egyéb hiba:  {e.Message}");
                }
                Console.ReadKey();
                Environment.Exit(-1);
            }

            #region 2. feladat

            #endregion

            #region 1.feladat
            Console.WriteLine($"1. feladat: {szerelok.Count()} db pesi szeretlő van. ");

            #endregion
            #region 2.feladat
            int length = szerelok.Count();
            int maximum = 0;

            for (int i = 0; i < length; i++)
            {
                if (szerelok[i].gepek.Count() > maximum)
                {
                    maximum = szerelok[i].gepek.Count();
                }


            }
            Console.WriteLine("2. feladat: ");
            for (int i = 0; i < length; i++)
            {
                if (szerelok[i].gepek.Count() == maximum)
                {
                    Console.WriteLine($"\t A legtöbb({maximum}) képesítéssel rendelkezők id-je: {szerelok[i].szerelo}");
                }
            }

            #endregion
            #region 3. feladat

            int elerhetosz = 0;
            int elerhetov = 0;
            for (int i = 0; i < length; i++)
            {
                if (szerelok[i].munka[5]) elerhetosz++;
                if (szerelok[i].munka[6]) elerhetov++;

            }
            Console.WriteLine($"3. feladat: Hétvégén {elerhetosz}db szombaton és {elerhetov} db vasárnap áll szerelő áll rendelkezésre.");
            #endregion
            #region 4. feladat



            int summ = 0;
            for (int i = 0; i < length; i++)
            {
                summ += szerelok[i].minosites;
            }
            float summ2 = (float)summ;
            float length2 = (float)length;

            float avg = summ2 / length2;






            int felette = 0;
            for (int i = 0; i < length; i++)
            {
                if (szerelok[i].minosites > avg)
                {
                    felette++;
                }
            }

            Console.WriteLine($"4. feladat: Az adatbázisban a szereplők átlagosan {Math.Round(avg, 2)} pontot kaptak, amelymél a szerelők {(felette / length2) * 100}%-a teljesít jobban");



            #endregion
            #region 5. feladat
            Console.WriteLine("5. feladat: Mind a három gázzal műkövő berendezéshez érők ID-je: ");
            for (int i = 0; i < length; i++)
            {
                if (szerelok[i].gepek.Contains("C") && szerelok[i].gepek.Contains("K") && szerelok[i].gepek.Contains("G"))
                {
                    Console.WriteLine($"\t {szerelok[i].szerelo}");
                }
            }


            #endregion

            #region 6. feladat
            Console.Write("6. feladat: Adja meg a keresendő eszköz nevét:");
            string keszulek = Console.ReadLine();
            string[] napok = new string[] { "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap" };
            if (keszulek != "C" && keszulek != "KG" && keszulek != "K" && keszulek != "H" && keszulek != "P" && keszulek != "MG" && keszulek != "MGT")

            {
                Console.WriteLine("Helytelen rövidítést adott meg");
            }
            else
            {
                foreach (var item in szerelok)
                {
                    bool erthozza = false;
                    foreach (var item2 in item.gepek)
                    {
                        if (item2 == keszulek)
                        {
                            erthozza = true;
                            break;
                        }

                    }
                    if (erthozza)
                    {
                        for (int i=0; i<item.munka.Length; i++)
                        {
                            if (item.munka[i])
                            {
                                napok[i] = "";
                            }
                        }
                    }

                }
                Console.Write("A keresettt TTTTTTTTTTTTTípushoz a következő napokon van szerelő: ");
                foreach (var item in napok)
                {
                    Console.Write($"{item} ");
                }
            }

            
            #endregion





            Console.ReadKey();


        }
    }
}
