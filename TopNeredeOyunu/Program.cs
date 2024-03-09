using System.Runtime.InteropServices;

Random rastgele = new Random();
int sutun = rastgele.Next(50);
int satir = rastgele.Next(30);
Console.SetCursorPosition(sutun, satir);
Console.Write("X");
int kulsatir, kulsutun;
for (int hak = 1; hak <= 3; hak++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(0, 0);
    Console.Write("Satır tahmininizi giriniz: ");
    kulsatir = Convert.ToInt32(Console.ReadLine());

    Console.Write("Sütun tahmininizi giriniz: ");
    kulsutun = Convert.ToInt32(Console.ReadLine());

    Console.SetCursorPosition(kulsatir, kulsutun);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("!");

    if (sutun == kulsutun && satir == kulsatir)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(57, 15);
        Console.Write("Bravooo!");
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(57, 15);
        if (hak == 1)
        {
            Console.Write("Bir daha dene.");
        }
        else if (hak == 2)
        {
            Console.Write("Tekrar dene.");
        }
        else
        {
            Console.Write("Tüm haklarını bitirdin.");
        }

    }


}