using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo
{
    static class MyStaticClass
    {
        public static void Func3(this Program p)
        {
            Console.WriteLine("This is the third function");
        }

    }
}
