using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_OOP4
{
    class Zbozi
    {
        protected string nazevzbozi;
        protected double cena;
        protected DateTime datumvyroby;
        protected int pocetdnimintrvanlivosti;

        public Zbozi(string nazevzbozi, double cena, DateTime datumvyroby, int pocetdnimintrvanlivosti)
        {
            this.nazevzbozi = nazevzbozi;
            this.cena = cena;
            this.datumvyroby = datumvyroby;
            this.pocetdnimintrvanlivosti = pocetdnimintrvanlivosti;
        }
        public bool MinTrvanlivost()
        {
            /* int pocetdni = 0;
             TimeSpan trvanlivost = datumvyroby.Days + TimeSpan.FromDays(pocetdnimintrvanlivosti);
             pocetdni = trvanlivost.Days;
             if (pocetdni > 0)
             {
                 JeProsle = false;
             }
             else
             {
                 JeProsle = true;
                 pocetdni = 0;
             }
             return pocetdni;*/
            if ((DateTime.Now.DayOfYear - datumvyroby.DayOfYear) > pocetdnimintrvanlivosti)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual double CenasDPH()
        {
            cena = (cena * 121) / 100;
            return cena;
        }
        public override string ToString()
        {
            if(MinTrvanlivost())
            {
                return String.Format("Název zboží je {0}, jeho cena s DPH je {1}, datum výroby je {2}\n a zboží NEPŘEKROČILO min. trvanlivost.",nazevzbozi,CenasDPH(),datumvyroby);
            }
            else
            {
                return String.Format("Nazev zboží je {0}, jeho cena s DPH je {1}, datum výroby je {2}\n a zboží PŘEKROČILO min. trvanlivost.", nazevzbozi, CenasDPH(), datumvyroby);
            }
        }
    }
}
