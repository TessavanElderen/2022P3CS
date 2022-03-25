using System;

namespace Overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse myHorse = new Horse();
            Console.WriteLine(myHorse.age + " " + myHorse.Name + " " + myHorse.animalKingdom);
        }
    }

    class Animal //Base class (parent)
    {
        public float age = 20f; //Animal field
        public string Name = "Shadow"; // Animal field

    }

    class Horse : Animal //derived class (child)
    {
        public string animalKingdom = "Mammel"; //Horse field
    }
}
