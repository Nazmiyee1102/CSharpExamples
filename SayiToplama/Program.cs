//kullanıcının girdiği iki sayıyı toplayan konsol programı

int sayi1, sayi2, sonuc;

Console.Write("Sayı1: ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Sayı2: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

sonuc = sayi1 + sayi2;
Console.WriteLine("Sonuç: " + sonuc);