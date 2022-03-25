using System;

namespace Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myObj = new Number();
            myObj.Getal = 5;
            Console.WriteLine(myObj.Getal);
        }
    }

    class Number 
    {
        private int getal;
        public int Getal
        {
            get { return getal;}
            set { getal = value;}
        }
    }
}
