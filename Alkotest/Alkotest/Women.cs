using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkotest
{
    class Women : Person
    {
        public Women()
        {
            imie = "Bezimienna";
            wspolczynnik = 0.6;
        }
        void powitanie()
        {
            Console.WriteLine("Witaj");
            Console.WriteLine(imie);
            Console.WriteLine("!");
        }
    }
}
