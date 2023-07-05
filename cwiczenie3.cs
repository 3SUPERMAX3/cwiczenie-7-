double podajMediane(double[] tablicaPodana)
{
    // Sprawdzamy czy tablica ma wprowadzone wartości       
    if (tablicaPodana == null || tablicaPodana.Length == 0)
        throw new ArgumentException("Tablica jest pusta.");

    // Sortujemy wartości używając tymczasowej tablicy, żeby nie zmieniać porządku liczb w tablicy podanej
    double[] tablicaPosortowana = (double[])tablicaPodana.Clone();
    Array.Sort(tablicaPosortowana);

    // Obliczamy medianę
    int rozmiar = tablicaPosortowana.Length;
    int srodek = rozmiar / 2;

    if (rozmiar % 2 != 0)
        return tablicaPosortowana[srodek];

    dynamic value1 = tablicaPosortowana[srodek];
    dynamic value2 = tablicaPosortowana[srodek - 1];
    return (value1 + value2) / 2;
}

Console.WriteLine("Podaj wielkość tablicy: ");
int wielkoscTablicy = int.Parse(Console.ReadLine());
double[] tablica = new double[wielkoscTablicy];

// Wypełniamy tablicę
for (int i = 0; i < tablica.Length; i++)
{
    Console.WriteLine($"Pozycja {i + 1} ma się równać: ");
    tablica[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine($"Mediana dla tablicy to: {podajMediane(tablica)}");