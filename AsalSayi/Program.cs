// Asal sayı bulan program

int sayi;
Console.WriteLine("Sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % sayi == 0 && sayi % 1 == 0)
{
    Console.WriteLine("Girdiğiniz sayı asaldır.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı asal değildir.");
}