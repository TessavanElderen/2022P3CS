using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


// maak een functie die kan vermenigvuldigen en het kan laten zien 
// Zorg ervoor dat de som die je maakt kan vermenigvuldigen en + en of - som
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekenmachine rekenmachine = new Rekenmachine();
            int plusResultaat = rekenmachine.Plus(8, 2);
            int keerResultaat = rekenmachine.VermenigVuldigen(3, 16);
            
            Console.WriteLine(keerResultaat);
            Console.WriteLine(plusResultaat); 
        }
    }
    class Rekenmachine
    {
        public int VermenigVuldigen(int eersteGetal, int tweedeGetal)
        {
            int result = eersteGetal * tweedeGetal;
            return result;
        }

        public int Plus(int eersteGetal, int tweedeGetal)
        {
            return eersteGetal + tweedeGetal;
        }
    }
}
