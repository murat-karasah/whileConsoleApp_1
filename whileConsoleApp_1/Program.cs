using System;

namespace whileConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //for uygulama
            /*
             for (int i = 1; i < 10; i++)
              {
                  Console.WriteLine(i);
              }
            
             */



            //While uygulama
            /*
             
             int i = 3;
             while (i>=0)
             {
                 Console.WriteLine(i);
                 i--;
             }
            
             */



            //While Şifre Giriş Uygulaması
            /*
            string pass = "1234";
            int i = 5;
            while (i!=0)
            {
                Console.WriteLine("Lütfen şifreyi giriniz");
                string enterPass = Console.ReadLine();
                if (enterPass !=pass)
                {
                    i--;
                    if (i==0)
                    {
                        Console.WriteLine("Şifre Bloke Oldu!");
                    }
                    else
                    {
                        Console.WriteLine("Girilen Şifre Yanlış Kalan Hakkınız" + i);
                    }
                }
                else
                {
                    Console.WriteLine("Giriş Başarılı");
                    break;
                }
            }
            */

            // Random Sayı Oluşturma
            /*
            Random sayiuret = new Random();
            int uretilensayi = sayiuret.Next(1, 10);
            int enterNum=0;
            int i=0;
            while (enterNum != uretilensayi)
            {
                Console.WriteLine("Lütfen 0-10 arasında bir değer giriniz:");
                enterNum = Convert.ToInt32(Console.ReadLine());
                i++;
                if (enterNum!=uretilensayi)
                {
                    Console.WriteLine("Yanlış Tahimn");
                }
                else
                {
                    Console.WriteLine($"Doğru Tahmin... {i}.Tahminde buldunuz!");
                }
            }
            */

            //do-while uygulaması
            int i = 1;
            int tek = 0;
            int cift = 0;
            do
            {
                // if ile
                /*
                 if (i % 2 == 0)
                 {
                     cift += i;
                 }
                 else
                 {
                     tek += i;
                 }
                */
                cift = i % 2 == 0 ? cift += i :cift+0 ;
                tek = i % 2 != 0 ? tek += i : tek+0;


                Console.WriteLine(i % 2 == 0 ? i + " : Çift Sayı"  : i + " : Tek Sayı") ;
               
               
                i++;
            } while (i<=100);
            Console.WriteLine($"Çift Sayıların Toplamı : {cift}\nTek Sayıların Toplamı : {tek}");

        }
    }
}
