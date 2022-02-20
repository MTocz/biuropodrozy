/*
Informatyka (Inż., sem. 1)
Grupa nr 5​
Michał Pokrywczyński (110902)​
Martyna Toczyska (112785)​
Róża Pietras (109228)
 */

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
            Pokaz1();
            // Losowanie();
            //Wylosować jeden hotel z kategorii 2 z wyjątkiem miasta z losowania 1
            //Wylosować jeden hotel z kategorii 3 z wyjątkiem miasta z losowania 1 i 2
            //Zapytać o wybór hotelu
            //Zapytać o ilość osób dorosłych
            //Zapytać o ilość dzieci
            //Pomnożyć cene z wybranego hotelu przez dorosłych i dzieci
            //Wyświetlić końcową cenę
        }

        public static void StworzListeHoteli()
        {
            _hotele = new List<Hotele>();

            Hotele hotel = new Hotele("Cancun Bay Resort", "Meksyk", "****", 450);
            _hotele.Add(hotel);
            _hotele.Add(new Hotele("Iberostar Quetzal", "Meksyk", "*****", 690));
            _hotele.Add(new Hotele("Imperial Laguna by Faranda", "Meksyk", "***", 320));
            _hotele.Add(new Hotele("Playacalida", "Hiszpania", "*****", 600));
            _hotele.Add(new Hotele("Palia Puerto del Sol", "Hiszpania", "***", 240));
            _hotele.Add(new Hotele("Playa Real Resort", "Hiszpania", "****", 380));
            _hotele.Add(new Hotele("Sea Gull", "Egipt", "***", 270));
            _hotele.Add(new Hotele("Continental Hurghada", "Egipt", "****", 360));
            _hotele.Add(new Hotele("Sharm Grand Plaza", "Egipt", "*****", 620));
            _hotele.Add(new Hotele("Ikaros Hotel", "Grecja", "***", 220));
            _hotele.Add(new Hotele("Labranda Sandy Beach Resort", "Grecja", "*****", 580));
            _hotele.Add(new Hotele("Lida Corfu", "Grecja", "****", 310));
            _hotele.Add(new Hotele("Mytt Beach Hotel", "Tajlandia", "*****", 720));
            _hotele.Add(new Hotele("Novotel Rayong", "Tajlandia", "****", 410));
            _hotele.Add(new Hotele("Cholchan Pattaya Resort", "Tajlandia", "***", 290));


        }


        public static void Powitanie()
        {
            Console.WriteLine("DZISIEJSZE PROMOWANE OFERTY");
            Console.WriteLine("---------------------------");
        }


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

                if (numer > 3) break;
            }

                
                Console.WriteLine("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY:");
                string NumerOferty = Console.ReadLine();
                int WybranaOferta = int.Parse(NumerOferty);

                Hotele WybranyHotel = _hotele[WybranaOferta - 1];
                Console.Clear();

                
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH");
                string dorosli = Console.ReadLine();
                int IloscDoroslych = int.Parse(dorosli);

                Console.Clear();

                
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI");
                string dzieci = Console.ReadLine();
                int IloscDzieci = int.Parse(dzieci);

                Console.Clear();
                Console.WriteLine("CAŁKOWITA CENA WAKACJI WYNOSI: " + (
                    WybranyHotel.Cena * IloscDoroslych + WybranyHotel.Cena * 0.5 * IloscDzieci
                ) * 7 + (" PLN")
                );
            }

        }
    }
