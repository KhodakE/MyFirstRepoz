using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFirstRepoz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jay");
            Console.WriteLine("Yes");
            Console.WriteLine("No");

            TestClass tc = new TestClass();
            tc.Name = "Hello";
            Console.WriteLine(tc.Name);
        }
    }
}
