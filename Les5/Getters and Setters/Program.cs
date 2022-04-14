using System;

namespace Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myObj = new Number(); // instantie in een variable opgeslagen
            myObj.SetGetal(40);
            Console.WriteLine(myObj.GetGetal());
        }
    }

    class Number 
    {       
        private int hallogetal;
        public void SetGetal(int getal) // locale variable
        {
            hallogetal = getal;
        }
           
        public int GetGetal()
        {
            return hallogetal; 
        }
    }
}
