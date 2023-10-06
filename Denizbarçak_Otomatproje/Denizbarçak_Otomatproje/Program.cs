using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Denizbarçak_Otomatproje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = new string[3] { "KOLA", "BİSKÜVİ", "ÇİKOLATA" };
            int[] fiyatlar = new int[3] { 10, 8, 7 };
            string usurname = "admin";
            string password = "admin";
            string memberusurname = "member";
            string memberpassword = "member";
            int totaltutar = 0;
            int bakiye = 0;
        GIRISEKRANI:
            Console.WriteLine("---------------- OTOMAT ----------------\n");
            Console.WriteLine("Giris icin '1' tuslayiniz.(admin ekrani icin'0' tuslayiniz.)");
            Console.Write("Islem seciniz: ");
            string girissecim = Console.ReadLine();
            if (girissecim == "0")                //ADMIN GIRISI KISMI
            {
                Console.Clear();
                Console.Write("Kullanici adini giriniz: ");
                string kullanici = Console.ReadLine();
                Console.Write("Sifrenizi giriniz: ");
                string sifre = Console.ReadLine();
                if (kullanici == usurname && sifre == usurname)
                {
                URUNBILGIGUNCELLEME:
                    Console.Clear();
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: \n\n1-Ürün değiştir\n2-Fiyat değiştir\n3-Cikis");
                    Console.Write("\nIslem seciniz:");
                    string adminislemsecimi = Console.ReadLine();
                    if (adminislemsecimi == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Ismini degistirmek istediginiz urunu seciniz.\n");
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "-" + urunler[i] + " (" + fiyatlar[i] + ") TL");
                        }

                        Console.Write("\nUrun seciniz: ");
                        int degisecekurun = Convert.ToInt32(Console.ReadLine());
                        if (degisecekurun > 3 || degisecekurun <= 0)
                        {
                            Console.WriteLine("Hatali bir islem yaptiniz.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto URUNBILGIGUNCELLEME;
                        }
                        else
                        {
                            Console.Write("Yeni ürünü giriniz: ");
                            string yeniurun = Console.ReadLine().ToUpper();
                            urunler[degisecekurun - 1] = yeniurun;
                            Console.WriteLine("Urun guncellendi.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto URUNBILGIGUNCELLEME;
                        }

                    }          // Urun degisimi
                    else if (adminislemsecimi == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Fiyatini degistirmek istediginiz urunu seciniz.\n");
                        for (int i = 0; i < fiyatlar.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "-" + urunler[i] + " (" + fiyatlar[i] + ") TL");
                        }
                        Console.Write("\nUrun seciniz: ");
                        int degisecekfiyat = Convert.ToInt32(Console.ReadLine());
                        if (degisecekfiyat > 3 || degisecekfiyat <= 0)
                        {
                            Console.WriteLine("Hatali bir islem yaptiniz.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto URUNBILGIGUNCELLEME;
                        }
                        else
                        {
                            Console.Write("Yeni fiyati giriniz: ");
                            int yenifiyat = Convert.ToInt32(Console.ReadLine());
                            fiyatlar[degisecekfiyat - 1] = yenifiyat;
                            Console.WriteLine("Urun guncellendi.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto URUNBILGIGUNCELLEME;
                        }


                    }    // Fiyat degisimi 
                    else if (adminislemsecimi == "3")
                    {
                        Console.Clear();
                        goto GIRISEKRANI;
                    }     // Cikis
                    else
                    {
                        Console.WriteLine("Hatali bir islem yaptiniz!!!");
                        Thread.Sleep(1000);
                        goto URUNBILGIGUNCELLEME;
                    }                                  // Hatali islem


                }            // Kullanici sifre dogru olma durumu
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Kullanici adi veya sifreyi hatali!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto GIRISEKRANI;
                }
            }                                 //ADMIN GIRISI KISMI
            else if (girissecim == "1")
            {
            UYEGIRISI:
                Console.Clear();
                Console.Write("Kullanıcı adı: ");
                string kullaniciadi = Console.ReadLine();
                Console.Write("Şifre: ");
                string sifre = Console.ReadLine();

                if (kullaniciadi == memberusurname && sifre == memberpassword)
                {
                Menu:
                    Console.Clear();
                    Console.WriteLine("1-Ürün alma\n2-Bakiye yükleme ");
                    Console.Write("\nİşlem seçiniz: ");
                    string SECIM = Console.ReadLine();
                    Console.Clear();
                    if (SECIM == "2")
                    {
                        Console.Write("Yatırılacak tutarı giriniz: ");
                        try
                        {
                            int yatirilantutar = Convert.ToInt32(Console.ReadLine());
                            totaltutar = totaltutar + yatirilantutar;
                            goto Menu;
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Lütfen sadece numara giriniz!!!");
                            Thread.Sleep(1000);
                            goto Menu;
                        }
                    }
                    else if (SECIM == "1")
                    {
                        Console.Clear();
                    URUNSECIMI:
                        for (int i = 0; i < urunler.Length; i++)
                            Console.WriteLine((i + 1) + "-" + urunler[i] + " (" + fiyatlar[i] + ") TL");
                        Console.WriteLine("0-Çıkış\nPara iadesi için '4' tuşlayınız.");
                        Console.Write("\nSatın almak istediğiniz ürünü seçiniz: ");
                        int secilenurun = Convert.ToInt32(Console.ReadLine());
                        if (secilenurun == 0)
                        {
                            Console.Clear();
                            goto GIRISEKRANI;
                        }
                        else if (secilenurun == 4)
                        {
                            Console.WriteLine("Para iadenizi bekleyiniz...");
                            Thread.Sleep(1500);
                            Console.Clear();
                            bakiye = 0;
                            goto GIRISEKRANI;
                        }
                        else if (secilenurun < 0 && secilenurun > 4)
                        {
                            Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto URUNSECIMI;
                        }
                        else if (fiyatlar[secilenurun - 1] > totaltutar)
                        {
                            Console.WriteLine("Yetersiz bakiye.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto URUNSECIMI;
                        }
                        else if (secilenurun >= 0 && secilenurun <= 4)
                        {
                            Console.Clear();
                            Console.WriteLine("ÜRÜN: " + (urunler[secilenurun - 1]));
                            totaltutar -= fiyatlar[secilenurun - 1];
                            Console.WriteLine("Kalan bakiye: " + totaltutar);
                            Console.WriteLine("Ürününüzü alınız...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            goto URUNSECIMI;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto URUNSECIMI;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı tuşlama yaptınız...");
                        Thread.Sleep(1000);
                        goto Menu;
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
                    Thread.Sleep(1000);
                    goto UYEGIRISI;
                }   // MEMBER HATALI ŞİFRE


            }                            //MEMBER GIRISI KISMI
            else                                 //Hatali islem kismi
            {
                Console.WriteLine("Hatali islem!!!");
                Thread.Sleep(1000);
                Console.Clear();
                goto GIRISEKRANI;
            }                                                  //Hatali islem kismi





            Console.ReadLine();
        }
    }
}
