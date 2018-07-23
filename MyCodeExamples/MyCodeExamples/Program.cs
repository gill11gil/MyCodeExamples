using System;
using MyDesignPatterns.MyFactoryExample;
using MyDesignPatterns;

namespace MyCodeExamples
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    IFactory factory = new BoxFactory();

        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine(factory.GetBox(ProductTypes.Small).Title);
        //    }

        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine(factory.GetBox(ProductTypes.Medium).Title);
        //    }

        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine(factory.GetBox(ProductTypes.Large).Title);
        //    }
        //    Console.Read();
        //}
        static void Main(string[] args)
        {
            var instance1 = MySingletonClass.Instance;
            var instance2 = MySingletonClass.Instance;

            Console.WriteLine((instance1 == instance2) ? "Same" : "Different");
            Console.Read();
        }
    }
}
