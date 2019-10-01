using System;
using System.Globalization;
using System.Resources;

namespace testMemStreamResXFileRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Resources.test;
            Console.WriteLine(test.GetType());

            ResourceManager resourceManager = new ResourceManager("testMemStreamResXFileRef.Resources", typeof(Resources).Assembly);
            var test2 = resourceManager.GetStream("test", CultureInfo.InvariantCulture);
            Console.WriteLine(test2.GetType());
        }
    }

}
