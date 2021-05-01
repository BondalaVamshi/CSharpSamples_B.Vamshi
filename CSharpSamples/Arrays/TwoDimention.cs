using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class TwoDimention
    {
        public void Two()
        {
            Console.WriteLine("enter value for  r");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value for  c");
            int c = int.Parse(Console.ReadLine());

            //int r = 3, c = 2;
            int[,] two = new int[r, c];
            Console.WriteLine("enter values for array");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    two[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("your array values are");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine(two[i, j]);
                }
            }


            //// { {1,2,3,4 },{3,2,1,4} };

            ////int[] one = new int[] { 2,21,23,43,54};
            ////for(int i = 0; i < two.Length; i++)
            ////{
            ////    Console.WriteLine(one[i]);

            ////}
            //two[0, 0] = 2;
            //two[0, 1] = 3;
            //two[0, 2] = 43;
            //two[0, 3] = 2;
            //two[1, 0] = 22;
            //two[1, 1] = 112;
            //two[1, 2] = 122;
            //two[1, 3] = 121;
            //two[2, 0] = 231;
            //two[2, 1] = 561;
            //two[2, 2] = 561;
            //two[2, 3] = 541;
            //two[2, 0] = 1;
            ////Console.WriteLine("enter the{0}x{1} values into the 2 dimensional array",two.GetLength(0),two.GetLength(1));
            ////for (int i= 0;i<two.GetLength(0); i++)
            ////{
            ////for (int j= 0;j<two.GetLength(1); j++)
            ////    {
            ////       two[i,j]= int.Parse(Console.ReadLine());
            ////    }
            ////}

            //Console.WriteLine("array values are .....");
            //for (int i = 0; i < two.GetLength(0); i++)
            //{
            //    for (int j = 0; j < two.GetLength(1); j++)
            //    {
            //        Console.WriteLine((two[i, j]));
            //    }
            //}
        }
    }
}
