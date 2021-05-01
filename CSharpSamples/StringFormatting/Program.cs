using System;

namespace StringFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is  \"STRING\"");
            string s;
            //s = new string();    NOTE:there is no default parameter less contructor for string datatype 
            s = new string("this is connstructor");
            Console.WriteLine(s);
            string s1;
            //s1 = 100;
            //s1 = 100.0;
            s1 = "100.00";
            Console.WriteLine(  s1);
            //s1 = 's';
            s1 = "a";
            //s1 = 'abc';
            s1 = "this is string";
            Console.WriteLine(s1);
            Console.WriteLine("this is  console writing string");
            //s1 = true;
            s1 = null;
            Console.WriteLine(s1);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("string concatinating");
            string s2 = "hello";
            string s3 = "world";
            Console.WriteLine(s2+s3);

            Console.WriteLine(s2 + " " + s3);

            Console.WriteLine($"s1:{s1} s2:{s2} s3{s3}");

            Console.WriteLine("hello"+"world");

            s3 = "string" + "concatinate";

            Console.WriteLine(s3);
            Console.WriteLine(s3.Length);
            int si = s2.Length;
            Console.WriteLine("length of s2"+si);


        }
    }
}
