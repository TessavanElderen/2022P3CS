using System;

namespace Functies_Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(myName());
        }

        static string myName()
        {
            string name = "Tessa";
            return name; 
        }
    }
}
