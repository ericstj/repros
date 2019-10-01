using System;
using System.Globalization;
using System.IO;
using System.Resources;

namespace testMemStreamResXFileRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream test = Resources.test;
            Console.WriteLine(test.GetType());

            ResourceManager resourceManager = new ResourceManager("testMemStreamResXFileRef.Resources", typeof(Resources).Assembly);
            test = resourceManager.GetStream("test", CultureInfo.InvariantCulture);
            Console.WriteLine(test.GetType());

            Stream test2 = Resources.test2_0;
            Console.WriteLine(test2.GetType());

            test2 = resourceManager.GetStream("test", CultureInfo.InvariantCulture);
            Console.WriteLine(test2.GetType());
        }
    }

}
