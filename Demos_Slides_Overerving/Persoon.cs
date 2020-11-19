using System;
using System.Collections.Generic;
using System.Text;

namespace Demos_Slides_Overerving
{
    class Persoon
    {
        public string Naam {get;set;}
        public string Adres { get; set; }
    }
    class Werknemer : Persoon
    { 
        public string Bedrijf { get; set; }
        public double Loon { get; set; }
    }
    class Student : Persoon
    { 
        public string School { get; set; }
    }

}
