try
{
    Console.Write("Введите x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double S = 0;

    for (int i = 1; i <= n; i += 2)
    {
        long factorial = 1;
        for (int j = 1; j <= i; j++)
        {
            factorial *= j;
        }

        if (i % 2 == 0)
        {
            S += Math.Pow(x, i) / factorial;
        }
        else
        {
            S-= Math.Pow(x, i) / factorial;
        }
    }

    Console.WriteLine($"S = {S:F2}");
}
catch (Exception err)
{
    Console.WriteLine(err);
}