// pierwszy sposób - działa dla >24h
string FormatujCzas(int sekundy)
{
    int godziny = sekundy / 3600;
    int minuty = (sekundy % 3600) / 60;
    int pozostaleSekundy = sekundy % 60;

    string formatowanyCzas = $"{godziny:D2}:{minuty:D2}:{pozostaleSekundy:D2}";

    return formatowanyCzas;
}

//drugi sposób - zeruje licznik po 24h
void formatuj(int sekundy)
{
    TimeSpan time = TimeSpan.FromSeconds(sekundy);
    string str = time.ToString(@"hh\:mm\:ss");
    Console.WriteLine(str);
}




int czasWsekundach = int.Parse(Console.ReadLine());
string sformatowanyCzas = FormatujCzas(czasWsekundach);
Console.WriteLine(sformatowanyCzas);

Console.WriteLine("\n");
formatuj(czasWsekundach);

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(tablica[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] przygotujTabeleCwiczenie2(int Size)
{
    int[,] array = new int[Size, Size];
    int currentCol = 0;
    int currentRow = 0;
    int direction = 0; // 0 - prawo; 1 - dół; 2 - lewo; 3 - góra

    for (int currentNumber = 1; currentNumber <= Size * Size; currentNumber++)
    {
        array[currentRow, currentCol] = currentNumber;
        switch (direction)
        {
            case 0: //w prawo
                if (currentCol + 1 >= Size || array[currentRow, currentCol + 1] != 0)
                {
                    direction = 1;
                    currentRow++;
                }
                else
                {
                    currentCol++;
                }
                break;
            case 1: //w dół
                if (currentRow + 1 >= Size || array[currentRow + 1, currentCol] != 0)
                {
                    direction = 2;
                    currentCol--;
                }
                else
                {
                    currentRow++;
                }
                break;
            case 2:
                if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                {
                    direction = 3;
                    currentRow--;
                }
                else
                {
                    currentCol--;
                }
                break;
            case 3:
                if (array[currentRow - 1, currentCol] != 0)
                {
                    direction = 0;
                    currentCol++;
                }
                else
                {
                    currentRow--;
                }
                break;
            default:

                break;
        }
    }

    return array;
}



int Size = ZczytajLiczbe("Podaj wartosc: ");
int[,] tablica1 = WypelnijTablice(Size);
int[,] tablica2 = przygotujTabeleCwiczenie2(Size);

Console.WriteLine("\n");
WypiszTablice(tablica1);
Console.WriteLine("\n\n");
WypiszTablice(tablica2);