using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_OOP4
{
    internal class Produkt : Zbozi
    {
        private bool lzezlevnit;

        public Produkt(string nazevzbozi, double cena, DateTime datumvyroby, int pocetdnimintrvanlivosti, bool lzezlevnit) : base(nazevzbozi, cena, datumvyroby, pocetdnimintrvanlivosti)
        {
            this.lzezlevnit = lzezlevnit;
        }
        public override double CenasDPH()
        {
            if (MinTrvanlivost() && lzezlevnit)
            {
                return base.CenasDPH();
            }
            else if (lzezlevnit != false)
            {
                return base.CenasDPH() * 0.6;
            }
            else { return base.CenasDPH(); }
        }
    }
}
