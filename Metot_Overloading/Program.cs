using System;
namespace MetotOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            // out parametreler

            string sayi = "999";
            int outsayi;

           bool sonuc = int.TryParse(sayi, out outsayi);

           if(sonuc)
           {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outsayi);

           }else{
            Console.WriteLine("başarısız");

           }

           Metotlar ornek = new Metotlar();
           ornek.Topla(2,3, out int Toplam);

           Console.WriteLine(Toplam);


           // Metot Aşırı Yükleme - Overloading

           int ifade = 999;
           ornek.EkranaYazidir(ifade);
        }

    }

    class Metotlar
    {
        public  void Topla(int a, int b, out int Toplam)
        {
            Toplam = a+b;
        }

        public void EkranaYazidir(string veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazidir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}