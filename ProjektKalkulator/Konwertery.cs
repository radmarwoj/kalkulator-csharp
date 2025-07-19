public class Konwertery
{
    public double CelsjuszFahrenheit(double a)
    {
        return (a * 9.0 / 5.0) + 32;
    }

    public double FahrenheitCelsjusz(double a)
    {
        return (a - 32) * 5.0 / 9.0;
    }

    public double MileKilometry(double a)
    {
        return a * 1.6093;
    }

    public double KilometryMile(double a)
    {
        return a / 1.6093;
    }

    public double StopyMetry(double a)
    {
        return a * 0.3048;
    }

    public double MetryStopy(double a)
    {
        return a / 0.3048;
    }

    public double LnkMpg(double a)
    {
        return 235.215 / a;
    }

    public double KonieKilowaty(double a)
    {
        return a / 1.35962;
    }

    public double KilowatyKonie(double a)
    {
        return a * 1.35962;
    }
}
