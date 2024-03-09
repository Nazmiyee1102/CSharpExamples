// Büyük sayıyı bulan konsol programı

int sayi1, sayi2;

Console.Write("1.Sayı: ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Sayı: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi1 > sayi2)
{
    Console.WriteLine("1. sayı büyük");
}
else if (sayi1 < sayi2)
{
    Console.WriteLine("2. sayı büyük");
}
else
{
    Console.WriteLine("Sayılar eşit.");
}