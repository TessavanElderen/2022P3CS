using System;

namespace Oefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Student
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    internal abstract class Skill
    {
        internal string name;

        internal abstract void Use();

        internal virtual void OnActivate()
        {

        }
    }

    internal class FireBall : Skill
    {
        internal override void Use()
        {
            Use();
        }

        internal override void OnActivate()
        {
            base.OnActivate();
        }

    }

}
