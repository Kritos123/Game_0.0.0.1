using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_0._0._0._1.Budovy
{
    class Dul:Budova
    {
        //Deklarace private proměných
        private string nazev;
        private int coins_p_s;

        //Get Set
        public string Nazev { get { return nazev; } set { nazev = value; } }
        public int Coins_p_s { get { return coins_p_s; } set { coins_p_s = value; } }
        //Bezparametrický konstruktor
        public Dul() : base() { }

        //Paramtrický konstruktor
        public Dul(int level, string cena, string info, string nazev, int coins_p_s) : base(level, cena, info)
        {
            this.Nazev = nazev;
            this.Coins_p_s = coins_p_s;
        }
    }
}
