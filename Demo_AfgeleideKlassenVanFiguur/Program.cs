using System;
using System.Collections.Generic;

namespace Demo_AfgeleideKlassenVanFiguur
{
    /* Oefening Afgeleide klasse Vierkant van Figuur maken
       *Vul onderstaande code aan:
        Maak een afgeleide klasse Vierkant van de klasse Figuur
        Voeg een public Auto-property Zijde toe (double)

        Maak in de Main() een variabele vierkant1 van type Vierkant en geef deze de kleur “Wit” en Zijde = 2.5

        Maak in de Main() een variable figuur van type Figuur en zet hierin een object van klasse Vierkant met kleur “Paars” en zijd = 1.5
        Voeg vierkant1 en figuur toe aan tekening1
        Roep de methode PrintTekening aan van tekening1

     */
    class Tekening
    {
        private List<Figuur> _figuren; //standaar is _figuren null
        public Tekening()
        {
            _figuren = new List<Figuur>(); //initialiseer tekening met lege lijst van Figuur objecten
        }
        public void VoegFiguurToe(Figuur figuur)
        {
            _figuren.Add(figuur);            
        }
        public void VerwijderFiguur(Figuur figuur)
        {
            _figuren.Remove(figuur);
        }
        public int AantalFiguren  //nu is het een Property met enkel leestoegang
        {
            get { return _figuren.Count; }
        }
        public void PrintTekening() //public methode van klasse Tekening
        {
            foreach (Figuur figuur in _figuren)
            {
                Console.WriteLine($"Figuur met kleur {figuur.Kleur}");
            }
        }
        public void ZetKleurVanAlleFiguren(string kleur)//public methode van klasse Tekening
        {
            for (int i = 0; i < _figuren.Count; i++)
            {
                _figuren[i].Kleur = kleur;
            }
        }
    }
    class Figuur
    {
        public string Kleur { get; set; }
    }
    class Rechthoek : Figuur //Rechthoek is afgeleide klasse van Figuur
    { 
        public double Breedte { get; set; }
        public double Hoogte { get; set; }
    }
    class Cirkel : Figuur//Cirkel is afgeleide klasse van Figuur
    { 
        public double Straal { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Tekening tekening = new Tekening();
            Console.WriteLine("Aantal figuren in tekening: " + tekening.AantalFiguren);
            Rechthoek r1 = new Rechthoek() { Kleur = "Groen", Breedte = 2, Hoogte = 3 };
            Cirkel c1 = new Cirkel() { Kleur = "Blauw", Straal = 2 };
            Figuur f1 = new Figuur() { Kleur = "Rood" };
            tekening.VoegFiguurToe(r1);
            tekening.VoegFiguurToe(c1);
            tekening.VoegFiguurToe(f1);
            Console.WriteLine("Aantal figuren in tekening: " + tekening.AantalFiguren);
            tekening.PrintTekening();
            tekening.ZetKleurVanAlleFiguren("Zwart");
            tekening.PrintTekening();


            //Figuur f2 = r1;//ok lukt 
            //               // Rechthoek r2 = f1;//niet ok lukt niet
            //Figuur f3 = new Cirkel() { Kleur = "Geel", Straal = 1 };//ok lukt
            //Console.WriteLine($"Figuur f1 {f1.Kleur} ");
            //Console.WriteLine($"Rechthoek r1 {r1.Kleur} {r1.Breedte} x {r1.Hoogte}");
            //Console.WriteLine($"Cirkel c1 {c1.Kleur} straal={c1.Straal}");
            //Console.WriteLine($"Figuur f3 {f3.Kleur}");
        }
    }
}
