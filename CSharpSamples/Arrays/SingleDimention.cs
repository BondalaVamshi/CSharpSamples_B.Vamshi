using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class SingleDimention
    {
        public void Single()
        {
            Console.WriteLine("enter length of string");
            int l = int.Parse(Console.ReadLine());
            int[] single = new int[l];

            Console.WriteLine("enter the values for single dimentional array");
            for (int i = 0; i < l; i++)
            {
                single[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("your array values are");
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(single[i]);
            }

            Console.WriteLine("this is sorting of an array........");
            Array.Sort(single);
            foreach (int arra in single)
            {
                Console.WriteLine(arra);
            }

            Array.Reverse(single);
            Console.WriteLine("this is reverse of an array........");
            single[1] = 100;
            foreach (int arra in single)
            {
                Console.WriteLine(arra);
            }

            Console.WriteLine("enter the resize of the  array");
            int reSize = int.Parse(Console.ReadLine());
            Array.Resize(ref single, reSize);
            Console.WriteLine("enter the {0} values into resized array", single.Length);
            for (int i = 0; i < reSize; i++)
            {
                single[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("this is resized of an array........");

            foreach (int arra in single)
            {
                Console.WriteLine(arra);
            }
        }

    }
}
