using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for(ifade1;koşul1;ifade2){} for döngüsünde ifade1 yerine sayacın tanımlanması yapılır, örneğin int i=0.
            // ifade2 kısmında sayacın artacağı mı yoksa azalacağı mı yazılır i++ veya i-- gibi.
            // koşul1 kısmına ise döngünün devam etmesi için gerekli durumu yazarsınız, örneğin i değişkeni 14 olana kadar devam etsin istiyorsanız i==14 yazmalıyız.
            // Diğer parantezin içine ise döngünün yapması istediği kodu yazmalısınız.
            // break; ifadesi döngü içinden çıkılmak istendiğinde kullanılır.
            // continue; ifadesi döngüde belirlediğiniz duruma gelince orayı atlar ve döngüye devam eder, örnekte daha açık şekilde anlatılıyor.
            // while(){} döngüsünde parantez içindeki durum sağlandığı sürece o döngü devam eder.
            // foreach(){} diziler ve koleksiyonlarda döngü yapmak için kullanılır.

            // Örnek olarak klavyeden girilen bir aralığın içindeki tek sayıları ekrana yazan program.

                Console.WriteLine("1. Örnek / Tek sayı ayırma programına hoşgeldiniz.");

                Console.Write("Aralığın alt sınırını giriniz : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Aralığın üst sınırını giriniz : ");
                int num2 = int.Parse(Console.ReadLine());           // Programları kullanırken aralığı eşit veya ters girmemeye dikkat edelim o durumlarda olacakları eklemedim :)

                for (int i = num1; i <= num2 ; i++)
                {
                    if (i % 2 == 1) // Burada 2 ile bölümünden 1 kalan sayıları bulup ekrana yazdırıyor.
                        Console.WriteLine(i);
                }

                Console.WriteLine(" ");// Konsolda boşluk gözükmesi için.
                Console.WriteLine("2. Örnek / Break Örneği.");

                for (int i = 0; i <= 7; i++) // Normalde bu döngünün 7'ye kadar yazması lazım ama aşağıda break; komutunu kullandığımız için döngüden çıkıyor.
                {
                    if (i == 5) // Döngüdeki i değişkeni 5 olduğunda döngüden çıkıyor.
                        break;
                    Console.WriteLine(i);
                }

                Console.WriteLine(" "); // Konsolda boşluk gözükmesi için.
                Console.WriteLine("3. Örnek / Continue Örneği.");

                for (int i = 0; i <= 7; i++)
                {
                    if (i == 5) // Normalde 0'dan 7 ye kadar bütün sayıları yazacak ama burada continue kullandığımız için 5 yazmayı atlıyor ve devam ediyor.
                        continue;
                    Console.WriteLine(i);
                }

            // While örneği olarak verilen aralıktaki sayıları toplayıp ortalamasını alan program.

                Console.WriteLine(" "); // Konsolda boşluk gözükmesi için.
                Console.WriteLine("4. Örnek / Girilen aralıktaki sayıları toplayıp ortalamasını bulan While örneği.");

                Console.Write("Alt sınırı giriniz : ");
                int num5 = int.Parse(Console.ReadLine());
                Console.Write("Üst sınırı giriniz : ");
                int num6 = int.Parse(Console.ReadLine());
                int toplam = 0, terimsayisi = (num6 - num5)/1 + 1;
                double ortalama;
                while (num5 <= num6)
                {
                    toplam += num5;
                    num5++;
                }

                ortalama = toplam / terimsayisi;
                Console.WriteLine("Girdiğiniz aralığın ortalaması : {0}", ortalama);

            // While örneği olarak girilen harften alfabedeki son harfe kadar yazan program. (İngilizce alfabesine göre.)

                Console.WriteLine(" "); // Konsolda boşluk gözükmesi için.
                Console.WriteLine("5. Örnek / Girilen harften son harfe kadar bütün harfleri yazan While örneği.");

                Console.Write("Harf giriniz : ");
                char character = char.Parse(Console.ReadLine());
                while (character <= 'z')
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine(" "); // Konsolda boşluk gözükmesi için.

           // ForEach örneği.

                Console.WriteLine("6. Örnek / ForEach Örneği.");

                string[] takimlar = { "Lakers", "Nets", "Thunder", "Warriors", "Celtics"};
                foreach (var takim in takimlar)
                {
                    Console.WriteLine(takim);
                }
        }
    }
}
