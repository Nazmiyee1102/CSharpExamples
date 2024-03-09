int sayi, tahmin;
Random random = new Random();
sayi = random.Next(1, 100);

    Console.Write("Tahmin : ");
    tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin >= sayi)
    {
        Console.WriteLine("Tebrikler!");
    }
    else
    {
        Console.WriteLine("Tekrar deneyin.");
    }
