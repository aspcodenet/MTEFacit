using System;
using System.Collections.Generic;
using System.Text;

namespace MTEFacit.ForLoopar
{
    public class Lab3
    {
        public void Run()
        {
            while (true)
            {
                Console.Write("Tal1:");
                int tal1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tal2:");
                int tal2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Summa:" + (tal1 + tal2));

                Console.Write("Vill du fortsätta J/N:");
                string cont = Console.ReadLine().ToUpper(); //j  J
                if (cont == "N")
                {
                    return;
                }

            }
        }
    }
}
