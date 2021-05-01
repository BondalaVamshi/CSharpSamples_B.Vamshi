using System;

namespace Extension_Methods
{
    public class class1
    {
        public void Message1()
        {

            Console.WriteLine("this is the message 1:\"hello all of you\"");
        }
    }
    public static class class2
    {
        public static void Message2(this class1 c1)
        {
            Console.WriteLine("this is Message 2:\"Best of luck....\"");
        }
    }
    public static class class3
    {
        public static void Message3(this class1 c1)
        {
            Console.WriteLine("this is Message 3:\"Future i on.....\"");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.Message1();
            c1.Message2();
            c1.Message3();
            Console.ReadKey();
        }
    }
}
