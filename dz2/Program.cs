
int AkirmanFunk(int n, int m)
{
    if(n == 0){
        return m + 1;
    }

    if(n > 0 && m == 0)
    {
        return AkirmanFunk(n - 1, m = 1);
    }
    if(n > 0 && m > 0)
    {
        return AkirmanFunk(n - 1, AkirmanFunk(n ,m - 1));
    }
    return AkirmanFunk(n, m);
}
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(AkirmanFunk(n, m ));

