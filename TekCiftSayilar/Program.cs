// tek ve çift sayıları bulan program

int sayi;

Console.Write("Sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}