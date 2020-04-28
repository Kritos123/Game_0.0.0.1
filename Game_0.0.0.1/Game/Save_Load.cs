using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Game_0._0._0._1.Budovy;
using Game_0._0._0._1.Player;


namespace Game_0._0._0._1.Game
{
    class Save_Load:Profil
    {
        XmlWriterSettings settings;
      
        //Konstruktor
        public Save_Load()
        {
            settings = new XmlWriterSettings();
            settings.Indent = true;

        }
    
        //Ukladani do xml
        public void Save_xml(Profil pr)
        {
            // Zápis uživatelů
            using (XmlWriter xw = XmlWriter.Create(@"Save.xml", settings))
            {
                xw.WriteStartDocument(); // hlavička
                xw.WriteStartElement("Profily"); // otevření kořenového elementu uzivatele

                // zápis jednotlivých uživatelů
                
                    xw.WriteStartElement("Profil");
                    xw.WriteElementString("Jmeno", pr.Jmeno);
                    xw.WriteElementString("Level", pr.hl.Level.ToString());
                    xw.WriteElementString("Cena", pr.hl.Cena);
                    xw.WriteElementString("Info", pr.hl.Info);
                    xw.WriteElementString("Nazev", pr.hl.Nazev);
                    xw.WriteEndElement();
                

                xw.WriteEndElement(); // uzavření kořenového elementu
                xw.WriteEndDocument(); // konec dokument
                xw.Flush();
            }
        }

        //Nacteni do xml
        public Profil Load()
        {
            try
            {
                XmlReader xr = xr = XmlReader.Create(@"Save.xml");
                int level = 0;
                String cena="";
                String jmeno = "";
                String nazev = "";
                String info = "";
                string element = "";
                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        element = xr.Name;

                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {
                            case "Jmeno":
                                jmeno = xr.Value;
                                break;
                            case "Level":
                                level = int.Parse(xr.Value);
                                break;
                            case "Cena":
                                cena = xr.Value;
                                break;
                            case "Info":
                                info = xr.Value;
                                break;
                            case "Nazev":
                                nazev = xr.Value;
                                break;
                        }
                    }

                    else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "Profil"))
                        return new Profil(jmeno,new Hlavni_budov(level,cena,info,nazev));
                }
                xr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Neexistující soubor", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        //To string
        public override string ToString()
        {
            return string.Format(base.ToString());
        }
        
       
    }
}


