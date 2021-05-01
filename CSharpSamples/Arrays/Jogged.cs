using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Jogged
    {
        public void VillNames()
        {
            string[][] vName = new string[][]
                              { new string[] { "1", "hello", "all", "4 " },
                               new string[] {"2",  "hello","all" ,  "4"}
                              };
            Console.WriteLine("the array values are");
            for (int i = 0; i < vName.Length; i++)
            {
                for (int j = 0; j < vName[i].Length; j++)
                {
                    Console.WriteLine(vName[i][j]);
                }
            }
        }
    }

}
