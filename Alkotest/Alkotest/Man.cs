using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkotest
{
    class Man : Person
    {
       public Man()
        {
            imie = "Bezimienny";
            wspolczynnik = 0.7;
        }
        void powitanie()
        {
            Console.WriteLine("Witaj");
            Console.WriteLine(imie);
            Console.WriteLine("!");
        }
    }
}
