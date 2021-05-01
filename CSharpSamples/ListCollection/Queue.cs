using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ListCollection
{
    class QueueClass
    {
        public void Create()
        {
            Queue Q = new Queue();
            Q.Enqueue("z");
            Q.Enqueue("y");
            Q.Enqueue("zzzzz");
            Q.Enqueue("w");
            Console.WriteLine("queue values are");
            foreach(string st in Q)
            {
                Console.WriteLine(st);
            }
            Q.Dequeue();
            Q.Dequeue();
            Console.WriteLine("queue values after de queue are");
            foreach (string st in Q)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine($"peek values are:{Q.Peek()}");
            Console.WriteLine($"count of Q :{Q.Count}");
            Queue Q2 = Q.Clone() as Queue;
            Console.WriteLine("Q2 values are");
            foreach(string st in Q2)
            {
                Console.WriteLine(st);
            }
            Q.Clear();

        }
    }
}
