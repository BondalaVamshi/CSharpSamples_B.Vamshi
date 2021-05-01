using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class ForEach
    {
        public void Names()
        {
            string[] name = new string[] {"Cognine","Pradeep","Sudheer","Srinivas" };
            foreach(string s in name)
            {
                Console.WriteLine("the name is :"+s);
            }
            int[] no = new int[] {1,2,3,4,5,5,6,7,78,6 };
            foreach(int i in no)
            {
                Console.WriteLine(i);
            }
        }
    }
}
