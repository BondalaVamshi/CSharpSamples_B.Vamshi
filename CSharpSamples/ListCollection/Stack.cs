using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ListCollection
{
    class StackClass
    {
        public void Create()
        {
            Stack s = new Stack();
            s.Push("a1");
            s.Push("a2");
            s.Push("a3");
            s.Push("a4");
            Console.WriteLine("stack values are");
            foreach(string st in s)
            {
                Console.WriteLine(st);
            }
            s.Pop();
            s.Pop();
            Console.WriteLine("stack valuesa fter pop are");
            foreach (string st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine($"this is the count :{s.Count}");
            Console.WriteLine($"this is peek value :{s.Peek()}");
            Stack s2 = s.Clone() as Stack;
            s2.Push("a5");
           
            foreach (string st in s2)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine($"this is the count of s2 :{s2.Count}");
            Console.WriteLine($"this is peek value  of s2:{s2.Peek()}");
            object[] o = new object[s2.Count];
            s2.CopyTo(o,0);
            Console.WriteLine("this is object values after copy");
            foreach (string st in o)
            {
                Console.WriteLine(st);
            }
            s2.Clear();

        }
    }
}
