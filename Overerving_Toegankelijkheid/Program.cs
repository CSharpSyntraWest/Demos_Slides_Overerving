using System;

namespace Overerving_Toegankelijkheid
{
    class Dier
    {
        protected string Naam { get;  set; }
        protected int Leeftijd { get; private set; }
        private void Spreek()
        {
            Console.WriteLine("Dier zegt: joepie ik ben een dier ...");
        }
        protected void Beweeg()
        {
            Console.WriteLine("Dier beweegt ...");
            this.Spreek();
        }
    }
    class Zoogdier : Dier
    {
        public int AantalMaandenDrachtig { get; set; }

        // base.Spreek() kan niet worden aangeroepen (private)
        // this.Naam kan hier gelezen en gewijzigd worden (protected)
    }

    class Hond : Zoogdier
    {
        public string Ras { get; private set; }
        public Hond(string naam, string ras)
        {
            this.Naam = naam; // ok, Naam heeft protected set in parent klasse Dier
            this.Ras = ras;
            //this.Leeftijd = 2;// kan niet worden gewijzigd: private set in klasse Dier
        }
        public void Blaf()
        {
            // base.Spreek();// kan niet worden aangeroepen(private bij  klasse Dier)
            Console.WriteLine("Woef!");
        }
        public void Wandel()
        {
            base.Beweeg();   
        }
    }
    class Program
    {
        static void Main()
        {
            Hond hond = new Hond("Fifi", "Labrador");
            hond.AantalMaandenDrachtig = 6; //ok public property met set in klasse Zoogdier
            Console.WriteLine("Hond " + hond.Ras);//ok leestoegang tot Property Ras
            hond.Wandel(); //ok is public in klasse Hond
            hond.Blaf(); //ok is public in klasse Hond
            //hond.Beweeg();//is protected kan hier niet worden aangeroepen
            //hond.Spreek() //is private in klasse Dier kan niet worden aangeroepen
            //hond.Naam = "Fifi"; // Naam is protected  klasse Dier, kan hier niet worden aangeroepen
            //hond.Ras = "pitbull"; // Ras kan niet worden gewijzigd (private set in klasse Hond)
        }
    }


}
