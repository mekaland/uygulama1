using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true) {
            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz... ");
            Console.WriteLine("1- Yazılımcı işlemleri");
            Console.WriteLine("2- Yönetici işlemleri");
            Console.WriteLine("3- çıkış için q ya basın. ");
            string secilenIslem = Console.ReadLine();

                if (secilenIslem == "q")
                {
                Console.WriteLine("programdan çıkılıyor...");
                break;
                } 
                 else if(secilenIslem == "1")
                {
                    yazilimci yazilimci = new yazilimci(1,"Kadir","Dagli","c#,java");


                    while(true)
                    {
                    Console.WriteLine("Yazilimci işlemi seciniz : ");
                    Console.WriteLine("1- Format at");
                    Console.WriteLine("2- Bilgileri goster");
                    Console.WriteLine("3- çıkış için q ya bas");
                    string yazilimciIslem = Console.ReadLine();

                        if(yazilimciIslem == "q")
                        {
                            Console.WriteLine("Yazilimci işlemlerinden çıkş yapılıyor");
                            break;
                        }
                        else if(yazilimciIslem =="1")
                        {
                            Console.Write("Isletim sistemi giriniz: ");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.formatAt(isletimSistemi);
                        }
                        else if(yazilimciIslem == "2")
                        {
                            yazilimci.bilgileriGoster();
                        }
                    }

                   }
                 else if(secilenIslem=="2")
                {
                    Yonetici yonetici = new Yonetici(2,"Yakup","Reçber",12);
                    Console.WriteLine("Yönetici işlemi seçiniz : ");
                    Console.WriteLine("1- Zam yap");
                    Console.WriteLine("2- Yönetici bilgilerini göster");
                    Console.WriteLine("3- Çıkış için q ya basınız ");
                    string yoneticiIslem = Console.ReadLine();

                    while (true) { 
                        if(yoneticiIslem == "q") 
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor..");
                            break;
                         }
                        else if (yoneticiIslem =="1")
                        {
                            Console.Write("Zam miktarını giriniz : ");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());
                            yonetici.zamYap(zamMiktari);
                        }
                        else if( yoneticiIslem == "2")
                        {
                            yonetici.bilgileriGoster();
                        }
                        else {
                            Console.WriteLine("Lutfen gecerli bir işlem giriniz"); 
                        }
                      }
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli bir işlem giriniz");
                }
            }
           

        }
    }
}
