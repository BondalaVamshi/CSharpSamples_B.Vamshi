using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = null;
            int? i = null;
            Console.WriteLine("null i: "+i);
            i = 100;
            Console.WriteLine("value of i :"+i);
            
            Console.WriteLine($"max value of i:{int.MaxValue}");
            Console.WriteLine($"min value of i:{int.MinValue}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            // double d = null;
            double? d = null;
            Console.WriteLine("null of d:"+d);
            d = 100.00;
            Console.WriteLine("value of d:"+d);
            Console.WriteLine($"max value of d:{double.MaxValue}");
            Console.WriteLine($"min value of d:{double.MinValue}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //float f = null;
            float? f = null;
            Console.WriteLine("null of f:" + f);
            f = 100.00f;
            Console.WriteLine("value of f:" + f);
            Console.WriteLine($"max value of f:{float.MaxValue}");
            Console.WriteLine($"min value of f:{float.MinValue}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //char c = null;
            char? c = null;
            Console.WriteLine("null of c:"+c);
            c = 'a';
            Console.WriteLine("value of c:"+c);
            Console.WriteLine("min value of char:"+char.MinValue);
            Console.WriteLine("max value of char:" + char.MaxValue);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //bool b = null;
            bool? b = null;
            Console.WriteLine("null of b:" + b);
            b = true;
            Console.WriteLine("value of b:" + b);
            //Console.WriteLine("min value of char:" + bool.MinValue);
            //Console.WriteLine("max value of char:" + bool.MaxValue);

            Console.WriteLine("\n");
            Console.WriteLine("\n");


            string s = null;
            Console.WriteLine("null value of s"+s);
           
        }
    }
}
