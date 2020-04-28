using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_0._0._0._1.Budovy
{
    class Hlavni_budov : Budova
    {
        //Deklarace private proměných
        private string nazev;

        //Get Set
        public string Nazev { get { return nazev; }set { nazev = value; } }
        //Bezparametrický konstruktor
        public Hlavni_budov() : base() { }

        //Paramtrický konstruktor
        public Hlavni_budov(int level, string cena, string info, string nazev) : base(level, cena, info)
        {
            this.Nazev = nazev;
        }

        //To string
        public override string ToString()
        {
            return string.Format(base.ToString() + "{0}", nazev);
        }
    }
}
