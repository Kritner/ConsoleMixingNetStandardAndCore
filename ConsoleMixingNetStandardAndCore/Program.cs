using System;
using StandardLibrary;

namespace ConsoleMixingNetStandardAndCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 thingy = new Class1();
            Console.WriteLine(thingy.GetTextToOutput());
        }
    }
}
