using System;

namespace PozitifNegatifSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının negatif mi pozitif mi olduğunu bulan Console örneği.
            int sayi;
            Console.WriteLine("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi >= 0)
            {
                Console.WriteLine("Girdiğiniz sayı pozitiftir.");

            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı negatiftir.");
            }
        }
    }
}

