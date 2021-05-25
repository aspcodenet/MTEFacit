using System;
using System.Collections.Generic;
using System.Text;

namespace MTEFacit.IfSatser
{
    public class Lab7
    {
        /*
         *
Be användaren att mata in namnet på ett land där den bor. Om det är Sverige, 

Danmark, eller Norge skall användare informeras att-Du bor i Skandinavien. Om 

inte meddela användaren att den inte bor i Skandinavien. 

          
         *
         */
        public void Run()
        {
            Console.WriteLine("Mata in namn:");
            string s = Console.ReadLine().ToLower(); //sverige     //Ja    if("ja")
            if (s == "sverige" || s == "danmark" || s == "norge")
            {
                Console.WriteLine("Du bor i Skandinavien");
            }
        }

    }
}
