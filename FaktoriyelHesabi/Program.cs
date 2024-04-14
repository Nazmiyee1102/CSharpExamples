int n = Convert.ToInt32(Console.ReadLine());

int f = 1;

for (int i = 2; i <= n; i++)
    f *= i;
Console.WriteLine("{0}! = {1}", n, f);

