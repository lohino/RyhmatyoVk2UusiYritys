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


        // palauttaa true, jos rivi on oikeassa muodossa
        static public bool OnOikeaMääräSarakkeita(string rivi, int SarakkeidenMaara)
        {
            
            if (rivi.Length == SarakkeidenMaara)
            {
                return true;
            }
            return false;
            
        }

        static public bool Alkupaiva(DateTime alkupäivä, DateTime loppupäivä)
        {
            var tänään = DateTime.Today;
            var tänään2019 = tänään.AddYears(-2);
            if (alkupäivä - tänään2019 < TimeSpan.Zero)
            {
                return false;
            }
            if (loppupäivä - alkupäivä < TimeSpan.Zero)
            {
                return false;
            }
            // viedään lokiin
            return true;
        }
        static public bool MaksimiPituus(string kuvaus)
        {
            if (kuvaus.Length > 500)
            {
                return false;
            }
            return true;
        }

        

    }
}
