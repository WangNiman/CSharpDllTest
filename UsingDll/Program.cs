using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingDll
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary.Class1 Jack = new ClassLibrary.Class1("Jack");
            Jack.sayHello();
            Console.WriteLine("using successful!");
            Console.ReadKey();
        }
    }
}
