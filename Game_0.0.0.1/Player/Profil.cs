using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_0._0._0._1.Budovy;
using Game_0._0._0._1.Database_connection;

namespace Game_0._0._0._1.Player
{
    class Profil:Osoba
    {
       //Deklarace
        Connect cn = new Connect();

        //Get Set
        public Hlavni_budov hl
        {
            get;
            set;
        }

        //Konstruktory
        public Profil() { }

        public Profil(string jmeno, int id) : base(jmeno)
        {
           cn.Connect_hl(id);
           hl = cn.Bd;
           
        }

       public Profil(string jmeno, Hlavni_budov Hl) : base(jmeno)
        {

            hl = Hl;

        }

        //To string
        public override string ToString()
        {
            return string.Format(hl.ToString()+base.ToString());
        }
    }
}
