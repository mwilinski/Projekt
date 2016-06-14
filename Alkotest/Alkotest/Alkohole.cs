using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkotest
{
    class Alkohole
    {
        
        public enum Rodzaje : int { wodka =30,piwo=250,wino=100};
        public Rodzaje rodzaj { get; set; }
        public double ilosc;
        public Rodzaje zwrocRodzaj(string nazwa)
        {
            Rodzaje rodzaj=0;
            if (nazwa == "piwo")
                rodzaj = Rodzaje.piwo;
            if (nazwa == "wino")
                rodzaj=Rodzaje.wino;
            if (nazwa == "wodka")
                rodzaj=Rodzaje.wodka;
             return rodzaj;
        }
        public double zwrocCzystyAlko(Rodzaje rodzaj)
        {
            double a = (int)rodzaj;
            return (ilosc/a)*10;
            
        }
       
    }
}
