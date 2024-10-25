using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim25101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# ile Ekranda Merhaba Dünya yazdırma
            Console.WriteLine("1.Örnek");
            Console.WriteLine("Merhaba Dünya.");

            //C# ile ad ve soyad bilgisini string değişenlere alarak ekranda yazdırma
            Console.WriteLine("2.Örnek");
            string ad, soyad;
            Console.Write("Adınız nedir ");
            ad = Console.ReadLine();
            Console.Write("Soyadınız nedir ");
            soyad = Console.ReadLine();
            Console.WriteLine(ad +" "+ soyad);

            // Kullanıcıdan 2 sayı isteyerek bu sayıların toplamını bulan basit Console programı
            Console.WriteLine("3.Örnek");
            int sayi1, sayi2, toplam;
            Console.WriteLine("1. Sayıyı giriniz ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplamınızın sonucu: " + toplam);

            // Kullanıcıdan 2 sayı isteyerek bu sayıların
            // toplamını, farkını, çarpımını ve bölümünü ekranda gösteren basit C# Console uygulaması
            Console.WriteLine("4.Örnek");
            Console.WriteLine("1. Sayıyı giriniz ");
            int sayi3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz ");
            int sayi4 = Convert.ToInt16(Console.ReadLine());
            int toplam1 = sayi1 + sayi2;
            int çıkarma = sayi1 - sayi2;
            int çarpma = sayi1 * sayi2;
            int bölme = sayi1 / sayi2;
            Console.WriteLine($"Toplam: {toplam} çıkarma: {çıkarma} çarpma: {çarpma} bölme: {bölme}");

            //Kullanıcının girdiği sayının %18 ini bulup yazdıran program
            Console.WriteLine("5.Örnek");
            double sayi5, sonuc;
            Console.WriteLine("yüzde 18i alınacak Sayıyı Girin  ");
            sayi5 = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi5 * 18 / 100;
            Console.WriteLine("Sonucunuz :" + sonuc);

            //Kullanıcının girdiği sayının yine kullanıcının girdiği % değerini hesaplayan
            //ve gösteren program
            Console.WriteLine("6.Örnek");
            Console.WriteLine("Yüzde Değeri Alınacak sayıyı giriniz");
            double sayi6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yüzde değerini giriniz");
            double yuzde = Convert.ToDouble(Console.ReadLine());
            double sonuc1 = (sayi6 * yuzde) / 100;
            Console.WriteLine($"{sayi6} sayısının {yuzde}% değeri: {sonuc1}");

            //Alış Fiyatı Girilen malın kullanıcının girdiği
            //yüzdelik karla satış fiyatını bulan program
            Console.WriteLine("7.Örnek");
            double alis, kar, satis;
            Console.Write("Alış Fiyatını Girin ");
            alis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kar Oranını Girin ");
            kar = Convert.ToDouble(Console.ReadLine());
            satis = alis + (alis * kar / 100);
            Console.WriteLine("Satış Fiyatı " + satis);

            //Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program
            Console.WriteLine("8.Örnek");
            int kisa, uzun, alan, cevre;
            Console.Write("Kısa Kenarı Girin");
            kisa = Convert.ToInt16(Console.ReadLine());
            Console.Write("Uzun Kenarı Girin");
            uzun = Convert.ToInt16(Console.ReadLine());
            alan = kisa * uzun;
            cevre = 2 * (kisa + uzun);
            Console.WriteLine("Dikdörtgenin Alanı " + alan);
            Console.WriteLine("Dikdörtgenin Çevresi " + cevre);

            //Yarıçapı girilen dairenin alanını ve çevresini bulan program
            Console.WriteLine("9.Örnek");
            double yaricap, alan1, cevre1;
            Console.Write("Yarıçapı Girin ");
            yaricap = Convert.ToDouble(Console.ReadLine());
            alan1 = 3.14 * yaricap * yaricap;
            cevre1 = 2 * 3.14 * yaricap;
            Console.WriteLine("Dairenin Alanı " + alan1);
            Console.WriteLine("Dairenin Çevresi " + cevre1);

            //3 Yazılı notu girilen öğrencinin ortalamasını ve sınıf geçme durumunu gösteren program
            Console.WriteLine("10.Örnek");
            double not1, not2, not3, ortalama;
            Console.Write("1. Yazılı Notunu Girin ");
            not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Yazılı Notunu Girin ");
            not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. Yazılı Notunu Girin ");
            not3 = Convert.ToDouble(Console.ReadLine());

            ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("Ortalamanız " + ortalama);

            if (ortalama >= 50)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }

            //Girilen 2 sayıdan büyük olanını bulan program
            Console.WriteLine("11.Örnek");
            int sayi7, sayi8;
            Console.Write("1. Sayı ");
            sayi7 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayı ");
            sayi8 = Convert.ToInt16(Console.ReadLine());
            if (sayi7 > sayi8)
            {
                Console.WriteLine("1. Sayı Büyük");
            }
            else if (sayi7 == sayi8)
            {
                Console.WriteLine("İki Sayı Eşit");
            }
            else
            {
                Console.WriteLine("2. Sayı Büyük");
            }

            //Girilen sayının tek mi çift mi olduğunu bulan program
            Console.WriteLine("12.Örnek");
            Console.Write("Tek veya Çift Bir sayı giriniz ");
            int sayi9 = Convert.ToInt16(Console.ReadLine());

            if (sayi9 % 2 == 0)
            {
                Console.WriteLine("Çift");
            }
            else
            {
                Console.WriteLine("Tek");
            }

            //Girilen sayının negatif mi pozitif mi olduğunu bulan program
            Console.WriteLine("13.Örnek");
            Console.Write("Pozitip veya Negatif Bir sayı giriniz ");
            int sayi10 = Convert.ToInt32(Console.ReadLine());

            if (sayi10 > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if (sayi10 < 0)
            {
                Console.WriteLine("Negatif");
            }
            else
            {
                Console.WriteLine("Sıfır");
            }

            //Girilen sayının 4 ve 7 ye tam bölünüp bölünmediğini bulan program
            Console.WriteLine("14.Örnek");
            Console.Write("4 ve 7ye Tam Bölünen Bir sayı giriniz ");
            int sayi11 = Convert.ToInt16(Console.ReadLine());

            if (sayi11 % 4 == 0 && sayi11 % 7 == 0)
            {
                Console.WriteLine("Sayı hem 4'e hem de 7'ye tam bölünür");
            }
            else
            {
                Console.WriteLine("Sayı 4'e ve 7'ye tam bölünmez");
            }

            //Girilen sayının 0-100 arasında olup olmadığını kontrol eden program
            Console.WriteLine("15.Örnek");
            Console.Write("0 ile 100 Arası Bir sayı giriniz ");
            int sayi12 = Convert.ToInt32(Console.ReadLine());

            if (sayi12 >= 0 && sayi12 <= 100)
            {
                Console.WriteLine("Sayı 0 ile 100 arasındadır");
            }
            else
            {
                Console.WriteLine("Sayı 0 ile 100 arasında değildir");
            }

            Console.ReadKey();

        }
    }
}
