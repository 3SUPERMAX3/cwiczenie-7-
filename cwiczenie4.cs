Console.Write("Rozmiar tablicy dwuwymiarowej: \n");
int n = int.Parse(Console.ReadLine());

int[,] array = losowaTablica(n);

Console.WriteLine("\nWygenerowana losowo tablica: \n");
wyswietlTablice(array);

static int[,] losowaTablica(int n)
{
    int[,] array = new int[n, n];
    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 10); //generuje losowe wartości 0-9, nie chciało mi się za każdym razem wpisywać z palca
        }
    }

    return array;
}

static void wyswietlTablice(int[,] array)
{
    int n = array.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($" {array[i, j],-3} ");
        }
        Console.WriteLine();
    }
}

znajdzNajbardziejPodobneWiersze(array, out int row1, out int row2);
Console.WriteLine($"\nNajbardziej podobne wiersze: {row1} i {row2}");


void znajdzNajbardziejPodobneWiersze(int[,] array, out int row1, out int row2)
{
    long najmniejszaRoznica = long.MaxValue;

    int iloscWierszy = array.GetLength(0);
    int iloscKolumn = array.GetLength(1);

    row1 = 0;
    row2 = 0;

    for (int i = 0; i < iloscWierszy; i++)
    {
        for (int j = i + 1; j < iloscWierszy; j++)
        {
            long roznica = wyliczRoznice(array, i, j);
            if (roznica < najmniejszaRoznica)
            {
                najmniejszaRoznica = roznica;
                row1 = i;
                row2 = j;
            }
        }
    }
}

long wyliczRoznice(int[,] array, int i, int j)
{
    int iloscKolumn = array.GetLength(1);
    long roznica = 0;

    for (int kol = 0; kol < iloscKolumn; kol++)
    {
        roznica += (long)Math.Pow(array[i, kol] - array[j, kol], 2);
    }

    return roznica;
}