using System;

namespace Demo_AfgeleideKlassenVanDier
{
    public class Dier
    {
        private string kleur;
        public Dier(string kleur)
        {
            this.kleur = kleur;
        }
        public string Kleur
        {
            get { return this.kleur; }
        }
        public void Spreek()
        {
            Console.WriteLine("Dier spreekt");
        }
    }
    public class Hond : Dier
    {
        private string naam;
        private string ras;

        public Hond() : base("onbekende kleur") { }
        public Hond(string kleur) : base(kleur) { }
        public Hond(string naam, string ras, string kleur) : base(kleur)
        {
            this.naam = naam;
            this.ras = ras;
        }

        public string Naam
        {
            get { return this.naam; }
            set { this.naam = value; }
        }
        public string Ras
        {
            get { return this.ras; }
        }

    }
    class Program
    {
        static void Main()
        {
            Dier dier = new Dier("Wit");
            Console.WriteLine($"{dier.Kleur} dier :");
            dier.Spreek();

            Hond hond1 = new Hond();
            Console.WriteLine($"hond met {hond1.Kleur} :");
            hond1.Spreek();

            Hond hond2 = new Hond("Bobby", "Golden Retriever", "Beige");
            Console.WriteLine($"{hond2.Naam} is {hond2.Kleur} {hond2.Ras}");
        }
    }
}
