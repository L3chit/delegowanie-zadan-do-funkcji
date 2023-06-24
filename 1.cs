using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj czas w sekundach: ");
        int czas = Convert.ToInt32(Console.ReadLine());
        string sformatowanyCzas = FormatujCzas(czas);
        Console.WriteLine(sformatowanyCzas); // Wyświetlenie sformatowanego czasu (np. 00:05:32)
    }

    static string FormatujCzas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = czas % 60;

        string sGodziny = godziny.ToString("D2"); // Formatowanie godzin jako 2 znaków (dopisywanie zer na początku, jeśli potrzeba)
        string sMinuty = minuty.ToString("D2"); // Formatowanie minut jako 2 znaków
        string sSekundy = sekundy.ToString("D2"); // Formatowanie sekund jako 2 znaków

        string sformatowanyCzas = $"{sGodziny}:{sMinuty}:{sSekundy}";

        return sformatowanyCzas;
    }
}
