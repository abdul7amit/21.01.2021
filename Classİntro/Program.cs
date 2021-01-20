using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "Engin Demiroğ";
            Kurs1.İzlenmeOrani = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Kerem VarıŞ";
            Kurs2.İzlenmeOrani = 64;


            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "C++";
            Kurs3.Egitmen = "Murat Kurtboğan";
            Kurs3.İzlenmeOrani = 100;


             


            //Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {Kurs1, Kurs2, Kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; } //prop yaz iki tab bas
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
