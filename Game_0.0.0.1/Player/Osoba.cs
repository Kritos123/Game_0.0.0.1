using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_0._0._0._1.Budovy;

namespace Game_0._0._0._1.Player
{
    class Osoba
    {   //Private proměné
        private string jmeno;
        private int id=0;
       
        //Get Set
        public string Jmeno { get{ return jmeno; }set { jmeno = value; } }
        public int Id { get { return id; }set { id = id++; } }

        //Bezparametrický konstruktor
        public Osoba() { }
       
        //Paramatrický konstruktor
        public Osoba(string jmeno)
        {
           // this.Id = id;
            this.Jmeno = jmeno;

        }
        //To string
        public override string ToString()
        {
            return string.Format("{0}",Jmeno);
        }
    }
}
