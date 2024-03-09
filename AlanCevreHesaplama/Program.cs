// Dikdörtgen alan ve cevre hesaplama

int alan, cevre, kisaKenar, uzunKenar;

Console.Write("Kısa kenarı giriniz: ");
kisaKenar = Convert.ToInt32(Console.ReadLine());

Console.Write("Uzun kenarı giriniz: ");
uzunKenar = Convert.ToInt32(Console.ReadLine());

alan = kisaKenar * uzunKenar;

cevre = (2 * uzunKenar) + (2 * kisaKenar);

Console.WriteLine("Alan  : " + alan);

Console.WriteLine("Çevre : " + cevre);
