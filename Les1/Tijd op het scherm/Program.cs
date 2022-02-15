using System;
using System.Timers; 

namespace Tijd_op_het_scherm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Timer tr = new Timer(1000);
            tr.Elapsed += Tr_Elapsed;
            tr.Enabled = true;
            tr.AutoReset = true;
            tr.Start();

            Console.ReadKey();
        }
        private static void Tr_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime time = DateTime.Now;
            string datumTijd = "HH:mm:ss"; 
            Console.WriteLine(time.ToString(datumTijd));
        }
    }
}
