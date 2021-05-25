using System;
using System.Collections.Generic;
using System.Text;

namespace MTEFacit
{
    public class Lab4
    {
        public void Run()
        {
            Console.Write("Skriv in ditt förnamn:");

            string fornamn = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn:");

            string efternamn = Console.ReadLine();

            Console.WriteLine(efternamn + ", " + fornamn);
        }
    }
}
