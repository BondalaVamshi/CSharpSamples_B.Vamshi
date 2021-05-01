using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ListCollection
{
    class ArrayListClass
    {
       public void Create()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("a1");
            arrayList.Add("b1");
            arrayList.Add("c1");
            arrayList.Add("1");
            arrayList.Add("c");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine(arrayList.Capacity);
            arrayList.Remove("c1");
            arrayList.RemoveAt(0);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            arrayList.Insert(0, "b2");
            foreach(string s in arrayList)
            {
                Console.WriteLine(s);
            }
            arrayList.Sort();
            Console.WriteLine("after sorting");
            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }
            arrayList.Reverse();
            Console.WriteLine("after reverse");
            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }
            ArrayList arrayList2 = arrayList.Clone() as ArrayList;
            arrayList2.Add("al1");
            arrayList2.Add("al2");
            Console.WriteLine("arrayList2 values");
            foreach (object o in arrayList2)
            {
                Console.WriteLine(o);
            }
            object[] o2 = new object[arrayList2.Count];
            arrayList2.CopyTo(o2, 0);
            Console.WriteLine("object o2 values");
            foreach (object o in o2)
            {
                Console.WriteLine(o);
            }
            arrayList2.Clear();
            foreach (object o in arrayList2)
            {
                Console.WriteLine(o);
            }

        }
    }
}
