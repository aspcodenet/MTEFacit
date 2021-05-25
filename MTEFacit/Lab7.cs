using System;
using System.Collections.Generic;
using System.Text;

namespace MTEFacit
{
    public class Lab7
    {
        public void Run()
        {
            Console.Write("Skriv in ditt tal1:");

            //float eller double   3.1415q
            decimal tal1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Skriv in ditt tal2:");

            decimal tal2 = Convert.ToDecimal(Console.ReadLine());

            decimal avg = (tal1 + tal2) / 2;

            Console.WriteLine("Summan är " + (tal1+tal2).ToString()  );
            Console.WriteLine("Differensen är " + (tal1 - tal2).ToString());
            Console.WriteLine("Summan är " + avg.ToString());

        }
    }
}
