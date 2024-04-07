int[] mass = { 1, 2, 0, 54, 15, 7, };

void MassPrint(int[] mass, int i = 0)
{
    if (i == mass.Length)
    {
        return;
    }

    MassPrint(mass, i + 1);
    Console.Write($"{mass[i]} ");
}

MassPrint(mass);