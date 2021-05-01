using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class While
    {
        public void WhileMethod()
        {
            Console.WriteLine("enter the number for starting value");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number for ending value");
            int e = int.Parse(Console.ReadLine());
            while (s <= e)
            {
                Console.WriteLine(s);
                s++;
            }

        }
    }
}
