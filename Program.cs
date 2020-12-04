using System;

namespace Dames
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau damier = new Plateau();
            Console.WriteLine("Commencer une partie ! ");
            damier.Damier();
            //Console.ReadKey(true);
        }
    }
}
