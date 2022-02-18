using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biuropodrozy
{
    public class Hotele
    {
        
        public Hotele(int kategoria, string nazwa, string kraj, string gwiazdki, int cena)
        {
            //ID = id;
            Kategoria = kategoria;
            Nazwa = nazwa;
            Kraj = kraj;
            Gwiazdki = gwiazdki;
            Cena = cena;

        }

        //public int ID { get; set; }
        public int Kategoria { get; set; }
        public string Nazwa { get; set; }
        public string Kraj { get; set; }
        public string Gwiazdki { get; set; }
        public int Cena { get; set; }


    }
}
