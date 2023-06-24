using System;

class Program
{
    static void Main()
    {
        // Wygenerowanie losowych współrzędnych punktów od 1.00 do 10.00
        Random random = new Random();
        double x1 = random.NextDouble() * 9 + 1; // Losowa wartość od 1.00 do 10.00
        double y1 = random.NextDouble() * 9 + 1;
        double x2 = random.NextDouble() * 9 + 1;
        double y2 = random.NextDouble() * 9 + 1;

        Console.WriteLine($"Wylosowane punkty:");
        Console.WriteLine($"Punkt początkowy: ({x1}, {y1})");
        Console.WriteLine($"Punkt końcowy: ({x2}, {y2})");

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine($"Długość odcinka: {dlugoscOdcinka}");
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dlugosc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dlugosc;
    }
}
