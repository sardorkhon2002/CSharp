using System;

namespace Practice_5_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            LaptopChild l = new LaptopChild();

            l.PrintDetails(LaptopChild.acer, LaptopChild.acer_p, LaptopChild.acer_i5, LaptopChild.acer_r, LaptopChild.acer_h);
            Console.WriteLine("*********************************************");

            l.PrintDetails(LaptopChild.hp, LaptopChild.hp_p, LaptopChild.hp_i3, LaptopChild.hp_r, LaptopChild.hp_h);
            Console.WriteLine("*********************************************");

            l.PrintDetails(LaptopChild.samsung, LaptopChild.samsung_p, LaptopChild.samsung_i7, LaptopChild.samsung_r, LaptopChild.samsung_h);
            Console.WriteLine("*********************************************");

            Console.ReadKey();

        }
    }

    class LaptopBase
    {
        public const string acer = "Acer";
        public const string hp = "HP";
        public const string samsung = "Samsung";

        public const string acer_p = "$350";
        public const string hp_p = "$450";
        public const string samsung_p = "$500";

        public const string acer_i5 = "i5-8th";
        public const string hp_i3 = "i3-8th";
        public const string samsung_i7 = "i7-8th";

        public const string acer_r = "8GB";
        public const string hp_r = "12GB";
        public const string samsung_r = "16GB";

        public const string acer_h = "1TB";
        public const string hp_h = "2TB";
        public const string samsung_h = "500GB";

    }

    class LaptopChild : LaptopBase
    {
        public void PrintDetails(string name, string price, string processor, string ram, string hardDrive)
        {
            Console.WriteLine("\nName: {0}", name);
            Console.WriteLine("Price: {0}", price);
            Console.WriteLine("Processor: {0}", processor);
            Console.WriteLine("Ram: {0}", ram);
            Console.WriteLine("Hard Drive: {0}\n", hardDrive);
        }
    }
}
