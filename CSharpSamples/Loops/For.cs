using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class For
    {
        public void ForPattern()
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                
            }

            Console.WriteLine("the curve");
            for (int i = 0; i <= 3 * n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == j || i + j == 2 * n )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            
            Console.ReadKey();
        }
    }
}
