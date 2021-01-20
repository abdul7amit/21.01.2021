using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "python";

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs","Java", "python" };
            //burda sadece string yazabiliyorum. Classta yeni bir class oluşturarak birden fazla tip ile çalışabilirim.

            for (int i = 0; i < kurslar.Length; i++)//sıfırdan başlıyacağız 10 şartımız. i+=2 ikişer ikişer arttır demek.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)//İn kurslar kursları dolaş demek.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
