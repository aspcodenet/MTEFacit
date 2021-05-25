using System;
using System.Collections.Generic;
using System.Text;

namespace MTEFacit.IfSatser
{
    public class Lab2
    {

        /*
Be användaren att mata in hur många paket mjölk som finns kvar. Är det mindre än 

10 skriv- Beställ 30 paket. Är det mellan 10 och 20 skriv- Beställ 20 paket. Annars 

skriv-Du behöver inte beställa någon mjölk.          *
         */
        public void Run()
        {
            Console.Write("Hur många paket finns det kvar?");
            int paket = Convert.ToInt32(Console.ReadLine());
            if (paket < 10)
            {
                Console.WriteLine("Beställ 30 paket");
            }
            else if (paket > 10 && paket < 20)
            {
                Console.WriteLine("Beställ 20 paket");
            }
            else 
            {
                Console.WriteLine("Du behöver inte beställa nån mjölk");
            }
        }
    }
}
