﻿using System;

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
                    Console.WriteLine($"Doğru Tahmin... {i}.Tahminde buldunuz");
                }
            }

        }
    }
}
