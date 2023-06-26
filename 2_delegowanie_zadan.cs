using System;

class Program
{
    static void Main()
    {
        double x1 = 1.5;
        double y1 = 2.3;
        double x2 = 4.8;
        double y2 = 6.1;

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + dlugoscOdcinka);
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;

        double dlugosc = Math.Sqrt(dx * dx + dy * dy);

        return dlugosc;
    }
}