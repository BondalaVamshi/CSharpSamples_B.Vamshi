using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Vehicle
    {
        public void Fuel()
        {
            Console.WriteLine("this is Fuel method");
        }
        abstract public void Ac();
        abstract public void PowerWindoews();
    }
    class SwiftCar : Vehicle
    {
        public override void Ac()
        {
            Console.WriteLine("Swift car Ac");
        }
        public override void PowerWindoews()
        {
            Console.WriteLine("Swift car Power Windows");    
        }
        public void SwiftFeatures()
        {
            Console.WriteLine("extra comfort is added");
        }
    }
}
