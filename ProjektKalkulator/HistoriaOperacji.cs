using System;
using System.Collections.Generic;

public class HistoriaOperacji
{
    private List<Operacje> historia = new List<Operacje>();

    public void DodajOperacje(Operacje operacja)
    {
        historia.Add(operacja);
    }

    public void WyswietlHistorie()
    {
        if (historia.Count == 0)
        {
            Console.WriteLine("Brak zapisanych operacji.");
        }
        else
        {
            Console.WriteLine("Historia operacji:");
            foreach (Operacje op in historia)
            {
                Console.WriteLine(op);
            }
        }
    }

    public void WyczyscHistorie()
    {
        historia.Clear();
    }

    public bool CzyPusta()
    {
        return historia.Count == 0;
    }
}
