using System;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "this is a string s";
            int i = s.Length;

            var v = "this is var v";
            int i1 = v.Length;

            dynamic d = "this is dynamic";
            // int i2 = v.length;
            int i2 = d.Length;

            dynamic d2 = 100;
            Console.WriteLine("Value: {0}, Type: {1}", d2, d2.GetType());

            d2 = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", d2, d2.GetType());

            d2 = true;
            Console.WriteLine("Value: {0}, Type: {1}", d2, d2.GetType());

        }
    }
}
