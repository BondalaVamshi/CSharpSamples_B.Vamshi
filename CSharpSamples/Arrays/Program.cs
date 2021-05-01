using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleDimention singleDimention = new SingleDimention();
            singleDimention.Single();
            TwoDimention twoDimention = new TwoDimention();
            twoDimention.Two();
            Jogged jogged = new Jogged();
            jogged.VillNames();
        }
    }
}
