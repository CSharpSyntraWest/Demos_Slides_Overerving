using System;

namespace Demo_AfgeleideKlassenVanPersoon
{
    class Persoon
    {
        public string Naam { get; set; }
        public string Adres { get; set; }
        
    }

    class Student : Persoon
    { 
        public string School { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Student student = new Student() { Naam="Jan", Adres="Molenstraat 8 9000 Gent",School="Syntra-West"};
            Console.Write($"Student {student.Naam} volgt les bij {student.School} ");
        }
    }
}
