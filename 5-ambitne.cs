using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int liczba = rand.Next(6, 100); // Losowanie liczby od 6 do 99
        int liczbaDzielnikow = LiczbaDzielnikowPierwszych(liczba);
        Console.WriteLine($"Liczba dzielników pierwszych liczby {liczba}: {liczbaDzielnikow}");
    }

    static int LiczbaDzielnikowPierwszych(int liczba)
    {
        if (liczba <= 5)
            return 0;

        int liczbaDzielnikow = 0;

        for (int i = 2; i <= liczba / 2; i++)
        {
            if (liczba % i == 0 && CzyLiczbaPierwsza(i))
                liczbaDzielnikow++;
        }

        return liczbaDzielnikow;
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }
}
