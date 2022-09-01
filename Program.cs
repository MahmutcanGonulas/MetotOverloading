using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int outSayi;

            //eğer parse olursa sayi içindeki değeri outSayi içindeki değere aktaracak
            bool sonuc = int.TryParse(sayi, out outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Console.WriteLine("outSayi == " + outSayi);

            Metotlar mt=new Metotlar();
            mt.Topla(4,5,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Aşırı Yükleme - Overloading

            int ifade=999;
            mt.EkranaYazdir(ifade);

            //Metot imzası
            //metotAdı + parametre sayisi + parametre
            mt.EkranaYazdir("asd"+"das");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1,string veri2){
            Console.WriteLine(veri1+veri2);
        }
    }
}