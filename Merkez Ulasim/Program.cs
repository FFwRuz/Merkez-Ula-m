using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkez_Ulasim
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("|-------------------- MERKEZ ULASİM -----------------------|");
            Console.WriteLine("");
            Console.WriteLine("          Designed By : Taha , Enes , Enes P , Esma    ");
            Console.WriteLine("");
            Console.WriteLine("                        27.12.2022                          ");
            Console.WriteLine("|----------------------------------------------------------|");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            giris();
            Console.ReadKey();
        }
       //Uber
        static void uber()
        {
            basla:
            Console.WriteLine("     Menü Seçenekleri    ");
            Console.WriteLine("");
            Console.WriteLine("1 - Genel Menü");
            Console.WriteLine("");
            Console.WriteLine("2 - Sürücü Adayları Görüntüleme ");
            Console.WriteLine("");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|                           | ");
            Console.WriteLine("Seçim Yapınız:");
            int secim2 = Convert.ToInt32(Console.ReadLine());

            if (secim2 == 1)
            {
                Console.Clear();
                uberSecim();

                int secim4 = Convert.ToInt32(Console.ReadLine());

                if(secim4 == 1)
                {
                    uberKonum();
                }
                else if(secim4 == 2)
                {
                    puanlama();
                }
                else if(secim4 == 3)
                {
                    sürücü();
                }

            }
            else if(secim2 == 2)
            {

                Console.Clear();
                Console.WriteLine(" -       Sürücü Adayları     -");
                Console.WriteLine("");
                Console.WriteLine(" 1 - Esma");
                Console.WriteLine("");
                Console.WriteLine(" 2 - Enes Polat");
                Console.WriteLine("");
                Console.WriteLine(" 3 - Enes ");
                Console.WriteLine("");
                Console.WriteLine(" 4 - Taha");
                Console.WriteLine("");
                Console.WriteLine(" 5 - Çıkış");
                int secimad = Convert.ToInt32(Console.ReadLine());
                if (secimad == 5)
                {
                    Console.Clear();
                    goto basla;
                    
                }
                else
                {
                    Console.WriteLine("Doğru Seçim Yapiniz");
                }
                Console.ReadKey();
            }
        }
        static void uberKonum()
        {
            bas:
            Console.WriteLine("           Konum Giriniz              ");
            Console.WriteLine("");
            Console.Write("  Başlangıç Noktası:   ");
            string konum = Console.ReadLine();
            try
            {
                Convert.ToInt32(konum);
                Console.WriteLine("Lütfen Sayı Girmeyiniz !");
                goto bas;
            }
            catch
            {
                Console.WriteLine("");
                Console.Write("  Varış Noktası:    ");
                string bitis = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("     Başlangıç Noktası " + konum + " " + "olarak Ayarlandı.");
                Console.WriteLine("");
                Console.WriteLine("     Varış Noktası " + bitis + " " + "olarak Ayarlandı.");
            }
            
        }
        static void puanlama()
        {
            int puan = 0;
            Console.WriteLine(" 0 - 10 Arası Puan Giriniz: ");
            int girilenP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Bize Puan Verdiğiniz İçin Teşekkür Ederiz.");
            System.Threading.Thread.Sleep(200);
            int toplamP = girilenP + puan;
            Console.WriteLine(" Verdiğniz Puan: " + toplamP);
        }
        static void sürücü()
        {
            Console.Clear();
            Console.WriteLine("    Sürücü Seçim Menüsü ");
            Console.WriteLine("|------------------------|");
            Console.WriteLine("");
            Console.WriteLine(" 1 - Esma");
            Console.WriteLine("");
            Console.WriteLine(" 2 - Enes Polat");
            Console.WriteLine("");
            Console.WriteLine(" 3 - Enes ");
            Console.WriteLine("");
            Console.WriteLine(" 4 - Taha");
            Console.WriteLine("");
            Console.WriteLine("|------------------------|");
            Console.WriteLine("");

            Console.WriteLine("   Seçim Yapınız:  ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if(secim == 1)
            {
                string esma = "Esma";
                Console.WriteLine(esma + " Sürücünüz Olarak Ayarlandı.");
            }
            else if(secim == 2)
            {
                string ensp = "Enes Polat";
                Console.WriteLine(ensp + " Sürücünüz Olarak Ayarlandı.");
            }
            else if(secim == 3)
            {
                string ens = "Enes";
                Console.WriteLine(ens + " Sürücünüz Olarak Ayarlandı.");
            }
            else if(secim == 4)
            {
                string tha = "Taha";
                Console.WriteLine(tha + " Sürücünüz Olarak Ayarlandı.");
            }
            else if(secim > 4)
            {
                Console.WriteLine(" Geçersiz Karakter / Sayı Saptandı 1 - 4 Arasında Bir Sayı veya Karakter Giriniz.");
            }
        }
        static void uberSecim()
        {
            
            Console.WriteLine("      Menü    ");
            Console.WriteLine("|---------------|");
            Console.WriteLine("");
            Console.WriteLine(" 1 - Konum Belirleme ");
            Console.WriteLine("");
            Console.WriteLine(" 2 - Sürücü Puanlama ");
            Console.WriteLine("");
            Console.WriteLine(" 3 - Sürücü Seçimi ");
            Console.WriteLine("");
            Console.WriteLine("|---------------|");
        }                      

        //Taksi
      

        //Otobüs
        static void otobus()
        {
            Console.WriteLine("   Otobüs Menü  ");
            Console.WriteLine("|---------------|");

            Console.WriteLine("");
            Console.WriteLine(" 1 - Konum Belirleme");
            Console.WriteLine("");
            Console.WriteLine(" 2 - Fiyat Bilgilendirme");
            Console.WriteLine("");
            Console.WriteLine(" 3 - Kart Durumu");
            Console.WriteLine("");
            Console.WriteLine(" 4 - Yer Durumu");
            Console.WriteLine("|---------------|");

            Console.WriteLine(" Seçim Yapınız: ");
            int secim5 = Convert.ToInt32(Console.ReadLine());
            if(secim5 == 1)
            {
                Console.WriteLine(" Gidiceğiniz Yeri Seçiniz : ");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Console.WriteLine(" 1 - HadımKöy PTT ");
                Console.WriteLine("");
                Console.WriteLine(" 2 - ArnavutKöy Merkez ");
                Console.WriteLine("");
                Console.WriteLine(" 3 - Delikli Kaya ");
                Console.WriteLine("");
                Console.WriteLine(" 4 - Ömerli Kiptaş Konutları ");
                Console.WriteLine("");
                Console.WriteLine(" 5 - HadımKöy Toki Konutları");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
            }
            else if(secim5 == 2)
            {
                Console.WriteLine("     MERKEZ ULASİM   FİYAT LİSTESİ     ");
                Console.WriteLine(" ");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine(" Öğrenci = 3,50TL ");
                Console.WriteLine("");
                Console.WriteLine(" Tam = 7,28TL ");
                Console.WriteLine("");
                Console.WriteLine(" Gazi Kartı = BEDAVA , Vatan Size Minnettar.");
                Console.WriteLine("");
                Console.WriteLine(" Anne Kartı = BEDAVA ");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------");
            }
            else if (secim5 == 3)
            {

            }
            else if(secim5 == 4)
            {
                Console.Clear();
                otobusYer();
            }
            Console.ReadKey();
        } 
        static void otobusKonum()
        {
            Console.WriteLine("           Konum Giriniz              ");
            Console.WriteLine("");
            Console.Write("  Başlangıç Noktası:   ");
            string konum = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("  Varış Noktası:    ");
            string bitis = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("     Başlangıç Noktası " + konum + "" + "olarak Ayarlandı.");
            Console.WriteLine("");
            Console.WriteLine("     Varış Noktası " + bitis + "" + "olarak Ayarlandı.");
        }
        static void otobusYer()
        {
        enbas:
            string[] yolcular = { "BOŞ", "BOŞ", "BOŞ", "BOŞ", "BOŞ", "BOŞ", "BOŞ", "BOŞ", "BOŞ", "BOŞ" };

        baslangıc:
            sbyte secim, secimm, dongu = 1;
            Console.WriteLine("Numara\tYolcu İsim\n______\t__________");
            foreach (string yolcu in yolcular)
            {
                if (yolcu == "BOŞ")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" {0} \t{1}", dongu, yolcu);
                    dongu++;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" {0} \t{1}", dongu, yolcu);
                    dongu++;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nİşlemler\n 1. Yolcu ekle\n 2. Yolcu sil\n 3. Yolcuların hepsini sil");
            Console.Write("Seçiminizi giriniz [1,2,3] : ");
            secim = sbyte.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("Kaçıncı sıraya yolcu ekleyeceksimiz : ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    secimm = sbyte.Parse(Console.ReadLine());
                    secimm--;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Yolcunun ismini giriniz : ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    yolcular[secimm] = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ana menüye dönmek için ENTER'e basınız ...");
                    Console.ReadLine();
                    Console.Clear();
                    goto baslangıc;
                    break;
                case 2:
                    Console.Write("Kaçıncı sıradaki yolcuyu kaldıracaksınız : ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    secimm = sbyte.Parse(Console.ReadLine());
                    secimm--;
                    Console.ForegroundColor = ConsoleColor.White;
                    yolcular[secimm] = "BOŞ";
                    Console.WriteLine("Ana menüye dönmek için ENTER'e basınız ...");
                    Console.ReadLine();
                    Console.Clear();
                    goto baslangıc;
                    break;
                case 3:
                    Console.WriteLine("Tüm kayıtlar silinmiştir ...");
                    Console.WriteLine("Ana menüye dönmek için ENTER'e basınız ...");
                    Console.ReadLine();
                    Console.Clear();
                    goto enbas;
                    break;
                default:
                    Console.WriteLine("Seçiminiz yanlıştır tekrar deneyiniz ...");
                    Console.WriteLine("Ana menüye dönmek için ENTER'e basınız ...");
                    Console.ReadLine();
                    Console.Clear();
                    goto baslangıc;
                    break;


            }
        }
        static void otobusKart()
        {

        }

        //Minibüs
       

        //giriş
        static void giris()
        {
            Console.WriteLine("|        Giriş  Menüsü      |   ");
            Console.WriteLine("");
            Console.WriteLine("1 - Uber");
            Console.WriteLine("");
            Console.WriteLine("2 - Otobüs");
            Console.WriteLine("");
            
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine(" Seçim İçin Bir Tuş Tıklayınız.");
            int secim = Convert.ToInt32(Console.ReadLine());

            if(secim == 1)
            {
                Console.WriteLine("     Uber'e Hoşgeldiniz..");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                uber();   
            }
         
            else if(secim == 2)
            {
                Console.WriteLine("     Otobüs'e Hoşgeldiniz..");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                otobus();
            }
            Console.ReadKey();
        }

    }
}
