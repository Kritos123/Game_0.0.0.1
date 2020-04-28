using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_0._0._0._1.Budovy;

namespace Game_0._0._0._1.Database_connection
{
    class Connect
    {
       // Deklarace
       private Hlavni_budov bd;

       //Get Set
       public Hlavni_budov Bd { get { return bd; } set { bd = value; } }

       //Konstruktory
       public Connect()
        {
            
            this.Bd = bd;
        }
       
       //Metoda pro cetni z databaze pro Hlavni budovu
       public  void  Connect_hl(int id)
        {
            using (Game_dataEntities context = new Game_dataEntities())
            {
                Hlavni_budova hl = context.Hlavni_budova.FirstOrDefault(r => r.Id == id);

                Bd= new Hlavni_budov(hl.Id, hl.Cena, hl.Info, hl.Nazev);
            }
       
        }
    }
}
