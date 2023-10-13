using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Deniz_Manavotomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] halmeyveler = new string[3] { "Elma", "Armut", "Karpuz" };
            string[] halsebzeler = new string[3] { "Domates", "Biber", "Soğan" };
            int[] meyvekg = new int[3] { 0, 0, 0 };
            int[] sebzekg = new int[3] { 0, 0, 0 };
            string[] Manavmeyve = new string[3];
            string[] Manavsebze = new string[3];

            while (true)
            {
                Console.WriteLine("---MANAV---\n\n1-HAL\n2-MANAV");
                Console.Write("\nSecim yapiniz: ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                HAL:
                    Console.Clear();
                    Console.WriteLine("----HAL BOLUMU----\n\n1-MEYVE\n2-SEBZE\n3-CIKIS");
                    Console.Write("\nIslem seciniz: ");
                    string halsecim = Console.ReadLine();

                    if (halsecim == "1")
                    {
                        Console.Clear();
                        for (int i = 0; i < halmeyveler.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + halmeyveler[i] + " (" + meyvekg[i] + " KG)");
                        }
                        Console.Write("\nSatin alacaginiz urunu seciniz: ");
                        int secilenurun = Convert.ToInt32(Console.ReadLine());
                        if (secilenurun > halmeyveler.Length)
                        {
                            Console.WriteLine("Yanlis bir secim yaptiniz.");
                            Thread.Sleep(1000);
                            goto HAL;
                        }
                        Array.Copy(halmeyveler, (secilenurun - 1), Manavmeyve, (secilenurun - 1), 1);
                        Console.Write("Kaç kilogram alacağınızı giriniz:");
                        int halsecimkg = Convert.ToInt32(Console.ReadLine());
                        meyvekg[secilenurun - 1] += halsecimkg;
                        Console.WriteLine("Islem basarili.");
                        Thread.Sleep(1000);
                        goto HAL;
                    }     // MEYVE HAL
                    else if (halsecim == "2")
                    {
                        Console.Clear();
                        for (int i = 0; i < halsebzeler.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + halsebzeler[i] + " (" + sebzekg[i] + " KG)");
                        }
                        Console.Write("\nSatin alacaginiz urunu seciniz: ");
                        int secilenurun = Convert.ToInt32(Console.ReadLine());
                        if (secilenurun > halsebzeler.Length)
                        {
                            Console.WriteLine("Yanlis bir secim yaptiniz.");
                            Thread.Sleep(1000);
                            goto HAL;
                        }
                        Array.Copy(halsebzeler, (secilenurun - 1), Manavsebze, (secilenurun - 1), 1);
                        Console.Write("Kaç kilogram alacağınızı giriniz:");
                        int halsecimkg = Convert.ToInt32(Console.ReadLine());
                        sebzekg[secilenurun - 1] += halsecimkg;
                        Console.WriteLine("Islem basarili.");
                        Thread.Sleep(1000);
                        goto HAL;

                    } // SEBZE HAL
                    else if (halsecim == "3")
                    {
                        Console.Clear();
                    } // HAL CIKIS
                    else
                    {
                        Console.Write("Hatali bir islem yaptiniz!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto HAL;
                    }                      // HAL HATALI ISLEM


                }
                else if (secim == "2")
                {
                MANAV:
                    Console.Clear();
                    Console.WriteLine("----- Manav -----\n\n1-MEYVE\n2-SEBZE\n3-CIKIS");
                    Console.Write("\nIslem seciniz: ");
                    string manavsecim = Console.ReadLine();

                    if (manavsecim == "1")
                    {
                        Console.Clear();
                        if (Manavmeyve.Length == 0)
                        {
                            Console.WriteLine("Suanda stokta meyve bulunmamaktadir.");
                            goto MANAV;
                        }
                        else
                        {
                            for (int i = 0; i < Manavmeyve.Length; i++)
                            {
                                Console.WriteLine((i + 1) + "." + Manavmeyve[i] + " (" + meyvekg[i] + " KG)");
                            }
                            Console.Write("Almak istediginiz urunu seciniz: ");
                            int alinanmeyve = Convert.ToInt32(Console.ReadLine());
                            if (alinanmeyve > Manavmeyve.Length)
                            {
                                Console.WriteLine("Yanlis bir secim yaptiniz.");
                                Thread.Sleep(1000);
                                goto MANAV;
                            }
                            Console.Write("Kac kg " + Manavmeyve[alinanmeyve - 1] + " almak istediginizi giriniz:");
                            int alinanmk = Convert.ToInt32(Console.ReadLine());
                            meyvekg[alinanmeyve - 1] -= alinanmk;
                            goto MANAV;
                        }

                    }            // MEYVE ALIS 
                    else if (manavsecim == "2")
                    {
                        Console.Clear();
                        for (int i = 0; i < Manavsebze.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + Manavsebze[i] + " (" + sebzekg[i] + " KG)");
                        }
                        Console.Write("Almak istediginiz urunu seciniz: ");
                        int alinansebze = Convert.ToInt32(Console.ReadLine());
                        if (alinansebze > Manavsebze.Length)
                        {
                            Console.WriteLine("Yanlis bir secim yaptiniz.");
                            Thread.Sleep(1000);
                            goto MANAV;
                        }
                        Console.Write("Kac kg " + Manavsebze[alinansebze - 1] + " almak istediginizi giriniz:");
                        int alinanms = Convert.ToInt32(Console.ReadLine());
                        sebzekg[alinansebze - 1] -= alinanms;
                        goto MANAV;
                    }       // SEBZE ALIS 
                    else if (manavsecim == "3")
                    {
                        Console.Clear();
                    }        // MANAV CIKIS
                    else
                    {
                        Console.Write("Hatali bir islem yaptiniz!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto MANAV;

                    }                           // HATALI ISLEM
                }
                else
                {
                    Console.Write("Hatali bir islem yaptiniz!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            }
        }
}
