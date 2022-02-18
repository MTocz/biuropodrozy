using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biuropodrozy
{
    class Program
    {
        private static List<Hotele> _hotele;


        static void Main(string[] args)
        {
            //Stworzyć listę hoteli
            StworzListeHoteli();
            //Pofiltrować liste hoteli na kategorie
            //Wyświetlić napis promowane oferty
            Powitanie();
            //Wylosować jeden hotel z kategorii 1 i wyświetlić
            //Kategoria ***
            Pokaz1();
            // Losowanie();
            //Wylosować jeden hotel z kategorii 2 z wyjątkiem miasta z losowania 1
            //Wylosować jeden hotel z kategorii 3 z wyjątkiem miasta z losowania 1 i 2
            //Zapytać o wybór hotelu
            WyborOferty();
            //Zapytać o ilość osób dorosłych
            PodajDoroslych();
            //Zapytać o ilość dzieci
            PodajDzieci();
            //Pomnożyć cene z wybranego hotelu przez dorosłych i dzieci
            //Wyświetlić końcową cenę
        }

        public static void StworzListeHoteli()
        {
            _hotele = new List<Hotele>();

            Hotele hotel = new Hotele(4, "Cancun Bay Resort", "Meksyk", "****", 450);
            _hotele.Add(hotel);
            _hotele.Add(new Hotele(5, "Iberostar Quetzal", "Meksyk", "*****", 690));
            _hotele.Add(new Hotele(3, "Imperial Laguna by Faranda", "Meksyk", "***", 320));
            _hotele.Add(new Hotele(5, "Playacalida", "Hiszpania", "*****", 600));
            _hotele.Add(new Hotele(3, "Palia Puerto del Sol", "Hiszpania", "***", 240));
            _hotele.Add(new Hotele(4, "Playa Real Resort", "Hiszpania", "****", 380));
            _hotele.Add(new Hotele(3, "Sea Gull", "Egipt", "***", 270));
            _hotele.Add(new Hotele(4, "Continental Hurghada", "Egipt", "****", 360));
            _hotele.Add(new Hotele(5, "Sharm Grand Plaza", "Egipt", "*****", 620));
            _hotele.Add(new Hotele(3, "Ikaros Hotel", "Grecja", "***", 220));
            _hotele.Add(new Hotele(5, "Labranda Sandy Beach Resort", "Grecja", "*****", 580));
            _hotele.Add(new Hotele(4, "Lida Corfu", "Grecja", "****", 310));
            _hotele.Add(new Hotele(5, "Mytt Beach Hotel", "Tajlandia", "*****", 720));
            _hotele.Add(new Hotele(4, "Novotel Rayong", "Tajlandia", "****", 410));
            _hotele.Add(new Hotele(3, "Cholchan Pattaya Resort", "Tajlandia", "***", 290));

        }

        //void StworzKategorie()
        //{
        // KategorieHoteli = WszystkieHotele.Select(x => x.Kategoria).Distinct()
        // .OrderBy(x => x).ToList();  
        // }


        public static void Powitanie()
        {
            Console.WriteLine("DZISIEJSZE PROMOWANE OFERTY");
            Console.WriteLine("---------------------------");
        }

        //*public static void Grupowanie()
        //{
        // List<string> kat3 = new List<string>(Hotele);
        //IEnumerable<IGrouping<string, string>> query = from gwi in gwiazdki
        //group gwi by gwi = "***";
        //foreach (var group in query)
        // {
        //Console.WriteLine(group.Key == 0);
        //foreach (string i in group)
        //Console.WriteLine(i);
        //}

        //}

        public static void Pokaz1()
        {
            int numer = 1;
            foreach (Hotele hotel in _hotele)
            {
                Console.WriteLine("NUMER: " + numer);
                numer++;
                Console.WriteLine("KRAJ: " + hotel.Kraj);
                Console.WriteLine("TERMIN: 15.06.2022 - 22.06.2022 (7 dni)");
                Console.WriteLine("HOTEL: " + hotel.Nazwa + " (" + hotel.Kategoria + ")");
                Console.WriteLine("WYŻYWIENIE: śniadania");
                Console.WriteLine("CENA: " + (hotel.Cena * 7) + " PLN/os");
                Console.WriteLine("---------------------------");


            }
            
        }

        public static void WyborOferty()
        {
            Console.WriteLine("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY:");
            string NumerOferty = Console.ReadLine();
            int WybranaOferta = int.Parse(NumerOferty);

            Hotele WybranyHotel = _hotele[WybranaOferta - 1];
            Console.Clear();

        }
        public static void PodajDoroslych()

        {
            Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH");
            string dorosli = Console.ReadLine();
            int IloscDoroslych = int.Parse(dorosli);

            Console.Clear();

        }
        public static void PodajDzieci()

        {
            Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI");
            string dzieci = Console.ReadLine();
            int IloscDzieci = int.Parse(dzieci);

            Console.Clear();
            Console.WriteLine("CAŁKOWITA CENA WAKACJI WYNOSI: ");

        }

    }
}
