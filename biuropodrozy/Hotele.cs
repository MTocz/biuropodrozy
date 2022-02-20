using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biuropodrozy
{
    public class Hotele
    {
        
        public Hotele(string nazwa, string kraj, string kategoria, int cena)
        {
            //ID = id;
            Nazwa = nazwa;
            Kraj = kraj;
            Kategoria = kategoria;
            Cena = cena;

        }

        //public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Kraj { get; set; }
        public string Kategoria { get; set; }
        public int Cena { get; set; }


    }
}
