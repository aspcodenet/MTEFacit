using System;
using System.Collections.Generic;
using System.Text;

namespace MTEFacit.ForLoopar
{
    public class Lab1
    {
        public void Run()
        {
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int k = 0;
            while (true)
            {
                Console.WriteLine(k);
                if (k > 10)
                    break;
                k++;
            }

            

        }
    }
}
