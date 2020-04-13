using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(432, 543));
            Console.ReadLine();
        }

        private static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
