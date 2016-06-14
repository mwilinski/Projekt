using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkotest
{
    abstract class Person : InterfacePerson
    {
    protected double wspolczynnik;
    int wiek { get; set; }
    int wzrost { get; set; }
    public double wynik;
    public int waga;
    public string imie { get; set; }
    private string plec;
    public double policz(double iloscalko)
    {
       return iloscalko/(wspolczynnik*waga);
    }

    }
}
