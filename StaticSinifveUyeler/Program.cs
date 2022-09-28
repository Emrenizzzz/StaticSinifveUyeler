using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSinifveUyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Yunus","Başer","İK");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Emre", "Sırakaya", "Muhasebe");
            Calisan calisan2 = new Calisan("Eylül", "Kaya", "Pazarlama");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);


            Console.WriteLine("Toplama işlemi sonucu = {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu = {0}",Islemler.Cıkar(500,300));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;  }

        private string Isim;
        private string Soyisim;
        private string Departman;

        public Calisan()
        {
            calisanSayisi=0;
        }

        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cıkar(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
        


    }
}
