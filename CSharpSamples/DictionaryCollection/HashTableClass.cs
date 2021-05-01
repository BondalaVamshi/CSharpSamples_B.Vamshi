using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace DictionaryCollection
{
    class HashTableClass
    {
        public void Create()
        {
            Hashtable H = new Hashtable();
            H.Add(1, "hello");
            H.Add(2, "hi");
            H.Add(3, "hmm");
            H.Add(4, "ahh");
            Console.WriteLine($"this is count of H {H.Count}");
            object[] o1 = new object[H.Count];
            H.CopyTo(o1, 0);
            Console.WriteLine(H.ContainsKey(1));
            Console.WriteLine(H.ContainsValue("hi"));
            Console.WriteLine(H.Contains(3));


        }
    }
}
