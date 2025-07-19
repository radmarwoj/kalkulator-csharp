using System;

public class DzialaniaPodstawowe
{
    public double Dodaj(double a, double b)
    {
        return a + b;
    }

    public double Odejmij(double a, double b)
    {
        return a - b;
    }

    public double Pomnoz(double a, double b)
    {
        return a * b;
    }

    public double Podziel(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Błąd: niedozwolona operacja");
            return double.NaN;
        }
        return a / b;
    }

    public double Poteguj(double a, double b)
    {
        if (a == 0 && b == 0)
        {
            Console.WriteLine("Błąd: niedozwolona operacja");
            return double.NaN;
        }
        return Math.Pow(a, b);
    }

    public double Pierwiastkuj(double a, double b)
    {
        if (b == 0 || b % 1 != 0)
        {
            Console.WriteLine("Niedozwolona operacja");
            return double.NaN;
        }
        if (b % 2 == 0 && a < 0)
        {
            Console.WriteLine("Niedozwolona operacja");
            return double.NaN;
        }
        return Math.Pow(a, 1.0 / b);
    }

    public double Silnia(double a)
    {
        if (a % 1 != 0 || a < 0)
        {
            Console.WriteLine("Niedozwolona operacja");
            return double.NaN;
        }
        if (a == 0)
            return 1;

        double s = 1;
        for (int i = 1; i <= a; i++)
        {
            s *= i;
        }
        return s;
    }

    public double Sinus(double a)
    {
        double stopnieSinus = a * (Math.PI / 180);
        return Math.Sin(stopnieSinus);
    }

    public double Cosinus(double a)
    {
        return Math.Cos(a);
    }

    public double Tangens(double a)
    {
        return Math.Tan(a);
    }

    public double Cotangens(double a)
    {
        if (a == 0)
        {
            Console.WriteLine("Niedozwolona operacja");
            return double.NaN;
        }
        return 1 / Math.Tan(a);
    }

    public double OdwrocLiczbe(double a)
    {
        if (a == 0)
        {
            Console.WriteLine("Niedozwolona operacja");
            return double.NaN;
        }
        return 1 / a;
    }
}
