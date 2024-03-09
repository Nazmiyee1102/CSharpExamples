// Girilen sayının 0 - 100 arasında olup olmadığını kontrol eden program

int sayi;
Console.WriteLine("Sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi >= 0 && sayi <= 100)
{
    Console.WriteLine("Sayı 0 - 100 arasındadır.");
}
else
{
    Console.WriteLine("Sayı 0 - 100 arasında değildir.");
}