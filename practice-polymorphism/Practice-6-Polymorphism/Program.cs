using System;

namespace Practice_6_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            ch.Engine("40W", "20 r/m", 5);
            Console.ReadKey();
        }
        
    }
    public class Base
    {
        public virtual void Engine(string pof, string rpm, int noc)
        {
            Console.WriteLine("Power of engine is {0}\nRPM is {1}\nNo of Cylinder is {2}", pof, rpm, noc);
        }
    }
    public class Child : Base
    {
        public override void Engine(string pof, string rpm, int noc)
        {
            base.Engine(pof, rpm, noc);
            
            pof="60W";
            rpm = "50 r/m";
            noc = 15;
            Console.WriteLine("\n\nPower of engine is {0}\nRPM is {1}\nNo of Cylinder is {2}", pof, rpm, noc);
        }
    }
}