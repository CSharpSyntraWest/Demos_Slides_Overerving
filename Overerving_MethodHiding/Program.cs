using System;

namespace Overerving_MethodHiding
{
    class Dier
    {
        public string Naam { get; set; }
        public void Spreek()
        {
            Console.WriteLine("Dier zegt: joepie ik ben een dier ...");
        }
        protected void Beweeg()
        {
            Console.WriteLine("Dier beweegt ...");
        }
    }
    class Hond:Dier
    { 
        public string Naam { get; set; }

        public void Spreek()
        { 
            Console.WriteLine("Woef!!")
        }

    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
