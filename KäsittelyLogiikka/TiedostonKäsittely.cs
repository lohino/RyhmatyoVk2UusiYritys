using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Käsittelylogiikka
{
    public class TiedostonKäsittely
    {
        public List<List<string>> kurssikuvaukset { get; set; }

        public static List<List<string>> LueTiedosto(string tiedostopolku)
        {
            try
            {
                var lista = new List<List<string>>();
                var rivit = File.ReadAllLines(tiedostopolku);
                foreach (var rivi in rivit)
                {
                    var kuvaukset = rivi.Split(';').ToList();
                    lista.Add(kuvaukset);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }



    public class TestejaOsa2
    {
        List<string> testiMjono = new List<string>() {"570192;RH416 Red Hat Security: Linux in Physical, Virtual, and Cloud with exam;23.3.2020;27.3.2020;Pasila;Kirja tai muu tuloste;Manage security of Red Hat Enterprise Linux systems deployed in bare-metal, virtual, and cloud environments;True;Technology;Infra;Red Hat;",
                                    "570191; RH415 Red Hat Security: Linux in Physical, Virtual, and Cloud;23.3.2020;26.3.2020;Pasila;Kirja tai muu tuloste; Manage security of Red Hat Enterprise Linux systems deployed in bare-metal, virtual, and cloud environments;True;Technology;Infra;Red Hat;" ,
                                    "569946;AZ-301 Azure Solutions Architect Design;18.11.2019;20.11.2019;Pasila;;Opi suunnittelemaan Azure-ympäristö ja sen arkkitehtuuri.Tämä kurssi tarjoaa syventävää osaamista erityisesti sovellusarkkitehdeille.; True;Technology;Infra;Microsoft Cloud-services;" ,
                                    "569947;AZ-301 Azure Solutions Architect Design;18.11.2019;20.11.2019;Online;;Opi suunnittelemaan Azure-ympäristö ja sen arkkitehtuuri.Tämä kurssi tarjoaa syventävää osaamista erityisesti sovellusarkkitehdeille.; True;Technology;Infra;Microsoft Cloud-services;" };

        //public void Alkupaiva()
        //public bool Alkupaiva(DateTime alkupäivä, DateTime loppupäivä)
        //{
        //    DateTime tänään = new DateTime.Today;
        //    var tänään2019 = tänään.AddYears(-2);
        //    if (alkupäivä - tänään2019 < 0)
        //    {
        //        return false;
        //    }
        //    if (loppupäivä - alkupäivä < 0)
        //    {
        //        return false;
        //    }
        //    // viedään lokiin
        //    return true;
        //}
        public bool MaksimiPituus(string kuvaus)
        {
            if (kuvaus.Length > 500)
            {
                //viedään lokiin
                return false;
            }
            return true;
        }

    }
}
