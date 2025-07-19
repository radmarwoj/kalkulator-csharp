public class Operacje
{
    private double operand1;
    private double operand2;
    private string operatorSymbol;
    private double wynik;
    private bool jednoliczbowa;

    public Operacje(double operand1, double operand2, string operatorSymbol, double wynik)
    {
        this.operand1 = operand1;
        this.operand2 = operand2;
        this.operatorSymbol = operatorSymbol;
        this.wynik = wynik;
        this.jednoliczbowa = false;
    }

    public Operacje(double operand1, string operatorSymbol, double wynik)
    {
        this.operand1 = operand1;
        this.operand2 = 0;
        this.operatorSymbol = operatorSymbol;
        this.wynik = wynik;
        this.jednoliczbowa = true;
    }

    public double Operand1
    {
        get { return operand1; }
        set { operand1 = value; }
    }

    public double Operand2
    {
        get { return operand2; }
        set { operand2 = value; }
    }

    public string OperatorSymbol
    {
        get { return operatorSymbol; }
        set { operatorSymbol = value; }
    }

    public double Wynik
    {
        get { return wynik; }
        set { wynik = value; }
    }

    public bool Jednoliczbowa
    {
        get { return jednoliczbowa; }
        set { jednoliczbowa = value; }
    }

    public override string ToString()
    {
        if (jednoliczbowa)
        {
            return $"{operand1} {operatorSymbol} = {wynik}";
        }
        else
        {
            return $"{operand1} {operatorSymbol} {operand2} = {wynik}";
        }
    }
}
