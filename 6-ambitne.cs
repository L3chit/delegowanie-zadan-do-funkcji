using System;

class Program
{
    static void Main()
    {
        int rozmiar = 5;
        double[] tablica = GenerujLiczbyLosowe(rozmiar);
        double srednia = ObliczSrednia(tablica, rozmiar);
        Console.WriteLine($"Średnia arytmetyczna: {srednia}");
    }

    static double[] GenerujLiczbyLosowe(int rozmiar)
    {
        Random rand = new Random();
        double[] tablica = new double[rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = Math.Round(rand.NextDouble() * 10, 1); // Losowanie liczby rzeczywistej od 0 do 10 z jednym miejscem po przecinku
        }

        return tablica;
    }

    static double ObliczSrednia(double[] tablica, int rozmiar)
    {
        if (rozmiar == 0)
            return 0;

        double suma = tablica[rozmiar - 1] + ObliczSrednia(tablica, rozmiar - 1);
        double srednia = suma / rozmiar;

        if (rozmiar == tablica.Length)
        {
            Console.WriteLine("Tablica liczb:");
            WyswietlTablice(tablica);
        }

        return srednia;
    }

    static void WyswietlTablice(double[] tablica)
    {
        foreach (double liczba in tablica)
        {
            Console.Write($"{liczba} ");
        }
        Console.WriteLine();
    }
}
