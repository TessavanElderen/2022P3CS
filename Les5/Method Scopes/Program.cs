using System;

namespace Method_Scopes
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (true)
            {
                // Scope line 8: If Statement & Alles er buiten
                string scope8Var = "8";
                string scope12Var = "12";
                string scope17Var = "N/A";

                if (true)
                {
                    // Scope line 12: If Statement & Alles er buiten
                    scope12Var = "12";
                }

                if (false)
                {
                    // Scope line 17: If Statement & Alles er buiten    
                    scope17Var = "17";
                }

                Console.WriteLine("This was set in scope line 8: " + scope8Var);
                Console.WriteLine("This was set in scope line 12: " + scope12Var);
                Console.WriteLine("This was set in scope line 17: " + scope17Var);
            }
        }
    }
}
