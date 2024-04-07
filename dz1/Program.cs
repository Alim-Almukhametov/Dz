string NaturNumb(int m, int n)
{
    if(m == n) return Convert.ToString(n);
    return m + " " + NaturNumb(m + 1, n);
}

Console.WriteLine("Введите число: M ");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: N ");
int n = Convert.ToInt32(Console.ReadLine());


Console.Write(NaturNumb(m, n));



