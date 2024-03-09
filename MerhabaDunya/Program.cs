// 10 tane alt alta Merhaba Dünya yazan program

////for (int i = 0; i < 10; i++)
////{
////    Console.WriteLine("Merhaba Dünya!");

////}

//klavyeden girilen metni alt alta yazan program

//Console.Write("Metni giriniz: ");
//string metin = Console.ReadLine();
//Console.WriteLine("****");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(metin);
//}

//metin kaç kere yazılsın

Console.Write("Metni giriniz: ");
string metin = Console.ReadLine();

int tekrar;
Console.Write("Kaç kere yazılsın?  : ");
tekrar = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("****************");

for (int i = 0; i < tekrar; i++)
{
    Console.WriteLine(metin);
}