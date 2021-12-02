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
        }
    }
}
