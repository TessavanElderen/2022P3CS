using System;
using Animals; 

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals.Wolves age = new Animals.Wolves();
            age.WolfAge();
        }
    }
}

namespace Animals
{
    class Wolves
    {
        public void WolfAge()
        {
            Console.WriteLine("Wolf is 4 jaar");
        }  
    }
}
