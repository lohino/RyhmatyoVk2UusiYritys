using System;
using System.Diagnostics;
using System.IO;
using Käsittelylogiikka;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string loki = "c:\\temp\\loki.txt";
            if (!Directory.Exists("C:\\temp\\")) { Directory.CreateDirectory("c:\\temp\\"); }
            var tk = TiedostonKäsittely.LueTiedosto("");
            int sar = tk[0].Count;
            foreach (var item in tk)
            {
                try
                {

                    if (TiedostonKäsittely.OnOikeaMääräSarakkeita(item[6], sar))
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        KirjoitaLokiin(loki, "Kommentti liian pitkä");
                    }
                }
                catch
                {

                }
                try
                {
                    DateTime alkup = new DateTime(Convert.ToInt32(item[2]));
                    DateTime loppu = new DateTime(Convert.ToInt32(item[3]));
                    if (TiedostonKäsittely.Alkupaiva(alkup, loppu))
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        KirjoitaLokiin(loki, "virhe alkupäivämäärässä tai lopetus ennen aloitusta");
                    }
                }
                catch
                {
                    
                }

                try
                {
                    
                    if (TiedostonKäsittely.MaksimiPituus(item[6]))
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        KirjoitaLokiin(loki, "Kommentti liian pitkä");
                    }
                }
                catch
                {

                }

                
            }
        }
        static public void KirjoitaLokiin(string loki, string v)
        {
            if (!File.Exists(loki)) { File.Create(loki); }
            File.AppendAllText(loki, v);
        }
    }
}
