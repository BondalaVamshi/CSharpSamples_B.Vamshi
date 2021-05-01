using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is \"int\" datatypes");
            int i;
            //i = 100;
            i = new int();
            Console.WriteLine(i);
            //i = "100";
            //i = 100.0;
            i = 'a';
            Console.WriteLine(i);
            //i = 'abc';
            //i = true;
            i = int.MaxValue;
            Console.WriteLine(i);
            i = int.MinValue;
            Console.WriteLine(i);
            // i = null;

            int? i1 = null;
            Console.WriteLine(i1);
            i1 = 100;
            Console.WriteLine(i1);
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Console.WriteLine("this is \"double\" datatype");
            double d;
            d = new float();
            Console.WriteLine(d);
            d = 100;
            d = 100.0;
            //d = "double";
            d = 'h';
            Console.WriteLine(d);
            //d = 'abc';
            //d = true;
            //d = null;

            double? d1 = null;
            Console.WriteLine(d);
            d = double.MaxValue;
            Console.WriteLine(d);
            d = double.MinValue;
            Console.WriteLine(d);
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            Console.WriteLine("this is \"float\" dataypes");
            float f;
            f = new float();
            Console.WriteLine(f);
            f = 100;
            // f = 100.0;
            f = 100.0f;
            Console.WriteLine(f);
            // f = "float";
            f = 'f';
            Console.WriteLine(f);
            // f = 'abc';
            d = 100.00;
            f = 100.00f;
            //f = 100.00d;
            double df = 100.00f;
            Console.WriteLine(df);
            // float f1 = null;
            float? f1 = null;
            Console.WriteLine(f1);
            f1 = 100.00f;
            Console.WriteLine(f1);
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            Console.WriteLine("this is \" char\" datatype");
            char c;
            c = new char();
            Console.WriteLine("default value : "+c);
            c = 'c';
            //c = 'char';
            //c = "c";
            //c = 100;
            //c = true;
            char c1 = 'a';
            char c2 = 'b';
            Console.WriteLine(c1 + " " + c2);
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
            //char c3 = c1 + c2;
            // char c3 = '65';


            Console.WriteLine("this is \"BOOL\" datatype");
            bool b;
            b = new bool();
            Console.WriteLine("default value: "+b);
            b = true;
            Console.WriteLine(b);
            b = false;
            Console.WriteLine(b);
            //b = "string";
            //b = 'c';
            //b = 0;
            //b = 1;
            //b = 100.0;
            bool b1 = true;
            bool b2 = true; ;
            //bool b3 = b1 + b2;
            Console.WriteLine(b1+b2);
        }
    }
}
