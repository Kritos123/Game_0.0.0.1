using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_0._0._0._1.Budovy
{
    class Budova
    {
        // Deklarace private proměných
        private int level;
        private string cena;
        private string info;

        //Get Set
        public int Level {get{ return level; } set { level = value; } }
        public string Cena { get { return cena; } set { cena = value; } }
        public string Info { get { return info; } set { info = value; } }

        //Bezparametrický konstruktor
        public Budova() { }

        //Parametricky kontruktor
        public Budova(int level, string cena, string info)
        {
            this.Level = level;
            this.Cena = cena;
            this.Info = info;

        }
        
        //To string
        public override string ToString()
        {
            return string.Format("{0},{1},{2}", Level, Cena, Info);
        }
    }
}
