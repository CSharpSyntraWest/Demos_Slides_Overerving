using System;

namespace MetInheritance3
{
    using System;
    using System.Collections.Generic;

    class Figuur
    {
        public string Kleur { get; set; }
    }
    class Vierkant : Figuur
    {
        public double Zijde { get; set; }
    }

    class Rechthoek : Figuur
    {
        public double Breedte { get; set; }
        public double Hoogte { get; set; }
    }
    class Cirkel : Figuur
    {
        public double Straal { get; set; }
    }
    class Tekening
    {
        private List<Figuur> _figuren;
        public Tekening()
        {
            _figuren = new List<Figuur>();
        }
        public Figuur this[int index]
        {
            get { return _figuren[index]; }
            set { _figuren[index] = value; }
        }
        public int Count
        {
            get { return _figuren.Count; }
        }
        public void Add(Figuur item)
        {
            _figuren.Add(item);
        }
        public void KleurAllesZwart()
        {
            for (int index = 0; index < Count; index++)
                this[index].Kleur = "zwart";
        }
    }
    class Program
    {
        static void Main()
        {
            Rechthoek r1 = new Rechthoek { Hoogte = 5d, Breedte = 4d, Kleur = "geel" };
            Cirkel c1 = new Cirkel { Straal = 10d, Kleur = "rood" };
            Vierkant v1 = new Vierkant { Zijde = 15d, Kleur = "blauw" };
            Tekening tekening1 = new Tekening();
            tekening1.Add(r1);
            tekening1.Add(c1);
            tekening1.Add(v1);
            Print(tekening1);                             
            tekening1.KleurAllesZwart();
            Print(tekening1); 
            Console.ReadLine();
        }
        static void Print(Tekening fn)
        {
            Console.WriteLine("Alle figuren in de tekening: ");
            for (int index = 0; index < fn.Count; index++)
            {
                Figuur f = fn[index];
                string naamNameSpace = f.GetType().Namespace;
                string naamAfgeleideType = f.GetType().ToString().Replace(naamNameSpace + ".", "");
                 string basisType = f.GetType().BaseType.Name;
                Console.WriteLine($"- {basisType} is een {naamAfgeleideType} met kleur {f.Kleur}.");
            }
            Console.WriteLine();
        }

    }
}
