using System;

namespace Voorbeeld_Virtual_Override
{
    class Dier
    {
        public string Naam { get; set; }
        public int Leeftijd { get; private set; }
        public virtual void Spreek()
        {
            Console.WriteLine("Dier zegt: joepie ik ben een dier ...");
        }
    }
    class Zoogdier : Dier
    {
        public int AantalMaandenDrachtig { get; set; }
        public override void Spreek()
        {
            Console.WriteLine("Dier zegt: hallo ik ben een zoogdier ...");
        }
    }

    class Hond : Zoogdier
    {
        public string Ras { get; private set; }
        public Hond(string naam, string ras)
        {
            this.Naam = naam; 
            this.Ras = ras;
        }
        public override void Spreek()
        {
            Console.WriteLine("Woef!");
        }
        
    }
    class Program
    {
        static void Main()
        {
            Dier dier = new Dier();
            dier.Spreek();
            Zoogdier zoogdier = new Zoogdier();
            zoogdier.Spreek();
            Hond hond = new Hond("Fifi", "Labrador");
            hond.Spreek();
        }
    }
}
