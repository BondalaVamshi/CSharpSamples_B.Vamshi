using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Operators
    {
        public void Arithmatic()
        {
            int a = 10;
            int b = 15;

            char ch1 = 'a';
            char ch2 = 'b';

            string s1 = "this is";
            string s2 = "string";

            Console.WriteLine("this is \"arithmatic\" operator");
            int c;
            Console.WriteLine("this is addition(+)");
            Console.WriteLine(a + b);
            a = a + b;
            Console.WriteLine(a);
            s2 = s1 + s2;
            Console.WriteLine(s2);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("this is substraction(-)");
            a = a - b;
            Console.WriteLine(a);
            c = a - b;
            Console.WriteLine(c);
            //s2 = s1 - s2;
            //char ch1 = ch + ch1;
            //char ch1 = ch - ch1;
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("this is multiplication(*)");
            a = a * b;
            //ch = ch * ch1;
            //s1 = s1 * s2;
            Console.WriteLine(a);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("this is division(/)");
            a = a / b;
            Console.WriteLine(a);
            //ch = ch / ch1;
            //s1 = s1 / s2;

            Console.WriteLine("this is modulous(%)");
            a = a % b;
            Console.WriteLine(a);
            //ch = ch %ch1;
            //s1 = s1 % s2;
            Console.WriteLine("a+b*a :" + a + b * a);
            Console.WriteLine("(a+b)*a: " + (a + b) * a);
            Console.WriteLine("a+(b*a): " + a + (b * a));

        }
        public void Assignment()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"a:{a} b:{b}");
            a += b;
            Console.WriteLine("a += b :" + a);
            a *= b;
            Console.WriteLine("a *= b :" + a);
            a -= b;
            Console.WriteLine("a -= b :" + a);
            a /= b;
            Console.WriteLine("a /= b :" + a);
            a %= b;
            Console.WriteLine("a %= b :" + a);
            a = b;
            Console.WriteLine("a=b :" + a);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

        }

        public void Bitwise()
        {
            Console.WriteLine("enter value for a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value for b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a & b:{a&b}");
            Console.WriteLine($"a|b {a|b}");
            Console.WriteLine($"a^b  {a^b}");
            a &= b;
            Console.WriteLine($" a &= b: {a}");
            a |= b;
            Console.WriteLine($" a |= b: {a}");
            a ^= b;
            Console.WriteLine($"a^=b {a}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

        }
        public void Shift()
        {
            Console.WriteLine("this is shift");
            Console.WriteLine("enter value for INT a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value for INT b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a<<b :{a << b} ");
            Console.WriteLine($"a>>b :{a >> b} ");
            Console.WriteLine("enter value for INT a1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value for  INT b1");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a<<b :{a1 << b1} ");
            Console.WriteLine($"a<<b :{a1 >> b1} ");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

        }

        public void Comparision()
        {
            Console.WriteLine("this is comparision operator");
            int a = 10;
            int b = 20;
            Console.WriteLine($"a==b {a==b}");
            double d = 10.00;
            Console.WriteLine($" a:{a} b:{b} c:{d}");
            Console.WriteLine($"a==d {a == d}");
            char c1 = 'a';
            Console.WriteLine($"a==c1 {a == c1}");
            Console.WriteLine($"d==c1 {d == c1}");
            string s = "10";
            //Console.WriteLine($"a==s {a == s}");
            Console.WriteLine($"a==s {a == int.Parse(s)}");
            bool bo1 = true;
            int i1 = 1;
            // Console.WriteLine($"bo1==i1 {bo1 == i1}");
            Console.WriteLine($"bo1==i1 {bo1 == Convert.ToBoolean(i1)}");

            Console.WriteLine($"a==b {a==b}");
            Console.WriteLine($"a<b {a < b}");
            Console.WriteLine($"a<=b {a <= b}");
            Console.WriteLine($"a>b {a > b}");
            Console.WriteLine($"a>=b {a >= b}");
            Console.WriteLine($"a!=b {a != b}");

        }
        public void logical()
        {
            int a = 100;
            int b = 200;
            int c = 300;
            Console.WriteLine($"a:{a} b:{b} c:{c}");
            Console.WriteLine(a == b && b == c);
            Console.WriteLine($"a < b && b < c : {a < b && b < c}");
            Console.WriteLine(a > b && b > c);
            //Console.WriteLine(a > b and b > c);

            Console.WriteLine(a < b || b < c);
            Console.WriteLine(a < b || b > c);
            Console.WriteLine(a > b || b > c);
            //Console.WriteLine(a<b or a > c);

        }
        public void IncrementDecrement()
        {
            Console.WriteLine("this is increment and decrement operator");
            Console.WriteLine("enter the value for i");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine($"i : {i}");
            Console.WriteLine("post increment");
            Console.WriteLine(i++);
            Console.WriteLine("i :"+i);
            Console.WriteLine("pre increment");
            Console.WriteLine(++i);
            Console.WriteLine("i : "+i);
            Console.WriteLine("post decrement");
            Console.WriteLine(i--);
            Console.WriteLine("i :" + i);
            Console.WriteLine("pre decrement");
            Console.WriteLine(--i);
            Console.WriteLine("i :" + i);
        }
    }
}
