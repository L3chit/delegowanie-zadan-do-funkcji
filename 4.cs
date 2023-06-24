using System;

class Program
{
    static void Main()
    {
        int[,] tablica = {
            {1, 2, 3, 4},
            {4, 2, 3, 1},
            {3, 1, 4, 2},
            {2, 3, 1, 4}
        };

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);
        Console.WriteLine($"Najbardziej zbliżone wiersze: {najblizszeWiersze[0]}, {najblizszeWiersze[1]}");
    }

    static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
    {
        int liczbaWierszy = tablica.GetLength(0);
        int minRoznica = int.MaxValue;
        int[] najblizszeWiersze = new int[2];

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = i + 1; j < liczbaWierszy; j++)
            {
                int roznica = ObliczMiareZroznicowania(tablica, i, j);

                if (roznica < minRoznica)
                {
                    minRoznica = roznica;
                    najblizszeWiersze[0] = i;
                    najblizszeWiersze[1] = j;
                }
            }
        }

        return najblizszeWiersze;
    }

    static int ObliczMiareZroznicowania(int[,] tablica, int i, int j)
    {
        int liczbaKolumn = tablica.GetLength(1);
        int roznica = 0;

        for (int k = 0; k < liczbaKolumn; k++)
        {
            int aik = tablica[i, k];
            int ajk = tablica[j, k];
            roznica += (aik - ajk) * (aik - ajk);
        }

        return roznica;
    }
}
