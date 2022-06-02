using MyLibrary;
using System;

namespace Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 25;
            int result;
            Console.WriteLine("demo assemblies my library ");
            result = a.add(b);
            Console.WriteLine($"{a}+{b}={result}");
            result = a.sub(b);
            Console.WriteLine($"{a}-{b}={result}");
        }
    }
}
