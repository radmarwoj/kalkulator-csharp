using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Program kalkulator");
        var dp = new DzialaniaPodstawowe();
        var hist = new HistoriaOperacji();
        var kw = new Konwertery();
        double a, b, wynik;

        while (true)
        {
            Console.WriteLine("Wybierz typ działania:");
            Console.WriteLine("1 - dwuliczbowe (dodawanie, potęgowanie, ...)");
            Console.WriteLine("2 - jednoliczbowe (silnia, sinus, ...)");
            Console.WriteLine("3 - konwersje (temperatury, mile na kilometry, ...)");
            Console.WriteLine("h - zobacz historię działań");
            Console.WriteLine("q - wyjdź z programu\n");

            string typDzialania = Console.ReadLine();

            if (typDzialania.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Koniec programu");
                break;
            }

            if (typDzialania.Equals("h", StringComparison.OrdinalIgnoreCase))
            {
                hist.WyswietlHistorie();
                continue;
            }

            if (typDzialania == "1")
            {
                Console.WriteLine("Wybierz rodzaj działania:\nDodawanie: +\nOdejmowanie: -\nMnożenie: *\nDzielenie: /\nPotęgowanie: po\nPierwiastkowanie: pi");
                string dzialanieDwuliczbowe = Console.ReadLine();

                Console.WriteLine("Wprowadź pierwszą liczbę:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Wprowadź drugą liczbę");
                b = double.Parse(Console.ReadLine());

                switch (dzialanieDwuliczbowe)
                {
                    case "+": wynik = dp.Dodaj(a, b); break;
                    case "-": wynik = dp.Odejmij(a, b); break;
                    case "*": wynik = dp.Pomnoz(a, b); break;
                    case "/": wynik = dp.Podziel(a, b); break;
                    case "po": wynik = dp.Poteguj(a, b); break;
                    case "pi": wynik = dp.Pierwiastkuj(a, b); break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór działania");
                        continue;
                }
                Console.WriteLine("Wynik: " + wynik + "\n");
                hist.DodajOperacje(new Operacje(a, b, dzialanieDwuliczbowe, wynik));
            }
            else if (typDzialania == "2")
            {
                Console.WriteLine("Wybierz rodzaj działania:");
                Console.WriteLine("! - Silnia\nsin - sinus\ncos - cosinus\ntan - tangens\nctg - cotangens\nodw - odwrotność liczby\n");
                string dzialanieJednoliczbowe = Console.ReadLine();

                Console.WriteLine("Wprowadź liczbę");
                a = double.Parse(Console.ReadLine());

                switch (dzialanieJednoliczbowe)
                {
                    case "!": wynik = dp.Silnia(a); break;
                    case "sin": wynik = dp.Sinus(a); break;
                    case "cos": wynik = dp.Cosinus(a); break;
                    case "tan": wynik = dp.Tangens(a); break;
                    case "ctg": wynik = dp.Cotangens(a); break;
                    case "odw": wynik = dp.OdwrocLiczbe(a); break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór działania");
                        continue;
                }
                Console.WriteLine("Wynik: " + wynik + "\n");
                hist.DodajOperacje(new Operacje(a, dzialanieJednoliczbowe, wynik));
            }
            else if (typDzialania == "3")
            {
                Console.WriteLine("Wybierz rodzaj działania:");
                Console.WriteLine("cf - Celsjusz -> Fahrenheit\nfc - Fahrenheit -> Celsjusz\nmk - mile -> kilometry\nkm - kilometry -> mile\nsm - stopy -> metry\nms - metry -> stopy\nlg - litry/100km -> mile na galony\ngl - mile na galony -> litry/100km\nkw - konie mechaniczne -> kilowaty\nwk - kilowaty -> konie mechaniczne");

                string konwertuj = Console.ReadLine();

                Console.WriteLine("Wprowadź liczbę:");
                a = double.Parse(Console.ReadLine());

                switch (konwertuj)
                {
                    case "cf": wynik = kw.CelsjuszFahrenheit(a); break;
                    case "fc": wynik = kw.FahrenheitCelsjusz(a); break;
                    case "mk": wynik = kw.MileKilometry(a); break;
                    case "km": wynik = kw.KilometryMile(a); break;
                    case "sm": wynik = kw.StopyMetry(a); break;
                    case "ms": wynik = kw.MetryStopy(a); break;
                    case "lg":
                    case "gl": wynik = kw.LnkMpg(a); break;
                    case "kw": wynik = kw.KonieKilowaty(a); break;
                    case "wk": wynik = kw.KilowatyKonie(a); break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór");
                        continue;
                }
                Console.WriteLine("Wynik: " + wynik + "\n");
                hist.DodajOperacje(new Operacje(a, konwertuj, wynik));
            }
        }
    }
}
