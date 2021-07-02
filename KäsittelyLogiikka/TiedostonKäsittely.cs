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
        public bool Alkupaiva(DateTime alkupäivä, DateTime loppupäivä)
        {
            var tänään = DateTime.Today;
            var tänään2019 = tänään.AddYears(-2);
            if (alkupäivä - tänään2019 < TimeSpan.Zero)
            {
                KirjoitaLokiin("Alkupäivä negatiivinen");
                return false;
            }
            if (loppupäivä - alkupäivä < TimeSpan.Zero)
            {
                KirjoitaLokiin("Kesto negatiivinen");
                return false;
            }
            // viedään lokiin
            return true;
        }

        public bool MaksimiPituus(string kuvaus)
        {
            if (kuvaus.Length > 500)
            {
                KirjoitaLokiin("Kuvaus liian pitkä");
                return false;
            }
            return true;
        }

        private void KirjoitaLokiin(string v)
        {
            throw new NotImplementedException();
        }

    }
}
