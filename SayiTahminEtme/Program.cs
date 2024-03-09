using System;

namespace SayiTahminEtme
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayiUret;
            sayiUret = new Random();
            int tahmin = sayiUret.Next(0, 100);
            Console.WriteLine("0 - 100 arasında bir sayı giriniz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin == 0)
            {
                Console.WriteLine("Tebrikler, bildiniz.");
            }
            else
            {
                Console.WriteLine("Tekrar deneyiniz.");
            }
        }
    }
}